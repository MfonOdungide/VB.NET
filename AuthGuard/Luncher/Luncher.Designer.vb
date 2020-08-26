<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLuncher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLuncher))
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.Tmr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.ForeColor = System.Drawing.Color.White
        Me.txtFile.Location = New System.Drawing.Point(0, 0)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFile.Size = New System.Drawing.Size(417, 170)
        Me.txtFile.TabIndex = 4
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(321, 135)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(75, 23)
        Me.bttnSave.TabIndex = 5
        Me.bttnSave.Text = "Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'Tmr
        '
        Me.Tmr.Interval = 1000
        '
        'frmLuncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.bttnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLuncher"
        Me.Text = "AuthGuardLuncher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents Tmr As System.Windows.Forms.Timer

End Class
