Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormAkunPenghuni

    ' Variabel untuk menyimpan data yang dipilih dari tabel
    Private penghuniDict As New Dictionary(Of String, Integer)()
    Private selectedAkunID As Integer = 0
    Private selectedUsername As String = ""

    ' Dieksekusi saat form pertama kali dimuat
    Private Sub FormAkunPenghuni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAkun()
        LoadPenghuniTanpaAkun()
        ClearInput()
        btnEdit.Enabled = False ' Pastikan tombol Edit non-aktif di awal
    End Sub

    ' Memuat daftar penghuni yang BELUM memiliki akun ke ComboBox
    Private Sub LoadPenghuniTanpaAkun()
        penghuniDict.Clear()
        cmbPenghuni.DataSource = Nothing
        Dim namaPenghuniList As New List(Of String)()
        Try
            BukaKoneksi()
            query = "SELECT p.id_penghuni, p.nama_penghuni FROM tbl_penghuni p " &
                    "LEFT JOIN tbl_akun_penghuni ap ON p.id_penghuni = ap.id_penghuni " &
                    "WHERE ap.id_akun IS NULL AND p.status = 'Aktif'"
            cmd = New MySqlCommand(query, conn)
            rd = cmd.ExecuteReader()
            While rd.Read()
                penghuniDict.Add(rd.GetString("nama_penghuni"), rd.GetInt32("id_penghuni"))
                namaPenghuniList.Add(rd.GetString("nama_penghuni"))
            End While
            rd.Close()
            cmbPenghuni.DataSource = namaPenghuniList
        Catch ex As Exception
            MsgBox("Gagal memuat daftar penghuni: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Memuat daftar akun yang sudah dibuat ke DataGridView
    Private Sub LoadDataAkun()
        Try
            BukaKoneksi()
            query = "SELECT ap.id_akun, p.nama_penghuni, ap.username FROM tbl_akun_penghuni ap " &
                    "JOIN tbl_penghuni p ON ap.id_penghuni = p.id_penghuni ORDER BY p.nama_penghuni"
            da = New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvAkun.DataSource = dt
            If dgvAkun.Columns.Count > 0 Then
                dgvAkun.Columns("id_akun").Visible = False
                dgvAkun.Columns("nama_penghuni").HeaderText = "Nama Penghuni"
                dgvAkun.Columns("username").HeaderText = "Username"
                dgvAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
            MsgBox("Gagal memuat data akun: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Fungsi Hashing
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

    ' TOMBOL BUAT AKUN
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbPenghuni.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Pilih penghuni serta isi Username dan Password!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            BukaKoneksi()
            query = "INSERT INTO tbl_akun_penghuni (id_penghuni, username, password) VALUES (@id, @uname, @pword)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", penghuniDict(cmbPenghuni.SelectedItem.ToString()))
            cmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@pword", HashPassword(txtPassword.Text))
            cmd.ExecuteNonQuery()
            MsgBox("Akun untuk " & cmbPenghuni.SelectedItem.ToString() & " berhasil dibuat!", MsgBoxStyle.Information)
            RefreshData() ' Memuat ulang semua data dan membersihkan form
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Username '" & txtUsername.Text.Trim() & "' sudah digunakan!", MsgBoxStyle.Critical)
            Else
                MsgBox("Error Database: " & ex.Message, MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Gagal membuat akun: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' TOMBOL EDIT
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedAkunID = 0 Then
            MsgBox("Pilih dulu akun yang akan diedit dari tabel.", MsgBoxStyle.Exclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Username tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim usernameBaru As String = txtUsername.Text.Trim()
        Dim passwordBaru As String = txtPassword.Text

        Try
            BukaKoneksi()
            ' Cek dulu apakah username baru sudah dipakai orang lain
            If usernameBaru.ToLower() <> selectedUsername.ToLower() Then
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_akun_penghuni WHERE username = @uname", conn)
                checkCmd.Parameters.AddWithValue("@uname", usernameBaru)
                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MsgBox("Username '" & usernameBaru & "' sudah digunakan oleh akun lain.", MsgBoxStyle.Critical)
                    TutupKoneksi()
                    Return
                End If
            End If

            Dim queryBuilder As New StringBuilder("UPDATE tbl_akun_penghuni SET username = @uname ")
            cmd = New MySqlCommand()
            cmd.Parameters.AddWithValue("@uname", usernameBaru)

            ' Hanya update password jika field password diisi
            If Not String.IsNullOrWhiteSpace(passwordBaru) Then
                queryBuilder.Append(", password = @pword ")
                cmd.Parameters.AddWithValue("@pword", HashPassword(passwordBaru))
            End If

            queryBuilder.Append("WHERE id_akun = @id_akun")
            cmd.CommandText = queryBuilder.ToString()
            cmd.Parameters.AddWithValue("@id_akun", selectedAkunID)
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            MsgBox("Data akun berhasil diperbarui!", MsgBoxStyle.Information)
            RefreshData()
        Catch ex As Exception
            MsgBox("Gagal memperbarui akun: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' TOMBOL HAPUS AKUN
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedAkunID = 0 Then
            MsgBox("Pilih akun dari tabel yang akan dihapus.", MsgBoxStyle.Exclamation)
            Return
        End If
        If MsgBox("Anda yakin ingin menghapus akun ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                BukaKoneksi()
                query = "DELETE FROM tbl_akun_penghuni WHERE id_akun = @id_akun"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_akun", selectedAkunID)
                cmd.ExecuteNonQuery()
                MsgBox("Akun berhasil dihapus.", MsgBoxStyle.Information)
                RefreshData()
            Catch ex As Exception
                MsgBox("Gagal menghapus akun: " & ex.Message)
            Finally
                TutupKoneksi()
            End Try
        End If
    End Sub

    ' TOMBOL CLEAR
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    ' EVENT SAAT KLIK BARIS DI TABEL
    Private Sub dgvAkun_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAkun.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAkun.Rows(e.RowIndex)

            ' Simpan data penting dari baris yang dipilih
            selectedAkunID = Convert.ToInt32(row.Cells("id_akun").Value)
            selectedUsername = row.Cells("username").Value.ToString()

            ' Masuk ke "Mode Edit"
            cmbPenghuni.Enabled = False
            cmbPenghuni.Text = row.Cells("nama_penghuni").Value.ToString() ' Tampilkan nama (non-aktif)
            txtUsername.Text = selectedUsername ' Tampilkan username untuk diedit
            txtPassword.Clear()

            ' Atur tombol
            btnTambah.Enabled = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    ' Membersihkan form dan kembali ke "Mode Tambah"
    Private Sub ClearInput()
        cmbPenghuni.Enabled = True
        cmbPenghuni.SelectedIndex = -1
        txtUsername.Clear()
        txtPassword.Clear()
        selectedAkunID = 0
        selectedUsername = ""
        dgvAkun.ClearSelection()

        btnTambah.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    ' Memuat ulang semua data setelah ada perubahan
    Private Sub RefreshData()
        LoadDataAkun()
        LoadPenghuniTanpaAkun()
        ClearInput()
    End Sub

End Class