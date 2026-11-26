<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnDog As System.Windows.Forms.Button
    Friend WithEvents btnCat As System.Windows.Forms.Button
    Friend WithEvents btnSmall As System.Windows.Forms.Button
    Friend WithEvents lblAgeGroup As System.Windows.Forms.Label
    Friend WithEvents cboAge As System.Windows.Forms.ComboBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents flpPets As System.Windows.Forms.FlowLayoutPanel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.cboAge = New System.Windows.Forms.ComboBox()
        Me.lblAgeGroup = New System.Windows.Forms.Label()
        Me.btnSmall = New System.Windows.Forms.Button()
        Me.btnCat = New System.Windows.Forms.Button()
        Me.btnDog = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.flpPets = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(24, 16)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 32)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "← Back to Dashboard"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblBrand
        '
        Me.lblBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblBrand.Location = New System.Drawing.Point(858, 22)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(122, 15)
        Me.lblBrand.TabIndex = 1
        Me.lblBrand.Text = "ADOPT ME CATALOG"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(342, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(356, 41)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Find Your Perfect Match"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(244, 92)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(548, 17)
        Me.lblSubtitle.TabIndex = 3
        Me.lblSubtitle.Text = "Filter pets by temperament, species, and lifestyle requirements to find your idea" &
    "l companion."
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFilter
        '
        Me.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilter.Controls.Add(Me.btnReset)
        Me.pnlFilter.Controls.Add(Me.cboGender)
        Me.pnlFilter.Controls.Add(Me.lblGender)
        Me.pnlFilter.Controls.Add(Me.cboSize)
        Me.pnlFilter.Controls.Add(Me.lblSize)
        Me.pnlFilter.Controls.Add(Me.cboAge)
        Me.pnlFilter.Controls.Add(Me.lblAgeGroup)
        Me.pnlFilter.Controls.Add(Me.btnSmall)
        Me.pnlFilter.Controls.Add(Me.btnCat)
        Me.pnlFilter.Controls.Add(Me.btnDog)
        Me.pnlFilter.Controls.Add(Me.btnAll)
        Me.pnlFilter.Controls.Add(Me.txtSearch)
        Me.pnlFilter.Location = New System.Drawing.Point(145, 122)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(730, 114)
        Me.pnlFilter.TabIndex = 4
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(562, 72)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(150, 26)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "🔄 Reset Filters"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male & Female", "Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(382, 73)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(168, 21)
        Me.cboGender.TabIndex = 10
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(442, 55)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Any Size", "Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(198, 73)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(168, 21)
        Me.cboSize.TabIndex = 8
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblSize.Location = New System.Drawing.Point(268, 55)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(27, 13)
        Me.lblSize.TabIndex = 7
        Me.lblSize.Text = "Size"
        '
        'cboAge
        '
        Me.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAge.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cboAge.FormattingEnabled = True
        Me.cboAge.Items.AddRange(New Object() {"Any Age", "Puppy/Kitten", "Young", "Adult", "Senior"})
        Me.cboAge.Location = New System.Drawing.Point(16, 73)
        Me.cboAge.Name = "cboAge"
        Me.cboAge.Size = New System.Drawing.Size(168, 21)
        Me.cboAge.TabIndex = 6
        '
        'lblAgeGroup
        '
        Me.lblAgeGroup.AutoSize = True
        Me.lblAgeGroup.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAgeGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblAgeGroup.Location = New System.Drawing.Point(68, 55)
        Me.lblAgeGroup.Name = "lblAgeGroup"
        Me.lblAgeGroup.Size = New System.Drawing.Size(64, 13)
        Me.lblAgeGroup.TabIndex = 5
        Me.lblAgeGroup.Text = "Age Group"
        '
        'btnSmall
        '
        Me.btnSmall.BackColor = System.Drawing.Color.White
        Me.btnSmall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSmall.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSmall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnSmall.Location = New System.Drawing.Point(614, 15)
        Me.btnSmall.Name = "btnSmall"
        Me.btnSmall.Size = New System.Drawing.Size(98, 28)
        Me.btnSmall.TabIndex = 4
        Me.btnSmall.Text = "🐰 Small Pets"
        Me.btnSmall.UseVisualStyleBackColor = False
        '
        'btnCat
        '
        Me.btnCat.BackColor = System.Drawing.Color.White
        Me.btnCat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCat.Location = New System.Drawing.Point(535, 15)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(72, 28)
        Me.btnCat.TabIndex = 3
        Me.btnCat.Text = "🐱 Cats"
        Me.btnCat.UseVisualStyleBackColor = False
        '
        'btnDog
        '
        Me.btnDog.BackColor = System.Drawing.Color.White
        Me.btnDog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDog.Location = New System.Drawing.Point(452, 15)
        Me.btnDog.Name = "btnDog"
        Me.btnDog.Size = New System.Drawing.Size(76, 28)
        Me.btnDog.TabIndex = 2
        Me.btnDog.Text = "🐶 Dogs"
        Me.btnDog.UseVisualStyleBackColor = False
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(374, 15)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(72, 28)
        Me.btnAll.TabIndex = 1
        Me.btnAll.Text = "All Pets"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearch.Location = New System.Drawing.Point(16, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(348, 24)
        Me.txtSearch.TabIndex = 0
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblAvailable.Location = New System.Drawing.Point(24, 254)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(382, 25)
        Me.lblAvailable.TabIndex = 5
        Me.lblAvailable.Text = "💚 Available Pets • Ready for loving homes"
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(868, 254)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(116, 26)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "Showing 6 pets"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpPets
        '
        Me.flpPets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpPets.AutoScroll = True
        Me.flpPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.flpPets.Location = New System.Drawing.Point(24, 290)
        Me.flpPets.Name = "flpPets"
        Me.flpPets.Size = New System.Drawing.Size(964, 385)
        Me.flpPets.TabIndex = 7
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 690)
        Me.Controls.Add(Me.flpPets)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(960, 620)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PawHaven - Adopt Me Catalog"
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
