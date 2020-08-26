<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.bttnViewAssessment = New System.Windows.Forms.Button()
        Me.bttnAddRecord = New System.Windows.Forms.Button()
        Me.bttnPrint = New System.Windows.Forms.Button()
        Me.bttnEditAssessment = New System.Windows.Forms.Button()
        Me.bttnViewRecord = New System.Windows.Forms.Button()
        Me.bttnSettings = New System.Windows.Forms.Button()
        Me.bttnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip_Home = New System.Windows.Forms.ToolTip(Me.components)
        Me.bttnInfo = New System.Windows.Forms.Button()
        Me.bttnLogOff = New System.Windows.Forms.Button()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayIconMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreMainApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrayIconMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttnViewAssessment
        '
        Me.bttnViewAssessment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnViewAssessment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnViewAssessment.Image = CType(resources.GetObject("bttnViewAssessment.Image"), System.Drawing.Image)
        Me.bttnViewAssessment.Location = New System.Drawing.Point(145, 58)
        Me.bttnViewAssessment.Name = "bttnViewAssessment"
        Me.bttnViewAssessment.Size = New System.Drawing.Size(56, 56)
        Me.bttnViewAssessment.TabIndex = 2
        Me.ToolTip_Home.SetToolTip(Me.bttnViewAssessment, "View Class Assessmenet Record")
        Me.bttnViewAssessment.UseVisualStyleBackColor = True
        '
        'bttnAddRecord
        '
        Me.bttnAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnAddRecord.Image = CType(resources.GetObject("bttnAddRecord.Image"), System.Drawing.Image)
        Me.bttnAddRecord.Location = New System.Drawing.Point(61, 124)
        Me.bttnAddRecord.Name = "bttnAddRecord"
        Me.bttnAddRecord.Size = New System.Drawing.Size(56, 56)
        Me.bttnAddRecord.TabIndex = 1
        Me.ToolTip_Home.SetToolTip(Me.bttnAddRecord, "Add Student's Record")
        Me.bttnAddRecord.UseVisualStyleBackColor = True
        '
        'bttnPrint
        '
        Me.bttnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnPrint.Image = CType(resources.GetObject("bttnPrint.Image"), System.Drawing.Image)
        Me.bttnPrint.Location = New System.Drawing.Point(81, 244)
        Me.bttnPrint.Name = "bttnPrint"
        Me.bttnPrint.Size = New System.Drawing.Size(56, 56)
        Me.bttnPrint.TabIndex = 4
        Me.ToolTip_Home.SetToolTip(Me.bttnPrint, "Print Reports and Records")
        Me.bttnPrint.UseVisualStyleBackColor = True
        '
        'bttnEditAssessment
        '
        Me.bttnEditAssessment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnEditAssessment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnEditAssessment.Image = CType(resources.GetObject("bttnEditAssessment.Image"), System.Drawing.Image)
        Me.bttnEditAssessment.Location = New System.Drawing.Point(227, 124)
        Me.bttnEditAssessment.Name = "bttnEditAssessment"
        Me.bttnEditAssessment.Size = New System.Drawing.Size(56, 56)
        Me.bttnEditAssessment.TabIndex = 3
        Me.ToolTip_Home.SetToolTip(Me.bttnEditAssessment, "Add Student's Continous Assessment")
        Me.bttnEditAssessment.UseVisualStyleBackColor = True
        '
        'bttnViewRecord
        '
        Me.bttnViewRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnViewRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnViewRecord.Image = CType(resources.GetObject("bttnViewRecord.Image"), System.Drawing.Image)
        Me.bttnViewRecord.Location = New System.Drawing.Point(206, 244)
        Me.bttnViewRecord.Name = "bttnViewRecord"
        Me.bttnViewRecord.Size = New System.Drawing.Size(56, 56)
        Me.bttnViewRecord.TabIndex = 5
        Me.ToolTip_Home.SetToolTip(Me.bttnViewRecord, "View and Search Student Records")
        Me.bttnViewRecord.UseVisualStyleBackColor = True
        '
        'bttnSettings
        '
        Me.bttnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnSettings.Image = Global.Invasion_Systems_e_Registration_Portal.My.Resources.Resources.Settings
        Me.bttnSettings.Location = New System.Drawing.Point(12, 408)
        Me.bttnSettings.Name = "bttnSettings"
        Me.bttnSettings.Size = New System.Drawing.Size(56, 56)
        Me.bttnSettings.TabIndex = 6
        Me.ToolTip_Home.SetToolTip(Me.bttnSettings, "Access Portal Settings")
        Me.bttnSettings.UseVisualStyleBackColor = True
        '
        'bttnExit
        '
        Me.bttnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnExit.Image = CType(resources.GetObject("bttnExit.Image"), System.Drawing.Image)
        Me.bttnExit.Location = New System.Drawing.Point(279, 408)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(56, 56)
        Me.bttnExit.TabIndex = 9
        Me.ToolTip_Home.SetToolTip(Me.bttnExit, "Exit Portal")
        Me.bttnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(110, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 130)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'bttnInfo
        '
        Me.bttnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnInfo.Image = Global.Invasion_Systems_e_Registration_Portal.My.Resources.Resources.Information
        Me.bttnInfo.Location = New System.Drawing.Point(74, 408)
        Me.bttnInfo.Name = "bttnInfo"
        Me.bttnInfo.Size = New System.Drawing.Size(56, 56)
        Me.bttnInfo.TabIndex = 7
        Me.ToolTip_Home.SetToolTip(Me.bttnInfo, "Access Information Screen")
        Me.bttnInfo.UseVisualStyleBackColor = True
        '
        'bttnLogOff
        '
        Me.bttnLogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bttnLogOff.Image = Global.Invasion_Systems_e_Registration_Portal.My.Resources.Resources.lockdownh
        Me.bttnLogOff.Location = New System.Drawing.Point(299, 346)
        Me.bttnLogOff.Name = "bttnLogOff"
        Me.bttnLogOff.Size = New System.Drawing.Size(36, 37)
        Me.bttnLogOff.TabIndex = 8
        Me.ToolTip_Home.SetToolTip(Me.bttnLogOff, "Log Off Current User")
        Me.bttnLogOff.UseVisualStyleBackColor = True
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TrayIcon.BalloonTipText = "Invasion Systems e-Registration Portal"
        Me.TrayIcon.BalloonTipTitle = "Invasion Systems e-Registration Portal"
        Me.TrayIcon.ContextMenuStrip = Me.TrayIconMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Invasion Systems e-Registration Portal"
        Me.TrayIcon.Visible = True
        '
        'TrayIconMenu
        '
        Me.TrayIconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HToolStripMenuItem, Me.RestoreMainApplicationToolStripMenuItem, Me.LogOffUserToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.TrayIconMenu.Name = "ContextMenuStrip1"
        Me.TrayIconMenu.Size = New System.Drawing.Size(208, 92)
        '
        'HToolStripMenuItem
        '
        Me.HToolStripMenuItem.Name = "HToolStripMenuItem"
        Me.HToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.HToolStripMenuItem.Text = "Hide Main Application"
        '
        'RestoreMainApplicationToolStripMenuItem
        '
        Me.RestoreMainApplicationToolStripMenuItem.Name = "RestoreMainApplicationToolStripMenuItem"
        Me.RestoreMainApplicationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.RestoreMainApplicationToolStripMenuItem.Text = "Restore Main Application"
        '
        'LogOffUserToolStripMenuItem
        '
        Me.LogOffUserToolStripMenuItem.Name = "LogOffUserToolStripMenuItem"
        Me.LogOffUserToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.LogOffUserToolStripMenuItem.Text = "LogOff User"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Invasion_Systems_e_Registration_Portal.My.Resources.Resources.Wallpaper
        Me.ClientSize = New System.Drawing.Size(347, 502)
        Me.Controls.Add(Me.bttnLogOff)
        Me.Controls.Add(Me.bttnInfo)
        Me.Controls.Add(Me.bttnPrint)
        Me.Controls.Add(Me.bttnViewRecord)
        Me.Controls.Add(Me.bttnEditAssessment)
        Me.Controls.Add(Me.bttnAddRecord)
        Me.Controls.Add(Me.bttnViewAssessment)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bttnExit)
        Me.Controls.Add(Me.bttnSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrayIconMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnViewAssessment As System.Windows.Forms.Button
    Friend WithEvents bttnAddRecord As System.Windows.Forms.Button
    Friend WithEvents bttnPrint As System.Windows.Forms.Button
    Friend WithEvents bttnEditAssessment As System.Windows.Forms.Button
    Friend WithEvents bttnViewRecord As System.Windows.Forms.Button
    Friend WithEvents bttnSettings As System.Windows.Forms.Button
    Friend WithEvents bttnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip_Home As System.Windows.Forms.ToolTip
    Friend WithEvents bttnInfo As System.Windows.Forms.Button
    Friend WithEvents bttnLogOff As System.Windows.Forms.Button
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayIconMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestoreMainApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
