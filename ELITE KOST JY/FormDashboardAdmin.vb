Public Class FormDashboardAdmin
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' (Opsional) Tampilkan default form saat dashboard dibuka
        LoadForm(New FormPenghuni())
    End Sub

    ' Fungsi umum untuk load form ke panelKonten
    Private Sub LoadForm(frm As Form)
        panelKonten.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        panelKonten.Controls.Add(frm)
        frm.Show()
    End Sub

    ' Tombol navigasi
    Private Sub btnPenghuni_Click(sender As Object, e As EventArgs) Handles btnPenghuni.Click
        LoadForm(New FormPenghuni())
    End Sub

    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click
        LoadForm(New FormKamar())
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        LoadForm(New FormPembayaran())
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        LoadForm(New FormLaporan())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            FormLogin.Show()
            Me.Close()
        End If
    End Sub


    Private Sub btnAkunAdmin_Click(sender As Object, e As EventArgs) Handles btnAkunAdmin.Click
        LoadForm(New FormKelolaAdmin())
    End Sub

    Private Sub btnAkunPenghuni_Click(sender As Object, e As EventArgs) Handles btnAkunPenghuni.Click
        LoadForm(New FormAkunPenghuni())
    End Sub
End Class