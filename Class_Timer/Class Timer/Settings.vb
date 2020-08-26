Public Class frmSettings
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub bttnApply_Click(sender As Object, e As EventArgs) Handles bttnApply.Click, bttnOk.Click
        'Checking for Movable Checkbox
        If chkboxMovable.CheckState = CheckState.Checked Then
            frmClassMonitor.chkboxMovable.CheckState = CheckState.Checked
        Else
            frmClassMonitor.chkboxMovable.CheckState = CheckState.Unchecked
        End If
        'Checking for Topmost Checkbox  
        If chkboxTopmost.CheckState = CheckState.Checked Then
            frmClassMonitor.chkboxTopmost.CheckState = CheckState.Checked
        Else
            frmClassMonitor.chkboxTopmost.CheckState = CheckState.Unchecked
        End If
        'Checking for Visible Checkbox
        If chkboxVisible.CheckState = CheckState.Checked Then
            frmClassMonitor.chkboxVisible.CheckState = CheckState.Checked
        Else
            frmClassMonitor.chkboxVisible.CheckState = CheckState.Unchecked
        End If
        'checking for Notification
        If chkboxNotification.CheckState = CheckState.Checked Then
            frmClassMonitor.chkboxNotification.CheckState = CheckState.Checked
        Else
            frmClassMonitor.chkboxNotification.CheckState = CheckState.Unchecked
        End If
        'checking for sounds
        If chkboxPlaySound.CheckState = CheckState.Checked Then
            frmClassMonitor.chkboxPlaySound.CheckState = CheckState.Checked
        Else
            frmClassMonitor.chkboxPlaySound.CheckState = CheckState.Unchecked
        End If
        frmClassMonitor.txtMinutes.Text = txtMinutes.Text
        frmClassMonitor.txtSeconds.Text = txtSeconds.Text

        'Action
        frmClassMonitor.lblAction.Text = cboAction.SelectedIndex
    End Sub

    Private Sub bttnCancel_Click(sender As Object, e As EventArgs) Handles bttnCancel.Click, bttnOk.Click
        Me.Hide()
    End Sub

    Private Sub RestoreDefaults()
        chkboxMovable.CheckState = CheckState.Unchecked
        chkboxTopmost.CheckState = CheckState.Checked
        chkboxVisible.CheckState = CheckState.Checked
        chkboxNotification.CheckState = CheckState.Checked
        chkboxPlaySound.CheckState = CheckState.Checked
        cboAction.SelectedIndex = 0
        txtMinutes.Text = "30"
        txtSeconds.Text = "00"
    End Sub

    Private Sub bttnTopDock_Click(sender As Object, e As EventArgs) Handles bttnTopDock.Click
        Call frmClassMonitor.CenterForm(frmClassMonitor)
    End Sub

    Private Sub bttnUndock_Click(sender As Object, e As EventArgs) Handles bttnUndock.Click
        chkboxMovable.CheckState = CheckState.Checked
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAction.SelectedIndex = Val(lblAction.Text)
        chkboxTopmost.CheckState = frmClassMonitor.chkboxTopmost.CheckState
        chkboxVisible.CheckState = frmClassMonitor.chkboxVisible.CheckState
        chkboxPlaySound.CheckState = frmClassMonitor.chkboxPlaysound.CheckState
        chkboxNotification.CheckState = frmClassMonitor.chkboxNotification.CheckState
        chkboxMovable.CheckState = frmClassMonitor.chkboxMovable.CheckState
    End Sub

    Private Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnDefaults.Click
        RestoreDefaults()
    End Sub

    Private Sub Form_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Point = Control.MousePosition
            Point.X = Point.X - (X)
            Point.Y = Point.Y - (Y)
            Me.Location = Point
        End If
    End Sub

    Private Sub Form_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

End Class