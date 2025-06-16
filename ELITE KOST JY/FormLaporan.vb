Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class FormLaporan

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFilterComboBoxes()
        dgvLaporan.DataSource = Nothing
        lblTotal.Text = "Total : Rp 0"
    End Sub

    Private Sub LoadFilterComboBoxes()
        cmbBulan.Items.Clear()
        cmbBulan.Items.Add("Semua Bulan")
        cmbBulan.Items.AddRange(DateTimeFormatInfo.CurrentInfo.MonthNames)
        cmbBulan.Items.Remove("")
        cmbBulan.SelectedIndex = 0

        cmbTahun.Items.Clear()
        For thn As Integer = 2023 To Date.Now.Year + 1
            cmbTahun.Items.Add(thn)
        Next
        cmbTahun.SelectedItem = Date.Now.Year

        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"Semua Status", "Lunas", "Lunas via Transfer", "DP", "Belum Lunas"})
        cmbStatus.SelectedIndex = 0
    End Sub

    ' Pastikan baris ini memiliki "Handles btnTampilkan.Click"
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Try
            BukaKoneksi()
            Dim conditions As New List(Of String)()
            cmd = New MySqlCommand()

            Dim baseQuery As String = "SELECT nama_penghuni, nomor_kamar, bulan_bayar, jumlah_bayar, tanggal_bayar, keterangan " &
                                      "FROM tbl_pembayaran"

            conditions.Add("YEAR(tanggal_bayar) = @tahun")
            cmd.Parameters.AddWithValue("@tahun", Convert.ToInt32(cmbTahun.SelectedItem))

            If cmbBulan.SelectedIndex > 0 Then
                conditions.Add("MONTH(tanggal_bayar) = @bulan")
                cmd.Parameters.AddWithValue("@bulan", cmbBulan.SelectedIndex)
            End If

            If cmbStatus.SelectedItem.ToString() <> "Semua Status" Then
                conditions.Add("keterangan = @status")
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
            End If

            query = baseQuery & " WHERE " & String.Join(" AND ", conditions) & " ORDER BY tanggal_bayar ASC"

            cmd.Connection = conn
            cmd.CommandText = query

            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvLaporan.DataSource = dt
            AturTampilanGrid()

            Dim total As Decimal = 0
            If dt.Rows.Count > 0 Then
                total = dt.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("jumlah_bayar"))
            End If
            lblTotal.Text = "Total : " & total.ToString("c", New CultureInfo("id-ID"))

            If dt.Rows.Count = 0 Then
                MsgBox("Tidak ada data yang ditemukan untuk filter yang dipilih.", MsgBoxStyle.Information, "Info")
            End If
        Catch ex As Exception
            MsgBox("Gagal menampilkan laporan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub AturTampilanGrid()
        If dgvLaporan.Columns.Count > 0 Then
            dgvLaporan.Columns("nama_penghuni").HeaderText = "Nama Penghuni"
            dgvLaporan.Columns("nomor_kamar").HeaderText = "No. Kamar"
            dgvLaporan.Columns("bulan_bayar").HeaderText = "Pembayaran Bulan"
            dgvLaporan.Columns("jumlah_bayar").HeaderText = "Jumlah"
            dgvLaporan.Columns("tanggal_bayar").HeaderText = "Tgl. Bayar"
            dgvLaporan.Columns("keterangan").HeaderText = "Keterangan"
            dgvLaporan.Columns("jumlah_bayar").DefaultCellStyle.Format = "N0"
            dgvLaporan.Columns("tanggal_bayar").DefaultCellStyle.Format = "dd MMM yyyy"
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

End Class