Public Class Splashscreen
    ' Global variabel utuk menampilka nilai progress
    Dim Progress As Integer = 0
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Fungsi yag akan dijalakan setiap interval timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Menghitung progress terbaru
        Dim newProgress = Progress + 1
        ' Mengupdate global variabel progress supaya tidak stuk di angka 0
        Progress = newProgress

        ' Jika progress sama dengan 100 maka hentikan timer
        If (Progress = 100) Then
            Timer1.Stop()
            Me.Hide()
            Menu_Utama.ShowDialog()

        End If

        ' Set progressbar value meggunaka nilai newProgress
        ProgressBar.Value = newProgress
        lbl_loading.Text = "loading.. " & newProgress & "%"
    End Sub
End Class
