<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLock))
        Me.grpboxLogin = New System.Windows.Forms.GroupBox()
        Me.bttnLogin = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstProc = New System.Windows.Forms.ListBox()
        Me.LevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClevelDataSet = New AuthGuard.clevelDataSet()
        Me.errorcount = New System.Windows.Forms.Label()
        Me.RegistrationNumberTextBox = New System.Windows.Forms.TextBox()
        Me.UserDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthDataSet = New AuthGuard.authDataSet()
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
        Me.ClearanceLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.LockMouseOverHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewInformationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuAdminConsole = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDataTableAdapter = New AuthGuard.authDataSetTableAdapters.UserDataTableAdapter()
        Me.TableAdapterManager = New AuthGuard.authDataSetTableAdapters.TableAdapterManager()
        Me._1TableAdapter = New AuthGuard.clevelDataSetTableAdapters._1TableAdapter()
        Me._2TableAdapter = New AuthGuard.clevelDataSetTableAdapters._2TableAdapter()
        Me._3TableAdapter = New AuthGuard.clevelDataSetTableAdapters._3TableAdapter()
        Me._4TableAdapter = New AuthGuard.clevelDataSetTableAdapters._4TableAdapter()
        Me._5TableAdapter = New AuthGuard.clevelDataSetTableAdapters._5TableAdapter()
        Me._6TableAdapter = New AuthGuard.clevelDataSetTableAdapters._6TableAdapter()
        Me._7TableAdapter = New AuthGuard.clevelDataSetTableAdapters._7TableAdapter()
        Me._0TableAdapter = New AuthGuard.clevelDataSetTableAdapters._0TableAdapter()
        Me.TmrLock = New System.Windows.Forms.Timer(Me.components)
        RegistrationNumberLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        ClearanceLevelLabel = New System.Windows.Forms.Label()
        Me.grpboxLogin.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClevelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataBindingNavigator.SuspendLayout()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistrationNumberLabel
        '
        RegistrationNumberLabel.AutoSize = True
        RegistrationNumberLabel.Location = New System.Drawing.Point(54, 2)
        RegistrationNumberLabel.Name = "RegistrationNumberLabel"
        RegistrationNumberLabel.Size = New System.Drawing.Size(106, 13)
        RegistrationNumberLabel.TabIndex = 14
        RegistrationNumberLabel.Text = "Registration Number:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(104, 28)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 15
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(105, 54)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 16
        PasswordLabel.Text = "password:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(108, 80)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 17
        SurnameLabel.Text = "Surname:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(100, 108)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 18
        FirstNameLabel.Text = "First Name:"
        '
        'ClearanceLevelLabel
        '
        ClearanceLevelLabel.AutoSize = True
        ClearanceLevelLabel.Location = New System.Drawing.Point(73, 134)
        ClearanceLevelLabel.Name = "ClearanceLevelLabel"
        ClearanceLevelLabel.Size = New System.Drawing.Size(87, 13)
        ClearanceLevelLabel.TabIndex = 19
        ClearanceLevelLabel.Text = "Clearance Level:"
        '
        'grpboxLogin
        '
        Me.grpboxLogin.BackColor = System.Drawing.Color.Transparent
        Me.grpboxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpboxLogin.Controls.Add(Me.bttnLogin)
        Me.grpboxLogin.Controls.Add(Me.PictureBox)
        Me.grpboxLogin.Controls.Add(Me.txtPassword)
        Me.grpboxLogin.Controls.Add(Me.txtUsername)
        Me.grpboxLogin.Controls.Add(Me.GroupBox1)
        Me.grpboxLogin.Location = New System.Drawing.Point(280, 67)
        Me.grpboxLogin.Name = "grpboxLogin"
        Me.grpboxLogin.Size = New System.Drawing.Size(474, 327)
        Me.grpboxLogin.TabIndex = 1
        Me.grpboxLogin.TabStop = False
        '
        'bttnLogin
        '
        Me.bttnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLogin.Location = New System.Drawing.Point(171, 274)
        Me.bttnLogin.Name = "bttnLogin"
        Me.bttnLogin.Size = New System.Drawing.Size(148, 37)
        Me.bttnLogin.TabIndex = 3
        Me.bttnLogin.Text = "&Login"
        Me.LockMouseOverHelp.SetToolTip(Me.bttnLogin, "Authenticate")
        Me.bttnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.AuthGuard.My.Resources.Resources.BitLocker_icon
        Me.PictureBox.Location = New System.Drawing.Point(171, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(148, 149)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(105, 225)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(274, 43)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LockMouseOverHelp.SetToolTip(Me.txtPassword, "Password")
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(105, 176)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(274, 43)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "Username"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LockMouseOverHelp.SetToolTip(Me.txtUsername, "Username")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lstProc)
        Me.GroupBox1.Controls.Add(Me.errorcount)
        Me.GroupBox1.Controls.Add(Me.RegistrationNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.UserDataBindingNavigator)
        Me.GroupBox1.Controls.Add(ClearanceLevelLabel)
        Me.GroupBox1.Controls.Add(RegistrationNumberLabel)
        Me.GroupBox1.Controls.Add(Me.ClearanceLevelComboBox)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(171, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(35, 19)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ".."
        '
        'lstProc
        '
        Me.lstProc.DataSource = Me.LevelBindingSource
        Me.lstProc.DisplayMember = "ProcessName"
        Me.lstProc.FormattingEnabled = True
        Me.lstProc.Location = New System.Drawing.Point(142, 158)
        Me.lstProc.Name = "lstProc"
        Me.lstProc.Size = New System.Drawing.Size(124, 82)
        Me.lstProc.TabIndex = 13
        Me.lstProc.ValueMember = "ProcessName"
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
        'errorcount
        '
        Me.errorcount.AutoSize = True
        Me.errorcount.Location = New System.Drawing.Point(73, 170)
        Me.errorcount.Name = "errorcount"
        Me.errorcount.Size = New System.Drawing.Size(13, 13)
        Me.errorcount.TabIndex = 23
        Me.errorcount.Text = "0"
        '
        'RegistrationNumberTextBox
        '
        Me.RegistrationNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "RegistrationNumber", True))
        Me.RegistrationNumberTextBox.Location = New System.Drawing.Point(166, -1)
        Me.RegistrationNumberTextBox.Name = "RegistrationNumberTextBox"
        Me.RegistrationNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RegistrationNumberTextBox.TabIndex = 15
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
        'UserDataBindingNavigator
        '
        Me.UserDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserDataBindingNavigator.BindingSource = Me.UserDataBindingSource
        Me.UserDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserDataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.UserDataBindingNavigator.Enabled = False
        Me.UserDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserDataBindingNavigatorSaveItem})
        Me.UserDataBindingNavigator.Location = New System.Drawing.Point(57, 203)
        Me.UserDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserDataBindingNavigator.Name = "UserDataBindingNavigator"
        Me.UserDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserDataBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.UserDataBindingNavigator.TabIndex = 14
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
        'ClearanceLevelComboBox
        '
        Me.ClearanceLevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "ClearanceLevel", True))
        Me.ClearanceLevelComboBox.FormattingEnabled = True
        Me.ClearanceLevelComboBox.Location = New System.Drawing.Point(166, 131)
        Me.ClearanceLevelComboBox.Name = "ClearanceLevelComboBox"
        Me.ClearanceLevelComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ClearanceLevelComboBox.TabIndex = 20
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "user", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(166, 25)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 16
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "pass", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(166, 51)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 17
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(166, 105)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 19
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(166, 77)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 18
        '
        'lblCopyright
        '
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.White
        Me.lblCopyright.Location = New System.Drawing.Point(0, 535)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(1044, 31)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "©2014 Invasion Systems"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "AuthGuard"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHideToolStripMenuItem, Me.LockToolStripMenuItem, Me.ViewInformationToolStripMenuItem1, Me.ToolStripMenuAdminConsole})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(166, 92)
        '
        'ShowHideToolStripMenuItem
        '
        Me.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem"
        Me.ShowHideToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ShowHideToolStripMenuItem.Text = "Show/Hide"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'ViewInformationToolStripMenuItem1
        '
        Me.ViewInformationToolStripMenuItem1.Name = "ViewInformationToolStripMenuItem1"
        Me.ViewInformationToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ViewInformationToolStripMenuItem1.Text = "View Information"
        '
        'ToolStripMenuAdminConsole
        '
        Me.ToolStripMenuAdminConsole.Name = "ToolStripMenuAdminConsole"
        Me.ToolStripMenuAdminConsole.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuAdminConsole.Text = "Admin Console"
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
        '_0TableAdapter
        '
        Me._0TableAdapter.ClearBeforeFill = True
        '
        'TmrLock
        '
        Me.TmrLock.Enabled = True
        '
        'frmLock
        '
        Me.AcceptButton = Me.bttnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.AuthGuard.My.Resources.Resources.Wallpaper1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1044, 566)
        Me.Controls.Add(Me.grpboxLogin)
        Me.Controls.Add(Me.lblCopyright)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpboxLogin.ResumeLayout(False)
        Me.grpboxLogin.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClevelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataBindingNavigator.ResumeLayout(False)
        Me.UserDataBindingNavigator.PerformLayout()
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpboxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents bttnLogin As System.Windows.Forms.Button
    Friend WithEvents LockMouseOverHelp As System.Windows.Forms.ToolTip
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowHideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewInformationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuAdminConsole As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstProc As System.Windows.Forms.ListBox
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
    Friend WithEvents RegistrationNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearanceLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClevelDataSet As AuthGuard.clevelDataSet
    Friend WithEvents LevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _1TableAdapter As AuthGuard.clevelDataSetTableAdapters._1TableAdapter
    Friend WithEvents _2TableAdapter As AuthGuard.clevelDataSetTableAdapters._2TableAdapter
    Friend WithEvents _3TableAdapter As AuthGuard.clevelDataSetTableAdapters._3TableAdapter
    Friend WithEvents _4TableAdapter As AuthGuard.clevelDataSetTableAdapters._4TableAdapter
    Friend WithEvents _5TableAdapter As AuthGuard.clevelDataSetTableAdapters._5TableAdapter
    Friend WithEvents _6TableAdapter As AuthGuard.clevelDataSetTableAdapters._6TableAdapter
    Friend WithEvents _7TableAdapter As AuthGuard.clevelDataSetTableAdapters._7TableAdapter
    Friend WithEvents _0TableAdapter As AuthGuard.clevelDataSetTableAdapters._0TableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents errorcount As System.Windows.Forms.Label
    Friend WithEvents TmrLock As System.Windows.Forms.Timer

End Class
