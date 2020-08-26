<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsole
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
        Dim RegistrationNumberLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim ClearanceLevelLabel As System.Windows.Forms.Label
        Dim ApplicationNameLabel As System.Windows.Forms.Label
        Dim ProcessNameLabel As System.Windows.Forms.Label
        Dim ApplicationPathLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim lblLevel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsole))
        Me.bttnInclude = New System.Windows.Forms.Button()
        Me.bttnRefreshQueue = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnRemoveAll = New System.Windows.Forms.Button()
        Me.bttnRemove = New System.Windows.Forms.Button()
        Me.txtProcess = New System.Windows.Forms.TextBox()
        Me.lstProcessQueue = New System.Windows.Forms.ListBox()
        Me.LevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClevelDataSet = New AuthGuard.clevelDataSet()
        Me.lstProcesses = New System.Windows.Forms.ListBox()
        Me.bttnKillSelected = New System.Windows.Forms.Button()
        Me.bttnUpdateProcessList = New System.Windows.Forms.Button()
        Me.bttnKill = New System.Windows.Forms.Button()
        Me.lblProcessCount = New System.Windows.Forms.Label()
        Me.grpboxProcesses = New System.Windows.Forms.GroupBox()
        Me.grpboxControl = New System.Windows.Forms.GroupBox()
        Me.bttnViewLog = New System.Windows.Forms.Button()
        Me.bttnExit = New System.Windows.Forms.Button()
        Me.bttnEnableGuard = New System.Windows.Forms.Button()
        Me.bttnDisableGuard = New System.Windows.Forms.Button()
        Me.lstProc = New System.Windows.Forms.ListBox()
        Me.grpboxUserInformation = New System.Windows.Forms.GroupBox()
        Me.UserDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UserDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthDataSet = New AuthGuard.authDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClearanceLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PassportPictureBox = New System.Windows.Forms.PictureBox()
        Me.RegistrationNumberTextBox = New System.Windows.Forms.TextBox()
        Me.grpboxSecurityLevel = New System.Windows.Forms.GroupBox()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.UserDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.UserDataTableAdapter = New AuthGuard.authDataSetTableAdapters.UserDataTableAdapter()
        Me.TableAdapterManager = New AuthGuard.authDataSetTableAdapters.TableAdapterManager()
        Me.grpProcesses = New System.Windows.Forms.GroupBox()
        Me.CLevelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.lblLevell = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.ApplicationPathTextBox = New System.Windows.Forms.TextBox()
        Me.ProcessNameTextBox = New System.Windows.Forms.TextBox()
        Me.ApplicationNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProcessDataGrid = New System.Windows.Forms.DataGridView()
        Me.ProcessNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._0TableAdapter = New AuthGuard.clevelDataSetTableAdapters._0TableAdapter()
        Me._1TableAdapter = New AuthGuard.clevelDataSetTableAdapters._1TableAdapter()
        Me._2TableAdapter = New AuthGuard.clevelDataSetTableAdapters._2TableAdapter()
        Me._3TableAdapter = New AuthGuard.clevelDataSetTableAdapters._3TableAdapter()
        Me._4TableAdapter = New AuthGuard.clevelDataSetTableAdapters._4TableAdapter()
        Me._5TableAdapter = New AuthGuard.clevelDataSetTableAdapters._5TableAdapter()
        Me._6TableAdapter = New AuthGuard.clevelDataSetTableAdapters._6TableAdapter()
        Me._7TableAdapter = New AuthGuard.clevelDataSetTableAdapters._7TableAdapter()
        Me.LevelTableAdapterManager = New AuthGuard.clevelDataSetTableAdapters.TableAdapterManager()
        Me.ClevelDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutoKillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        RegistrationNumberLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        ClearanceLevelLabel = New System.Windows.Forms.Label()
        ApplicationNameLabel = New System.Windows.Forms.Label()
        ProcessNameLabel = New System.Windows.Forms.Label()
        ApplicationPathLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        lblLevel = New System.Windows.Forms.Label()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxProcesses.SuspendLayout()
        Me.grpboxControl.SuspendLayout()
        Me.grpboxUserInformation.SuspendLayout()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataBindingNavigator.SuspendLayout()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxSecurityLevel.SuspendLayout()
        CType(Me.UserDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProcesses.SuspendLayout()
        CType(Me.CLevelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CLevelBindingNavigator.SuspendLayout()
        CType(Me.ProcessDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClevelDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistrationNumberLabel
        '
        RegistrationNumberLabel.AutoSize = True
        RegistrationNumberLabel.Location = New System.Drawing.Point(19, 22)
        RegistrationNumberLabel.Name = "RegistrationNumberLabel"
        RegistrationNumberLabel.Size = New System.Drawing.Size(106, 13)
        RegistrationNumberLabel.TabIndex = 0
        RegistrationNumberLabel.Text = "Registration Number:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(69, 100)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(70, 126)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(73, 48)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 7
        SurnameLabel.Text = "Surname:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(65, 74)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 9
        FirstNameLabel.Text = "First Name:"
        '
        'ClearanceLevelLabel
        '
        ClearanceLevelLabel.AutoSize = True
        ClearanceLevelLabel.Location = New System.Drawing.Point(38, 152)
        ClearanceLevelLabel.Name = "ClearanceLevelLabel"
        ClearanceLevelLabel.Size = New System.Drawing.Size(87, 13)
        ClearanceLevelLabel.TabIndex = 11
        ClearanceLevelLabel.Text = "Clearance Level:"
        '
        'ApplicationNameLabel
        '
        ApplicationNameLabel.AutoSize = True
        ApplicationNameLabel.Location = New System.Drawing.Point(252, 44)
        ApplicationNameLabel.Name = "ApplicationNameLabel"
        ApplicationNameLabel.Size = New System.Drawing.Size(93, 13)
        ApplicationNameLabel.TabIndex = 2
        ApplicationNameLabel.Text = "Application Name:"
        '
        'ProcessNameLabel
        '
        ProcessNameLabel.AutoSize = True
        ProcessNameLabel.Location = New System.Drawing.Point(266, 68)
        ProcessNameLabel.Name = "ProcessNameLabel"
        ProcessNameLabel.Size = New System.Drawing.Size(79, 13)
        ProcessNameLabel.TabIndex = 4
        ProcessNameLabel.Text = "Process Name:"
        '
        'ApplicationPathLabel
        '
        ApplicationPathLabel.AutoSize = True
        ApplicationPathLabel.Location = New System.Drawing.Point(258, 92)
        ApplicationPathLabel.Name = "ApplicationPathLabel"
        ApplicationPathLabel.Size = New System.Drawing.Size(87, 13)
        ApplicationPathLabel.TabIndex = 6
        ApplicationPathLabel.Text = "Application Path:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(282, 117)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 8
        DescriptionLabel.Text = "Description:"
        '
        'lblLevel
        '
        lblLevel.AutoSize = True
        lblLevel.Location = New System.Drawing.Point(309, 20)
        lblLevel.Name = "lblLevel"
        lblLevel.Size = New System.Drawing.Size(36, 13)
        lblLevel.TabIndex = 2
        lblLevel.Text = "Level:"
        '
        'bttnInclude
        '
        Me.bttnInclude.Location = New System.Drawing.Point(533, 18)
        Me.bttnInclude.Name = "bttnInclude"
        Me.bttnInclude.Size = New System.Drawing.Size(75, 23)
        Me.bttnInclude.TabIndex = 5
        Me.bttnInclude.Text = "Add"
        Me.bttnInclude.UseVisualStyleBackColor = True
        '
        'bttnRefreshQueue
        '
        Me.bttnRefreshQueue.Location = New System.Drawing.Point(250, 195)
        Me.bttnRefreshQueue.Name = "bttnRefreshQueue"
        Me.bttnRefreshQueue.Size = New System.Drawing.Size(125, 23)
        Me.bttnRefreshQueue.TabIndex = 12
        Me.bttnRefreshQueue.Text = "Refresh Kill List"
        Me.bttnRefreshQueue.UseVisualStyleBackColor = True
        '
        'bttnAdd
        '
        Me.bttnAdd.Location = New System.Drawing.Point(250, 44)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(125, 23)
        Me.bttnAdd.TabIndex = 6
        Me.bttnAdd.Text = ">>"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnRemoveAll
        '
        Me.bttnRemoveAll.Location = New System.Drawing.Point(250, 96)
        Me.bttnRemoveAll.Name = "bttnRemoveAll"
        Me.bttnRemoveAll.Size = New System.Drawing.Size(125, 23)
        Me.bttnRemoveAll.TabIndex = 8
        Me.bttnRemoveAll.Text = "|<<"
        Me.bttnRemoveAll.UseVisualStyleBackColor = True
        '
        'bttnRemove
        '
        Me.bttnRemove.Location = New System.Drawing.Point(250, 70)
        Me.bttnRemove.Name = "bttnRemove"
        Me.bttnRemove.Size = New System.Drawing.Size(125, 23)
        Me.bttnRemove.TabIndex = 7
        Me.bttnRemove.Text = "<<"
        Me.bttnRemove.UseVisualStyleBackColor = True
        '
        'txtProcess
        '
        Me.txtProcess.Location = New System.Drawing.Point(16, 20)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(511, 20)
        Me.txtProcess.TabIndex = 14
        '
        'lstProcessQueue
        '
        Me.lstProcessQueue.FormattingEnabled = True
        Me.lstProcessQueue.Location = New System.Drawing.Point(392, 45)
        Me.lstProcessQueue.Name = "lstProcessQueue"
        Me.lstProcessQueue.Size = New System.Drawing.Size(216, 186)
        Me.lstProcessQueue.TabIndex = 12
        '
        'LevelBindingSource
        '
        Me.LevelBindingSource.DataMember = "0"
        Me.LevelBindingSource.DataSource = Me.ClevelDataSet
        '
        'ClevelDataSet
        '
        Me.ClevelDataSet.DataSetName = "clevelDataSet"
        Me.ClevelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstProcesses
        '
        Me.lstProcesses.FormattingEnabled = True
        Me.lstProcesses.Location = New System.Drawing.Point(16, 45)
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.Size = New System.Drawing.Size(216, 186)
        Me.lstProcesses.TabIndex = 13
        '
        'bttnKillSelected
        '
        Me.bttnKillSelected.Location = New System.Drawing.Point(250, 147)
        Me.bttnKillSelected.Name = "bttnKillSelected"
        Me.bttnKillSelected.Size = New System.Drawing.Size(125, 23)
        Me.bttnKillSelected.TabIndex = 10
        Me.bttnKillSelected.Text = "Kill Selected"
        Me.bttnKillSelected.UseVisualStyleBackColor = True
        '
        'bttnUpdateProcessList
        '
        Me.bttnUpdateProcessList.Location = New System.Drawing.Point(250, 171)
        Me.bttnUpdateProcessList.Name = "bttnUpdateProcessList"
        Me.bttnUpdateProcessList.Size = New System.Drawing.Size(125, 23)
        Me.bttnUpdateProcessList.TabIndex = 11
        Me.bttnUpdateProcessList.Text = "Update Process List"
        Me.bttnUpdateProcessList.UseVisualStyleBackColor = True
        '
        'bttnKill
        '
        Me.bttnKill.Location = New System.Drawing.Point(250, 122)
        Me.bttnKill.Name = "bttnKill"
        Me.bttnKill.Size = New System.Drawing.Size(125, 23)
        Me.bttnKill.TabIndex = 9
        Me.bttnKill.Text = "Kill"
        Me.bttnKill.UseVisualStyleBackColor = True
        '
        'lblProcessCount
        '
        Me.lblProcessCount.Location = New System.Drawing.Point(247, 219)
        Me.lblProcessCount.Name = "lblProcessCount"
        Me.lblProcessCount.Size = New System.Drawing.Size(128, 12)
        Me.lblProcessCount.TabIndex = 20
        Me.lblProcessCount.Text = "{process count}"
        Me.lblProcessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpboxProcesses
        '
        Me.grpboxProcesses.Controls.Add(Me.lstProcesses)
        Me.grpboxProcesses.Controls.Add(Me.lblProcessCount)
        Me.grpboxProcesses.Controls.Add(Me.bttnKill)
        Me.grpboxProcesses.Controls.Add(Me.bttnInclude)
        Me.grpboxProcesses.Controls.Add(Me.bttnUpdateProcessList)
        Me.grpboxProcesses.Controls.Add(Me.bttnRefreshQueue)
        Me.grpboxProcesses.Controls.Add(Me.bttnKillSelected)
        Me.grpboxProcesses.Controls.Add(Me.bttnAdd)
        Me.grpboxProcesses.Controls.Add(Me.lstProcessQueue)
        Me.grpboxProcesses.Controls.Add(Me.bttnRemoveAll)
        Me.grpboxProcesses.Controls.Add(Me.txtProcess)
        Me.grpboxProcesses.Controls.Add(Me.bttnRemove)
        Me.grpboxProcesses.Location = New System.Drawing.Point(7, 2)
        Me.grpboxProcesses.Name = "grpboxProcesses"
        Me.grpboxProcesses.Size = New System.Drawing.Size(621, 245)
        Me.grpboxProcesses.TabIndex = 21
        Me.grpboxProcesses.TabStop = False
        Me.grpboxProcesses.Text = "Processes"
        '
        'grpboxControl
        '
        Me.grpboxControl.Controls.Add(Me.bttnViewLog)
        Me.grpboxControl.Controls.Add(Me.bttnExit)
        Me.grpboxControl.Controls.Add(Me.bttnEnableGuard)
        Me.grpboxControl.Controls.Add(Me.bttnDisableGuard)
        Me.grpboxControl.Controls.Add(Me.lstProc)
        Me.grpboxControl.Location = New System.Drawing.Point(639, 2)
        Me.grpboxControl.Name = "grpboxControl"
        Me.grpboxControl.Size = New System.Drawing.Size(177, 245)
        Me.grpboxControl.TabIndex = 22
        Me.grpboxControl.TabStop = False
        Me.grpboxControl.Text = "Control"
        '
        'bttnViewLog
        '
        Me.bttnViewLog.Location = New System.Drawing.Point(6, 179)
        Me.bttnViewLog.Name = "bttnViewLog"
        Me.bttnViewLog.Size = New System.Drawing.Size(165, 52)
        Me.bttnViewLog.TabIndex = 4
        Me.bttnViewLog.Text = "View Log"
        Me.bttnViewLog.UseVisualStyleBackColor = True
        '
        'bttnExit
        '
        Me.bttnExit.Location = New System.Drawing.Point(6, 124)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(165, 52)
        Me.bttnExit.TabIndex = 3
        Me.bttnExit.Text = "Exit Guard"
        Me.bttnExit.UseVisualStyleBackColor = True
        '
        'bttnEnableGuard
        '
        Me.bttnEnableGuard.Location = New System.Drawing.Point(6, 20)
        Me.bttnEnableGuard.Name = "bttnEnableGuard"
        Me.bttnEnableGuard.Size = New System.Drawing.Size(165, 49)
        Me.bttnEnableGuard.TabIndex = 1
        Me.bttnEnableGuard.Text = "Enable Guard"
        Me.bttnEnableGuard.UseVisualStyleBackColor = True
        '
        'bttnDisableGuard
        '
        Me.bttnDisableGuard.Location = New System.Drawing.Point(6, 72)
        Me.bttnDisableGuard.Name = "bttnDisableGuard"
        Me.bttnDisableGuard.Size = New System.Drawing.Size(165, 49)
        Me.bttnDisableGuard.TabIndex = 2
        Me.bttnDisableGuard.Text = "Disable Guard"
        Me.bttnDisableGuard.UseVisualStyleBackColor = True
        '
        'lstProc
        '
        Me.lstProc.DataSource = Me.LevelBindingSource
        Me.lstProc.DisplayMember = "ProcessName"
        Me.lstProc.FormattingEnabled = True
        Me.lstProc.Location = New System.Drawing.Point(27, 188)
        Me.lstProc.Name = "lstProc"
        Me.lstProc.Size = New System.Drawing.Size(77, 30)
        Me.lstProc.TabIndex = 12
        Me.lstProc.ValueMember = "ProcessName"
        '
        'grpboxUserInformation
        '
        Me.grpboxUserInformation.Controls.Add(Me.UserDataBindingNavigator)
        Me.grpboxUserInformation.Controls.Add(ClearanceLevelLabel)
        Me.grpboxUserInformation.Controls.Add(Me.ClearanceLevelComboBox)
        Me.grpboxUserInformation.Controls.Add(FirstNameLabel)
        Me.grpboxUserInformation.Controls.Add(Me.FirstNameTextBox)
        Me.grpboxUserInformation.Controls.Add(SurnameLabel)
        Me.grpboxUserInformation.Controls.Add(Me.SurnameTextBox)
        Me.grpboxUserInformation.Controls.Add(PasswordLabel)
        Me.grpboxUserInformation.Controls.Add(Me.PasswordTextBox)
        Me.grpboxUserInformation.Controls.Add(UsernameLabel)
        Me.grpboxUserInformation.Controls.Add(Me.UsernameTextBox)
        Me.grpboxUserInformation.Controls.Add(Me.PassportPictureBox)
        Me.grpboxUserInformation.Controls.Add(RegistrationNumberLabel)
        Me.grpboxUserInformation.Controls.Add(Me.RegistrationNumberTextBox)
        Me.grpboxUserInformation.Location = New System.Drawing.Point(398, 248)
        Me.grpboxUserInformation.Name = "grpboxUserInformation"
        Me.grpboxUserInformation.Size = New System.Drawing.Size(418, 223)
        Me.grpboxUserInformation.TabIndex = 23
        Me.grpboxUserInformation.TabStop = False
        Me.grpboxUserInformation.Text = "User Information"
        '
        'UserDataBindingNavigator
        '
        Me.UserDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserDataBindingNavigator.BindingSource = Me.UserDataBindingSource
        Me.UserDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserDataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.UserDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.ToolStripLabel1, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserDataBindingNavigatorSaveItem})
        Me.UserDataBindingNavigator.Location = New System.Drawing.Point(50, 181)
        Me.UserDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserDataBindingNavigator.Name = "UserDataBindingNavigator"
        Me.UserDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserDataBindingNavigator.Size = New System.Drawing.Size(250, 25)
        Me.UserDataBindingNavigator.TabIndex = 27
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
        'UserDataBindingSource
        '
        Me.UserDataBindingSource.DataMember = "UserData"
        Me.UserDataBindingSource.DataSource = Me.AuthDataSet
        '
        'AuthDataSet
        '
        Me.AuthDataSet.DataSetName = "authDataSet"
        Me.AuthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
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
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel1.Text = "Navigator"
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
        'ClearanceLevelComboBox
        '
        Me.ClearanceLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "ClearanceLevel", True))
        Me.ClearanceLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClearanceLevelComboBox.FormattingEnabled = True
        Me.ClearanceLevelComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.ClearanceLevelComboBox.Location = New System.Drawing.Point(131, 149)
        Me.ClearanceLevelComboBox.Name = "ClearanceLevelComboBox"
        Me.ClearanceLevelComboBox.Size = New System.Drawing.Size(152, 21)
        Me.ClearanceLevelComboBox.TabIndex = 18
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(131, 71)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(152, 20)
        Me.FirstNameTextBox.TabIndex = 15
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(131, 45)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(152, 20)
        Me.SurnameTextBox.TabIndex = 14
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "pass", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(131, 123)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PasswordTextBox.TabIndex = 17
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "user", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(131, 97)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(152, 20)
        Me.UsernameTextBox.TabIndex = 16
        '
        'PassportPictureBox
        '
        Me.PassportPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PassportPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.UserDataBindingSource, "Passport", True))
        Me.PassportPictureBox.ErrorImage = Global.AuthGuard.My.Resources.Resources.BitLocker_icon
        Me.PassportPictureBox.Image = Global.AuthGuard.My.Resources.Resources.BitLocker_icon
        Me.PassportPictureBox.InitialImage = Global.AuthGuard.My.Resources.Resources.BitLocker_icon
        Me.PassportPictureBox.Location = New System.Drawing.Point(289, 27)
        Me.PassportPictureBox.Name = "PassportPictureBox"
        Me.PassportPictureBox.Size = New System.Drawing.Size(120, 136)
        Me.PassportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PassportPictureBox.TabIndex = 3
        Me.PassportPictureBox.TabStop = False
        '
        'RegistrationNumberTextBox
        '
        Me.RegistrationNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "RegistrationNumber", True))
        Me.RegistrationNumberTextBox.Location = New System.Drawing.Point(131, 19)
        Me.RegistrationNumberTextBox.Name = "RegistrationNumberTextBox"
        Me.RegistrationNumberTextBox.Size = New System.Drawing.Size(152, 20)
        Me.RegistrationNumberTextBox.TabIndex = 13
        '
        'grpboxSecurityLevel
        '
        Me.grpboxSecurityLevel.Controls.Add(Me.txtNameSearch)
        Me.grpboxSecurityLevel.Controls.Add(Me.cboSearch)
        Me.grpboxSecurityLevel.Controls.Add(Me.UserDataDataGridView)
        Me.grpboxSecurityLevel.Location = New System.Drawing.Point(7, 248)
        Me.grpboxSecurityLevel.Name = "grpboxSecurityLevel"
        Me.grpboxSecurityLevel.Size = New System.Drawing.Size(385, 223)
        Me.grpboxSecurityLevel.TabIndex = 24
        Me.grpboxSecurityLevel.TabStop = False
        '
        'cboSearch
        '
        Me.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"Registration Number", "Surname", "First Name"})
        Me.cboSearch.Location = New System.Drawing.Point(238, 11)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(137, 21)
        Me.cboSearch.TabIndex = 2
        '
        'UserDataDataGridView
        '
        Me.UserDataDataGridView.AllowUserToAddRows = False
        Me.UserDataDataGridView.AllowUserToDeleteRows = False
        Me.UserDataDataGridView.AutoGenerateColumns = False
        Me.UserDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.user})
        Me.UserDataDataGridView.DataSource = Me.UserDataBindingSource
        Me.UserDataDataGridView.Location = New System.Drawing.Point(6, 36)
        Me.UserDataDataGridView.Name = "UserDataDataGridView"
        Me.UserDataDataGridView.ReadOnly = True
        Me.UserDataDataGridView.Size = New System.Drawing.Size(369, 180)
        Me.UserDataDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RegistrationNumber"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RegistrationNumber"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'user
        '
        Me.user.DataPropertyName = "user"
        Me.user.HeaderText = "UserName"
        Me.user.Name = "user"
        Me.user.ReadOnly = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 33)
        Me.Button5.TabIndex = 27
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(144, 166)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 33)
        Me.Button6.TabIndex = 28
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(78, 82)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 33)
        Me.Button7.TabIndex = 25
        Me.Button7.UseVisualStyleBackColor = True
        '
        'UserDataTableAdapter
        '
        Me.UserDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = AuthGuard.authDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserDataTableAdapter = Me.UserDataTableAdapter
        '
        'grpProcesses
        '
        Me.grpProcesses.Controls.Add(Me.CLevelBindingNavigator)
        Me.grpProcesses.Controls.Add(Me.lblLevell)
        Me.grpProcesses.Controls.Add(DescriptionLabel)
        Me.grpProcesses.Controls.Add(Me.DescriptionTextBox)
        Me.grpProcesses.Controls.Add(Me.cboLevel)
        Me.grpProcesses.Controls.Add(ApplicationPathLabel)
        Me.grpProcesses.Controls.Add(Me.ApplicationPathTextBox)
        Me.grpProcesses.Controls.Add(ProcessNameLabel)
        Me.grpProcesses.Controls.Add(Me.ProcessNameTextBox)
        Me.grpProcesses.Controls.Add(lblLevel)
        Me.grpProcesses.Controls.Add(ApplicationNameLabel)
        Me.grpProcesses.Controls.Add(Me.ApplicationNameTextBox)
        Me.grpProcesses.Controls.Add(Me.ProcessDataGrid)
        Me.grpProcesses.Location = New System.Drawing.Point(7, 473)
        Me.grpProcesses.Name = "grpProcesses"
        Me.grpProcesses.Size = New System.Drawing.Size(575, 211)
        Me.grpProcesses.TabIndex = 27
        Me.grpProcesses.TabStop = False
        Me.grpProcesses.Text = "Processes"
        '
        'CLevelBindingNavigator
        '
        Me.CLevelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.CLevelBindingNavigator.BindingSource = Me.LevelBindingSource
        Me.CLevelBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.CLevelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.CLevelBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CLevelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.ToolStripLabel2, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.BindingNavigatorSaveItem})
        Me.CLevelBindingNavigator.Location = New System.Drawing.Point(283, 183)
        Me.CLevelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.CLevelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.CLevelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.CLevelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.CLevelBindingNavigator.Name = "CLevelBindingNavigator"
        Me.CLevelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.CLevelBindingNavigator.Size = New System.Drawing.Size(250, 25)
        Me.CLevelBindingNavigator.TabIndex = 1
        Me.CLevelBindingNavigator.Text = "CLevelBindingNavigator"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem1.Visible = False
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel2.Text = "Navigator"
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        Me.BindingNavigatorPositionItem1.Visible = False
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorSaveItem.Text = "Save Data"
        '
        'lblLevell
        '
        Me.lblLevell.AutoSize = True
        Me.lblLevell.Location = New System.Drawing.Point(282, 170)
        Me.lblLevell.Name = "lblLevell"
        Me.lblLevell.Size = New System.Drawing.Size(0, 13)
        Me.lblLevell.TabIndex = 13
        Me.lblLevell.Visible = False
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LevelBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(351, 114)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(187, 65)
        Me.DescriptionTextBox.TabIndex = 23
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cboLevel.Location = New System.Drawing.Point(351, 16)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(187, 21)
        Me.cboLevel.TabIndex = 19
        '
        'ApplicationPathTextBox
        '
        Me.ApplicationPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LevelBindingSource, "ApplicationPath", True))
        Me.ApplicationPathTextBox.Location = New System.Drawing.Point(351, 89)
        Me.ApplicationPathTextBox.Name = "ApplicationPathTextBox"
        Me.ApplicationPathTextBox.Size = New System.Drawing.Size(187, 20)
        Me.ApplicationPathTextBox.TabIndex = 22
        '
        'ProcessNameTextBox
        '
        Me.ProcessNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LevelBindingSource, "ProcessName", True))
        Me.ProcessNameTextBox.Location = New System.Drawing.Point(351, 65)
        Me.ProcessNameTextBox.Name = "ProcessNameTextBox"
        Me.ProcessNameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.ProcessNameTextBox.TabIndex = 21
        '
        'ApplicationNameTextBox
        '
        Me.ApplicationNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LevelBindingSource, "ApplicationName", True))
        Me.ApplicationNameTextBox.Location = New System.Drawing.Point(351, 41)
        Me.ApplicationNameTextBox.Name = "ApplicationNameTextBox"
        Me.ApplicationNameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.ApplicationNameTextBox.TabIndex = 20
        '
        'ProcessDataGrid
        '
        Me.ProcessDataGrid.AllowUserToAddRows = False
        Me.ProcessDataGrid.AllowUserToDeleteRows = False
        Me.ProcessDataGrid.AutoGenerateColumns = False
        Me.ProcessDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProcessDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProcessNameDataGridViewTextBoxColumn})
        Me.ProcessDataGrid.DataSource = Me.LevelBindingSource
        Me.ProcessDataGrid.Location = New System.Drawing.Point(6, 16)
        Me.ProcessDataGrid.Name = "ProcessDataGrid"
        Me.ProcessDataGrid.ReadOnly = True
        Me.ProcessDataGrid.Size = New System.Drawing.Size(246, 189)
        Me.ProcessDataGrid.TabIndex = 1
        '
        'ProcessNameDataGridViewTextBoxColumn
        '
        Me.ProcessNameDataGridViewTextBoxColumn.DataPropertyName = "ProcessName"
        Me.ProcessNameDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.ProcessNameDataGridViewTextBoxColumn.HeaderText = "ProcessName"
        Me.ProcessNameDataGridViewTextBoxColumn.Name = "ProcessNameDataGridViewTextBoxColumn"
        Me.ProcessNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProcessNameDataGridViewTextBoxColumn.Width = 200
        '
        '_0TableAdapter
        '
        Me._0TableAdapter.ClearBeforeFill = True
        '
        '_1TableAdapter
        '
        Me._1TableAdapter.ClearBeforeFill = True
        '
        '_2TableAdapter
        '
        Me._2TableAdapter.ClearBeforeFill = True
        '
        '_3TableAdapter
        '
        Me._3TableAdapter.ClearBeforeFill = True
        '
        '_4TableAdapter
        '
        Me._4TableAdapter.ClearBeforeFill = True
        '
        '_5TableAdapter
        '
        Me._5TableAdapter.ClearBeforeFill = True
        '
        '_6TableAdapter
        '
        Me._6TableAdapter.ClearBeforeFill = True
        '
        '_7TableAdapter
        '
        Me._7TableAdapter.ClearBeforeFill = True
        '
        'LevelTableAdapterManager
        '
        Me.LevelTableAdapterManager._0TableAdapter = Me._0TableAdapter
        Me.LevelTableAdapterManager._1TableAdapter = Me._1TableAdapter
        Me.LevelTableAdapterManager._2TableAdapter = Me._2TableAdapter
        Me.LevelTableAdapterManager._3TableAdapter = Me._3TableAdapter
        Me.LevelTableAdapterManager._4TableAdapter = Me._4TableAdapter
        Me.LevelTableAdapterManager._5TableAdapter = Me._5TableAdapter
        Me.LevelTableAdapterManager._6TableAdapter = Me._6TableAdapter
        Me.LevelTableAdapterManager._7TableAdapter = Me._7TableAdapter
        Me.LevelTableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.LevelTableAdapterManager.UpdateOrder = AuthGuard.clevelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClevelDataSetBindingSource
        '
        Me.ClevelDataSetBindingSource.DataSource = Me.ClevelDataSet
        Me.ClevelDataSetBindingSource.Position = 0
        '
        'AutoKillTimer
        '
        Me.AutoKillTimer.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Location = New System.Drawing.Point(588, 473)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 208)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 20)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 26
        '
        'txtNameSearch
        '
        Me.txtNameSearch.Location = New System.Drawing.Point(6, 11)
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(226, 20)
        Me.txtNameSearch.TabIndex = 3
        '
        'frmConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(835, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpProcesses)
        Me.Controls.Add(Me.grpboxUserInformation)
        Me.Controls.Add(Me.grpboxSecurityLevel)
        Me.Controls.Add(Me.grpboxControl)
        Me.Controls.Add(Me.grpboxProcesses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuthGuard Administrative Console"
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxProcesses.ResumeLayout(False)
        Me.grpboxProcesses.PerformLayout()
        Me.grpboxControl.ResumeLayout(False)
        Me.grpboxUserInformation.ResumeLayout(False)
        Me.grpboxUserInformation.PerformLayout()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataBindingNavigator.ResumeLayout(False)
        Me.UserDataBindingNavigator.PerformLayout()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxSecurityLevel.ResumeLayout(False)
        Me.grpboxSecurityLevel.PerformLayout()
        CType(Me.UserDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProcesses.ResumeLayout(False)
        Me.grpProcesses.PerformLayout()
        CType(Me.CLevelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CLevelBindingNavigator.ResumeLayout(False)
        Me.CLevelBindingNavigator.PerformLayout()
        CType(Me.ProcessDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClevelDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnInclude As System.Windows.Forms.Button
    Friend WithEvents bttnRefreshQueue As System.Windows.Forms.Button
    Friend WithEvents bttnAdd As System.Windows.Forms.Button
    Friend WithEvents bttnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents bttnRemove As System.Windows.Forms.Button
    Friend WithEvents txtProcess As System.Windows.Forms.TextBox
    Friend WithEvents lstProcessQueue As System.Windows.Forms.ListBox
    Friend WithEvents lstProcesses As System.Windows.Forms.ListBox
    Friend WithEvents bttnKillSelected As System.Windows.Forms.Button
    Friend WithEvents bttnUpdateProcessList As System.Windows.Forms.Button
    Friend WithEvents bttnKill As System.Windows.Forms.Button
    Friend WithEvents lblProcessCount As System.Windows.Forms.Label
    Friend WithEvents grpboxProcesses As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxControl As System.Windows.Forms.GroupBox
    Friend WithEvents bttnViewLog As System.Windows.Forms.Button
    Friend WithEvents bttnExit As System.Windows.Forms.Button
    Friend WithEvents bttnEnableGuard As System.Windows.Forms.Button
    Friend WithEvents bttnDisableGuard As System.Windows.Forms.Button
    Friend WithEvents grpboxUserInformation As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxSecurityLevel As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents AuthDataSet As AuthGuard.authDataSet
    Friend WithEvents UserDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserDataTableAdapter As AuthGuard.authDataSetTableAdapters.UserDataTableAdapter
    Friend WithEvents TableAdapterManager As AuthGuard.authDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents ClearanceLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassportPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RegistrationNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents grpProcesses As System.Windows.Forms.GroupBox
    Friend WithEvents LevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClevelDataSet As AuthGuard.clevelDataSet
    Friend WithEvents _0TableAdapter As AuthGuard.clevelDataSetTableAdapters._0TableAdapter
    Friend WithEvents _1TableAdapter As AuthGuard.clevelDataSetTableAdapters._1TableAdapter
    Friend WithEvents _2TableAdapter As AuthGuard.clevelDataSetTableAdapters._2TableAdapter
    Friend WithEvents _3TableAdapter As AuthGuard.clevelDataSetTableAdapters._3TableAdapter
    Friend WithEvents _4TableAdapter As AuthGuard.clevelDataSetTableAdapters._4TableAdapter
    Friend WithEvents _5TableAdapter As AuthGuard.clevelDataSetTableAdapters._5TableAdapter
    Friend WithEvents _6TableAdapter As AuthGuard.clevelDataSetTableAdapters._6TableAdapter
    Friend WithEvents _7TableAdapter As AuthGuard.clevelDataSetTableAdapters._7TableAdapter
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents ApplicationPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProcessNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApplicationNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProcessDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents LevelTableAdapterManager As AuthGuard.clevelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblLevell As System.Windows.Forms.Label
    Friend WithEvents CLevelBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClevelDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProcessNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AutoKillTimer As System.Windows.Forms.Timer
    Friend WithEvents lstProc As System.Windows.Forms.ListBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtNameSearch As System.Windows.Forms.TextBox
End Class
