Public Class frmExiting


    Private Sub Exiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Show()
        frmLock.TrayIcon.BalloonTipTitle = "AuthGuard - Invasion Systems"
        frmLock.TrayIcon.BalloonTipText = "Exiting Application"
        frmLock.TrayIcon.ShowBalloonTip(1)

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ProgressBar.Increment(15)
        If ProgressBar.Value = ProgressBar.Maximum Then
            End
        ElseIf ProgressBar.Value >= 25 And ProgressBar.Value <= 40 Then
            frmConsole.bttnDisableGuard.PerformClick()
            lblInformation.Text = "Disabling Protection..."
        ElseIf ProgressBar.Value >= 41 And ProgressBar.Value <= 75 Then
            lblInformation.Text = "Terminiating Services..."
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Program Termination Sequence Initiated...! "
            frmAdminLogin.Close()
            frmStatus.Close()
            frmConsole.Close()
            frmAboutBox.Close()
            frmUserInformation.Close()
            frmLock.Close()
        ElseIf ProgressBar.Value >= 76 And ProgressBar.Value <= 99 Then
            lblInformation.Text = "Exiting Application..."
        End If
    End Sub
End Class