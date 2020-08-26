Imports System.Data.OleDb
Imports System.Media

Public Class frmLogin
    Dim path = System.Windows.Forms.Application.StartupPath
    Dim LogOnsound As String
    Dim MyPlayer As New SoundPlayer()

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.bttnSignin.PerformClick()
        End If
    End Sub

    Private Sub Loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogOnsound = "\Sounds\LogOn.wav"
        KeyPreview = True
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSignin.Click
        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=UserData.mdb")
        Dim command As New OleDbCommand("SELECT [ID] FROM [UserData] WHERE [usernameField] = matricnumber AND [passwordField] = password", connection)

        Dim usernameParam As New OleDbParameter("username", Me.txtUsername.Text)
        Dim passwordParam As New OleDbParameter("password", Me.txtPassword.Text)

        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)

        Try
            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Welcome " & txtUsername.Text & "!", "Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyPlayer.Play()

                'frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " " & "Logged In as " & Me.txtUsername.Text

                txtPassword.Text = ""
                'frmMain.lblLoggedUser.Text = txtUsername.Text
                ' frmMain.LoginTableAdapter.Fill(frmMain.LoginDataSet.Login)
                'frmMain.LoginTableAdapter.UserName(frmMain.LoginDataSet.Login, Me.txtUsername.Text)
                Me.Hide()
                frmMain.Show()



                frmMain.TrayIcon.Visible = True
                frmMain.TrayIcon.BalloonTipText = Application.ProductName & " Running!"
                frmMain.TrayIcon.BalloonTipTitle = Application.ProductName
                frmMain.TrayIcon.ShowBalloonTip(1)
            Else
                MessageBox.Show("Username and or Password are not found", "Authentication Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                txtPassword.Text = ""
            End If

            command.Connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error Connecting with Database", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub lblNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNewUser.Click
        frmRegistration.Show()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        'frmExiting.Show()
    End Sub

    Private Sub lblResetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResetPassword.Click
        frmRegistration.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmMain.Show()
    End Sub
End Class
