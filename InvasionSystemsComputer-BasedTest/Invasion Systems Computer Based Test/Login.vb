Imports System.Data.OleDb
Imports System.Media
Imports System.Text
Imports System.IO
Imports System

Public Class frmLogin

    Private Filename As String = "Log.txt"
    Private SessionEnd As String = "-----------------------" & Environment.NewLine

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        KeyPreview = True   'Activates key press monitor with the keydown even
        CreateFile()
        Me.TrayIcon.Visible = True
        Me.TrayIcon.BalloonTipText = Application.ProductName & " Running!"
        Me.TrayIcon.BalloonTipTitle = Application.ProductName
        Me.TrayIcon.ShowBalloonTip(1)
    End Sub
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

    Private Sub bttnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLogin.Click
        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb;Jet OLEDB:Database Password=invasion")
        Dim command As New OleDbCommand("SELECT [ID] FROM [Credentials] WHERE [RegistrationNumber] = username AND [Surname] = password", connection)

        Dim usernameParam As New OleDbParameter("username", Me.txtRegistrationNumber.Text)
        Dim passwordParam As New OleDbParameter("password", Me.txtPassword.Text)

        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)
        Try
            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Welcome " & txtRegistrationNumber.Text & "!", "Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLog.Show()
                frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & Me.txtRegistrationNumber.Text & "] Authenticated"
                frmLog.Hide()
                txtPassword.Text = ""
                frmConfirmation.txtRegistrationNumber.Text = txtRegistrationNumber.Text
                frmConfirmation.SettingsTableAdapter.Fill(frmConfirmation.DataDataSet.Settings)
                frmConfirmation.CredentialsTableAdapter.RegistrationNumber(frmConfirmation.DataDataSet.Credentials, Me.txtRegistrationNumber.Text)

                Me.Hide()
                frmConfirmation.Show()

            Else
                MessageBox.Show("Username/Password not found, Please contact Administrator", "Authentication Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtPassword.Text = ""
            End If

            command.Connection.Close()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call bttnLogin.PerformClick()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click


        If frmConfirmation.SurnameTextBox.Text = "" Then
            Me.Show()
        Else
            frmConfirmation.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub
End Class
