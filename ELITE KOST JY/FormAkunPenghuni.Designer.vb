<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAkunPenghuni
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
        Me.dgvAkun = New System.Windows.Forms.DataGridView()
        Me.grpAkunPenghuni = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.cmbPenghuni = New System.Windows.Forms.ComboBox()
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAkunPenghuni.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAkun
        '
        Me.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAkun.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvAkun.Location = New System.Drawing.Point(0, 0)
        Me.dgvAkun.Name = "dgvAkun"
        Me.dgvAkun.RowHeadersWidth = 51
        Me.dgvAkun.RowTemplate.Height = 24
        Me.dgvAkun.Size = New System.Drawing.Size(706, 733)
        Me.dgvAkun.TabIndex = 0
        '
        'grpAkunPenghuni
        '
        Me.grpAkunPenghuni.Controls.Add(Me.btnEdit)
        Me.grpAkunPenghuni.Controls.Add(Me.btnClear)
        Me.grpAkunPenghuni.Controls.Add(Me.btnHapus)
        Me.grpAkunPenghuni.Controls.Add(Me.btnTambah)
        Me.grpAkunPenghuni.Controls.Add(Me.txtPassword)
        Me.grpAkunPenghuni.Controls.Add(Me.lblPassword)
        Me.grpAkunPenghuni.Controls.Add(Me.txtUsername)
        Me.grpAkunPenghuni.Controls.Add(Me.lblUsername)
        Me.grpAkunPenghuni.Controls.Add(Me.lblNama)
        Me.grpAkunPenghuni.Controls.Add(Me.cmbPenghuni)
        Me.grpAkunPenghuni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpAkunPenghuni.Location = New System.Drawing.Point(706, 0)
        Me.grpAkunPenghuni.Name = "grpAkunPenghuni"
        Me.grpAkunPenghuni.Size = New System.Drawing.Size(756, 733)
        Me.grpAkunPenghuni.TabIndex = 1
        Me.grpAkunPenghuni.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(169, 190)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 36)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(427, 190)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 36)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(301, 190)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(104, 36)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(32, 190)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(112, 36)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(201, 121)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(323, 30)
        Me.txtPassword.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(27, 124)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 25)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(201, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(323, 30)
        Me.txtUsername.TabIndex = 3
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(27, 77)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(27, 30)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 25)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'cmbPenghuni
        '
        Me.cmbPenghuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPenghuni.FormattingEnabled = True
        Me.cmbPenghuni.Location = New System.Drawing.Point(201, 22)
        Me.cmbPenghuni.Name = "cmbPenghuni"
        Me.cmbPenghuni.Size = New System.Drawing.Size(323, 33)
        Me.cmbPenghuni.TabIndex = 0
        '
        'FormAkunPenghuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.grpAkunPenghuni)
        Me.Controls.Add(Me.dgvAkun)
        Me.Name = "FormAkunPenghuni"
        Me.Text = "FormAkunPenghuni"
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAkunPenghuni.ResumeLayout(False)
        Me.grpAkunPenghuni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAkun As DataGridView
    Friend WithEvents grpAkunPenghuni As GroupBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents cmbPenghuni As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnEdit As Button
End Class
