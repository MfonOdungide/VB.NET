Imports System.Diagnostics
Public Class frmConsole

    Private Sub UserDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AuthDataSet)

    End Sub

    Private Sub frmConsole_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Exiting Console"
    End Sub

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSearch.SelectedIndex = 0
        SurnameTextBox.Text.ToUpper()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Administrative Console Accessed"

        If AutoKillTimer.Enabled = False Then ' Timer is active
            bttnEnableGuard.Enabled = False 'Disable Enable Button
            bttnDisableGuard.Enabled = True
            bttnAdd.Enabled = False
            bttnInclude.Enabled = False
            bttnRemoveAll.Enabled = False
            bttnRemove.Enabled = False
        ElseIf AutoKillTimer.Enabled = True Then
            bttnEnableGuard.Enabled = True
            bttnDisableGuard.Enabled = False
            bttnAdd.Enabled = True
            bttnInclude.Enabled = True
            bttnRemoveAll.Enabled = True
            bttnRemove.Enabled = True
        End If
        '############## Bug Fix v2.0 ##############
        '
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        On Error Resume Next
        'Bug fix on v.2.0 (Remove and Enable try, catch...)
        '##########################################


        'Try
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
        'TODO: This line of code loads data into the 'ClevelDataSet._0' table. You can move, or remove it, as needed.
        Me._0TableAdapter.Fill(Me.ClevelDataSet._0)
        'TODO: This line of code loads data into the 'AuthDataSet.UserData' table. You can move, or remove it, as needed.
        Me.UserDataTableAdapter.Fill(Me.AuthDataSet.UserData)
        'Catch ex As Exception
        'MessageBox.Show("Console DB Missing", "AuthGuard Error", MessageBoxButtons.OK)
        'MessageBox.Show(ex.Message, "AuthGuard Error", MessageBoxButtons.OK)
        'End Try


    End Sub

    Private Sub cboLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedIndexChanged
        Dim Level As String = cboLevel.SelectedItem
        LevelBindingSource.DataMember = Level
        lblLevell.Text = Level
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


    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LevelBindingSource.EndEdit()
            Me.LevelTableAdapterManager.UpdateAll(Me.ClevelDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AuthGuard Error", MessageBoxButtons.OK)
        End Try

    End Sub


    Private Sub bttnUpdateProcessList_Click(sender As Object, e As EventArgs) Handles bttnUpdateProcessList.Click
        UpdateProcessList()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Process List Updated"

    End Sub

    Private Sub lstProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProcesses.SelectedIndexChanged, lstProcessQueue.SelectedIndexChanged, lstProc.SelectedIndexChanged
        txtProcess.Text = lstProcesses.SelectedItem
    End Sub

    Private Sub RemoveAll_Click(sender As Object, e As EventArgs) Handles bttnRemoveAll.Click
        Try
            lstProcessQueue.Items.Clear()
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " AutoKill List Cleared"

        Catch ex As Exception
            MessageBox.Show("Nothing to Clear", "Clear Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bttnRemove_Click(sender As Object, e As EventArgs) Handles bttnRemove.Click
        Try
            lstProcessQueue.Items.Remove(lstProcessQueue.SelectedItem)
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & lstProcessQueue.SelectedItem & "}" & " Removed from AutoKill List"

        Catch ex As Exception
            MessageBox.Show("Select Process to Remove", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Try
            lstProcessQueue.Items.Add(lstProcesses.SelectedItem)
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & lstProcesses.SelectedItem & "}" & " Added from Process List to AutoKill List"

        Catch ex As Exception
            MessageBox.Show("Select Process to Add", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub UpdateProcessList()
        'clears the existing list of any items
        lstProcesses.Items.Clear()
        'loop through the running processes and add each to the list
        Dim P As System.Diagnostics.Process
        For Each P In System.Diagnostics.Process.GetProcesses
            lstProcesses.Items.Add(P.ProcessName)
        Next
        lstProcesses.Sorted = True
        'displays the number of running processes in  a status message at the bottom of the page
        lblProcessCount.Text = "Processes Running: " & lstProcesses.Items.Count.ToString()

    End Sub

    Private Sub Kill()
        Dim processlist() As Process
        processlist = Process.GetProcessesByName(lstProcesses.Items(lstProcesses.SelectedIndex).ToString)
        For Each proc As Process In processlist
            If MsgBox("Terminate" & proc.ProcessName & "?", MsgBoxStyle.YesNo, "Terminate?") = MsgBoxResult.Yes Then
                Try
                    proc.Kill()
                    frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & proc.ProcessName & "}" & " Manually Terminated"
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Next
    End Sub

    Private Sub bttnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnKill.Click
        'Call killprocess function and send the name of the program you'd like to kill
        killprocess(txtProcess.Text)
    End Sub

    Public Function killprocess(ByVal processname As String)

        'Get list of all running processes
        Dim proc() As Process = Process.GetProcesses

        'Loop through all processes
        For i As Integer = 0 To proc.GetUpperBound(0)
            If proc(i).ProcessName = processname Then
                'kill process if name is calc
                '############## Bug Fix v2.0 ##############
                On Error Resume Next
                '############## Bug Fix v2.0 ##############
                proc(i).Kill()
                MessageBox.Show("Your " & processname & " has been killed by AuthGuard!", "AuthGuard", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & processname & "}" & " Manually Killed"

            End If
        Next
        'Return 0
    End Function

    Private Sub bttnKillSelected_Click(sender As Object, e As EventArgs) Handles bttnKillSelected.Click
        If lstProcesses.SelectedItems.Count <= 0 Then
            MessageBox.Show("Click on a process to kill", "No Process Selected")
            Return
        End If
        'loop through the running process looking for a match by comparing process name to the name selected in the listbox
        Dim p As System.Diagnostics.Process
        For Each p In System.Diagnostics.Process.GetProcesses()
            Try
                Dim sP As String = lstProcesses.SelectedItem

                If p.ProcessName = sP Then
                    p.Kill()
                End If
                MessageBox.Show("Your " & sP & " has been killed by AuthGuard!", "AuthGuard", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & sP & "}" & " Manually Terminated"

            Catch ex As Exception

            End Try
        Next
        'Update the list to show the killed process has been removed
        UpdateProcessList()
    End Sub
    Private Sub AutoKill()
        Dim Max As Integer = lstProcessQueue.Items.Count.ToString - 1
        For K As Integer = 0 To Max 'Step -1
            Dim p As System.Diagnostics.Process
            For Each p In System.Diagnostics.Process.GetProcesses()
                Try
                    If p.ProcessName = lstProcessQueue.Items(K).ToString Then
                        p.Kill()
                        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & p.ProcessName & "}" & " AutoKilled"

                        frmLock.TrayIcon.Visible = True
                        frmLock.TrayIcon.BalloonTipText = p.ProcessName & " Killed By AuthGuard"
                        frmLock.TrayIcon.BalloonTipTitle = Application.ProductName
                        frmLock.TrayIcon.ShowBalloonTip(1)
                    End If
                Catch ex As Exception

                End Try
            Next
        Next

    End Sub

    Private Sub bttnAutoKill_Click(sender As Object, e As EventArgs) Handles bttnRefreshQueue.Click
        UpdateKillList()

    End Sub

    Private Sub ProcessCountUpdate_Tick(sender As Object, e As EventArgs) Handles AutoKillTimer.Tick
        AutoKill()
        UpdateProcessList()
    End Sub

    Private Sub bttnEnableGuard_Click(sender As Object, e As EventArgs) Handles bttnEnableGuard.Click
        If AutoKillTimer.Enabled = False Then
            AutoKillTimer.Enabled = True
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " AutoKill Enabled"
            bttnEnableGuard.Enabled = False
            bttnDisableGuard.Enabled = True
            bttnAdd.Enabled = False
            bttnInclude.Enabled = False
            bttnRemoveAll.Enabled = False
            bttnRemove.Enabled = False
        End If
    End Sub

    Private Sub bttnDisableGuard_Click(sender As Object, e As EventArgs) Handles bttnDisableGuard.Click
        If AutoKillTimer.Enabled = True Then
            AutoKillTimer.Enabled = False
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " AutoKill Disabled"
            bttnEnableGuard.Enabled = True
            bttnDisableGuard.Enabled = False
            bttnAdd.Enabled = True
            bttnInclude.Enabled = True
            bttnRemoveAll.Enabled = True
            bttnRemove.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bttnViewLog.Click
        frmLog.Show()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Log Accessed"

    End Sub

    Private Sub UpdateKillList()
        lstProcessQueue.Items.Clear()
        For K As Integer = 0 To frmLock.lstProc.Items.Count - 1
            frmLock.lstProc.SelectedIndex = K
            lstProcessQueue.Items.Add(frmLock.lstProc.SelectedValue)
        Next

    End Sub


    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click
        frmExiting.Show()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Exit Sequence Initated"

    End Sub

    Private Sub SurnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameTextBox.TextChanged
        SurnameTextBox.CharacterCasing = CharacterCasing.Upper
        PasswordTextBox.Text = SurnameTextBox.Text
    End Sub

    Private Sub bttnInclude_Click(sender As Object, e As EventArgs) Handles bttnInclude.Click
        lstProcessQueue.Items.Add(txtProcess.Text)
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " {" & txtProcess.Text & "}" & " Temporarily added to AutoKill List"

    End Sub

    Private Sub txtProcess_TextChanged(sender As Object, e As EventArgs) Handles txtProcess.TextChanged
        If txtProcess.Text = "" And AutoKillTimer.Enabled = True Then
            bttnInclude.Enabled = False
        ElseIf txtProcess.Text = "" And AutoKillTimer.Enabled = False Then
            bttnInclude.Enabled = True
        ElseIf txtProcess.Text <> "" And AutoKillTimer.Enabled = False Then
            bttnInclude.Enabled = True
        ElseIf txtProcess.Text <> "" And AutoKillTimer.Enabled = True Then
            bttnInclude.Enabled = False
        End If
    End Sub

    Private Sub PassportPictureBox_Click(sender As Object, e As EventArgs) Handles PassportPictureBox.DoubleClick
        If Me.OpenFileDialog.ShowDialog = 1 Then
            Me.PassportPictureBox.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        UsernameTextBox.CharacterCasing = CharacterCasing.Upper

    End Sub
    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        PasswordTextBox.CharacterCasing = CharacterCasing.Lower
    End Sub
    Private Sub RegistrationNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles RegistrationNumberTextBox.TextChanged
        UsernameTextBox.Text = RegistrationNumberTextBox.Text

        If RegistrationNumberTextBox.Text = "" And SurnameTextBox.Text = "" And FirstNameTextBox.Text = "" Then
            PassportPictureBox.Image = My.Resources.BitLocker_icon
            ClearanceLevelComboBox.SelectedIndex = 0
        End If
    End Sub

   
    Private Sub cboSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearch.SelectedIndexChanged
        If cboSearch.SelectedIndex = 0 Then
            Try
                Me.UserDataTableAdapter.RegistrationNumber(Me.AuthDataSet.UserData, txtNameSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf cboSearch.SelectedIndex = 1 Then
            Try
                Me.UserDataTableAdapter.Surname(Me.AuthDataSet.UserData, txtNameSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf cboSearch.SelectedIndex = 2 Then
            Try
                Me.UserDataTableAdapter.FirstName(Me.AuthDataSet.UserData, txtNameSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearch.TextChanged
        If cboSearch.SelectedIndex = 0 Then
            Try
                Me.UserDataTableAdapter.RegistrationNumber(Me.AuthDataSet.UserData, txtNameSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf cboSearch.SelectedIndex = 1 Then
            Try
                Me.UserDataTableAdapter.Surname(Me.AuthDataSet.UserData, txtNameSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf cboSearch.SelectedIndex = 2 Then
            Try
                Me.UserDataTableAdapter.FirstName(Me.AuthDataSet.UserData, txtNameSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

   
End Class