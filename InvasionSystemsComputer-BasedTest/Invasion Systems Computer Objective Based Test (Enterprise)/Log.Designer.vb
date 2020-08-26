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
        Me.tmrLogUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.lstFile = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtFile
        '
        Me.txtFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFile.Location = New System.Drawing.Point(0, 0)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFile.Size = New System.Drawing.Size(859, 405)
        Me.txtFile.TabIndex = 2
        '
        'tmrLogUpdate
        '
        Me.tmrLogUpdate.Enabled = True
        Me.tmrLogUpdate.Interval = 10000
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(772, 409)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(75, 23)
        Me.bttnSave.TabIndex = 3
        Me.bttnSave.Text = "Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'lstFile
        '
        Me.lstFile.FormattingEnabled = True
        Me.lstFile.Location = New System.Drawing.Point(131, 141)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.Size = New System.Drawing.Size(120, 95)
        Me.lstFile.TabIndex = 4
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 444)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.lstFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLog"
        Me.Text = "Session Log - CBT Emulator [Invasion Systems]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents lstFile As System.Windows.Forms.ListBox
    Friend WithEvents tmrLogUpdate As System.Windows.Forms.Timer
End Class
