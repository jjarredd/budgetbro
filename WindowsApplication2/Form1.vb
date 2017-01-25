Imports System.IO
Public Class Form1

    Dim settingsPath As String = Application.StartupPath & "\73884647.bb1"

    ' -dreamincode.net/forums/topic/135768-moving-a-borderless-form/
    Dim cursMove As Boolean
    Dim cursX As Integer
    Dim cursY As Integer

    'lvSettings
    ' 0  default directory
    ' 1  display mode (narrow value)
    ' 2  colum order, visibity, width (0True125)
    ' 3  auto save (checkstate)
    ' 4  auto load (checkstate) | filepath (C:\)

    'DBproperties
    ' 0  filepath
    ' 1  title 
    ' 2  budget
    ' 3  autosave
    ' 4  req pw
    ' 5  pw
    ' 6  hint
    ' 7  font
    ' 8  fontsize
    ' 9  backcolor
    ' 10 forecolor
    ' 11 selcolor
    ' 12 gridcolor
    ' 13 grids
    ' 14 header
    ' 15 last display mode

    Public Sub chartDraw(pointsList As ListView)


        Chart1.Series.Clear()

        For l = 1 To xyList.Columns.Count - 1
            Dim seriesString As String = "z" & l
            Chart1.Series.Add(seriesString)
            '
            For i = 0 To xyList.Items.Count - 1
                Dim xStr As String = pointsList.Items(i).Text
                Dim yStr As String = pointsList.Items(i).SubItems(l).Text
                Dim zStr As String = pointsList.Columns.Item(l).Text
                Chart1.Series(seriesString).Points.AddXY(xStr, yStr)
                Chart1.Series(seriesString).ChartType = DataVisualization.Charting.SeriesChartType.StackedColumn
                '!legend
            Next i
            '
        Next l


    End Sub

    Public Sub chartDraw_TotalByDay(pointsList As ListView)

        '# chart data: total amount per day (daily total)

        '# reset chart
        Chart2.Series.Clear()

        '# 
        Dim seriesString As String = "z"
        Chart2.Series.Add(seriesString)
        '
        For i = 0 To xyList.Items.Count - 2 'change back to 1 if you're not going to maintain totals
            Dim xStr As String = pointsList.Items(i).Text
            Dim yStr As String = pointsList.Items(i).SubItems(xyList.Columns.Count - 1).Text
            'MsgBox(xStr & ", " & yStr) 'expect this to return date & daily total
            Dim zStr As String = "Daily Total"
            Chart2.Series(seriesString).Points.AddXY(xStr, yStr)
            Chart2.Series(seriesString).ChartType = DataVisualization.Charting.SeriesChartType.StackedArea

            '!legend (zStr)
        Next i



    End Sub
    Public Sub chartDraw_RunningTotal(pointsList As ListView)

        '# chart data: running total by date

        ' Reset chart.
        Chart2.Series.Clear()

        ' 
        Dim seriesString As String = "z"
        Dim addStr As Decimal = 0
        Chart2.Series.Add(seriesString)
        ' 
        For i = 0 To xyList.Items.Count - 2
            Dim xStr As String = pointsList.Items(i).Text
            Dim yStr As Decimal = pointsList.Items(i).SubItems(xyList.Columns.Count - 1).Text
            addStr = addStr + +yStr
            'MsgBox(xStr & ", " & yStr) 'expect this to return date & daily total
            Dim zStr As String = "Daily Total"
            Chart2.Series(seriesString).Points.AddXY(xStr, addStr)
            Chart2.Series(seriesString).ChartType = DataVisualization.Charting.SeriesChartType.StackedArea

            '!legend (zStr)
        Next i



    End Sub
    Public Sub chartDraw_TotalsByCategory(pointsList As ListView)


        '# chart data: total amount per category

        Chart2.Series.Clear()

        For l = 1 To xyList.Columns.Count - 2
            Dim seriesString As String = "z" & l
            Chart2.Series.Add(seriesString)
            '
            For i = 0 To xyList.Items.Count - 2 'change back to 1 if you're not going to maintain totals
                Dim xStr As String = pointsList.Items(i).Text
                Dim yStr As String = pointsList.Items(i).SubItems(l).Text
                Dim zStr As String = pointsList.Columns.Item(l).Text
                Chart2.Series(seriesString).Points.AddXY(xStr, yStr)
                Chart2.Series(seriesString).ChartType = DataVisualization.Charting.SeriesChartType.Bar
                'Chart2.ChartAreas.Item(1).AxisY.Interval = 10
                'Chart2.ChartAreas.Item(1).AxisY.Maximum = 100
                Chart2.Series(seriesString).Points(i).AxisLabel = xStr & "   "


                ' chartArea.AxisX.Minimum = 0;
                ' chartArea.AxisX.Maximum = valuesArray.Length;
                '!legend
            Next i
            '
        Next l

        Chart2.ChartAreas.Item(0).AxisX.Maximum = xyList.Items.Count - 2
        xyList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)



    End Sub
    Public Function chkDBaltered() As Boolean


        ' Determines if database has been altered since last save by 
        ' checking if window title ends w/ asterisk; see setDBaltered.

        ' Always return True unless the window title ends with an asterisk. 
        chkDBaltered = True
        If lblTitle.Text.EndsWith("*") = True Then chkDBaltered = False


    End Function
    Public Function chkDBexisting() As Boolean


        ' Determines if database currently in use is an existing file by 
        ' referencing DBproperties(filePath); see mnuFileNew_Click.

        ' Always return True unless DBproperties(filePath) value contains ">".
        chkDBexisting = True
        If DBproperties.Items.Item(0).Text.Contains(">") = True Then chkDBexisting = False


    End Function
    Public Function DBcloseAction() As String


        ' Determines action when closing current DB based on chkDBexisting variable and
        ' DBproperties(autosave) setting. Called when starting new or opening existing
        ' database or exiting the program.

        ' Set defaults.
        Dim qPrompt As Boolean = False
        DBcloseAction = "Close"

        ' If database has not been altered, do nothing; return "Close". Otherwise, check if DB file exists to determine action.
        If Not chkDBaltered() = True Then
        Else

            ' If DB file does not exist, prompt user for action. Otherwise, refer to DBproperties(Autosave) to determine action.
            If Not chkDBexisting() = True Then
                qPrompt = True
            Else

                ' If Autosave is off, prompt user for action. Otherwise, return "Save".
                If DBproperties.Items.Item(3).Text = 0 Then
                    qPrompt = True
                Else
                    DBcloseAction = "Save"
                End If
            End If

            ' Prompt user if DB file does not exist or if Autosave is turned off.
            If qPrompt = True Then
                Dim mResult = MsgBox("Save data before closing?", vbYesNoCancel)
                If mResult = MsgBoxResult.Yes Then DBcloseAction = "Save"
                If mResult = MsgBoxResult.Cancel Then DBcloseAction = "Cancel"
            End If

        End If


    End Function
    Public Sub DBload(filePath As String)


        ' Loads existing database.

        ' Open file and copy each line to readArray list.
        Dim readArray As New ListView
        Dim fPath As String = filePath
        Dim fReader As StreamReader
        fReader = File.OpenText(fPath)
        While fReader.Peek <> -1
            readArray.Items.Add(fReader.ReadLine)
        End While
        fReader.Dispose()

        ' Cut properties section from readArray and copy to DBproperties list.
        DBproperties.Items.Clear()
        DBproperties.Items.Add(filePath)
        Do While readArray.Items(0).Text.StartsWith("|") = False
            DBproperties.Items.Add(readArray.Items(0).Text)
            readArray.Items.RemoveAt(0)
        Loop

        ' Update dataView columns (Line 1) & cell contents (remaining Lines) from readArray.
        resetEntryFields(True)
        For i = 0 To readArray.Items.Count - 1
            If i = 0 Then
                setDGVcolumns(readArray.Items(i).Text)
            Else
                Dim cSplit As String() = (readArray.Items(i).Text.Trim("|")).Split("|")
                Dim cList As List(Of String) = cSplit.ToList
                With dataView
                    .Rows.Add()
                    .Rows.Item(i - 1).Tag = cList(5)
                    For k = 0 To .Columns.Count - 1
                        .Item(k, .Rows.Count - 1).Value = cList(k)
                        ' Update auto-complete collections and cmboCategory drop down list.
                        If k = clmEntry.DisplayIndex Then txtEntry.AutoCompleteCustomSource.Add(cList(k))
                        If k = clmCategory.DisplayIndex Then
                            If Not cmboCategory.Items.Contains(cList(k)) = True Then
                                cmboCategory.Items.Add(cList(k))
                                cmboCategory.AutoCompleteCustomSource.Add(cList(k))
                            End If
                        End If
                    Next k
                End With
            End If
        Next i

        ' Set dataView appearance as specified in DBproperties.
        ' !password
        lblSubtitle.Text = DBproperties.Items.Item(1).Text
        dataView.Font = setFont(DBproperties.Items.Item(7).Text, DBproperties.Items.Item(8).Text, False, False) '!fix font styles
        setDGVcolors(DBproperties.Items.Item(9).Text, DBproperties.Items.Item(10).Text, DBproperties.Items.Item(11).Text)
        setDGVgridlines(DBproperties.Items.Item(13).Text, getColor(DBproperties.Items.Item(12).Text))
        mnuViewHeader.Checked = DBproperties.Items.Item(14).Text
        Dim dgvMode As Integer = DBproperties.Items.Item(15).Text

        ' If no visible data, set range to ALL. Otherwise, refer to 
        If dataView.RowCount > 0 And dataView.DisplayedRowCount(True) = 0 Then
            setDGVrange(0)
        Else
            setDGVrange(dgvMode)
        End If

        ' Set ChangedStatus variable since this is a fresh load.
        setDBaltered(False)


    End Sub
    Public Sub DBsave(Optional filePath As String = Nothing)


        ' Save current database.

        ' maybe do this instead of current saveaction function
        '        ' If filePath is left blank, and DB file does not exist, then prompt for filePath.
        '        If filePath = Nothing Then
        '            If Not chkDBexisting() = True Then
        '                'saveDialog
        '            Else
        '                'if autosave is on then save"
        '
        '        ' Otherwise, reference DBproperties(filePath)
        '        filePath = DBproperties.Items.Item(0).Text
        '    End If
        'End If

        ' Write file properties to fileString.
        Dim fileString As String = ""
        For i = 1 To 12
            fileString = fileString & DBproperties.Items.Item(i).Text & vbNewLine
        Next i
        fileString = fileString & mnuViewGridlines.Checked & vbNewLine                                  ' 13 grids | headers
        fileString = fileString & mnuViewHeader.Checked & vbNewLine
        fileString = fileString & getDGVmode() & vbNewLine                                              ' 8 last display mode

        ' Write column properties and database contents to fileString.
        Dim clmOrder As String = ""
        For Each column As DataGridViewColumn In dataView.Columns
            clmOrder = clmOrder & column.DisplayIndex & column.Displayed & column.Width & "|"           ' 0 |0True125|1True125|
        Next
        fileString = fileString & "|" & clmOrder & vbNewLine
        For Each row As DataGridViewRow In dataView.Rows ' cell data
            Dim rowString As String = "|"
            For Each cell As DataGridViewCell In dataView.Rows(row.Index).Cells
                rowString = rowString & cell.Value & "|"                                                ' i |date|entry|category|amount|added|
            Next
            rowString = rowString & row.Tag & "|"
            fileString = fileString & rowString & vbNewLine
        Next

        ' Save fileString to file.
        Dim fWriter As New IO.StreamWriter(filePath)
        fWriter.Write(fileString)
        fWriter.Dispose()


    End Sub
    Public Function DBsaveAction() As String


        ' Determines action when saving current DB based on chkDBexisting variable. When
        ' DBexisting = False, prompt user for filePath. Otherwise, save current. Called 
        ' when saving current database via Menu > File > Save and DBcloseAction function.

        ' If database file does not exist, prompt user for filepath. Otherwise, save current.
        DBsaveAction = "Cancel"
        If Not chkDBexisting() = True Then
            Dim saveDlg As New SaveFileDialog
            saveDlg.InitialDirectory = lvSettings.Items(0).Text
            saveDlg.Filter = "BRO Files (*.br0)|*.br0"
            If saveDlg.ShowDialog() = DialogResult.Cancel Then
                Exit Function
            Else
                DBproperties.Items.Item(0).Text = LCase(saveDlg.FileName)
                DBsaveAction = "New."
            End If
        End If

        ' Save database file and update altered status.
        DBsave(DBproperties.Items.Item(0).Text)
        setDBaltered(False)
        DBsaveAction = "Existing"


    End Function

    Public Function getColor(clrString As String) As Color


        ' Split data string " Then Then2550.255.255" to determine RGB values and convert to useable color.

        Dim rgbSplit As String() = clrString.Split(".")
        Dim rgbList As List(Of String) = rgbSplit.ToList
        getColor = Color.FromArgb(rgbSplit(0), rgbSplit(1), rgbSplit(2))


    End Function
    Public Function getDGVmode() As Integer


        ' Determines display mode; see setDGVrange sub.

        If mnuDataDisplaymodeMonthly.Checked = True Then
            getDGVmode = 2
        Else
            getDGVmode = mnuDataDisplaymodeYearly.CheckState
        End If


    End Function
    Public Sub resetEntryFields(Optional fullReset As Boolean = Nothing)


        '# reset form after add/modify entry, also used when loading or starting a new database

        ' Reset entry field values.
        txtEntry.Text = "entry"
        cmboCategory.Text = "category"
        txtAmount.Text = "0.00"
        lblTotal.Text = getTotalAmount()

        ' Reset date, category combo drop down list, and auto-complete values if starting or loading new database.
        If fullReset = True Then
            datePicker.Value = Date.Today
            txtEntry.AutoCompleteCustomSource.Clear()
            cmboCategory.AutoCompleteCustomSource.Clear()
            cmboCategory.Items.Clear()
            dataView.Rows.Clear()
        End If

        ' Apply ADD appearance to fields in case it was in EDIT mode.
        txtEntry.BackColor = Color.White
        cmboCategory.BackColor = Color.White
        txtAmount.BackColor = Color.White
        btnEntryOK.Text = "ADD"

        ' Update form.
        dataView.Enabled = True
        MenuStrip1.Enabled = True


    End Sub
    Public Sub setDBaltered(status As Boolean)


        ' Sets ChangedStatus; see chkDBaltered function.
        ' Window title ends with asterisk (*) by default. 
        ' When an entry is added, modified, or deleted, or if the database properties are edited, asterisk is removed.
        ' When a database is saved or loaded, asterisk is added.

        lblTitle.Text = lblTitle.Text.Trim("*")
        If status = False Then lblTitle.Text = lblTitle.Text & "*"


    End Sub
    Public Function setColorStr(clr As Color) As String


        '# convert Color to RGB data string (R.G.B)
        setColorStr = clr.R & "." & clr.G & "." & clr.B


    End Function
    Public Sub setDGVcolors(backRGB As String, foreRGB As String, selRGB As String)


        '# set dataView appearance: backcolors, forecolors
        dataView.BackgroundColor = getColor(backRGB)
        dataView.RowsDefaultCellStyle.BackColor = getColor(backRGB)
        dataView.RowsDefaultCellStyle.SelectionBackColor = getColor(backRGB)
        dataView.RowsDefaultCellStyle.SelectionForeColor = getColor(selRGB)
        dataView.ForeColor = getColor(foreRGB)


    End Sub
    Public Sub setDGVcolumns(StringToSplit As String) '|0True98|1True223|2True108|3True84|4False100|


        ' Set order, visibility, and width of columns in dataView.

        ' Split string into corresponding columns.
        Dim cSplit As String() = StringToSplit.Trim("|").Split("|")
        Dim cList As List(Of String) = cSplit.ToList
        ' For each split-string, isolate values and apply to dataView.
        For i = 0 To dataView.Columns.Count - 1
            Dim clmString As String = cList(i)
            Dim clmOrder As String = clmString.First
            Dim clmWidth As String = Mid(clmString, InStr(clmString, "e") + 1)
            With dataView.Columns(i)
                .DisplayIndex = clmOrder
                If clmString.Contains("False") Then
                    .Visible = False
                Else
                    .Visible = True
                End If
                .Width = clmWidth
            End With
        Next

        ' Update menuStrip checkmarks.
        mnuDataColumnsDate.Checked = clmDate.Visible
        mnuDataColumnsEntry.Checked = clmEntry.Visible
        mnuDataColumnsCategory.Checked = clmCategory.Visible
        mnuDataColumnsAmount.Checked = clmAmount.Visible
        mnuDataColumnsAdded.Checked = clmAdded.Visible


    End Sub
    Public Sub setDGVgridlines(YesNo As Boolean, Optional gColor As Color = Nothing)


        'If YesNo = Nothing Then
        ' If dataView.GridColor = dataView.BackgroundColor Then YesNo = True Else YesNo = False
        ' End If

        Select Case YesNo
            Case True
                If gColor = Nothing Then
                    If DBproperties.Items.Count = 0 Then
                        gColor = Color.LightGray
                    Else
                        gColor = getColor(DBproperties.Items.Item(12).Text)
                    End If
                End If
            Case False
                gColor = dataView.BackgroundColor
        End Select

        dataView.GridColor = gColor
        mnuViewGridlines.Checked = YesNo


    End Sub
    Public Sub setDGVrange(narrowVal As Integer)


        '!USE MIKEYS TIMESTAMP
        ' Set display mode according to narrowVal. See getDGVmode function.
        ' 0 = none
        ' 1 = yearly
        ' 2 = monthly

        ' If there is no data, do nothing. Otherwise, go through each index <i> in [dataView] row collection, get value of [clmDate]
        ' cell <dateVal>, and format it into a numerically sequential representation <dataVal>. Set boolean <hideRow> false by default.
        ' Determine match requirements by <narrowVal> (year or month AND year). Set boolean <hideRow> true if <dataVal> date(s) does not 
        ' match up to [datePicker] date(s). Set row visibility by <hideRow> value.

        If dataView.Rows.Count = 0 Then
        Else
            For i = 0 To dataView.Rows.Count - 1
                Dim dateVal As Date = dataView.Item(clmDate.Name, i).Value
                Dim dataVal As String = Format(dateVal, "yyyyMMdd")
                Dim hideRow As Boolean = False
                Select Case narrowVal
                    Case 1 'year
                        If Not Mid(dataVal, 1, 4) = datePicker.Value.Year Then hideRow = True
                    Case 2 'month
                        If Not Mid(dataVal, 1, 4) = datePicker.Value.Year Then hideRow = True
                        If Not Mid(dataVal, 5, 2) = datePicker.Value.Month Then hideRow = True
                End Select
                If hideRow = True Then
                    dataView.Rows.Item(i).Visible = False
                Else
                    dataView.Rows.Item(i).Visible = True
                End If
            Next
        End If
        lblTotal.Text = getTotalAmount() ' Recount total.

        ' Update menu checkmarks and btnMode text.
        mnuDataDisplaymodeAll.Checked = False
        mnuDataDisplaymodeYearly.Checked = False
        mnuDataDisplaymodeMonthly.Checked = False
        Dim dmode As String = "ERR"
        Select Case narrowVal
            Case 0
                mnuDataDisplaymodeAll.Checked = True
                dmode = "ALL"
            Case 1
                mnuDataDisplaymodeYearly.Checked = True
                dmode = datePicker.Value.Year
            Case 2
                mnuDataDisplaymodeMonthly.Checked = True
                dmode = UCase(DateAndTime.MonthName(datePicker.Value.Month, True))
        End Select
        btnRange.Text = dmode


    End Sub
    Public Function setFont(ByVal fontName As String, ByVal fontSize As Integer, ByVal isBold As Boolean, ByVal isItalic As Boolean) As Drawing.Font


        ' thanks Philip Fourie @ stackoverflow.com/questions/1350993/vb-net-how-to-compose-and-apply-a-font-to-a-label-in-runtime

        Dim styles As FontStyle = FontStyle.Regular
        If (isBold) Then
            styles = styles Or FontStyle.Bold
        End If
        If (isItalic) Then
            styles = styles Or FontStyle.Italic
        End If
        Dim newFont As New Drawing.Font(fontName, fontSize, styles)
        Return newFont


    End Function
    Public Sub setPoints(sourceView As DataGridView, xColumn As DataGridViewColumn, pointsList As ListView)


        '# setup pointsList with columns: category name, total amount, total transactions
        pointsList.Items.Clear()
        pointsList.Columns.Clear()
        For h = 0 To 2
            pointsList.Columns.Add(h)
        Next

        '# fill pointsList
        For i = 0 To dataView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1
            Dim varAddNew As Boolean = True
            Dim xStr = dataView.Item(xColumn.Name, i).Value
            Dim yStr = dataView.Item(clmAmount.Name, i).Value
            '
            If Not pointsList.Items.Count = 0 Then
                ' does item already exist in xyList?
                If pointsList.FindItemWithText(xStr, False, 0, False) IsNot Nothing Then
                    'if yes, modify item
                    Dim yIndex As Integer = pointsList.FindItemWithText(xStr, False, 0, False).Index
                    Dim curAmt As Decimal = pointsList.Items(yIndex).SubItems(1).Text
                    Dim curCnt As Integer = pointsList.Items(yIndex).SubItems(2).Text
                    pointsList.Items(yIndex).SubItems(1).Text = Val(curAmt) + Val(yStr.trim("$"))
                    pointsList.Items(yIndex).SubItems(2).Text = curCnt + 1
            varAddNew = False
        End If
        End If
            '
            If varAddNew = True Then
                'if no, add new item
                Dim nuItem As New ListViewItem
                nuItem.Text = (xStr)
                nuItem.SubItems.Add(yStr)
                nuItem.SubItems.Add("1")
                pointsList.Items.Add(nuItem)
            End If
            '
        Next i

    End Sub
    Public Sub setPoints2(sourceView As DataGridView, xColumn As DataGridViewColumn, pointsList As ListView)

        '# setup pointsList
        pointsList.Items.Clear()
        pointsList.Columns.Clear()
        pointsList.Columns.Add(xColumn.HeaderText)
        For c = 0 To cmboCategory.Items.Count - 1
            pointsList.Columns.Add(cmboCategory.Items.Item(c))
        Next c

        '# process each row in dataView collection one-by-one to determine visibility
        Dim visCount As Integer = dataView.Rows.GetRowCount(DataGridViewElementStates.Visible)
        For i = 0 To dataView.Rows.Count - 1
            '
            '# if visible, grab data and determine if xPoint already exists
            If dataView.Rows.Item(i).Visible = True Then
                '
                Dim xExists As Boolean = False  ' does not exist by default
                '
                Dim xStr = dataView.Item(xColumn.Name, i).Value ' xStr = date
                Dim yStr = dataView.Item(clmAmount.Name, i).Value
                Dim zStr = dataView.Item(clmCategory.Name, i).Value
                '
                If Not pointsList.Items.Count = 0 Then  ' if pointsList is empty, xPoint does not exist by default
                    '
                    '# if xPoint does exist, modify item
                    If pointsList.FindItemWithText(xStr, False, 0, False) IsNot Nothing Then
                        Dim xIndex As Integer = pointsList.FindItemWithText(xStr, False, 0, False).Index
                        '
                        For k = 1 To pointsList.Columns.Count - 1
                            '
                            If pointsList.Columns(k).Text = zStr Then
                                pointsList.Items(xIndex).SubItems().Item(k).Text = Val(xyList.Items(xIndex).SubItems().Item(k).Text) + Val(yStr.trim("$"))
                            End If
                            '
                        Next k
                        '
                        xExists = True
                    End If
                End If
                '
                '# if xPoint does not exists, add new item
                If xExists = False Then
                    Dim nuItem As New ListViewItem
                    nuItem.Text = (xStr)
                    '
                    For j = 1 To pointsList.Columns.Count - 1
                        nuItem.SubItems.Add("0")
                        '
                        If pointsList.Columns(j).Text = zStr Then
                            nuItem.SubItems(j).Text = Val(yStr.trim("$"))
                        End If
                        '
                    Next j
                    '
                    pointsList.Items.Add(nuItem)
                End If
                '
            End If
            '
        Next i

        '__________________totals__
        'i think this can be done while building list to speed up process

        Dim clmArray As New ArrayList
        For tclm = 1 To pointsList.Columns.Count - 1
            clmArray.Add("0")
        Next


        pointsList.Columns.Add("TOTAL")

        '# process each row in pointsList one-by-one
        For row = 0 To pointsList.Items.Count - 1
            Dim rowTotal As Decimal = 0, clmTotal As Decimal = 0
            ' get sum of values from each columns within specific row to determine total daily amount
            For clm = 1 To pointsList.Columns.Count - 2
                Dim xyVal As Decimal = pointsList.Items.Item(row).SubItems(clm).Text
                rowTotal = rowTotal + xyVal
                'clmTotal = clmTotal + xyVal
                clmArray.Item(clm - 1) = Val(clmArray.Item(clm - 1)) + xyVal
            Next clm
            ' display total daily amount at end of row
            pointsList.Items.Item(row).SubItems.Add(rowTotal)

        Next row

        Dim totItem As New ListViewItem

        totItem.Text = "TOTAL"
        For y = 0 To clmArray.Count - 1
            totItem.SubItems.Add(clmArray.Item(y))
        Next



        'For y = 1 To pointsList.Columns.Count - 1
        ' Dim dailyTally As Decimal = 0
        ' For x = 0 To pointsList.Items.Count - 1
        ' Dim dailyAmount As Decimal = pointsList.Items.Item(x).SubItems(y).Text
        ' dailyTally = dailyTally + dailyAmount
        ' Next x
        ' totItem.SubItems.Add(dailyTally)
        'Next y
        pointsList.Items.Add(totItem)

        '___________________________




    End Sub
    Public Sub sortDGVbyDate()


        'Sort dataView sequentially by date.

        ' For each row in dataView, reformat clmDate value to numerically sequential representation (20160101). 
        For i = 0 To dataView.RowCount - 1
            Dim curVal As Date = dataView.Item(clmDate.Name, i).Value
            Dim nuVal As String = Format(curVal, "yyyyMMdd")
            dataView.Item(clmDate.Name, i).Value = nuVal
        Next i

        ' Resort in same direction.
        If dataView.SortOrder = 1 Then
            dataView.Sort(clmDate, System.ComponentModel.ListSortDirection.Ascending)
        Else
            dataView.Sort(clmDate, System.ComponentModel.ListSortDirection.Descending)
        End If
        clmDate.SortMode = DataGridViewColumnSortMode.Automatic
        clmDate.SortMode = DataGridViewColumnSortMode.Programmatic

        ' For each row in dataView, revert clmDate value back to traditional US date format (01/01/2016).
        For j = 0 To dataView.RowCount - 1
            Dim curVal2 As String = dataView.Item(clmDate.Name, j).Value
            Dim nuYear As String, nuMonth As String, nuDay As String
            nuYear = Mid(dataView.Item(clmDate.Name, j).Value, 1, 4)
            nuMonth = Mid(dataView.Item(clmDate.Name, j).Value, 5, 2)
            nuDay = Mid(dataView.Item(clmDate.Name, j).Value, 7, 2)
            dataView.Item(clmDate.Name, j).Value = nuMonth & "/" & nuDay & "/" & nuYear
        Next j


    End Sub

    Public Function getTotalAmount() As String


        '# visCount = number of rows currently visible in dataView to be processed
        Dim visCount As Integer = dataView.Rows.GetRowCount(DataGridViewElementStates.Visible)
        Dim nTotal As Decimal = 0

        '# process all rows in dataView collection
        For i = 0 To dataView.Rows.Count - 1
            '
            ' if specified row is currently visible, add amount to total
            If dataView.Rows.Item(i).Visible = True Then
                Dim nAmount As Decimal = dataView.Rows.Item(i).Cells(clmAmount.Name).Value
                nTotal = (nTotal) + (nAmount)
                visCount = visCount - 1
            End If
            '
            ' if all visible rows have been processed, skip remaining rows in collection 
            If visCount = 0 Then i = dataView.Rows.Count - 1
            '
        Next i
        '# return total
        getTotalAmount = FormatCurrency(nTotal)


    End Function
    Public Function totalAmountByDay()


        '# add value in "amount" column line by line and return sum in currency format
        Dim nAmount As Decimal, nTotal As Decimal = 0
        For i = 0 To dataView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1
            nAmount = dataView.Item(clmAmount.Name, i).Value
            nTotal = nTotal + nAmount
        Next i

        totalAmountByDay = FormatCurrency(nTotal, 2)


    End Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Load form, start program.

        ' If this is the first time the program has been loaded, 
        ' create default settings file and welcome user.
        If File.Exists(settingsPath) = False Then
            Dim fWriter As New IO.StreamWriter(settingsPath)
            fWriter.WriteLine(Application.StartupPath & "\")
            fWriter.WriteLine("0")
            fWriter.WriteLine("0True108|1True175|2True142|3True78|4True100")
            fWriter.WriteLine("0")
            fWriter.WriteLine("0|...")
            fWriter.Dispose()
            MsgBox("Sup, Bro.")
        End If

        ' Open settings file and copy to lvSettings reference list.
        Dim fReader As New StreamReader(settingsPath)
        fReader = File.OpenText(settingsPath)
        While fReader.Peek <> -1
            lvSettings.Items.Add(fReader.ReadLine)
        End While
        fReader.Dispose()

        ' Auto-load database if called for in lvSettings.
        If lvSettings.Items(4).Text.StartsWith("1") = True Then
            Dim fPath As String = Mid(lvSettings.Items(4).Text, 3)      'autoload
            If File.Exists(fPath) = False Then
                MsgBox(fPath & vbNewLine & vbNewLine & "Autoload failed. Refer To settings.", MsgBoxStyle.Exclamation, "sorry bro.")
            Else
                DBload(fPath)
            End If
        Else
            mnuFileNew_Click(sender, e) 'do we need this? its already new right?
        End If

        ' Correct form size from changes made while 
        ' working in designer.
        'Me.Width = (dataView.Location.X) * 2 + dataView.Width
        Me.Height = pnlView.Location.Y + pnlView.Height


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEntryOK.Click


        ' Add/edit entry.

        ' Fix blank fields to meet convention and prevent errors.
        If cmboCategory.Text = "category" Or cmboCategory.Text = "" Then cmboCategory.Text = "none"
        If txtAmount.Text = "" Then txtAmount.Text = "0.00"

        ' Set target row.
        Dim dgvRow As DataGridViewRow
        If btnEntryOK.Text = "ADD" Then
            dataView.Rows.Add()
            dgvRow = dataView.Rows.Item(dataView.Rows.Count - 1)
        Else
            dgvRow = dataView.SelectedRows(0)
        End If

        ' Set row values and update auto-complete collections. !need to make it update category drop down list
        dgvRow.Cells(clmDate.Name).Value = Format(datePicker.Value.Date, "MM/dd/yyyy")
        dgvRow.Cells(clmEntry.Name).Value = txtEntry.Text
        txtEntry.AutoCompleteCustomSource.Add(txtEntry.Text)
        dgvRow.Cells(clmCategory.Name).Value = cmboCategory.Text
        cmboCategory.AutoCompleteCustomSource.Add(cmboCategory.Text)
        If Not cmboCategory.Items.Contains(cmboCategory.Text) = True Then cmboCategory.Items.Add(cmboCategory.Text)
        dgvRow.Cells(clmAmount.Name).Value = FormatCurrency(txtAmount.Text).Trim("$")
        If btnEntryOK.Text = "ADD" Then
            dgvRow.Cells(clmAdded.Name).Value = Format(Today.Date, "MM/dd/yyyy")
            dgvRow.Tag = "t" & dataView.Rows.Count - 1
        End If

        ' Update form. 
        sortDGVbyDate()
        setDBaltered(True)
        resetEntryFields()
        pnlEntry.Visible = False
        lblCounter.Text = dataView.SelectedRows.Item(0).Index & " (" & dataView.SelectedRows.Item(0).Tag & ") " & dataView.SelectedRows.Item(0).Index + 1 & "/" & dataView.RowCount & ""


    End Sub
    Private Sub dataView_SelectionChanged(sender As Object, e As EventArgs) Handles dataView.SelectionChanged


        If dataView.SelectedRows.Count = 0 Then Exit Sub
        lblCounter.Text = dataView.SelectedRows.Item(0).Index & " (" & dataView.SelectedRows.Item(0).Tag & ") " & dataView.SelectedRows.Item(0).Index + 1 & "/" & dataView.RowCount & ""


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEntry.TextChanged



    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click





        ' Make it so Menu > Edit > Amend Entry and > Delete Entry are only enabled when there is visible? data in database.

        'AUTOCOMPLETE
        ' Add autocomplete functionality for txtEntry and cmboCategory input fields. *DONE*
        ' Update cmboCategory dropdown list at the same time.
        ' - add to collection while loading existing DB, or when adding / amending entry *DONE*
        ' - remove from collection when deleting *DONE* or amending entry 
        ' - clear collection when starting new DB or loading existing DB *DONE*
        'make it so user can select to have autocomplete collection only include more recent (last 30 days) entries

        'DONE- date column sorting 
        '! should this be changed to incorporate Mikey's timestamp string?

        'doesn't save programs settings


        'CHARTS'
        ' daily totals (DONE)
        ' running total (DONE)
        ' by category (SORT OF DONE)
        '

        'REPORTS'
        ' spending by category (pie graph)?
        ' high cost purchase
        ' 


    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click


        '# fill form using input from settings array
        With Form2
            'default directory
            .txtDirectory.Text = lvSettings.Items(0).Text
            'display mode
            Select Case lvSettings.Items(1).Text
                Case "0"
                    .chkAll.Checked = True
                    .chkYearly.Checked = False
                    .chkMonthly.Checked = False
                Case "1"
                    .chkAll.Checked = False
                    .chkYearly.Checked = True
                    .chkMonthly.Checked = False
                Case "2"
                    .chkAll.Checked = False
                    .chkYearly.Checked = False
                    .chkMonthly.Checked = True
            End Select
            'columns 
            Dim cSplit As String() = lvSettings.Items(2).Text.Split("|")
            Dim cList As List(Of String) = cSplit.ToList
            For i = 0 To dataView.Columns.Count - 1
                Dim clmString As String = cList(i)
                Dim clmOrder As String = clmString.First
                If clmString.Contains("False") Then
                    Form2.lstColumns.SetItemChecked(i, False)
                Else
                    Form2.lstColumns.SetItemChecked(i, True)
                End If
            Next
            'auto save
            .chkAutosave.CheckState = lvSettings.Items(3).Text
            'auto load
            Dim strAutoload As String = lvSettings.Items(4).Text
            .chkAutoload.CheckState = Mid(strAutoload, 1, 1)
            .txtFilename.Text = Mid(strAutoload, 3)
        End With

        '# show form
        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub DeleteEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEntryToolStripMenuItem.Click


        ' Removes entry from database.

        ' Hide pnlEntry.
        pnlEntry.Visible = False

        ' Skip if there is no data specified for removal.
        If dataView.SelectedRows.Count = 0 Then
            MsgBox("No data exists or has been selected to remove.")
        Else

            ' Prompt user to confirm action.
            Dim mResult As MsgBoxResult = MsgBox("Are you sure you want to permanently delete the entry """ & dataView.SelectedRows(0).Cells(clmEntry.Name).Value & """ from the database?", vbYesNo, "Confirm Action")
            ' When confirmed,
            If mResult = vbYes Then
                ' update autocomplete collections,
                Dim eVal As String = dataView.SelectedRows(0).Cells.Item(clmEntry.Name).Value
                Dim cVal As String = dataView.SelectedRows(0).Cells.Item(clmCategory.Name).Value
                txtEntry.AutoCompleteCustomSource.Remove(eVal)
                cmboCategory.AutoCompleteCustomSource.Remove(cVal)
                cmboCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                ' and cmboCategory dropdown list,
                If Not cmboCategory.AutoCompleteCustomSource.Contains(cVal) Then cmboCategory.Items.Remove(cVal)
                ' then remove entry from database,
                dataView.Rows.RemoveAt(dataView.SelectedRows(0).Index)
                ' and update total.
                lblTotal.Text = getTotalAmount()
            End If

        End If


    End Sub
    Private Sub cmboCategory_Leave(sender As Object, e As EventArgs) Handles cmboCategory.Leave


        cmboCategory.Text = cmboCategory.Text.TrimStart(" ")
        cmboCategory.Text = cmboCategory.Text.TrimEnd(" ")
        cmboCategory.Text = cmboCategory.Text.Replace("|", "")


    End Sub
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click


        ' Creates new database.

        ' Close current database.
        Dim Action As String = DBcloseAction()
        If Action = "Cancel" Then Exit Sub
        If Action = "Save" Then
            If DBsaveAction() = "Cancel" Then Exit Sub
        End If

        ' Refresh database properties reference list.
        With DBproperties.Items
            .Clear()
            .Add("<filepath>") '0
            .Add("untitled") '1
            .Add("3, 000") '2
            .Add(lvSettings.Items.Item(3).Text) '3
            .Add("False") '4
            .Add("") '5
            .Add("") '6
            .Add("Calibri") '7
            .Add("8.25") '8
            .Add(setColorStr(Color.White)) '9
            .Add(setColorStr(Color.Black)) '10
            .Add(setColorStr(Color.Goldenrod))  '11
            .Add(setColorStr(Color.LightGray)) '12
            .Add("True") '13
            .Add("True") '14
            .Add(lvSettings.Items.Item(1).Text) '15
        End With

        ' Refresh dataView.
        resetEntryFields(True)
        setDGVrange(lvSettings.Items(1).Text)
        setDGVcolumns(lvSettings.Items(2).Text)

        ' Refresh form.
        setDBaltered(False)
        lblSubtitle.Text = "untitled"


    End Sub
    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnEntryOK.PerformClick()
            e.Handled = True
        End If

    End Sub
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click


        ' Saves current database to new file.
        Dim saveDlg As New SaveFileDialog
        saveDlg.InitialDirectory = lvSettings.Items(0).Text
        saveDlg.Filter = "BRO Files (*.br0)|*.br0"
        If saveDlg.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        Else
            DBproperties.Items.Item(0).Text = LCase(saveDlg.FileName)
            DBsave(saveDlg.FileName)
            setDBaltered(False)
        End If


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click


        ' Opens existing database from file.

        ' Close current database.
        Dim Action As String = DBcloseAction()
        If Action = "Cancel" Then Exit Sub
        If Action = "Save" Then
            If DBsaveAction() = "Cancel" Then Exit Sub
        End If

        ' Open existing database.
        Dim fileDialog As New OpenFileDialog
        fileDialog.InitialDirectory = lvSettings.Items(0).Text
        fileDialog.Filter = "BRO Files (*.br0)|*.br0"
        fileDialog.Multiselect = False
        If fileDialog.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        Else
            pnlEntry.Visible = False
            DBload(fileDialog.FileName)
        End If


    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub cmboCategory_TextUpdate(sender As Object, e As EventArgs) Handles cmboCategory.TextUpdate

    End Sub

    Private Sub cmboCategory_ControlAdded(sender As Object, e As ControlEventArgs) Handles cmboCategory.ControlAdded


    End Sub

    Private Sub cmboCategory_DataSourceChanged(sender As Object, e As EventArgs) Handles cmboCategory.DataSourceChanged

    End Sub

    Private Sub DateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuDataColumnsDate.Click



    End Sub

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click

    End Sub

    Private Sub DateToolStripMenuItem1_CheckStateChanged(sender As Object, e As EventArgs) Handles mnuDataColumnsDate.CheckStateChanged


        clmDate.Visible = mnuDataColumnsDate.Checked

    End Sub

    Private Sub mnuDataColumnsEntry_Click(sender As Object, e As EventArgs) Handles mnuDataColumnsEntry.Click

        clmEntry.Visible = mnuDataColumnsEntry.Checked

    End Sub

    Private Sub mnuDataColumnsCategory_Click(sender As Object, e As EventArgs) Handles mnuDataColumnsCategory.Click

        clmCategory.Visible = mnuDataColumnsCategory.Checked

    End Sub

    Private Sub mnuDataColumnsAmount_Click(sender As Object, e As EventArgs) Handles mnuDataColumnsAmount.Click

        clmAmount.Visible = mnuDataColumnsAmount.Checked

    End Sub

    Private Sub mnuDataColumnsAdded_Click(sender As Object, e As EventArgs) Handles mnuDataColumnsAdded.Click

        clmAdded.Visible = mnuDataColumnsAdded.Checked

    End Sub

    Private Sub dataView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataView.ColumnHeaderMouseClick

        If e.ColumnIndex = 0 Then
            For i = 0 To dataView.RowCount - 1
                Dim curVal As Date = dataView.Item(clmDate.Name, i).Value
                Dim nuVal As String = Format(curVal, "yyyyMMdd")
                dataView.Item(clmDate.Name, i).Value = nuVal
                'MsgBox(nuVal)
            Next i

            If dataView.SortOrder = 2 Then
                dataView.Sort(clmDate, System.ComponentModel.ListSortDirection.Ascending)
            Else
                dataView.Sort(clmDate, System.ComponentModel.ListSortDirection.Descending)
            End If
            clmDate.SortMode = DataGridViewColumnSortMode.Automatic
            clmDate.SortMode = DataGridViewColumnSortMode.Programmatic

            For j = 0 To dataView.RowCount - 1
                Dim curVal2 As String = dataView.Item(clmDate.Name, j).Value
                Dim nuYear As String, nuMonth As String, nuDay As String
                nuYear = Mid(dataView.Item(clmDate.Name, j).Value, 1, 4)
                nuMonth = Mid(dataView.Item(clmDate.Name, j).Value, 5, 2)
                nuDay = Mid(dataView.Item(clmDate.Name, j).Value, 7, 2)

                dataView.Item(clmDate.Name, j).Value = nuMonth & "/" & nuDay & "/" & nuYear
            Next j
        End If


    End Sub

    Private Sub mnuDataDisplaymodeMonthly_Click(sender As Object, e As EventArgs) Handles mnuDataDisplaymodeMonthly.Click


        setDGVrange(2)


    End Sub

    Private Sub mnuDataDisplaymodeAll_Click(sender As Object, e As EventArgs) Handles mnuDataDisplaymodeAll.Click


        setDGVrange(0)


    End Sub

    Private Sub mnuDataDisplaymodeYearly_Click(sender As Object, e As EventArgs) Handles mnuDataDisplaymodeYearly.Click


        setDGVrange(1)


    End Sub

    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged

        '!this isn't necessary as there is no change... all is all
        'If mnuDataDisplaymodeAll.Checked = True Then
        'mnuDataDisplaymodeAll_Click(sender, e)
        'Exit Sub
        'End If
        If mnuDataDisplaymodeYearly.Checked = True Then
            mnuDataDisplaymodeYearly_Click(sender, e)
            Exit Sub
        End If
        If mnuDataDisplaymodeMonthly.Checked = True Then
            mnuDataDisplaymodeMonthly_Click(sender, e)
            Exit Sub
        End If

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDataColumnsReset.Click

        '# reset order, width, and visibility of all columns within dataView
        setDGVcolumns(lvSettings.Items(2).Text)

    End Sub

    Private Sub Form1_MarginChanged(sender As Object, e As EventArgs) Handles Me.MarginChanged

    End Sub

    Private Sub Form1_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated

    End Sub

    Private Sub FILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub

    Private Sub DATAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAToolStripMenuItem.Click

    End Sub

    Private Sub GridlinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewGridlines.Click



    End Sub

    Private Sub lvSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSettings.SelectedIndexChanged

    End Sub



    Private Sub mnuViewGridlines_CheckedChanged(sender As Object, e As EventArgs) Handles mnuViewGridlines.CheckedChanged

        setDGVgridlines(mnuViewGridlines.Checked)

    End Sub

    Private Sub DBproperties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DBproperties.SelectedIndexChanged

    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

        '# visCount = number of rows currently visible in dataView to be processed
        Dim visCount As Integer = dataView.Rows.GetRowCount(DataGridViewElementStates.Visible)
        Dim totalAmt As Decimal = 0.0

        '# process all rows in dataView collection
        For i = 0 To dataView.Rows.Count - 1
            '
            ' if specified row is currently visible, add amount to total
            If dataView.Rows.Item(i).Visible = True Then
                Dim getAmount As Decimal = Val(dataView.Rows.Item(i).Cells(clmAmount.Name).Value)
                totalAmt = totalAmt + getAmount
                visCount = visCount - 1
            End If
            '
            ' if all visible rows have been processed, jump to end of collection 
            If visCount = 0 Then i = dataView.Rows.Count - 1
            '
        Next i


    End Sub

    Private Sub lblTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseDown

        If e.Button = MouseButtons.Left Then
            cursMove = True
            cursX = Cursor.Position.X - Me.Left
            cursY = Cursor.Position.Y - Me.Top
        End If

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub lblTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseMove

        If cursMove Then
            Me.Left = Cursor.Position.X - cursX
            Me.Top = Cursor.Position.Y - cursY
        End If

    End Sub

    Private Sub lblTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseUp

        cursMove = False

    End Sub

    Private Sub ModifyEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditModifyEntry.Click


        ' Amends selected entry.

        ' If no entry selected, do nothing.
        If dataView.SelectedRows.Count = 0 Then
            MsgBox("No entry selected.")
        Else
            ' Otherwse, switch pnlEntry to EDIT mode and make visible.
            MenuStrip1.Enabled = False
            dataView.Enabled = False
            datePicker.Value = dataView.SelectedRows.Item(0).Cells(clmDate.Name).Value
            txtEntry.Text = dataView.SelectedRows.Item(0).Cells(clmEntry.Name).Value
            cmboCategory.Text = dataView.SelectedRows.Item(0).Cells(clmCategory.Name).Value
            txtAmount.Text = dataView.SelectedRows.Item(0).Cells(clmAmount.Name).Value
            btnEntryOK.Text = "EDIT"
            txtEntry.BackColor = Color.Cornsilk
            cmboCategory.BackColor = Color.Cornsilk
            txtAmount.BackColor = Color.Cornsilk
            pnlEntry.Visible = True
        End If


    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuFileProperties.Click


        'set frmProperties fields
        With frmProperties
            .txtFile.Text = DBproperties.Items.Item(0).Text
            .txtFile.SelectionStart = .txtFile.TextLength
            .txtTitle.Text = DBproperties.Items.Item(1).Text
            .txtBudget.Text = DBproperties.Items.Item(2).Text
            .chkAutoSave.CheckState = DBproperties.Items.Item(3).Text
            .chkPW.Checked = False
            .txtPW.Text = ""
            .txtHint.Text = ""
            .btnBackColor.BackColor = dataView.BackgroundColor
            .btnForeColor.BackColor = dataView.ForeColor
            .btnSelColor.BackColor = dataView.RowsDefaultCellStyle.SelectionForeColor
            .btnGridColor.BackColor = getColor(DBproperties.Items.Item(12).Text)
            .chkGrid.CheckState = mnuViewGridlines.CheckState
            .chkHeaders.Checked = dataView.ColumnHeadersVisible
        End With

        ' set dataPreview appearance properties
        With frmProperties.dataPreview
            .BackgroundColor = dataView.BackgroundColor
            .DefaultCellStyle.BackColor = dataView.BackgroundColor
            .DefaultCellStyle.SelectionBackColor = dataView.BackgroundColor
            .RowsDefaultCellStyle.SelectionForeColor = dataView.RowsDefaultCellStyle.SelectionForeColor
            .RowsDefaultCellStyle.Font = dataView.RowsDefaultCellStyle.Font
            .ForeColor = dataView.ForeColor
            .Font = dataView.Font
        End With



        '.chkPW = lvprop
        '.txtPW.Text =
        Me.Hide()
        frmProperties.Show()

    End Sub

    Private Sub mnuViewHeader_Click(sender As Object, e As EventArgs) Handles mnuViewHeader.Click



    End Sub

    Private Sub mnuViewHeader_CheckedChanged(sender As Object, e As EventArgs) Handles mnuViewHeader.CheckedChanged

        dataView.ColumnHeadersVisible = mnuViewHeader.Checked

    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click


        ' Edit > Rename Category. 

        ' If no item is selected, do nothing.
        If dataView.SelectedRows.Count = 0 Then
            MsgBox("No category selected.")
        Else
            ' Otherwise, prompt user for new category title.
            Dim curVal = dataView.SelectedRows.Item(0).Cells.Item(clmCategory.Name).Value
            Dim iResult = InputBox("Rename category '" & curVal & "' to:")
            If iResult.Trim(" ") = "" Then Exit Sub
            ' Rename category and !!!update auto-complete collection !!!and cmboCategory drop down list.
            For i = 0 To dataView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1
                If dataView.Item(clmCategory.Name, i).Value = curVal Then dataView.Item(clmCategory.Name, i).Value = iResult
            Next i
        End If


    End Sub

    Private Sub dataView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dataView.RowsRemoved


        ' Update changed status since data has been removed.
        setDBaltered(True)
        resetEntryFields()

    End Sub
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click


        ' Saves current database to new or existing file depending on chkDBexisting variable via DBsaveAction function. 
        If chkDBaltered() = True Then
            DBsaveAction()
        End If


    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click


        ' Close current database.
        Dim Action As String = DBcloseAction()
        If Action = "Cancel" Then Exit Sub
        If Action = "Save" Then
            If DBsaveAction() = "Cancel" Then Exit Sub
        End If

        ' End program.
        End


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        ' Exit program, "X" on titlebar.
        mnuFileExit_Click(sender, e)


    End Sub

    Private Sub btnExit_MouseDown(sender As Object, e As MouseEventArgs) Handles btnExit.MouseDown

        btnExit.Top = btnExit.Top + 1

    End Sub

    Private Sub btnExit_MouseUp(sender As Object, e As MouseEventArgs) Handles btnExit.MouseUp

        btnExit.Top = btnExit.Top - 1

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        setPoints(dataView, clmCategory, xyList)

        chartDraw_TotalsByCategory(xyList)


        '________________________________


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        setPoints2(dataView, clmDate, xyList)

        chartDraw_RunningTotal(xyList)

    End Sub

    Private Sub dataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataView.CellContentClick

    End Sub

    Private Sub xyList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xyList.SelectedIndexChanged

    End Sub

    Private Sub pnlView_Paint(sender As Object, e As PaintEventArgs) Handles pnlView.Paint

    End Sub

    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click

        'Me.Width = 912
        'Me.Height = 692

        'MenuStrip1.Enabled = False

        'xyList.Visible = True
    End Sub

    Private Sub dataView_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles dataView.CellContextMenuStripNeeded

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlControl.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnRange.Click


        Dim mode As Integer = getDGVmode()
        mode = mode + +1
        If mode > 2 Then mode = 0
        setDGVrange(mode)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles BtnAddEntry.Click


        'Select Case BtnAddEntry.Text
        'Case "+"
        pnlEntry.Visible = True
        'BtnAddEntry.Text = "^"
        'Case "^"
        'pnlEntry.Visible = False
        'BtnAddEntry.Text = "+"
        ' End Select


    End Sub
    Private Sub pnlEntry_VisibleChanged(sender As Object, e As EventArgs) Handles pnlEntry.VisibleChanged

        'MsgBox("start @ " & dataView.Top & ", " & dataView.Bottom)

        'dataView.Enabled = Not pnlEntry.Visible   '! only on edit mode
        Select Case pnlEntry.Visible
            Case True
                dataView.Height = pnlView.Height - pnlStatus.Height - pnlEntry.Height - 11
                dataView.Top = pnlEntry.Bottom - 1
            Case False
                dataView.Height = pnlView.Height - pnlStatus.Height - 12
                dataView.Top = 8
        End Select

        'MsgBox("Stop @ " & dataView.Top & ", " & dataView.Bottom)

    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click


        Dim nowRange As Integer = getDGVmode()
        Select Case nowRange
            Case 1 'year
                datePicker.Value = datePicker.Value.AddYears(1)
            Case 2 'month
                datePicker.Value = datePicker.Value.AddMonths(1)
        End Select


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click


        Dim nowRange As Integer = getDGVmode()
        Select Case nowRange
            Case 1 'year
                datePicker.Value = datePicker.Value.AddYears(-1)
            Case 2 'month
                datePicker.Value = datePicker.Value.AddMonths(-1)
        End Select


    End Sub

    Private Sub lblSubtitle_Click(sender As Object, e As EventArgs) Handles lblSubtitle.Click

    End Sub

    Private Sub lblSubtitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lblSubtitle.MouseDown


        lblTitle_MouseDown(sender, e)


    End Sub

    Private Sub lblSubtitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lblSubtitle.MouseUp


        lblTitle_MouseUp(sender, e)


    End Sub

    Private Sub lblSubtitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lblSubtitle.MouseMove


        lblTitle_MouseMove(sender, e)


    End Sub

    Private Sub lblTitle_DoubleClick(sender As Object, e As EventArgs) Handles lblTitle.DoubleClick

        If Me.Height > 50 Then
            Me.Height = pnlControl.Height
            Exit Sub
        Else
            Me.Height = pnlView.Height + pnlView.Top
            Exit Sub
        End If

    End Sub

    Private Sub btnRange_MouseHover(sender As Object, e As EventArgs) Handles btnRange.MouseHover





    End Sub

    Private Sub btnBack_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBack.MouseDown


        If Not getDGVmode() = 0 Then btnBack.Left = btnBack.Left - 1


    End Sub

    Private Sub btnBack_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBack.MouseUp


        If Not getDGVmode() = 0 Then btnBack.Left = btnBack.Left + 1


    End Sub

    Private Sub btnForward_MouseDown(sender As Object, e As MouseEventArgs) Handles btnForward.MouseDown


        If Not getDGVmode() = 0 Then btnForward.Left = btnForward.Left + 1


    End Sub

    Private Sub btnForward_MouseUp(sender As Object, e As MouseEventArgs) Handles btnForward.MouseUp


        If Not getDGVmode() = 0 Then btnForward.Left = btnForward.Left - 1


    End Sub

    Private Sub btnRange_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRange.MouseDown


        btnRange.Top = btnRange.Top + 1


    End Sub

    Private Sub btnRange_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRange.MouseUp


        btnRange.Top = btnRange.Top - 1


    End Sub

    Private Sub btnRange_DoubleClick(sender As Object, e As EventArgs) Handles btnRange.DoubleClick


        datePicker.Value = Date.Today


    End Sub

    Private Sub btnEditEntry_Click(sender As Object, e As EventArgs) Handles btnEditEntry.Click


        If dataView.SelectedRows.Count = 0 Then
            MsgBox("you gotta make a selection first, bro.")
        Else
            MenuStrip1.Enabled = False
            datePicker.Value = dataView.SelectedRows.Item(0).Cells(clmDate.Name).Value
            txtEntry.Text = dataView.SelectedRows.Item(0).Cells(clmEntry.Name).Value
            cmboCategory.Text = dataView.SelectedRows.Item(0).Cells(clmCategory.Name).Value
            txtAmount.Text = dataView.SelectedRows.Item(0).Cells(clmAmount.Name).Value
            btnEntryOK.Text = "SAVE"
            txtEntry.BackColor = Color.Cornsilk
            cmboCategory.BackColor = Color.Cornsilk
            txtAmount.BackColor = Color.Cornsilk
            pnlEntry.Visible = True
        End If


    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click


        Me.WindowState = FormWindowState.Minimized


    End Sub
    Private Sub txtEntry_Leave(sender As Object, e As EventArgs) Handles txtEntry.Leave


        txtEntry.Text = txtEntry.Text.Replace("|", "")


    End Sub

    Private Sub pnlEntry_Paint(sender As Object, e As PaintEventArgs) Handles pnlEntry.Paint

    End Sub

    Private Sub cmboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboCategory.SelectedIndexChanged

    End Sub

    Private Sub DATAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DATAToolStripMenuItem1.Click

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub
End Class
