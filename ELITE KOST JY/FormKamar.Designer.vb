<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKamar
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
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.grpKamar = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbTipe = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNoKamar = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.lblNoKamar2 = New System.Windows.Forms.Label()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpKamar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKamar
        '
        Me.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKamar.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvKamar.Location = New System.Drawing.Point(0, 0)
        Me.dgvKamar.Name = "dgvKamar"
        Me.dgvKamar.RowHeadersWidth = 51
        Me.dgvKamar.RowTemplate.Height = 24
        Me.dgvKamar.Size = New System.Drawing.Size(706, 733)
        Me.dgvKamar.TabIndex = 0
        '
        'grpKamar
        '
        Me.grpKamar.Controls.Add(Me.btnClear)
        Me.grpKamar.Controls.Add(Me.btnHapus)
        Me.grpKamar.Controls.Add(Me.btnEdit)
        Me.grpKamar.Controls.Add(Me.btnTambah)
        Me.grpKamar.Controls.Add(Me.cmbStatus)
        Me.grpKamar.Controls.Add(Me.cmbTipe)
        Me.grpKamar.Controls.Add(Me.txtHarga)
        Me.grpKamar.Controls.Add(Me.txtNoKamar)
        Me.grpKamar.Controls.Add(Me.lblStatus)
        Me.grpKamar.Controls.Add(Me.lblHarga)
        Me.grpKamar.Controls.Add(Me.lblTipe)
        Me.grpKamar.Controls.Add(Me.lblNoKamar2)
        Me.grpKamar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpKamar.Location = New System.Drawing.Point(706, 0)
        Me.grpKamar.Name = "grpKamar"
        Me.grpKamar.Size = New System.Drawing.Size(756, 733)
        Me.grpKamar.TabIndex = 1
        Me.grpKamar.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(417, 273)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 37)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(293, 273)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 37)
        Me.btnHapus.TabIndex = 24
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(176, 273)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 37)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(42, 273)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(107, 37)
        Me.btnTambah.TabIndex = 22
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(191, 186)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(318, 33)
        Me.cmbStatus.TabIndex = 21
        '
        'cmbTipe
        '
        Me.cmbTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipe.FormattingEnabled = True
        Me.cmbTipe.Location = New System.Drawing.Point(191, 88)
        Me.cmbTipe.Name = "cmbTipe"
        Me.cmbTipe.Size = New System.Drawing.Size(318, 33)
        Me.cmbTipe.TabIndex = 20
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(191, 141)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(318, 30)
        Me.txtHarga.TabIndex = 19
        '
        'txtNoKamar
        '
        Me.txtNoKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKamar.Location = New System.Drawing.Point(191, 34)
        Me.txtNoKamar.Name = "txtNoKamar"
        Me.txtNoKamar.Size = New System.Drawing.Size(318, 30)
        Me.txtNoKamar.TabIndex = 18
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(37, 194)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 25)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Status"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(37, 141)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(65, 25)
        Me.lblHarga.TabIndex = 16
        Me.lblHarga.Text = "Harga"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipe.Location = New System.Drawing.Point(37, 88)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(51, 25)
        Me.lblTipe.TabIndex = 15
        Me.lblTipe.Text = "Tipe"
        '
        'lblNoKamar2
        '
        Me.lblNoKamar2.AutoSize = True
        Me.lblNoKamar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoKamar2.Location = New System.Drawing.Point(37, 34)
        Me.lblNoKamar2.Name = "lblNoKamar2"
        Me.lblNoKamar2.Size = New System.Drawing.Size(133, 25)
        Me.lblNoKamar2.TabIndex = 14
        Me.lblNoKamar2.Text = "Nomor Kamar"
        '
        'FormKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.grpKamar)
        Me.Controls.Add(Me.dgvKamar)
        Me.MaximizeBox = False
        Me.Name = "FormKamar"
        Me.Text = "Kamar - Kost Elite JY"
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpKamar.ResumeLayout(False)
        Me.grpKamar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvKamar As DataGridView
    Friend WithEvents grpKamar As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbTipe As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNoKamar As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblTipe As Label
    Friend WithEvents lblNoKamar2 As Label
End Class
