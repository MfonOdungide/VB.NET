Imports System.Text
Imports System.IO
Imports System
Public Class frmLuncher
    Private Filename As String = "Log.txt"
    Private SessionEnd As String = "-----------------------" & Environment.NewLine

    Private Sub frmLuncher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddToRegistry()
        Logg()
        CheckClearancLevel()
        CheckAuthDatabase()
        CheckLogFile()
        CheckAuthGuard()
    End Sub
    Private Sub Logg()
        If IO.File.Exists(Filename) = True Then

            Dim objWriter As New System.IO.StreamWriter(Filename)

            objWriter.Write(txtFile.Text)
            objWriter.Close()
            'MsgBox("Text written to file")
        Else

            Dim fs As FileStream = File.Create(Filename)

        End If
    End Sub

    Private Sub frmLog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If IO.File.Exists(Filename) = True Then
            Dim objWriter As New System.IO.StreamWriter(Filename)
            objWriter.Write(txtFile.Text)
            objWriter.Close()
        Else

        End If

        e.Cancel = True
        Me.Hide()
        Call bttnSave.PerformClick()
        txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Exiting Log "
    End Sub

    Private Sub AddToRegistry()
        Dim regKey As Microsoft.Win32.RegistryKey
        Dim KeyName As String = "AuthGuard"
        Dim KeyValue As String = Application.ExecutablePath.ToString
        Try
            ' regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

            If regKey.GetValue(KeyName) = Nothing Then
                'if there's no KeyName yet? then create and set it's value 
                ' MsgBox("AuthGuard is not on AutoStart!")
                regKey.SetValue(KeyName, KeyValue, Microsoft.Win32.RegistryValueKind.String)
                'MsgBox("key " & KeyName & " has been created") 

            Else
                'MsgBox("This Program already exists", vbInformation, "Information")

            End If

        Catch ex As Exception

        End Try

    End Sub
    

    Private Sub bttnSave_Click() Handles bttnSave.Click

        Dim CombinedText As String = String.Concat(txtFile.Text, Environment.NewLine, SessionEnd)
        My.Computer.FileSystem.WriteAllText(Filename, CombinedText, True)
    End Sub

    Private Sub CheckClearancLevel()
        txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Checking Clearance Level Database"
        If System.IO.File.Exists("C:\Program Files\Invasion Systems\AuthGuard\clevel.ivsdb") = True Then
            txtFile.Text = txtFile.Text & vbCrLf + "Clearance Level Database Connection Available"
        Else
            txtFile.Text = txtFile.Text & vbCrLf + "Clearance LevelDatabase Connection Unavailable"
        End If

    End Sub
    Private Sub CheckAuthDatabase()
        txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Checking Authentication Database"
        If System.IO.File.Exists("C:\Program Files\Invasion Systems\AuthGuard\auth.ivsdb") = True Then
            txtFile.Text = txtFile.Text & vbCrLf + "Authentication Database Connection Available"
        Else
            txtFile.Text = txtFile.Text & vbCrLf + "Authentication Database Connection Unavailable"
        End If

    End Sub

    Private Sub CheckLogFile()
        txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Checking Log File"
        If System.IO.File.Exists("C:\Program Files\Invasion Systems\AuthGuard\Log.txt") = True Then
            txtFile.Text = txtFile.Text & vbCrLf + "Log Data Available"
        Else
            txtFile.Text = txtFile.Text & vbCrLf + "Log Data Unavailable"
        End If

    End Sub
    Private Sub CheckAuthGuard()
        txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Checking for Installation"
        If System.IO.File.Exists("C:\Program Files\Invasion Systems\AuthGuard\authGuard.exe") = True Then
            txtFile.Text = txtFile.Text & vbCrLf + "AuthGruard Installed"
            ExecuteAuthGuard()
            txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Checking Authentication Database"

        Else
            txtFile.Text = txtFile.Text & vbCrLf + "AuthGuard Not Installed"

        End If

    End Sub
    Private Sub ExecuteAuthGuard()
        txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Executing AuthGuard..."
        Try
            System.Diagnostics.Process.Start("C:\Program Files\Invasion Systems\AuthGuard\AuthGuard.exe")
            Tmr.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " " & ex.Message

        End Try

    End Sub

    Public Function killprocess(ByVal processname As String)

        'Get list of all running processes
        Dim proc() As Process = Process.GetProcesses

        'Loop through all processes
        For i As Integer = 0 To proc.GetUpperBound(0)
            If proc(i).ProcessName = processname Then
                On Error Resume Next
                proc(i).Kill()
            End If
        Next

    End Function

    Private Sub Tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tmr.Tick
        Dim p As System.Diagnostics.Process
        For Each p In System.Diagnostics.Process.GetProcesses()
            If p.ProcessName = "AuthGuard" Then
                txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " AuthGuard Executed Successfully"
                Tmr.Enabled = False
                Me.Close()
                killprocess("AuthLuncher")

            End If
        Next


    End Sub
End Class
