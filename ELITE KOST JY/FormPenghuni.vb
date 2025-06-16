Imports MySql.Data.MySqlClient

Public Class FormPenghuni

    Private selectedPenghuniID As Integer = 0
    Private selectedNomorKamarAsal As String = ""

    Private Sub FormPenghuni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Aktif")
        cmbStatus.Items.Add("Tidak Aktif")
        LoadDataPenghuni()
        ClearInput()
    End Sub

    Private Sub LoadDataPenghuni()
        Try
            BukaKoneksi()
            query = "SELECT id_penghuni, nama_penghuni, no_telepon, alamat_asal, tanggal_masuk, nomor_kamar, status FROM tbl_penghuni ORDER BY nama_penghuni ASC"
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvPenghuni.DataSource = dt

            If dgvPenghuni.Columns.Count > 0 Then
                dgvPenghuni.Columns("id_penghuni").Visible = False
                dgvPenghuni.Columns("nama_penghuni").HeaderText = "Nama Penghuni"
                dgvPenghuni.Columns("no_telepon").HeaderText = "No. Telepon"
                dgvPenghuni.Columns("alamat_asal").HeaderText = "Alamat Asal"
                dgvPenghuni.Columns("tanggal_masuk").HeaderText = "Tgl Masuk"
                dgvPenghuni.Columns("nomor_kamar").HeaderText = "No. Kamar"
                dgvPenghuni.Columns("status").HeaderText = "Status"

                dgvPenghuni.Columns("nama_penghuni").DisplayIndex = 0
                dgvPenghuni.Columns("no_telepon").DisplayIndex = 1
                dgvPenghuni.Columns("alamat_asal").DisplayIndex = 2
                dgvPenghuni.Columns("tanggal_masuk").DisplayIndex = 3
                dgvPenghuni.Columns("nomor_kamar").DisplayIndex = 4
                dgvPenghuni.Columns("status").DisplayIndex = 5

                dgvPenghuni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            dgvPenghuni.ClearSelection()
        Catch ex As Exception
            MsgBox("Gagal memuat data penghuni: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Function CekStatusKamar(nomorKamar As String) As String
        Dim statusHasil As String = "Tidak Ditemukan"
        Try
            BukaKoneksi()
            query = "SELECT status FROM tbl_kamar WHERE nomor_kamar = @nomorKamar"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nomorKamar", nomorKamar)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then statusHasil = result.ToString()
        Catch ex As Exception
            MsgBox("Error memeriksa status kamar: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            TutupKoneksi()
        End Try
        Return statusHasil
    End Function

    Private Sub UpdateStatusKamar(nomorKamar As String, statusKamarBaru As String)
        If String.IsNullOrWhiteSpace(nomorKamar) Then Return
        Try
            BukaKoneksi()
            query = "UPDATE tbl_kamar SET status = @status WHERE nomor_kamar = @nomorKamar"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@status", statusKamarBaru)
            cmd.Parameters.AddWithValue("@nomorKamar", nomorKamar)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error saat update status kamar: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles btnTambah.Click'
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtNoKamar.Text) Then
            MsgBox("Nama dan No Kamar harus diisi!", MsgBoxStyle.Exclamation, "Input Tidak Lengkap")
            Return
        End If

        Dim nomorKamarTarget As String = txtNoKamar.Text.Trim()
        If CekStatusKamar(nomorKamarTarget) <> "Tersedia" Then
            MsgBox("Nomor kamar '" & nomorKamarTarget & "' tidak tersedia atau tidak ditemukan.", MsgBoxStyle.Exclamation, "Kamar Tidak Tersedia")
            Return
        End If

        Try
            BukaKoneksi()
            query = "INSERT INTO tbl_penghuni (nama_penghuni, no_telepon, alamat_asal, tanggal_masuk, status, nomor_kamar) VALUES (@nama, @kontak, @alamat, @tgl_masuk, 'Aktif', @nomor_kamar)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            cmd.Parameters.AddWithValue("@kontak", txtKontak.Text.Trim())
            cmd.Parameters.AddWithValue("@alamat", txtAlamatAsal.Text.Trim())
            cmd.Parameters.AddWithValue("@tgl_masuk", dtpTanggalMasuk.Value.Date)
            cmd.Parameters.AddWithValue("@nomor_kamar", nomorKamarTarget)
            cmd.ExecuteNonQuery()

            UpdateStatusKamar(nomorKamarTarget, "Terisi")
            MsgBox("Data penghuni baru berhasil ditambahkan!", MsgBoxStyle.Information, "Sukses")
            LoadDataPenghuni()
            ClearInput()
        Catch ex As Exception
            MsgBox("Gagal menambahkan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles btnEdit.Click'
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If selectedPenghuniID = 0 Then Return

        Dim nomorKamarBaru As String = txtNoKamar.Text.Trim()
        If nomorKamarBaru <> selectedNomorKamarAsal AndAlso CekStatusKamar(nomorKamarBaru) <> "Tersedia" Then
            MsgBox("Nomor kamar baru '" & nomorKamarBaru & "' tidak tersedia atau tidak ditemukan.", MsgBoxStyle.Exclamation, "Kamar Tidak Tersedia")
            Return
        End If

        Try
            BukaKoneksi()
            query = "UPDATE tbl_penghuni SET nama_penghuni = @nama, no_telepon = @kontak, alamat_asal = @alamat, tanggal_masuk = @tgl_masuk, status = @status, nomor_kamar = @nomor_kamar WHERE id_penghuni = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            cmd.Parameters.AddWithValue("@kontak", txtKontak.Text.Trim())
            cmd.Parameters.AddWithValue("@alamat", txtAlamatAsal.Text.Trim())
            cmd.Parameters.AddWithValue("@tgl_masuk", dtpTanggalMasuk.Value.Date)
            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nomor_kamar", nomorKamarBaru)
            cmd.Parameters.AddWithValue("@id", selectedPenghuniID)
            cmd.ExecuteNonQuery()

            If nomorKamarBaru <> selectedNomorKamarAsal Then
                UpdateStatusKamar(selectedNomorKamarAsal, "Tersedia")
                UpdateStatusKamar(nomorKamarBaru, "Terisi")
            End If
            If cmbStatus.SelectedItem.ToString() = "Tidak Aktif" Then
                UpdateStatusKamar(nomorKamarBaru, "Tersedia")
            End If

            MsgBox("Data penghuni berhasil diperbarui!", MsgBoxStyle.Information, "Sukses")
            LoadDataPenghuni()
            ClearInput()
        Catch ex As Exception
            MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedPenghuniID = 0 Then Return

        If MsgBox("Anda yakin ingin menghapus penghuni '" & txtNama.Text & "'? Data akan dihapus permanen dan kamar yang ditempati akan dikosongkan.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
            Try
                BukaKoneksi()
                query = "DELETE FROM tbl_penghuni WHERE id_penghuni = @id" ' Mengubah query untuk menghapus data
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedPenghuniID)
                cmd.ExecuteNonQuery()

                UpdateStatusKamar(selectedNomorKamarAsal, "Tersedia") ' Kamar menjadi tersedia
                MsgBox("Data penghuni berhasil dihapus!", MsgBoxStyle.Information, "Sukses") ' Memperbarui pesan sukses
                LoadDataPenghuni()
                ClearInput()
            Catch ex As Exception
                MsgBox("Gagal menghapus data penghuni: " & ex.Message, MsgBoxStyle.Critical, "Error") ' Memperbarui pesan error
            Finally
                TutupKoneksi()
            End Try
        End If
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles btnClear.Click'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub dgvPenghuni_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPenghuni.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvPenghuni.Rows.Count Then
            If dgvPenghuni.Rows(e.RowIndex).IsNewRow Then Return
            Dim row As DataGridViewRow = dgvPenghuni.Rows(e.RowIndex)

            selectedPenghuniID = Convert.ToInt32(row.Cells("id_penghuni").Value)
            selectedNomorKamarAsal = row.Cells("nomor_kamar").Value.ToString()
            txtNama.Text = row.Cells("nama_penghuni").Value.ToString()
            txtKontak.Text = row.Cells("no_telepon").Value.ToString()
            txtAlamatAsal.Text = row.Cells("alamat_asal").Value.ToString()
            txtNoKamar.Text = selectedNomorKamarAsal
            dtpTanggalMasuk.Value = Convert.ToDateTime(row.Cells("tanggal_masuk").Value)
            cmbStatus.SelectedItem = row.Cells("status").Value.ToString()

            btnEdit.Enabled = True
            btnHapus.Enabled = True
            btnTambah.Enabled = False
        End If
    End Sub



    Private Sub ClearInput()
        txtNama.Clear()
        txtNoKamar.Clear()
        txtKontak.Clear()
        txtAlamatAsal.Clear()
        dtpTanggalMasuk.Value = DateTime.Today
        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
        selectedPenghuniID = 0
        selectedNomorKamarAsal = ""
        dgvPenghuni.ClearSelection()

        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnTambah.Enabled = True
        txtNama.Focus()
    End Sub
End Class