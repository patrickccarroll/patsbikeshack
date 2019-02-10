<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExtras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grbxDescription = New System.Windows.Forms.GroupBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grbxExtras = New System.Windows.Forms.GroupBox()
        Me.chkLights = New System.Windows.Forms.CheckBox()
        Me.chkPump = New System.Windows.Forms.CheckBox()
        Me.chkRegularHelmit = New System.Windows.Forms.CheckBox()
        Me.chkFullHelmit = New System.Windows.Forms.CheckBox()
        Me.grbxDescription.SuspendLayout()
        Me.grbxExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(301, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 68)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(47, 406)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 68)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add to Cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grbxDescription
        '
        Me.grbxDescription.Controls.Add(Me.lblDescription)
        Me.grbxDescription.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxDescription.Location = New System.Drawing.Point(12, 219)
        Me.grbxDescription.Name = "grbxDescription"
        Me.grbxDescription.Size = New System.Drawing.Size(458, 158)
        Me.grbxDescription.TabIndex = 5
        Me.grbxDescription.TabStop = False
        Me.grbxDescription.Text = "Description"
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(24, 28)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(412, 109)
        Me.lblDescription.TabIndex = 0
        '
        'grbxExtras
        '
        Me.grbxExtras.Controls.Add(Me.chkFullHelmit)
        Me.grbxExtras.Controls.Add(Me.chkRegularHelmit)
        Me.grbxExtras.Controls.Add(Me.chkPump)
        Me.grbxExtras.Controls.Add(Me.chkLights)
        Me.grbxExtras.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxExtras.Location = New System.Drawing.Point(12, 29)
        Me.grbxExtras.Name = "grbxExtras"
        Me.grbxExtras.Size = New System.Drawing.Size(458, 184)
        Me.grbxExtras.TabIndex = 4
        Me.grbxExtras.TabStop = False
        Me.grbxExtras.Text = "Select Extras"
        '
        'chkLights
        '
        Me.chkLights.AutoSize = True
        Me.chkLights.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLights.Location = New System.Drawing.Point(34, 38)
        Me.chkLights.Name = "chkLights"
        Me.chkLights.Size = New System.Drawing.Size(201, 28)
        Me.chkLights.TabIndex = 0
        Me.chkLights.Text = "Road Light Kit     $25"
        Me.chkLights.UseVisualStyleBackColor = True
        '
        'chkPump
        '
        Me.chkPump.AutoSize = True
        Me.chkPump.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPump.Location = New System.Drawing.Point(34, 72)
        Me.chkPump.Name = "chkPump"
        Me.chkPump.Size = New System.Drawing.Size(203, 28)
        Me.chkPump.TabIndex = 1
        Me.chkPump.Text = "Tire Pump Kit       $25"
        Me.chkPump.UseVisualStyleBackColor = True
        '
        'chkRegularHelmit
        '
        Me.chkRegularHelmit.AutoSize = True
        Me.chkRegularHelmit.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegularHelmit.Location = New System.Drawing.Point(34, 106)
        Me.chkRegularHelmit.Name = "chkRegularHelmit"
        Me.chkRegularHelmit.Size = New System.Drawing.Size(204, 28)
        Me.chkRegularHelmit.TabIndex = 2
        Me.chkRegularHelmit.Text = "Regular Helmit    $50"
        Me.chkRegularHelmit.UseVisualStyleBackColor = True
        '
        'chkFullHelmit
        '
        Me.chkFullHelmit.AutoSize = True
        Me.chkFullHelmit.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFullHelmit.Location = New System.Drawing.Point(34, 140)
        Me.chkFullHelmit.Name = "chkFullHelmit"
        Me.chkFullHelmit.Size = New System.Drawing.Size(213, 28)
        Me.chkFullHelmit.TabIndex = 3
        Me.chkFullHelmit.Text = "Full Face Helmit  $100"
        Me.chkFullHelmit.UseVisualStyleBackColor = True
        '
        'frmExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 503)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grbxDescription)
        Me.Controls.Add(Me.grbxExtras)
        Me.Name = "frmExtras"
        Me.Text = "Extras"
        Me.grbxDescription.ResumeLayout(False)
        Me.grbxExtras.ResumeLayout(False)
        Me.grbxExtras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grbxDescription As GroupBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents grbxExtras As GroupBox
    Friend WithEvents chkFullHelmit As CheckBox
    Friend WithEvents chkRegularHelmit As CheckBox
    Friend WithEvents chkPump As CheckBox
    Friend WithEvents chkLights As CheckBox
End Class
