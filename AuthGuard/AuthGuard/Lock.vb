Imports System.Data.OleDb
Imports System.Media
Imports System.Text
Imports System.IO
Imports System

Public Class frmLock

    Private Filename As String = "Log.txt"
    Private SessionEnd As String = "-----------------------" & Environment.NewLine

    Dim Point As New System.Drawing.Point()
    Dim A, B As Integer

    Private Sub CreateFile()
        If IO.File.Exists(Filename) = True Then
            'MsgBox("Text written to file")
        Else
            Dim fs As FileStream = File.Create(Filename)
            Me.TrayIcon.Visible = True
            Me.TrayIcon.BalloonTipText = Application.ProductName & " - Log File Created"
            Me.TrayIcon.BalloonTipTitle = Application.ProductName
            Me.TrayIcon.ShowBalloonTip(1)
        End If

    End Sub

    Private Sub frmLock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub AddToRegistry()
        Dim regKey As Microsoft.Win32.RegistryKey
        '############## Bug Fix v2.0 ##############
        '
        'Dim KeyName As String = "AuthGuard"
        '##########################################
        Dim KeyName As String = "AuthLuncher"
        Dim KeyValue As String = Application.ExecutablePath.ToString
        Try
            regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

            If regKey.GetValue(KeyName) = Nothing Then
                'if there's no KeyName yet? then create and set it's value 
                MsgBox("AuthGuard is not on AutoStart!")
                regKey.SetValue(KeyName, KeyValue, Microsoft.Win32.RegistryValueKind.String)
                'MsgBox("key " & KeyName & " has been created") 
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipText = "AuthGuard Successfully Added to AutoStart"
                Me.TrayIcon.BalloonTipTitle = Application.ProductName
                Me.TrayIcon.ShowBalloonTip(1)
            Else
                'MsgBox("This Program already exists", vbInformation, "Information")
                Me.TrayIcon.Visible = True
                Me.TrayIcon.BalloonTipText = "AuthGuard Already on AutoStart"
                Me.TrayIcon.BalloonTipTitle = Application.ProductName
                Me.TrayIcon.ShowBalloonTip(1)
            End If

        Catch ex As Exception
            Me.TrayIcon.Visible = True
            Me.TrayIcon.BalloonTipText = "Error Creating Registry Key"
            Me.TrayIcon.BalloonTipTitle = Application.ProductName
            Me.TrayIcon.ShowBalloonTip(1)
        End Try

    End Sub

    Private Sub frmLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateFile()
        'AddToRegistry()
        frmConsole.Show()
        frmConsole.TopMost = False
        Me.TopMost = True
        frmConsole.Hide()
        frmLog.Show()
        frmLog.Hide()
        Me.TopMost = True
        '############## Bug Fix v2.0 ##############
        'Kill AuthGuard Luncher


        '##########################################
        Try
            'TODO: This line of code loads data into the 'ClevelDataSet._0' table. You can move, or remove it, as needed.
            Me._0TableAdapter.Fill(Me.ClevelDataSet._0)
            'TODO: This line of code loads data into the 'ClevelDataSet._7' table. You can move, or remove it, as needed.
            Me._7TableAdapter.Fill(Me.ClevelDataSet._7)
            'TODO: This line of code loads data into the 'ClevelDataSet._6' table. You can move, or remove it, as needed.
            Me._6TableAdapter.Fill(Me.ClevelDataSet._6)
            'TODO: This line of code loads data into the 'ClevelDataSet._5' table. You can move, or remove it, as needed.
            Me._5TableAdapter.Fill(Me.ClevelDataSet._5)
            'TODO: This line of code loads data into the 'ClevelDataSet._4' table. You can move, or remove it, as needed.
            Me._4TableAdapter.Fill(Me.ClevelDataSet._4)
            'TODO: This line of code loads data into the 'ClevelDataSet._3' table. You can move, or remove it, as needed.
            Me._3TableAdapter.Fill(Me.ClevelDataSet._3)
            'TODO: This line of code loads data into the 'ClevelDataSet._2' table. You can move, or remove it, as needed.
            Me._2TableAdapter.Fill(Me.ClevelDataSet._2)
            'TODO: This line of code loads data into the 'ClevelDataSet._1' table. You can move, or remove it, as needed.
            Me._1TableAdapter.Fill(Me.ClevelDataSet._1)
            'TODO: This line of code loads data into the 'AuthDataSet.UserData' table. You can move, or remove it, as needed.
            Me.UserDataTableAdapter.Fill(Me.AuthDataSet.UserData)
            Me.UserDataTableAdapter.Username(Me.AuthDataSet.UserData, txtUsername.Text)
            txtUsername.ForeColor = Color.LightGray
            txtPassword.ForeColor = Color.LightGray
            CenterControl()
            CornerControl()
            TrayIcon.Visible = True
        Catch
            '############## Bug Fix v2.0 ##############
            MessageBox.Show("Database Disconnected", "AuthGuard Authentication Error", MessageBoxButtons.OK)
            '
            '##########################################
        End Try

    End Sub

    Private Sub frmLock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then 'F12 for Settings
            bttnLogin.Focus()
        End If

        If e.KeyCode = Keys.F1 Then 'F1 for Help
            frmAboutBox.Show()
        End If

    End Sub
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
            txtUsername.ForeColor = Color.Black ' txtUsername.Text = ""
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
    Private Sub CenterControl()
        grpboxLogin.Top = (Me.ClientSize.Height / 2) - (grpboxLogin.Height / 2)
        grpboxLogin.Left = (Me.ClientSize.Width / 2) - (grpboxLogin.Width / 2)
    End Sub

    Private Sub Center_Control_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterControl()
        CornerControl()
    End Sub

    Private Sub CornerControl()
        lblCopyright.Top = (Me.ClientSize.Height) - (lblCopyright.Height)
        lblCopyright.Left = (Me.ClientSize.Width) - (lblCopyright.Width)
    End Sub

    Private Sub bttnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bttnLogin.Click
        'Dim ErrorCount As Integer = 0

        If (errorcount.Text = "3") Then
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " System Disabled"
            bttnLogin.Enabled = False
            MessageBox.Show("System Disabled, Contact Administrator!", "AuthGuard Authentication Error", MessageBoxButtons.OK)
            frmAdminLogin.Show()
            Me.Enabled = False
            With frmAdminLogin
                .ControlBox = False
                .TopMost = True
            End With
        Else


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
                    'If UsernameTextBox.Text = txtPassword.Text And PasswordTextBox.Text = txtPassword.Text Then
                    MessageBox.Show("Welcome " & FirstNameTextBox.Text & " " & SurnameTextBox.Text & "!", "AuthGuard Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & Me.txtUsername.Text & "] Authentication Successful"
                    txtPassword.Text = ""
                    frmStatus.lblUser.Text = SurnameTextBox.Text & " " & FirstNameTextBox.Text
                    TmrLock.Enabled = False
                    ExecuteExplorer()
                    Me.Hide()
                    frmStatus.Show()
                    UpdateList()
                    'frmConsole.bttnEnableGuard.PerformClick() 'not working
                    frmConsole.AutoKillTimer.Enabled = True

                Else
                    errorcount.Text = errorcount.Text + 1
                    frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & Me.txtUsername.Text & "]  Authentication Failed"
                    MessageBox.Show("Username/Password not found, Please contact Administrator", "AuthGuard Authentication Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    txtPassword.Text = ""
                    txtPassword.Focus()

                    If (errorcount.Text = "3") Then
                        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " System Disabled"
                        bttnLogin.Enabled = False
                        MessageBox.Show("System Disabled, Contact Administrator!", "AuthGuard Authentication Error", MessageBoxButtons.OK)
                        frmAdminLogin.Show()
                        Me.Enabled = False
                        With frmAdminLogin
                            .ControlBox = False
                            .TopMost = True
                        End With
                    End If

                End If

                'command.Connection.Close()
            Catch ex As Exception

                '############## Bug Fix v2. 0 ##############
                '.Windows.Forms.MessageBox.Show(ex.Message)
                errorcount.Text = errorcount.Text + 1
                MessageBox.Show("Database Disconnected", "AuthGuard Authentication Error", MessageBoxButtons.OK)
                'MessageBox.Show(ex.Message, "AuthGuard Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '
                '###########################################

            End Try
        End If
    End Sub

    Private Sub ShowHideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHideToolStripMenuItem.Click
        If frmStatus.Visible = False Then
            frmStatus.Visible = True
        ElseIf frmStatus.Visible = True Then
            frmStatus.Visible = False
        End If
    End Sub

    Private Sub AdminConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAdminConsole.Click
        frmAdminLogin.Show()
    End Sub

    Private Sub UserDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AuthDataSet)
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        txtUsername.ForeColor = Color.Black
        Try
            Me.UserDataTableAdapter.Username(Me.AuthDataSet.UserData, txtUsername.Text)
        Catch ex As System.Exception

            '############## Bug Fix v2.0 ##############
            '
            'System.Windows.Forms.MessageBox.Show(ex.Message)
            '##########################################
        End Try

    End Sub

    Private Sub ClearanceLevelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClearanceLevelComboBox.TextChanged
        Dim Level As String = ClearanceLevelComboBox.Text
        LevelBindingSource.DataMember = Level
        'lblLevell.Text = Level
        Select Case Level
            Case "0"
                Me._0TableAdapter.Fill(Me.ClevelDataSet._0)
            Case "1"
                Me._1TableAdapter.Fill(Me.ClevelDataSet._1)
            Case "2"
                Me._2TableAdapter.Fill(Me.ClevelDataSet._2)
            Case "3"
                Me._3TableAdapter.Fill(Me.ClevelDataSet._3)
            Case "4"
                Me._4TableAdapter.Fill(Me.ClevelDataSet._4)
            Case "5"
                Me._5TableAdapter.Fill(Me.ClevelDataSet._5)
            Case "6"
                Me._6TableAdapter.Fill(Me.ClevelDataSet._6)
            Case "7"
                Me._7TableAdapter.Fill(Me.ClevelDataSet._7)
            Case "8"
                'Me._8TableAdaper.Fill (me.clevelDataset._8)
        End Select
        '  ProcessDataGrid.DataMember = Level

    End Sub

    Private Sub UpdateList()
        frmConsole.lstProcessQueue.Items.Clear()
        For K As Integer = 0 To lstProc.Items.Count - 1
            lstProc.SelectedIndex = K
            frmConsole.lstProcessQueue.Items.Add(lstProc.SelectedValue)
        Next
    End Sub


    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & Me.txtUsername.Text & "] Log Off"
        frmAdminLogin.Close()
        frmStatus.Close()
        frmConsole.Close()
        frmAboutBox.Close()
        frmUserInformation.Close()
        frmExiting.Close()
        Me.Show()
        frmConsole.Show()
        frmConsole.TopMost = False
        frmConsole.Hide()
        Me.txtPassword.Focus()
    End Sub

    Private Sub ViewInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInformationToolStripMenuItem1.Click
        frmUserInformation.Show()
    End Sub

    Private Sub TmrLock_Tick(sender As Object, e As EventArgs) Handles TmrLock.Tick
        killprocess("explorer")
        If My.Computer.Keyboard.AltKeyDown = True Then 'And Keys.Tab = True Then
            Me.Focus()
            Me.TopMost = True
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Public Function killprocess(ByVal processname As String)

        'Get list of all running processes
        Dim proc() As Process = Process.GetProcesses

        'Loop through all processes
        For i As Integer = 0 To proc.GetUpperBound(0)
            If proc(i).ProcessName = processname Then
                'kill process if name is calc

                '############## Bug Fix V2.0 ##################
                On Error Resume Next
                '############## Bug Fix V2.0 ##################
                proc(i).Kill()
            End If
        Next
        'Return 0
    End Function

    Public Sub ExecuteExplorer()
        System.Diagnostics.Process.Start("C:\Windows\explorer.exe")
        Dim MyProcess = New Process
        With MyProcess.StartInfo
            .FileName = "explorer.exe"
            '.UseShellExecute = False
            '.CreateNoWindow = True
            '.RedirectStandardInput = True
            '.RedirectStandardOutput = True
            '.RedirectStandardError = True
        End With
        TmrLock.Enabled = False
        MyProcess.Start()

    End Sub

End Class
