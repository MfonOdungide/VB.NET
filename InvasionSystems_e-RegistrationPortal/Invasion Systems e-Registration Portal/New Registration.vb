Public Class frmNewRegistration

    Private Sub BioDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BioDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BioDataBindingSource.EndEdit()
    End Sub

    Private Sub New_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecordsDataSet.BioData' table. You can move, or remove it, as needed.

        KeyPreview = True
        Me.BioDataTableAdapter.Fill(Me.RecordsDataSet.BioData)

        If frmViewRegistration.chkEdit.Enabled = True Then

            Me.BioDataTableAdapter.RegNumber(Me.RecordsDataSet.BioData, frmViewRegistration.RegistrationNumber_Textbox.Text)
            Me.bttnNew.Enabled = False
            bttnSave.Text = "&Update"
            Me.Text = "[" & Registration_NumberTextBox.Text & "], " & SurnameTextBox.Text & " " & First_NameTextBox.Text & " " & Other_NamesTextBox.Text & " - Invasion Systems e-Registration Portal"
        ElseIf frmViewRegistration.chkEdit.Enabled = False Then

            'TODO: This line of code loads data into the 'RecordsDataSet.BioData' table. You can move, or remove it, as needed.
            Me.BioDataTableAdapter.Fill(Me.RecordsDataSet.BioData)
            Me.BioDataBindingSource.AddNew()
            Me.Text = "New Registration - Invasion Systems e-Registration Portal"
        End If
        Registration_NumberTextBox.Focus()
    End Sub

    Private Sub PassportPictureBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassportPictureBox.DoubleClick

        If Me.OpenFileDialog.ShowDialog = 1 Then
            Me.PassportPictureBox.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        
        If chkEdit.Enabled = True Then
            Try
                Me.Validate()
                Me.BioDataBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.RecordsDataSet)

                'Confirm Update
                MessageBox.Show("User " & Registration_NumberTextBox.Text & " " & "[" & SurnameTextBox.Text & "] " & "Updated Successfully", Registration_NumberTextBox.Text & " Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Press F5 on Main Screen to reflect Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                bttnSave.Enabled = False 'Disable Save button to allow for error check on Registration Number field
                bttnEdit.Enabled = True
                Disable_Groupboxes()
                Me.bttnClear.Enabled = False
                Me.bttnDelete.Enabled = False

            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else

            'Update and populate fields
            Try
                Me.Validate()
                Me.BioDataBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.RecordsDataSet)

                'Confirm Saving
                MessageBox.Show("User " & Registration_NumberTextBox.Text & " " & "[" & SurnameTextBox.Text & "] " & "Saved Successfully", Registration_NumberTextBox.Text & " Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bttnSave.Enabled = False 'Disable Save button to allow for error check on Registration Number field
                bttnEdit.Enabled = True
                Disable_Groupboxes()
                Me.bttnClear.Enabled = False
                Me.bttnDelete.Enabled = False
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        frmViewRegistration.chkEdit.Enabled = False
    End Sub

    Private Sub bttnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNew.Click
        Try
            Me.BioDataBindingSource.AddNew()
            bttnSave.Enabled = True
            bttnSave.Text = "Save"
            Me.chkEdit.Checked = False
            Me.bttnClear.Enabled = True
            bttnEdit.Enabled = False
            Enable_Groupboxes()
            Registration_NumberTextBox.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Registration_NumberTextBox.Focus()
        End Try
        frmViewRegistration.chkEdit.Enabled = False
    End Sub

    Private Sub bttnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClear.Click
        Try
            Me.BioDataBindingSource.RemoveCurrent()
            bttnSave.Enabled = True
            bttnSave.Text = "Save"
            Me.chkEdit.Checked = False
            Me.bttnClear.Enabled = False
            Me.bttnDelete.Enabled = False
            bttnEdit.Enabled = False

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Registration_NumberTextBox.Focus()
        End Try
        frmViewRegistration.chkEdit.Enabled = False
    End Sub

    Private Sub bttnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEdit.Click
        Try
            bttnSave.Enabled = True
            bttnSave.Text = "&Update"
            Me.chkEdit.Checked = False
            Enable_Groupboxes()
            Registration_NumberTextBox.Focus()
            Me.bttnClear.Enabled = True
            Me.bttnDelete.Enabled = True
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Registration_NumberTextBox.Focus()
        End Try
        frmViewRegistration.chkEdit.Enabled = False
    End Sub

    Private Sub bttnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDelete.Click
        Try
            Me.BioDataBindingSource.RemoveCurrent()
            Call bttnNew.PerformClick()
            bttnSave.Enabled = True
            '  bttnSave.Text = "&Update"
            Me.chkEdit.Checked = False
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Registration_NumberTextBox.Focus()
        End Try
        frmViewRegistration.chkEdit.Enabled = False
    End Sub

    Private Sub Disable_Groupboxes()
        grpboxContactInformation.Enabled = False
        grpboxCourseInformation.Enabled = False
        grpboxEducationalInformation.Enabled = False
        grpboxNOKInformation.Enabled = False
        grpboxPersonalInformation.Enabled = False
    End Sub
    Private Sub Enable_Groupboxes()
        grpboxContactInformation.Enabled = True
        grpboxCourseInformation.Enabled = True
        grpboxEducationalInformation.Enabled = True
        grpboxNOKInformation.Enabled = True
        grpboxPersonalInformation.Enabled = True
    End Sub

    Private Sub bttnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnExit.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub PassportPictureBox_Click(sender As Object, e As EventArgs) Handles PassportPictureBox.Click

    End Sub
End Class