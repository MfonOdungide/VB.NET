Imports System.Text
Imports System.IO
Imports System


Public Class frmLog

    Private Filename As String = "Log.txt"
    Private SessionEnd As String = "-----------------------" & Environment.NewLine

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
    End Sub
    Private Sub Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists(Filename) = True Then
            '  Dim objWriter As New System.IO.StreamWriter(Filename)
            'objWriter.Write(txtFile.Text)
            'objWriter.Close()
            'MsgBox("Text written to file")

        Else
            'Dim fs As FileStream = File.Create(Filename)
            frmLogin.TrayIcon.Visible = True
            frmLogin.TrayIcon.BalloonTipText = Application.ProductName & " - Restart Program to Create Log File"
            frmLogin.TrayIcon.BalloonTipTitle = Application.ProductName
            frmLogin.TrayIcon.ShowBalloonTip(1)

        End If

        If txtFile.Text <> "" Then
            txtFile.Text = IO.File.ReadAllText(Filename)
            txtFile.Text = txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " " & frmConfirmation.lblRegistrationNumber.Text & ":" & " Accessed Log"
        Else
            txtFile.Text = IO.File.ReadAllText(Filename)
        End If
        'Me.tmrLogUpdate.Enabled = True
    End Sub

    Private Sub UpDateListBox()
        lstFile.DataSource = IO.File.ReadAllLines(Filename)
        lstFile.SelectedIndex = lstFile.Items.Count - 1
    End Sub

    Private Sub bttnSave_Click() Handles bttnSave.Click
        Dim CombinedText As String = String.Concat(txtFile.Text, Environment.NewLine, SessionEnd)
        My.Computer.FileSystem.WriteAllText(FileName, CombinedText, True)
        UpDateListBox()

    End Sub

    Private Sub tmrLogUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogUpdate.Tick
        'Dim FILE_NAME As String = "Log.txt"

        If IO.File.Exists(Filename) = True Then

            Dim objWriter As New System.IO.StreamWriter(Filename)

            objWriter.Write(txtFile.Text)
            objWriter.Close()
            'MsgBox("Text written to file")
        Else

            'Dim fs As FileStream = File.Create(Filename)
            frmLogin.TrayIcon.Visible = True
            frmLogin.TrayIcon.BalloonTipText = Application.ProductName & " - Creating Log File"
            frmLogin.TrayIcon.BalloonTipTitle = Application.ProductName
            frmLogin.TrayIcon.ShowBalloonTip(1)
        End If
    End Sub

End Class