<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCongratulations
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
        Dim txtUsername As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCongratulations))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblSecurityAnswer = New System.Windows.Forms.Label()
        Me.lblSecurityQuestion = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.bttnGoToMenu = New System.Windows.Forms.Button()
        txtUsername = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        txtUsername.AutoSize = True
        txtUsername.Location = New System.Drawing.Point(8, 29)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New System.Drawing.Size(58, 13)
        txtUsername.TabIndex = 10
        txtUsername.Text = "Username:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(8, 77)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(93, 13)
        Label2.TabIndex = 10
        Label2.Text = "Security Question:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(8, 101)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(83, 13)
        Label4.TabIndex = 10
        Label4.Text = "Security Answer"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(8, 53)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(49, 13)
        Label6.TabIndex = 10
        Label6.Text = "Program:"
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(18, 99)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(312, 59)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblProgram)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.lblSecurityAnswer)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.lblSecurityQuestion)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(txtUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Details"
        '
        'lblProgram
        '
        Me.lblProgram.Location = New System.Drawing.Point(76, 52)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(219, 20)
        Me.lblProgram.TabIndex = 11
        '
        'lblSecurityAnswer
        '
        Me.lblSecurityAnswer.Location = New System.Drawing.Point(107, 98)
        Me.lblSecurityAnswer.Name = "lblSecurityAnswer"
        Me.lblSecurityAnswer.Size = New System.Drawing.Size(188, 20)
        Me.lblSecurityAnswer.TabIndex = 11
        '
        'lblSecurityQuestion
        '
        Me.lblSecurityQuestion.Location = New System.Drawing.Point(107, 75)
        Me.lblSecurityQuestion.Name = "lblSecurityQuestion"
        Me.lblSecurityQuestion.Size = New System.Drawing.Size(188, 20)
        Me.lblSecurityQuestion.TabIndex = 11
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(76, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(219, 20)
        Me.lblUsername.TabIndex = 11
        '
        'picBanner
        '
        Me.picBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.picBanner.Image = Global.EIE_eLearning.My.Resources.Resources.eLearning
        Me.picBanner.Location = New System.Drawing.Point(0, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(342, 87)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner.TabIndex = 2
        Me.picBanner.TabStop = False
        '
        'bttnGoToMenu
        '
        Me.bttnGoToMenu.Location = New System.Drawing.Point(213, 320)
        Me.bttnGoToMenu.Name = "bttnGoToMenu"
        Me.bttnGoToMenu.Size = New System.Drawing.Size(111, 23)
        Me.bttnGoToMenu.TabIndex = 3
        Me.bttnGoToMenu.Text = "Preceed to Menu"
        Me.bttnGoToMenu.UseVisualStyleBackColor = True
        '
        'frmCongratulations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 355)
        Me.Controls.Add(Me.bttnGoToMenu)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCongratulations"
        Me.Text = "Registration Confirmation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lblSecurityAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSecurityQuestion As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents bttnGoToMenu As System.Windows.Forms.Button
End Class
