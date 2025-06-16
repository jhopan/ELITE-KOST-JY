Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormKelolaAdmin

    Private selectedUsername As String = ""

    Private Sub FormKelolaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAdmin()
        ClearInput()
    End Sub

    Private Sub LoadDataAdmin()
        Try
            BukaKoneksi()
            ' Mengambil kolom nama_lengkap dari database
            query = "SELECT username, nama_lengkap FROM tbl_admin ORDER BY username ASC"
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvAdmin.DataSource = dt

            If dgvAdmin.Columns.Count > 0 Then
                dgvAdmin.Columns("username").HeaderText = "Username"
                dgvAdmin.Columns("nama_lengkap").HeaderText = "Nama"
                dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
            MsgBox("Gagal memuat data admin: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' Menggunakan txtNama sesuai desain baru Anda
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            BukaKoneksi()
            ' Menyimpan ke kolom nama_lengkap di database
            query = "INSERT INTO tbl_admin (nama_lengkap, username, password) VALUES (@nama, @uname, @pword)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            cmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@pword", HashPassword(txtPassword.Text))
            cmd.ExecuteNonQuery()
            MsgBox("Admin baru berhasil ditambahkan!", MsgBoxStyle.Information)
            LoadDataAdmin()
            ClearInput()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Username '" & txtUsername.Text.Trim() & "' sudah digunakan!", MsgBoxStyle.Critical)
            Else
                MsgBox("Error Database: " & ex.Message, MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' FUNGSI EDIT BARU
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(selectedUsername) Then
            MsgBox("Pilih admin yang akan diedit dari daftar.", MsgBoxStyle.Exclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Field Nama tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            BukaKoneksi()
            Dim queryBuilder As New StringBuilder()
            queryBuilder.Append("UPDATE tbl_admin SET nama_lengkap = @nama ")
            cmd = New MySqlCommand()
            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())

            ' Hanya update password jika field password diisi
            If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
                queryBuilder.Append(", password = @pword ")
                cmd.Parameters.AddWithValue("@pword", HashPassword(txtPassword.Text))
            End If

            queryBuilder.Append("WHERE username = @username_key")
            cmd.CommandText = queryBuilder.ToString()
            cmd.Parameters.AddWithValue("@username_key", selectedUsername)
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            MsgBox("Data admin berhasil diperbarui!", MsgBoxStyle.Information)
            LoadDataAdmin()
            ClearInput()

        Catch ex As Exception
            MsgBox("Gagal memperbarui data admin: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrWhiteSpace(selectedUsername) Then
            MsgBox("Pilih admin yang akan dihapus dari daftar.", MsgBoxStyle.Exclamation)
            Return
        End If
        If dgvAdmin.Rows.Count <= 1 Then
            MsgBox("Tidak dapat menghapus satu-satunya admin yang tersisa.", MsgBoxStyle.Exclamation)
            Return
        End If
        If MsgBox("Anda yakin ingin menghapus admin '" & selectedUsername & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
            Try
                BukaKoneksi()
                query = "DELETE FROM tbl_admin WHERE username = @uname"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uname", selectedUsername)
                cmd.ExecuteNonQuery()
                MsgBox("Admin berhasil dihapus.", MsgBoxStyle.Information)
                LoadDataAdmin()
                ClearInput()
            Catch ex As Exception
                MsgBox("Gagal menghapus admin: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                TutupKoneksi()
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub dgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAdmin.Rows(e.RowIndex)
            selectedUsername = row.Cells("username").Value.ToString()

            ' Tampilkan data ke form untuk mode Edit/Hapus
            txtUsername.Text = selectedUsername
            ' Menggunakan kolom 'nama_lengkap' dari database
            txtNama.Text = row.Cells("nama_lengkap").Value.ToString()
            txtPassword.Clear()

            ' Masuk ke "Mode Edit"
            btnHapus.Enabled = True
            btnEdit.Enabled = True
            btnTambah.Enabled = False
            txtUsername.ReadOnly = True ' Username (kunci) tidak bisa diedit
        End If
    End Sub

    Private Sub ClearInput()
        ' Menggunakan txtNama sesuai desain baru Anda
        txtNama.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        selectedUsername = ""
        dgvAdmin.ClearSelection()

        ' Kembali ke "Mode Tambah"
        btnHapus.Enabled = False
        btnEdit.Enabled = False
        btnTambah.Enabled = True
        txtUsername.ReadOnly = False
        txtNama.Focus()
    End Sub
End Class