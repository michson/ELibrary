Public Class Frmbooks

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        AxFoxitCtl1.OpenFile(OpenFileDialog1.FileName)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmMainPage.Show()
        Me.Hide()

    End Sub

    Private Sub Frmbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_MyDatabase_1DataSet.Books_TB' table. You can move, or remove it, as needed.
        Me.Books_TBTableAdapter.Fill(Me._MyDatabase_1DataSet.Books_TB)

    End Sub

    
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If lstBooks.SelectedIndex < 0 Then
            MsgBox("Select A book in the List Provided!")
        ElseIf lstBooks.SelectedIndex >= 1 Then

            Dim Itemselected As String = lstBooks.Items.Item(lstBooks.SelectedIndex).ToString
            Dim foxit As New AxFOXITREADERLib.AxFoxitCtl
            MsgBox("Item selected is " & Itemselected)
            AxFoxitCtl1.OpenFile("~/Books/" & Itemselected)
            AxFoxitCtl2.OpenFile("~/Books/" & Itemselected)
            AxFoxitCtl2.src = "~/Books/" & Itemselected.ToString

        End If
        Try
            'foxit.OpenFile("~/Books/" & lstBooks.SelectedItem.ToString & ".pdf")
            'foxit.src = lstBooks.SelectedItem
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class