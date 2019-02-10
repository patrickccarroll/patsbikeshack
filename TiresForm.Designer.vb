<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTires
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grbxDescription = New System.Windows.Forms.GroupBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grbxTires = New System.Windows.Forms.GroupBox()
        Me.lstTires = New System.Windows.Forms.ListBox()
        Me.grbxDescription.SuspendLayout()
        Me.grbxTires.SuspendLayout()
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
        Me.grbxDescription.Location = New System.Drawing.Point(12, 235)
        Me.grbxDescription.Name = "grbxDescription"
        Me.grbxDescription.Size = New System.Drawing.Size(458, 142)
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
        Me.lblDescription.Size = New System.Drawing.Size(412, 97)
        Me.lblDescription.TabIndex = 0
        '
        'grbxTires
        '
        Me.grbxTires.Controls.Add(Me.lstTires)
        Me.grbxTires.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxTires.Location = New System.Drawing.Point(12, 29)
        Me.grbxTires.Name = "grbxTires"
        Me.grbxTires.Size = New System.Drawing.Size(458, 200)
        Me.grbxTires.TabIndex = 4
        Me.grbxTires.TabStop = False
        Me.grbxTires.Text = "Select a Tire Set"
        '
        'lstTires
        '
        Me.lstTires.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTires.FormattingEnabled = True
        Me.lstTires.ItemHeight = 24
        Me.lstTires.Items.AddRange(New Object() {"Knobby    $30", "Slick          $40", "Hybrid      $50", "Racing      $60"})
        Me.lstTires.Location = New System.Drawing.Point(24, 49)
        Me.lstTires.Name = "lstTires"
        Me.lstTires.Size = New System.Drawing.Size(412, 124)
        Me.lstTires.TabIndex = 4
        '
        'frmTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 503)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grbxDescription)
        Me.Controls.Add(Me.grbxTires)
        Me.Name = "frmTires"
        Me.Text = "Tires"
        Me.grbxDescription.ResumeLayout(False)
        Me.grbxTires.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grbxDescription As GroupBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents grbxTires As GroupBox
    Friend WithEvents lstTires As ListBox
End Class
