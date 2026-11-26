<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents grpMission1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMission1 As System.Windows.Forms.Label
    Friend WithEvents grpMission2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMission2 As System.Windows.Forms.Label
    Friend WithEvents grpMission3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMission3 As System.Windows.Forms.Label
    Friend WithEvents grpProcess As System.Windows.Forms.GroupBox
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents grpContact As System.Windows.Forms.GroupBox
    Friend WithEvents lblContact As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpMission1 = New System.Windows.Forms.GroupBox()
        Me.lblMission1 = New System.Windows.Forms.Label()
        Me.grpMission2 = New System.Windows.Forms.GroupBox()
        Me.lblMission2 = New System.Windows.Forms.Label()
        Me.grpMission3 = New System.Windows.Forms.GroupBox()
        Me.lblMission3 = New System.Windows.Forms.Label()
        Me.grpProcess = New System.Windows.Forms.GroupBox()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.grpContact = New System.Windows.Forms.GroupBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.grpMission1.SuspendLayout()
        Me.grpMission2.SuspendLayout()
        Me.grpMission3.SuspendLayout()
        Me.grpProcess.SuspendLayout()
        Me.grpContact.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.lblBrand)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(904, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(760, 14)
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
        Me.lblBrand.Size = New System.Drawing.Size(155, 21)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "🐾 PAWHAVEN"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 75)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(469, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "About PawHaven Adoption Network"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(23, 115)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(569, 19)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "A community-first platform connecting rescued pets with verified adopters across the country."
        '
        'grpMission1
        '
        Me.grpMission1.BackColor = System.Drawing.Color.White
        Me.grpMission1.Controls.Add(Me.lblMission1)
        Me.grpMission1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpMission1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpMission1.Location = New System.Drawing.Point(27, 150)
        Me.grpMission1.Name = "grpMission1"
        Me.grpMission1.Size = New System.Drawing.Size(265, 140)
        Me.grpMission1.TabIndex = 3
        Me.grpMission1.TabStop = False
        Me.grpMission1.Text = "🏠 Safe Forever Homes"
        '
        'lblMission1
        '
        Me.lblMission1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMission1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMission1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblMission1.Location = New System.Drawing.Point(3, 21)
        Me.lblMission1.Name = "lblMission1"
        Me.lblMission1.Padding = New System.Windows.Forms.Padding(10)
        Me.lblMission1.Size = New System.Drawing.Size(259, 116)
        Me.lblMission1.TabIndex = 0
        Me.lblMission1.Text = "Every animal deserves a caring sanctuary. We verify applicant readiness and ensur" &
    "e transparent medical profiles before any pet is placed."
        '
        'grpMission2
        '
        Me.grpMission2.BackColor = System.Drawing.Color.White
        Me.grpMission2.Controls.Add(Me.lblMission2)
        Me.grpMission2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpMission2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpMission2.Location = New System.Drawing.Point(318, 150)
        Me.grpMission2.Name = "grpMission2"
        Me.grpMission2.Size = New System.Drawing.Size(265, 140)
        Me.grpMission2.TabIndex = 4
        Me.grpMission2.TabStop = False
        Me.grpMission2.Text = "🤝 Owner Rehoming Support"
        '
        'lblMission2
        '
        Me.lblMission2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMission2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMission2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblMission2.Location = New System.Drawing.Point(3, 21)
        Me.lblMission2.Name = "lblMission2"
        Me.lblMission2.Padding = New System.Windows.Forms.Padding(10)
        Me.lblMission2.Size = New System.Drawing.Size(259, 116)
        Me.lblMission2.TabIndex = 0
        Me.lblMission2.Text = "No judgment. If life circumstances change, we offer owners a dignified way to reg" &
    "ister companions with complete temperament and health histories."
        '
        'grpMission3
        '
        Me.grpMission3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMission3.BackColor = System.Drawing.Color.White
        Me.grpMission3.Controls.Add(Me.lblMission3)
        Me.grpMission3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpMission3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpMission3.Location = New System.Drawing.Point(608, 150)
        Me.grpMission3.Name = "grpMission3"
        Me.grpMission3.Size = New System.Drawing.Size(268, 140)
        Me.grpMission3.TabIndex = 5
        Me.grpMission3.TabStop = False
        Me.grpMission3.Text = "🌱 Community Driven"
        '
        'lblMission3
        '
        Me.lblMission3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMission3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMission3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblMission3.Location = New System.Drawing.Point(3, 21)
        Me.lblMission3.Name = "lblMission3"
        Me.lblMission3.Padding = New System.Windows.Forms.Padding(10)
        Me.lblMission3.Size = New System.Drawing.Size(262, 116)
        Me.lblMission3.TabIndex = 0
        Me.lblMission3.Text = "Powered by compassionate volunteers, fosters, local veterinary partners, and supp" &
    "orters dedicated to animal welfare across the region."
        '
        'grpProcess
        '
        Me.grpProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProcess.BackColor = System.Drawing.Color.White
        Me.grpProcess.Controls.Add(Me.lblProcess)
        Me.grpProcess.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpProcess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpProcess.Location = New System.Drawing.Point(27, 310)
        Me.grpProcess.Name = "grpProcess"
        Me.grpProcess.Size = New System.Drawing.Size(849, 140)
        Me.grpProcess.TabIndex = 6
        Me.grpProcess.TabStop = False
        Me.grpProcess.Text = "📋 How Adoption Works (3 Simple Steps)"
        '
        'lblProcess
        '
        Me.lblProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProcess.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblProcess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblProcess.Location = New System.Drawing.Point(3, 21)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.lblProcess.Size = New System.Drawing.Size(843, 116)
        Me.lblProcess.TabIndex = 0
        Me.lblProcess.Text = "1. BROWSE & APPLY: Discover dogs, cats, or small animals. Review temperament scores" &
    " and submit your adoption interest form." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. SHELTER COORDINATION: Our staff " &
    "evaluates your housing suitability and reviews vaccination schedules with current c" &
    "aregivers." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. MEET & WELCOME HOME: Schedule a safe meet-and-greet session to ens" &
    "ure a harmonious match, then finalize the adoption paperwork!"
        '
        'grpContact
        '
        Me.grpContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpContact.BackColor = System.Drawing.Color.White
        Me.grpContact.Controls.Add(Me.lblContact)
        Me.grpContact.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.grpContact.Location = New System.Drawing.Point(27, 465)
        Me.grpContact.Name = "grpContact"
        Me.grpContact.Size = New System.Drawing.Size(849, 100)
        Me.grpContact.TabIndex = 7
        Me.grpContact.TabStop = False
        Me.grpContact.Text = "📞 Contact & Shelter Location"
        '
        'lblContact
        '
        Me.lblContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(3, 21)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.lblContact.Size = New System.Drawing.Size(843, 76)
        Me.lblContact.TabIndex = 0
        Me.lblContact.Text = "📍 General Trias Shelter Center, Cavite, Philippines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "✉ Email: contact@pawhaven" &
    ".org   |   ☎ Hotline: (046) 431-7788   |   ⏰ Hours: Mon-Sat, 9:00 AM - 5:00 PM"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 590)
        Me.Controls.Add(Me.grpContact)
        Me.Controls.Add(Me.grpProcess)
        Me.Controls.Add(Me.grpMission3)
        Me.Controls.Add(Me.grpMission2)
        Me.Controls.Add(Me.grpMission1)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(750, 550)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PawHaven - About Us"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpMission1.ResumeLayout(False)
        Me.grpMission2.ResumeLayout(False)
        Me.grpMission3.ResumeLayout(False)
        Me.grpProcess.ResumeLayout(False)
        Me.grpContact.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

