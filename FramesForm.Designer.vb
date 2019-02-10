<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrames
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbxFrames = New System.Windows.Forms.GroupBox()
        Me.lstFrames = New System.Windows.Forms.ListBox()
        Me.grbxDescription = New System.Windows.Forms.GroupBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grbxFrames.SuspendLayout()
        Me.grbxDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbxFrames
        '
        Me.grbxFrames.Controls.Add(Me.lstFrames)
        Me.grbxFrames.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxFrames.Location = New System.Drawing.Point(12, 27)
        Me.grbxFrames.Name = "grbxFrames"
        Me.grbxFrames.Size = New System.Drawing.Size(458, 200)
        Me.grbxFrames.TabIndex = 0
        Me.grbxFrames.TabStop = False
        Me.grbxFrames.Text = "Select a Frame"
        '
        'lstFrames
        '
        Me.lstFrames.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFrames.FormattingEnabled = True
        Me.lstFrames.ItemHeight = 24
        Me.lstFrames.Items.AddRange(New Object() {"BMX Ripper                 $125", "Mountain Crusher    $250", "Beach Cruiser             $175", "Road Master               $325"})
        Me.lstFrames.Location = New System.Drawing.Point(24, 49)
        Me.lstFrames.Name = "lstFrames"
        Me.lstFrames.Size = New System.Drawing.Size(412, 124)
        Me.lstFrames.TabIndex = 4
        '
        'grbxDescription
        '
        Me.grbxDescription.Controls.Add(Me.lblDescription)
        Me.grbxDescription.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxDescription.Location = New System.Drawing.Point(12, 233)
        Me.grbxDescription.Name = "grbxDescription"
        Me.grbxDescription.Size = New System.Drawing.Size(458, 165)
        Me.grbxDescription.TabIndex = 1
        Me.grbxDescription.TabStop = False
        Me.grbxDescription.Text = "Description"
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(24, 24)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(412, 116)
        Me.lblDescription.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(47, 404)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 68)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to Cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(301, 404)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 68)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmFrames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 503)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grbxDescription)
        Me.Controls.Add(Me.grbxFrames)
        Me.Name = "frmFrames"
        Me.Text = "Frames"
        Me.grbxFrames.ResumeLayout(False)
        Me.grbxDescription.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbxFrames As GroupBox
    Friend WithEvents grbxDescription As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstFrames As ListBox
    Friend WithEvents lblDescription As Label
End Class
