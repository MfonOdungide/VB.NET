Public Class frmExiting

    Private Sub Exiting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Show()
        frmClassMonitor.TrayIcon.BalloonTipTitle = "ClassMonitor - Invasion Systems"
        frmClassMonitor.TrayIcon.BalloonTipText = "Exiting Application"
        frmClassMonitor.TrayIcon.ShowBalloonTip(1)

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ProgressBar.Increment(15)
        If ProgressBar.Value = ProgressBar.Maximum Then
            End
        ElseIf ProgressBar.Value >= 25 And ProgressBar.Value <= 40 Then
            lblInformation.Text = "Closing Connections..."
        ElseIf ProgressBar.Value >= 41 And ProgressBar.Value <= 75 Then
            lblInformation.Text = "Terminiating Services..."
        ElseIf ProgressBar.Value >= 76 And ProgressBar.Value <= 99 Then
            lblInformation.Text = "Exiting Application..."
        End If
    End Sub
End Class