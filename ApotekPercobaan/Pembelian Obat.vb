Imports MySql.Data.MySqlClient
Public Class Form_Pembelian
    Sub Tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from pembelian_obat", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pembelian_obat")
        dg_Pembelian_Obat.DataSource = Ds.Tables("pembelian_obat")
        dg_Pembelian_Obat.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond

        btn_tambah.Text = "Tambah"
        btn_tambah.Enabled = True
        btn_ubah.Text = "Ubah"
        btn_ubah.Enabled = True
        btn_Hapus.Text = "Hapus"
        btn_Hapus.Enabled = True
        btn_keluar.Text = "Keluar"
        btn_keluar.Enabled = True

        txt_kodeobat.Enabled = False
        txt_namaobat.Enabled = False
        dtpembelian.Enabled = False
        dtExp.Enabled = False
        txt_jenis.Enabled = False
        txt_jumlah.Enabled = False
        txt_harga.Enabled = False

        txt_kodeobat.Text = ""
        txt_namaobat.Text = ""
        dtpembelian.ResetText()
        dtExp.ResetText()
        txt_harga.Text = ""
        txt_jumlah.Text = ""
        txt_jenis.Text = ""
    End Sub
    Sub Isi()
        txt_kodeobat.Enabled = True
        txt_namaobat.Enabled = True
        dtpembelian.Enabled = True
        dtExp.Enabled = True
        txt_harga.Enabled = True
        txt_jumlah.Enabled = True
        txt_jenis.Enabled = True
    End Sub
    Private Sub Pembelian_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilkan()
        LblKodePetugas.Text = FormLogin.txt_petugas.Text
        dtpembelian.Text = Today
        txt_kodeobat.Focus()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call Tampilkan()
        End If
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If btn_tambah.Text = "Tambah" Then
            btn_tambah.Text = "Simpan"
            btn_ubah.Enabled = False
            btn_Hapus.Enabled = False
            btn_keluar.Text = "&Batal"
            Call Isi()
            txt_kodeobat.Focus()
        Else
            If txt_kodeobat.Text = "" Or txt_namaobat.Text = "" Or dtpembelian.Text = "" Or dtExp.Text = "" Or txt_harga.Text = "" Or txt_jumlah.Text = "" Or txt_jenis.Text = "" Or LblKodePetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                txt_kodeobat.Focus()
            Else
                Dim pembelian = New Pembelian With {
                     .kd_obat = txt_kodeobat.Text,
                    .nama_obat = txt_namaobat.Text,
                    .tgl_pembelian = dtpembelian.Text,
                    .exp = dtExp.Text,
                    .Harga = txt_harga.Text,
                    .jumlah_obat = txt_jumlah.Text,
                    .jenis_obat = txt_jenis.Text,
                    .kd_petugas = LblKodePetugas.Text
                }
                Dim Tambah = pembelian.Tambah()
                If (Tambah) Then
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        If btn_ubah.Text = "Ubah" Then
            btn_ubah.Text = "Simpan"
            btn_tambah.Enabled = False
            btn_Hapus.Enabled = False
            btn_keluar.Text = "&Batal"
            Call Isi()
            txt_kodeobat.Focus()
        Else
            If txt_kodeobat.Text = "" Or txt_namaobat.Text = "" Or dtpembelian.Text = "" Or dtExp.Text = "" Or txt_harga.Text = "" Or txt_jumlah.Text = "" Or txt_jenis.Text = "" Or LblKodePetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                txt_kodeobat.Focus()
            Else
                Dim pembelian = New Pembelian With {
                    .kd_obat = txt_kodeobat.Text,
                    .nama_obat = txt_namaobat.Text,
                    .tgl_pembelian = dtpembelian.Text,
                    .exp = dtExp.Text,
                    .Harga = txt_harga.Text,
                    .jumlah_obat = txt_jumlah.Text,
                    .jenis_obat = txt_jenis.Text,
                    .kd_petugas = LblKodePetugas.Text
                }
                Dim Ubah = pembelian.Update()
                If (Ubah) Then
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub

    Private Sub txt_kodeobat_TextChanged(sender As Object, e As EventArgs) Handles txt_kodeobat.TextChanged

    End Sub
    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click
        If btn_Hapus.Text = "Hapus" Then
            btn_Hapus.Text = "Delete"
            btn_tambah.Enabled = False
            btn_ubah.Enabled = False
            btn_keluar.Text = "&Batal"
            Call Isi()
            txt_kodeobat.Focus()
        Else
            If txt_kodeobat.Text = "" Or txt_namaobat.Text = "" Or dtpembelian.Text = "" Or dtExp.Text = "" Or txt_harga.Text = "" Or txt_jumlah.Text = "" Or txt_jenis.Text = "" Or LblKodePetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                txt_kodeobat.Focus()
            Else
                Dim pembelian = New Pembelian With {
                    .kd_obat = txt_kodeobat.Text,
                    .nama_obat = txt_namaobat.Text,
                    .tgl_pembelian = dtpembelian.Text,
                    .exp = dtExp.Text,
                    .Harga = txt_harga.Text,
                    .jumlah_obat = txt_jumlah.Text,
                    .jenis_obat = txt_jenis.Text,
                    .kd_petugas = LblKodePetugas.Text
                }
                Dim hapus = pembelian.Hapus()
                If (hapus) Then
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call Tampilkan()
                Else
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End If
            End If
        End If
    End Sub
    Private Sub txt_kodeobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kodeobat.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = Pembelian.Carikode(txt_kodeobat.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada", MsgBoxStyle.Critical, "WARNING!!")
            Else
                txt_namaobat.Text = hasil.nama_obat
                dtpembelian.Text = hasil.tgl_pembelian
                dtExp.Text = hasil.exp
                txt_harga.Text = hasil.harga
                txt_jumlah.Text = hasil.jumlah_obat
                txt_jenis.Text = hasil.jenis_obat
                LblKodePetugas.Text = hasil.kd_petugas
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Call OpenConn()
        Da = New MySqlDataAdapter("select * from pembelian_obat where nama_obat like '%" & TxtCari.Text & "%'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "pembelian_obat")
        dg_Pembelian_Obat.DataSource = Ds.Tables("pembelian_obat")
        dg_Pembelian_Obat.AllowUserToAddRows = False
        dg_Pembelian_Obat.ReadOnly = True
    End Sub
End Class