<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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

    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents grpPetInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblSpecies As System.Windows.Forms.Label
    Friend WithEvents cboSpecies As System.Windows.Forms.ComboBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblBreed As System.Windows.Forms.Label
    Friend WithEvents txtBreed As System.Windows.Forms.TextBox
    Friend WithEvents grpHealth As System.Windows.Forms.GroupBox
    Friend WithEvents lblLiveWith As System.Windows.Forms.Label
    Friend WithEvents rbPetsYes As System.Windows.Forms.RadioButton
    Friend WithEvents rbPetsNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblVaccinated As System.Windows.Forms.Label
    Friend WithEvents rbVacYes As System.Windows.Forms.RadioButton
    Friend WithEvents rbVacNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblVacStatus As System.Windows.Forms.Label
    Friend WithEvents cboVacStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblVacKind As System.Windows.Forms.Label
    Friend WithEvents txtVacKind As System.Windows.Forms.TextBox
    Friend WithEvents grpTraits As System.Windows.Forms.GroupBox
    Friend WithEvents lblTemperament As System.Windows.Forms.Label
    Friend WithEvents rbTemp1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTemp2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTemp3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTemp4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTemp5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblTempHint As System.Windows.Forms.Label
    Friend WithEvents lblClinginess As System.Windows.Forms.Label
    Friend WithEvents rbCling1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCling2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCling3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCling4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCling5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblClingHint As System.Windows.Forms.Label
    Friend WithEvents grpOwner As System.Windows.Forms.GroupBox
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents grpPhoto As System.Windows.Forms.GroupBox
    Friend WithEvents picPet As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpPetInfo = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.cboSpecies = New System.Windows.Forms.ComboBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.grpHealth = New System.Windows.Forms.GroupBox()
        Me.lblLiveWith = New System.Windows.Forms.Label()
        Me.rbPetsYes = New System.Windows.Forms.RadioButton()
        Me.rbPetsNo = New System.Windows.Forms.RadioButton()
        Me.lblVaccinated = New System.Windows.Forms.Label()
        Me.rbVacYes = New System.Windows.Forms.RadioButton()
        Me.rbVacNo = New System.Windows.Forms.RadioButton()
        Me.lblVacStatus = New System.Windows.Forms.Label()
        Me.cboVacStatus = New System.Windows.Forms.ComboBox()
        Me.lblVacKind = New System.Windows.Forms.Label()
        Me.txtVacKind = New System.Windows.Forms.TextBox()
        Me.grpTraits = New System.Windows.Forms.GroupBox()
        Me.lblTemperament = New System.Windows.Forms.Label()
        Me.rbTemp1 = New System.Windows.Forms.RadioButton()
        Me.rbTemp2 = New System.Windows.Forms.RadioButton()
        Me.rbTemp3 = New System.Windows.Forms.RadioButton()
        Me.rbTemp4 = New System.Windows.Forms.RadioButton()
        Me.rbTemp5 = New System.Windows.Forms.RadioButton()
        Me.lblTempHint = New System.Windows.Forms.Label()
        Me.lblClinginess = New System.Windows.Forms.Label()
        Me.rbCling1 = New System.Windows.Forms.RadioButton()
        Me.rbCling2 = New System.Windows.Forms.RadioButton()
        Me.rbCling3 = New System.Windows.Forms.RadioButton()
        Me.rbCling4 = New System.Windows.Forms.RadioButton()
        Me.rbCling5 = New System.Windows.Forms.RadioButton()
        Me.lblClingHint = New System.Windows.Forms.Label()
        Me.grpOwner = New System.Windows.Forms.GroupBox()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.txtOwner = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.grpPhoto = New System.Windows.Forms.GroupBox()
        Me.picPet = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpPetInfo.SuspendLayout()
        Me.grpHealth.SuspendLayout()
        Me.grpTraits.SuspendLayout()
        Me.grpOwner.SuspendLayout()
        Me.grpPhoto.SuspendLayout()
        CType(Me.picPet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.White
        Me.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRecords.Location = New System.Drawing.Point(30, 15)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(130, 32)
        Me.btnRecords.TabIndex = 0
        Me.btnRecords.Text = "📁 My Adoptions"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(740, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(155, 32)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "← Back to Homepage"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(30, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(865, 38)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Set Your Pet for Adoption"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(30, 85)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(865, 20)
        Me.lblSubtitle.TabIndex = 3
        Me.lblSubtitle.Text = "Not financially capable enough to take care of your pet anymore? Leave it to us"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpPetInfo
        '
        Me.grpPetInfo.BackColor = System.Drawing.Color.White
        Me.grpPetInfo.Controls.Add(Me.lblName)
        Me.grpPetInfo.Controls.Add(Me.txtName)
        Me.grpPetInfo.Controls.Add(Me.lblSpecies)
        Me.grpPetInfo.Controls.Add(Me.cboSpecies)
        Me.grpPetInfo.Controls.Add(Me.lblAge)
        Me.grpPetInfo.Controls.Add(Me.txtAge)
        Me.grpPetInfo.Controls.Add(Me.lblGender)
        Me.grpPetInfo.Controls.Add(Me.rbMale)
        Me.grpPetInfo.Controls.Add(Me.rbFemale)
        Me.grpPetInfo.Controls.Add(Me.lblSize)
        Me.grpPetInfo.Controls.Add(Me.cboSize)
        Me.grpPetInfo.Controls.Add(Me.lblColor)
        Me.grpPetInfo.Controls.Add(Me.txtColor)
        Me.grpPetInfo.Controls.Add(Me.lblBreed)
        Me.grpPetInfo.Controls.Add(Me.txtBreed)
        Me.grpPetInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpPetInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpPetInfo.Location = New System.Drawing.Point(30, 115)
        Me.grpPetInfo.Name = "grpPetInfo"
        Me.grpPetInfo.Size = New System.Drawing.Size(280, 275)
        Me.grpPetInfo.TabIndex = 4
        Me.grpPetInfo.TabStop = False
        Me.grpPetInfo.Text = "Pet Information:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(12, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtName.Location = New System.Drawing.Point(80, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(185, 23)
        Me.txtName.TabIndex = 1
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSpecies.Location = New System.Drawing.Point(12, 65)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(52, 15)
        Me.lblSpecies.TabIndex = 2
        Me.lblSpecies.Text = "Species:"
        '
        'cboSpecies
        '
        Me.cboSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpecies.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Items.AddRange(New Object() {"Dog", "Cat", "Small Pet", "Other"})
        Me.cboSpecies.Location = New System.Drawing.Point(80, 62)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.Size = New System.Drawing.Size(185, 21)
        Me.cboSpecies.TabIndex = 3
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(12, 100)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 15)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtAge.Location = New System.Drawing.Point(80, 97)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(185, 23)
        Me.txtAge.TabIndex = 5
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(12, 135)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(51, 15)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender:"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Checked = True
        Me.rbMale.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbMale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbMale.Location = New System.Drawing.Point(80, 133)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(51, 19)
        Me.rbMale.TabIndex = 7
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbFemale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbFemale.Location = New System.Drawing.Point(150, 133)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 19)
        Me.rbFemale.TabIndex = 8
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSize.Location = New System.Drawing.Point(12, 170)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(33, 15)
        Me.lblSize.TabIndex = 9
        Me.lblSize.Text = "Size:"
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(80, 167)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(185, 21)
        Me.cboSize.TabIndex = 10
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblColor.Location = New System.Drawing.Point(12, 205)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(39, 15)
        Me.lblColor.TabIndex = 11
        Me.lblColor.Text = "Color:"
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtColor.Location = New System.Drawing.Point(80, 202)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(185, 23)
        Me.txtColor.TabIndex = 12
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblBreed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblBreed.Location = New System.Drawing.Point(12, 240)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(43, 15)
        Me.lblBreed.TabIndex = 13
        Me.lblBreed.Text = "Breed:"
        '
        'txtBreed
        '
        Me.txtBreed.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtBreed.Location = New System.Drawing.Point(80, 237)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(185, 23)
        Me.txtBreed.TabIndex = 14
        '
        'grpHealth
        '
        Me.grpHealth.BackColor = System.Drawing.Color.White
        Me.grpHealth.Controls.Add(Me.lblLiveWith)
        Me.grpHealth.Controls.Add(Me.rbPetsYes)
        Me.grpHealth.Controls.Add(Me.rbPetsNo)
        Me.grpHealth.Controls.Add(Me.lblVaccinated)
        Me.grpHealth.Controls.Add(Me.rbVacYes)
        Me.grpHealth.Controls.Add(Me.rbVacNo)
        Me.grpHealth.Controls.Add(Me.lblVacStatus)
        Me.grpHealth.Controls.Add(Me.cboVacStatus)
        Me.grpHealth.Controls.Add(Me.lblVacKind)
        Me.grpHealth.Controls.Add(Me.txtVacKind)
        Me.grpHealth.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpHealth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpHealth.Location = New System.Drawing.Point(325, 115)
        Me.grpHealth.Name = "grpHealth"
        Me.grpHealth.Size = New System.Drawing.Size(280, 275)
        Me.grpHealth.TabIndex = 5
        Me.grpHealth.TabStop = False
        Me.grpHealth.Text = "Others / Health:"
        '
        'lblLiveWith
        '
        Me.lblLiveWith.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblLiveWith.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblLiveWith.Location = New System.Drawing.Point(12, 28)
        Me.lblLiveWith.Name = "lblLiveWith"
        Me.lblLiveWith.Size = New System.Drawing.Size(250, 18)
        Me.lblLiveWith.TabIndex = 0
        Me.lblLiveWith.Text = "Can live with other pets?"
        '
        'rbPetsYes
        '
        Me.rbPetsYes.AutoSize = True
        Me.rbPetsYes.Checked = True
        Me.rbPetsYes.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbPetsYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbPetsYes.Location = New System.Drawing.Point(15, 48)
        Me.rbPetsYes.Name = "rbPetsYes"
        Me.rbPetsYes.Size = New System.Drawing.Size(42, 19)
        Me.rbPetsYes.TabIndex = 1
        Me.rbPetsYes.TabStop = True
        Me.rbPetsYes.Text = "Yes"
        Me.rbPetsYes.UseVisualStyleBackColor = True
        '
        'rbPetsNo
        '
        Me.rbPetsNo.AutoSize = True
        Me.rbPetsNo.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbPetsNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbPetsNo.Location = New System.Drawing.Point(80, 48)
        Me.rbPetsNo.Name = "rbPetsNo"
        Me.rbPetsNo.Size = New System.Drawing.Size(41, 19)
        Me.rbPetsNo.TabIndex = 2
        Me.rbPetsNo.Text = "No"
        Me.rbPetsNo.UseVisualStyleBackColor = True
        '
        'lblVaccinated
        '
        Me.lblVaccinated.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblVaccinated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblVaccinated.Location = New System.Drawing.Point(12, 85)
        Me.lblVaccinated.Name = "lblVaccinated"
        Me.lblVaccinated.Size = New System.Drawing.Size(250, 18)
        Me.lblVaccinated.TabIndex = 3
        Me.lblVaccinated.Text = "Is the pet vaccinated?"
        '
        'rbVacYes
        '
        Me.rbVacYes.AutoSize = True
        Me.rbVacYes.Checked = True
        Me.rbVacYes.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbVacYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbVacYes.Location = New System.Drawing.Point(15, 105)
        Me.rbVacYes.Name = "rbVacYes"
        Me.rbVacYes.Size = New System.Drawing.Size(42, 19)
        Me.rbVacYes.TabIndex = 4
        Me.rbVacYes.TabStop = True
        Me.rbVacYes.Text = "Yes"
        Me.rbVacYes.UseVisualStyleBackColor = True
        '
        'rbVacNo
        '
        Me.rbVacNo.AutoSize = True
        Me.rbVacNo.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbVacNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbVacNo.Location = New System.Drawing.Point(80, 105)
        Me.rbVacNo.Name = "rbVacNo"
        Me.rbVacNo.Size = New System.Drawing.Size(41, 19)
        Me.rbVacNo.TabIndex = 5
        Me.rbVacNo.Text = "No"
        Me.rbVacNo.UseVisualStyleBackColor = True
        '
        'lblVacStatus
        '
        Me.lblVacStatus.AutoSize = True
        Me.lblVacStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblVacStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblVacStatus.Location = New System.Drawing.Point(12, 145)
        Me.lblVacStatus.Name = "lblVacStatus"
        Me.lblVacStatus.Size = New System.Drawing.Size(109, 15)
        Me.lblVacStatus.TabIndex = 6
        Me.lblVacStatus.Text = "Vaccine Complete:"
        '
        'cboVacStatus
        '
        Me.cboVacStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVacStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cboVacStatus.FormattingEnabled = True
        Me.cboVacStatus.Items.AddRange(New Object() {"Complete", "Incomplete", "Unknown"})
        Me.cboVacStatus.Location = New System.Drawing.Point(15, 165)
        Me.cboVacStatus.Name = "cboVacStatus"
        Me.cboVacStatus.Size = New System.Drawing.Size(250, 21)
        Me.cboVacStatus.TabIndex = 7
        '
        'lblVacKind
        '
        Me.lblVacKind.AutoSize = True
        Me.lblVacKind.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblVacKind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblVacKind.Location = New System.Drawing.Point(12, 205)
        Me.lblVacKind.Name = "lblVacKind"
        Me.lblVacKind.Size = New System.Drawing.Size(126, 15)
        Me.lblVacKind.TabIndex = 8
        Me.lblVacKind.Text = "What kind of vaccine?"
        '
        'txtVacKind
        '
        Me.txtVacKind.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtVacKind.Location = New System.Drawing.Point(15, 225)
        Me.txtVacKind.Name = "txtVacKind"
        Me.txtVacKind.Size = New System.Drawing.Size(250, 23)
        Me.txtVacKind.TabIndex = 9
        '
        'grpTraits
        '
        Me.grpTraits.BackColor = System.Drawing.Color.White
        Me.grpTraits.Controls.Add(Me.lblTemperament)
        Me.grpTraits.Controls.Add(Me.rbTemp1)
        Me.grpTraits.Controls.Add(Me.rbTemp2)
        Me.grpTraits.Controls.Add(Me.rbTemp3)
        Me.grpTraits.Controls.Add(Me.rbTemp4)
        Me.grpTraits.Controls.Add(Me.rbTemp5)
        Me.grpTraits.Controls.Add(Me.lblTempHint)
        Me.grpTraits.Controls.Add(Me.lblClinginess)
        Me.grpTraits.Controls.Add(Me.rbCling1)
        Me.grpTraits.Controls.Add(Me.rbCling2)
        Me.grpTraits.Controls.Add(Me.rbCling3)
        Me.grpTraits.Controls.Add(Me.rbCling4)
        Me.grpTraits.Controls.Add(Me.rbCling5)
        Me.grpTraits.Controls.Add(Me.lblClingHint)
        Me.grpTraits.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpTraits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpTraits.Location = New System.Drawing.Point(620, 115)
        Me.grpTraits.Name = "grpTraits"
        Me.grpTraits.Size = New System.Drawing.Size(280, 275)
        Me.grpTraits.TabIndex = 6
        Me.grpTraits.TabStop = False
        Me.grpTraits.Text = "Personality Traits:"
        '
        'lblTemperament
        '
        Me.lblTemperament.AutoSize = True
        Me.lblTemperament.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTemperament.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTemperament.Location = New System.Drawing.Point(12, 30)
        Me.lblTemperament.Name = "lblTemperament"
        Me.lblTemperament.Size = New System.Drawing.Size(124, 15)
        Me.lblTemperament.TabIndex = 0
        Me.lblTemperament.Text = "Temperament (1 to 5)"
        '
        'rbTemp1
        '
        Me.rbTemp1.AutoSize = True
        Me.rbTemp1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbTemp1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbTemp1.Location = New System.Drawing.Point(15, 55)
        Me.rbTemp1.Name = "rbTemp1"
        Me.rbTemp1.Size = New System.Drawing.Size(31, 19)
        Me.rbTemp1.TabIndex = 1
        Me.rbTemp1.Text = "1"
        Me.rbTemp1.UseVisualStyleBackColor = True
        '
        'rbTemp2
        '
        Me.rbTemp2.AutoSize = True
        Me.rbTemp2.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbTemp2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbTemp2.Location = New System.Drawing.Point(65, 55)
        Me.rbTemp2.Name = "rbTemp2"
        Me.rbTemp2.Size = New System.Drawing.Size(31, 19)
        Me.rbTemp2.TabIndex = 2
        Me.rbTemp2.Text = "2"
        Me.rbTemp2.UseVisualStyleBackColor = True
        '
        'rbTemp3
        '
        Me.rbTemp3.AutoSize = True
        Me.rbTemp3.Checked = True
        Me.rbTemp3.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbTemp3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbTemp3.Location = New System.Drawing.Point(115, 55)
        Me.rbTemp3.Name = "rbTemp3"
        Me.rbTemp3.Size = New System.Drawing.Size(31, 19)
        Me.rbTemp3.TabIndex = 3
        Me.rbTemp3.TabStop = True
        Me.rbTemp3.Text = "3"
        Me.rbTemp3.UseVisualStyleBackColor = True
        '
        'rbTemp4
        '
        Me.rbTemp4.AutoSize = True
        Me.rbTemp4.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbTemp4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbTemp4.Location = New System.Drawing.Point(165, 55)
        Me.rbTemp4.Name = "rbTemp4"
        Me.rbTemp4.Size = New System.Drawing.Size(31, 19)
        Me.rbTemp4.TabIndex = 4
        Me.rbTemp4.Text = "4"
        Me.rbTemp4.UseVisualStyleBackColor = True
        '
        'rbTemp5
        '
        Me.rbTemp5.AutoSize = True
        Me.rbTemp5.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbTemp5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbTemp5.Location = New System.Drawing.Point(215, 55)
        Me.rbTemp5.Name = "rbTemp5"
        Me.rbTemp5.Size = New System.Drawing.Size(31, 19)
        Me.rbTemp5.TabIndex = 5
        Me.rbTemp5.Text = "5"
        Me.rbTemp5.UseVisualStyleBackColor = True
        '
        'lblTempHint
        '
        Me.lblTempHint.AutoSize = True
        Me.lblTempHint.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblTempHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTempHint.Location = New System.Drawing.Point(12, 85)
        Me.lblTempHint.Name = "lblTempHint"
        Me.lblTempHint.Size = New System.Drawing.Size(225, 12)
        Me.lblTempHint.TabIndex = 6
        Me.lblTempHint.Text = "Chill                     Mid                     Hyper"
        '
        'lblClinginess
        '
        Me.lblClinginess.AutoSize = True
        Me.lblClinginess.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblClinginess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblClinginess.Location = New System.Drawing.Point(12, 140)
        Me.lblClinginess.Name = "lblClinginess"
        Me.lblClinginess.Size = New System.Drawing.Size(107, 15)
        Me.lblClinginess.TabIndex = 7
        Me.lblClinginess.Text = "Clinginess (1 to 5)"
        '
        'rbCling1
        '
        Me.rbCling1.AutoSize = True
        Me.rbCling1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbCling1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbCling1.Location = New System.Drawing.Point(15, 165)
        Me.rbCling1.Name = "rbCling1"
        Me.rbCling1.Size = New System.Drawing.Size(31, 19)
        Me.rbCling1.TabIndex = 8
        Me.rbCling1.Text = "1"
        Me.rbCling1.UseVisualStyleBackColor = True
        '
        'rbCling2
        '
        Me.rbCling2.AutoSize = True
        Me.rbCling2.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbCling2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbCling2.Location = New System.Drawing.Point(65, 165)
        Me.rbCling2.Name = "rbCling2"
        Me.rbCling2.Size = New System.Drawing.Size(31, 19)
        Me.rbCling2.TabIndex = 9
        Me.rbCling2.Text = "2"
        Me.rbCling2.UseVisualStyleBackColor = True
        '
        'rbCling3
        '
        Me.rbCling3.AutoSize = True
        Me.rbCling3.Checked = True
        Me.rbCling3.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbCling3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbCling3.Location = New System.Drawing.Point(115, 165)
        Me.rbCling3.Name = "rbCling3"
        Me.rbCling3.Size = New System.Drawing.Size(31, 19)
        Me.rbCling3.TabIndex = 10
        Me.rbCling3.TabStop = True
        Me.rbCling3.Text = "3"
        Me.rbCling3.UseVisualStyleBackColor = True
        '
        'rbCling4
        '
        Me.rbCling4.AutoSize = True
        Me.rbCling4.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbCling4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbCling4.Location = New System.Drawing.Point(165, 165)
        Me.rbCling4.Name = "rbCling4"
        Me.rbCling4.Size = New System.Drawing.Size(31, 19)
        Me.rbCling4.TabIndex = 11
        Me.rbCling4.Text = "4"
        Me.rbCling4.UseVisualStyleBackColor = True
        '
        'rbCling5
        '
        Me.rbCling5.AutoSize = True
        Me.rbCling5.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.rbCling5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rbCling5.Location = New System.Drawing.Point(215, 165)
        Me.rbCling5.Name = "rbCling5"
        Me.rbCling5.Size = New System.Drawing.Size(31, 19)
        Me.rbCling5.TabIndex = 12
        Me.rbCling5.Text = "5"
        Me.rbCling5.UseVisualStyleBackColor = True
        '
        'lblClingHint
        '
        Me.lblClingHint.AutoSize = True
        Me.lblClingHint.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblClingHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblClingHint.Location = New System.Drawing.Point(12, 195)
        Me.lblClingHint.Name = "lblClingHint"
        Me.lblClingHint.Size = New System.Drawing.Size(227, 12)
        Me.lblClingHint.TabIndex = 13
        Me.lblClingHint.Text = "Cuddler                  Mid             Independent"
        '
        'grpOwner
        '
        Me.grpOwner.BackColor = System.Drawing.Color.White
        Me.grpOwner.Controls.Add(Me.lblOwner)
        Me.grpOwner.Controls.Add(Me.txtOwner)
        Me.grpOwner.Controls.Add(Me.lblPhone)
        Me.grpOwner.Controls.Add(Me.txtPhone)
        Me.grpOwner.Controls.Add(Me.lblCity)
        Me.grpOwner.Controls.Add(Me.txtCity)
        Me.grpOwner.Controls.Add(Me.lblEmail)
        Me.grpOwner.Controls.Add(Me.txtEmail)
        Me.grpOwner.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpOwner.Location = New System.Drawing.Point(30, 405)
        Me.grpOwner.Name = "grpOwner"
        Me.grpOwner.Size = New System.Drawing.Size(575, 140)
        Me.grpOwner.TabIndex = 7
        Me.grpOwner.TabStop = False
        Me.grpOwner.Text = "Owner Information:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblOwner.Location = New System.Drawing.Point(12, 30)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(65, 15)
        Me.lblOwner.TabIndex = 0
        Me.lblOwner.Text = "Full Name:"
        '
        'txtOwner
        '
        Me.txtOwner.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtOwner.Location = New System.Drawing.Point(115, 27)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.Size = New System.Drawing.Size(435, 23)
        Me.txtOwner.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(12, 65)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(99, 15)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Contact number:"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtPhone.Location = New System.Drawing.Point(115, 62)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(435, 23)
        Me.txtPhone.TabIndex = 3
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCity.Location = New System.Drawing.Point(12, 100)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(86, 15)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City/Province:"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtCity.Location = New System.Drawing.Point(115, 97)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(160, 23)
        Me.txtCity.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(290, 100)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.txtEmail.Location = New System.Drawing.Point(340, 97)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(210, 23)
        Me.txtEmail.TabIndex = 7
        '
        'grpPhoto
        '
        Me.grpPhoto.BackColor = System.Drawing.Color.White
        Me.grpPhoto.Controls.Add(Me.picPet)
        Me.grpPhoto.Controls.Add(Me.btnUpload)
        Me.grpPhoto.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpPhoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpPhoto.Location = New System.Drawing.Point(620, 405)
        Me.grpPhoto.Name = "grpPhoto"
        Me.grpPhoto.Size = New System.Drawing.Size(280, 140)
        Me.grpPhoto.TabIndex = 8
        Me.grpPhoto.TabStop = False
        Me.grpPhoto.Text = "Pet Image:"
        '
        'picPet
        '
        Me.picPet.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.picPet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPet.Location = New System.Drawing.Point(15, 25)
        Me.picPet.Name = "picPet"
        Me.picPet.Size = New System.Drawing.Size(250, 68)
        Me.picPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPet.TabIndex = 0
        Me.picPet.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUpload.Location = New System.Drawing.Point(65, 100)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(150, 28)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "📁 Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(340, 560)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(265, 42)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "🐾 Submit Pet for Adoption"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(930, 620)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpPhoto)
        Me.Controls.Add(Me.grpOwner)
        Me.Controls.Add(Me.grpTraits)
        Me.Controls.Add(Me.grpHealth)
        Me.Controls.Add(Me.grpPetInfo)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRecords)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PawHaven - Set Pet for Adoption"
        Me.grpPetInfo.ResumeLayout(False)
        Me.grpPetInfo.PerformLayout()
        Me.grpHealth.ResumeLayout(False)
        Me.grpHealth.PerformLayout()
        Me.grpTraits.ResumeLayout(False)
        Me.grpTraits.PerformLayout()
        Me.grpOwner.ResumeLayout(False)
        Me.grpOwner.PerformLayout()
        Me.grpPhoto.ResumeLayout(False)
        CType(Me.picPet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class

