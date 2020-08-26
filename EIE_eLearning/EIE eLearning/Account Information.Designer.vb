<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountInformation
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
        Dim SecurityAnswerLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim OtherNamesLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim MatricNumberLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim SecurityQuestionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountInformation))
        Me.UserData_DataSet = New EIE_eLearning.UserData_DataSet()
        Me.UserDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataTableAdapter = New EIE_eLearning.UserData_DataSetTableAdapters.UserDataTableAdapter()
        Me.TableAdapterManager = New EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager()
        Me.AccountInfoGroup = New System.Windows.Forms.GroupBox()
        Me.SecurityQuestionTextBox = New System.Windows.Forms.TextBox()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.UserDetailGroup = New System.Windows.Forms.GroupBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.LevelTextBox = New System.Windows.Forms.TextBox()
        Me.ProgramTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtOtherNames = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtMatricNumber = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UserDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        SecurityAnswerLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        OtherNamesLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        MatricNumberLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        SecurityQuestionLabel = New System.Windows.Forms.Label()
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccountInfoGroup.SuspendLayout()
        Me.UserDetailGroup.SuspendLayout()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SecurityAnswerLabel
        '
        SecurityAnswerLabel.AutoSize = True
        SecurityAnswerLabel.Location = New System.Drawing.Point(17, 72)
        SecurityAnswerLabel.Name = "SecurityAnswerLabel"
        SecurityAnswerLabel.Size = New System.Drawing.Size(86, 13)
        SecurityAnswerLabel.TabIndex = 15
        SecurityAnswerLabel.Text = "Security Answer:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(47, 20)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "Password:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(54, 204)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email:"
        '
        'OtherNamesLabel
        '
        OtherNamesLabel.AutoSize = True
        OtherNamesLabel.Location = New System.Drawing.Point(17, 75)
        OtherNamesLabel.Name = "OtherNamesLabel"
        OtherNamesLabel.Size = New System.Drawing.Size(72, 13)
        OtherNamesLabel.TabIndex = 4
        OtherNamesLabel.Text = "Other Names:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(37, 49)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 2
        SurnameLabel.Text = "Surname:"
        '
        'MatricNumberLabel
        '
        MatricNumberLabel.AutoSize = True
        MatricNumberLabel.Location = New System.Drawing.Point(10, 23)
        MatricNumberLabel.Name = "MatricNumberLabel"
        MatricNumberLabel.Size = New System.Drawing.Size(79, 13)
        MatricNumberLabel.TabIndex = 0
        MatricNumberLabel.Text = "Matric Number:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(24, 126)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 14
        DepartmentLabel.Text = "Department:"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(40, 152)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(49, 13)
        ProgramLabel.TabIndex = 15
        ProgramLabel.Text = "Program:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(53, 178)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(36, 13)
        LevelLabel.TabIndex = 16
        LevelLabel.Text = "Level:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(44, 101)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 17
        GenderLabel.Text = "Gender:"
        '
        'SecurityQuestionLabel
        '
        SecurityQuestionLabel.AutoSize = True
        SecurityQuestionLabel.Location = New System.Drawing.Point(10, 46)
        SecurityQuestionLabel.Name = "SecurityQuestionLabel"
        SecurityQuestionLabel.Size = New System.Drawing.Size(93, 13)
        SecurityQuestionLabel.TabIndex = 15
        SecurityQuestionLabel.Text = "Security Question:"
        '
        'UserData_DataSet
        '
        Me.UserData_DataSet.DataSetName = "UserData_DataSet"
        Me.UserData_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserDataBindingSource
        '
        Me.UserDataBindingSource.DataMember = "UserData"
        Me.UserDataBindingSource.DataSource = Me.UserData_DataSet
        '
        'UserDataTableAdapter
        '
        Me.UserDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatalogTableAdapter = Nothing
        Me.TableAdapterManager.CoursesTableAdapter = Nothing
        Me.TableAdapterManager.GradesTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserDataTableAdapter = Me.UserDataTableAdapter
        '
        'AccountInfoGroup
        '
        Me.AccountInfoGroup.Controls.Add(SecurityQuestionLabel)
        Me.AccountInfoGroup.Controls.Add(Me.SecurityQuestionTextBox)
        Me.AccountInfoGroup.Controls.Add(SecurityAnswerLabel)
        Me.AccountInfoGroup.Controls.Add(Me.txtSecurityAnswer)
        Me.AccountInfoGroup.Controls.Add(PasswordLabel)
        Me.AccountInfoGroup.Controls.Add(Me.txtPassword)
        Me.AccountInfoGroup.Location = New System.Drawing.Point(9, 280)
        Me.AccountInfoGroup.Name = "AccountInfoGroup"
        Me.AccountInfoGroup.Size = New System.Drawing.Size(320, 106)
        Me.AccountInfoGroup.TabIndex = 5
        Me.AccountInfoGroup.TabStop = False
        Me.AccountInfoGroup.Text = "Account Information"
        '
        'SecurityQuestionTextBox
        '
        Me.SecurityQuestionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "SecurityQuestion", True))
        Me.SecurityQuestionTextBox.Location = New System.Drawing.Point(109, 43)
        Me.SecurityQuestionTextBox.Name = "SecurityQuestionTextBox"
        Me.SecurityQuestionTextBox.ReadOnly = True
        Me.SecurityQuestionTextBox.Size = New System.Drawing.Size(188, 20)
        Me.SecurityQuestionTextBox.TabIndex = 16
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "SecurityAnswer", True))
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(109, 69)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.ReadOnly = True
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(188, 20)
        Me.txtSecurityAnswer.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(109, 17)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtPassword.TabIndex = 10
        '
        'UserDetailGroup
        '
        Me.UserDetailGroup.Controls.Add(GenderLabel)
        Me.UserDetailGroup.Controls.Add(Me.GenderTextBox)
        Me.UserDetailGroup.Controls.Add(LevelLabel)
        Me.UserDetailGroup.Controls.Add(Me.LevelTextBox)
        Me.UserDetailGroup.Controls.Add(ProgramLabel)
        Me.UserDetailGroup.Controls.Add(Me.ProgramTextBox)
        Me.UserDetailGroup.Controls.Add(DepartmentLabel)
        Me.UserDetailGroup.Controls.Add(Me.DepartmentTextBox)
        Me.UserDetailGroup.Controls.Add(EmailLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtEmail)
        Me.UserDetailGroup.Controls.Add(OtherNamesLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtOtherNames)
        Me.UserDetailGroup.Controls.Add(SurnameLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtSurname)
        Me.UserDetailGroup.Controls.Add(MatricNumberLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtMatricNumber)
        Me.UserDetailGroup.Location = New System.Drawing.Point(12, 40)
        Me.UserDetailGroup.Name = "UserDetailGroup"
        Me.UserDetailGroup.Size = New System.Drawing.Size(317, 234)
        Me.UserDetailGroup.TabIndex = 4
        Me.UserDetailGroup.TabStop = False
        Me.UserDetailGroup.Text = "User Details"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(95, 98)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.ReadOnly = True
        Me.GenderTextBox.Size = New System.Drawing.Size(202, 20)
        Me.GenderTextBox.TabIndex = 18
        '
        'LevelTextBox
        '
        Me.LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Level", True))
        Me.LevelTextBox.Location = New System.Drawing.Point(95, 175)
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.ReadOnly = True
        Me.LevelTextBox.Size = New System.Drawing.Size(202, 20)
        Me.LevelTextBox.TabIndex = 17
        '
        'ProgramTextBox
        '
        Me.ProgramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Program", True))
        Me.ProgramTextBox.Location = New System.Drawing.Point(95, 149)
        Me.ProgramTextBox.Name = "ProgramTextBox"
        Me.ProgramTextBox.ReadOnly = True
        Me.ProgramTextBox.Size = New System.Drawing.Size(202, 20)
        Me.ProgramTextBox.TabIndex = 16
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(95, 123)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.ReadOnly = True
        Me.DepartmentTextBox.Size = New System.Drawing.Size(202, 20)
        Me.DepartmentTextBox.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(95, 201)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(202, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtOtherNames
        '
        Me.txtOtherNames.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "OtherNames", True))
        Me.txtOtherNames.Location = New System.Drawing.Point(95, 72)
        Me.txtOtherNames.Name = "txtOtherNames"
        Me.txtOtherNames.ReadOnly = True
        Me.txtOtherNames.Size = New System.Drawing.Size(202, 20)
        Me.txtOtherNames.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Surname", True))
        Me.txtSurname.Location = New System.Drawing.Point(95, 46)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(202, 20)
        Me.txtSurname.TabIndex = 2
        '
        'txtMatricNumber
        '
        Me.txtMatricNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "MatricNumber", True))
        Me.txtMatricNumber.Location = New System.Drawing.Point(95, 20)
        Me.txtMatricNumber.Name = "txtMatricNumber"
        Me.txtMatricNumber.ReadOnly = True
        Me.txtMatricNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtMatricNumber.TabIndex = 1
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UserDataBindingNavigatorSaveItem
        '
        Me.UserDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserDataBindingNavigatorSaveItem.Name = "UserDataBindingNavigatorSaveItem"
        Me.UserDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserDataBindingNavigator
        '
        Me.UserDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserDataBindingNavigator.BindingSource = Me.UserDataBindingSource
        Me.UserDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserDataBindingNavigatorSaveItem})
        Me.UserDataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserDataBindingNavigator.Name = "UserDataBindingNavigator"
        Me.UserDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserDataBindingNavigator.Size = New System.Drawing.Size(345, 25)
        Me.UserDataBindingNavigator.TabIndex = 0
        Me.UserDataBindingNavigator.Text = "BindingNavigator1"
        '
        'frmAccountInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 397)
        Me.Controls.Add(Me.AccountInfoGroup)
        Me.Controls.Add(Me.UserDetailGroup)
        Me.Controls.Add(Me.UserDataBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountInformation"
        Me.Text = "Account Information"
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccountInfoGroup.ResumeLayout(False)
        Me.AccountInfoGroup.PerformLayout()
        Me.UserDetailGroup.ResumeLayout(False)
        Me.UserDetailGroup.PerformLayout()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataBindingNavigator.ResumeLayout(False)
        Me.UserDataBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserData_DataSet As EIE_eLearning.UserData_DataSet
    Friend WithEvents UserDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserDataTableAdapter As EIE_eLearning.UserData_DataSetTableAdapters.UserDataTableAdapter
    Friend WithEvents TableAdapterManager As EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountInfoGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecurityAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents UserDetailGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherNames As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricNumber As System.Windows.Forms.TextBox
    Friend WithEvents SecurityQuestionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgramTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserDataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserDataBindingNavigator As System.Windows.Forms.BindingNavigator
End Class
