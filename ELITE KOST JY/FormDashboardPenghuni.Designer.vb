<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboardPenghuni
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
        Me.lblSelamatDatang = New System.Windows.Forms.Label()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblJatuhTempo = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblTipeKamar = New System.Windows.Forms.Label()
        Me.lblNomorKamar = New System.Windows.Forms.Label()
        Me.grpRiwayat = New System.Windows.Forms.GroupBox()
        Me.dgvRiwayat = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.pcbWelcome = New System.Windows.Forms.PictureBox()
        Me.grpInfo.SuspendLayout()
        Me.grpRiwayat.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelamatDatang
        '
        Me.lblSelamatDatang.AutoSize = True
        Me.lblSelamatDatang.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelamatDatang.Location = New System.Drawing.Point(618, 54)
        Me.lblSelamatDatang.Name = "lblSelamatDatang"
        Me.lblSelamatDatang.Size = New System.Drawing.Size(327, 29)
        Me.lblSelamatDatang.TabIndex = 0
        Me.lblSelamatDatang.Text = "Ini Ucapan Selamat Datang"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.lblJatuhTempo)
        Me.grpInfo.Controls.Add(Me.lblHarga)
        Me.grpInfo.Controls.Add(Me.lblTipeKamar)
        Me.grpInfo.Controls.Add(Me.lblNomorKamar)
        Me.grpInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpInfo.Location = New System.Drawing.Point(1092, 0)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(370, 733)
        Me.grpInfo.TabIndex = 1
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Info Kamar Anda"
        '
        'lblJatuhTempo
        '
        Me.lblJatuhTempo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJatuhTempo.AutoSize = True
        Me.lblJatuhTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJatuhTempo.Location = New System.Drawing.Point(0, 182)
        Me.lblJatuhTempo.Name = "lblJatuhTempo"
        Me.lblJatuhTempo.Size = New System.Drawing.Size(153, 25)
        Me.lblJatuhTempo.TabIndex = 3
        Me.lblJatuhTempo.Text = "Ini Jatuh Tempo"
        '
        'lblHarga
        '
        Me.lblHarga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(0, 121)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(143, 25)
        Me.lblHarga.TabIndex = 2
        Me.lblHarga.Text = "Ini Label Harga"
        '
        'lblTipeKamar
        '
        Me.lblTipeKamar.AutoSize = True
        Me.lblTipeKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipeKamar.Location = New System.Drawing.Point(0, 80)
        Me.lblTipeKamar.Name = "lblTipeKamar"
        Me.lblTipeKamar.Size = New System.Drawing.Size(192, 25)
        Me.lblTipeKamar.TabIndex = 1
        Me.lblTipeKamar.Text = "Ini Label Tipe Kamar"
        '
        'lblNomorKamar
        '
        Me.lblNomorKamar.AutoSize = True
        Me.lblNomorKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomorKamar.Location = New System.Drawing.Point(0, 40)
        Me.lblNomorKamar.Name = "lblNomorKamar"
        Me.lblNomorKamar.Size = New System.Drawing.Size(158, 25)
        Me.lblNomorKamar.TabIndex = 0
        Me.lblNomorKamar.Text = "Ini Nomor Kamar"
        '
        'grpRiwayat
        '
        Me.grpRiwayat.Controls.Add(Me.dgvRiwayat)
        Me.grpRiwayat.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpRiwayat.Location = New System.Drawing.Point(0, 0)
        Me.grpRiwayat.Name = "grpRiwayat"
        Me.grpRiwayat.Size = New System.Drawing.Size(480, 733)
        Me.grpRiwayat.TabIndex = 2
        Me.grpRiwayat.TabStop = False
        Me.grpRiwayat.Text = "Riwayat Pembayaran Anda"
        '
        'dgvRiwayat
        '
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRiwayat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRiwayat.Location = New System.Drawing.Point(3, 18)
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.RowHeadersWidth = 51
        Me.dgvRiwayat.RowTemplate.Height = 24
        Me.dgvRiwayat.Size = New System.Drawing.Size(474, 712)
        Me.dgvRiwayat.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(850, 553)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(106, 42)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnBayar
        '
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.Location = New System.Drawing.Point(564, 553)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(142, 42)
        Me.btnBayar.TabIndex = 4
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'pcbWelcome
        '
        Me.pcbWelcome.Image = Global.ELITE_KOST_JY.My.Resources.Resources.ChatGPT_Image_16_Jun_2025__01_26_46
        Me.pcbWelcome.InitialImage = Nothing
        Me.pcbWelcome.Location = New System.Drawing.Point(486, 133)
        Me.pcbWelcome.Name = "pcbWelcome"
        Me.pcbWelcome.Size = New System.Drawing.Size(600, 372)
        Me.pcbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbWelcome.TabIndex = 5
        Me.pcbWelcome.TabStop = False
        '
        'FormDashboardPenghuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.pcbWelcome)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.grpRiwayat)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.lblSelamatDatang)
        Me.Name = "FormDashboardPenghuni"
        Me.Text = "FormDashboardPenghuni"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpRiwayat.ResumeLayout(False)
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelamatDatang As Label
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblTipeKamar As Label
    Friend WithEvents lblNomorKamar As Label
    Friend WithEvents grpRiwayat As GroupBox
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents pcbWelcome As PictureBox
    Friend WithEvents lblJatuhTempo As Label
End Class
