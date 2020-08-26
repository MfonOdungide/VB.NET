Public Class frmTimer

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_button.Click
        Label1.Visible = True

        If Seconds_textbox.Text = "00" Then
            If minutes_textbox.Text = "00" Then
                If hours_textbox.Text = "00" Then
                    Start_pause.Enabled = False
                    MsgBox("Please enter a value heigher then 0")
                End If
            End If
        End If
        If Seconds_textbox.Text = "0" Then
            If minutes_textbox.Text = "0" Then
                If hours_textbox.Text = "0" Then
                    Start_pause.Enabled = False
                    MsgBox("Please enter a value heigher then 0")

                End If
            End If
        End If
        If Seconds_textbox.Text = "" Then
            minutes_textbox.Text = ""
            hours_textbox.Text = ""
            Start_pause.Enabled = False
            MsgBox("Please enter a value")

        End If
        ok_button.Enabled = True
        hours_label.Text = hours_textbox.Text
        minutes_label.Text = minutes_textbox.Text
        seconds_label.Text = Seconds_textbox.Text
        If hours_label.Text > "0" Then
            Start_pause.Enabled = True
        End If
        If minutes_label.Text > "0" Then
            Start_pause.Enabled = True
        End If
        If seconds_label.Text > "0" Then
            Start_pause.Enabled = True
        End If
    End Sub

    Private Sub Start_pause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_pause.Click
        If Start_pause.Text = "Start" Then
            Timer1.Enabled = True
            ok_button.Enabled = False
            Start_pause.Text = "Pause"
            Start_pause.Enabled = False
        ElseIf Start_pause.Text = "Pause" Then
            Timer1.Enabled = False
            Restart.Enabled = True
            ok_button.Enabled = True
            Start_pause.Text = "Start"
            Start_pause.Enabled = Enabled
        End If

        Label1.Visible = True
    End Sub

    Private Sub Restart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart.Click
        hours_label.Text = hours_textbox.Text
        minutes_label.Text = minutes_textbox.Text
        seconds_label.Text = Seconds_textbox.Text
        Start_pause.Text = "Start"
        Start_pause.Enabled = True
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        Me.TrayIcon.Text = "Timer - Invasion Systems [" & hours_label.Text & " : " & minutes_label.Text & " : " & seconds_label.Text & "]"
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
        If hours_label.Text > "0" Then
            If minutes_label.Text = "0" Then
                If seconds_label.Text = "0" Then
                    hours_label.Text = hours_label.Text - 1
                    minutes_label.Text = "59"
                    seconds_label.Text = "59"
                End If
            End If
        End If

        If seconds_label.Text = "0" Then
            If minutes_label.Text = "0" Then
                If hours_label.Text = "0" Then
                    Timer1.Enabled = False
                    frmTime_Up.Show()
                    'MsgBox("Time is up")
                    Me.Hide()
                    Start_pause.Text = "Start"
                    Restart.Enabled = False
                End If
            End If
        End If


    End Sub

    Private Sub Timer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        e.Cancel = True
        Me.Hide()

        Me.TrayIcon.BalloonTipText = "Minimized to Tray"
        Me.TrayIcon.ShowBalloonTip(1)
    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Me.ok_button.PerformClick()
        KeyPreview = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Visible = False

    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick

    End Sub
    Private Sub Timer_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            Call Me.Restart.PerformClick()
        End If

        If e.KeyCode = Keys.F11 Then
            'Enable Pause
            If Start_pause.Text = "Pause" Then
                If Start_pause.Enabled = True Then
                    Start_pause.Enabled = False
                ElseIf Start_pause.Enabled = False Then
                    Start_pause.Enabled = True
                End If

            End If
        End If
        If e.KeyCode = Keys.F1 Then
            frmHelp.Show()
        End If
        If e.KeyCode = Keys.F10 Then
            'Enable Pause

            If Label1.Visible = False Then
                Label1.Visible = True
            Else
                Label1.Visible = False
            End If

        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        frmClosing.Show()
    End Sub

    Private Sub TrayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        Me.Show()
    End Sub

End Class
