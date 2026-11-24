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

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents grpFilter As System.Windows.Forms.GroupBox
    Friend WithEvents grpSpecies As System.Windows.Forms.GroupBox
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbDog As System.Windows.Forms.RadioButton
    Friend WithEvents rbCat As System.Windows.Forms.RadioButton
    Friend WithEvents rbSmall As System.Windows.Forms.RadioButton
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents chkVac As System.Windows.Forms.CheckBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAdopt As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.chkVac = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.grpSpecies = New System.Windows.Forms.GroupBox()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.rbCat = New System.Windows.Forms.RadioButton()
        Me.rbDog = New System.Windows.Forms.RadioButton()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.btnAdopt = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.grpSpecies.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnRecords)
        Me.pnlHeader.Controls.Add(Me.btnSet)
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.lblBrand)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1004, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'btnRecords
        '
        Me.btnRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnRecords.Location = New System.Drawing.Point(860, 14)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(125, 32)
        Me.btnRecords.TabIndex = 3
        Me.btnRecords.Text = "My Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnSet
        '
        Me.btnSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnSet.Location = New System.Drawing.Point(725, 14)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(125, 32)
        Me.btnSet.TabIndex = 2
        Me.btnSet.Text = "+ Set Adoption"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(195, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 32)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "← Back to Home"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(20, 18)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(127, 21)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "🐾 PAWHAVEN"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 75)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(172, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Available Pets"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 110)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(467, 17)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Browse verified pets ready for loving forever homes. Filter by species and size."
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.BackColor = System.Drawing.Color.White
        Me.grpFilter.Controls.Add(Me.btnReset)
        Me.grpFilter.Controls.Add(Me.lblSize)
        Me.grpFilter.Controls.Add(Me.cboSize)
        Me.grpFilter.Controls.Add(Me.chkVac)
        Me.grpFilter.Controls.Add(Me.btnSearch)
        Me.grpFilter.Controls.Add(Me.txtSearch)
        Me.grpFilter.Controls.Add(Me.lblSearch)
        Me.grpFilter.Controls.Add(Me.grpSpecies)
        Me.grpFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpFilter.Location = New System.Drawing.Point(24, 138)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(955, 125)
        Me.grpFilter.TabIndex = 3
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter & Search Pets"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(835, 80)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset All"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblSize.Location = New System.Drawing.Point(520, 87)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 6
        Me.lblSize.Text = "Size:"
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"All Sizes", "Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(560, 83)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(120, 23)
        Me.cboSize.TabIndex = 5
        '
        'chkVac
        '
        Me.chkVac.AutoSize = True
        Me.chkVac.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkVac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.chkVac.Location = New System.Drawing.Point(695, 85)
        Me.chkVac.Name = "chkVac"
        Me.chkVac.Size = New System.Drawing.Size(111, 19)
        Me.chkVac.TabIndex = 4
        Me.chkVac.Text = "Vaccinated Only"
        Me.chkVac.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(395, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSearch.Location = New System.Drawing.Point(135, 82)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 25)
        Me.txtSearch.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 87)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(123, 15)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search Name/Breed:"
        '
        'grpSpecies
        '
        Me.grpSpecies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSpecies.Controls.Add(Me.rbSmall)
        Me.grpSpecies.Controls.Add(Me.rbCat)
        Me.grpSpecies.Controls.Add(Me.rbDog)
        Me.grpSpecies.Controls.Add(Me.rbAll)
        Me.grpSpecies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpSpecies.Location = New System.Drawing.Point(15, 22)
        Me.grpSpecies.Name = "grpSpecies"
        Me.grpSpecies.Size = New System.Drawing.Size(920, 50)
        Me.grpSpecies.TabIndex = 0
        Me.grpSpecies.TabStop = False
        Me.grpSpecies.Text = "Select Species (User Selection)"
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbSmall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.rbSmall.Location = New System.Drawing.Point(400, 20)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(115, 19)
        Me.rbSmall.TabIndex = 3
        Me.rbSmall.Text = "🐰 Small Animals"
        Me.rbSmall.UseVisualStyleBackColor = True
        '
        'rbCat
        '
        Me.rbCat.AutoSize = True
        Me.rbCat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.rbCat.Location = New System.Drawing.Point(260, 20)
        Me.rbCat.Name = "rbCat"
        Me.rbCat.Size = New System.Drawing.Size(63, 19)
        Me.rbCat.TabIndex = 2
        Me.rbCat.Text = "🐱 Cats"
        Me.rbCat.UseVisualStyleBackColor = True
        '
        'rbDog
        '
        Me.rbDog.AutoSize = True
        Me.rbDog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rbDog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.rbDog.Location = New System.Drawing.Point(140, 20)
        Me.rbDog.Name = "rbDog"
        Me.rbDog.Size = New System.Drawing.Size(67, 19)
        Me.rbDog.TabIndex = 1
        Me.rbDog.Text = "🐶 Dogs"
        Me.rbDog.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rbAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.rbAll.Location = New System.Drawing.Point(15, 20)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(85, 19)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All Animals"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'btnAdopt
        '
        Me.btnAdopt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdopt.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAdopt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdopt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdopt.ForeColor = System.Drawing.Color.White
        Me.btnAdopt.Location = New System.Drawing.Point(780, 580)
        Me.btnAdopt.Name = "btnAdopt"
        Me.btnAdopt.Size = New System.Drawing.Size(200, 38)
        Me.btnAdopt.TabIndex = 5
        Me.btnAdopt.Text = "🐾 Adopt / View Pet"
        Me.btnAdopt.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(24, 592)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(134, 15)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "Showing 0 companions"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 635)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnAdopt)
        Me.Controls.Add(Me.grpFilter)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(850, 600)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PawHaven - Adopt Me Catalog"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.grpSpecies.ResumeLayout(False)
        Me.grpSpecies.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

