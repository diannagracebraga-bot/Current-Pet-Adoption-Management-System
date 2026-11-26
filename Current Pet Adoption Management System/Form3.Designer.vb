<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlRegister As System.Windows.Forms.Panel
    Friend WithEvents lblIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents lnkLogin As System.Windows.Forms.LinkLabel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.lblIcon = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lnkLogin = New System.Windows.Forms.LinkLabel()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(525, 20)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 32)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "← Back to Homepage"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlRegister
        '
        Me.pnlRegister.BackColor = System.Drawing.Color.White
        Me.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRegister.Controls.Add(Me.lblIcon)
        Me.pnlRegister.Controls.Add(Me.lblTitle)
        Me.pnlRegister.Controls.Add(Me.lblSubtitle)
        Me.pnlRegister.Controls.Add(Me.lblUser)
        Me.pnlRegister.Controls.Add(Me.txtUser)
        Me.pnlRegister.Controls.Add(Me.lblPass)
        Me.pnlRegister.Controls.Add(Me.txtPass)
        Me.pnlRegister.Controls.Add(Me.lblConfirm)
        Me.pnlRegister.Controls.Add(Me.txtConfirm)
        Me.pnlRegister.Controls.Add(Me.chkShowPass)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.lnkLogin)
        Me.pnlRegister.Location = New System.Drawing.Point(180, 65)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(360, 460)
        Me.pnlRegister.TabIndex = 1
        '
        'lblIcon
        '
        Me.lblIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 24.0!)
        Me.lblIcon.Location = New System.Drawing.Point(130, 12)
        Me.lblIcon.Name = "lblIcon"
        Me.lblIcon.Size = New System.Drawing.Size(100, 40)
        Me.lblIcon.TabIndex = 0
        Me.lblIcon.Text = "🐱 🐶"
        Me.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(15, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(328, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Create an Account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(15, 90)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(328, 20)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Join PawHaven to adopt and list pets."
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(30, 120)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 15)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Username"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUser.Location = New System.Drawing.Point(30, 138)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(300, 25)
        Me.txtUser.TabIndex = 4
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblPass.Location = New System.Drawing.Point(30, 175)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(59, 15)
        Me.lblPass.TabIndex = 5
        Me.lblPass.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPass.Location = New System.Drawing.Point(30, 193)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(300, 25)
        Me.txtPass.TabIndex = 6
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblConfirm.Location = New System.Drawing.Point(30, 230)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(107, 15)
        Me.lblConfirm.TabIndex = 7
        Me.lblConfirm.Text = "Confirm Password"
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtConfirm.Location = New System.Drawing.Point(30, 248)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(300, 25)
        Me.txtConfirm.TabIndex = 8
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chkShowPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.chkShowPass.Location = New System.Drawing.Point(30, 285)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(113, 17)
        Me.chkShowPass.TabIndex = 9
        Me.chkShowPass.Text = "Show passwords"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(30, 318)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(300, 38)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register Account"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lnkLogin
        '
        Me.lnkLogin.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lnkLogin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lnkLogin.Location = New System.Drawing.Point(30, 370)
        Me.lnkLogin.Name = "lnkLogin"
        Me.lnkLogin.Size = New System.Drawing.Size(300, 25)
        Me.lnkLogin.TabIndex = 11
        Me.lnkLogin.TabStop = True
        Me.lnkLogin.Text = "Already have an account? Log in"
        Me.lnkLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(704, 540)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PawHaven - Register"
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

End Class
