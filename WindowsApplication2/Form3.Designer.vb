<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProperties
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkHeaders = New System.Windows.Forms.CheckBox()
        Me.btnSelColor = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.chkAutoSave = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHint = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.chkPW = New System.Windows.Forms.CheckBox()
        Me.dataPreview = New System.Windows.Forms.DataGridView()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGridColor = New System.Windows.Forms.Button()
        Me.chkGrid = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBackColor = New System.Windows.Forms.Button()
        Me.btnForeColor = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdReset = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.clmTest1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTest2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTest3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dataPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.chkHeaders)
        Me.Panel1.Controls.Add(Me.btnSelColor)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.chkAutoSave)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtHint)
        Me.Panel1.Controls.Add(Me.txtPW)
        Me.Panel1.Controls.Add(Me.txtFile)
        Me.Panel1.Controls.Add(Me.chkPW)
        Me.Panel1.Controls.Add(Me.dataPreview)
        Me.Panel1.Controls.Add(Me.btnFont)
        Me.Panel1.Controls.Add(Me.txtBudget)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnGridColor)
        Me.Panel1.Controls.Add(Me.chkGrid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnBackColor)
        Me.Panel1.Controls.Add(Me.btnForeColor)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 189)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "––––––––––––––––––––––––––––––––––––"
        '
        'chkHeaders
        '
        Me.chkHeaders.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkHeaders.Location = New System.Drawing.Point(100, 160)
        Me.chkHeaders.Name = "chkHeaders"
        Me.chkHeaders.Size = New System.Drawing.Size(94, 23)
        Me.chkHeaders.TabIndex = 18
        Me.chkHeaders.Text = "column headers"
        Me.chkHeaders.UseVisualStyleBackColor = True
        '
        'btnSelColor
        '
        Me.btnSelColor.BackColor = System.Drawing.Color.LightGray
        Me.btnSelColor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSelColor.FlatAppearance.BorderSize = 0
        Me.btnSelColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelColor.Location = New System.Drawing.Point(150, 135)
        Me.btnSelColor.Name = "btnSelColor"
        Me.btnSelColor.Size = New System.Drawing.Size(19, 19)
        Me.btnSelColor.TabIndex = 17
        Me.btnSelColor.UseVisualStyleBackColor = False
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.DarkGray
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Gold
        Me.txtTitle.Location = New System.Drawing.Point(15, 6)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(179, 19)
        Me.txtTitle.TabIndex = 16
        Me.txtTitle.Text = "untitled"
        '
        'chkAutoSave
        '
        Me.chkAutoSave.AutoSize = True
        Me.chkAutoSave.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoSave.Location = New System.Drawing.Point(15, 59)
        Me.chkAutoSave.Name = "chkAutoSave"
        Me.chkAutoSave.Size = New System.Drawing.Size(182, 17)
        Me.chkAutoSave.TabIndex = 15
        Me.chkAutoSave.Text = "auto save when closing database"
        Me.chkAutoSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "hint:"
        '
        'txtHint
        '
        Me.txtHint.Enabled = False
        Me.txtHint.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHint.Location = New System.Drawing.Point(100, 97)
        Me.txtHint.Name = "txtHint"
        Me.txtHint.Size = New System.Drawing.Size(94, 21)
        Me.txtHint.TabIndex = 13
        '
        'txtPW
        '
        Me.txtPW.Enabled = False
        Me.txtPW.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(15, 97)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(82, 21)
        Me.txtPW.TabIndex = 12
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.DarkGray
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFile.Location = New System.Drawing.Point(15, 29)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(179, 14)
        Me.txtFile.TabIndex = 11
        Me.txtFile.Text = "c:\desktop"
        '
        'chkPW
        '
        Me.chkPW.Enabled = False
        Me.chkPW.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPW.Location = New System.Drawing.Point(15, 78)
        Me.chkPW.Name = "chkPW"
        Me.chkPW.Size = New System.Drawing.Size(94, 21)
        Me.chkPW.TabIndex = 10
        Me.chkPW.Text = "password"
        Me.chkPW.UseVisualStyleBackColor = True
        '
        'dataPreview
        '
        Me.dataPreview.AllowUserToAddRows = False
        Me.dataPreview.AllowUserToDeleteRows = False
        Me.dataPreview.AllowUserToResizeRows = False
        Me.dataPreview.BackgroundColor = System.Drawing.Color.White
        Me.dataPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataPreview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTest1, Me.clmTest2, Me.clmTest3})
        Me.dataPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataPreview.EnableHeadersVisualStyles = False
        Me.dataPreview.GridColor = System.Drawing.Color.White
        Me.dataPreview.Location = New System.Drawing.Point(205, 59)
        Me.dataPreview.MultiSelect = False
        Me.dataPreview.Name = "dataPreview"
        Me.dataPreview.ReadOnly = True
        Me.dataPreview.RowHeadersVisible = False
        Me.dataPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataPreview.Size = New System.Drawing.Size(177, 124)
        Me.dataPreview.TabIndex = 9
        '
        'btnFont
        '
        Me.btnFont.FlatAppearance.BorderSize = 0
        Me.btnFont.Location = New System.Drawing.Point(15, 133)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(82, 23)
        Me.btnFont.TabIndex = 0
        Me.btnFont.Text = "font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'txtBudget
        '
        Me.txtBudget.BackColor = System.Drawing.Color.DarkGray
        Me.txtBudget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBudget.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBudget.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtBudget.Location = New System.Drawing.Point(287, 6)
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.Size = New System.Drawing.Size(91, 20)
        Me.txtBudget.TabIndex = 8
        Me.txtBudget.Text = "$3000.00"
        Me.txtBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(301, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "monthly budget"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGridColor
        '
        Me.btnGridColor.BackColor = System.Drawing.Color.LightGray
        Me.btnGridColor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGridColor.FlatAppearance.BorderSize = 0
        Me.btnGridColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGridColor.Location = New System.Drawing.Point(175, 135)
        Me.btnGridColor.Name = "btnGridColor"
        Me.btnGridColor.Size = New System.Drawing.Size(19, 19)
        Me.btnGridColor.TabIndex = 5
        Me.btnGridColor.UseVisualStyleBackColor = False
        '
        'chkGrid
        '
        Me.chkGrid.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkGrid.Location = New System.Drawing.Point(15, 160)
        Me.chkGrid.Name = "chkGrid"
        Me.chkGrid.Size = New System.Drawing.Size(82, 23)
        Me.chkGrid.TabIndex = 4
        Me.chkGrid.Text = "grid"
        Me.chkGrid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkGrid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "____________________________________     ____________________________________"
        '
        'btnBackColor
        '
        Me.btnBackColor.BackColor = System.Drawing.Color.White
        Me.btnBackColor.FlatAppearance.BorderSize = 0
        Me.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackColor.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackColor.Location = New System.Drawing.Point(100, 135)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(19, 19)
        Me.btnBackColor.TabIndex = 3
        Me.btnBackColor.UseVisualStyleBackColor = False
        '
        'btnForeColor
        '
        Me.btnForeColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnForeColor.FlatAppearance.BorderSize = 0
        Me.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnForeColor.Location = New System.Drawing.Point(125, 135)
        Me.btnForeColor.Name = "btnForeColor"
        Me.btnForeColor.Size = New System.Drawing.Size(19, 19)
        Me.btnForeColor.TabIndex = 2
        Me.btnForeColor.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "file properties"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "budgetBRO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdReset)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdCancel)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 282)
        Me.Panel2.TabIndex = 2
        '
        'cmdReset
        '
        Me.cmdReset.AutoSize = True
        Me.cmdReset.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.Gold
        Me.cmdReset.Location = New System.Drawing.Point(12, 253)
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
        Me.cmdSave.Location = New System.Drawing.Point(281, 253)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(36, 14)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "APPLY"
        '
        'cmdCancel
        '
        Me.cmdCancel.AutoSize = True
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Location = New System.Drawing.Point(337, 253)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(45, 14)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "CANCEL"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(169, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 27)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(507, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "x"
        '
        'clmTest1
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clmTest1.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmTest1.HeaderText = " date"
        Me.clmTest1.Name = "clmTest1"
        Me.clmTest1.ReadOnly = True
        Me.clmTest1.Width = 60
        '
        'clmTest2
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clmTest2.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmTest2.HeaderText = "entry"
        Me.clmTest2.Name = "clmTest2"
        Me.clmTest2.ReadOnly = True
        Me.clmTest2.Width = 80
        '
        'clmTest3
        '
        Me.clmTest3.HeaderText = "category"
        Me.clmTest3.Name = "clmTest3"
        Me.clmTest3.ReadOnly = True
        '
        'frmProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 275)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProperties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFont As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackColor As Button
    Friend WithEvents btnForeColor As Button
    Friend WithEvents chkGrid As CheckBox
    Friend WithEvents btnGridColor As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdReset As Label
    Friend WithEvents cmdSave As Label
    Friend WithEvents cmdCancel As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBudget As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dataPreview As DataGridView
    Friend WithEvents chkPW As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHint As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtFile As TextBox
    Friend WithEvents chkAutoSave As CheckBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnSelColor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents chkHeaders As CheckBox
    Friend WithEvents clmTest1 As DataGridViewTextBoxColumn
    Friend WithEvents clmTest2 As DataGridViewTextBoxColumn
    Friend WithEvents clmTest3 As DataGridViewTextBoxColumn
End Class
