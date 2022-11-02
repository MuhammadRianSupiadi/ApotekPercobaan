Public Class Splashscreen
    Dim Progress As Integer = 0
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newProgress = Progress + 1
        Progress = newProgress

        If (Progress = 100) Then
            Timer1.Stop()
            Me.Hide()
            Menu_Utama.ShowDialog()

        End If

        ProgressBar.Value = newProgress
        lbl_loading.Text = "loading.. " & newProgress & "%"
    End Sub
End Class
