Imports MySql.Data.MySqlClient

''' <summary>
''' Modul ini berfungsi sebagai pusat koneksi dan interaksi dengan database MySQL.
''' Semua form lain akan menggunakan modul ini untuk berkomunikasi dengan database.
''' </summary>
Module modKoneksi

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public rd As MySqlDataReader
    Public query As String

    ' Ganti password_anda dengan password MySQL Anda, atau kosongkan jika tidak ada password.
    Private Const ConnectionString As String = "Server=localhost;Database=kost_elite_jy_db;Uid=root;Pwd=;"

    ''' <summary>
    ''' Membuka koneksi ke database jika koneksi belum terbuka.
    ''' </summary>
    Public Sub BukaKoneksi()
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection(ConnectionString)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                ' Aktifkan baris di bawah ini untuk testing koneksi
                ' MsgBox("Koneksi ke server MySQL berhasil dibuka!", MsgBoxStyle.Information)
            End If
        Catch ex As MySqlException
            MsgBox("Gagal membuka koneksi ke database: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' Menutup koneksi ke database jika masih terbuka.
    ''' </summary>
    Public Sub TutupKoneksi()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As MySqlException
            MsgBox("Gagal menutup koneksi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module
