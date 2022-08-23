Public Class staffUpload


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If cboLevel.Text = "" Then
            MessageBox.Show("Please Select the Level")
            cboLevel.Focus()
            Exit Sub
        End If

        If Txtcode.Text = "" Then
            MessageBox.Show("Select the Course Code")
            Txtcode.Focus()
            Exit Sub
        End If

        If txtTitle.Text = "" Then
            MessageBox.Show("Please Enter the Book Title")
            txtTitle.Focus()
            Exit Sub
        End If

        Dim reply As DialogResult

        OpenFileDialog1.Filter = "(PDF Files)|*.pdf"
        reply = OpenFileDialog1.ShowDialog()
        If reply <> Windows.Forms.DialogResult.Cancel Then

            txtPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If txtPath.Text <> "" Then
            AxFoxitCtl1.OpenFile(Trim(txtPath.Text))
            pnlPreview.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmMainPage.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Visible = True


    End Sub

    Private Sub staffUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        SaveFileDialog1.OpenFile()


    End Sub
End Class