Public Class frmAccountInformation

    Private Sub UserDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserData_DataSet)

    End Sub

    Private Sub Account_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserData_DataSet.UserData' table. You can move, or remove it, as needed.
        Me.UserDataTableAdapter.Fill(Me.UserData_DataSet.UserData)

    End Sub


End Class