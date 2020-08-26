
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Public Class frmPrint

    Private Sub frmPrint_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        frmResult.Hide()

        frmLogin.TrayIcon.BalloonTipText = "Minimized to Tray"
        frmLogin.TrayIcon.ShowBalloonTip(1)
    End Sub

    Private Sub Prnt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = DateAndTime.Now
        lblScore.Text = frmTest.txtScore.Text
        lblRegistration_Number.Text = frmConfirmation.txtRegistrationNumber.Text
        lblFullName.Text = frmConfirmation.lblName.Text
        lblCourseCode.Text = frmConfirmation.lblCourseCode.Text
        lblExamCenter.Text = frmConfirmation.lblExamCenter.Text
        picPassport.Image = frmConfirmation.picboxPassport.Image
        Me.Text = frmConfirmation.txtRegistrationNumber.Text & ", " & frmConfirmation.lblName.Text & " - Test Results"
        Percentage()
        lblCourse.Text = frmConfirmation.lblCourseTitle.Text

    End Sub

    Private Sub Percentage()
        Dim X, Y, percentage As Integer
        X = Val(frmTest.txtScore.Text)
        Y = Val(frmTest.lblNo_Of_Questions.Text)
        percentage = ((X / Y) * 100)
        lblScore.Text = percentage & "%"
    End Sub
    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As System.Int32) As Boolean
    Private Const SRCCOPY As Integer = &HCC0020

    Private Function GetFormImage() As Bitmap
        ' Get this form's Graphics object.
        Dim me_gr As Graphics = Me.CreateGraphics

        ' Make a Bitmap to hold the image.
        Dim bm As New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = Graphics.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc

        ' Get the form's hDC. We must do this after 
        ' creating the new Bitmap, which uses me_gr.
        Dim me_hdc As IntPtr = me_gr.GetHdc

        ' BitBlt the form's image onto the Bitmap.
        BitBlt(bm_hdc, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height, _
            me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        ' Return the result.
        Return bm
    End Function

    ' Variables used to print.
    Private m_PrintBitmap As Bitmap
    Private WithEvents m_PrintDocument As PrintDocument

    ' Print the picture.
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        ' Copy the form's image into a bitmap.
        m_PrintBitmap = GetFormImage()

        ' Make a PrintDocument and print.
        m_PrintDocument = New PrintDocument
        m_PrintDocument.Print()
    End Sub

    ' Print the form image.
    Private Sub m_PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles m_PrintDocument.PrintPage
        ' Draw the image centered.
        Dim x As Integer = e.MarginBounds.X + _
            (e.MarginBounds.Width - m_PrintBitmap.Width) \ 2
        Dim y As Integer = e.MarginBounds.Y + _
            (e.MarginBounds.Height - m_PrintBitmap.Height) \ 2
        e.Graphics.DrawImage(m_PrintBitmap, x, y)

        ' There's only one page.
        e.HasMorePages = False
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        ' Copy the form's image into a bitmap.
        m_PrintBitmap = GetFormImage()

        ' Make a PrintDocument and print.
        m_PrintDocument = New PrintDocument
        m_PrintDocument.Print()
    End Sub
End Class
