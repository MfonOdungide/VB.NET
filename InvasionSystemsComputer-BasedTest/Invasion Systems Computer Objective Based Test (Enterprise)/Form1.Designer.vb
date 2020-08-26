<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInstruction = New System.Windows.Forms.RichTextBox()
        Me.Cover = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInstruction
        '
        Me.txtInstruction.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtInstruction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInstruction.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstruction.Location = New System.Drawing.Point(-24, 104)
        Me.txtInstruction.Name = "txtInstruction"
        Me.txtInstruction.Size = New System.Drawing.Size(700, 540)
        Me.txtInstruction.TabIndex = 50
        Me.txtInstruction.Text = resources.GetString("txtInstruction.Text")
        '
        'Cover
        '
        Me.Cover.Location = New System.Drawing.Point(621, 50)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(749, 560)
        Me.Cover.TabIndex = 51
        Me.Cover.Text = ".."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 501)
        Me.Controls.Add(Me.Cover)
        Me.Controls.Add(Me.txtInstruction)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtInstruction As System.Windows.Forms.RichTextBox
    Friend WithEvents Cover As System.Windows.Forms.Label
End Class
