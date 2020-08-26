<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRegistration
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Date_RegisteredLabel As System.Windows.Forms.Label
        Dim Course_RegisteredLabel As System.Windows.Forms.Label
        Dim Training_SessionLabel As System.Windows.Forms.Label
        Dim Current_ClassLabel As System.Windows.Forms.Label
        Dim Est_Grad_DateLabel As System.Windows.Forms.Label
        Dim GraduatedLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim City_TownLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim POBoxLabel As System.Windows.Forms.Label
        Dim ZIP_CodeLabel As System.Windows.Forms.Label
        Dim Institution_NameLabel As System.Windows.Forms.Label
        Dim Inst_AddressLabel As System.Windows.Forms.Label
        Dim Inst_FromLabel As System.Windows.Forms.Label
        Dim Inst_ToLabel As System.Windows.Forms.Label
        Dim Inst_GraduatedLabel As System.Windows.Forms.Label
        Dim Inst_QualificationLabel As System.Windows.Forms.Label
        Dim NOK_TitleLabel As System.Windows.Forms.Label
        Dim NOK_FullNameLabel As System.Windows.Forms.Label
        Dim NOK_AddressLabel As System.Windows.Forms.Label
        Dim NOK_PhoneNumberLabel As System.Windows.Forms.Label
        Dim NOK_EmailLabel As System.Windows.Forms.Label
        Dim NOK_RelationshipLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewRegistration))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshF5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutERegistratonPortalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BioDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Current_Class = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BioDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordsDataSet = New Invasion_Systems_e_Registration_Portal.RecordsDataSet()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Search = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.BioDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BioDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BioDataTableAdapter = New Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.BioDataTableAdapter()
        Me.TableAdapterManager = New Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.RegistrationNumber_Textbox = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ZIP_CodeLabel1 = New System.Windows.Forms.Label()
        Me.POBoxLabel1 = New System.Windows.Forms.Label()
        Me.CountryLabel1 = New System.Windows.Forms.Label()
        Me.StateLabel1 = New System.Windows.Forms.Label()
        Me.City_TownLabel1 = New System.Windows.Forms.Label()
        Me.AddressLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GraduatedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Est_Grad_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Current_ClassLabel1 = New System.Windows.Forms.Label()
        Me.Training_SessionLabel1 = New System.Windows.Forms.Label()
        Me.Course_RegisteredLabel1 = New System.Windows.Forms.Label()
        Me.Date_RegisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Inst_GraduatedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Inst_QualificationLabel1 = New System.Windows.Forms.Label()
        Me.Inst_ToLabel1 = New System.Windows.Forms.Label()
        Me.Inst_FromLabel1 = New System.Windows.Forms.Label()
        Me.Inst_AddressLabel1 = New System.Windows.Forms.Label()
        Me.Institution_NameLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.NOK_RelationshipLabel1 = New System.Windows.Forms.Label()
        Me.NOK_EmailLabel1 = New System.Windows.Forms.Label()
        Me.NOK_PhoneNumberLabel1 = New System.Windows.Forms.Label()
        Me.NOK_AddressLabel1 = New System.Windows.Forms.Label()
        Me.NOK_FullNameLabel1 = New System.Windows.Forms.Label()
        Me.NOK_TitleLabel1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Date_RegisteredLabel = New System.Windows.Forms.Label()
        Course_RegisteredLabel = New System.Windows.Forms.Label()
        Training_SessionLabel = New System.Windows.Forms.Label()
        Current_ClassLabel = New System.Windows.Forms.Label()
        Est_Grad_DateLabel = New System.Windows.Forms.Label()
        GraduatedLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        City_TownLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        POBoxLabel = New System.Windows.Forms.Label()
        ZIP_CodeLabel = New System.Windows.Forms.Label()
        Institution_NameLabel = New System.Windows.Forms.Label()
        Inst_AddressLabel = New System.Windows.Forms.Label()
        Inst_FromLabel = New System.Windows.Forms.Label()
        Inst_ToLabel = New System.Windows.Forms.Label()
        Inst_GraduatedLabel = New System.Windows.Forms.Label()
        Inst_QualificationLabel = New System.Windows.Forms.Label()
        NOK_TitleLabel = New System.Windows.Forms.Label()
        NOK_FullNameLabel = New System.Windows.Forms.Label()
        NOK_AddressLabel = New System.Windows.Forms.Label()
        NOK_PhoneNumberLabel = New System.Windows.Forms.Label()
        NOK_EmailLabel = New System.Windows.Forms.Label()
        NOK_RelationshipLabel = New System.Windows.Forms.Label()
        Me.MainMenu.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BioDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        CType(Me.BioDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BioDataBindingNavigator.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(10, 297)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(106, 13)
        Label1.TabIndex = 25
        Label1.Text = "Phone Number:"
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(10, 268)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(106, 13)
        Label3.TabIndex = 23
        Label3.Text = "Email:"
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(228, 235)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(67, 13)
        Label5.TabIndex = 21
        Label5.Text = "State Origin:"
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(10, 238)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(106, 13)
        Label7.TabIndex = 19
        Label7.Text = "LGA Origin:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(222, 161)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(74, 13)
        Label9.TabIndex = 17
        Label9.Text = "Marital Status:"
        '
        'Label11
        '
        Label11.Location = New System.Drawing.Point(10, 212)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(106, 13)
        Label11.TabIndex = 15
        Label11.Text = "Nationality:"
        '
        'Label13
        '
        Label13.Location = New System.Drawing.Point(9, 187)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(106, 13)
        Label13.TabIndex = 13
        Label13.Text = "Date Of Birth"
        '
        'Label14
        '
        Label14.Location = New System.Drawing.Point(10, 161)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(106, 13)
        Label14.TabIndex = 10
        Label14.Text = "Gender:"
        '
        'Label16
        '
        Label16.Location = New System.Drawing.Point(10, 133)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(106, 13)
        Label16.TabIndex = 8
        Label16.Text = "Other Names:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(10, 105)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(60, 13)
        Label18.TabIndex = 6
        Label18.Text = "First Name:"
        '
        'Label20
        '
        Label20.Location = New System.Drawing.Point(10, 78)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(106, 13)
        Label20.TabIndex = 4
        Label20.Text = "Surname:"
        '
        'Label22
        '
        Label22.Location = New System.Drawing.Point(10, 51)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(106, 13)
        Label22.TabIndex = 2
        Label22.Text = "Title:"
        '
        'Label24
        '
        Label24.Location = New System.Drawing.Point(10, 24)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(106, 13)
        Label24.TabIndex = 0
        Label24.Text = "Registration Number:"
        '
        'Date_RegisteredLabel
        '
        Date_RegisteredLabel.Location = New System.Drawing.Point(6, 23)
        Date_RegisteredLabel.Name = "Date_RegisteredLabel"
        Date_RegisteredLabel.Size = New System.Drawing.Size(100, 13)
        Date_RegisteredLabel.TabIndex = 0
        Date_RegisteredLabel.Text = "Date Registered:"
        '
        'Course_RegisteredLabel
        '
        Course_RegisteredLabel.Location = New System.Drawing.Point(6, 49)
        Course_RegisteredLabel.Name = "Course_RegisteredLabel"
        Course_RegisteredLabel.Size = New System.Drawing.Size(100, 13)
        Course_RegisteredLabel.TabIndex = 2
        Course_RegisteredLabel.Text = "Course Registered:"
        '
        'Training_SessionLabel
        '
        Training_SessionLabel.Location = New System.Drawing.Point(6, 72)
        Training_SessionLabel.Name = "Training_SessionLabel"
        Training_SessionLabel.Size = New System.Drawing.Size(100, 13)
        Training_SessionLabel.TabIndex = 4
        Training_SessionLabel.Text = "Training Session:"
        '
        'Current_ClassLabel
        '
        Current_ClassLabel.Location = New System.Drawing.Point(6, 97)
        Current_ClassLabel.Name = "Current_ClassLabel"
        Current_ClassLabel.Size = New System.Drawing.Size(100, 13)
        Current_ClassLabel.TabIndex = 6
        Current_ClassLabel.Text = "Current Class:"
        '
        'Est_Grad_DateLabel
        '
        Est_Grad_DateLabel.Location = New System.Drawing.Point(6, 124)
        Est_Grad_DateLabel.Name = "Est_Grad_DateLabel"
        Est_Grad_DateLabel.Size = New System.Drawing.Size(100, 13)
        Est_Grad_DateLabel.TabIndex = 8
        Est_Grad_DateLabel.Text = "Est Grad Date:"
        '
        'GraduatedLabel
        '
        GraduatedLabel.Location = New System.Drawing.Point(6, 150)
        GraduatedLabel.Name = "GraduatedLabel"
        GraduatedLabel.Size = New System.Drawing.Size(100, 13)
        GraduatedLabel.TabIndex = 48
        GraduatedLabel.Text = "Graduated:"
        '
        'AddressLabel
        '
        AddressLabel.Location = New System.Drawing.Point(9, 30)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 0
        AddressLabel.Text = "Address:"
        '
        'City_TownLabel
        '
        City_TownLabel.Location = New System.Drawing.Point(9, 83)
        City_TownLabel.Name = "City_TownLabel"
        City_TownLabel.Size = New System.Drawing.Size(59, 13)
        City_TownLabel.TabIndex = 2
        City_TownLabel.Text = "City/Town:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(238, 81)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(43, 13)
        StateLabel.TabIndex = 4
        StateLabel.Text = "POBox:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(205, 113)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(35, 13)
        CountryLabel.TabIndex = 6
        CountryLabel.Text = "State:"
        '
        'POBoxLabel
        '
        POBoxLabel.Location = New System.Drawing.Point(9, 141)
        POBoxLabel.Name = "POBoxLabel"
        POBoxLabel.Size = New System.Drawing.Size(55, 14)
        POBoxLabel.TabIndex = 8
        POBoxLabel.Text = "Country:"
        '
        'ZIP_CodeLabel
        '
        ZIP_CodeLabel.Location = New System.Drawing.Point(9, 113)
        ZIP_CodeLabel.Name = "ZIP_CodeLabel"
        ZIP_CodeLabel.Size = New System.Drawing.Size(55, 13)
        ZIP_CodeLabel.TabIndex = 10
        ZIP_CodeLabel.Text = "ZIP Code:"
        '
        'Institution_NameLabel
        '
        Institution_NameLabel.AutoSize = True
        Institution_NameLabel.Location = New System.Drawing.Point(8, 20)
        Institution_NameLabel.Name = "Institution_NameLabel"
        Institution_NameLabel.Size = New System.Drawing.Size(86, 13)
        Institution_NameLabel.TabIndex = 0
        Institution_NameLabel.Text = "Institution Name:"
        '
        'Inst_AddressLabel
        '
        Inst_AddressLabel.AutoSize = True
        Inst_AddressLabel.Location = New System.Drawing.Point(8, 47)
        Inst_AddressLabel.Name = "Inst_AddressLabel"
        Inst_AddressLabel.Size = New System.Drawing.Size(68, 13)
        Inst_AddressLabel.TabIndex = 2
        Inst_AddressLabel.Text = "Inst Address:"
        '
        'Inst_FromLabel
        '
        Inst_FromLabel.AutoSize = True
        Inst_FromLabel.Location = New System.Drawing.Point(8, 95)
        Inst_FromLabel.Name = "Inst_FromLabel"
        Inst_FromLabel.Size = New System.Drawing.Size(33, 13)
        Inst_FromLabel.TabIndex = 4
        Inst_FromLabel.Text = "From:"
        '
        'Inst_ToLabel
        '
        Inst_ToLabel.AutoSize = True
        Inst_ToLabel.Location = New System.Drawing.Point(205, 95)
        Inst_ToLabel.Name = "Inst_ToLabel"
        Inst_ToLabel.Size = New System.Drawing.Size(23, 13)
        Inst_ToLabel.TabIndex = 6
        Inst_ToLabel.Text = "To:"
        '
        'Inst_GraduatedLabel
        '
        Inst_GraduatedLabel.AutoSize = True
        Inst_GraduatedLabel.Location = New System.Drawing.Point(210, 123)
        Inst_GraduatedLabel.Name = "Inst_GraduatedLabel"
        Inst_GraduatedLabel.Size = New System.Drawing.Size(60, 13)
        Inst_GraduatedLabel.TabIndex = 0
        Inst_GraduatedLabel.Text = "Graduated:"
        '
        'Inst_QualificationLabel
        '
        Inst_QualificationLabel.AutoSize = True
        Inst_QualificationLabel.Location = New System.Drawing.Point(9, 125)
        Inst_QualificationLabel.Name = "Inst_QualificationLabel"
        Inst_QualificationLabel.Size = New System.Drawing.Size(68, 13)
        Inst_QualificationLabel.TabIndex = 2
        Inst_QualificationLabel.Text = "Qualification:"
        '
        'NOK_TitleLabel
        '
        NOK_TitleLabel.Location = New System.Drawing.Point(7, 25)
        NOK_TitleLabel.Name = "NOK_TitleLabel"
        NOK_TitleLabel.Size = New System.Drawing.Size(100, 13)
        NOK_TitleLabel.TabIndex = 0
        NOK_TitleLabel.Text = "NOK Title:"
        '
        'NOK_FullNameLabel
        '
        NOK_FullNameLabel.Location = New System.Drawing.Point(7, 52)
        NOK_FullNameLabel.Name = "NOK_FullNameLabel"
        NOK_FullNameLabel.Size = New System.Drawing.Size(100, 13)
        NOK_FullNameLabel.TabIndex = 2
        NOK_FullNameLabel.Text = "Full Name:"
        '
        'NOK_AddressLabel
        '
        NOK_AddressLabel.Location = New System.Drawing.Point(10, 79)
        NOK_AddressLabel.Name = "NOK_AddressLabel"
        NOK_AddressLabel.Size = New System.Drawing.Size(100, 13)
        NOK_AddressLabel.TabIndex = 4
        NOK_AddressLabel.Text = "NOK Address:"
        '
        'NOK_PhoneNumberLabel
        '
        NOK_PhoneNumberLabel.Location = New System.Drawing.Point(9, 138)
        NOK_PhoneNumberLabel.Name = "NOK_PhoneNumberLabel"
        NOK_PhoneNumberLabel.Size = New System.Drawing.Size(100, 13)
        NOK_PhoneNumberLabel.TabIndex = 6
        NOK_PhoneNumberLabel.Text = "NOK Phone Number:"
        '
        'NOK_EmailLabel
        '
        NOK_EmailLabel.Location = New System.Drawing.Point(10, 166)
        NOK_EmailLabel.Name = "NOK_EmailLabel"
        NOK_EmailLabel.Size = New System.Drawing.Size(100, 13)
        NOK_EmailLabel.TabIndex = 8
        NOK_EmailLabel.Text = "NOK Email:"
        '
        'NOK_RelationshipLabel
        '
        NOK_RelationshipLabel.Location = New System.Drawing.Point(207, 20)
        NOK_RelationshipLabel.Name = "NOK_RelationshipLabel"
        NOK_RelationshipLabel.Size = New System.Drawing.Size(72, 15)
        NOK_RelationshipLabel.TabIndex = 49
        NOK_RelationshipLabel.Text = "Relationship:"
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.SystemColors.Menu
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(815, 24)
        Me.MainMenu.TabIndex = 43
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.PrintRegistrationToolStripMenuItem, Me.PrintRecordToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Checked = True
        Me.OpenToolStripMenuItem.CheckOnClick = True
        Me.OpenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'PrintRegistrationToolStripMenuItem
        '
        Me.PrintRegistrationToolStripMenuItem.Enabled = False
        Me.PrintRegistrationToolStripMenuItem.Name = "PrintRegistrationToolStripMenuItem"
        Me.PrintRegistrationToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PrintRegistrationToolStripMenuItem.Text = "Print Preview"
        '
        'PrintRecordToolStripMenuItem
        '
        Me.PrintRecordToolStripMenuItem.Enabled = False
        Me.PrintRecordToolStripMenuItem.Name = "PrintRecordToolStripMenuItem"
        Me.PrintRecordToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PrintRecordToolStripMenuItem.Text = "Print Records"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditRecordToolStripMenuItem, Me.AdvancedSearchToolStripMenuItem, Me.ToolStripSeparator3, Me.RefreshF5ToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeyDisplayString = "F5"
        Me.EditToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditRecordToolStripMenuItem
        '
        Me.EditRecordToolStripMenuItem.Name = "EditRecordToolStripMenuItem"
        Me.EditRecordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EditRecordToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EditRecordToolStripMenuItem.Text = "Edit Record"
        '
        'AdvancedSearchToolStripMenuItem
        '
        Me.AdvancedSearchToolStripMenuItem.Name = "AdvancedSearchToolStripMenuItem"
        Me.AdvancedSearchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.AdvancedSearchToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AdvancedSearchToolStripMenuItem.Text = "Advanced Search"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(181, 6)
        '
        'RefreshF5ToolStripMenuItem
        '
        Me.RefreshF5ToolStripMenuItem.Name = "RefreshF5ToolStripMenuItem"
        Me.RefreshF5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshF5ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RefreshF5ToolStripMenuItem.Text = "Refresh"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutERegistratonPortalToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Enabled = False
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutERegistratonPortalToolStripMenuItem
        '
        Me.AboutERegistratonPortalToolStripMenuItem.Name = "AboutERegistratonPortalToolStripMenuItem"
        Me.AboutERegistratonPortalToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AboutERegistratonPortalToolStripMenuItem.Text = "About e-Registraton Portal"
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(647, 736)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(138, 15)
        Me.lblAbout.TabIndex = 44
        Me.lblAbout.Text = "© 2014 Invasion Systems"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BioDataDataGridView)
        Me.GroupBox2.Controls.Add(Me.ToolStrip)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 370)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'BioDataDataGridView
        '
        Me.BioDataDataGridView.AllowUserToAddRows = False
        Me.BioDataDataGridView.AllowUserToDeleteRows = False
        Me.BioDataDataGridView.AutoGenerateColumns = False
        Me.BioDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BioDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Current_Class})
        Me.BioDataDataGridView.DataSource = Me.BioDataBindingSource
        Me.BioDataDataGridView.Location = New System.Drawing.Point(3, 44)
        Me.BioDataDataGridView.Name = "BioDataDataGridView"
        Me.BioDataDataGridView.ReadOnly = True
        Me.BioDataDataGridView.Size = New System.Drawing.Size(331, 320)
        Me.BioDataDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Registration_Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Registration Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Current_Class
        '
        Me.Current_Class.DataPropertyName = "Current_Class"
        Me.Current_Class.HeaderText = "Class"
        Me.Current_Class.Name = "Current_Class"
        Me.Current_Class.ReadOnly = True
        Me.Current_Class.Width = 50
        '
        'BioDataBindingSource
        '
        Me.BioDataBindingSource.DataMember = "BioData"
        Me.BioDataBindingSource.DataSource = Me.RecordsDataSet
        '
        'RecordsDataSet
        '
        Me.RecordsDataSet.DataSetName = "RecordsDataSet"
        Me.RecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Search, Me.SearchComboBox})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(337, 25)
        Me.ToolStrip.TabIndex = 3
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Search"
        '
        'Search
        '
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(150, 25)
        '
        'SearchComboBox
        '
        Me.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchComboBox.Items.AddRange(New Object() {"Registration Number", "Surname", "First Name", "Telephone", "Current Class"})
        Me.SearchComboBox.Name = "SearchComboBox"
        Me.SearchComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'BioDataBindingNavigator
        '
        Me.BioDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BioDataBindingNavigator.BindingSource = Me.BioDataBindingSource
        Me.BioDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BioDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BioDataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BioDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BioDataBindingNavigatorSaveItem})
        Me.BioDataBindingNavigator.Location = New System.Drawing.Point(11, 730)
        Me.BioDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BioDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BioDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BioDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BioDataBindingNavigator.Name = "BioDataBindingNavigator"
        Me.BioDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BioDataBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.BioDataBindingNavigator.TabIndex = 46
        Me.BioDataBindingNavigator.Text = "BindingNavigator1"
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
        'BioDataBindingNavigatorSaveItem
        '
        Me.BioDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BioDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("BioDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BioDataBindingNavigatorSaveItem.Name = "BioDataBindingNavigatorSaveItem"
        Me.BioDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BioDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BioDataTableAdapter
        '
        Me.BioDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BioDataTableAdapter = Me.BioDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.DOBDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Label13)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Label24)
        Me.GroupBox3.Controls.Add(Me.RegistrationNumber_Textbox)
        Me.GroupBox3.Location = New System.Drawing.Point(357, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(428, 323)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Personal Information"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Checked = False
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BioDataBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Enabled = False
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(122, 182)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(300, 22)
        Me.DOBDateTimePicker.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Phone_Number", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 23)
        Me.Label2.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Email", True))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 23)
        Me.Label4.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "State_Origin", True))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(300, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "LGA_Origin", True))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Marital_Status", True))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(302, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 23)
        Me.Label10.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Nationality", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(121, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(301, 23)
        Me.Label12.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BioDataBindingSource, "Passport", True))
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BioDataBindingSource, "Passport", True))
        Me.PictureBox1.Location = New System.Drawing.Point(296, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Gender", True))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(122, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 23)
        Me.Label15.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Other_Names", True))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(122, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 23)
        Me.Label17.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "First_Name", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(122, 100)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 23)
        Me.Label19.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Surname", True))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(122, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(168, 23)
        Me.Label21.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Title", True))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(122, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 23)
        Me.Label23.TabIndex = 3
        '
        'RegistrationNumber_Textbox
        '
        Me.RegistrationNumber_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrationNumber_Textbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Registration_Number", True))
        Me.RegistrationNumber_Textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationNumber_Textbox.Location = New System.Drawing.Point(122, 19)
        Me.RegistrationNumber_Textbox.Name = "RegistrationNumber_Textbox"
        Me.RegistrationNumber_Textbox.Size = New System.Drawing.Size(168, 23)
        Me.RegistrationNumber_Textbox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ZIP_CodeLabel)
        Me.GroupBox1.Controls.Add(Me.ZIP_CodeLabel1)
        Me.GroupBox1.Controls.Add(POBoxLabel)
        Me.GroupBox1.Controls.Add(Me.POBoxLabel1)
        Me.GroupBox1.Controls.Add(CountryLabel)
        Me.GroupBox1.Controls.Add(Me.CountryLabel1)
        Me.GroupBox1.Controls.Add(StateLabel)
        Me.GroupBox1.Controls.Add(Me.StateLabel1)
        Me.GroupBox1.Controls.Add(City_TownLabel)
        Me.GroupBox1.Controls.Add(Me.City_TownLabel1)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(358, 356)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 168)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'ZIP_CodeLabel1
        '
        Me.ZIP_CodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ZIP_CodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "ZIP Code", True))
        Me.ZIP_CodeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIP_CodeLabel1.Location = New System.Drawing.Point(102, 110)
        Me.ZIP_CodeLabel1.Name = "ZIP_CodeLabel1"
        Me.ZIP_CodeLabel1.Size = New System.Drawing.Size(85, 23)
        Me.ZIP_CodeLabel1.TabIndex = 11
        '
        'POBoxLabel1
        '
        Me.POBoxLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.POBoxLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "POBox", True))
        Me.POBoxLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POBoxLabel1.Location = New System.Drawing.Point(279, 77)
        Me.POBoxLabel1.Name = "POBoxLabel1"
        Me.POBoxLabel1.Size = New System.Drawing.Size(142, 23)
        Me.POBoxLabel1.TabIndex = 9
        '
        'CountryLabel1
        '
        Me.CountryLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Country", True))
        Me.CountryLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel1.Location = New System.Drawing.Point(102, 138)
        Me.CountryLabel1.Name = "CountryLabel1"
        Me.CountryLabel1.Size = New System.Drawing.Size(319, 23)
        Me.CountryLabel1.TabIndex = 7
        '
        'StateLabel1
        '
        Me.StateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "State", True))
        Me.StateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateLabel1.Location = New System.Drawing.Point(246, 110)
        Me.StateLabel1.Name = "StateLabel1"
        Me.StateLabel1.Size = New System.Drawing.Size(175, 23)
        Me.StateLabel1.TabIndex = 5
        '
        'City_TownLabel1
        '
        Me.City_TownLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.City_TownLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "City/Town", True))
        Me.City_TownLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_TownLabel1.Location = New System.Drawing.Point(102, 80)
        Me.City_TownLabel1.Name = "City_TownLabel1"
        Me.City_TownLabel1.Size = New System.Drawing.Size(118, 23)
        Me.City_TownLabel1.TabIndex = 3
        '
        'AddressLabel1
        '
        Me.AddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Address", True))
        Me.AddressLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel1.Location = New System.Drawing.Point(102, 27)
        Me.AddressLabel1.Name = "AddressLabel1"
        Me.AddressLabel1.Size = New System.Drawing.Size(319, 50)
        Me.AddressLabel1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(GraduatedLabel)
        Me.GroupBox4.Controls.Add(Est_Grad_DateLabel)
        Me.GroupBox4.Controls.Add(Me.GraduatedCheckBox)
        Me.GroupBox4.Controls.Add(Me.Est_Grad_DateDateTimePicker)
        Me.GroupBox4.Controls.Add(Current_ClassLabel)
        Me.GroupBox4.Controls.Add(Me.Current_ClassLabel1)
        Me.GroupBox4.Controls.Add(Training_SessionLabel)
        Me.GroupBox4.Controls.Add(Me.Training_SessionLabel1)
        Me.GroupBox4.Controls.Add(Course_RegisteredLabel)
        Me.GroupBox4.Controls.Add(Me.Course_RegisteredLabel1)
        Me.GroupBox4.Controls.Add(Date_RegisteredLabel)
        Me.GroupBox4.Controls.Add(Me.Date_RegisteredDateTimePicker)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 397)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 176)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Course Information"
        '
        'GraduatedCheckBox
        '
        Me.GraduatedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BioDataBindingSource, "Graduated", True))
        Me.GraduatedCheckBox.Enabled = False
        Me.GraduatedCheckBox.Location = New System.Drawing.Point(115, 144)
        Me.GraduatedCheckBox.Name = "GraduatedCheckBox"
        Me.GraduatedCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.GraduatedCheckBox.TabIndex = 49
        Me.GraduatedCheckBox.UseVisualStyleBackColor = True
        '
        'Est_Grad_DateDateTimePicker
        '
        Me.Est_Grad_DateDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Est_Grad_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BioDataBindingSource, "Est_Grad_Date", True))
        Me.Est_Grad_DateDateTimePicker.Enabled = False
        Me.Est_Grad_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Est_Grad_DateDateTimePicker.Location = New System.Drawing.Point(112, 119)
        Me.Est_Grad_DateDateTimePicker.Name = "Est_Grad_DateDateTimePicker"
        Me.Est_Grad_DateDateTimePicker.Size = New System.Drawing.Size(222, 22)
        Me.Est_Grad_DateDateTimePicker.TabIndex = 9
        '
        'Current_ClassLabel1
        '
        Me.Current_ClassLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Current_ClassLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Current_Class", True))
        Me.Current_ClassLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_ClassLabel1.Location = New System.Drawing.Point(112, 94)
        Me.Current_ClassLabel1.Name = "Current_ClassLabel1"
        Me.Current_ClassLabel1.Size = New System.Drawing.Size(222, 20)
        Me.Current_ClassLabel1.TabIndex = 7
        '
        'Training_SessionLabel1
        '
        Me.Training_SessionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Training_SessionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Training_Session", True))
        Me.Training_SessionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Training_SessionLabel1.Location = New System.Drawing.Point(112, 69)
        Me.Training_SessionLabel1.Name = "Training_SessionLabel1"
        Me.Training_SessionLabel1.Size = New System.Drawing.Size(222, 20)
        Me.Training_SessionLabel1.TabIndex = 5
        '
        'Course_RegisteredLabel1
        '
        Me.Course_RegisteredLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Course_RegisteredLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Course_Registered", True))
        Me.Course_RegisteredLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course_RegisteredLabel1.Location = New System.Drawing.Point(112, 46)
        Me.Course_RegisteredLabel1.Name = "Course_RegisteredLabel1"
        Me.Course_RegisteredLabel1.Size = New System.Drawing.Size(222, 20)
        Me.Course_RegisteredLabel1.TabIndex = 3
        '
        'Date_RegisteredDateTimePicker
        '
        Me.Date_RegisteredDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_RegisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BioDataBindingSource, "Date_Registered", True))
        Me.Date_RegisteredDateTimePicker.Enabled = False
        Me.Date_RegisteredDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_RegisteredDateTimePicker.Location = New System.Drawing.Point(112, 19)
        Me.Date_RegisteredDateTimePicker.Name = "Date_RegisteredDateTimePicker"
        Me.Date_RegisteredDateTimePicker.Size = New System.Drawing.Size(222, 22)
        Me.Date_RegisteredDateTimePicker.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Inst_GraduatedLabel)
        Me.GroupBox5.Controls.Add(Inst_QualificationLabel)
        Me.GroupBox5.Controls.Add(Me.Inst_GraduatedCheckBox)
        Me.GroupBox5.Controls.Add(Me.Inst_QualificationLabel1)
        Me.GroupBox5.Controls.Add(Inst_ToLabel)
        Me.GroupBox5.Controls.Add(Me.Inst_ToLabel1)
        Me.GroupBox5.Controls.Add(Inst_FromLabel)
        Me.GroupBox5.Controls.Add(Me.Inst_FromLabel1)
        Me.GroupBox5.Controls.Add(Inst_AddressLabel)
        Me.GroupBox5.Controls.Add(Me.Inst_AddressLabel1)
        Me.GroupBox5.Controls.Add(Institution_NameLabel)
        Me.GroupBox5.Controls.Add(Me.Institution_NameLabel1)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 573)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 154)
        Me.GroupBox5.TabIndex = 49
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Educational Information"
        '
        'Inst_GraduatedCheckBox
        '
        Me.Inst_GraduatedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BioDataBindingSource, "Inst_Graduated", True))
        Me.Inst_GraduatedCheckBox.Enabled = False
        Me.Inst_GraduatedCheckBox.Location = New System.Drawing.Point(303, 118)
        Me.Inst_GraduatedCheckBox.Name = "Inst_GraduatedCheckBox"
        Me.Inst_GraduatedCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.Inst_GraduatedCheckBox.TabIndex = 1
        Me.Inst_GraduatedCheckBox.UseVisualStyleBackColor = True
        '
        'Inst_QualificationLabel1
        '
        Me.Inst_QualificationLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Inst_QualificationLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_Qualification", True))
        Me.Inst_QualificationLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inst_QualificationLabel1.Location = New System.Drawing.Point(96, 121)
        Me.Inst_QualificationLabel1.Name = "Inst_QualificationLabel1"
        Me.Inst_QualificationLabel1.Size = New System.Drawing.Size(104, 23)
        Me.Inst_QualificationLabel1.TabIndex = 3
        '
        'Inst_ToLabel1
        '
        Me.Inst_ToLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Inst_ToLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_To", True))
        Me.Inst_ToLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inst_ToLabel1.Location = New System.Drawing.Point(234, 92)
        Me.Inst_ToLabel1.Name = "Inst_ToLabel1"
        Me.Inst_ToLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Inst_ToLabel1.TabIndex = 7
        '
        'Inst_FromLabel1
        '
        Me.Inst_FromLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Inst_FromLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_From", True))
        Me.Inst_FromLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inst_FromLabel1.Location = New System.Drawing.Point(96, 92)
        Me.Inst_FromLabel1.Name = "Inst_FromLabel1"
        Me.Inst_FromLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Inst_FromLabel1.TabIndex = 5
        '
        'Inst_AddressLabel1
        '
        Me.Inst_AddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Inst_AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_Address", True))
        Me.Inst_AddressLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inst_AddressLabel1.Location = New System.Drawing.Point(96, 43)
        Me.Inst_AddressLabel1.Name = "Inst_AddressLabel1"
        Me.Inst_AddressLabel1.Size = New System.Drawing.Size(238, 43)
        Me.Inst_AddressLabel1.TabIndex = 3
        '
        'Institution_NameLabel1
        '
        Me.Institution_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Institution_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Institution_Name", True))
        Me.Institution_NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institution_NameLabel1.Location = New System.Drawing.Point(96, 16)
        Me.Institution_NameLabel1.Name = "Institution_NameLabel1"
        Me.Institution_NameLabel1.Size = New System.Drawing.Size(238, 23)
        Me.Institution_NameLabel1.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(NOK_RelationshipLabel)
        Me.GroupBox6.Controls.Add(NOK_EmailLabel)
        Me.GroupBox6.Controls.Add(Me.NOK_RelationshipLabel1)
        Me.GroupBox6.Controls.Add(Me.NOK_EmailLabel1)
        Me.GroupBox6.Controls.Add(NOK_PhoneNumberLabel)
        Me.GroupBox6.Controls.Add(Me.NOK_PhoneNumberLabel1)
        Me.GroupBox6.Controls.Add(NOK_AddressLabel)
        Me.GroupBox6.Controls.Add(Me.NOK_AddressLabel1)
        Me.GroupBox6.Controls.Add(NOK_FullNameLabel)
        Me.GroupBox6.Controls.Add(Me.NOK_FullNameLabel1)
        Me.GroupBox6.Controls.Add(NOK_TitleLabel)
        Me.GroupBox6.Controls.Add(Me.NOK_TitleLabel1)
        Me.GroupBox6.Location = New System.Drawing.Point(357, 530)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(428, 197)
        Me.GroupBox6.TabIndex = 49
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Next Of Kin Information"
        '
        'NOK_RelationshipLabel1
        '
        Me.NOK_RelationshipLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NOK_RelationshipLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Relationship", True))
        Me.NOK_RelationshipLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOK_RelationshipLabel1.Location = New System.Drawing.Point(280, 17)
        Me.NOK_RelationshipLabel1.Name = "NOK_RelationshipLabel1"
        Me.NOK_RelationshipLabel1.Size = New System.Drawing.Size(142, 23)
        Me.NOK_RelationshipLabel1.TabIndex = 50
        '
        'NOK_EmailLabel1
        '
        Me.NOK_EmailLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NOK_EmailLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Email", True))
        Me.NOK_EmailLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOK_EmailLabel1.Location = New System.Drawing.Point(122, 161)
        Me.NOK_EmailLabel1.Name = "NOK_EmailLabel1"
        Me.NOK_EmailLabel1.Size = New System.Drawing.Size(300, 23)
        Me.NOK_EmailLabel1.TabIndex = 9
        '
        'NOK_PhoneNumberLabel1
        '
        Me.NOK_PhoneNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NOK_PhoneNumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_PhoneNumber", True))
        Me.NOK_PhoneNumberLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOK_PhoneNumberLabel1.Location = New System.Drawing.Point(122, 132)
        Me.NOK_PhoneNumberLabel1.Name = "NOK_PhoneNumberLabel1"
        Me.NOK_PhoneNumberLabel1.Size = New System.Drawing.Size(300, 23)
        Me.NOK_PhoneNumberLabel1.TabIndex = 7
        '
        'NOK_AddressLabel1
        '
        Me.NOK_AddressLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NOK_AddressLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Address", True))
        Me.NOK_AddressLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOK_AddressLabel1.Location = New System.Drawing.Point(121, 74)
        Me.NOK_AddressLabel1.Name = "NOK_AddressLabel1"
        Me.NOK_AddressLabel1.Size = New System.Drawing.Size(301, 55)
        Me.NOK_AddressLabel1.TabIndex = 5
        '
        'NOK_FullNameLabel1
        '
        Me.NOK_FullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NOK_FullNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_FullName", True))
        Me.NOK_FullNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOK_FullNameLabel1.Location = New System.Drawing.Point(121, 47)
        Me.NOK_FullNameLabel1.Name = "NOK_FullNameLabel1"
        Me.NOK_FullNameLabel1.Size = New System.Drawing.Size(301, 23)
        Me.NOK_FullNameLabel1.TabIndex = 3
        '
        'NOK_TitleLabel1
        '
        Me.NOK_TitleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NOK_TitleLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Title", True))
        Me.NOK_TitleLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOK_TitleLabel1.Location = New System.Drawing.Point(121, 20)
        Me.NOK_TitleLabel1.Name = "NOK_TitleLabel1"
        Me.NOK_TitleLabel1.Size = New System.Drawing.Size(75, 23)
        Me.NOK_TitleLabel1.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(14, 730)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(355, 23)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "..."
        '
        'chkEdit
        '
        Me.chkEdit.AutoSize = True
        Me.chkEdit.Enabled = False
        Me.chkEdit.Location = New System.Drawing.Point(292, 737)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(15, 14)
        Me.chkEdit.TabIndex = 50
        Me.chkEdit.UseVisualStyleBackColor = True
        '
        'frmViewRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(832, 703)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.chkEdit)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BioDataBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmViewRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Registration - [Invasion Systems e-Registration Portal]"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BioDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.BioDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BioDataBindingNavigator.ResumeLayout(False)
        Me.BioDataBindingNavigator.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshF5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutERegistratonPortalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Search As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents RecordsDataSet As Invasion_Systems_e_Registration_Portal.RecordsDataSet
    Friend WithEvents BioDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BioDataTableAdapter As Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.BioDataTableAdapter
    Friend WithEvents TableAdapterManager As Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BioDataBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BioDataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BioDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents RegistrationNumber_Textbox As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GraduatedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Est_Grad_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Current_ClassLabel1 As System.Windows.Forms.Label
    Friend WithEvents Training_SessionLabel1 As System.Windows.Forms.Label
    Friend WithEvents Course_RegisteredLabel1 As System.Windows.Forms.Label
    Friend WithEvents Date_RegisteredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ZIP_CodeLabel1 As System.Windows.Forms.Label
    Friend WithEvents POBoxLabel1 As System.Windows.Forms.Label
    Friend WithEvents CountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents StateLabel1 As System.Windows.Forms.Label
    Friend WithEvents City_TownLabel1 As System.Windows.Forms.Label
    Friend WithEvents AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Inst_GraduatedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_QualificationLabel1 As System.Windows.Forms.Label
    Friend WithEvents Inst_ToLabel1 As System.Windows.Forms.Label
    Friend WithEvents Inst_FromLabel1 As System.Windows.Forms.Label
    Friend WithEvents Inst_AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents Institution_NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents NOK_RelationshipLabel1 As System.Windows.Forms.Label
    Friend WithEvents NOK_EmailLabel1 As System.Windows.Forms.Label
    Friend WithEvents NOK_PhoneNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents NOK_AddressLabel1 As System.Windows.Forms.Label
    Friend WithEvents NOK_FullNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents NOK_TitleLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Current_Class As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkEdit As System.Windows.Forms.CheckBox
End Class
