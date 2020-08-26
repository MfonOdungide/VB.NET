<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkboxTopmost = New System.Windows.Forms.CheckBox()
        Me.chkboxMovable = New System.Windows.Forms.CheckBox()
        Me.bttnTopDock = New System.Windows.Forms.Button()
        Me.bttnUndock = New System.Windows.Forms.Button()
        Me.bttnApply = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.chkboxVisible = New System.Windows.Forms.CheckBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.bttnOk = New System.Windows.Forms.Button()
        Me.chkboxPlaySound = New System.Windows.Forms.CheckBox()
        Me.chkboxNotification = New System.Windows.Forms.CheckBox()
        Me.cboAction = New System.Windows.Forms.ComboBox()
        Me.btnDefaults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(71, 27)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(51, 20)
        Me.txtSeconds.TabIndex = 2
        Me.txtSeconds.Text = "00"
        Me.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.txtSeconds, "Seconds")
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(10, 27)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(51, 20)
        Me.txtMinutes.TabIndex = 1
        Me.txtMinutes.Text = "30"
        Me.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.txtMinutes, "Minutes")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(86, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SS"
        '
        'chkboxTopmost
        '
        Me.chkboxTopmost.AutoSize = True
        Me.chkboxTopmost.BackColor = System.Drawing.Color.Transparent
        Me.chkboxTopmost.Location = New System.Drawing.Point(10, 50)
        Me.chkboxTopmost.Name = "chkboxTopmost"
        Me.chkboxTopmost.Size = New System.Drawing.Size(68, 17)
        Me.chkboxTopmost.TabIndex = 3
        Me.chkboxTopmost.Text = "TopMost"
        Me.ToolTip.SetToolTip(Me.chkboxTopmost, "On Top of Other Windows")
        Me.chkboxTopmost.UseVisualStyleBackColor = False
        '
        'chkboxMovable
        '
        Me.chkboxMovable.AutoSize = True
        Me.chkboxMovable.BackColor = System.Drawing.Color.Transparent
        Me.chkboxMovable.Location = New System.Drawing.Point(10, 73)
        Me.chkboxMovable.Name = "chkboxMovable"
        Me.chkboxMovable.Size = New System.Drawing.Size(67, 17)
        Me.chkboxMovable.TabIndex = 4
        Me.chkboxMovable.Text = "Movable"
        Me.ToolTip.SetToolTip(Me.chkboxMovable, "Make Timer Movable")
        Me.chkboxMovable.UseVisualStyleBackColor = False
        '
        'bttnTopDock
        '
        Me.bttnTopDock.Location = New System.Drawing.Point(164, 13)
        Me.bttnTopDock.Name = "bttnTopDock"
        Me.bttnTopDock.Size = New System.Drawing.Size(100, 12)
        Me.bttnTopDock.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.bttnTopDock, "Dock to Top")
        Me.bttnTopDock.UseVisualStyleBackColor = True
        '
        'bttnUndock
        '
        Me.bttnUndock.Location = New System.Drawing.Point(164, 28)
        Me.bttnUndock.Name = "bttnUndock"
        Me.bttnUndock.Size = New System.Drawing.Size(100, 57)
        Me.bttnUndock.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.bttnUndock, "Undock from Top")
        Me.bttnUndock.UseVisualStyleBackColor = True
        '
        'bttnApply
        '
        Me.bttnApply.Location = New System.Drawing.Point(225, 116)
        Me.bttnApply.Name = "bttnApply"
        Me.bttnApply.Size = New System.Drawing.Size(61, 23)
        Me.bttnApply.TabIndex = 8
        Me.bttnApply.Text = "&Apply"
        Me.ToolTip.SetToolTip(Me.bttnApply, "Apply Settings")
        Me.bttnApply.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnCancel.Location = New System.Drawing.Point(170, 116)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(52, 23)
        Me.bttnCancel.TabIndex = 10
        Me.bttnCancel.Text = "&Cancel"
        Me.ToolTip.SetToolTip(Me.bttnCancel, "Cancel")
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'chkboxVisible
        '
        Me.chkboxVisible.AutoSize = True
        Me.chkboxVisible.BackColor = System.Drawing.Color.Transparent
        Me.chkboxVisible.Checked = True
        Me.chkboxVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxVisible.Location = New System.Drawing.Point(83, 50)
        Me.chkboxVisible.Name = "chkboxVisible"
        Me.chkboxVisible.Size = New System.Drawing.Size(56, 17)
        Me.chkboxVisible.TabIndex = 5
        Me.chkboxVisible.Text = "Visible"
        Me.ToolTip.SetToolTip(Me.chkboxVisible, "Set/Hide Timer")
        Me.chkboxVisible.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.Location = New System.Drawing.Point(270, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(18, 23)
        Me.cmdClose.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.cmdClose, "Close Window")
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.Color.Transparent
        Me.lblAction.Location = New System.Drawing.Point(132, 95)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(40, 13)
        Me.lblAction.TabIndex = 12
        Me.lblAction.Text = "Action:"
        Me.ToolTip.SetToolTip(Me.lblAction, "Select action on time elapsed")
        '
        'bttnOk
        '
        Me.bttnOk.Location = New System.Drawing.Point(103, 116)
        Me.bttnOk.Name = "bttnOk"
        Me.bttnOk.Size = New System.Drawing.Size(61, 23)
        Me.bttnOk.TabIndex = 9
        Me.bttnOk.Text = "&Ok"
        Me.bttnOk.UseVisualStyleBackColor = True
        '
        'chkboxPlaySound
        '
        Me.chkboxPlaySound.AutoSize = True
        Me.chkboxPlaySound.BackColor = System.Drawing.Color.Transparent
        Me.chkboxPlaySound.Checked = True
        Me.chkboxPlaySound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxPlaySound.Location = New System.Drawing.Point(83, 73)
        Me.chkboxPlaySound.Name = "chkboxPlaySound"
        Me.chkboxPlaySound.Size = New System.Drawing.Size(80, 17)
        Me.chkboxPlaySound.TabIndex = 3
        Me.chkboxPlaySound.Text = "Play Sound"
        Me.chkboxPlaySound.UseVisualStyleBackColor = False
        '
        'chkboxNotification
        '
        Me.chkboxNotification.AutoSize = True
        Me.chkboxNotification.BackColor = System.Drawing.Color.Transparent
        Me.chkboxNotification.Checked = True
        Me.chkboxNotification.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkboxNotification.Location = New System.Drawing.Point(10, 93)
        Me.chkboxNotification.Name = "chkboxNotification"
        Me.chkboxNotification.Size = New System.Drawing.Size(116, 17)
        Me.chkboxNotification.TabIndex = 3
        Me.chkboxNotification.Text = "Display Notification"
        Me.chkboxNotification.UseVisualStyleBackColor = False
        '
        'cboAction
        '
        Me.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAction.FormattingEnabled = True
        Me.cboAction.Items.AddRange(New Object() {"No Action", "Log Off User", "Lock System", "Sleep System", "Hibernate System", "Shutdown System", "Restart System"})
        Me.cboAction.Location = New System.Drawing.Point(178, 91)
        Me.cboAction.Name = "cboAction"
        Me.cboAction.Size = New System.Drawing.Size(108, 21)
        Me.cboAction.TabIndex = 11
        '
        'btnDefaults
        '
        Me.btnDefaults.AutoSize = True
        Me.btnDefaults.BackColor = System.Drawing.Color.Transparent
        Me.btnDefaults.Location = New System.Drawing.Point(13, 120)
        Me.btnDefaults.Name = "btnDefaults"
        Me.btnDefaults.Size = New System.Drawing.Size(46, 13)
        Me.btnDefaults.TabIndex = 12
        Me.btnDefaults.Text = "Defaults"
        '
        'frmSettings
        '
        Me.AcceptButton = Me.bttnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Class_Monitor.My.Resources.Resources.SettingBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.bttnCancel
        Me.ClientSize = New System.Drawing.Size(292, 154)
        Me.Controls.Add(Me.btnDefaults)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.cboAction)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnOk)
        Me.Controls.Add(Me.bttnApply)
        Me.Controls.Add(Me.bttnUndock)
        Me.Controls.Add(Me.bttnTopDock)
        Me.Controls.Add(Me.chkboxVisible)
        Me.Controls.Add(Me.chkboxMovable)
        Me.Controls.Add(Me.chkboxNotification)
        Me.Controls.Add(Me.chkboxPlaySound)
        Me.Controls.Add(Me.chkboxTopmost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.txtMinutes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "ClassMonitor Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkboxTopmost As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxMovable As System.Windows.Forms.CheckBox
    Friend WithEvents bttnTopDock As System.Windows.Forms.Button
    Friend WithEvents bttnUndock As System.Windows.Forms.Button
    Friend WithEvents bttnApply As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents chkboxVisible As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents cmdClose As System.Windows.Forms.Label
    Friend WithEvents bttnOk As System.Windows.Forms.Button
    Friend WithEvents chkboxPlaySound As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxNotification As System.Windows.Forms.CheckBox
    Friend WithEvents cboAction As System.Windows.Forms.ComboBox
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents btnDefaults As System.Windows.Forms.Label
End Class
