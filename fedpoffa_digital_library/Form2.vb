Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet2.library' table. You can move, or remove it, as needed.
        Me.LibraryTableAdapter.Fill(Me.LibraryDataSet2.library)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Frmbooks.Show()
        Me.Hide()

    End Sub
End Class
