Public Class FrmSplashScreen
    Dim SAPI = CreateObject("SAPI.spvoice")
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            FrmMainPage.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Show()
        Timer1.Start()
        SAPI.speak("please wait,some seconds to load")
    End Sub
End Class

