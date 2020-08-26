Public Class frmMain

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Me.Hide()
        frmSearch.Show()
    End Sub

    Private Sub cmdViewCatalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewCatalog.Click
        frmCatalog.Show()
    End Sub

    Private Sub cmdSearch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.MouseHover
        cmdSearch.Image = My.Resources.Search_hover
    End Sub

    Private Sub cmdSearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.MouseLeave
        cmdSearch.Image = My.Resources.Search_leave
    End Sub

    Private Sub cmdLogout_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLogout.MouseHover
        cmdLogout.Image = My.Resources.logout_hover
    End Sub

    Private Sub cmdLogout_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdLogout.MouseLeave
        cmdLogout.Image = My.Resources.logout_leave
    End Sub

    Private Sub cmdViewCatalog_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewCatalog.MouseHover
        cmdViewCatalog.Image = My.Resources.catalog_hover
    End Sub

    Private Sub cmdViewCatalog_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewCatalog.MouseLeave
        cmdViewCatalog.Image = My.Resources.catalog_leave
    End Sub

    Private Sub cmdViewProgress_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewProgress.MouseHover
        cmdViewProgress.Image = My.Resources.progress_hover
    End Sub

    Private Sub cmdViewProgress_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewProgress.MouseLeave
        cmdViewProgress.Image = My.Resources.progress_leave
    End Sub

    Private Sub cmdViewAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAccount.Click
        frmAccountInformation.Show()
    End Sub

    Private Sub cmdViewAccount_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewAccount.MouseHover
        cmdViewAccount.Image = My.Resources.account_hover
    End Sub

    Private Sub cmdViewAccount_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdViewAccount.MouseLeave
        cmdViewAccount.Image = My.Resources.account_leave
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class