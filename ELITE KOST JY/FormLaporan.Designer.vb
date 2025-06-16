<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.grpLaporan = New System.Windows.Forms.GroupBox()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbTahun = New System.Windows.Forms.ComboBox()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.lblBulan = New System.Windows.Forms.Label()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLaporan.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLaporan
        '
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvLaporan.Location = New System.Drawing.Point(0, 0)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.RowHeadersWidth = 51
        Me.dgvLaporan.RowTemplate.Height = 24
        Me.dgvLaporan.Size = New System.Drawing.Size(706, 733)
        Me.dgvLaporan.TabIndex = 1
        '
        'grpLaporan
        '
        Me.grpLaporan.Controls.Add(Me.btnTampilkan)
        Me.grpLaporan.Controls.Add(Me.cmbStatus)
        Me.grpLaporan.Controls.Add(Me.cmbTahun)
        Me.grpLaporan.Controls.Add(Me.cmbBulan)
        Me.grpLaporan.Controls.Add(Me.lblTotal)
        Me.grpLaporan.Controls.Add(Me.lblStatus)
        Me.grpLaporan.Controls.Add(Me.lblTahun)
        Me.grpLaporan.Controls.Add(Me.lblBulan)
        Me.grpLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLaporan.Location = New System.Drawing.Point(706, 0)
        Me.grpLaporan.Name = "grpLaporan"
        Me.grpLaporan.Size = New System.Drawing.Size(756, 733)
        Me.grpLaporan.TabIndex = 2
        Me.grpLaporan.TabStop = False
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilkan.Location = New System.Drawing.Point(207, 257)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(121, 35)
        Me.btnTampilkan.TabIndex = 18
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(180, 122)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(230, 33)
        Me.cmbStatus.TabIndex = 17
        '
        'cmbTahun
        '
        Me.cmbTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTahun.FormattingEnabled = True
        Me.cmbTahun.Location = New System.Drawing.Point(180, 71)
        Me.cmbTahun.Name = "cmbTahun"
        Me.cmbTahun.Size = New System.Drawing.Size(230, 33)
        Me.cmbTahun.TabIndex = 16
        '
        'cmbBulan
        '
        Me.cmbBulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.Location = New System.Drawing.Point(180, 22)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(230, 33)
        Me.cmbBulan.TabIndex = 15
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(33, 179)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 25)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "Total"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(33, 125)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 25)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status"
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTahun.Location = New System.Drawing.Point(32, 74)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(69, 25)
        Me.lblTahun.TabIndex = 12
        Me.lblTahun.Text = "Tahun"
        '
        'lblBulan
        '
        Me.lblBulan.AutoSize = True
        Me.lblBulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBulan.Location = New System.Drawing.Point(32, 25)
        Me.lblBulan.Name = "lblBulan"
        Me.lblBulan.Size = New System.Drawing.Size(62, 25)
        Me.lblBulan.TabIndex = 11
        Me.lblBulan.Text = "Bulan"
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.grpLaporan)
        Me.Controls.Add(Me.dgvLaporan)
        Me.Name = "FormLaporan"
        Me.Text = "Laporan - Kost Elite JY"
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLaporan.ResumeLayout(False)
        Me.grpLaporan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents grpLaporan As GroupBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbTahun As ComboBox
    Friend WithEvents cmbBulan As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblBulan As Label
End Class
