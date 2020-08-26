Public Class frmClosing


    Private Sub TmrExit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        ProgressBar.Increment(15)
        

        If ProgressBar.Value = ProgressBar.Maximum Then
            'lblVerboseMessage.Text = "Logging Off User..."
            End
        ElseIf ProgressBar.Value >= 25 And ProgressBar.Value <= 40 Then
            lblVerboseMessage.Text = "Closing Connections..."
            'frmSettings.Close()
        ElseIf ProgressBar.Value >= 41 And ProgressBar.Value <= 75 Then
            lblVerboseMessage.Text = "Terminating Services..."
            ' frmLog.Close()
            ' frmTimer.Close()
            'frmProcess.Close()
        ElseIf ProgressBar.Value >= 76 And ProgressBar.Value <= 99 Then
            lblVerboseMessage.Text = "Exiting Application..."
            End
        End If
    End Sub

    Private Sub Exiting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar.Show()
        frmTimer.TrayIcon.BalloonTipText = "Exiting Application"
        frmTimer.TrayIcon.ShowBalloonTip(1)
    End Sub

End Class