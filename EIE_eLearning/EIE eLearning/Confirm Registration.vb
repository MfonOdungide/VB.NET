Public Class frmCongratulations

    Private Sub Confirm_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome " & frmRegistration.txtSurname.Text & "! "
        lblUsername.Text = frmRegistration.lblUsername.Text
        lblProgram.Text = frmRegistration.cboProgram.Text
        lblSecurityQuestion.Text = frmRegistration.cboSecurityQuestion.Text
        lblSecurityAnswer.Text = frmRegistration.txtSecurityAnswer.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnGoToMenu.Click
        frmMain.Show()
    End Sub
End Class