<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvPembayaran = New System.Windows.Forms.DataGridView()
        Me.grpPenghuni = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cmbKeterangan = New System.Windows.Forms.ComboBox()
        Me.dtpTanggalBayar = New System.Windows.Forms.DateTimePicker()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.txtNoKamar = New System.Windows.Forms.TextBox()
        Me.cmbNama = New System.Windows.Forms.ComboBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblTanggalBayar = New System.Windows.Forms.Label()
        Me.lblJumlahBayar = New System.Windows.Forms.Label()
        Me.lblBulanBayar = New System.Windows.Forms.Label()
        Me.lblNomorKamar = New System.Windows.Forms.Label()
        Me.lblNamaPenghuni = New System.Windows.Forms.Label()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPenghuni.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPembayaran
        '
        Me.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembayaran.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvPembayaran.Location = New System.Drawing.Point(0, 0)
        Me.dgvPembayaran.Name = "dgvPembayaran"
        Me.dgvPembayaran.RowHeadersWidth = 51
        Me.dgvPembayaran.RowTemplate.Height = 24
        Me.dgvPembayaran.Size = New System.Drawing.Size(706, 733)
        Me.dgvPembayaran.TabIndex = 0
        '
        'grpPenghuni
        '
        Me.grpPenghuni.Controls.Add(Me.btnClear)
        Me.grpPenghuni.Controls.Add(Me.btnHapus)
        Me.grpPenghuni.Controls.Add(Me.btnEdit)
        Me.grpPenghuni.Controls.Add(Me.btnTambah)
        Me.grpPenghuni.Controls.Add(Me.cmbKeterangan)
        Me.grpPenghuni.Controls.Add(Me.dtpTanggalBayar)
        Me.grpPenghuni.Controls.Add(Me.txtJumlah)
        Me.grpPenghuni.Controls.Add(Me.cmbBulan)
        Me.grpPenghuni.Controls.Add(Me.txtNoKamar)
        Me.grpPenghuni.Controls.Add(Me.cmbNama)
        Me.grpPenghuni.Controls.Add(Me.lblKeterangan)
        Me.grpPenghuni.Controls.Add(Me.lblTanggalBayar)
        Me.grpPenghuni.Controls.Add(Me.lblJumlahBayar)
        Me.grpPenghuni.Controls.Add(Me.lblBulanBayar)
        Me.grpPenghuni.Controls.Add(Me.lblNomorKamar)
        Me.grpPenghuni.Controls.Add(Me.lblNamaPenghuni)
        Me.grpPenghuni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPenghuni.Location = New System.Drawing.Point(706, 0)
        Me.grpPenghuni.Name = "grpPenghuni"
        Me.grpPenghuni.Size = New System.Drawing.Size(756, 733)
        Me.grpPenghuni.TabIndex = 1
        Me.grpPenghuni.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(425, 323)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 35)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(296, 323)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(94, 35)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(165, 323)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 35)
        Me.btnEdit.TabIndex = 30
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(34, 323)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(108, 35)
        Me.btnTambah.TabIndex = 29
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'cmbKeterangan
        '
        Me.cmbKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKeterangan.FormattingEnabled = True
        Me.cmbKeterangan.Location = New System.Drawing.Point(197, 236)
        Me.cmbKeterangan.Name = "cmbKeterangan"
        Me.cmbKeterangan.Size = New System.Drawing.Size(314, 33)
        Me.cmbKeterangan.TabIndex = 28
        '
        'dtpTanggalBayar
        '
        Me.dtpTanggalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalBayar.Location = New System.Drawing.Point(197, 191)
        Me.dtpTanggalBayar.Name = "dtpTanggalBayar"
        Me.dtpTanggalBayar.Size = New System.Drawing.Size(314, 30)
        Me.dtpTanggalBayar.TabIndex = 27
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(197, 149)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(314, 30)
        Me.txtJumlah.TabIndex = 26
        '
        'cmbBulan
        '
        Me.cmbBulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.Location = New System.Drawing.Point(197, 106)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(314, 33)
        Me.cmbBulan.TabIndex = 25
        '
        'txtNoKamar
        '
        Me.txtNoKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKamar.Location = New System.Drawing.Point(197, 63)
        Me.txtNoKamar.Name = "txtNoKamar"
        Me.txtNoKamar.Size = New System.Drawing.Size(314, 30)
        Me.txtNoKamar.TabIndex = 24
        '
        'cmbNama
        '
        Me.cmbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNama.FormattingEnabled = True
        Me.cmbNama.Location = New System.Drawing.Point(197, 18)
        Me.cmbNama.Name = "cmbNama"
        Me.cmbNama.Size = New System.Drawing.Size(314, 33)
        Me.cmbNama.TabIndex = 23
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(30, 236)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(114, 25)
        Me.lblKeterangan.TabIndex = 22
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblTanggalBayar
        '
        Me.lblTanggalBayar.AutoSize = True
        Me.lblTanggalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalBayar.Location = New System.Drawing.Point(30, 191)
        Me.lblTanggalBayar.Name = "lblTanggalBayar"
        Me.lblTanggalBayar.Size = New System.Drawing.Size(140, 25)
        Me.lblTanggalBayar.TabIndex = 21
        Me.lblTanggalBayar.Text = "Tanggal Bayar"
        '
        'lblJumlahBayar
        '
        Me.lblJumlahBayar.AutoSize = True
        Me.lblJumlahBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahBayar.Location = New System.Drawing.Point(29, 149)
        Me.lblJumlahBayar.Name = "lblJumlahBayar"
        Me.lblJumlahBayar.Size = New System.Drawing.Size(132, 25)
        Me.lblJumlahBayar.TabIndex = 20
        Me.lblJumlahBayar.Text = "Jumlah Bayar"
        '
        'lblBulanBayar
        '
        Me.lblBulanBayar.AutoSize = True
        Me.lblBulanBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBulanBayar.Location = New System.Drawing.Point(30, 106)
        Me.lblBulanBayar.Name = "lblBulanBayar"
        Me.lblBulanBayar.Size = New System.Drawing.Size(118, 25)
        Me.lblBulanBayar.TabIndex = 19
        Me.lblBulanBayar.Text = "Bulan Bayar"
        '
        'lblNomorKamar
        '
        Me.lblNomorKamar.AutoSize = True
        Me.lblNomorKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomorKamar.Location = New System.Drawing.Point(29, 63)
        Me.lblNomorKamar.Name = "lblNomorKamar"
        Me.lblNomorKamar.Size = New System.Drawing.Size(133, 25)
        Me.lblNomorKamar.TabIndex = 18
        Me.lblNomorKamar.Text = "Nomor Kamar"
        '
        'lblNamaPenghuni
        '
        Me.lblNamaPenghuni.AutoSize = True
        Me.lblNamaPenghuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPenghuni.Location = New System.Drawing.Point(30, 18)
        Me.lblNamaPenghuni.Name = "lblNamaPenghuni"
        Me.lblNamaPenghuni.Size = New System.Drawing.Size(152, 25)
        Me.lblNamaPenghuni.TabIndex = 17
        Me.lblNamaPenghuni.Text = "Nama Penghuni"
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.grpPenghuni)
        Me.Controls.Add(Me.dgvPembayaran)
        Me.Name = "FormPembayaran"
        Me.Text = "Pembayaran - Kost Elite JY"
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPenghuni.ResumeLayout(False)
        Me.grpPenghuni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPembayaran As DataGridView
    Friend WithEvents grpPenghuni As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbKeterangan As ComboBox
    Friend WithEvents dtpTanggalBayar As DateTimePicker
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents cmbBulan As ComboBox
    Friend WithEvents txtNoKamar As TextBox
    Friend WithEvents cmbNama As ComboBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblTanggalBayar As Label
    Friend WithEvents lblJumlahBayar As Label
    Friend WithEvents lblBulanBayar As Label
    Friend WithEvents lblNomorKamar As Label
    Friend WithEvents lblNamaPenghuni As Label
End Class
