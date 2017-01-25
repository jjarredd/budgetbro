Public Class frmProperties

    Public Function setColorStr(clr As Color) As String

        setColorStr = clr.R & "." & clr.G & "." & clr.B

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFont.Click

        Dim fontDlg As New FontDialog
        fontDlg.MinSize = 8
        fontDlg.MaxSize = 10
        fontDlg.ShowColor = False
        fontDlg.ShowEffects = False
        fontDlg.Font = dataPreview.Font
        If fontDlg.ShowDialog = DialogResult.OK Then
            dataPreview.Font = fontDlg.Font
            dataPreview.RowsDefaultCellStyle.Font = fontDlg.Font
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With dataPreview
            For i = 0 To 2
                .Rows.Add()
                .Rows.Item(i).Cells.Item(0).Value = "02/26/86"
                .Rows.Item(i).Cells.Item(1).Value = "preview"
                .Rows.Item(i).Cells.Item(2).Value = "none"
            Next i
        End With


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged

        Select Case chkGrid.Checked
            Case True
                dataPreview.GridColor = btnGridColor.BackColor
            Case False
                dataPreview.GridColor = dataPreview.BackgroundColor
        End Select



    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkPW.CheckedChanged


        txtPW.Enabled = chkPW.Checked
        txtHint.Enabled = chkPW.Checked

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        'update lvProperties
        With Form1.DBproperties.Items
            .Clear()
            .Add(txtFile.Text) '0
            .Add(txtTitle.Text) '1
            .Add(txtBudget.Text) '2
            .Add(chkAutoSave.CheckState) '3
            .Add(chkPW.Checked) '4
            .Add(txtPW.Text) '5
            .Add(txtHint.Text) '6
            .Add(dataPreview.Font.Name) '7
            .Add(dataPreview.Font.Size) '8
            .Add(setColorStr(btnBackColor.BackColor)) '9
            .Add(setColorStr(btnForeColor.BackColor)) '10
            .Add(setColorStr(btnSelColor.BackColor))  '11
            .Add(setColorStr(btnGridColor.BackColor)) '12
            .Add(chkGrid.Checked) '13
            .Add(chkHeaders.Checked) '14
            .Add(Form1.getDGVmode) '15
        End With

        'update dataView appearance
        With Form1
            .lblSubtitle.Text = txtTitle.Text
            .dataView.Font = dataPreview.Font
            .setDGVcolors(setColorStr(btnBackColor.BackColor), setColorStr(btnForeColor.BackColor), setColorStr(btnSelColor.BackColor))
            .setDGVgridlines(chkGrid.Checked, btnGridColor.BackColor)
            .setDBaltered(True)
            .mnuViewHeader.Checked = chkHeaders.Checked
        End With

        'hide/show form
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnBackColor_Click(sender As Object, e As EventArgs) Handles btnBackColor.Click

        Dim bClrDlg As New ColorDialog
        If (bClrDlg.ShowDialog() = DialogResult.OK) Then
            btnBackColor.BackColor = bClrDlg.Color
            dataPreview.BackgroundColor = bClrDlg.Color
            dataPreview.RowsDefaultCellStyle.BackColor = bClrDlg.Color
            dataPreview.RowsDefaultCellStyle.SelectionBackColor = bClrDlg.Color
        End If

    End Sub

    Private Sub btnForeColor_Click(sender As Object, e As EventArgs) Handles btnForeColor.Click

        Dim fClrDlg As New ColorDialog
        If (fClrDlg.ShowDialog() = DialogResult.OK) Then
            btnForeColor.BackColor = fClrDlg.Color
            dataPreview.ForeColor = fClrDlg.Color
        End If

    End Sub

    Private Sub btnGridColor_Click(sender As Object, e As EventArgs) Handles btnGridColor.Click

        Dim gClrDlg As New ColorDialog
        If (gClrDlg.ShowDialog() = DialogResult.OK) Then
            btnGridColor.BackColor = gClrDlg.Color
            If chkGrid.Checked = True Then
                dataPreview.GridColor = gClrDlg.Color
            End If
        End If

    End Sub

    Private Sub btnSelColor_Click(sender As Object, e As EventArgs) Handles btnSelColor.Click

        Dim sClrDlg As New ColorDialog
        If (sClrDlg.ShowDialog() = DialogResult.OK) Then
            btnSelColor.BackColor = sClrDlg.Color
            dataPreview.RowsDefaultCellStyle.SelectionForeColor = sClrDlg.Color
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub chkHeaders_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeaders.CheckedChanged

        dataPreview.ColumnHeadersVisible = chkHeaders.Checked

    End Sub

    Private Sub dataPreview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPreview.CellContentClick

    End Sub

    Private Sub cmdSave_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdSave.MouseUp

        cmdSave.Top = cmdSave.Top - 1

    End Sub

    Private Sub cmdSave_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdSave.MouseDown

        cmdSave.Top = cmdSave.Top + 1

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        With Form1
            'txtFile.Text = .lvProperties.Items.Item(0).Text
            'txtTitle.Text = "untitled"
            txtBudget.Text = "$3,000.00"
            chkPW.Checked = False
            txtPW.Text = ""
            txtHint.Text = ""
            dataPreview.Font = .setFont("Calibri", 8.25, False, False)
            dataPreview.RowsDefaultCellStyle.Font = .setFont("Calibri", 8.25, False, False)
            btnBackColor.BackColor = Color.White
            btnForeColor.BackColor = Color.Black
            btnSelColor.BackColor = Color.Goldenrod
            btnGridColor.BackColor = Color.LightGray
            chkGrid.Checked = True
            chkHeaders.Checked = True
        End With

    End Sub

    Private Sub cmdReset_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdReset.MouseDown

        cmdReset.Top = cmdReset.Top + 1

    End Sub

    Private Sub cmdReset_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdReset.MouseUp

        cmdReset.Top = cmdReset.Top - 1

    End Sub

    Private Sub cmdCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdCancel.MouseDown

        cmdCancel.Top = cmdCancel.Top + 1

    End Sub

    Private Sub cmdCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdCancel.MouseUp

        cmdCancel.Top = cmdCancel.Top - 1

    End Sub

    Private Sub btnBackColor_BackColorChanged(sender As Object, e As EventArgs) Handles btnBackColor.BackColorChanged


        dataPreview.BackgroundColor = btnBackColor.BackColor
        dataPreview.RowsDefaultCellStyle.BackColor = btnBackColor.BackColor
        dataPreview.RowsDefaultCellStyle.SelectionBackColor = btnBackColor.BackColor

    End Sub

    Private Sub btnForeColor_BackColorChanged(sender As Object, e As EventArgs) Handles btnForeColor.BackColorChanged

        dataPreview.ForeColor = btnForeColor.BackColor

    End Sub

    Private Sub btnSelColor_BackColorChanged(sender As Object, e As EventArgs) Handles btnSelColor.BackColorChanged

        dataPreview.RowsDefaultCellStyle.SelectionForeColor = btnSelColor.BackColor

    End Sub

    Private Sub btnGridColor_BackColorChanged(sender As Object, e As EventArgs) Handles btnGridColor.BackColorChanged

        If chkGrid.Checked = True Then
            dataPreview.GridColor = btnGridColor.BackColor
        End If

    End Sub

    Private Sub txtBudget_TextChanged(sender As Object, e As EventArgs) Handles txtBudget.TextChanged

        If IsNumeric(txtBudget.Text) = False Then txtBudget.Text = ""

    End Sub

    Private Sub txtBudget_LostFocus(sender As Object, e As EventArgs) Handles txtBudget.LostFocus

        txtBudget.Text = FormatCurrency(txtBudget.Text, 2)

    End Sub
End Class