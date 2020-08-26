<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Dim MatricNumberLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim OtherNamesLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim txtUsername As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim lblretype As System.Windows.Forms.Label
        Dim SecurityQuestionLabel As System.Windows.Forms.Label
        Dim SecurityAnswerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.UserData_DataSet = New EIE_eLearning.UserData_DataSet()
        Me.UserDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataTableAdapter = New EIE_eLearning.UserData_DataSetTableAdapters.UserDataTableAdapter()
        Me.TableAdapterManager = New EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager()
        Me.UserDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDetailGroup = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtOtherNames = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtMatricNumber = New System.Windows.Forms.TextBox()
        Me.AccountInfoGroup = New System.Windows.Forms.GroupBox()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.cboSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.txtRetypePassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.GroupboxAction = New System.Windows.Forms.GroupBox()
        Me.bttnReset = New System.Windows.Forms.Button()
        Me.bttnRegister = New System.Windows.Forms.Button()
        MatricNumberLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        OtherNamesLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        txtUsername = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        lblretype = New System.Windows.Forms.Label()
        SecurityQuestionLabel = New System.Windows.Forms.Label()
        SecurityAnswerLabel = New System.Windows.Forms.Label()
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataBindingNavigator.SuspendLayout()
        CType(Me.UserDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDetailGroup.SuspendLayout()
        Me.AccountInfoGroup.SuspendLayout()
        Me.GroupboxAction.SuspendLayout()
        Me.SuspendLayout()
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
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(37, 49)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 2
        SurnameLabel.Text = "Surname:"
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
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(44, 101)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(24, 128)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        DepartmentLabel.TabIndex = 8
        DepartmentLabel.Text = "Department:"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Location = New System.Drawing.Point(40, 155)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(49, 13)
        ProgramLabel.TabIndex = 10
        ProgramLabel.Text = "Program:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(53, 182)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(36, 13)
        LevelLabel.TabIndex = 12
        LevelLabel.Text = "Level:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(54, 209)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email:"
        '
        'txtUsername
        '
        txtUsername.AutoSize = True
        txtUsername.Location = New System.Drawing.Point(45, 18)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New System.Drawing.Size(58, 13)
        txtUsername.TabIndex = 10
        txtUsername.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(46, 44)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "Password:"
        '
        'lblretype
        '
        lblretype.AutoSize = True
        lblretype.Location = New System.Drawing.Point(8, 70)
        lblretype.Name = "lblretype"
        lblretype.Size = New System.Drawing.Size(93, 13)
        lblretype.TabIndex = 13
        lblretype.Text = "Retype Password:"
        '
        'SecurityQuestionLabel
        '
        SecurityQuestionLabel.AutoSize = True
        SecurityQuestionLabel.Location = New System.Drawing.Point(9, 96)
        SecurityQuestionLabel.Name = "SecurityQuestionLabel"
        SecurityQuestionLabel.Size = New System.Drawing.Size(93, 13)
        SecurityQuestionLabel.TabIndex = 14
        SecurityQuestionLabel.Text = "Security Question:"
        '
        'SecurityAnswerLabel
        '
        SecurityAnswerLabel.AutoSize = True
        SecurityAnswerLabel.Location = New System.Drawing.Point(16, 123)
        SecurityAnswerLabel.Name = "SecurityAnswerLabel"
        SecurityAnswerLabel.Size = New System.Drawing.Size(86, 13)
        SecurityAnswerLabel.TabIndex = 15
        SecurityAnswerLabel.Text = "Security Answer:"
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
        Me.UserDataBindingNavigator.Size = New System.Drawing.Size(646, 25)
        Me.UserDataBindingNavigator.TabIndex = 0
        Me.UserDataBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'UserDataBindingNavigatorSaveItem
        '
        Me.UserDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserDataBindingNavigatorSaveItem.Name = "UserDataBindingNavigatorSaveItem"
        Me.UserDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserDataDataGridView
        '
        Me.UserDataDataGridView.AutoGenerateColumns = False
        Me.UserDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.UserDataDataGridView.DataSource = Me.UserDataBindingSource
        Me.UserDataDataGridView.Location = New System.Drawing.Point(12, 273)
        Me.UserDataDataGridView.Name = "UserDataDataGridView"
        Me.UserDataDataGridView.Size = New System.Drawing.Size(623, 228)
        Me.UserDataDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OtherNames"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OtherNames"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MatricNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MatricNumber"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Program"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Level"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SecurityQuestion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SecurityQuestion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SecurityAnswer"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SecurityAnswer"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'UserDetailGroup
        '
        Me.UserDetailGroup.Controls.Add(EmailLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtEmail)
        Me.UserDetailGroup.Controls.Add(LevelLabel)
        Me.UserDetailGroup.Controls.Add(Me.cboLevel)
        Me.UserDetailGroup.Controls.Add(ProgramLabel)
        Me.UserDetailGroup.Controls.Add(Me.cboProgram)
        Me.UserDetailGroup.Controls.Add(DepartmentLabel)
        Me.UserDetailGroup.Controls.Add(Me.cboDepartment)
        Me.UserDetailGroup.Controls.Add(GenderLabel)
        Me.UserDetailGroup.Controls.Add(Me.cboGender)
        Me.UserDetailGroup.Controls.Add(OtherNamesLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtOtherNames)
        Me.UserDetailGroup.Controls.Add(SurnameLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtSurname)
        Me.UserDetailGroup.Controls.Add(MatricNumberLabel)
        Me.UserDetailGroup.Controls.Add(Me.txtMatricNumber)
        Me.UserDetailGroup.Location = New System.Drawing.Point(12, 28)
        Me.UserDetailGroup.Name = "UserDetailGroup"
        Me.UserDetailGroup.Size = New System.Drawing.Size(309, 239)
        Me.UserDetailGroup.TabIndex = 2
        Me.UserDetailGroup.TabStop = False
        Me.UserDetailGroup.Text = "User Details"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(95, 206)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 20)
        Me.txtEmail.TabIndex = 8
        '
        'cboLevel
        '
        Me.cboLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Level", True))
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"", "100", "200", "300", "400", "500"})
        Me.cboLevel.Location = New System.Drawing.Point(95, 179)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(202, 21)
        Me.cboLevel.TabIndex = 7
        '
        'cboProgram
        '
        Me.cboProgram.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Program", True))
        Me.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Items.AddRange(New Object() {"", "Computer Engineering", "Electrical Electronics Engineering", "Information Communication Technology"})
        Me.cboProgram.Location = New System.Drawing.Point(95, 152)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(202, 21)
        Me.cboProgram.TabIndex = 6
        '
        'cboDepartment
        '
        Me.cboDepartment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Department", True))
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"", "Electrical And Informations Engineering"})
        Me.cboDepartment.Location = New System.Drawing.Point(95, 125)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(202, 21)
        Me.cboDepartment.TabIndex = 5
        '
        'cboGender
        '
        Me.cboGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Gender", True))
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(95, 98)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(202, 21)
        Me.cboGender.TabIndex = 4
        '
        'txtOtherNames
        '
        Me.txtOtherNames.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "OtherNames", True))
        Me.txtOtherNames.Location = New System.Drawing.Point(95, 72)
        Me.txtOtherNames.Name = "txtOtherNames"
        Me.txtOtherNames.Size = New System.Drawing.Size(202, 20)
        Me.txtOtherNames.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Surname", True))
        Me.txtSurname.Location = New System.Drawing.Point(95, 46)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(202, 20)
        Me.txtSurname.TabIndex = 2
        '
        'txtMatricNumber
        '
        Me.txtMatricNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "MatricNumber", True))
        Me.txtMatricNumber.Location = New System.Drawing.Point(95, 20)
        Me.txtMatricNumber.Name = "txtMatricNumber"
        Me.txtMatricNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtMatricNumber.TabIndex = 1
        '
        'AccountInfoGroup
        '
        Me.AccountInfoGroup.Controls.Add(SecurityAnswerLabel)
        Me.AccountInfoGroup.Controls.Add(Me.txtSecurityAnswer)
        Me.AccountInfoGroup.Controls.Add(SecurityQuestionLabel)
        Me.AccountInfoGroup.Controls.Add(Me.cboSecurityQuestion)
        Me.AccountInfoGroup.Controls.Add(Me.txtRetypePassword)
        Me.AccountInfoGroup.Controls.Add(lblretype)
        Me.AccountInfoGroup.Controls.Add(PasswordLabel)
        Me.AccountInfoGroup.Controls.Add(Me.txtPassword)
        Me.AccountInfoGroup.Controls.Add(Me.lblUsername)
        Me.AccountInfoGroup.Controls.Add(txtUsername)
        Me.AccountInfoGroup.Location = New System.Drawing.Point(327, 28)
        Me.AccountInfoGroup.Name = "AccountInfoGroup"
        Me.AccountInfoGroup.Size = New System.Drawing.Size(308, 158)
        Me.AccountInfoGroup.TabIndex = 3
        Me.AccountInfoGroup.TabStop = False
        Me.AccountInfoGroup.Text = "Account Information"
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "SecurityAnswer", True))
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(108, 120)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(188, 20)
        Me.txtSecurityAnswer.TabIndex = 13
        '
        'cboSecurityQuestion
        '
        Me.cboSecurityQuestion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "SecurityQuestion", True))
        Me.cboSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecurityQuestion.FormattingEnabled = True
        Me.cboSecurityQuestion.Items.AddRange(New Object() {"", "Who is your best Lecturer", "What is your Best Course", "When was your Best Semester", "What was your higest Score"})
        Me.cboSecurityQuestion.Location = New System.Drawing.Point(108, 93)
        Me.cboSecurityQuestion.Name = "cboSecurityQuestion"
        Me.cboSecurityQuestion.Size = New System.Drawing.Size(188, 21)
        Me.cboSecurityQuestion.TabIndex = 12
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Location = New System.Drawing.Point(108, 67)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.Size = New System.Drawing.Size(188, 20)
        Me.txtRetypePassword.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(108, 41)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtPassword.TabIndex = 10
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Location = New System.Drawing.Point(108, 16)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(188, 20)
        Me.lblUsername.TabIndex = 9
        '
        'GroupboxAction
        '
        Me.GroupboxAction.Controls.Add(Me.bttnReset)
        Me.GroupboxAction.Controls.Add(Me.bttnRegister)
        Me.GroupboxAction.Location = New System.Drawing.Point(327, 186)
        Me.GroupboxAction.Name = "GroupboxAction"
        Me.GroupboxAction.Size = New System.Drawing.Size(308, 75)
        Me.GroupboxAction.TabIndex = 12
        Me.GroupboxAction.TabStop = False
        '
        'bttnReset
        '
        Me.bttnReset.Location = New System.Drawing.Point(166, 19)
        Me.bttnReset.Name = "bttnReset"
        Me.bttnReset.Size = New System.Drawing.Size(94, 40)
        Me.bttnReset.TabIndex = 15
        Me.bttnReset.Text = "Reset"
        Me.bttnReset.UseVisualStyleBackColor = True
        '
        'bttnRegister
        '
        Me.bttnRegister.Location = New System.Drawing.Point(52, 19)
        Me.bttnRegister.Name = "bttnRegister"
        Me.bttnRegister.Size = New System.Drawing.Size(94, 40)
        Me.bttnRegister.TabIndex = 14
        Me.bttnRegister.Text = "Register"
        Me.bttnRegister.UseVisualStyleBackColor = True
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 539)
        Me.Controls.Add(Me.GroupboxAction)
        Me.Controls.Add(Me.AccountInfoGroup)
        Me.Controls.Add(Me.UserDetailGroup)
        Me.Controls.Add(Me.UserDataDataGridView)
        Me.Controls.Add(Me.UserDataBindingNavigator)
        Me.Name = "frmRegistration"
        Me.Text = "Reg"
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataBindingNavigator.ResumeLayout(False)
        Me.UserDataBindingNavigator.PerformLayout()
        CType(Me.UserDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDetailGroup.ResumeLayout(False)
        Me.UserDetailGroup.PerformLayout()
        Me.AccountInfoGroup.ResumeLayout(False)
        Me.AccountInfoGroup.PerformLayout()
        Me.GroupboxAction.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserData_DataSet As EIE_eLearning.UserData_DataSet
    Friend WithEvents UserDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserDataTableAdapter As EIE_eLearning.UserData_DataSetTableAdapters.UserDataTableAdapter
    Friend WithEvents TableAdapterManager As EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserDataBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserDataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserDetailGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtOtherNames As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents cboProgram As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents AccountInfoGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtRetypePassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSecurityAnswer As System.Windows.Forms.TextBox
    Friend WithEvents cboSecurityQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupboxAction As System.Windows.Forms.GroupBox
    Friend WithEvents bttnReset As System.Windows.Forms.Button
    Friend WithEvents bttnRegister As System.Windows.Forms.Button
End Class
