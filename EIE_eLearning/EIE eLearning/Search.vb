Public Class frmSearch

    Private Sub CatalogBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CatalogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserData_DataSet)

    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserData_DataSet.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.UserData_DataSet.Courses)
        'TODO: This line of code loads data into the 'UserData_DataSet.Courses' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'UserData_DataSet.Catalog' table. You can move, or remove it, as needed.
        Me.CatalogTableAdapter.Fill(Me.UserData_DataSet.Catalog)

    End Sub

    Private Sub CoursesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Me.CatalogTableAdapter.Courses(Me.UserData_DataSet.Catalog, CourseCodeToolStripTextBox.Text, CourseTitleToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub





    Private Sub cboSort_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSort.TextChanged
        Try
            Me.CatalogTableAdapter.Modules(Me.UserData_DataSet.Catalog, cboSort.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    
    Private Sub bttnTakeCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnTakeCourse.Click
        Me.Hide()
        frmPreview.Show()
    End Sub

   
End Class