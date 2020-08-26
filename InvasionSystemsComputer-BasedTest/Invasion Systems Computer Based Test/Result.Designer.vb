<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult
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
        Me.bttnGenerateResult = New System.Windows.Forms.Button()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblCongratulatons = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttnGenerateResult
        '
        Me.bttnGenerateResult.Location = New System.Drawing.Point(492, 191)
        Me.bttnGenerateResult.Name = "bttnGenerateResult"
        Me.bttnGenerateResult.Size = New System.Drawing.Size(136, 41)
        Me.bttnGenerateResult.TabIndex = 12
        Me.bttnGenerateResult.Text = "Generate Result"
        Me.bttnGenerateResult.UseVisualStyleBackColor = True
        '
        'lblPercentage
        '
        Me.lblPercentage.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(44, 56)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(552, 128)
        Me.lblPercentage.TabIndex = 11
        Me.lblPercentage.Text = "100%"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCongratulatons
        '
        Me.lblCongratulatons.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongratulatons.Location = New System.Drawing.Point(55, 9)
        Me.lblCongratulatons.Name = "lblCongratulatons"
        Me.lblCongratulatons.Size = New System.Drawing.Size(531, 47)
        Me.lblCongratulatons.TabIndex = 10
        Me.lblCongratulatons.Text = "Congratulations! You Scored"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(265, 208)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 9
        Me.txtScore.Visible = False
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnGenerateResult)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblCongratulatons)
        Me.Controls.Add(Me.txtScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmResult"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnGenerateResult As System.Windows.Forms.Button
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents lblCongratulatons As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
End Class
