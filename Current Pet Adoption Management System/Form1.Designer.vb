<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Friend WithEvents btnLogo As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnAdopt As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents grpAdopt As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesc1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents grpSet As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesc2 As System.Windows.Forms.Label
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesc3 As System.Windows.Forms.Label
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents lblFeatured As System.Windows.Forms.Label
    Friend WithEvents lblFeaturedSub As System.Windows.Forms.Label
    Friend WithEvents lnkViewAll As System.Windows.Forms.LinkLabel
    Friend WithEvents flpFeatured As System.Windows.Forms.FlowLayoutPanel

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnAdopt = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpAdopt = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblDesc1 = New System.Windows.Forms.Label()
        Me.grpSet = New System.Windows.Forms.GroupBox()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.lblDesc2 = New System.Windows.Forms.Label()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.lblDesc3 = New System.Windows.Forms.Label()
        Me.lblFeatured = New System.Windows.Forms.Label()
        Me.lblFeaturedSub = New System.Windows.Forms.Label()
        Me.lnkViewAll = New System.Windows.Forms.LinkLabel()
        Me.flpFeatured = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.grpAdopt.SuspendLayout()
        Me.grpSet.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.btnAdmin)
        Me.pnlHeader.Controls.Add(Me.btnAbout)
        Me.pnlHeader.Controls.Add(Me.btnRecords)
        Me.pnlHeader.Controls.Add(Me.btnSet)
        Me.pnlHeader.Controls.Add(Me.btnAdopt)
        Me.pnlHeader.Controls.Add(Me.btnHome)
        Me.pnlHeader.Controls.Add(Me.btnLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(880, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(85, 32)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(760, 14)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(105, 32)
        Me.btnAdmin.TabIndex = 6
        Me.btnAdmin.Text = "🛡 Admin Mode"
        Me.btnAdmin.UseVisualStyleBackColor = False
        Me.btnAdmin.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnAbout.Location = New System.Drawing.Point(545, 14)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 32)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnRecords.Location = New System.Drawing.Point(425, 14)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(110, 32)
        Me.btnRecords.TabIndex = 4
        Me.btnRecords.Text = "My Adoptions"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnSet.Location = New System.Drawing.Point(305, 14)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(110, 32)
        Me.btnSet.TabIndex = 3
        Me.btnSet.Text = "Set Adoption"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnAdopt
        '
        Me.btnAdopt.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAdopt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdopt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdopt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnAdopt.Location = New System.Drawing.Point(205, 14)
        Me.btnAdopt.Name = "btnAdopt"
        Me.btnAdopt.Size = New System.Drawing.Size(90, 32)
        Me.btnAdopt.TabIndex = 2
        Me.btnAdopt.Text = "Adopt Me"
        Me.btnAdopt.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.White
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnHome.Location = New System.Drawing.Point(125, 14)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(70, 32)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.White
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnLogo.Location = New System.Drawing.Point(12, 14)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(100, 32)
        Me.btnLogo.TabIndex = 0
        Me.btnLogo.Text = "🐾 PAWHAVEN"
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(290, 74)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(397, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Find your new best friend"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(312, 118)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(344, 20)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Give a loving pet a safe and happy forever home."
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpAdopt
        '
        Me.grpAdopt.BackColor = System.Drawing.Color.White
        Me.grpAdopt.Controls.Add(Me.btnBrowse)
        Me.grpAdopt.Controls.Add(Me.lblDesc1)
        Me.grpAdopt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpAdopt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpAdopt.Location = New System.Drawing.Point(24, 152)
        Me.grpAdopt.Name = "grpAdopt"
        Me.grpAdopt.Size = New System.Drawing.Size(296, 128)
        Me.grpAdopt.TabIndex = 3
        Me.grpAdopt.TabStop = False
        Me.grpAdopt.Text = "🐾 Adopt a Pet"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(15, 86)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(155, 28)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse Pets →"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblDesc1
        '
        Me.lblDesc1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblDesc1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDesc1.Location = New System.Drawing.Point(12, 26)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(268, 52)
        Me.lblDesc1.TabIndex = 0
        Me.lblDesc1.Text = "Explore dogs, cats, and small animals ready for adoption. Filter by species, age, and lifestyle."
        '
        'grpSet
        '
        Me.grpSet.BackColor = System.Drawing.Color.White
        Me.grpSet.Controls.Add(Me.btnPost)
        Me.grpSet.Controls.Add(Me.lblDesc2)
        Me.grpSet.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpSet.Location = New System.Drawing.Point(344, 152)
        Me.grpSet.Name = "grpSet"
        Me.grpSet.Size = New System.Drawing.Size(296, 128)
        Me.grpSet.TabIndex = 4
        Me.grpSet.TabStop = False
        Me.grpSet.Text = "🤲 Set for Adoption"
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Location = New System.Drawing.Point(15, 86)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(155, 28)
        Me.btnPost.TabIndex = 1
        Me.btnPost.Text = "Submit Listing →"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'lblDesc2
        '
        Me.lblDesc2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblDesc2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDesc2.Location = New System.Drawing.Point(12, 26)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(268, 52)
        Me.lblDesc2.TabIndex = 0
        Me.lblDesc2.Text = "Rehome your pet safely. Register companion medical logs, traits, and temperament ratings."
        '
        'grpRecords
        '
        Me.grpRecords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRecords.BackColor = System.Drawing.Color.White
        Me.grpRecords.Controls.Add(Me.btnHistory)
        Me.grpRecords.Controls.Add(Me.lblDesc3)
        Me.grpRecords.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpRecords.Location = New System.Drawing.Point(664, 152)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(296, 128)
        Me.grpRecords.TabIndex = 5
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "📋 My Adoptions"
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(15, 86)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(155, 28)
        Me.btnHistory.TabIndex = 1
        Me.btnHistory.Text = "View Submissions →"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'lblDesc3
        '
        Me.lblDesc3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblDesc3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblDesc3.Location = New System.Drawing.Point(12, 26)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(268, 52)
        Me.lblDesc3.TabIndex = 0
        Me.lblDesc3.Text = "Monitor active listings, shelter staff verification status, and adoption applications."
        '
        'lblFeatured
        '
        Me.lblFeatured.AutoSize = True
        Me.lblFeatured.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblFeatured.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblFeatured.Location = New System.Drawing.Point(24, 298)
        Me.lblFeatured.Name = "lblFeatured"
        Me.lblFeatured.Size = New System.Drawing.Size(316, 30)
        Me.lblFeatured.TabIndex = 6
        Me.lblFeatured.Text = "Featured Pets Looking for Homes"
        '
        'lblFeaturedSub
        '
        Me.lblFeaturedSub.AutoSize = True
        Me.lblFeaturedSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFeaturedSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lblFeaturedSub.Location = New System.Drawing.Point(26, 328)
        Me.lblFeaturedSub.Name = "lblFeaturedSub"
        Me.lblFeaturedSub.Size = New System.Drawing.Size(218, 15)
        Me.lblFeaturedSub.TabIndex = 7
        Me.lblFeaturedSub.Text = "Urgent companions waiting to meet you"
        '
        'lnkViewAll
        '
        Me.lnkViewAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkViewAll.AutoSize = True
        Me.lnkViewAll.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lnkViewAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkViewAll.LinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lnkViewAll.Location = New System.Drawing.Point(892, 310)
        Me.lnkViewAll.Name = "lnkViewAll"
        Me.lnkViewAll.Size = New System.Drawing.Size(68, 17)
        Me.lnkViewAll.TabIndex = 8
        Me.lnkViewAll.TabStop = True
        Me.lnkViewAll.Text = "View All >"
        '
        'flpFeatured
        '
        Me.flpFeatured.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpFeatured.AutoScroll = True
        Me.flpFeatured.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.flpFeatured.Location = New System.Drawing.Point(24, 354)
        Me.flpFeatured.Name = "flpFeatured"
        Me.flpFeatured.Size = New System.Drawing.Size(942, 338)
        Me.flpFeatured.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 705)
        Me.Controls.Add(Me.flpFeatured)
        Me.Controls.Add(Me.lnkViewAll)
        Me.Controls.Add(Me.lblFeaturedSub)
        Me.Controls.Add(Me.lblFeatured)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.grpSet)
        Me.Controls.Add(Me.grpAdopt)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(920, 680)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PawHaven - Find Your New Best Friend"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpAdopt.ResumeLayout(False)
        Me.grpSet.ResumeLayout(False)
        Me.grpRecords.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
