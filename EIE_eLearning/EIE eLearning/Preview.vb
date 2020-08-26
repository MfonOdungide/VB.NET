Public Class frmPreview
    Dim path = System.Windows.Forms.Application.StartupPath

    Private Sub frmPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Player.URL = "wildlife.wmv "
        'Dim location as string
        'location =frmSearch.lblMatricNumber.text & ".wmv "
        'me.player.url = "location"
        'Me.Reader.LoadFile("wildlife.pdf")
    End Sub

    Private Sub Player_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Player.Enter

    End Sub
End Class