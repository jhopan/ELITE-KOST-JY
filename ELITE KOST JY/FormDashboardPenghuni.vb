Imports MySql.Data.MySqlClient
Imports System.Globalization ' Penting untuk format Rupiah

Public Class FormDashboardPenghuni

    ' Variabel privat untuk menyimpan ID penghuni yang sedang login.
    ' ReadOnly berarti nilainya hanya bisa diisi sekali saat form dibuat.
    Private ReadOnly _idPenghuniLogin As Integer

    ' Ini adalah Constructor. Sub ini akan berjalan pertama kali saat form dibuat.
    ' Ia menerima "bekal" berupa ID penghuni dari FormLogin.
    Public Sub New(idPenghuni As Integer)
        ' Panggilan ini wajib ada untuk sebuah form.
        InitializeComponent()

        ' Simpan ID penghuni yang dikirim dari FormLogin ke dalam variabel privat.
        _idPenghuniLogin = idPenghuni
    End Sub

    ' Event ini berjalan otomatis saat form selesai dibuat dan siap ditampilkan.
    Private Sub FormDashboardPenghuni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form dimuat, panggil subrutin untuk mengisi semua data.
        TampilkanInfoProfil()
        TampilkanRiwayatPembayaran()
    End Sub

    ' Subrutin untuk mengambil dan menampilkan data profil & kamar.
    ' Di dalam FormDashboardPenghuni.vb
    Private Sub TampilkanInfoProfil()
        Try
            BukaKoneksi()
            ' Kita perlu mengambil tanggal_masuk juga
            query = "SELECT p.nama_penghuni, p.nomor_kamar, p.tanggal_masuk, k.tipe, k.harga FROM tbl_penghuni p " &
                "JOIN tbl_kamar k ON p.nomor_kamar = k.nomor_kamar WHERE p.id_penghuni = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", _idPenghuniLogin)
            rd = cmd.ExecuteReader()

            If rd.Read() Then
                lblSelamatDatang.Text = "Selamat Datang, " & rd("nama_penghuni").ToString()
                lblNomorKamar.Text = "Nomor Kamar: " & rd("nomor_kamar").ToString()
                lblTipeKamar.Text = "Tipe Kamar: " & rd("tipe").ToString()
                lblHarga.Text = "Harga Sewa: " & Convert.ToDecimal(rd("harga")).ToString("c", New CultureInfo("id-ID"))

                ' --- BAGIAN BARU: HITUNG JATUH TEMPO ---
                Dim tanggalMasuk As Date = rd.GetDateTime("tanggal_masuk")
                Dim jatuhTempo As Date = tanggalMasuk.AddMonths(1) ' Jatuh tempo adalah 1 bulan setelah tanggal masuk/pembayaran terakhir
                lblJatuhTempo.Text = "Jatuh Tempo Berikutnya: " & jatuhTempo.ToString("dd MMMM yyyy")
                '--------------------------------------
            End If
            rd.Close()
        Catch ex As Exception
            MsgBox("Gagal memuat info profil Anda: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Subrutin untuk mengambil dan menampilkan riwayat pembayaran.
    Private Sub TampilkanRiwayatPembayaran()
        Try
            BukaKoneksi()
            ' Query ini mengambil semua pembayaran yang cocok dengan ID penghuni yang login
            query = "SELECT tanggal_bayar, bulan_bayar, jumlah_bayar, keterangan FROM tbl_pembayaran " &
                    "WHERE id_penghuni = @id ORDER BY tanggal_bayar DESC"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", _idPenghuniLogin)
            da = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRiwayat.DataSource = dt

            ' Atur tampilan header dan format kolom di DataGridView
            If dgvRiwayat.Columns.Count > 0 Then
                dgvRiwayat.Columns("tanggal_bayar").HeaderText = "Tgl. Bayar"
                dgvRiwayat.Columns("bulan_bayar").HeaderText = "Pembayaran Bulan"
                dgvRiwayat.Columns("jumlah_bayar").HeaderText = "Jumlah (Rp)"
                dgvRiwayat.Columns("keterangan").HeaderText = "Keterangan"

                ' Atur format kolom
                dgvRiwayat.Columns("jumlah_bayar").DefaultCellStyle.Format = "N0" ' Format angka dengan pemisah ribuan
                dgvRiwayat.Columns("tanggal_bayar").DefaultCellStyle.Format = "dd MMMM yyyy" ' Format tanggal lebih jelas

                dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

        Catch ex As Exception
            MsgBox("Gagal memuat riwayat pembayaran: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' Event untuk tombol Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Anda yakin ingin logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim frmLogin As New FormLogin()
            frmLogin.Show()
            Me.Close() ' Tutup form dashboard ini
        End If
    End Sub

    ' Di dalam FormDashboardPenghuni.vb
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        ' Ambil data yang diperlukan untuk dikirim ke form pembayaran
        Dim nama As String = lblSelamatDatang.Text.Replace("Selamat Datang, ", "")
        Dim noKamar As String = lblNomorKamar.Text.Replace("Nomor Kamar: ", "")
        Dim harga As String = lblHarga.Text.Replace("Harga Sewa: ", "")

        ' Buat dan tampilkan form pembayaran baru sambil mengirim data
        Dim frmBayar As New FormProsesPembayaran(nama, noKamar, harga)
        frmBayar.ShowDialog()
    End Sub

End Class