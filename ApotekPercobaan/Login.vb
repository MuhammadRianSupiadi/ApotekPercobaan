Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Terbuka()
        Menu_Utama.Login.Enabled = False
        Menu_Utama.KELUAR.Enabled = True
        Menu_Utama.PETUGAS.Enabled = True
        Menu_Utama.Master.Enabled = True
        Menu_Utama.TRANSAKSI.Enabled = True
        Menu_Utama.LAPORAN.Enabled = True
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from petugas where kd_petugas = '" & txt_petugas.Text & "'and password='" & txt_password.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call Terbuka()
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If CheckPassword.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"

        End If
    End Sub
End Class