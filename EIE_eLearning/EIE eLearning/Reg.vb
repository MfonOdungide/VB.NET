Public Class frmRegistration

    Private Sub UserDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserData_DataSet)

    End Sub

    Private Sub Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserData_DataSet.UserData' table. You can move, or remove it, as needed.
        Me.UserDataTableAdapter.Fill(Me.UserData_DataSet.UserData)
        Me.UserDataBindingSource.AddNew()
        txtMatricNumber.Focus()
    End Sub

    Private Sub bttnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnReset.Click
        Try
            Me.UserDataBindingSource.AddNew()
            txtMatricNumber.Focus()
            txtRetypePassword.Text = ""
        Catch ex As Exception
            MessageBox.Show("Form is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMatricNumber.Focus()
        End Try
    End Sub

    Private Sub bttnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRegister.Click

        If txtMatricNumber.Text = "" Then
            MessageBox.Show("Matric Number Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMatricNumber.Focus()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Password Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
        ElseIf txtPassword.Text <> txtRetypePassword.Text Then
            MessageBox.Show("Password Mismatch", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetypePassword.Text = ""
            txtRetypePassword.Focus()
        ElseIf cboSecurityQuestion.Text = "" Then
            MessageBox.Show("Security Question Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSecurityQuestion.Focus()
        ElseIf txtSecurityAnswer.Text = "" Then
            MessageBox.Show("Security Answer Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSecurityAnswer.Focus()
        ElseIf txtSurname.Text = "" Then
            MessageBox.Show("Surname Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSurname.Focus()
        ElseIf txtOtherNames.Text = "" Then
            MessageBox.Show("Other Names Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOtherNames.Focus()
        ElseIf cboGender.Text = "" Then
            MessageBox.Show("Gender Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboGender.Focus()
        ElseIf cboDepartment.Text = "" Then
            MessageBox.Show("Department Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboDepartment.Focus()
        ElseIf cboProgram.Text = "" Then
            MessageBox.Show("Program Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboProgram.Focus()
        ElseIf cboLevel.Text = "" Then
            MessageBox.Show("Level Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboLevel.Focus()
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Email Missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
        Else

            Try
                Me.Validate()
                Me.UserDataBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.UserData_DataSet)
                frmCongratulations.Show()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub txtMatricNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMatricNumber.TextChanged
        lblUsername.Text = txtMatricNumber.Text
    End Sub
End Class