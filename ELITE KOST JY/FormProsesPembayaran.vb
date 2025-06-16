Imports System.Globalization

Public Class FormProsesPembayaran

    Private ReadOnly _namaPenghuni As String
    Private ReadOnly _noKamar As String
    Private ReadOnly _hargaSewa As String

    Public Sub New(nama As String, noKamar As String, harga As String)
        InitializeComponent()
        _namaPenghuni = nama
        _noKamar = noKamar
        _hargaSewa = harga
    End Sub

    Private Sub FormProsesPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDetailPembayaran.Text = "Pembayaran Sewa Kamar " & _noKamar & " a/n " & _namaPenghuni
        lblJumlahTagihan.Text = "Jumlah Tagihan: " & _hargaSewa

        ' Atur kondisi awal: Pilih Transfer Bank dan tampilkan panelnya
        rdoTransfer.Checked = True
        panelTransfer.Visible = True
        panelQris.Visible = False

        ' Ganti path di bawah ini dengan lokasi file gambar QRIS Anda
        Dim pathGambarQris As String = "C:\Users\ACER\source\repos\ELITE KOST JY\ELITE KOST JY\Resources\ContohQris.png"

        Try
            If System.IO.File.Exists(pathGambarQris) Then
                pbQris.Image = Image.FromFile(pathGambarQris)
            Else
                Dim bmp As New Bitmap(pbQris.Width, pbQris.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.DrawString("Gambar QRIS tidak ditemukan di " & pathGambarQris, New Font("Arial", 8), Brushes.Black, 10, 10)
                End Using
                pbQris.Image = bmp
            End If
        Catch ex As Exception
            MsgBox("Gagal memuat gambar QRIS: " & ex.Message)
        End Try
    End Sub

    ' Event ini berjalan saat pilihan RadioButton "Transfer Bank" berubah
    Private Sub rdoTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTransfer.CheckedChanged
        If rdoTransfer.Checked Then
            panelTransfer.Visible = True
            panelQris.Visible = False
        End If
    End Sub

    ' Event ini berjalan saat pilihan RadioButton "QRIS" berubah
    Private Sub rdoQris_CheckedChanged(sender As Object, e As EventArgs) Handles rdoQris.CheckedChanged
        If rdoQris.Checked Then
            panelQris.Visible = True
            panelTransfer.Visible = False
        End If
    End Sub

    ' Event untuk tombol selesai/konfirmasi
    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        MsgBox("Terima kasih! Pembayaran Anda akan segera kami verifikasi oleh Admin.", MsgBoxStyle.Information, "Konfirmasi Terkirim")
        Me.Close()
    End Sub

End Class