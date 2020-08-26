<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmation))
        Me.lblRegistrationNumber = New System.Windows.Forms.Label()
        Me.CredentialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSet()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDesignation = New System.Windows.Forms.Label()
        Me.lblCourseTitle = New System.Windows.Forms.Label()
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.bttnProceed = New System.Windows.Forms.Button()
        Me.picboxPassport = New System.Windows.Forms.PictureBox()
        Me.lblExamCenter = New System.Windows.Forms.Label()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblNotYou = New System.Windows.Forms.Label()
        Me.txtNo_Of_Questions = New System.Windows.Forms.Label()
        Me.lblTimeAllowed = New System.Windows.Forms.Label()
        Me.CredentialsTableAdapter = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.CredentialsTableAdapter()
        Me.TableAdapterManager = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.TableAdapterManager()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsTableAdapter = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.SettingsTableAdapter()
        Me.TimeAllowedTextBox = New System.Windows.Forms.TextBox()
        Me.RegistrationNumberToolStrip = New System.Windows.Forms.ToolStrip()
        Me.RegistrationNumberToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.RegistrationNumberToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RegistrationNumberToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.txtRegistrationNumber = New System.Windows.Forms.TextBox()
        Me.lblNo_Of_Questions = New System.Windows.Forms.Label()
        CType(Me.CredentialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPassport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrationNumberToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistrationNumber
        '
        Me.lblRegistrationNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistrationNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CredentialsBindingSource, "RegistrationNumber", True))
        Me.lblRegistrationNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationNumber.Location = New System.Drawing.Point(30, 171)
        Me.lblRegistrationNumber.Name = "lblRegistrationNumber"
        Me.lblRegistrationNumber.Size = New System.Drawing.Size(168, 18)
        Me.lblRegistrationNumber.TabIndex = 3
        Me.lblRegistrationNumber.Text = "Registration Number"
        '
        'CredentialsBindingSource
        '
        Me.CredentialsBindingSource.DataMember = "Credentials"
        Me.CredentialsBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(30, 196)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(168, 18)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Amechukwu Oyekachi"
        '
        'lblDesignation
        '
        Me.lblDesignation.BackColor = System.Drawing.Color.Transparent
        Me.lblDesignation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CredentialsBindingSource, "Designation", True))
        Me.lblDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignation.Location = New System.Drawing.Point(30, 221)
        Me.lblDesignation.Name = "lblDesignation"
        Me.lblDesignation.Size = New System.Drawing.Size(168, 18)
        Me.lblDesignation.TabIndex = 3
        Me.lblDesignation.Text = "Designation"
        '
        'lblCourseTitle
        '
        Me.lblCourseTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CredentialsBindingSource, "ExamCourseTitle", True))
        Me.lblCourseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseTitle.Location = New System.Drawing.Point(30, 246)
        Me.lblCourseTitle.Name = "lblCourseTitle"
        Me.lblCourseTitle.Size = New System.Drawing.Size(168, 18)
        Me.lblCourseTitle.TabIndex = 3
        Me.lblCourseTitle.Text = "Course"
        '
        'lblCourseCode
        '
        Me.lblCourseCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CredentialsBindingSource, "ExamCourseCode", True))
        Me.lblCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseCode.Location = New System.Drawing.Point(30, 271)
        Me.lblCourseCode.Name = "lblCourseCode"
        Me.lblCourseCode.Size = New System.Drawing.Size(168, 18)
        Me.lblCourseCode.TabIndex = 3
        Me.lblCourseCode.Text = "Course Code"
        '
        'bttnProceed
        '
        Me.bttnProceed.Location = New System.Drawing.Point(181, 356)
        Me.bttnProceed.Name = "bttnProceed"
        Me.bttnProceed.Size = New System.Drawing.Size(97, 33)
        Me.bttnProceed.TabIndex = 4
        Me.bttnProceed.Text = "Proceed"
        Me.bttnProceed.UseVisualStyleBackColor = True
        '
        'picboxPassport
        '
        Me.picboxPassport.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CredentialsBindingSource, "Passport", True))
        Me.picboxPassport.ErrorImage = CType(resources.GetObject("picboxPassport.ErrorImage"), System.Drawing.Image)
        Me.picboxPassport.Image = CType(resources.GetObject("picboxPassport.Image"), System.Drawing.Image)
        Me.picboxPassport.Location = New System.Drawing.Point(204, 171)
        Me.picboxPassport.Name = "picboxPassport"
        Me.picboxPassport.Size = New System.Drawing.Size(94, 101)
        Me.picboxPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPassport.TabIndex = 5
        Me.picboxPassport.TabStop = False
        '
        'lblExamCenter
        '
        Me.lblExamCenter.BackColor = System.Drawing.Color.Transparent
        Me.lblExamCenter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "Exam Center", True))
        Me.lblExamCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamCenter.Location = New System.Drawing.Point(30, 296)
        Me.lblExamCenter.Name = "lblExamCenter"
        Me.lblExamCenter.Size = New System.Drawing.Size(256, 18)
        Me.lblExamCenter.TabIndex = 3
        Me.lblExamCenter.Text = "Exam Center"
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DataDataSet
        '
        'lblNotYou
        '
        Me.lblNotYou.BackColor = System.Drawing.Color.Transparent
        Me.lblNotYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotYou.Location = New System.Drawing.Point(30, 377)
        Me.lblNotYou.Name = "lblNotYou"
        Me.lblNotYou.Size = New System.Drawing.Size(60, 18)
        Me.lblNotYou.TabIndex = 3
        Me.lblNotYou.Text = "Not You?"
        '
        'txtNo_Of_Questions
        '
        Me.txtNo_Of_Questions.BackColor = System.Drawing.Color.Transparent
        Me.txtNo_Of_Questions.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "NumberOfQuestions", True))
        Me.txtNo_Of_Questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo_Of_Questions.Location = New System.Drawing.Point(201, 242)
        Me.txtNo_Of_Questions.Name = "txtNo_Of_Questions"
        Me.txtNo_Of_Questions.Size = New System.Drawing.Size(77, 18)
        Me.txtNo_Of_Questions.TabIndex = 3
        Me.txtNo_Of_Questions.Text = "Questions"
        '
        'lblTimeAllowed
        '
        Me.lblTimeAllowed.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeAllowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeAllowed.Location = New System.Drawing.Point(30, 344)
        Me.lblTimeAllowed.Name = "lblTimeAllowed"
        Me.lblTimeAllowed.Size = New System.Drawing.Size(153, 18)
        Me.lblTimeAllowed.TabIndex = 3
        Me.lblTimeAllowed.Text = "Time:"
        '
        'CredentialsTableAdapter
        '
        Me.CredentialsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CredentialsTableAdapter = Me.CredentialsTableAdapter
        Me.TableAdapterManager.ExamsTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CredentialsBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(219, 172)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(59, 20)
        Me.SurnameTextBox.TabIndex = 12
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CredentialsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(227, 219)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(59, 20)
        Me.FirstNameTextBox.TabIndex = 14
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'TimeAllowedTextBox
        '
        Me.TimeAllowedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "TimeAllowed", True))
        Me.TimeAllowedTextBox.Location = New System.Drawing.Point(216, 219)
        Me.TimeAllowedTextBox.Name = "TimeAllowedTextBox"
        Me.TimeAllowedTextBox.Size = New System.Drawing.Size(40, 20)
        Me.TimeAllowedTextBox.TabIndex = 15
        '
        'RegistrationNumberToolStrip
        '
        Me.RegistrationNumberToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationNumberToolStripLabel, Me.RegistrationNumberToolStripTextBox, Me.RegistrationNumberToolStripButton})
        Me.RegistrationNumberToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.RegistrationNumberToolStrip.Name = "RegistrationNumberToolStrip"
        Me.RegistrationNumberToolStrip.Size = New System.Drawing.Size(319, 25)
        Me.RegistrationNumberToolStrip.TabIndex = 16
        Me.RegistrationNumberToolStrip.Text = "RegistrationNumberToolStrip"
        Me.RegistrationNumberToolStrip.Visible = False
        '
        'RegistrationNumberToolStripLabel
        '
        Me.RegistrationNumberToolStripLabel.Name = "RegistrationNumberToolStripLabel"
        Me.RegistrationNumberToolStripLabel.Size = New System.Drawing.Size(117, 22)
        Me.RegistrationNumberToolStripLabel.Text = "RegistrationNumber:"
        '
        'RegistrationNumberToolStripTextBox
        '
        Me.RegistrationNumberToolStripTextBox.Name = "RegistrationNumberToolStripTextBox"
        Me.RegistrationNumberToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'RegistrationNumberToolStripButton
        '
        Me.RegistrationNumberToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RegistrationNumberToolStripButton.Name = "RegistrationNumberToolStripButton"
        Me.RegistrationNumberToolStripButton.Size = New System.Drawing.Size(118, 19)
        Me.RegistrationNumberToolStripButton.Text = "RegistrationNumber"
        '
        'txtRegistrationNumber
        '
        Me.txtRegistrationNumber.Location = New System.Drawing.Point(216, 194)
        Me.txtRegistrationNumber.Name = "txtRegistrationNumber"
        Me.txtRegistrationNumber.Size = New System.Drawing.Size(29, 20)
        Me.txtRegistrationNumber.TabIndex = 17
        '
        'lblNo_Of_Questions
        '
        Me.lblNo_Of_Questions.BackColor = System.Drawing.Color.Transparent
        Me.lblNo_Of_Questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo_Of_Questions.Location = New System.Drawing.Point(30, 321)
        Me.lblNo_Of_Questions.Name = "lblNo_Of_Questions"
        Me.lblNo_Of_Questions.Size = New System.Drawing.Size(153, 18)
        Me.lblNo_Of_Questions.TabIndex = 3
        Me.lblNo_Of_Questions.Text = "Questions"
        '
        'frmConfirmation
        '
        Me.AcceptButton = Me.bttnProceed
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Invasion_Systems_Computer_Based_Objective_Test.My.Resources.Resources.CBOT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(319, 445)
        Me.Controls.Add(Me.picboxPassport)
        Me.Controls.Add(Me.txtRegistrationNumber)
        Me.Controls.Add(Me.RegistrationNumberToolStrip)
        Me.Controls.Add(Me.TimeAllowedTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(Me.bttnProceed)
        Me.Controls.Add(Me.lblNotYou)
        Me.Controls.Add(Me.lblTimeAllowed)
        Me.Controls.Add(Me.lblNo_Of_Questions)
        Me.Controls.Add(Me.txtNo_Of_Questions)
        Me.Controls.Add(Me.lblExamCenter)
        Me.Controls.Add(Me.lblCourseCode)
        Me.Controls.Add(Me.lblCourseTitle)
        Me.Controls.Add(Me.lblDesignation)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblRegistrationNumber)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credential Confirmation - Invasion Systems CBOT"
        CType(Me.CredentialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPassport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrationNumberToolStrip.ResumeLayout(False)
        Me.RegistrationNumberToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegistrationNumber As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDesignation As System.Windows.Forms.Label
    Friend WithEvents lblCourseTitle As System.Windows.Forms.Label
    Friend WithEvents lblCourseCode As System.Windows.Forms.Label
    Friend WithEvents bttnProceed As System.Windows.Forms.Button
    Friend WithEvents picboxPassport As System.Windows.Forms.PictureBox
    Friend WithEvents lblExamCenter As System.Windows.Forms.Label
    Friend WithEvents lblNotYou As System.Windows.Forms.Label
    Friend WithEvents txtNo_Of_Questions As System.Windows.Forms.Label
    Friend WithEvents lblTimeAllowed As System.Windows.Forms.Label
    Friend WithEvents DataDataSet As Invasion_Systems_Computer_Based_Objective_Test.dataDataSet
    Friend WithEvents CredentialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CredentialsTableAdapter As Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.CredentialsTableAdapter
    Friend WithEvents TableAdapterManager As Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents TimeAllowedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistrationNumberToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents RegistrationNumberToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RegistrationNumberToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RegistrationNumberToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtRegistrationNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblNo_Of_Questions As System.Windows.Forms.Label
End Class
