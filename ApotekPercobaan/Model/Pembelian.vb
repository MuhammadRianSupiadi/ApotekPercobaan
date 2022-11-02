Imports MySql.Data.MySqlClient
Public Class Pembelian
    Public kd_obat As String
    Public nama_obat As String
    Public tgl_pembelian As Date
    Public exp As Date
    Public Harga As Decimal
    Public jumlah_obat As Integer
    Public jenis_obat As String
    Public kd_petugas As String

    Public Function Update()
        Try
            Call OpenConn()
            Dim UpdateData As String = "update pembelian_obat set nama_obat='" & nama_obat & "', tgl_pembelian='" & Format(tgl_pembelian, "yyyy-MM-dd") & "', exp='" & Format(exp, "yyyy-MM-dd") & "', harga='" & Harga & "', jumlah_obat='" & jumlah_obat & "', jenis_obat ='" & jenis_obat & "', kd_petugas='" & kd_petugas & "' where kd_obat='" & kd_obat & "'"
            Cmd = New MySqlCommand(UpdateData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Tambah()
        Try
            Call OpenConn()
            Dim TambahData As String = "insert into pembelian_obat values ('" & kd_obat & "','" & nama_obat & "','" & Format(tgl_pembelian, "yyyy-MM-dd") & "','" & Format(exp, "yyyy-MM-dd") & "', '" & Harga & "','" & jumlah_obat & "', '" & jenis_obat & "', '" & kd_petugas & "')"
            Cmd = New MySqlCommand(TambahData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Hapus()
        Try
            Call OpenConn()
            Dim DeleteData As String = "Delete From pembelian_obat where kd_obat='" & kd_obat & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Carikode(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("select * from pembelian_obat where kd_obat='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim pembelian = New Pembelian With {
                .nama_obat = Rd.Item("nama_obat"),
                .tgl_pembelian = Rd.Item("tgl_pembelian"),
                .exp = Rd.Item("exp"),
                .Harga = Rd.Item("harga"),
                .jumlah_obat = Rd.Item("jumlah_obat"),
                .jenis_obat = Rd.Item("jenis_obat"),
                .kd_petugas = Rd.Item("kd_petugas")
            }
            Return pembelian
        End If
    End Function
End Class
