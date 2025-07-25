﻿Imports MySql.Data.MySqlClient

Public Class FormKamar

    Private selectedNomorKamar As String = ""

    Private Sub FormKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataKamar()
        cmbTipe.Items.Clear()
        cmbTipe.Items.AddRange({"AC + KM Dalam", "Non-AC"})
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"Tersedia", "Terisi"})
        ClearInput()
    End Sub

    Private Sub LoadDataKamar()
        Try
            BukaKoneksi()
            query = "SELECT nomor_kamar, tipe, harga, status FROM tbl_kamar ORDER BY nomor_kamar ASC"
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvKamar.DataSource = dt

            If dgvKamar.Columns.Count > 0 Then
                dgvKamar.Columns("nomor_kamar").HeaderText = "No. Kamar"
                dgvKamar.Columns("tipe").HeaderText = "Tipe Kamar"
                dgvKamar.Columns("harga").HeaderText = "Harga (Rp)"
                dgvKamar.Columns("harga").DefaultCellStyle.Format = "N0"
                dgvKamar.Columns("status").HeaderText = "Status"
                dgvKamar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            dgvKamar.ClearSelection()
        Catch ex As Exception
            MsgBox("Gagal memuat data kamar: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan Handles
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrWhiteSpace(txtNoKamar.Text) OrElse String.IsNullOrWhiteSpace(txtHarga.Text) OrElse cmbTipe.SelectedItem Is Nothing OrElse cmbStatus.SelectedItem Is Nothing Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation, "Input Tidak Lengkap")
            Return
        End If

        Dim hargaKamar As Decimal
        If Not Decimal.TryParse(txtHarga.Text, hargaKamar) Then
            MsgBox("Harga harus berupa angka!", MsgBoxStyle.Exclamation, "Input Salah")
            Return
        End If

        Try
            BukaKoneksi()
            query = "INSERT INTO tbl_kamar (nomor_kamar, tipe, harga, status) VALUES (@nomor_kamar, @tipe, @harga, @status)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nomor_kamar", txtNoKamar.Text.Trim())
            cmd.Parameters.AddWithValue("@tipe", cmbTipe.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@harga", hargaKamar)
            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            MsgBox("Data kamar baru berhasil ditambahkan!", MsgBoxStyle.Information, "Sukses")
            LoadDataKamar()
            ClearInput()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("Nomor kamar '" & txtNoKamar.Text.Trim() & "' sudah ada. Gunakan nomor lain.", MsgBoxStyle.Exclamation, "Nomor Kamar Duplikat")
            Else
                MsgBox("Gagal menambahkan data: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            End If
        Catch ex As Exception
            MsgBox("Gagal menambahkan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan Handles
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(selectedNomorKamar) Then
            MsgBox("Silakan pilih data kamar yang akan diedit.", MsgBoxStyle.Exclamation, "Data Belum Dipilih")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtHarga.Text) OrElse cmbTipe.SelectedItem Is Nothing OrElse cmbStatus.SelectedItem Is Nothing Then
            MsgBox("Semua field harus diisi!", MsgBoxStyle.Exclamation, "Input Tidak Lengkap")
            Return
        End If

        Dim hargaKamar As Decimal
        If Not Decimal.TryParse(txtHarga.Text, hargaKamar) Then
            MsgBox("Harga harus berupa angka!", MsgBoxStyle.Exclamation, "Input Salah")
            Return
        End If

        If dgvKamar.CurrentRow.Cells("status").Value.ToString() = "Terisi" AndAlso cmbStatus.SelectedItem.ToString() = "Tersedia" Then
            If MsgBox("Kamar ini sedang 'Terisi'. Mengubah statusnya menjadi 'Tersedia' dapat menyebabkan data tidak konsisten. Lanjutkan?",
                      MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Peringatan Status") = MsgBoxResult.No Then
                Return
            End If
        End If

        Try
            BukaKoneksi()
            query = "UPDATE tbl_kamar SET tipe = @tipe, harga = @harga, status = @status WHERE nomor_kamar = @nomor_kamar_key"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@tipe", cmbTipe.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@harga", hargaKamar)
            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nomor_kamar_key", selectedNomorKamar)
            cmd.ExecuteNonQuery()

            MsgBox("Data kamar berhasil diperbarui!", MsgBoxStyle.Information, "Sukses")
            LoadDataKamar()
            ClearInput()
        Catch ex As Exception
            MsgBox("Gagal memperbarui data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan Handles
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrWhiteSpace(selectedNomorKamar) Then
            MsgBox("Silakan pilih data kamar yang akan dihapus.", MsgBoxStyle.Exclamation, "Data Belum Dipilih")
            Return
        End If

        If dgvKamar.CurrentRow.Cells("status").Value.ToString() = "Terisi" Then
            MsgBox("Kamar ini sedang 'Terisi' oleh penghuni dan tidak bisa dihapus. Keluarkan penghuni terlebih dahulu melalui form Data Penghuni.", MsgBoxStyle.Exclamation, "Aksi Ditolak")
            Return
        End If

        If MsgBox("Anda yakin ingin menghapus kamar '" & selectedNomorKamar & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi Hapus") = MsgBoxResult.Yes Then
            Try
                BukaKoneksi()
                query = "DELETE FROM tbl_kamar WHERE nomor_kamar = @nomor_kamar"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nomor_kamar", selectedNomorKamar)
                cmd.ExecuteNonQuery()

                MsgBox("Data kamar berhasil dihapus!", MsgBoxStyle.Information, "Sukses")
                LoadDataKamar()
                ClearInput()
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                TutupKoneksi()
            End Try
        End If
    End Sub

    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvKamar.Rows.Count Then
            If dgvKamar.Rows(e.RowIndex).IsNewRow Then Return
            Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)

            selectedNomorKamar = row.Cells("nomor_kamar").Value.ToString()

            txtNoKamar.Text = selectedNomorKamar
            cmbTipe.SelectedItem = row.Cells("tipe").Value.ToString()
            txtHarga.Text = Convert.ToDecimal(row.Cells("harga").Value).ToString("N0")
            cmbStatus.SelectedItem = row.Cells("status").Value.ToString()

            btnEdit.Enabled = True
            btnHapus.Enabled = True
            btnTambah.Enabled = False
            txtNoKamar.ReadOnly = True
        End If
    End Sub

    ' PERBAIKAN: Menambahkan Handles
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub ClearInput()
        txtNoKamar.Clear()
        txtHarga.Clear()
        If cmbTipe.Items.Count > 0 Then cmbTipe.SelectedIndex = 0
        If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
        selectedNomorKamar = ""
        dgvKamar.ClearSelection()
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnTambah.Enabled = True
        txtNoKamar.ReadOnly = False
        txtNoKamar.Focus()
    End Sub

End Class