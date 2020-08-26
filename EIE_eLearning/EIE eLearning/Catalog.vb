Public Class frmCatalog

    Private Sub CatalogBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CatalogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserData_DataSet)

    End Sub

    Private Sub Catalog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserData_DataSet.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.UserData_DataSet.Courses)
        'TODO: This line of code loads data into the 'UserData_DataSet.Catalog' table. You can move, or remove it, as needed.
        Me.CatalogTableAdapter.Fill(Me.UserData_DataSet.Catalog)

    End Sub

    

    
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.CoursesTableAdapter.Keywords(Me.UserData_DataSet.Courses, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class