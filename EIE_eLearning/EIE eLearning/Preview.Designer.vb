<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreview))
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Reader = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(0, 133)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(657, 418)
        Me.Player.TabIndex = 0
        '
        'Reader
        '
        'Me.Reader.Dock = System.Windows.Forms.DockStyle.Right
        'Me.Reader.Enabled = True
        'Me.Reader.Location = New System.Drawing.Point(663, 0)
        'Me.Reader.Name = "Reader"
        'Me.Reader.OcxState = CType(resources.GetObject("Reader.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Reader.Size = New System.Drawing.Size(686, 593)
        'Me.Reader.TabIndex = 1
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 593)
        Me.Controls.Add(Me.Reader)
        Me.Controls.Add(Me.Player)
        Me.Name = "frmPreview"
        Me.Text = "Preview"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Reader As AxAcroPDFLib.AxAcroPDF
End Class
