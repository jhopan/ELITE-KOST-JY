<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim btnLogin As System.Windows.Forms.Button
        Dim btnCancel As System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        btnLogin = New System.Windows.Forms.Button()
        btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnLogin.Location = New System.Drawing.Point(85, 216)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New System.Drawing.Size(90, 40)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        AddHandler btnLogin.Click, AddressOf Me.btnLogin_Click
        '
        'btnCancel
        '
        btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCancel.Location = New System.Drawing.Point(266, 216)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(98, 40)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        AddHandler btnCancel.Click, AddressOf Me.btnCancel_Click
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(39, 284)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 16)
        Me.lblMessage.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(201, 146)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(192, 30)
        Me.txtPassword.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(201, 93)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(192, 30)
        Me.txtUsername.TabIndex = 3
        '
        'cmbRole
        '
        Me.cmbRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(201, 46)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(192, 33)
        Me.cmbRole.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(37, 151)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 25)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Login Sebagai"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(37, 98)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(463, 307)
        Me.Controls.Add(btnCancel)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtUsername)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Kost Elite JY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
End Class
