<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditModifyEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataColumnsDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataColumnsEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataColumnsCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataColumnsAmount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataColumnsAdded = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDataColumnsReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataDisplaymodeMonthly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataDisplaymodeYearly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataDisplaymodeAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewGridlines = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAddEntry = New System.Windows.Forms.Label()
        Me.DBproperties = New System.Windows.Forms.ListView()
        Me.btnForward = New System.Windows.Forms.Label()
        Me.lvSettings = New System.Windows.Forms.ListView()
        Me.btnBack = New System.Windows.Forms.Label()
        Me.btnRange = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDeleteEntry = New System.Windows.Forms.Label()
        Me.btnEditEntry = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEntryOK = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmboCategory = New System.Windows.Forms.ComboBox()
        Me.txtEntry = New System.Windows.Forms.TextBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.xyList = New System.Windows.Forms.ListView()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.dataView = New System.Windows.Forms.DataGridView()
        Me.clmDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEntry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateAddedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clmAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAdded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlView.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEntry.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlControl.Controls.Add(Me.Button1)
        Me.pnlControl.Controls.Add(Me.btnMin)
        Me.pnlControl.Controls.Add(Me.MenuStrip1)
        Me.pnlControl.Controls.Add(Me.BtnAddEntry)
        Me.pnlControl.Controls.Add(Me.DBproperties)
        Me.pnlControl.Controls.Add(Me.btnForward)
        Me.pnlControl.Controls.Add(Me.lvSettings)
        Me.pnlControl.Controls.Add(Me.btnBack)
        Me.pnlControl.Controls.Add(Me.btnRange)
        Me.pnlControl.Controls.Add(Me.Button2)
        Me.pnlControl.Controls.Add(Me.Button3)
        Me.pnlControl.Controls.Add(Me.btnExit)
        Me.pnlControl.Controls.Add(Me.lblSubtitle)
        Me.pnlControl.Controls.Add(Me.lblTitle)
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(1784, 48)
        Me.pnlControl.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Test 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.AutoSize = True
        Me.btnMin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.LightGray
        Me.btnMin.Location = New System.Drawing.Point(492, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(13, 14)
        Me.btnMin.TabIndex = 22
        Me.btnMin.Text = "_"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.DATAToolStripMenuItem, Me.DATAToolStripMenuItem1, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(244, 14)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(228, 36)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 3
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.OpenToolStripMenuItem, Me.mnuFileSave, Me.mnuFileSaveAs, Me.SaveAsToolStripMenuItem, Me.mnuFileProperties, Me.mnuFileExit})
        Me.FILEToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(37, 17)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.BackColor = System.Drawing.Color.Black
        Me.mnuFileNew.ForeColor = System.Drawing.Color.Black
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(123, 22)
        Me.mnuFileNew.Text = "new"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(123, 22)
        Me.mnuFileSave.Text = "save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(123, 22)
        Me.mnuFileSaveAs.Text = "save as..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(120, 6)
        '
        'mnuFileProperties
        '
        Me.mnuFileProperties.Name = "mnuFileProperties"
        Me.mnuFileProperties.Size = New System.Drawing.Size(123, 22)
        Me.mnuFileProperties.Text = "properties"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(123, 22)
        Me.mnuFileExit.Text = "exit"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditModifyEntry, Me.DeleteEntryToolStripMenuItem, Me.ToolStripMenuItem3, Me.CategoriesToolStripMenuItem})
        Me.EDITToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(39, 17)
        Me.EDITToolStripMenuItem.Text = "&EDIT"
        '
        'mnuEditModifyEntry
        '
        Me.mnuEditModifyEntry.Name = "mnuEditModifyEntry"
        Me.mnuEditModifyEntry.Size = New System.Drawing.Size(154, 22)
        Me.mnuEditModifyEntry.Text = "amend entry"
        '
        'DeleteEntryToolStripMenuItem
        '
        Me.DeleteEntryToolStripMenuItem.Name = "DeleteEntryToolStripMenuItem"
        Me.DeleteEntryToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteEntryToolStripMenuItem.Text = "delete entry"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(151, 6)
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CategoriesToolStripMenuItem.Text = "rename category"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDataColumns, Me.DisplayModeToolStripMenuItem, Me.mnuViewGridlines, Me.mnuViewHeader})
        Me.DATAToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(43, 17)
        Me.DATAToolStripMenuItem.Text = "&VIEW"
        '
        'mnuDataColumns
        '
        Me.mnuDataColumns.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDataColumnsDate, Me.mnuDataColumnsEntry, Me.mnuDataColumnsCategory, Me.mnuDataColumnsAmount, Me.mnuDataColumnsAdded, Me.ToolStripMenuItem2, Me.mnuDataColumnsReset})
        Me.mnuDataColumns.Name = "mnuDataColumns"
        Me.mnuDataColumns.Size = New System.Drawing.Size(137, 22)
        Me.mnuDataColumns.Text = "columns"
        '
        'mnuDataColumnsDate
        '
        Me.mnuDataColumnsDate.CheckOnClick = True
        Me.mnuDataColumnsDate.Name = "mnuDataColumnsDate"
        Me.mnuDataColumnsDate.Size = New System.Drawing.Size(128, 22)
        Me.mnuDataColumnsDate.Text = "date"
        '
        'mnuDataColumnsEntry
        '
        Me.mnuDataColumnsEntry.CheckOnClick = True
        Me.mnuDataColumnsEntry.Name = "mnuDataColumnsEntry"
        Me.mnuDataColumnsEntry.Size = New System.Drawing.Size(128, 22)
        Me.mnuDataColumnsEntry.Text = "entry"
        '
        'mnuDataColumnsCategory
        '
        Me.mnuDataColumnsCategory.CheckOnClick = True
        Me.mnuDataColumnsCategory.Name = "mnuDataColumnsCategory"
        Me.mnuDataColumnsCategory.Size = New System.Drawing.Size(128, 22)
        Me.mnuDataColumnsCategory.Text = "category"
        '
        'mnuDataColumnsAmount
        '
        Me.mnuDataColumnsAmount.CheckOnClick = True
        Me.mnuDataColumnsAmount.Name = "mnuDataColumnsAmount"
        Me.mnuDataColumnsAmount.Size = New System.Drawing.Size(128, 22)
        Me.mnuDataColumnsAmount.Text = "amount"
        '
        'mnuDataColumnsAdded
        '
        Me.mnuDataColumnsAdded.CheckOnClick = True
        Me.mnuDataColumnsAdded.Name = "mnuDataColumnsAdded"
        Me.mnuDataColumnsAdded.Size = New System.Drawing.Size(128, 22)
        Me.mnuDataColumnsAdded.Text = "date added"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(125, 6)
        '
        'mnuDataColumnsReset
        '
        Me.mnuDataColumnsReset.Name = "mnuDataColumnsReset"
        Me.mnuDataColumnsReset.Size = New System.Drawing.Size(128, 22)
        Me.mnuDataColumnsReset.Text = "reset"
        '
        'DisplayModeToolStripMenuItem
        '
        Me.DisplayModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDataDisplaymodeMonthly, Me.mnuDataDisplaymodeYearly, Me.mnuDataDisplaymodeAll})
        Me.DisplayModeToolStripMenuItem.Name = "DisplayModeToolStripMenuItem"
        Me.DisplayModeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DisplayModeToolStripMenuItem.Text = "display mode"
        '
        'mnuDataDisplaymodeMonthly
        '
        Me.mnuDataDisplaymodeMonthly.Name = "mnuDataDisplaymodeMonthly"
        Me.mnuDataDisplaymodeMonthly.Size = New System.Drawing.Size(113, 22)
        Me.mnuDataDisplaymodeMonthly.Text = "monthly"
        '
        'mnuDataDisplaymodeYearly
        '
        Me.mnuDataDisplaymodeYearly.Name = "mnuDataDisplaymodeYearly"
        Me.mnuDataDisplaymodeYearly.Size = New System.Drawing.Size(113, 22)
        Me.mnuDataDisplaymodeYearly.Text = "yearly"
        '
        'mnuDataDisplaymodeAll
        '
        Me.mnuDataDisplaymodeAll.Name = "mnuDataDisplaymodeAll"
        Me.mnuDataDisplaymodeAll.Size = New System.Drawing.Size(113, 22)
        Me.mnuDataDisplaymodeAll.Text = "all"
        '
        'mnuViewGridlines
        '
        Me.mnuViewGridlines.CheckOnClick = True
        Me.mnuViewGridlines.Name = "mnuViewGridlines"
        Me.mnuViewGridlines.Size = New System.Drawing.Size(137, 22)
        Me.mnuViewGridlines.Text = "gridlines"
        '
        'mnuViewHeader
        '
        Me.mnuViewHeader.CheckOnClick = True
        Me.mnuViewHeader.Name = "mnuViewHeader"
        Me.mnuViewHeader.Size = New System.Drawing.Size(137, 22)
        Me.mnuViewHeader.Text = "header"
        '
        'DATAToolStripMenuItem1
        '
        Me.DATAToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DATAToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatsToolStripMenuItem})
        Me.DATAToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.DATAToolStripMenuItem1.Name = "DATAToolStripMenuItem1"
        Me.DATAToolStripMenuItem1.Size = New System.Drawing.Size(41, 17)
        Me.DATAToolStripMenuItem1.Text = "&DATA"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.StatsToolStripMenuItem.Text = "stats..."
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.HELPToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(42, 17)
        Me.HELPToolStripMenuItem.Text = "&HELP"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "about"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SettingsToolStripMenuItem.Text = "settings..."
        '
        'BtnAddEntry
        '
        Me.BtnAddEntry.AutoSize = True
        Me.BtnAddEntry.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddEntry.ForeColor = System.Drawing.Color.White
        Me.BtnAddEntry.Location = New System.Drawing.Point(216, 14)
        Me.BtnAddEntry.Name = "BtnAddEntry"
        Me.BtnAddEntry.Size = New System.Drawing.Size(17, 19)
        Me.BtnAddEntry.TabIndex = 20
        Me.BtnAddEntry.Text = "+"
        Me.BtnAddEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DBproperties
        '
        Me.DBproperties.BackColor = System.Drawing.Color.Gray
        Me.DBproperties.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBproperties.ForeColor = System.Drawing.Color.Gray
        Me.DBproperties.Location = New System.Drawing.Point(932, 8)
        Me.DBproperties.Name = "DBproperties"
        Me.DBproperties.Size = New System.Drawing.Size(93, 24)
        Me.DBproperties.TabIndex = 7
        Me.DBproperties.UseCompatibleStateImageBehavior = False
        Me.DBproperties.View = System.Windows.Forms.View.List
        Me.DBproperties.Visible = False
        '
        'btnForward
        '
        Me.btnForward.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForward.ForeColor = System.Drawing.Color.White
        Me.btnForward.Location = New System.Drawing.Point(180, 12)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(24, 24)
        Me.btnForward.TabIndex = 19
        Me.btnForward.Text = ">"
        Me.btnForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvSettings
        '
        Me.lvSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSettings.ForeColor = System.Drawing.Color.Gray
        Me.lvSettings.LabelWrap = False
        Me.lvSettings.Location = New System.Drawing.Point(796, 4)
        Me.lvSettings.MultiSelect = False
        Me.lvSettings.Name = "lvSettings"
        Me.lvSettings.Scrollable = False
        Me.lvSettings.Size = New System.Drawing.Size(124, 28)
        Me.lvSettings.TabIndex = 6
        Me.lvSettings.UseCompatibleStateImageBehavior = False
        Me.lvSettings.View = System.Windows.Forms.View.List
        Me.lvSettings.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(108, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(24, 24)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "<"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRange
        '
        Me.btnRange.BackColor = System.Drawing.Color.Transparent
        Me.btnRange.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRange.ForeColor = System.Drawing.Color.Honeydew
        Me.btnRange.Location = New System.Drawing.Point(128, 12)
        Me.btnRange.Name = "btnRange"
        Me.btnRange.Size = New System.Drawing.Size(56, 20)
        Me.btnRange.TabIndex = 17
        Me.btnRange.Text = "ALL"
        Me.btnRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(664, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 24)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(728, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 20)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "month"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.LightGray
        Me.btnExit.Location = New System.Drawing.Point(508, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(13, 14)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "x"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Honeydew
        Me.lblSubtitle.Location = New System.Drawing.Point(8, 26)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(96, 13)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "one.three"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(96, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "budgetBRO*"
        '
        'btnDeleteEntry
        '
        Me.btnDeleteEntry.AutoSize = True
        Me.btnDeleteEntry.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEntry.ForeColor = System.Drawing.Color.White
        Me.btnDeleteEntry.Location = New System.Drawing.Point(312, 4)
        Me.btnDeleteEntry.Name = "btnDeleteEntry"
        Me.btnDeleteEntry.Size = New System.Drawing.Size(15, 18)
        Me.btnDeleteEntry.TabIndex = 15
        Me.btnDeleteEntry.Text = "x"
        '
        'btnEditEntry
        '
        Me.btnEditEntry.FlatAppearance.BorderSize = 0
        Me.btnEditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditEntry.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEntry.ForeColor = System.Drawing.Color.White
        Me.btnEditEntry.Location = New System.Drawing.Point(244, 0)
        Me.btnEditEntry.Name = "btnEditEntry"
        Me.btnEditEntry.Size = New System.Drawing.Size(40, 23)
        Me.btnEditEntry.TabIndex = 21
        Me.btnEditEntry.Text = "EDIT"
        Me.btnEditEntry.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.ForeColor = System.Drawing.Color.White
        Me.btnData.Location = New System.Drawing.Point(340, 4)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(38, 16)
        Me.btnData.TabIndex = 15
        Me.btnData.Text = "DATA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(396, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "CONFIG"
        '
        'btnEntryOK
        '
        Me.btnEntryOK.Location = New System.Drawing.Point(500, 4)
        Me.btnEntryOK.Name = "btnEntryOK"
        Me.btnEntryOK.Size = New System.Drawing.Size(36, 21)
        Me.btnEntryOK.TabIndex = 7
        Me.btnEntryOK.Text = "ADD"
        Me.btnEntryOK.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(444, 4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(52, 21)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmboCategory
        '
        Me.cmboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmboCategory.FormattingEnabled = True
        Me.cmboCategory.Location = New System.Drawing.Point(300, 4)
        Me.cmboCategory.Name = "cmboCategory"
        Me.cmboCategory.Size = New System.Drawing.Size(140, 21)
        Me.cmboCategory.Sorted = True
        Me.cmboCategory.TabIndex = 3
        Me.cmboCategory.Text = "category"
        '
        'txtEntry
        '
        Me.txtEntry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtEntry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtEntry.BackColor = System.Drawing.Color.White
        Me.txtEntry.Location = New System.Drawing.Point(92, 5)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.ShortcutsEnabled = False
        Me.txtEntry.Size = New System.Drawing.Size(204, 21)
        Me.txtEntry.TabIndex = 2
        Me.txtEntry.Text = "entry"
        Me.txtEntry.WordWrap = False
        '
        'datePicker
        '
        Me.datePicker.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker.CustomFormat = "MM/dd/yyyy"
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datePicker.Location = New System.Drawing.Point(0, 4)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(84, 21)
        Me.datePicker.TabIndex = 1
        '
        'pnlView
        '
        Me.pnlView.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlView.Controls.Add(Me.Panel3)
        Me.pnlView.Controls.Add(Me.pnlEntry)
        Me.pnlView.Controls.Add(Me.pnlStatus)
        Me.pnlView.Controls.Add(Me.dataView)
        Me.pnlView.Location = New System.Drawing.Point(0, 40)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(1496, 684)
        Me.pnlView.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.xyList)
        Me.Panel3.Controls.Add(Me.Chart2)
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Location = New System.Drawing.Point(556, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(932, 648)
        Me.Panel3.TabIndex = 17
        '
        'xyList
        '
        Me.xyList.BackColor = System.Drawing.Color.DimGray
        Me.xyList.Location = New System.Drawing.Point(4, 428)
        Me.xyList.MultiSelect = False
        Me.xyList.Name = "xyList"
        Me.xyList.Size = New System.Drawing.Size(924, 192)
        Me.xyList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.xyList.TabIndex = 15
        Me.xyList.UseCompatibleStateImageBehavior = False
        Me.xyList.View = System.Windows.Forms.View.Details
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.DimGray
        Me.Chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.Chart2.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Inclination = 10
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.PointDepth = 50
        ChartArea1.Area3DStyle.Rotation = 10
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelAutoFitMaxFontSize = 8
        ChartArea1.AxisX.LabelAutoFitMinFontSize = 8
        ChartArea1.AxisX.LabelAutoFitStyle = CType(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LabelStyle.Interval = 1.0R
        ChartArea1.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorTickMark.Enabled = False
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX.MinorGrid.LineWidth = 0
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.ScaleView.MinSize = 1.0R
        ChartArea1.AxisX.ScaleView.Position = 0R
        ChartArea1.AxisX.ScaleView.SmallScrollSize = 1.0R
        ChartArea1.AxisX2.IsLabelAutoFit = False
        ChartArea1.AxisX2.LabelAutoFitMaxFontSize = 8
        ChartArea1.AxisX2.LabelAutoFitMinFontSize = 8
        ChartArea1.AxisX2.LabelAutoFitStyle = CType((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30 Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea1.AxisX2.LabelStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.IsStartedFromZero = False
        ChartArea1.AxisY.LabelAutoFitMaxFontSize = 8
        ChartArea1.AxisY.LabelAutoFitMinFontSize = 8
        ChartArea1.AxisY.LabelAutoFitStyle = CType(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.Interval = 0R
        ChartArea1.AxisY.LabelStyle.IntervalOffset = 0R
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.TruncatedLabels = True
        ChartArea1.AxisY.MajorGrid.Interval = 0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackColor = System.Drawing.Color.Gray
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.BorderWidth = 0
        ChartArea1.CursorX.Position = 0R
        ChartArea1.IsSameFontSizeForAllAxes = True
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Me.Chart2.Location = New System.Drawing.Point(4, 4)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(544, 416)
        Me.Chart2.TabIndex = 16
        Me.Chart2.Text = "Chart2"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.DimGray
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.White
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderlineWidth = 0
        ChartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Location = New System.Drawing.Point(556, 4)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
        Series2.Color = System.Drawing.Color.Gold
        Series2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.LegendText = "Legend"
        Series2.Name = "Series2"
        Series2.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(372, 416)
        Me.Chart1.TabIndex = 12
        Me.Chart1.Text = "Chart1"
        '
        'pnlEntry
        '
        Me.pnlEntry.Controls.Add(Me.Panel1)
        Me.pnlEntry.Controls.Add(Me.btnEntryOK)
        Me.pnlEntry.Controls.Add(Me.datePicker)
        Me.pnlEntry.Controls.Add(Me.txtEntry)
        Me.pnlEntry.Controls.Add(Me.cmboCategory)
        Me.pnlEntry.Controls.Add(Me.txtAmount)
        Me.pnlEntry.Location = New System.Drawing.Point(8, 8)
        Me.pnlEntry.Name = "pnlEntry"
        Me.pnlEntry.Size = New System.Drawing.Size(540, 33)
        Me.pnlEntry.TabIndex = 12
        Me.pnlEntry.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 20)
        Me.Panel1.TabIndex = 8
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.btnData)
        Me.pnlStatus.Controls.Add(Me.Label2)
        Me.pnlStatus.Controls.Add(Me.btnDeleteEntry)
        Me.pnlStatus.Controls.Add(Me.lblTotal)
        Me.pnlStatus.Controls.Add(Me.btnEditEntry)
        Me.pnlStatus.Controls.Add(Me.lblIndex)
        Me.pnlStatus.Controls.Add(Me.lblCounter)
        Me.pnlStatus.Location = New System.Drawing.Point(0, 660)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1072, 23)
        Me.pnlStatus.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblTotal.Location = New System.Drawing.Point(434, 3)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 13)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "($) 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.ForeColor = System.Drawing.Color.Gray
        Me.lblIndex.Location = New System.Drawing.Point(81, 3)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(13, 13)
        Me.lblIndex.TabIndex = 10
        Me.lblIndex.Text = "0"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.ForeColor = System.Drawing.Color.Gray
        Me.lblCounter.Location = New System.Drawing.Point(3, 3)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(49, 13)
        Me.lblCounter.TabIndex = 9
        Me.lblCounter.Text = "0 (t0) 0/0"
        '
        'dataView
        '
        Me.dataView.AllowUserToAddRows = False
        Me.dataView.AllowUserToDeleteRows = False
        Me.dataView.AllowUserToOrderColumns = True
        Me.dataView.AllowUserToResizeColumns = False
        Me.dataView.AllowUserToResizeRows = False
        Me.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataView.BackgroundColor = System.Drawing.Color.DimGray
        Me.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDate, Me.clmEntry, Me.clmCategory, Me.clmAmount, Me.clmAdded})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataView.DefaultCellStyle = DataGridViewCellStyle5
        Me.dataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dataView.EnableHeadersVisualStyles = False
        Me.dataView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dataView.Location = New System.Drawing.Point(8, 8)
        Me.dataView.MultiSelect = False
        Me.dataView.Name = "dataView"
        Me.dataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataView.RowHeadersVisible = False
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Goldenrod
        Me.dataView.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataView.Size = New System.Drawing.Size(540, 648)
        Me.dataView.TabIndex = 5
        '
        'clmDate
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmDate.FillWeight = 203.0457!
        Me.clmDate.HeaderText = "date"
        Me.clmDate.MinimumWidth = 80
        Me.clmDate.Name = "clmDate"
        Me.clmDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'clmEntry
        '
        Me.clmEntry.FillWeight = 65.65144!
        Me.clmEntry.HeaderText = "entry"
        Me.clmEntry.Name = "clmEntry"
        '
        'clmCategory
        '
        Me.clmCategory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.clmCategory.FillWeight = 65.65144!
        Me.clmCategory.HeaderText = "category"
        Me.clmCategory.Name = "clmCategory"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem, Me.EntryToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.AToolStripMenuItem, Me.DateAddedToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 114)
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DateToolStripMenuItem.Text = "date"
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.EntryToolStripMenuItem.Text = "entry"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CategoryToolStripMenuItem.Text = "category"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AToolStripMenuItem.Text = "amount"
        '
        'DateAddedToolStripMenuItem
        '
        Me.DateAddedToolStripMenuItem.Name = "DateAddedToolStripMenuItem"
        Me.DateAddedToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DateAddedToolStripMenuItem.Text = "date added"
        '
        'clmAmount
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmAmount.FillWeight = 65.65144!
        Me.clmAmount.HeaderText = "amount"
        Me.clmAmount.MinimumWidth = 80
        Me.clmAmount.Name = "clmAmount"
        '
        'clmAdded
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmAdded.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmAdded.HeaderText = "added"
        Me.clmAdded.Name = "clmAdded"
        Me.clmAdded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmAdded.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(537, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "_________________________________________________________________________________" &
    "_________________________"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(530, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 322)
        Me.Panel2.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1496, 829)
        Me.Controls.Add(Me.pnlView)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "budgetBRO"
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlView.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlEntry.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlControl As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlView As Panel
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents txtEntry As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataView As DataGridView
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnEntryOK As Button
    Friend WithEvents btnExit As Label
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCounter As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblIndex As Label
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents DeleteEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTotal As Label
    Friend WithEvents DisplayModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDataDisplaymodeMonthly As ToolStripMenuItem
    Friend WithEvents mnuDataDisplaymodeYearly As ToolStripMenuItem
    Friend WithEvents mnuDataDisplaymodeAll As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateAddedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDataColumns As ToolStripMenuItem
    Friend WithEvents mnuDataColumnsDate As ToolStripMenuItem
    Friend WithEvents mnuDataColumnsEntry As ToolStripMenuItem
    Friend WithEvents mnuDataColumnsCategory As ToolStripMenuItem
    Friend WithEvents mnuDataColumnsAmount As ToolStripMenuItem
    Friend WithEvents mnuDataColumnsAdded As ToolStripMenuItem
    Friend WithEvents mnuEditModifyEntry As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuDataColumnsReset As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvSettings As ListView
    Friend WithEvents DATAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuViewGridlines As ToolStripMenuItem
    Friend WithEvents DBproperties As ListView
    Friend WithEvents mnuFileProperties As ToolStripMenuItem
    Friend WithEvents mnuViewHeader As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents xyList As ListView
    Friend WithEvents btnForward As Label
    Friend WithEvents btnBack As Label
    Friend WithEvents btnRange As Label
    Friend WithEvents BtnAddEntry As Label
    Friend WithEvents pnlEntry As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEditEntry As Button
    Friend WithEvents btnData As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMin As Label
    Friend WithEvents btnDeleteEntry As Label
    Friend WithEvents cmboCategory As ComboBox
    Friend WithEvents clmDate As DataGridViewTextBoxColumn
    Friend WithEvents clmEntry As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents clmAmount As DataGridViewTextBoxColumn
    Friend WithEvents clmAdded As DataGridViewTextBoxColumn
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
End Class
