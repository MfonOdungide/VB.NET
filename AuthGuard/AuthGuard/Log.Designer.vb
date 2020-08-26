<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.tmrLogUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtFile
        '
        Me.txtFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.Location = New System.Drawing.Point(0, 0)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFile.Size = New System.Drawing.Size(867, 593)
        Me.txtFile.TabIndex = 3
        '
        'bttnSave
        '
        Me.bttnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bttnSave.Location = New System.Drawing.Point(0, 591)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(867, 38)
        Me.bttnSave.TabIndex = 4
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'tmrLogUpdate
        '
        Me.tmrLogUpdate.Enabled = True
        Me.tmrLogUpdate.Interval = 10000
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 629)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.txtFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuthGuard System Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents tmrLogUpdate As System.Windows.Forms.Timer
End Class
