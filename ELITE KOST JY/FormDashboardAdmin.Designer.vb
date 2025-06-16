<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboardAdmin
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
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnPembayaran = New System.Windows.Forms.Button()
        Me.btnKamar = New System.Windows.Forms.Button()
        Me.btnPenghuni = New System.Windows.Forms.Button()
        Me.panelKonten = New System.Windows.Forms.Panel()
        Me.btnAkunAdmin = New System.Windows.Forms.Button()
        Me.btnAkunPenghuni = New System.Windows.Forms.Button()
        Me.panelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.Controls.Add(Me.btnAkunPenghuni)
        Me.panelMenu.Controls.Add(Me.btnAkunAdmin)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.btnLaporan)
        Me.panelMenu.Controls.Add(Me.btnPembayaran)
        Me.panelMenu.Controls.Add(Me.btnKamar)
        Me.panelMenu.Controls.Add(Me.btnPenghuni)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(207, 733)
        Me.panelMenu.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(12, 301)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(166, 38)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnLaporan
        '
        Me.btnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.Location = New System.Drawing.Point(12, 257)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(166, 38)
        Me.btnLaporan.TabIndex = 3
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnPembayaran
        '
        Me.btnPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembayaran.Location = New System.Drawing.Point(12, 213)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Size = New System.Drawing.Size(166, 38)
        Me.btnPembayaran.TabIndex = 2
        Me.btnPembayaran.Text = "Pembayaran"
        Me.btnPembayaran.UseVisualStyleBackColor = True
        '
        'btnKamar
        '
        Me.btnKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKamar.Location = New System.Drawing.Point(12, 169)
        Me.btnKamar.Name = "btnKamar"
        Me.btnKamar.Size = New System.Drawing.Size(166, 38)
        Me.btnKamar.TabIndex = 1
        Me.btnKamar.Text = "Data Kamar"
        Me.btnKamar.UseVisualStyleBackColor = True
        '
        'btnPenghuni
        '
        Me.btnPenghuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenghuni.Location = New System.Drawing.Point(12, 117)
        Me.btnPenghuni.Name = "btnPenghuni"
        Me.btnPenghuni.Size = New System.Drawing.Size(166, 38)
        Me.btnPenghuni.TabIndex = 0
        Me.btnPenghuni.Text = "Data Penghuni"
        Me.btnPenghuni.UseVisualStyleBackColor = True
        '
        'panelKonten
        '
        Me.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelKonten.Location = New System.Drawing.Point(207, 0)
        Me.panelKonten.Name = "panelKonten"
        Me.panelKonten.Size = New System.Drawing.Size(1255, 733)
        Me.panelKonten.TabIndex = 2
        '
        'btnAkunAdmin
        '
        Me.btnAkunAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAkunAdmin.Location = New System.Drawing.Point(12, 24)
        Me.btnAkunAdmin.Name = "btnAkunAdmin"
        Me.btnAkunAdmin.Size = New System.Drawing.Size(166, 38)
        Me.btnAkunAdmin.TabIndex = 5
        Me.btnAkunAdmin.Text = "Akun Admin"
        Me.btnAkunAdmin.UseVisualStyleBackColor = True
        '
        'btnAkunPenghuni
        '
        Me.btnAkunPenghuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAkunPenghuni.Location = New System.Drawing.Point(12, 68)
        Me.btnAkunPenghuni.Name = "btnAkunPenghuni"
        Me.btnAkunPenghuni.Size = New System.Drawing.Size(166, 43)
        Me.btnAkunPenghuni.TabIndex = 6
        Me.btnAkunPenghuni.Text = "Akun Penghuni"
        Me.btnAkunPenghuni.UseVisualStyleBackColor = True
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 733)
        Me.Controls.Add(Me.panelKonten)
        Me.Controls.Add(Me.panelMenu)
        Me.MaximizeBox = False
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard - Kost Elite JY"
        Me.panelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents btnKamar As Button
    Friend WithEvents btnPenghuni As Button
    Friend WithEvents panelKonten As Panel
    Friend WithEvents btnAkunPenghuni As Button
    Friend WithEvents btnAkunAdmin As Button
End Class
