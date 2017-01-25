Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'grids




        MsgBox(chkAll.CheckState)

    End Sub

    Private Sub cmdReset_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdReset.MouseDown


        cmdReset.Top = cmdReset.Top + 1


    End Sub

    Private Sub cmdReset_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdReset.MouseUp


        cmdReset.Top = cmdReset.Top - 1


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles cmdReset.Click


        txtDirectory.Text = Application.StartupPath
        chkMonthly.Checked = False
        chkYearly.Checked = False
        chkAll.Checked = True
        With lstColumns
            .Items.Clear()
            .Items.Add("date", True)
            .Items.Add("entry", True)
            .Items.Add("category", True)
            .Items.Add("amount", True)
            .Items.Add("date added", False)
        End With
        chkAutosave.Checked = False
        chkAutoload.Checked = False
        txtFilename.Text = "..."
        Label1.Focus()


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click


        Me.Hide()
        Form1.Show()


    End Sub

    Private Sub Label9_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdCancel.MouseUp


        cmdCancel.Top = cmdCancel.Top - 1


    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        '# update lvSettings
        With Form1.lvSettings
            .Items.Clear()
            .Items.Add(txtDirectory.Text)
            'display mode
            If chkMonthly.CheckState = 1 Then
                .Items.Add("2")
            Else
                .Items.Add(chkYearly.CheckState)
            End If
            'columns
            Dim colStr As String = ""
            For i = 0 To lstColumns.Items.Count - 1
                colStr = colStr & i & lstColumns.GetItemChecked(i) & "125|"
            Next
            .Items.Add(colStr.Trim("|"))
            .Items.Add(chkAutosave.CheckState)
            .Items.Add(chkAutoload.CheckState & "|" & txtFilename.Text)
        End With

        '# write to settings file
        Dim fWriter As New IO.StreamWriter(Application.StartupPath & "\73884647.bb1")
        fWriter.WriteLine(Form1.lvSettings.Items(0).Text)
        fWriter.WriteLine(Form1.lvSettings.Items(1).Text)
        fWriter.WriteLine(Form1.lvSettings.Items(2).Text)
        fWriter.WriteLine(Form1.lvSettings.Items(3).Text)
        fWriter.WriteLine(Form1.lvSettings.Items(4).Text)
        fWriter.Close()

        '# close form
        MsgBox("Default settings saved..",, "you got it bro.")
        Me.Hide()
        Form1.Show()



    End Sub

    Private Sub cmdSave_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdSave.MouseUp


        cmdSave.Top = cmdSave.Top - 1


    End Sub

    Private Sub cmdSave_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdSave.MouseDown


        cmdSave.Top = cmdSave.Top + 1


    End Sub

    Private Sub cmdCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdCancel.MouseDown


        cmdCancel.Top = cmdCancel.Top + 1


    End Sub

    Private Sub cmdColDown_Click(sender As Object, e As EventArgs) Handles cmdColDown.Click



    End Sub

    Private Sub cmdColDown_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdColDown.MouseDown


        cmdColDown.Top = cmdColDown.Top + 1


    End Sub

    Private Sub cmdColDown_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdColDown.MouseUp


        cmdColDown.Top = cmdColDown.Top - 1


    End Sub

    Private Sub cmdColUp_Click(sender As Object, e As EventArgs) Handles cmdColUp.Click

    End Sub

    Private Sub cmdColUp_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdColUp.MouseDown


        cmdColUp.Top = cmdColUp.Top + 1


    End Sub

    Private Sub cmdColUp_MouseUp(sender As Object, e As MouseEventArgs) Handles cmdColUp.MouseUp


        cmdColUp.Top = cmdColUp.Top - 1


    End Sub

    Private Sub chkYearly_Click(sender As Object, e As EventArgs) Handles chkYearly.Click


        If chkYearly.Checked = True Then
            chkAll.Checked = False
            chkMonthly.Checked = False
        Else
            chkYearly.Checked = True
        End If


    End Sub

    Private Sub chkMonthly_Click(sender As Object, e As EventArgs) Handles chkMonthly.Click


        If chkMonthly.Checked = True Then
            chkYearly.Checked = False
            chkAll.Checked = False
        Else
            chkMonthly.Checked = True
        End If



    End Sub

    Private Sub chkAll_Click(sender As Object, e As EventArgs) Handles chkAll.Click


        If chkAll.Checked = True Then
            chkYearly.Checked = False
            chkMonthly.Checked = False
        Else
            chkAll.Checked = True
        End If


    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged

    End Sub

    Private Sub chkYearly_CheckedChanged(sender As Object, e As EventArgs) Handles chkYearly.CheckedChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lstColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstColumns.SelectedIndexChanged


    End Sub

    Private Sub chkAutoload_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoload.CheckedChanged




    End Sub

    Private Sub chkAutoload_Click(sender As Object, e As EventArgs) Handles chkAutoload.Click

        Select Case chkAutoload.Checked

            Case True
                Dim fileDlg As New OpenFileDialog
                With fileDlg
                    .InitialDirectory = txtDirectory.Text
                    .Filter = "BRO Files (*.br0)|*.br0"
                    .Multiselect = False
                End With
                If fileDlg.ShowDialog() = DialogResult.Cancel Then
                    chkAutoload.Checked = False
                    txtFilename.Text = "..."
                    Label1.Focus()
                    Exit Sub
                Else
                    chkAutoload.Checked = True
                    txtFilename.Text = fileDlg.FileName
                End If

            Case False
                chkAutoload.Checked = False
                txtFilename.Text = "..."

        End Select

    End Sub

    Private Sub txtFilename_TextChanged(sender As Object, e As EventArgs) Handles txtFilename.TextChanged

    End Sub

    Private Sub txtDirectory_TextChanged(sender As Object, e As EventArgs) Handles txtDirectory.TextChanged





    End Sub

    Private Sub txtDirectory_Click(sender As Object, e As EventArgs) Handles txtDirectory.Click


        Dim fldrDlg As New FolderBrowserDialog
        fldrDlg.SelectedPath = txtDirectory.Text
        If fldrDlg.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        Else
            txtDirectory.Text = fldrDlg.SelectedPath
        End If


    End Sub
End Class