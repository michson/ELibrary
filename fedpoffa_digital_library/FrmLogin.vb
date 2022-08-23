Imports System.Data
Imports System.Data.OleDb
Public Class FrmLogin
    Dim SAPI = CreateObject("SAPI.spvoice")
    Dim olec0nn As System.Data.OleDb.OleDbConnection
    Dim cmdOLEDB As New System.Data.OleDb.OleDbCommand
    Dim cmdInsert As New System.Data.OleDb.OleDbCommand
    Dim cmdUpdate As New System.Data.OleDb.OleDbCommand
    Dim cmdDelete As New System.Data.OleDb.OleDbCommand
    Dim Readforme As System.Data.OleDb.OleDbDataReader
    Public connection As SqlClient.SqlConnection()
    Public command As SqlClient.SqlCommand
    Public DReader As SqlClient.SqlDataReader
    Public Dadapt As SqlClient.SqlDataAdapter
    Public sqlstmts As String
    Public Connector As String
    Public ConnectMe As String

    Public Sub connectionString()
        Try
            Connector = " Data Source=C:\Users\Hi-Tech\Documents\visual studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\DBase.sdf; Persist Security Info=false"
            ConnectMe = "C:\Users\Hi-Tech\Documents\Visual Studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\me.mdb"
        Catch ex As Exception
            'Initial Catalog=; 
            'Provider=Microsoft SQL Server Compact 4.0;
        End Try
    End Sub

   
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        olec0nn = New System.Data.OleDb.OleDbConnection
        ' olec0nn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source = C:\Users\Hi-Tech\Desktop\me.mdb;"
        olec0nn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source = C:\Users\Hi-Tech\Documents\Visual Studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\me.mdb"

        olec0nn.Open()


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub clearFields()
        txtdep.Text = ""
        txtfirst.Text = ""
        txtlast.Text = ""
        txtmatric.Text = ""
        cbogender.Text = ""


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            olec0nn = New System.Data.OleDb.OleDbConnection
            olec0nn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source = C:\Users\Hi-Tech\Documents\Visual Studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\me.mdb"
            olec0nn.Open()
            Me.cmdOLEDB = New OleDbCommand("INSERT INTO User_Login_TB(FirstName,LastName,Matric_Number,Gender,Department) VALUES(' " & txtfirst.Text & "','" & txtlast.Text & "','" & txtmatric.Text & "','" & cbogender.Text & "','" & txtdep.Text & "')", Me.olec0nn)
            Me.cmdOLEDB.ExecuteNonQuery()
            MsgBox("Record Successfully Inserted")
            Me.clearFields()
        Catch ex As Exception
            MsgBox("An Error Occur (" & ex.Message & ")")
        End Try

        'If txtfirst.Text <> "" And txtlast.Text <> "" And txtmatric.Text <> "" And cbosex.Text <> "" And txtdep.Text <> "" Then

        '    cmdInsert.CommandText = "INSERT INTO users (Lastname, Firstname, Matric_No,Sex, Date_of_birth, Department,) VALUES (" &
        '            txtfirst.Text & ", '" & txtlast.Text & ",'" & txtmatric.Text & ",'" & cbosex.Text & ",'" & ",'" & txtdep.Text & "');"

        '    'MsgBox(cmdInsert.CommandText)

        '    cmdInsert.CommandType = CommandType.Text

        '    cmdInsert.Connection = olec0nn

        '    'ExecuteNonQuery()

        '    MsgBox("Record inserted.")

        '    'txtAuthor.Text = ""

        'Else

        '    MsgBox("Enter the required values:" &
        '        vbNewLine & "1. Firstname" & vbNewLine & "2.Lastname" & vbNewLine & "3. Matric_No" & vbNewLine & "4.Sex" & vbNewLine & "5.Date_of_bith" & vbNewLine & "6.Department")

        'End If

        '    cmdInsert.Dispose()




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
       

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmMainPage.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Try
                Dim matric As String
                matric = InputBox("Enter Matric Number to Delete", "Supplied Already Registered Matric", "Cs/--------")
                If matric = String.Empty Then
                    MsgBox("No Matric Is Entered")
                ElseIf matric IsNot String.Empty Then


                    olec0nn = New System.Data.OleDb.OleDbConnection
                    olec0nn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source = C:\Users\Hi-Tech\Documents\Visual Studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\me.mdb"
                    olec0nn.Open()
                    Me.cmdOLEDB = New OleDbCommand("SELECT '" & matric.ToString & "' FROM User_Login_TB", Me.olec0nn)
                    Me.Readforme = cmdOLEDB.ExecuteReader()
                    ' Dim valFromDb As Object = cmdOLEDB.ExecuteScalar()
                    If Not Readforme.HasRows Then


                        MsgBox("Matric Entered does not exit")
                    ElseIf Readforme.HasRows Then
                        If Readforme.Read Then
                            Dim valFromDb As Object = Readforme("Matric_Nmmber")
                            If Not valFromDb = String.Empty Then
                                MsgBox(valFromDb + "Is Found!")
                                Me.cmdOLEDB = New OleDbCommand("DELETE * FROM User_Login_TB WHERE Matric_Number='" & matric & "'", Me.olec0nn)
                                Me.cmdOLEDB.ExecuteNonQuery()

                                MsgBox("Record Successfully Deleted")
                                Me.clearFields()
                            Else
                                MsgBox(matric + "Does Not exit!")
                            End If
                        End If



                    End If
                    'MsgBox(valFromDb)
                    'If IsDBNull(valFromDb) Then

                    'ElseIf valFromDb Is DBNull.Value Then
                    '    MsgBox("Matric Entered does not exit")
                    'ElseIf valFromDb IsNot DBNull.Value Then
                    'cmdOLEDB.Dispose()
                    'olec0nn.Close()
                    'olec0nn = New System.Data.OleDb.OleDbConnection
                    'olec0nn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source = C:\Users\Hi-Tech\Documents\Visual Studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\me.mdb"
                    'olec0nn.Open()
                End If

            Catch ex As Exception
                MsgBox("An Error Occur (" & ex.Message & ")")
            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            olec0nn = New System.Data.OleDb.OleDbConnection
            olec0nn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source = C:\Users\Hi-Tech\Documents\Visual Studio 2012\Projects\fedpoffa_digital_library\fedpoffa_digital_library\Database\me.mdb"
            olec0nn.Open()
            cmdOLEDB = New OleDbCommand("SELECT Matric_Number FROM User_Login_TB", Me.olec0nn)
            Me.Readforme = cmdOLEDB.ExecuteReader()
            Dim matricNum As Object
            If Readforme.HasRows Then
                While Readforme.Read
                    matricNum = Readforme("Matric_Number")
                End While
                'If matricNum = txtmatric.Text Then
                MsgBox("Welcome!")
                'form.show
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class