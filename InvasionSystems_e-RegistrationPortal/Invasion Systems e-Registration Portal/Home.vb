Public Class frmHome

    Private Sub bttnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAddRecord.Click
        Me.Hide()
        frmNewRegistration.Show()
        'Me.TrayIcon.BalloonTipText = "Minimized to Tray"
        'Me.TrayIcon.ShowBalloonTip(1)

    End Sub

    Private Sub bttnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnExit.Click
        Me.Close()
    End Sub

    Private Sub bttnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSettings.Click
        frmSettings.Show()
        Me.Enabled = False


    End Sub

    Private Sub bttnViewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnViewRecord.Click
        Me.Hide()
        frmViewRegistration.Show()
        Me.TrayIcon.BalloonTipText = "Minimized to Tray"
        Me.TrayIcon.ShowBalloonTip(1)

    End Sub

    Private Sub TrayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        Me.Show()
        Me.TrayIcon.BalloonTipText = "Application Restored"
        Me.TrayIcon.ShowBalloonTip(1)
    End Sub

    
    Private Sub HToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HToolStripMenuItem.Click
        Me.Hide()
        Me.TrayIcon.BalloonTipText = "Minimized to Tray"
        Me.TrayIcon.ShowBalloonTip(1)

    End Sub

    Private Sub RestoreMainApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreMainApplicationToolStripMenuItem.Click
        Me.Show()
        Me.TrayIcon.BalloonTipText = "Application Restored"
        Me.TrayIcon.ShowBalloonTip(1)
    End Sub

    Private Sub bttnEditAssessment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEditAssessment.Click

    End Sub
End Class