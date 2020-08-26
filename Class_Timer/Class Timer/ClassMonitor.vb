Imports System.Media
Public Class frmClassMonitor
    Dim Point As New System.Drawing.Point()
    Dim A, B As Integer

    Private Sub frmClassMonitor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F9 Then 'F12 for Mute
            StopSounds()
            Shell("shutdown -a")
        End If
        If e.KeyCode = Keys.F12 Then 'F12 for Settings
            frmSettings.Show()
        End If
        If e.KeyCode = Keys.F1 Then 'F1 for Help
            frmAboutBox.Show()
        End If
    End Sub
    Private Sub StopSounds()
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblAction.Text = 0 Then
            Me.TrayIcon.Visible = True
            Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
            TrayIcon.BalloonTipText = "Application Running"
            Me.TrayIcon.ShowBalloonTip(1)
        End If
        Call CenterForm(Me)
        chkboxVisible.CheckState = CheckState.Checked
        CheckDownTimer()
        KeyPreview = True
        minutes_label.Text = txtMinutes.Text
        seconds_label.Text = txtSeconds.Text
    End Sub
    Private Sub CheckDownTimer()
        If DownTimer.Enabled = False Then
            DisarmToolStripMenuItem.Enabled = False
            ArmToolStripMenuItem1.Enabled = True
        ElseIf DownTimer.Enabled = True Then
            DisarmToolStripMenuItem.Enabled = True
            ArmToolStripMenuItem1.Enabled = False
        End If
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles DownTimer.Tick
        DownTimer.Interval = 1000
        If hours_label.Text = "" Then
            hours_label.Text = "0"
        End If
        If minutes_label.Text = "" Then
            minutes_label.Text = "0"
        End If
        If seconds_label.Text = "" Then
            seconds_label.Text = "0"
        End If
        If hours_label.Text = "00" Then
            hours_label.Text = "0"
        End If
        If minutes_label.Text = "00" Then
            minutes_label.Text = "0"
        End If
        If seconds_label.Text = "00" Then
            seconds_label.Text = "0"
        End If
        If seconds_label.Text > "0" Then
            seconds_label.Text = seconds_label.Text - 1
        End If
        If minutes_label.Text > "0" Then
            If seconds_label.Text = "0" Then
                minutes_label.Text = minutes_label.Text - 1
                seconds_label.Text = "59"
            End If
        End If

        'Warning event
        DisplayNotification()
        PlaySounds()

        'Timeout event
        If Val(seconds_label.Text) = 0 And Val(minutes_label.Text) = 0 And Val(hours_label.Text) = 0 Then
            Action()
            DownTimer.Enabled = False
            DisplayNotification()
            PlaySounds()

        End If


        If minutes_label.Text <= 9 And seconds_label.Text <= 9 Then
            lblUsedTime.Text = "0" & minutes_label.Text & " : " & "0" & seconds_label.Text
        End If
        If minutes_label.Text <= 9 And seconds_label.Text >= 10 Then
            lblUsedTime.Text = "0" & minutes_label.Text & " : " & seconds_label.Text
        End If
        If minutes_label.Text >= 10 And seconds_label.Text <= 9 Then
            lblUsedTime.Text = minutes_label.Text & " : " & "0" & seconds_label.Text
        End If
        If minutes_label.Text >= 10 And seconds_label.Text >= 10 Then
            lblUsedTime.Text = minutes_label.Text & " : " & seconds_label.Text
        End If
        CheckDownTimer()
    End Sub
    Private Sub DisplayNotification()
        If chkboxNotification.CheckState = CheckState.Checked Then
            If Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 5 And Val(seconds_label.Text) = 1 Then
                frmNotification.Show()
                frmNotification.lblInformation.Text = "You have less than 5 Minutes Remainig"
                frmNotification.lblInformation.ForeColor = Color.Red
                Blink.Enabled = True
                BlinkTime()
            ElseIf Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 0 And Val(seconds_label.Text) = 0 Then
                frmNotification.Show()
                frmNotification.lblInformation.Text = "Class Dismissed"
                frmNotification.lblInformation.ForeColor = Color.Red
                Blink.Enabled = True
            End If

        Else
            If Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 5 And Val(seconds_label.Text) = 1 Then
                Me.TrayIcon.Visible = True
                TrayIcon.BalloonTipText = "You have less than 5 Minutes Remainig"
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                Me.TrayIcon.ShowBalloonTip(1)
            ElseIf Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 0 And Val(seconds_label.Text) = 0 Then
                Me.TrayIcon.Visible = True
                TrayIcon.BalloonTipText = "Class Dismissed"
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                Me.TrayIcon.ShowBalloonTip(1)
            End If
            'Display no Notification
        End If
    End Sub

    Private Sub PlaySounds()
        If chkboxPlaySound.CheckState = CheckState.Checked Then
            If Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 5 And Val(seconds_label.Text) = 1 Then
                My.Computer.Audio.Play(My.Resources.Warning, AudioPlayMode.Background)
            ElseIf Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 0 And Val(seconds_label.Text) = 0 Then
                My.Computer.Audio.Play(My.Resources.TimeUp, AudioPlayMode.BackgroundLoop)
            End If

        Else
            'Play No sound
        End If
    End Sub

    Private Sub lblUsedTime_Click(sender As Object, e As EventArgs) Handles lblUsedTime.Click
        If DownTimer.Enabled = True Then
            DownTimer.Enabled = False
        Else
            DownTimer.Enabled = True
        End If
        UpTimer.Enabled = True
    End Sub
    Private Sub lblUsedTime_DoubleClick(sender As Object, e As EventArgs) Handles lblUsedTime.DoubleClick
        'Stop Sounds
        My.Computer.Audio.Stop() 'Stop background playing sounds
        Blink.Enabled = False
        frmNotification.Close()
        Reset()
    End Sub
    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        Dim R As Rectangle
        If parent IsNot Nothing Then
            R = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            R = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = R.Left + (R.Width - frm.Width) / 2
        Dim y = R.Top + (R.Height - frm.Height / 2)
        frm.Location = New Point(x, 0)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.Show()
    End Sub

    Private Sub chkboxTopmost_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxTopmost.CheckedChanged
        If chkboxTopmost.CheckState = CheckState.Checked Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub chkboxMovable_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxMovable.CheckedChanged
        If chkboxMovable.CheckState = CheckState.Checked Then

        Else

        End If
    End Sub

    Private Sub Form_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If chkboxMovable.CheckState = CheckState.Checked Then

            If e.Button = MouseButtons.Left Then
                Point = Control.MousePosition
                Point.X = Point.X - (A)
                Point.Y = Point.Y - (B)
                Me.Location = Point
            End If
        Else
            'do nothing = not movable
        End If
    End Sub

    Private Sub Form_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If chkboxMovable.CheckState = CheckState.Checked Then
            A = Control.MousePosition.X - Me.Location.X
            B = Control.MousePosition.Y - Me.Location.Y
        Else
            'do nothing = not movable
        End If

    End Sub

    Private Sub txtMinutes_TextChanged(sender As Object, e As EventArgs) Handles txtMinutes.TextChanged, txtSeconds.TextChanged
        If DownTimer.Enabled = True Then
            DownTimer.Enabled = False
            minutes_label.Text = txtMinutes.Text
            seconds_label.Text = txtSeconds.Text
            DownTimer.Enabled = True
        Else
            DownTimer.Enabled = False
            minutes_label.Text = txtMinutes.Text
            seconds_label.Text = txtSeconds.Text
        End If

    End Sub

    Private Sub TrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If Me.Visible = False Then
            chkboxVisible.CheckState = CheckState.Checked
        ElseIf Me.Visible = True Then
            chkboxVisible.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub chkboxVisble_checkedChanged(sender As Object, e As EventArgs) Handles chkboxVisible.CheckedChanged
        If chkboxVisible.CheckState = CheckState.Unchecked Then
            Me.Hide()
        ElseIf chkboxVisible.CheckState = CheckState.Checked Then
            Me.Show()
        End If
    End Sub

    Private Sub PauseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem1.Click
        DownTimer.Enabled = False
    End Sub

    Private Sub StopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem1.Click
        DownTimer.Enabled = False
    End Sub

    Private Sub Reset()
        If DownTimer.Enabled = True Then
            DownTimer.Enabled = False
            minutes_label.Text = txtMinutes.Text
            seconds_label.Text = txtSeconds.Text
            'DownTimer.Enabled = True
        Else
            DownTimer.Enabled = False
            minutes_label.Text = txtMinutes.Text
            seconds_label.Text = txtSeconds.Text
        End If
        StopSounds()
        frmNotification.Close()
        Shell("shutdown -a")
    End Sub
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Reset()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        frmExiting.Show()
    End Sub

    Private Sub minutes_label_textchanged(sender As Object, e As EventArgs) Handles minutes_label.TextChanged, seconds_label.TextChanged, lblSS.TextChanged, lblMM.TextChanged
        lblUsedTime.Text = minutes_label.Text & " : " & seconds_label.Text
    End Sub
    Private Sub Action()
        Dim Action As Integer
        Action = lblAction.Text
        Select Case Action
            Case 0
                'no action
                System.Diagnostics.Process.Start("shutdown", "-a") ' Aborts current shutdown procedure
                Shell("shutdown -a")
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Aborting Actions..."
                Me.TrayIcon.ShowBalloonTip(1)


            Case 1
                'log off user
                System.Diagnostics.Process.Start("shutdown", "-l -t 10")
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Logging Off User...'"
                Me.TrayIcon.ShowBalloonTip(1)

            Case 3
                'Sleep System
                MsgBox("This Machine cannot be put to sleep at the moment")
            Case 4
                'Hibernate System
                System.Diagnostics.Process.Start("shutdown", "-h -t 10")
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Hibernating System..."
                Me.TrayIcon.ShowBalloonTip(1)

            Case 5
                'Shutdown System 
                System.Diagnostics.Process.Start("shutdown", "-s -t 10")
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Shutting Down System..."
                Me.TrayIcon.ShowBalloonTip(1)

            Case 6
                'Restart System
                System.Diagnostics.Process.Start("shutdown", "-r -t 10")
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Restarting System..."
                Me.TrayIcon.ShowBalloonTip(1)

            Case 2
                'Lock System
                MsgBox("Cannot Lock current workstation at the moment")

        End Select
    End Sub
    Private Sub lblAction_textchanged(sender As Object, e As EventArgs) Handles lblAction.TextChanged
        Dim Action As Integer
        Action = lblAction.Text
        Select Case Action
            Case 0
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Aborting Actions..."
                Me.TrayIcon.ShowBalloonTip(1)


            Case 1
                'log off user
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Preferred Action Set to 'Logoff User'"
                Me.TrayIcon.ShowBalloonTip(1)

            Case 3
                'Sleep System
                MsgBox("This Machine cannot be put to sleep at the moment")
            Case 4
                'Hibernate System
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Preferred Action Set to 'Hibernate System'"
                Me.TrayIcon.ShowBalloonTip(1)

            Case 5
                'Shutdown System 
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Preferred Action Set to 'Shutdown System'"
                Me.TrayIcon.ShowBalloonTip(1)

            Case 6
                'Restart System
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
                TrayIcon.BalloonTipText = "Preferred Action Set to 'Restart System'"
                Me.TrayIcon.ShowBalloonTip(1)

            Case 2
                'Lock System
                MsgBox("Cannot Lock current workstation at the moment")

        End Select
    End Sub

    Private Sub ArmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArmToolStripMenuItem1.Click
        DownTimer.Enabled = True
    End Sub

    Private Sub UpTimer_Tick(sender As Object, e As EventArgs) Handles UpTimer.Tick
        lblSS.Text = lblSS.Text + 1
        If lblMM.Text = "00" Then
            lblMM.Text = "0"
        End If

        If lblSS.Text = "60" Then
            lblMM.Text = lblMM.Text + 1
            lblSS.Text = "0"
        End If

        If lblMM.Text <= 9 And lblSS.Text <= 9 Then
            lblUpTime.Text = "0" & lblMM.Text & " : " & "0" & lblSS.Text
        End If
        If lblMM.Text <= 9 And lblSS.Text >= 10 Then
            lblUpTime.Text = "0" & lblMM.Text & " : " & lblSS.Text
        End If
        If lblMM.Text >= 10 And lblSS.Text <= 9 Then
            lblUpTime.Text = lblMM.Text & " : " & "0" & lblSS.Text
        End If
        If lblMM.Text >= 10 And lblSS.Text >= 10 Then
            lblUpTime.Text = lblMM.Text & " : " & lblSS.Text
        End If
    End Sub

    Private Sub lblUpTime_Click(sender As Object, e As EventArgs) Handles lblUpTime.Click
        If UpTimer.Enabled = True Then
            UpTimer.Enabled = False
        Else
            UpTimer.Enabled = True
        End If

    End Sub
    Private Sub lblUpTime_DoubleClick(sender As Object, e As EventArgs) Handles lblUpTime.DoubleClick
        If UpTimer.Enabled = True Then
            UpTimer.Enabled = False
            lblHH.Text = "00"
            lblSS.Text = "00"
            lblUpTime.Text = "00 : 00"
        End If
        If UpTimer.Enabled = False Then
            lblHH.Text = "00"
            lblSS.Text = "00"
            lblUpTime.Text = "00 : 00"
            UpTimer.Enabled = True
        End If
    End Sub

    Private Sub Blink_Tick(sender As Object, e As EventArgs) Handles Blink.Tick
        If frmNotification.lblInformation.Visible = True Then
            frmNotification.lblInformation.Visible = False
        Else
            frmNotification.lblInformation.Visible = True
        End If
        BlinkTime()
    End Sub

    Private Sub BlinkTime()
        If Val(seconds_label.Text) = 55 And Val(minutes_label.Text) = 4 Then 'Blinking the control for 5 Seconds
            Blink.Enabled = False
            frmNotification.Close()
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        frmSettings.Show()
    End Sub
End Class
