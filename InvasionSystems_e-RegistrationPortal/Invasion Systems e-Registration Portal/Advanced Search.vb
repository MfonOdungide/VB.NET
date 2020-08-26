Public Class frmAdvancedSearch

    Private Sub frmAdvancedSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub

    Private Sub Others()
        '(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            frmViewRegistration.BioDataTableAdapter.Others(frmViewRegistration.RecordsDataSet.BioData, txtTitle.Text, txtName.Text, txtTrainingSession.Text, txtCourseRegistered.Text, txtCurrentClass.Text)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged, txtTrainingSession.TextChanged, txtCourseRegistered.TextChanged, txtCurrentClass.TextChanged
        Call Others()

    End Sub
    Private Sub txtNameTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If rbtnOtherNames.Checked = True Then
            Try
                frmViewRegistration.BioDataTableAdapter.OtherNames(frmViewRegistration.RecordsDataSet.BioData, txtName.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf rbtnSurname.Checked = True Then
            Try
                frmViewRegistration.BioDataTableAdapter.Surname(frmViewRegistration.RecordsDataSet.BioData, txtName.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub rbtnOtherNames_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnOtherNames.CheckedChanged
        If rbtnOtherNames.Checked = True Then
            Try
                frmViewRegistration.BioDataTableAdapter.OtherNames(frmViewRegistration.RecordsDataSet.BioData, txtName.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf rbtnSurname.Checked = True Then
            Try
                frmViewRegistration.BioDataTableAdapter.Surname(frmViewRegistration.RecordsDataSet.BioData, txtName.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class