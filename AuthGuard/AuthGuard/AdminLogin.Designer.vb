<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminLogin))
        Me.grpboxLogin = New System.Windows.Forms.GroupBox()
        Me.bttnLogin = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.grpboxLogin.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpboxLogin
        '
        Me.grpboxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpboxLogin.Controls.Add(Me.bttnLogin)
        Me.grpboxLogin.Controls.Add(Me.PictureBox)
        Me.grpboxLogin.Controls.Add(Me.txtPassword)
        Me.grpboxLogin.Controls.Add(Me.txtUsername)
        Me.grpboxLogin.Location = New System.Drawing.Point(3, -2)
        Me.grpboxLogin.Name = "grpboxLogin"
        Me.grpboxLogin.Size = New System.Drawing.Size(474, 332)
        Me.grpboxLogin.TabIndex = 2
        Me.grpboxLogin.TabStop = False
        '
        'bttnLogin
        '
        Me.bttnLogin.Location = New System.Drawing.Point(171, 274)
        Me.bttnLogin.Name = "bttnLogin"
        Me.bttnLogin.Size = New System.Drawing.Size(148, 37)
        Me.bttnLogin.TabIndex = 2
        Me.bttnLogin.Text = "&Login"
        Me.bttnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.AuthGuard.My.Resources.Resources.halo_shield
        Me.PictureBox.Location = New System.Drawing.Point(171, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(148, 149)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(105, 225)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(274, 43)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(105, 176)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(274, 43)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "Administrator"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmAdminLogin
        '
        Me.AcceptButton = Me.bttnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 333)
        Me.Controls.Add(Me.grpboxLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administator Login"
        Me.TopMost = True
        Me.grpboxLogin.ResumeLayout(False)
        Me.grpboxLogin.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpboxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents bttnLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
End Class
