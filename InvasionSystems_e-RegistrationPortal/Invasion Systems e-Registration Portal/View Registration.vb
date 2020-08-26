Public Class frmViewRegistration

    Private Sub BioDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BioDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BioDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RecordsDataSet)

    End Sub

    Private Sub frmViewRegistration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmAdvancedSearch.Close()

    End Sub

    Private Sub frmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecordsDataSet.BioData' table. You can move, or remove it, as needed.
        Me.BioDataTableAdapter.Fill(Me.RecordsDataSet.BioData)

        Me.SearchComboBox.SelectedItem = "Surname"
        Me.Search.Focus()

    End Sub

    Private Sub Search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Search.TextChanged
        Try

            'Using an undisclosed statement prevent the database displaying all the contacts before searching.
            'But it still displays the contacts after the clearing of all text in the field


            If SearchComboBox.SelectedItem = "Registration Number" Then
                Me.BioDataTableAdapter.RegNumber(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "Telephone" Then
                Me.BioDataTableAdapter.Telephone(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "First Name" Then
                Me.BioDataTableAdapter.FirstName(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "Current Class" Then
                Me.BioDataTableAdapter.CurrentClass(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "Surname" Then
                Me.BioDataTableAdapter.Surname(Me.RecordsDataSet.BioData, Search.Text)
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RefreshF5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshF5ToolStripMenuItem.Click
        Try
            If SearchComboBox.SelectedItem = "Registration Number" Then
                Me.BioDataTableAdapter.RegNumber(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "Telephone" Then
                Me.BioDataTableAdapter.Telephone(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "First Name" Then
                Me.BioDataTableAdapter.FirstName(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "Current Class" Then
                Me.BioDataTableAdapter.CurrentClass(Me.RecordsDataSet.BioData, Search.Text)
            ElseIf SearchComboBox.SelectedItem = "Surname" Then
                Me.BioDataTableAdapter.Surname(Me.RecordsDataSet.BioData, Search.Text)
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub SearchComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchComboBox.SelectedIndexChanged
        If SearchComboBox.SelectedItem = "Registration Number" Then
            Me.BioDataTableAdapter.RegNumber(Me.RecordsDataSet.BioData, Search.Text)
        ElseIf SearchComboBox.SelectedItem = "Telephone" Then
            Me.BioDataTableAdapter.Telephone(Me.RecordsDataSet.BioData, Search.Text)
        ElseIf SearchComboBox.SelectedItem = "First Name" Then
            Me.BioDataTableAdapter.FirstName(Me.RecordsDataSet.BioData, Search.Text)
        ElseIf SearchComboBox.SelectedItem = "Current Class" Then
            Me.BioDataTableAdapter.CurrentClass(Me.RecordsDataSet.BioData, Search.Text)
        ElseIf SearchComboBox.SelectedItem = "Surname" Then
            Me.BioDataTableAdapter.Surname(Me.RecordsDataSet.BioData, Search.Text)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub AdvancedSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedSearchToolStripMenuItem.Click
        frmAdvancedSearch.Show()
    End Sub

    Private Sub EditRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRecordToolStripMenuItem.Click
        chkEdit.Enabled = True
        chkEdit.CheckState = CheckState.Checked
        Me.Hide()
        frmNewRegistration.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Close()
        frmNewRegistration.Show()
    End Sub

End Class