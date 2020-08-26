<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimer))
        Me.hours_label = New System.Windows.Forms.Label()
        Me.minutes_label = New System.Windows.Forms.Label()
        Me.seconds_label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Restart = New System.Windows.Forms.Button()
        Me.Start_pause = New System.Windows.Forms.Button()
        Me.hours_textbox = New System.Windows.Forms.TextBox()
        Me.minutes_textbox = New System.Windows.Forms.TextBox()
        Me.Seconds_textbox = New System.Windows.Forms.TextBox()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hours_label
        '
        Me.hours_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hours_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hours_label.Location = New System.Drawing.Point(38, 23)
        Me.hours_label.Name = "hours_label"
        Me.hours_label.Size = New System.Drawing.Size(112, 67)
        Me.hours_label.TabIndex = 0
        Me.hours_label.Text = "00"
        Me.hours_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutes_label
        '
        Me.minutes_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.minutes_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes_label.Location = New System.Drawing.Point(156, 23)
        Me.minutes_label.Name = "minutes_label"
        Me.minutes_label.Size = New System.Drawing.Size(112, 67)
        Me.minutes_label.TabIndex = 0
        Me.minutes_label.Text = "00"
        Me.minutes_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'seconds_label
        '
        Me.seconds_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seconds_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seconds_label.Location = New System.Drawing.Point(274, 23)
        Me.seconds_label.Name = "seconds_label"
        Me.seconds_label.Size = New System.Drawing.Size(112, 67)
        Me.seconds_label.TabIndex = 0
        Me.seconds_label.Text = "00"
        Me.seconds_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Restart)
        Me.GroupBox1.Controls.Add(Me.Start_pause)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 131)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operations"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 48)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ".."
        '
        'Restart
        '
        Me.Restart.Location = New System.Drawing.Point(113, 76)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(163, 49)
        Me.Restart.TabIndex = 0
        Me.Restart.TabStop = False
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'Start_pause
        '
        Me.Start_pause.Location = New System.Drawing.Point(113, 20)
        Me.Start_pause.Name = "Start_pause"
        Me.Start_pause.Size = New System.Drawing.Size(163, 49)
        Me.Start_pause.TabIndex = 0
        Me.Start_pause.Text = "Start"
        Me.Start_pause.UseVisualStyleBackColor = True
        '
        'hours_textbox
        '
        Me.hours_textbox.Location = New System.Drawing.Point(45, 273)
        Me.hours_textbox.Name = "hours_textbox"
        Me.hours_textbox.Size = New System.Drawing.Size(67, 20)
        Me.hours_textbox.TabIndex = 2
        Me.hours_textbox.Text = "02"
        '
        'minutes_textbox
        '
        Me.minutes_textbox.Location = New System.Drawing.Point(125, 273)
        Me.minutes_textbox.Name = "minutes_textbox"
        Me.minutes_textbox.Size = New System.Drawing.Size(67, 20)
        Me.minutes_textbox.TabIndex = 2
        Me.minutes_textbox.Text = "00"
        '
        'Seconds_textbox
        '
        Me.Seconds_textbox.Location = New System.Drawing.Point(210, 273)
        Me.Seconds_textbox.Name = "Seconds_textbox"
        Me.Seconds_textbox.Size = New System.Drawing.Size(67, 20)
        Me.Seconds_textbox.TabIndex = 2
        Me.Seconds_textbox.Text = "00"
        '
        'ok_button
        '
        Me.ok_button.Location = New System.Drawing.Point(293, 273)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(75, 23)
        Me.ok_button.TabIndex = 3
        Me.ok_button.Text = "Ok"
        Me.ok_button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 77)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = ".."
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TrayIcon.BalloonTipText = "Timer - Invasion Systems"
        Me.TrayIcon.BalloonTipTitle = "Timer - Invasion Systems"
        Me.TrayIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Timer - Invasion Systems"
        Me.TrayIcon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
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
        'frmTimer
        '
        Me.AcceptButton = Me.Start_pause
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 371)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ok_button)
        Me.Controls.Add(Me.Seconds_textbox)
        Me.Controls.Add(Me.minutes_textbox)
        Me.Controls.Add(Me.hours_textbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.seconds_label)
        Me.Controls.Add(Me.minutes_label)
        Me.Controls.Add(Me.hours_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimer"
        Me.Text = "Timer - Invasion Systems"
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hours_label As System.Windows.Forms.Label
    Friend WithEvents minutes_label As System.Windows.Forms.Label
    Friend WithEvents seconds_label As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Restart As System.Windows.Forms.Button
    Friend WithEvents Start_pause As System.Windows.Forms.Button
    Friend WithEvents hours_textbox As System.Windows.Forms.TextBox
    Friend WithEvents minutes_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Seconds_textbox As System.Windows.Forms.TextBox
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
