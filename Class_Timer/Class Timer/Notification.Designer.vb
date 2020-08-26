<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotification
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotification))
        Me.TmrExit = New System.Windows.Forms.Timer(Me.components)
        Me.TmrNotification = New System.Windows.Forms.Timer(Me.components)
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TmrExit
        '
        Me.TmrExit.Interval = 1000
        '
        'TmrNotification
        '
        Me.TmrNotification.Interval = 1000
        '
        'lblInformation
        '
        Me.lblInformation.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(2, 23)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(470, 34)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "You have less than 5 Minutes Remaining "
        Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 81)
        Me.Controls.Add(Me.lblInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotification"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Monitor Notification"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TmrExit As System.Windows.Forms.Timer
    Friend WithEvents TmrNotification As System.Windows.Forms.Timer
    Friend WithEvents lblInformation As System.Windows.Forms.Label
End Class
