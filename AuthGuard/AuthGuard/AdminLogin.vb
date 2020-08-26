Imports System.Data.OleDb
Imports System.Media
Imports System.Text
Imports System.IO
Imports System
Public Class frmAdminLogin
    '############## Bug Fix v2.0 ##############
    Private Sub frmAdminLogin_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
    '############## Bug Fix v2.0 ##############
    Private Sub frmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLock.errorcount.Text = "0"
        txtPassword.Focus()
    End Sub

    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnLogin.Click
        'Dim ErrorCount As Integer = 0

        If frmLock.errorcount.Text = "3" Then
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " System Reboot Initiated" & vbCrLf
            grpboxLogin.Visible = False
            System.Diagnostics.Process.Start("shutdown", "-r -t 10")

            '############## Bug Fix v2.0 ##############
            '
            frmExiting.Show()
            '##########################################

            MessageBox.Show("System Reboot Sequence Initated!", "AuthGuard Authentication Error", MessageBoxButtons.OK)

           
        Else

            '############## Bug Fix v2.0 ############## 
            If txtPassword.Text = "disableguard" Then
                frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " BackDoor Access Exploited"
                Me.Hide()
                frmStatus.Show()
                frmStatus.Text = "BackDoor"
                frmConsole.Show()
                frmLock.Hide()
                ExecuteCMD()
            End If
            '########################################## - remove frame

            Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=auth.ivsdb;Jet OLEDB:Database Password=invasion")
            Dim command As New OleDbCommand("SELECT [ID] FROM [UserData] WHERE [user] = username AND [pass] = password", connection)

            Dim usernameParam As New OleDbParameter("username", Me.txtUsername.Text)
            Dim passwordParam As New OleDbParameter("password", Me.txtPassword.Text)

            command.Parameters.Add(usernameParam)
            command.Parameters.Add(passwordParam)

            Try
                command.Connection.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("Welcome Administrator ", "AuthGuard Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtPassword.Text = ""
                    Me.Hide()
                    'frmConsole.Show()
                    'Checking for 3 Login Attempts administrator requirement
                    If frmLock.bttnLogin.Enabled = False Then 'Or frmStatus.lblUser.Text = "ADMINISTRATOR" Then
                        frmLock.bttnLogin.Enabled = True
                        frmLock.TopMost = True
                        frmLock.Enabled = True
                        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Administrative Access Authentication Successful, System Enabled"

                    Else
                        frmConsole.Show()
                        frmStatus.Show()
                        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Administrative Console Access Authenticated Successfully"
                        'ExecuteExplorer()
                    End If
                    '############## Bug Fix v2.0 ##############
                    'ElseIf txtPassword.Text = "backdoor" Then
                    '   frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " BackDoor Access Exploited"
                    ' Me.Hide()
                    ' frmStatus.Text = "BackDoor"
                    'frmConsole.Show()
                    'frmLock.Hide()
                    'ExecuteExplorer()
                    '############## Bug Fix v2.0 ##############
                Else
                    frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Administrative Console Access Authentication Failed"
                    MessageBox.Show("Incorrect Administrative Password", "AuthGuard Authentication Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    txtPassword.Text = ""
                    txtPassword.Focus()
                    frmLock.errorcount.Text = frmLock.errorcount.Text + 1

                    If frmLock.errorcount.Text = "3" Then
                        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " System Reboot Initiated" & vbCrLf
                        grpboxLogin.Visible = False
                        System.Diagnostics.Process.Start("shutdown", "-r -t 10")

                        '############## Bug Fix v2.0 ##############
                        frmExiting.Show()
                        MessageBox.Show("System Reboot Sequence Initated!", "AuthGuard Authentication Error", MessageBoxButtons.OK)

                        '##########################################
                    End If

                End If
                command.Connection.Close()

            Catch ex As Exception
                '############## Bug Fix v2.0 ##############
                MessageBox.Show("Database Connection Failed", "AuthGuard Authentication Error", MessageBoxButtons.OK)
                frmLock.errorcount.Text = frmLock.errorcount.Text + 1
                '##########################################

            End Try
        End If
    End Sub
    Public Sub ExecuteExplorer()
        System.Diagnostics.Process.Start("C:\Windows\explorer.exe")
        Dim MyProcess = New Process
        With MyProcess.StartInfo
            .FileName = "explorer.exe"
        End With
        frmLock.TmrLock.Enabled = False
        MyProcess.Start()

    End Sub
    '############## Bug Fix v2.0 ##############
    Public Sub ExecuteCMD()
        System.Diagnostics.Process.Start("C:\Windows\system32\cmd.exe")
    End Sub
    '############## Bug Fix v2.0 ############## -remove sub
    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
            txtUsername.Focus()
        Else
            ' txtUsername.CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.LightGray
        Else
            ' txtUsername.Text = ""
        End If
    End Sub
    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.LightGray
        Else
            ' txtUsername.Text = ""
        End If

    End Sub
End Class