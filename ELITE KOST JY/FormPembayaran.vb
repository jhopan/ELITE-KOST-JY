Imports MySql.Data.MySqlClient
Imports System.Globalization ' Diperlukan untuk format tanggal dan angka

Public Class FormPembayaran

    Private penghuniDict As New Dictionary(Of String, Integer)()
    Private selectedPembayaranID As Integer = 0

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPenghuniComboBox()
        LoadKeteranganComboBox()
        LoadDataPembayaran()
        ClearInput()
    End Sub

    Private Sub LoadPenghuniComboBox()
        penghuniDict.Clear()
        cmbNama.DataSource = Nothing
        Dim namaPenghuniList As New List(Of String)()
        Try
            BukaKoneksi()
            query = "SELECT id_penghuni, nama_penghuni FROM tbl_penghuni WHERE status = 'Aktif' ORDER BY nama_penghuni ASC"
            cmd = New MySqlCommand(query, conn)
            rd = cmd.ExecuteReader()
            While rd.Read()
                penghuniDict.Add(rd.GetString("nama_penghuni"), rd.GetInt32("id_penghuni"))
                namaPenghuniList.Add(rd.GetString("nama_penghuni"))
            End While
            rd.Close()
            cmbNama.DataSource = namaPenghuniList
        Catch ex As Exception
            MsgBox("Gagal memuat data penghuni: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub LoadKeteranganComboBox()
        cmbKeterangan.Items.Clear()
        cmbKeterangan.Items.AddRange({"Lunas", "Lunas via Transfer", "DP", "Belum Lunas"})
        cmbKeterangan.SelectedIndex = 0
    End Sub

    Private Sub LoadDataPembayaran()
        Try
            BukaKoneksi()
            query = "SELECT id_pembayaran, nama_penghuni, nomor_kamar, bulan_bayar, jumlah_bayar, tanggal_bayar, keterangan " &
                    "FROM tbl_pembayaran ORDER BY tanggal_bayar DESC"
            da = New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvPembayaran.DataSource = dt

            If dgvPembayaran.Columns.Count > 0 Then
                dgvPembayaran.Columns("id_pembayaran").Visible = False
                dgvPembayaran.Columns("nama_penghuni").HeaderText = "Nama Penghuni"
                dgvPembayaran.Columns("nomor_kamar").HeaderText = "No. Kamar"
                dgvPembayaran.Columns("bulan_bayar").HeaderText = "Bulan Bayar"
                dgvPembayaran.Columns("jumlah_bayar").HeaderText = "Jumlah (Rp)"
                dgvPembayaran.Columns("tanggal_bayar").HeaderText = "Tgl. Bayar"
                dgvPembayaran.Columns("keterangan").HeaderText = "Keterangan"
                dgvPembayaran.Columns("jumlah_bayar").DefaultCellStyle.Format = "N0"
                dgvPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        Catch ex As Exception
            MsgBox("Gagal memuat riwayat pembayaran: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles cmbNama.SelectedIndexChanged'
    Private Sub cmbNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNama.SelectedIndexChanged
        If cmbNama.SelectedItem Is Nothing Then Return
        Try
            BukaKoneksi()
            query = "SELECT p.nomor_kamar, k.harga FROM tbl_penghuni p JOIN tbl_kamar k ON p.nomor_kamar = k.nomor_kamar WHERE p.id_penghuni = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", penghuniDict(cmbNama.SelectedItem.ToString()))
            rd = cmd.ExecuteReader()
            If rd.Read() Then
                txtNoKamar.Text = rd("nomor_kamar").ToString()
                ' Format harga dengan pemisah ribuan saat ditampilkan
                txtJumlah.Text = Convert.ToDecimal(rd("harga")).ToString("N0")
            End If
            rd.Close()
        Catch ex As Exception
            MsgBox("Gagal mengambil detail kamar: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles btnTambah.Click'
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbNama.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(txtJumlah.Text) Then
            MsgBox("Nama Penghuni dan Jumlah Bayar harus diisi!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' PERBAIKAN: Mengatasi format angka dengan pemisah ribuan (misal: 1,500,000)
        Dim jumlahBayar As Decimal
        Try
            jumlahBayar = Decimal.Parse(txtJumlah.Text, NumberStyles.Any, New CultureInfo("id-ID"))
        Catch ex As FormatException
            MsgBox("Format Jumlah Bayar tidak valid. Harap masukkan angka saja.", MsgBoxStyle.Exclamation)
            Return
        End Try

        Dim cultureInfo As New CultureInfo("id-ID")
        Dim bulanBayar As String = dtpTanggalBayar.Value.ToString("MMMM yyyy", cultureInfo)

        Try
            BukaKoneksi()
            query = "INSERT INTO tbl_pembayaran (id_penghuni, nama_penghuni, nomor_kamar, bulan_bayar, jumlah_bayar, tanggal_bayar, keterangan) " &
                    "VALUES (@id, @nama, @nokamar, @bulan, @jumlah, @tgl, @ket)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", penghuniDict(cmbNama.SelectedItem.ToString()))
            cmd.Parameters.AddWithValue("@nama", cmbNama.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@nokamar", txtNoKamar.Text)
            cmd.Parameters.AddWithValue("@bulan", bulanBayar)
            cmd.Parameters.AddWithValue("@jumlah", jumlahBayar) ' <-- Menggunakan variabel yang sudah bersih
            cmd.Parameters.AddWithValue("@tgl", dtpTanggalBayar.Value.Date)
            cmd.Parameters.AddWithValue("@ket", cmbKeterangan.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            MsgBox("Data pembayaran berhasil disimpan!", MsgBoxStyle.Information)
            LoadDataPembayaran()
            ClearInput()
        Catch ex As Exception
            MsgBox("Gagal menyimpan data pembayaran: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles btnHapus.Click'
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedPembayaranID = 0 Then
            MsgBox("Pilih data pembayaran dari tabel yang akan dihapus.", MsgBoxStyle.Exclamation)
            Return
        End If
        If MsgBox("Anda yakin ingin menghapus data pembayaran ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                BukaKoneksi()
                query = "DELETE FROM tbl_pembayaran WHERE id_pembayaran = @id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedPembayaranID)
                cmd.ExecuteNonQuery()
                MsgBox("Data pembayaran berhasil dihapus!", MsgBoxStyle.Information)
                LoadDataPembayaran()
                ClearInput()
            Catch ex As Exception
                MsgBox("Gagal menghapus data: " & ex.Message)
            Finally
                TutupKoneksi()
            End Try
        End If
    End Sub

    ' PERBAIKAN: Menambahkan 'Handles btnClear.Click'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub ClearInput()
        cmbNama.SelectedIndex = -1
        txtNoKamar.Clear()
        txtJumlah.Clear()
        dtpTanggalBayar.Value = Date.Now
        If cmbKeterangan.Items.Count > 0 Then cmbKeterangan.SelectedIndex = 0
        selectedPembayaranID = 0
        dgvPembayaran.ClearSelection()
        btnHapus.Enabled = False
        btnTambah.Enabled = True
    End Sub

    Private Sub dgvPembayaran_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembayaran.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPembayaran.Rows(e.RowIndex)
            selectedPembayaranID = Convert.ToInt32(row.Cells("id_pembayaran").Value)
            btnHapus.Enabled = True
            btnTambah.Enabled = False
        End If
    End Sub
End Class