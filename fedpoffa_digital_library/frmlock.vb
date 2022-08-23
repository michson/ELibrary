Public Class frmlock

    Private Sub frmlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LIST As New ListViewItem
        LIST.Text = (TextBox1.Text)
        LIST.SubItems.Add(TextBox2.Text)
        LIST.SubItems.Add(ComboBox1.Text)
        LIST.SubItems.Add(DateTimePicker1.Text)
        LIST.SubItems.Add(TextBox5.Text)
        Form3.ListView1.Items.Add(LIST)
        MsgBox("save successful")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmMainPage.Show()
        Me.Hide()


    End Sub
End Class