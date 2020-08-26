Public Class frmUserInformation

    Private Sub UserDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AuthDataSet)

    End Sub

    Private Sub frmUserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuthDataSet.UserData' table. You can move, or remove it, as needed.
        frmLock.UserDataTableAdapter.Fill(Me.AuthDataSet.UserData)
        UsernameLabel1.Text = frmLock.UsernameTextBox.Text
        frmLock.UserDataTableAdapter.Username(Me.AuthDataSet.UserData, frmLock.UsernameTextBox.Text)
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " User [" & frmLock.txtUsername.Text & "] Viewed Personal Information"
    End Sub


    Private Sub UsernameLabel1_textchanged(sender As Object, e As EventArgs) 'Handles UsernameLabel1.TextChanged
        Try
            Me.UserDataTableAdapter.Fill(Me.AuthDataSet.UserData)
            Me.UserDataTableAdapter.Username(Me.AuthDataSet.UserData, UsernameLabel1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class