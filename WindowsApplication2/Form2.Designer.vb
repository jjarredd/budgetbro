<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdReset = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.cmdColDown = New System.Windows.Forms.Label()
        Me.cmdColUp = New System.Windows.Forms.Label()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.chkYearly = New System.Windows.Forms.CheckBox()
        Me.chkMonthly = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkAutosave = New System.Windows.Forms.CheckBox()
        Me.chkAutoload = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.lstColumns = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "budgetBRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "program settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(507, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "x"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdReset)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 374)
        Me.Panel1.TabIndex = 1
        '
        'cmdReset
        '
        Me.cmdReset.AutoSize = True
        Me.cmdReset.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.Gold
        Me.cmdReset.Location = New System.Drawing.Point(9, 305)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(33, 13)
        Me.cmdReset.TabIndex = 10
        Me.cmdReset.Text = "RESET"
        '
        'cmdSave
        '
        Me.cmdSave.AutoSize = True
        Me.cmdSave.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(189, 304)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(32, 14)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "SAVE"
        '
        'cmdCancel
        '
        Me.cmdCancel.AutoSize = True
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Location = New System.Drawing.Point(236, 304)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(45, 14)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "CANCEL"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtFilename)
        Me.Panel2.Controls.Add(Me.cmdColDown)
        Me.Panel2.Controls.Add(Me.cmdColUp)
        Me.Panel2.Controls.Add(Me.chkAll)
        Me.Panel2.Controls.Add(Me.chkYearly)
        Me.Panel2.Controls.Add(Me.chkMonthly)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.chkAutosave)
        Me.Panel2.Controls.Add(Me.chkAutoload)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtDirectory)
        Me.Panel2.Controls.Add(Me.lstColumns)
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 245)
        Me.Panel2.TabIndex = 6
        '
        'txtFilename
        '
        Me.txtFilename.BackColor = System.Drawing.Color.DarkGray
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFilename.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFilename.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFilename.Location = New System.Drawing.Point(9, 223)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(270, 14)
        Me.txtFilename.TabIndex = 17
        Me.txtFilename.Text = "..."
        Me.txtFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdColDown
        '
        Me.cmdColDown.AutoSize = True
        Me.cmdColDown.Enabled = False
        Me.cmdColDown.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdColDown.ForeColor = System.Drawing.Color.Gold
        Me.cmdColDown.Location = New System.Drawing.Point(12, 111)
        Me.cmdColDown.Name = "cmdColDown"
        Me.cmdColDown.Size = New System.Drawing.Size(33, 13)
        Me.cmdColDown.TabIndex = 16
        Me.cmdColDown.Text = "down"
        Me.cmdColDown.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdColUp
        '
        Me.cmdColUp.AutoSize = True
        Me.cmdColUp.BackColor = System.Drawing.Color.DarkGray
        Me.cmdColUp.Enabled = False
        Me.cmdColUp.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdColUp.ForeColor = System.Drawing.Color.Gold
        Me.cmdColUp.Location = New System.Drawing.Point(12, 98)
        Me.cmdColUp.Name = "cmdColUp"
        Me.cmdColUp.Size = New System.Drawing.Size(19, 13)
        Me.cmdColUp.TabIndex = 15
        Me.cmdColUp.Text = "up"
        Me.cmdColUp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkAll
        '
        Me.chkAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAll.Checked = True
        Me.chkAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAll.Location = New System.Drawing.Point(239, 38)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(39, 25)
        Me.chkAll.TabIndex = 11
        Me.chkAll.Text = "all"
        Me.chkAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'chkYearly
        '
        Me.chkYearly.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkYearly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkYearly.Location = New System.Drawing.Point(189, 38)
        Me.chkYearly.Name = "chkYearly"
        Me.chkYearly.Size = New System.Drawing.Size(51, 25)
        Me.chkYearly.TabIndex = 10
        Me.chkYearly.Text = "yearly"
        Me.chkYearly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkYearly.UseVisualStyleBackColor = True
        '
        'chkMonthly
        '
        Me.chkMonthly.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkMonthly.Location = New System.Drawing.Point(108, 38)
        Me.chkMonthly.Name = "chkMonthly"
        Me.chkMonthly.Size = New System.Drawing.Size(82, 25)
        Me.chkMonthly.TabIndex = 9
        Me.chkMonthly.Text = "monthly"
        Me.chkMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMonthly.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "display mode:"
        '
        'chkAutosave
        '
        Me.chkAutosave.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAutosave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAutosave.Location = New System.Drawing.Point(9, 167)
        Me.chkAutosave.Name = "chkAutosave"
        Me.chkAutosave.Size = New System.Drawing.Size(269, 22)
        Me.chkAutosave.TabIndex = 7
        Me.chkAutosave.Text = "auto-save database when closing"
        Me.chkAutosave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAutosave.UseVisualStyleBackColor = True
        '
        'chkAutoload
        '
        Me.chkAutoload.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAutoload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAutoload.Location = New System.Drawing.Point(9, 195)
        Me.chkAutoload.Name = "chkAutoload"
        Me.chkAutoload.Size = New System.Drawing.Size(270, 22)
        Me.chkAutoload.TabIndex = 4
        Me.chkAutoload.Text = "auto-load database when program starts"
        Me.chkAutoload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAutoload.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "columns:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "default directory:"
        '
        'txtDirectory
        '
        Me.txtDirectory.BackColor = System.Drawing.Color.DarkGray
        Me.txtDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDirectory.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDirectory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirectory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDirectory.Location = New System.Drawing.Point(108, 17)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.ReadOnly = True
        Me.txtDirectory.Size = New System.Drawing.Size(171, 14)
        Me.txtDirectory.TabIndex = 1
        Me.txtDirectory.Text = "c:\program files\bro\budgetbro\"
        '
        'lstColumns
        '
        Me.lstColumns.BackColor = System.Drawing.Color.DarkGray
        Me.lstColumns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstColumns.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstColumns.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstColumns.FormattingEnabled = True
        Me.lstColumns.Items.AddRange(New Object() {"date", "entry", "category", "amount", "date added"})
        Me.lstColumns.Location = New System.Drawing.Point(108, 72)
        Me.lstColumns.Name = "lstColumns"
        Me.lstColumns.Size = New System.Drawing.Size(170, 80)
        Me.lstColumns.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 327)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bBro1.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents lstColumns As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkAutoload As CheckBox
    Friend WithEvents chkAutosave As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdReset As Label
    Friend WithEvents cmdSave As Label
    Friend WithEvents cmdCancel As Label
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkYearly As CheckBox
    Friend WithEvents chkMonthly As CheckBox
    Friend WithEvents cmdColDown As Label
    Friend WithEvents cmdColUp As Label
    Friend WithEvents txtFilename As TextBox
End Class
