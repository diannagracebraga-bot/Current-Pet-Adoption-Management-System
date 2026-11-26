<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPetDetails
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

    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblPetName As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtStory As System.Windows.Forms.TextBox
    Friend WithEvents pnlSpecs As System.Windows.Forms.Panel
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents pnlHealth As System.Windows.Forms.Panel
    Friend WithEvents lblHealthTitle As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents pnlTraits As System.Windows.Forms.Panel
    Friend WithEvents lblTraitsTitle As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents pbTemp As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCling As System.Windows.Forms.Label
    Friend WithEvents pbCling As System.Windows.Forms.ProgressBar
    Friend WithEvents grpApply As System.Windows.Forms.GroupBox
    Friend WithEvents lblApplicant As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblHousing As System.Windows.Forms.Label
    Friend WithEvents cboHousing As System.Windows.Forms.ComboBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStory = New System.Windows.Forms.TextBox()
        Me.pnlSpecs = New System.Windows.Forms.Panel()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.pnlHealth = New System.Windows.Forms.Panel()
        Me.lblHealthTitle = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.pnlTraits = New System.Windows.Forms.Panel()
        Me.lblTraitsTitle = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.pbTemp = New System.Windows.Forms.ProgressBar()
        Me.lblCling = New System.Windows.Forms.Label()
        Me.pbCling = New System.Windows.Forms.ProgressBar()
        Me.grpApply = New System.Windows.Forms.GroupBox()
        Me.lblApplicant = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblHousing = New System.Windows.Forms.Label()
        Me.cboHousing = New System.Windows.Forms.ComboBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpecs.SuspendLayout()
        Me.pnlHealth.SuspendLayout()
        Me.pnlTraits.SuspendLayout()
        Me.grpApply.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.btnClose)
        Me.pnlMain.Controls.Add(Me.picBanner)
        Me.pnlMain.Controls.Add(Me.lblPetName)
        Me.pnlMain.Controls.Add(Me.lblSubtitle)
        Me.pnlMain.Controls.Add(Me.lblStatus)
        Me.pnlMain.Controls.Add(Me.txtStory)
        Me.pnlMain.Controls.Add(Me.pnlSpecs)
        Me.pnlMain.Controls.Add(Me.pnlHealth)
        Me.pnlMain.Controls.Add(Me.pnlTraits)
        Me.pnlMain.Controls.Add(Me.grpApply)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(684, 761)
        Me.pnlMain.TabIndex = 0
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.picBanner.Location = New System.Drawing.Point(0, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(684, 180)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBanner.TabIndex = 0
        Me.picBanner.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(640, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "✕"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblPetName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblPetName.Location = New System.Drawing.Point(20, 195)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(126, 32)
        Me.lblPetName.TabIndex = 2
        Me.lblPetName.Text = "Pet Name"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(23, 230)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(193, 15)
        Me.lblSubtitle.TabIndex = 3
        Me.lblSubtitle.Text = "2 years • Male • Large • Portland, OR"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(530, 195)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(115, 26)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Approved"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStory
        '
        Me.txtStory.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtStory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtStory.Location = New System.Drawing.Point(23, 255)
        Me.txtStory.Multiline = True
        Me.txtStory.Name = "txtStory"
        Me.txtStory.ReadOnly = True
        Me.txtStory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStory.Size = New System.Drawing.Size(622, 55)
        Me.txtStory.TabIndex = 5
        Me.txtStory.Text = "Story and description of the companion."
        '
        'pnlSpecs
        '
        Me.pnlSpecs.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlSpecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSpecs.Controls.Add(Me.lblAge)
        Me.pnlSpecs.Controls.Add(Me.lblSex)
        Me.pnlSpecs.Controls.Add(Me.lblSize)
        Me.pnlSpecs.Controls.Add(Me.lblColor)
        Me.pnlSpecs.Location = New System.Drawing.Point(23, 320)
        Me.pnlSpecs.Name = "pnlSpecs"
        Me.pnlSpecs.Size = New System.Drawing.Size(622, 45)
        Me.pnlSpecs.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(10, 8)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(140, 28)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age: 2 years"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSex
        '
        Me.lblSex.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSex.Location = New System.Drawing.Point(160, 8)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(140, 28)
        Me.lblSex.TabIndex = 1
        Me.lblSex.Text = "Sex: Male"
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSize
        '
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSize.Location = New System.Drawing.Point(310, 8)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(140, 28)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Size: Large"
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblColor
        '
        Me.lblColor.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblColor.Location = New System.Drawing.Point(460, 8)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(150, 28)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "Color: Golden"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlHealth
        '
        Me.pnlHealth.BackColor = System.Drawing.Color.White
        Me.pnlHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHealth.Controls.Add(Me.lblHealthTitle)
        Me.pnlHealth.Controls.Add(Me.lblHealth)
        Me.pnlHealth.Location = New System.Drawing.Point(23, 375)
        Me.pnlHealth.Name = "pnlHealth"
        Me.pnlHealth.Size = New System.Drawing.Size(305, 95)
        Me.pnlHealth.TabIndex = 7
        '
        'lblHealthTitle
        '
        Me.lblHealthTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHealthTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblHealthTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblHealthTitle.Name = "lblHealthTitle"
        Me.lblHealthTitle.Size = New System.Drawing.Size(285, 20)
        Me.lblHealthTitle.TabIndex = 0
        Me.lblHealthTitle.Text = "🩺 Health & Vaccination"
        '
        'lblHealth
        '
        Me.lblHealth.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblHealth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHealth.Location = New System.Drawing.Point(8, 30)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(285, 58)
        Me.lblHealth.TabIndex = 1
        Me.lblHealth.Text = "• Vaccinated: Yes (Complete)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Kind: DHPP, Rabies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Good with other pe" &
    "ts: Yes"
        '
        'pnlTraits
        '
        Me.pnlTraits.BackColor = System.Drawing.Color.White
        Me.pnlTraits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTraits.Controls.Add(Me.lblTraitsTitle)
        Me.pnlTraits.Controls.Add(Me.lblTemp)
        Me.pnlTraits.Controls.Add(Me.pbTemp)
        Me.pnlTraits.Controls.Add(Me.lblCling)
        Me.pnlTraits.Controls.Add(Me.pbCling)
        Me.pnlTraits.Location = New System.Drawing.Point(340, 375)
        Me.pnlTraits.Name = "pnlTraits"
        Me.pnlTraits.Size = New System.Drawing.Size(305, 95)
        Me.pnlTraits.TabIndex = 8
        '
        'lblTraitsTitle
        '
        Me.lblTraitsTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTraitsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTraitsTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTraitsTitle.Name = "lblTraitsTitle"
        Me.lblTraitsTitle.Size = New System.Drawing.Size(285, 18)
        Me.lblTraitsTitle.TabIndex = 0
        Me.lblTraitsTitle.Text = "⭐ Personality Traits"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTemp.Location = New System.Drawing.Point(8, 30)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(126, 13)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.Text = "Temperament (Score 2/5)"
        '
        'pbTemp
        '
        Me.pbTemp.Location = New System.Drawing.Point(145, 32)
        Me.pbTemp.Maximum = 5
        Me.pbTemp.Name = "pbTemp"
        Me.pbTemp.Size = New System.Drawing.Size(148, 12)
        Me.pbTemp.TabIndex = 2
        Me.pbTemp.Value = 2
        '
        'lblCling
        '
        Me.lblCling.AutoSize = True
        Me.lblCling.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblCling.Location = New System.Drawing.Point(8, 55)
        Me.lblCling.Name = "lblCling"
        Me.lblCling.Size = New System.Drawing.Size(115, 13)
        Me.lblCling.TabIndex = 3
        Me.lblCling.Text = "Clinginess (Score 1/5)"
        '
        'pbCling
        '
        Me.pbCling.Location = New System.Drawing.Point(145, 57)
        Me.pbCling.Maximum = 5
        Me.pbCling.Name = "pbCling"
        Me.pbCling.Size = New System.Drawing.Size(148, 12)
        Me.pbCling.TabIndex = 4
        Me.pbCling.Value = 1
        '
        'grpApply
        '
        Me.grpApply.Controls.Add(Me.lblApplicant)
        Me.grpApply.Controls.Add(Me.txtName)
        Me.grpApply.Controls.Add(Me.lblPhone)
        Me.grpApply.Controls.Add(Me.txtPhone)
        Me.grpApply.Controls.Add(Me.lblEmail)
        Me.grpApply.Controls.Add(Me.txtEmail)
        Me.grpApply.Controls.Add(Me.lblHousing)
        Me.grpApply.Controls.Add(Me.cboHousing)
        Me.grpApply.Controls.Add(Me.lblMsg)
        Me.grpApply.Controls.Add(Me.txtMsg)
        Me.grpApply.Controls.Add(Me.btnSubmit)
        Me.grpApply.Controls.Add(Me.btnCancel)
        Me.grpApply.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpApply.Location = New System.Drawing.Point(23, 480)
        Me.grpApply.Name = "grpApply"
        Me.grpApply.Size = New System.Drawing.Size(622, 255)
        Me.grpApply.TabIndex = 9
        Me.grpApply.TabStop = False
        Me.grpApply.Text = "📝 Submit Adoption Application"
        '
        'lblApplicant
        '
        Me.lblApplicant.AutoSize = True
        Me.lblApplicant.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblApplicant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblApplicant.Location = New System.Drawing.Point(15, 25)
        Me.lblApplicant.Name = "lblApplicant"
        Me.lblApplicant.Size = New System.Drawing.Size(91, 13)
        Me.lblApplicant.TabIndex = 0
        Me.lblApplicant.Text = "Your Full Name *"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.Location = New System.Drawing.Point(18, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 23)
        Me.txtName.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(315, 25)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(91, 13)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone Number *"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhone.Location = New System.Drawing.Point(318, 42)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(285, 23)
        Me.txtPhone.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(15, 75)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(85, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email Address *"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(18, 92)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 23)
        Me.txtEmail.TabIndex = 5
        '
        'lblHousing
        '
        Me.lblHousing.AutoSize = True
        Me.lblHousing.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblHousing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHousing.Location = New System.Drawing.Point(315, 75)
        Me.lblHousing.Name = "lblHousing"
        Me.lblHousing.Size = New System.Drawing.Size(81, 13)
        Me.lblHousing.TabIndex = 6
        Me.lblHousing.Text = "Housing Type *"
        '
        'cboHousing
        '
        Me.cboHousing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHousing.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboHousing.FormattingEnabled = True
        Me.cboHousing.Items.AddRange(New Object() {"House with Fenced Yard", "Apartment / Condo", "Townhouse", "Rural / Farm"})
        Me.cboHousing.Location = New System.Drawing.Point(318, 92)
        Me.cboHousing.Name = "cboHousing"
        Me.cboHousing.Size = New System.Drawing.Size(285, 23)
        Me.cboHousing.TabIndex = 7
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblMsg.Location = New System.Drawing.Point(15, 125)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(232, 13)
        Me.lblMsg.TabIndex = 8
        Me.lblMsg.Text = "Experience with pets / Message to caretaker:"
        '
        'txtMsg
        '
        Me.txtMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMsg.Location = New System.Drawing.Point(18, 142)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(585, 45)
        Me.txtMsg.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(423, 203)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(180, 36)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "🐾 Send Application"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(318, 203)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 36)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormPetDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 761)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPetDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adopt Me - Pet Details & Application"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpecs.ResumeLayout(False)
        Me.pnlHealth.ResumeLayout(False)
        Me.pnlTraits.ResumeLayout(False)
        Me.pnlTraits.PerformLayout()
        Me.grpApply.ResumeLayout(False)
        Me.grpApply.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class

