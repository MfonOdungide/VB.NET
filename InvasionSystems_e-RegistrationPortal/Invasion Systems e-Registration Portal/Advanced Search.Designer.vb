<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvancedSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvancedSearch))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtCurrentClass = New System.Windows.Forms.TextBox()
        Me.txtCourseRegistered = New System.Windows.Forms.TextBox()
        Me.txtTrainingSession = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtnOtherNames = New System.Windows.Forms.RadioButton()
        Me.rbtnSurname = New System.Windows.Forms.RadioButton()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtCurrentClass)
        Me.GroupBox1.Controls.Add(Me.txtCourseRegistered)
        Me.GroupBox1.Controls.Add(Me.txtTrainingSession)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbtnOtherNames)
        Me.GroupBox1.Controls.Add(Me.rbtnSurname)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 199)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced Search"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(107, 19)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(218, 20)
        Me.txtTitle.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.txtTitle, "Title")
        '
        'txtCurrentClass
        '
        Me.txtCurrentClass.Location = New System.Drawing.Point(107, 160)
        Me.txtCurrentClass.Name = "txtCurrentClass"
        Me.txtCurrentClass.Size = New System.Drawing.Size(218, 20)
        Me.txtCurrentClass.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.txtCurrentClass, "Current Class")
        '
        'txtCourseRegistered
        '
        Me.txtCourseRegistered.Location = New System.Drawing.Point(107, 134)
        Me.txtCourseRegistered.Name = "txtCourseRegistered"
        Me.txtCourseRegistered.Size = New System.Drawing.Size(218, 20)
        Me.txtCourseRegistered.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.txtCourseRegistered, "Course Registered")
        '
        'txtTrainingSession
        '
        Me.txtTrainingSession.Location = New System.Drawing.Point(107, 103)
        Me.txtTrainingSession.Name = "txtTrainingSession"
        Me.txtTrainingSession.Size = New System.Drawing.Size(218, 20)
        Me.txtTrainingSession.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.txtTrainingSession, "Training Session")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Current Class:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(107, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(218, 20)
        Me.txtName.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.txtName, "Input Name")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Course Registered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Training Session:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name:"
        '
        'rbtnOtherNames
        '
        Me.rbtnOtherNames.AutoSize = True
        Me.rbtnOtherNames.Location = New System.Drawing.Point(229, 73)
        Me.rbtnOtherNames.Name = "rbtnOtherNames"
        Me.rbtnOtherNames.Size = New System.Drawing.Size(84, 17)
        Me.rbtnOtherNames.TabIndex = 12
        Me.rbtnOtherNames.TabStop = True
        Me.rbtnOtherNames.Text = "OtherNames"
        Me.ToolTip.SetToolTip(Me.rbtnOtherNames, "Other Names")
        Me.rbtnOtherNames.UseVisualStyleBackColor = True
        '
        'rbtnSurname
        '
        Me.rbtnSurname.AutoSize = True
        Me.rbtnSurname.Location = New System.Drawing.Point(127, 73)
        Me.rbtnSurname.Name = "rbtnSurname"
        Me.rbtnSurname.Size = New System.Drawing.Size(67, 17)
        Me.rbtnSurname.TabIndex = 11
        Me.rbtnSurname.TabStop = True
        Me.rbtnSurname.Text = "Surname"
        Me.ToolTip.SetToolTip(Me.rbtnSurname, "Surname")
        Me.rbtnSurname.UseVisualStyleBackColor = True
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(213, 220)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(138, 15)
        Me.lblAbout.TabIndex = 45
        Me.lblAbout.Text = "© 2014 Invasion Systems"
        Me.ToolTip.SetToolTip(Me.lblAbout, "Invasion Systems")
        '
        'frmAdvancedSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 238)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdvancedSearch"
        Me.Text = "Advanced Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnOtherNames As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSurname As System.Windows.Forms.RadioButton
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentClass As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseRegistered As System.Windows.Forms.TextBox
    Friend WithEvents txtTrainingSession As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
