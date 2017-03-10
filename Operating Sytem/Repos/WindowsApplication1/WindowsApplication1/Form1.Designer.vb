<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.BtnExit = New ns1.BunifuImageButton()
        Me.BtnBRMenu = New ns1.BunifuImageButton()
        Me.PnlBRMenu = New System.Windows.Forms.Panel()
        Me.BRMenuAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BtnLoginMenu = New ns1.BunifuImageButton()
        Me.PnlLogin = New System.Windows.Forms.Panel()
        Me.PnlLoginPrompt = New System.Windows.Forms.Panel()
        Me.BtnLogin = New ns1.BunifuFlatButton()
        Me.TxtPassword = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.LblPassword = New ns1.BunifuCustomLabel()
        Me.LblUsername = New ns1.BunifuCustomLabel()
        Me.TxtUsername = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.PnlLoginAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PnlHeader.SuspendLayout()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBRMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBRMenu.SuspendLayout()
        CType(Me.BtnLoginMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLogin.SuspendLayout()
        Me.PnlLoginPrompt.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PnlHeader.Controls.Add(Me.BtnExit)
        Me.PnlLoginAnimator.SetDecoration(Me.PnlHeader, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.PnlHeader, BunifuAnimatorNS.DecorationType.None)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(1920, 49)
        Me.PnlHeader.TabIndex = 0
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PnlLoginAnimator.SetDecoration(Me.BtnExit, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.BtnExit, BunifuAnimatorNS.DecorationType.None)
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageActive = Nothing
        Me.BtnExit.Location = New System.Drawing.Point(1878, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(30, 30)
        Me.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.TabStop = False
        Me.BtnExit.Zoom = 10
        '
        'BtnBRMenu
        '
        Me.BtnBRMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBRMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlLoginAnimator.SetDecoration(Me.BtnBRMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.BtnBRMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnBRMenu.Image = CType(resources.GetObject("BtnBRMenu.Image"), System.Drawing.Image)
        Me.BtnBRMenu.ImageActive = Nothing
        Me.BtnBRMenu.Location = New System.Drawing.Point(14, 13)
        Me.BtnBRMenu.Name = "BtnBRMenu"
        Me.BtnBRMenu.Size = New System.Drawing.Size(32, 32)
        Me.BtnBRMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnBRMenu.TabIndex = 1
        Me.BtnBRMenu.TabStop = False
        Me.BtnBRMenu.Zoom = 10
        '
        'PnlBRMenu
        '
        Me.PnlBRMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBRMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlBRMenu.Controls.Add(Me.BtnBRMenu)
        Me.PnlLoginAnimator.SetDecoration(Me.PnlBRMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.PnlBRMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PnlBRMenu.Location = New System.Drawing.Point(1863, 49)
        Me.PnlBRMenu.Name = "PnlBRMenu"
        Me.PnlBRMenu.Size = New System.Drawing.Size(57, 55)
        Me.PnlBRMenu.TabIndex = 2
        '
        'BRMenuAnimator
        '
        Me.BRMenuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BRMenuAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.BRMenuAnimator.DefaultAnimation = Animation2
        '
        'BtnLoginMenu
        '
        Me.BtnLoginMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoginMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PnlLoginAnimator.SetDecoration(Me.BtnLoginMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.BtnLoginMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnLoginMenu.Image = CType(resources.GetObject("BtnLoginMenu.Image"), System.Drawing.Image)
        Me.BtnLoginMenu.ImageActive = Nothing
        Me.BtnLoginMenu.Location = New System.Drawing.Point(37, 15)
        Me.BtnLoginMenu.Name = "BtnLoginMenu"
        Me.BtnLoginMenu.Size = New System.Drawing.Size(250, 250)
        Me.BtnLoginMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLoginMenu.TabIndex = 3
        Me.BtnLoginMenu.TabStop = False
        Me.BtnLoginMenu.Zoom = 10
        '
        'PnlLogin
        '
        Me.PnlLogin.Controls.Add(Me.BtnLoginMenu)
        Me.PnlLoginAnimator.SetDecoration(Me.PnlLogin, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.PnlLogin, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLogin.Location = New System.Drawing.Point(798, 400)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.Size = New System.Drawing.Size(324, 280)
        Me.PnlLogin.TabIndex = 4
        '
        'PnlLoginPrompt
        '
        Me.PnlLoginPrompt.Controls.Add(Me.BtnLogin)
        Me.PnlLoginPrompt.Controls.Add(Me.TxtPassword)
        Me.PnlLoginPrompt.Controls.Add(Me.LblPassword)
        Me.PnlLoginPrompt.Controls.Add(Me.LblUsername)
        Me.PnlLoginPrompt.Controls.Add(Me.TxtUsername)
        Me.PnlLoginAnimator.SetDecoration(Me.PnlLoginPrompt, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.PnlLoginPrompt, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLoginPrompt.Location = New System.Drawing.Point(826, 686)
        Me.PnlLoginPrompt.Name = "PnlLoginPrompt"
        Me.PnlLoginPrompt.Size = New System.Drawing.Size(286, 204)
        Me.PnlLoginPrompt.TabIndex = 5
        '
        'BtnLogin
        '
        Me.BtnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogin.BorderRadius = 0
        Me.BtnLogin.ButtonText = "Login"
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlLoginAnimator.SetDecoration(Me.BtnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.BRMenuAnimator.SetDecoration(Me.BtnLogin, BunifuAnimatorNS.DecorationType.None)
        Me.BtnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.BtnLogin.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnLogin.Iconimage = Nothing
        Me.BtnLogin.Iconimage_right = Nothing
        Me.BtnLogin.Iconimage_right_Selected = Nothing
        Me.BtnLogin.Iconimage_Selected = Nothing
        Me.BtnLogin.IconMarginLeft = 0
        Me.BtnLogin.IconMarginRight = 0
        Me.BtnLogin.IconRightVisible = True
        Me.BtnLogin.IconRightZoom = 0R
        Me.BtnLogin.IconVisible = True
        Me.BtnLogin.IconZoom = 90.0R
        Me.BtnLogin.IsTab = False
        Me.BtnLogin.Location = New System.Drawing.Point(77, 151)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnLogin.selected = False
        Me.BtnLogin.Size = New System.Drawing.Size(140, 33)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnLogin.Textcolor = System.Drawing.Color.White
        Me.BtnLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderColor = System.Drawing.Color.SeaGreen
        Me.BRMenuAnimator.SetDecoration(Me.TxtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLoginAnimator.SetDecoration(Me.TxtPassword, BunifuAnimatorNS.DecorationType.None)
        Me.TxtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(133, 105)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(134, 27)
        Me.TxtPassword.TabIndex = 4
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.BRMenuAnimator.SetDecoration(Me.LblPassword, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLoginAnimator.SetDecoration(Me.LblPassword, BunifuAnimatorNS.DecorationType.None)
        Me.LblPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(11, 108)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(104, 24)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.BRMenuAnimator.SetDecoration(Me.LblUsername, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLoginAnimator.SetDecoration(Me.LblUsername, BunifuAnimatorNS.DecorationType.None)
        Me.LblUsername.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(11, 36)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(113, 24)
        Me.LblUsername.TabIndex = 2
        Me.LblUsername.Text = "Username"
        '
        'TxtUsername
        '
        Me.TxtUsername.BorderColor = System.Drawing.Color.SeaGreen
        Me.BRMenuAnimator.SetDecoration(Me.TxtUsername, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLoginAnimator.SetDecoration(Me.TxtUsername, BunifuAnimatorNS.DecorationType.None)
        Me.TxtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(133, 33)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(134, 27)
        Me.TxtUsername.TabIndex = 0
        '
        'PnlLoginAnimator
        '
        Me.PnlLoginAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.PnlLoginAnimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.PnlLoginAnimator.DefaultAnimation = Animation1
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.PnlLoginPrompt)
        Me.Controls.Add(Me.PnlLogin)
        Me.Controls.Add(Me.PnlBRMenu)
        Me.Controls.Add(Me.PnlHeader)
        Me.BRMenuAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PnlLoginAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Text = "Form1"
        Me.PnlHeader.ResumeLayout(False)
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBRMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBRMenu.ResumeLayout(False)
        CType(Me.BtnLoginMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLoginPrompt.ResumeLayout(False)
        Me.PnlLoginPrompt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents BtnExit As ns1.BunifuImageButton
    Friend WithEvents BtnBRMenu As ns1.BunifuImageButton
    Friend WithEvents PnlBRMenu As Panel
    Friend WithEvents BRMenuAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BtnLoginMenu As ns1.BunifuImageButton
    Friend WithEvents PnlLogin As Panel
    Friend WithEvents PnlLoginAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PnlLoginPrompt As Panel
    Friend WithEvents LblPassword As ns1.BunifuCustomLabel
    Friend WithEvents LblUsername As ns1.BunifuCustomLabel
    Friend WithEvents TxtUsername As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents TxtPassword As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BtnLogin As ns1.BunifuFlatButton
End Class
