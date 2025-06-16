<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelolaAdmin
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
        Me.grpAkunPenghuni = New System.Windows.Forms.GroupBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.dgvAdmin = New System.Windows.Forms.DataGridView()
        Me.grpAkunPenghuni.SuspendLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAkunPenghuni
        '
        Me.grpAkunPenghuni.Controls.Add(Me.txtNama)
        Me.grpAkunPenghuni.Controls.Add(Me.btnEdit)
        Me.grpAkunPenghuni.Controls.Add(Me.btnClear)
        Me.grpAkunPenghuni.Controls.Add(Me.btnHapus)
        Me.grpAkunPenghuni.Controls.Add(Me.btnTambah)
        Me.grpAkunPenghuni.Controls.Add(Me.txtPassword)
        Me.grpAkunPenghuni.Controls.Add(Me.lblPassword)
        Me.grpAkunPenghuni.Controls.Add(Me.txtUsername)
        Me.grpAkunPenghuni.Controls.Add(Me.lblUsername)
        Me.grpAkunPenghuni.Controls.Add(Me.lblNama)
        Me.grpAkunPenghuni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpAkunPenghuni.Location = New System.Drawing.Point(706, 0)
        Me.grpAkunPenghuni.Name = "grpAkunPenghuni"
        Me.grpAkunPenghuni.Size = New System.Drawing.Size(756, 733)
        Me.grpAkunPenghuni.TabIndex = 3
        Me.grpAkunPenghuni.TabStop = False
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(185, 33)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(303, 30)
        Me.txtNama.TabIndex = 10
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(152, 185)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 37)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(401, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 37)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(276, 185)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 37)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(31, 185)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(99, 37)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(185, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(303, 30)
        Me.txtPassword.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(26, 118)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 25)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(185, 75)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(303, 30)
        Me.txtUsername.TabIndex = 3
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(26, 78)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(26, 38)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 25)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'dgvAdmin
        '
        Me.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvAdmin.Location = New System.Drawing.Point(0, 0)
        Me.dgvAdmin.Name = "dgvAdmin"
        Me.dgvAdmin.RowHeadersWidth = 51
        Me.dgvAdmin.RowTemplate.Height = 24
        Me.dgvAdmin.Size = New System.Drawing.Size(706, 733)
        Me.dgvAdmin.TabIndex = 2
        '
        'FormKelolaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.grpAkunPenghuni)
        Me.Controls.Add(Me.dgvAdmin)
        Me.Name = "FormKelolaAdmin"
        Me.Text = "FormKelolaAdmin"
        Me.grpAkunPenghuni.ResumeLayout(False)
        Me.grpAkunPenghuni.PerformLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAkunPenghuni As GroupBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents dgvAdmin As DataGridView
End Class
