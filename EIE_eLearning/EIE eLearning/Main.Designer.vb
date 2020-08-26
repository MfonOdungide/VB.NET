<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdViewProgress = New System.Windows.Forms.PictureBox()
        Me.cmdLogout = New System.Windows.Forms.PictureBox()
        Me.cmdViewCatalog = New System.Windows.Forms.PictureBox()
        Me.ToolTipMenu = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdViewAccount = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrayMenu.SuspendLayout()
        CType(Me.cmdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdViewProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdViewCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdViewAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Text = "TrayIcon"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TrayMenu.Name = "ContextMenuStrip1"
        Me.TrayMenu.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(156, -56)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 50)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Button1"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-4, -70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Transparent
        Me.cmdSearch.BackgroundImage = CType(resources.GetObject("cmdSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSearch.Location = New System.Drawing.Point(173, 29)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(96, 88)
        Me.cmdSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cmdSearch.TabIndex = 5
        Me.cmdSearch.TabStop = False
        Me.ToolTipMenu.SetToolTip(Me.cmdSearch, "Search Database")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-140, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 52)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-107, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 52)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "SEARCH"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmdViewProgress
        '
        Me.cmdViewProgress.BackColor = System.Drawing.Color.Transparent
        Me.cmdViewProgress.BackgroundImage = CType(resources.GetObject("cmdViewProgress.BackgroundImage"), System.Drawing.Image)
        Me.cmdViewProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdViewProgress.Location = New System.Drawing.Point(317, 151)
        Me.cmdViewProgress.Name = "cmdViewProgress"
        Me.cmdViewProgress.Size = New System.Drawing.Size(96, 88)
        Me.cmdViewProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cmdViewProgress.TabIndex = 5
        Me.cmdViewProgress.TabStop = False
        Me.ToolTipMenu.SetToolTip(Me.cmdViewProgress, "View Progress Report")
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogout.BackgroundImage = CType(resources.GetObject("cmdLogout.BackgroundImage"), System.Drawing.Image)
        Me.cmdLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdLogout.Location = New System.Drawing.Point(259, 293)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(96, 88)
        Me.cmdLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cmdLogout.TabIndex = 5
        Me.cmdLogout.TabStop = False
        Me.ToolTipMenu.SetToolTip(Me.cmdLogout, "Logout")
        '
        'cmdViewCatalog
        '
        Me.cmdViewCatalog.BackColor = System.Drawing.Color.Transparent
        Me.cmdViewCatalog.BackgroundImage = CType(resources.GetObject("cmdViewCatalog.BackgroundImage"), System.Drawing.Image)
        Me.cmdViewCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdViewCatalog.Location = New System.Drawing.Point(25, 132)
        Me.cmdViewCatalog.Name = "cmdViewCatalog"
        Me.cmdViewCatalog.Size = New System.Drawing.Size(96, 88)
        Me.cmdViewCatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cmdViewCatalog.TabIndex = 5
        Me.cmdViewCatalog.TabStop = False
        Me.ToolTipMenu.SetToolTip(Me.cmdViewCatalog, "View Completem Catalog")
        '
        'cmdViewAccount
        '
        Me.cmdViewAccount.BackColor = System.Drawing.Color.Transparent
        Me.cmdViewAccount.BackgroundImage = Global.EIE_eLearning.My.Resources.Resources.account_leave
        Me.cmdViewAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdViewAccount.Location = New System.Drawing.Point(75, 293)
        Me.cmdViewAccount.Name = "cmdViewAccount"
        Me.cmdViewAccount.Size = New System.Drawing.Size(96, 88)
        Me.cmdViewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cmdViewAccount.TabIndex = 5
        Me.cmdViewAccount.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(305, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 442)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdViewAccount)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.cmdViewCatalog)
        Me.Controls.Add(Me.cmdViewProgress)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.TrayMenu.ResumeLayout(False)
        CType(Me.cmdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdViewProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdViewCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdViewAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmdViewProgress As System.Windows.Forms.PictureBox
    Friend WithEvents cmdLogout As System.Windows.Forms.PictureBox
    Friend WithEvents cmdViewCatalog As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTipMenu As System.Windows.Forms.ToolTip
    Friend WithEvents cmdViewAccount As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
