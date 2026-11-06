"""Privacy regression checks for tracked project files.

These checks look for categories of personal data. They do not store
removed contact details or author names as expected literals.
"""

import re
import subprocess
import unittest
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]

EMAIL_RE = re.compile(r"\b[A-Za-z0-9._%+\-]+@[A-Za-z0-9.\-]+\.[A-Za-z]{2,}\b")
PHONE_RE = re.compile(
    r"(?<!\d)(?:\+\d{1,3}[\s.\-]?)?(?:\(\d{3}\)|\d{3})[\s.\-]\d{3}[\s.\-]\d{4}(?!\d)"
)
BYLINE_RE = re.compile(
    r"\bby\s+[A-Z][a-z]+(?:\s+[A-Z]\.)?(?:\s+[A-Z][a-z]+){1,3}\b"
)
SECRET_RE = re.compile(
    r"(?i)(BEGIN (?:RSA |OPENSSH |EC )?PRIVATE KEY|password\s*=\s*['\"][^'\"]+|api[_-]?key\s*[:=]\s*['\"][^'\"]+)"
)
BASE64_DATA_RE = re.compile(
    r'<data\b[^>]*mimetype="application/x-microsoft\.net\.object\.[^"]*base64"[^>]*>.*?</data>',
    re.DOTALL,
)


def tracked_files():
    result = subprocess.run(
        ["git", "ls-files", "-z"],
        cwd=ROOT,
        check=True,
        capture_output=True,
    )
    for name in result.stdout.decode("utf-8").split("\0"):
        if name:
            yield ROOT / name


def readable(path: Path) -> str:
    data = path.read_text(encoding="utf-8", errors="replace")
    if path.suffix.lower() == ".resx":
        data = BASE64_DATA_RE.sub("", data)
    return data


class PrivacyRegressionTests(unittest.TestCase):
    def test_tracked_files_have_no_personal_data_patterns(self):
        findings = []
        for path in tracked_files():
            text = readable(path)
            relative = path.relative_to(ROOT).as_posix()
            for label, pattern in (
                ("email", EMAIL_RE),
                ("phone", PHONE_RE),
                ("personal_byline", BYLINE_RE),
                ("secret", SECRET_RE),
            ):
                if pattern.search(text):
                    findings.append(f"{relative}: {label}")
        self.assertEqual(findings, [])

    def test_contact_override_is_gitignored(self):
        ignored = subprocess.run(
            ["git", "check-ignore", "-q", "contact.local.config"],
            cwd=ROOT,
        )
        self.assertEqual(ignored.returncode, 0)
        tracked = {path.relative_to(ROOT).as_posix() for path in tracked_files()}
        self.assertNotIn("contact.local.config", tracked)

    def test_contact_template_is_placeholder_only(self):
        template = (ROOT / "contact.local.config.template").read_text(encoding="utf-8")
        self.assertIn("REPLACE_WITH_DEPLOYMENT_PHONE", template)
        self.assertIsNone(PHONE_RE.search(template))
        self.assertIsNone(EMAIL_RE.search(template))
        app_config = (ROOT / "App.config").read_text(encoding="utf-8")
        self.assertRegex(app_config, r'key="ContactPhone"\s+value=""')

    def test_contact_number_is_not_hardcoded_in_source(self):
        source = (ROOT / "MainForm.vb").read_text(encoding="utf-8")
        self.assertIn("ConfiguredContactPhone()", source)
        self.assertIn("ContactPhone", source)
        self.assertIsNone(PHONE_RE.search(source))
        self.assertIsNone(BYLINE_RE.search(source))

    def test_product_workflow_is_preserved(self):
        designer = (ROOT / "MainForm.Designer.vb").read_text(encoding="utf-8")
        self.assertIn("Pat's Bike Shack", designer)
        charges = (ROOT / "ChargesModule.vb").read_text(encoding="utf-8")
        self.assertIn("Public Function CalcSubTotal()", charges)
        self.assertIn("g_decFRAMES_BMX", charges)
        self.assertIn("g_decSALES_TAX", charges)


if __name__ == "__main__":
    unittest.main()
