Public Class frmConfirmation

    Private Sub frmConfirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'DataDataSet.Settings' table. You can move, or remove it, as needed.
            Me.SettingsTableAdapter.Fill(Me.DataDataSet.Settings)
            'TODO: This line of code loads data into the 'DataDataSet.Credentials' table. You can move, or remove it, as needed.
            Me.CredentialsTableAdapter.Fill(Me.DataDataSet.Credentials)
            Me.CredentialsTableAdapter.RegistrationNumber(Me.DataDataSet.Credentials, Me.txtRegistrationNumber.Text) 'searching for registration number

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Me.Close()
            frmLogin.Show()
        End Try

    End Sub

    Private Sub lblRegistrationNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRegistrationNumber.TextChanged
        lblName.Text = SurnameTextBox.Text & ", " & FirstNameTextBox.Text
        lblTimeAllowed.Text = TimeAllowedTextBox.Text & "Minutes"
        lblNo_Of_Questions.Text = txtNo_Of_Questions.Text & " Questions"
    End Sub

    Private Sub RegistrationNumberToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationNumberToolStripButton.Click
        Try
            Me.CredentialsTableAdapter.RegistrationNumber(Me.DataDataSet.Credentials, RegistrationNumberToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub bttnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnProceed.Click

        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & lblRegistrationNumber.Text & "] Signed In as " & Me.lblName.Text
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf & "Examination Center: " & lblExamCenter.Text & vbCrLf & "Examination Title: " & Me.lblCourseTitle.Text & " [" & Me.lblCourseCode.Text & "]"
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf & "Time Allowed: " & lblTimeAllowed.Text & vbCrLf & "Number Of Questions: " & Me.lblNo_Of_Questions.Text
        frmTest.Show()
    End Sub

End Class