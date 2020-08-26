Public Class frmStatus

    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)

        lblUser.Text = frmLock.FirstNameTextBox.Text & " " & frmLock.SurnameTextBox.Text
    End Sub
    Private Sub frmLock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.L Then 'F12 for Settings
            Lock()
        End If

        If e.KeyCode = Keys.F1 Then 'F1 for Help
            frmAboutBox.Show()
        End If

        If e.KeyCode = Keys.C Then 'C for Console
            frmAdminLogin.Show()
        End If

        If e.KeyCode = Keys.I Then 'i for User Information
            frmUserInformation.Show()
        End If

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

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.DoubleClick
        Lock()

    End Sub
    Private Sub Lock()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & frmLock.txtUsername.Text & "] Log Off"
        frmAdminLogin.Close()
        Me.Close()
        frmConsole.Close()
        frmAboutBox.Close()
        frmUserInformation.Close()
        frmExiting.Close()
        frmLock.Show()
        frmConsole.Show()
        frmConsole.TopMost = False
        frmConsole.Hide()
        frmLock.txtPassword.Focus()

    End Sub

    Private Sub lblUser_MouseHover(sender As Object, e As EventArgs) Handles lblUser.MouseHover
        Me.ToolTip1.SetToolTip(Me, "Double-Click to Lock" & vbCrLf & "Press i for User Information " & vbCrLf & "Press L to Lock" & vbCrLf & "Press C for Administrative Console")
    End Sub

    Private Sub frmStatusMouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.ToolTip1.SetToolTip(Me, "Double-Click to Lock" & vbCrLf & "Press i for User Information " & vbCrLf & "Press L to Lock" & vbCrLf & "Press C for Administrative Console")
    End Sub
End Class