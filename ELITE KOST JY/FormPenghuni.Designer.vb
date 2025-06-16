<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenghuni
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
        Me.dgvPenghuni = New System.Windows.Forms.DataGridView()
        Me.grpPenghuni = New System.Windows.Forms.GroupBox()
        Me.txtAlamatAsal = New System.Windows.Forms.TextBox()
        Me.lblAlamatMasuk = New System.Windows.Forms.Label()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTanggalMasuk = New System.Windows.Forms.Label()
        Me.lblNoKamar = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.dtpTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.txtNoKamar = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        CType(Me.dgvPenghuni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPenghuni.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPenghuni
        '
        Me.dgvPenghuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenghuni.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvPenghuni.Location = New System.Drawing.Point(0, 0)
        Me.dgvPenghuni.Name = "dgvPenghuni"
        Me.dgvPenghuni.RowHeadersWidth = 51
        Me.dgvPenghuni.RowTemplate.Height = 24
        Me.dgvPenghuni.Size = New System.Drawing.Size(706, 733)
        Me.dgvPenghuni.TabIndex = 0
        '
        'grpPenghuni
        '
        Me.grpPenghuni.Controls.Add(Me.txtAlamatAsal)
        Me.grpPenghuni.Controls.Add(Me.lblAlamatMasuk)
        Me.grpPenghuni.Controls.Add(Me.lblKontak)
        Me.grpPenghuni.Controls.Add(Me.btnClear)
        Me.grpPenghuni.Controls.Add(Me.btnHapus)
        Me.grpPenghuni.Controls.Add(Me.btnEdit)
        Me.grpPenghuni.Controls.Add(Me.btnTambah)
        Me.grpPenghuni.Controls.Add(Me.cmbStatus)
        Me.grpPenghuni.Controls.Add(Me.lblStatus)
        Me.grpPenghuni.Controls.Add(Me.lblTanggalMasuk)
        Me.grpPenghuni.Controls.Add(Me.lblNoKamar)
        Me.grpPenghuni.Controls.Add(Me.lblNama)
        Me.grpPenghuni.Controls.Add(Me.dtpTanggalMasuk)
        Me.grpPenghuni.Controls.Add(Me.txtKontak)
        Me.grpPenghuni.Controls.Add(Me.txtNoKamar)
        Me.grpPenghuni.Controls.Add(Me.txtNama)
        Me.grpPenghuni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPenghuni.Location = New System.Drawing.Point(706, 0)
        Me.grpPenghuni.Name = "grpPenghuni"
        Me.grpPenghuni.Size = New System.Drawing.Size(756, 733)
        Me.grpPenghuni.TabIndex = 18
        Me.grpPenghuni.TabStop = False
        '
        'txtAlamatAsal
        '
        Me.txtAlamatAsal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatAsal.Location = New System.Drawing.Point(215, 115)
        Me.txtAlamatAsal.Name = "txtAlamatAsal"
        Me.txtAlamatAsal.Size = New System.Drawing.Size(283, 30)
        Me.txtAlamatAsal.TabIndex = 33
        '
        'lblAlamatMasuk
        '
        Me.lblAlamatMasuk.AutoSize = True
        Me.lblAlamatMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamatMasuk.Location = New System.Drawing.Point(40, 115)
        Me.lblAlamatMasuk.Name = "lblAlamatMasuk"
        Me.lblAlamatMasuk.Size = New System.Drawing.Size(137, 25)
        Me.lblAlamatMasuk.TabIndex = 32
        Me.lblAlamatMasuk.Text = "Alamat Masuk"
        '
        'lblKontak
        '
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontak.Location = New System.Drawing.Point(40, 65)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(119, 25)
        Me.lblKontak.TabIndex = 31
        Me.lblKontak.Text = "No. Telepon"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(413, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 35)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(279, 356)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(103, 37)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(170, 358)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 35)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(35, 356)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(117, 35)
        Me.btnTambah.TabIndex = 27
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Aktif"})
        Me.cmbStatus.Location = New System.Drawing.Point(215, 281)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(283, 33)
        Me.cmbStatus.TabIndex = 26
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(40, 289)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 25)
        Me.lblStatus.TabIndex = 25
        Me.lblStatus.Text = "Status"
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(40, 166)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(148, 25)
        Me.lblTanggalMasuk.TabIndex = 24
        Me.lblTanggalMasuk.Text = "Tanggal Masuk"
        '
        'lblNoKamar
        '
        Me.lblNoKamar.AutoSize = True
        Me.lblNoKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoKamar.Location = New System.Drawing.Point(40, 225)
        Me.lblNoKamar.Name = "lblNoKamar"
        Me.lblNoKamar.Size = New System.Drawing.Size(100, 25)
        Me.lblNoKamar.TabIndex = 23
        Me.lblNoKamar.Text = "No Kamar"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(40, 18)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 25)
        Me.lblNama.TabIndex = 22
        Me.lblNama.Text = "Nama"
        '
        'dtpTanggalMasuk
        '
        Me.dtpTanggalMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalMasuk.Location = New System.Drawing.Point(215, 166)
        Me.dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        Me.dtpTanggalMasuk.Size = New System.Drawing.Size(283, 30)
        Me.dtpTanggalMasuk.TabIndex = 21
        '
        'txtKontak
        '
        Me.txtKontak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKontak.Location = New System.Drawing.Point(215, 65)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(283, 30)
        Me.txtKontak.TabIndex = 20
        '
        'txtNoKamar
        '
        Me.txtNoKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKamar.Location = New System.Drawing.Point(215, 225)
        Me.txtNoKamar.Name = "txtNoKamar"
        Me.txtNoKamar.Size = New System.Drawing.Size(283, 30)
        Me.txtNoKamar.TabIndex = 19
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(215, 18)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(283, 30)
        Me.txtNama.TabIndex = 18
        '
        'FormPenghuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.grpPenghuni)
        Me.Controls.Add(Me.dgvPenghuni)
        Me.Name = "FormPenghuni"
        Me.Text = "Penghuni - Kost Elite JY"
        CType(Me.dgvPenghuni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPenghuni.ResumeLayout(False)
        Me.grpPenghuni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPenghuni As DataGridView
    Friend WithEvents grpPenghuni As GroupBox
    Friend WithEvents txtAlamatAsal As TextBox
    Friend WithEvents lblAlamatMasuk As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents lblNoKamar As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents dtpTanggalMasuk As DateTimePicker
    Friend WithEvents txtKontak As TextBox
    Friend WithEvents txtNoKamar As TextBox
    Friend WithEvents txtNama As TextBox
End Class
