Imports MySql.Data.MySqlClient
Public Class Petugas
    Public kd_petugas As String
    Public nama_petugas As String
    Public password As String
    Public no_hp As String

    Public Function Update()
        Try
            Call OpenConn()
            Dim UpdateData As String = "update petugas set nama_petugas='" & nama_petugas & "', password='" & password & "', no_hp='" & no_hp & "'where kd_petugas='" & kd_petugas & "'"
            Cmd = New MySqlCommand(UpdateData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Carikode(keyword As String)
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from petugas where kd_petugas='" & keyword & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            Return Nothing
        Else
            Dim petugas = New Petugas With {
                .nama_petugas = Rd.Item("nama_petugas"),
                .password = Rd.Item("password"),
                .no_hp = Rd.Item("no_hp")
            }
            Return petugas
        End If
    End Function
    Public Function Hapus()
        Try
            Call OpenConn()
            Dim DeleteData As String = "Delete From petugas where kd_petugas='" & kd_petugas & "'"
            Cmd = New MySqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
