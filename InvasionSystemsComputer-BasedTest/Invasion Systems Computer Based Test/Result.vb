Public Class frmResult

    Private Sub frmResult_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        frmTest.Enabled = True
        frmTest.Hide()

        frmLogin.TrayIcon.BalloonTipText = "Minimized to Tray"
        frmLogin.TrayIcon.ShowBalloonTip(1)

    End Sub

    Private Sub frmResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Form
        f = Application.OpenForms(0)
        Me.Text = frmConfirmation.txtRegistrationNumber.Text & ", " & frmConfirmation.lblName.Text & " - Test Results"

        Dim T As Integer
        txtScore.Text = frmTest.txtScore.Text
        T = Val(txtScore.Text)
        lblPercentage.Text = T & " Points" ' frmTest.txtScore.Text & " Points" 
    End Sub


    Private Sub GenerateResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnGenerateResult.Click
        Me.Hide()
        frmPrint.Show()
        frmTest.Hide()
    End Sub


End Class