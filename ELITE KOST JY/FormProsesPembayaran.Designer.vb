<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesPembayaran
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
        Me.lblDetailPembayaran = New System.Windows.Forms.Label()
        Me.lblJumlahTagihan = New System.Windows.Forms.Label()
        Me.grpPembayaran = New System.Windows.Forms.GroupBox()
        Me.rdoQris = New System.Windows.Forms.RadioButton()
        Me.rdoTransfer = New System.Windows.Forms.RadioButton()
        Me.panelTransfer = New System.Windows.Forms.Panel()
        Me.lblRekMandiri = New System.Windows.Forms.Label()
        Me.lblRekBCA = New System.Windows.Forms.Label()
        Me.lblInfoRekening = New System.Windows.Forms.Label()
        Me.panelQris = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbQris = New System.Windows.Forms.PictureBox()
        Me.btnSelesai = New System.Windows.Forms.Button()
        Me.grpPembayaran.SuspendLayout()
        Me.panelTransfer.SuspendLayout()
        Me.panelQris.SuspendLayout()
        CType(Me.pbQris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDetailPembayaran
        '
        Me.lblDetailPembayaran.AutoSize = True
        Me.lblDetailPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailPembayaran.Location = New System.Drawing.Point(23, 27)
        Me.lblDetailPembayaran.Name = "lblDetailPembayaran"
        Me.lblDetailPembayaran.Size = New System.Drawing.Size(229, 25)
        Me.lblDetailPembayaran.TabIndex = 0
        Me.lblDetailPembayaran.Text = "Label Judul Pembayaran"
        '
        'lblJumlahTagihan
        '
        Me.lblJumlahTagihan.AutoSize = True
        Me.lblJumlahTagihan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahTagihan.Location = New System.Drawing.Point(23, 70)
        Me.lblJumlahTagihan.Name = "lblJumlahTagihan"
        Me.lblJumlahTagihan.Size = New System.Drawing.Size(229, 25)
        Me.lblJumlahTagihan.TabIndex = 1
        Me.lblJumlahTagihan.Text = "Label Judul Pembayaran"
        '
        'grpPembayaran
        '
        Me.grpPembayaran.Controls.Add(Me.rdoQris)
        Me.grpPembayaran.Controls.Add(Me.rdoTransfer)
        Me.grpPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPembayaran.Location = New System.Drawing.Point(12, 111)
        Me.grpPembayaran.Name = "grpPembayaran"
        Me.grpPembayaran.Size = New System.Drawing.Size(279, 262)
        Me.grpPembayaran.TabIndex = 2
        Me.grpPembayaran.TabStop = False
        Me.grpPembayaran.Text = "Pilih Metode Pembayaran"
        '
        'rdoQris
        '
        Me.rdoQris.AutoSize = True
        Me.rdoQris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoQris.Location = New System.Drawing.Point(6, 115)
        Me.rdoQris.Name = "rdoQris"
        Me.rdoQris.Size = New System.Drawing.Size(74, 26)
        Me.rdoQris.TabIndex = 1
        Me.rdoQris.TabStop = True
        Me.rdoQris.Text = "QRIS"
        Me.rdoQris.UseVisualStyleBackColor = True
        '
        'rdoTransfer
        '
        Me.rdoTransfer.AutoSize = True
        Me.rdoTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTransfer.Location = New System.Drawing.Point(6, 62)
        Me.rdoTransfer.Name = "rdoTransfer"
        Me.rdoTransfer.Size = New System.Drawing.Size(145, 26)
        Me.rdoTransfer.TabIndex = 0
        Me.rdoTransfer.TabStop = True
        Me.rdoTransfer.Text = "Transfer Bank"
        Me.rdoTransfer.UseVisualStyleBackColor = True
        '
        'panelTransfer
        '
        Me.panelTransfer.Controls.Add(Me.lblRekMandiri)
        Me.panelTransfer.Controls.Add(Me.lblRekBCA)
        Me.panelTransfer.Controls.Add(Me.lblInfoRekening)
        Me.panelTransfer.Location = New System.Drawing.Point(18, 379)
        Me.panelTransfer.Name = "panelTransfer"
        Me.panelTransfer.Size = New System.Drawing.Size(352, 114)
        Me.panelTransfer.TabIndex = 3
        '
        'lblRekMandiri
        '
        Me.lblRekMandiri.AutoSize = True
        Me.lblRekMandiri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRekMandiri.Location = New System.Drawing.Point(3, 83)
        Me.lblRekMandiri.Name = "lblRekMandiri"
        Me.lblRekMandiri.Size = New System.Drawing.Size(310, 20)
        Me.lblRekMandiri.TabIndex = 4
        Me.lblRekMandiri.Text = "Mandiri : 0987654321 (a/n Kost Elite JY)"
        '
        'lblRekBCA
        '
        Me.lblRekBCA.AutoSize = True
        Me.lblRekBCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRekBCA.Location = New System.Drawing.Point(3, 50)
        Me.lblRekBCA.Name = "lblRekBCA"
        Me.lblRekBCA.Size = New System.Drawing.Size(290, 20)
        Me.lblRekBCA.TabIndex = 3
        Me.lblRekBCA.Text = "BCA : 1234567890 (a/n Kost Elite JY)"
        '
        'lblInfoRekening
        '
        Me.lblInfoRekening.AutoSize = True
        Me.lblInfoRekening.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoRekening.Location = New System.Drawing.Point(3, 16)
        Me.lblInfoRekening.Name = "lblInfoRekening"
        Me.lblInfoRekening.Size = New System.Drawing.Size(276, 20)
        Me.lblInfoRekening.TabIndex = 2
        Me.lblInfoRekening.Text = "Silakan transfer ke rekening berikut:"
        '
        'panelQris
        '
        Me.panelQris.Controls.Add(Me.Label2)
        Me.panelQris.Controls.Add(Me.pbQris)
        Me.panelQris.Location = New System.Drawing.Point(316, 101)
        Me.panelQris.Name = "panelQris"
        Me.panelQris.Size = New System.Drawing.Size(458, 272)
        Me.panelQris.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Silahkan Pindai QRIS"
        '
        'pbQris
        '
        Me.pbQris.Location = New System.Drawing.Point(17, 10)
        Me.pbQris.Name = "pbQris"
        Me.pbQris.Size = New System.Drawing.Size(417, 237)
        Me.pbQris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQris.TabIndex = 0
        Me.pbQris.TabStop = False
        '
        'btnSelesai
        '
        Me.btnSelesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelesai.Location = New System.Drawing.Point(107, 508)
        Me.btnSelesai.Name = "btnSelesai"
        Me.btnSelesai.Size = New System.Drawing.Size(454, 50)
        Me.btnSelesai.TabIndex = 5
        Me.btnSelesai.Text = "Saya Sudah Bayar Dan Konfirmasi"
        Me.btnSelesai.UseVisualStyleBackColor = True
        '
        'FormProsesPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 581)
        Me.Controls.Add(Me.btnSelesai)
        Me.Controls.Add(Me.panelQris)
        Me.Controls.Add(Me.panelTransfer)
        Me.Controls.Add(Me.grpPembayaran)
        Me.Controls.Add(Me.lblJumlahTagihan)
        Me.Controls.Add(Me.lblDetailPembayaran)
        Me.Name = "FormProsesPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProsesPembayaran"
        Me.grpPembayaran.ResumeLayout(False)
        Me.grpPembayaran.PerformLayout()
        Me.panelTransfer.ResumeLayout(False)
        Me.panelTransfer.PerformLayout()
        Me.panelQris.ResumeLayout(False)
        Me.panelQris.PerformLayout()
        CType(Me.pbQris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDetailPembayaran As Label
    Friend WithEvents lblJumlahTagihan As Label
    Friend WithEvents grpPembayaran As GroupBox
    Friend WithEvents rdoQris As RadioButton
    Friend WithEvents rdoTransfer As RadioButton
    Friend WithEvents panelTransfer As Panel
    Friend WithEvents lblInfoRekening As Label
    Friend WithEvents panelQris As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pbQris As PictureBox
    Friend WithEvents btnSelesai As Button
    Friend WithEvents lblRekMandiri As Label
    Friend WithEvents lblRekBCA As Label
End Class
