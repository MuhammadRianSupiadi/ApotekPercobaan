Public Class Menu_Utama
    Sub Terkunci()
        Login.Enabled = True
        KELUAR.Enabled = True
        PETUGAS.Enabled = False
        TRANSAKSI.Enabled = False
        LAPORAN.Enabled = False
    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub Menu_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub KELUAR_Click(sender As Object, e As EventArgs) Handles KELUAR.Click
        End
    End Sub

    Private Sub PETUGAS_Click(sender As Object, e As EventArgs) Handles PETUGAS.Click
        Form_Petugas.ShowDialog()
    End Sub

    Private Sub PENJULAN_OBAT_Click(sender As Object, e As EventArgs) Handles PENJULAN_OBAT.Click
        Penjualan_Obat.ShowDialog()
    End Sub

    Private Sub Pembelian_Click_1(sender As Object, e As EventArgs) Handles Pembelian.Click
        Form_Pembelian.ShowDialog()
    End Sub
End Class