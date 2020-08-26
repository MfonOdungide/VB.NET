<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassMonitor))
        Me.lblUpTime = New System.Windows.Forms.Label()
        Me.lblUsedTime = New System.Windows.Forms.Label()
        Me.seconds_label = New System.Windows.Forms.Label()
        Me.minutes_label = New System.Windows.Forms.Label()
        Me.hours_label = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.DownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ArmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkboxVisible = New System.Windows.Forms.CheckBox()
        Me.chkboxMovable = New System.Windows.Forms.CheckBox()
        Me.chkboxTopmost = New System.Windows.Forms.CheckBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAction = New System.Windows.Forms.Label()
        Me.chkboxNotification = New System.Windows.Forms.CheckBox()
        Me.chkboxPlaySound = New System.Windows.Forms.CheckBox()
        Me.lblHH = New System.Windows.Forms.Label()
        Me.lblMM = New System.Windows.Forms.Label()
        Me.lblSS = New System.Windows.Forms.Label()
        Me.UpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Blink = New System.Windows.Forms.Timer(Me.components)
        Me.ClassMonitorCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenu.SuspendLayout()
        Me.ClassMonitorCMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUpTime
        '
        Me.lblUpTime.BackColor = System.Drawing.Color.Transparent
        Me.lblUpTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpTime.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpTime.ForeColor = System.Drawing.Color.Black
        Me.lblUpTime.Location = New System.Drawing.Point(12, 6)
        Me.lblUpTime.Name = "lblUpTime"
        Me.lblUpTime.Size = New System.Drawing.Size(144, 23)
        Me.lblUpTime.TabIndex = 9
        Me.lblUpTime.Text = "00 : 00"
        Me.lblUpTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lblUpTime, "Elapsed Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to Pause/Stop")
        '
        'lblUsedTime
        '
        Me.lblUsedTime.BackColor = System.Drawing.Color.Transparent
        Me.lblUsedTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsedTime.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsedTime.ForeColor = System.Drawing.Color.Black
        Me.lblUsedTime.Location = New System.Drawing.Point(168, 6)
        Me.lblUsedTime.Name = "lblUsedTime"
        Me.lblUsedTime.Size = New System.Drawing.Size(144, 23)
        Me.lblUsedTime.TabIndex = 10
        Me.lblUsedTime.Text = "00 : 00"
        Me.lblUsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lblUsedTime, "Remaining Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to Start/Pause")
        '
        'seconds_label
        '
        Me.seconds_label.BackColor = System.Drawing.Color.Transparent
        Me.seconds_label.ForeColor = System.Drawing.Color.Black
        Me.seconds_label.Location = New System.Drawing.Point(136, 60)
        Me.seconds_label.Name = "seconds_label"
        Me.seconds_label.Size = New System.Drawing.Size(51, 23)
        Me.seconds_label.TabIndex = 6
        Me.seconds_label.Text = "Label1"
        Me.seconds_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutes_label
        '
        Me.minutes_label.BackColor = System.Drawing.Color.Transparent
        Me.minutes_label.ForeColor = System.Drawing.Color.Black
        Me.minutes_label.Location = New System.Drawing.Point(79, 60)
        Me.minutes_label.Name = "minutes_label"
        Me.minutes_label.Size = New System.Drawing.Size(51, 23)
        Me.minutes_label.TabIndex = 7
        Me.minutes_label.Text = "Label1"
        Me.minutes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hours_label
        '
        Me.hours_label.BackColor = System.Drawing.Color.Transparent
        Me.hours_label.ForeColor = System.Drawing.Color.Black
        Me.hours_label.Location = New System.Drawing.Point(22, 60)
        Me.hours_label.Name = "hours_label"
        Me.hours_label.Size = New System.Drawing.Size(51, 23)
        Me.hours_label.TabIndex = 8
        Me.hours_label.Text = "Label1"
        Me.hours_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSeconds
        '
        Me.txtSeconds.BackColor = System.Drawing.Color.Black
        Me.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSeconds.ForeColor = System.Drawing.Color.Transparent
        Me.txtSeconds.Location = New System.Drawing.Point(245, 65)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(51, 13)
        Me.txtSeconds.TabIndex = 3
        Me.txtSeconds.Text = "00"
        '
        'txtMinutes
        '
        Me.txtMinutes.BackColor = System.Drawing.Color.Black
        Me.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMinutes.ForeColor = System.Drawing.Color.Transparent
        Me.txtMinutes.Location = New System.Drawing.Point(188, 65)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(51, 13)
        Me.txtMinutes.TabIndex = 4
        Me.txtMinutes.Text = "30"
        '
        'DownTimer
        '
        Me.DownTimer.Interval = 1000
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Invasion Systems Class Monitor"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArmToolStripMenuItem1, Me.DisarmToolStripMenuItem, Me.HideToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(139, 114)
        '
        'ArmToolStripMenuItem1
        '
        Me.ArmToolStripMenuItem1.Name = "ArmToolStripMenuItem1"
        Me.ArmToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ArmToolStripMenuItem1.Text = "&Arm"
        '
        'DisarmToolStripMenuItem
        '
        Me.DisarmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PauseToolStripMenuItem1, Me.StopToolStripMenuItem1, Me.ResetToolStripMenuItem})
        Me.DisarmToolStripMenuItem.Name = "DisarmToolStripMenuItem"
        Me.DisarmToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DisarmToolStripMenuItem.Text = "&Disarm"
        '
        'PauseToolStripMenuItem1
        '
        Me.PauseToolStripMenuItem1.Name = "PauseToolStripMenuItem1"
        Me.PauseToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.PauseToolStripMenuItem1.Text = "&Pause"
        '
        'StopToolStripMenuItem1
        '
        Me.StopToolStripMenuItem1.Name = "StopToolStripMenuItem1"
        Me.StopToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.StopToolStripMenuItem1.Text = "&Stop"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.HideToolStripMenuItem.Text = "&Hide/Visible"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EXITToolStripMenuItem.Text = "&Exit"
        '
        'chkboxVisible
        '
        Me.chkboxVisible.AutoSize = True
        Me.chkboxVisible.BackColor = System.Drawing.Color.Transparent
        Me.chkboxVisible.Location = New System.Drawing.Point(172, 86)
        Me.chkboxVisible.Name = "chkboxVisible"
        Me.chkboxVisible.Size = New System.Drawing.Size(56, 17)
        Me.chkboxVisible.TabIndex = 13
        Me.chkboxVisible.Text = "Visible"
        Me.chkboxVisible.UseVisualStyleBackColor = False
        '
        'chkboxMovable
        '
        Me.chkboxMovable.AutoSize = True
        Me.chkboxMovable.BackColor = System.Drawing.Color.Transparent
        Me.chkboxMovable.Location = New System.Drawing.Point(99, 86)
        Me.chkboxMovable.Name = "chkboxMovable"
        Me.chkboxMovable.Size = New System.Drawing.Size(67, 17)
        Me.chkboxMovable.TabIndex = 12
        Me.chkboxMovable.Text = "Movable"
        Me.chkboxMovable.UseVisualStyleBackColor = False
        '
        'chkboxTopmost
        '
        Me.chkboxTopmost.AutoSize = True
        Me.chkboxTopmost.BackColor = System.Drawing.Color.Transparent
        Me.chkboxTopmost.Checked = True
        Me.chkboxTopmost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxTopmost.Location = New System.Drawing.Point(25, 86)
        Me.chkboxTopmost.Name = "chkboxTopmost"
        Me.chkboxTopmost.Size = New System.Drawing.Size(68, 17)
        Me.chkboxTopmost.TabIndex = 11
        Me.chkboxTopmost.Text = "TopMost"
        Me.chkboxTopmost.UseVisualStyleBackColor = False
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.Color.Transparent
        Me.lblAction.Location = New System.Drawing.Point(235, 86)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(13, 13)
        Me.lblAction.TabIndex = 14
        Me.lblAction.Text = "0"
        '
        'chkboxNotification
        '
        Me.chkboxNotification.AutoSize = True
        Me.chkboxNotification.BackColor = System.Drawing.Color.Transparent
        Me.chkboxNotification.Checked = True
        Me.chkboxNotification.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxNotification.Location = New System.Drawing.Point(99, 109)
        Me.chkboxNotification.Name = "chkboxNotification"
        Me.chkboxNotification.Size = New System.Drawing.Size(116, 17)
        Me.chkboxNotification.TabIndex = 15
        Me.chkboxNotification.Text = "Display Notification"
        Me.chkboxNotification.UseVisualStyleBackColor = False
        '
        'chkboxPlaySound
        '
        Me.chkboxPlaySound.AutoSize = True
        Me.chkboxPlaySound.BackColor = System.Drawing.Color.Transparent
        Me.chkboxPlaySound.Checked = True
        Me.chkboxPlaySound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxPlaySound.Location = New System.Drawing.Point(25, 109)
        Me.chkboxPlaySound.Name = "chkboxPlaySound"
        Me.chkboxPlaySound.Size = New System.Drawing.Size(80, 17)
        Me.chkboxPlaySound.TabIndex = 16
        Me.chkboxPlaySound.Text = "Play Sound"
        Me.chkboxPlaySound.UseVisualStyleBackColor = False
        '
        'lblHH
        '
        Me.lblHH.BackColor = System.Drawing.Color.Transparent
        Me.lblHH.ForeColor = System.Drawing.Color.Black
        Me.lblHH.Location = New System.Drawing.Point(22, 48)
        Me.lblHH.Name = "lblHH"
        Me.lblHH.Size = New System.Drawing.Size(51, 23)
        Me.lblHH.TabIndex = 8
        Me.lblHH.Text = "Label1"
        Me.lblHH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMM
        '
        Me.lblMM.BackColor = System.Drawing.Color.Transparent
        Me.lblMM.ForeColor = System.Drawing.Color.Black
        Me.lblMM.Location = New System.Drawing.Point(79, 48)
        Me.lblMM.Name = "lblMM"
        Me.lblMM.Size = New System.Drawing.Size(51, 23)
        Me.lblMM.TabIndex = 7
        Me.lblMM.Text = "00"
        Me.lblMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSS
        '
        Me.lblSS.BackColor = System.Drawing.Color.Transparent
        Me.lblSS.ForeColor = System.Drawing.Color.Black
        Me.lblSS.Location = New System.Drawing.Point(136, 48)
        Me.lblSS.Name = "lblSS"
        Me.lblSS.Size = New System.Drawing.Size(51, 23)
        Me.lblSS.TabIndex = 6
        Me.lblSS.Text = "00"
        Me.lblSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpTimer
        '
        Me.UpTimer.Interval = 1000
        '
        'Blink
        '
        Me.Blink.Interval = 1000
        '
        'ClassMonitorCMenu
        '
        Me.ClassMonitorCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem1})
        Me.ClassMonitorCMenu.Name = "ClassMonitorCMenu"
        Me.ClassMonitorCMenu.Size = New System.Drawing.Size(153, 48)
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'frmClassMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Class_Monitor.My.Resources.Resources.Banner1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(323, 35)
        Me.ContextMenuStrip = Me.ClassMonitorCMenu
        Me.Controls.Add(Me.chkboxNotification)
        Me.Controls.Add(Me.chkboxPlaySound)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.chkboxVisible)
        Me.Controls.Add(Me.chkboxMovable)
        Me.Controls.Add(Me.chkboxTopmost)
        Me.Controls.Add(Me.lblUpTime)
        Me.Controls.Add(Me.lblUsedTime)
        Me.Controls.Add(Me.seconds_label)
        Me.Controls.Add(Me.minutes_label)
        Me.Controls.Add(Me.hours_label)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.lblSS)
        Me.Controls.Add(Me.lblMM)
        Me.Controls.Add(Me.lblHH)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClassMonitor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invasion Systems Class Monitor"
        Me.ToolTip.SetToolTip(Me, "Click on the Timer to Start/Pause")
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.TrayMenu.ResumeLayout(False)
        Me.ClassMonitorCMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUpTime As System.Windows.Forms.Label
    Friend WithEvents lblUsedTime As System.Windows.Forms.Label
    Friend WithEvents seconds_label As System.Windows.Forms.Label
    Friend WithEvents minutes_label As System.Windows.Forms.Label
    Friend WithEvents hours_label As System.Windows.Forms.Label
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents DownTimer As System.Windows.Forms.Timer
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DisarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkboxVisible As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxMovable As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxTopmost As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents chkboxNotification As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxPlaySound As System.Windows.Forms.CheckBox
    Friend WithEvents ArmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHH As System.Windows.Forms.Label
    Friend WithEvents lblMM As System.Windows.Forms.Label
    Friend WithEvents lblSS As System.Windows.Forms.Label
    Friend WithEvents UpTimer As System.Windows.Forms.Timer
    Friend WithEvents Blink As System.Windows.Forms.Timer
    Friend WithEvents ClassMonitorCMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
