' Namespace yang dibutuhkan
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BukaKoneksi()
        Catch ex As Exception
            MsgBox("Tidak dapat terhubung ke database. Aplikasi akan ditutup." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Koneksi Gagal")
            Application.Exit()
            Return
        End Try

        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Penghuni")
        cmbRole.SelectedIndex = 0
        txtUsername.Focus()
    End Sub

    Public Function HashPassword(password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    ' PERBAIKAN UTAMA ADA DI DALAM SUB INI
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        If cmbRole.SelectedItem Is Nothing Then
            MsgBox("Silakan pilih Role Anda (Admin/Penghuni)!", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Input Tidak Lengkap")
            Return
        End If

        Dim loginSuccess As Boolean = False
        Dim namaUserLogin As String = ""
        Dim idPenghuniLogin As Integer = 0
        Dim usernameInput As String = txtUsername.Text.Trim()
        Dim passwordHashed As String = HashPassword(txtPassword.Text)
        Dim selectedRole As String = cmbRole.SelectedItem.ToString()

        Try
            BukaKoneksi()
            cmd = New MySqlCommand()
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@uname", usernameInput)
            cmd.Parameters.AddWithValue("@pword", passwordHashed)

            If selectedRole = "Admin" Then
                cmd.CommandText = "SELECT nama_lengkap FROM tbl_admin WHERE username = @uname AND password = @pword"
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    namaUserLogin = result.ToString()
                    loginSuccess = True
                End If
            Else ' selectedRole = "Penghuni"
                ' --- PERBAIKAN DI SINI ---
                ' 1. Query diubah untuk mengambil id_penghuni juga
                cmd.CommandText = "SELECT p.id_penghuni, p.nama_penghuni FROM tbl_akun_penghuni ap " &
                                  "INNER JOIN tbl_penghuni p ON ap.id_penghuni = p.id_penghuni " &
                                  "WHERE ap.username = @uname AND ap.password = @pword"

                ' 2. Gunakan ExecuteReader karena kita mengambil lebih dari satu kolom
                rd = cmd.ExecuteReader()

                ' 3. Jika data ditemukan, ambil nama DAN ID
                If rd.Read() Then
                    idPenghuniLogin = rd.GetInt32("id_penghuni") ' <-- ID diambil
                    namaUserLogin = rd.GetString("nama_penghuni") ' <-- Nama diambil
                    loginSuccess = True
                End If
                rd.Close()
                ' --- AKHIR PERBAIKAN ---
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan teknis saat proses login: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            loginSuccess = False
        Finally
            TutupKoneksi()
        End Try

        ' Logika Hasil Akhir Login
        If loginSuccess Then
            MsgBox("Login berhasil! Selamat datang, " & namaUserLogin & ".", MsgBoxStyle.Information, "Login Sukses")

            If selectedRole = "Admin" Then
                Dim frmDashboardAdmin As New FormDashboardAdmin()
                frmDashboardAdmin.Show()
            Else
                ' Sekarang idPenghuniLogin sudah berisi ID yang benar, bukan 0 lagi
                Dim frmDashboardPenghuni As New FormDashboardPenghuni(idPenghuniLogin)
                frmDashboardPenghuni.Show()
            End If
            Me.Hide()
        Else
            MsgBox("Login gagal! Periksa kembali Username, Password, dan Role Anda.", MsgBoxStyle.Critical, "Login Gagal")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        If MsgBox("Apakah Anda yakin ingin keluar dari aplikasi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi Keluar") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class