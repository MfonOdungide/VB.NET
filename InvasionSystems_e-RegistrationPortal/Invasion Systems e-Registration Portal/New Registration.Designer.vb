<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewRegistration
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
        Dim Registration_NumberLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Other_NamesLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Marital_StatusLabel As System.Windows.Forms.Label
        Dim LGA_OriginLabel As System.Windows.Forms.Label
        Dim State_OriginLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim City_TownLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim POBoxLabel As System.Windows.Forms.Label
        Dim ZIP_CodeLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim NOK_TitleLabel As System.Windows.Forms.Label
        Dim NOK_FullNameLabel As System.Windows.Forms.Label
        Dim NOK_AddressLabel As System.Windows.Forms.Label
        Dim NOK_PhoneNumberLabel As System.Windows.Forms.Label
        Dim NOK_EmailLabel As System.Windows.Forms.Label
        Dim NOK_RelationshipLabel As System.Windows.Forms.Label
        Dim Institution_NameLabel As System.Windows.Forms.Label
        Dim Inst_AddressLabel As System.Windows.Forms.Label
        Dim Inst_FromLabel As System.Windows.Forms.Label
        Dim Inst_ToLabel As System.Windows.Forms.Label
        Dim Inst_GraduatedLabel As System.Windows.Forms.Label
        Dim Inst_QualificationLabel As System.Windows.Forms.Label
        Dim Date_RegisteredLabel As System.Windows.Forms.Label
        Dim Course_RegisteredLabel As System.Windows.Forms.Label
        Dim Training_SessionLabel As System.Windows.Forms.Label
        Dim Current_ClassLabel As System.Windows.Forms.Label
        Dim Est_Grad_DateLabel As System.Windows.Forms.Label
        Dim GraduatedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewRegistration))
        Me.grpboxPersonalInformation = New System.Windows.Forms.GroupBox()
        Me.State_OriginComboBox = New System.Windows.Forms.ComboBox()
        Me.BioDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordsDataSet = New Invasion_Systems_e_Registration_Portal.RecordsDataSet()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LGA_OriginTextBox = New System.Windows.Forms.TextBox()
        Me.Marital_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.PassportPictureBox = New System.Windows.Forms.PictureBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Other_NamesTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.Registration_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.grpboxEducationalInformation = New System.Windows.Forms.GroupBox()
        Me.Inst_QualificationTextBox = New System.Windows.Forms.TextBox()
        Me.Inst_GraduatedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Inst_ToTextBox = New System.Windows.Forms.TextBox()
        Me.Inst_FromTextBox = New System.Windows.Forms.TextBox()
        Me.Inst_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Institution_NameTextBox = New System.Windows.Forms.TextBox()
        Me.grpboxContactInformation = New System.Windows.Forms.GroupBox()
        Me.ZIP_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.POBoxTextBox = New System.Windows.Forms.TextBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.City_TownTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.grpboxCourseInformation = New System.Windows.Forms.GroupBox()
        Me.GraduatedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Est_Grad_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Current_ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.Training_SessionComboBox = New System.Windows.Forms.ComboBox()
        Me.Course_RegisteredComboBox = New System.Windows.Forms.ComboBox()
        Me.Date_RegisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.grpboxNOKInformation = New System.Windows.Forms.GroupBox()
        Me.NOK_RelationshipComboBox = New System.Windows.Forms.ComboBox()
        Me.NOK_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NOK_PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NOK_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NOK_FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.NOK_TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.BioDataTableAdapter = New Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.BioDataTableAdapter()
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
        Me.grpboxAction = New System.Windows.Forms.GroupBox()
        Me.bttnExit = New System.Windows.Forms.Button()
        Me.bttnEdit = New System.Windows.Forms.Button()
        Me.bttnDelete = New System.Windows.Forms.Button()
        Me.bttnClear = New System.Windows.Forms.Button()
        Me.bttnNew = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.lblControlBox = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Registration_NumberLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Other_NamesLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Marital_StatusLabel = New System.Windows.Forms.Label()
        LGA_OriginLabel = New System.Windows.Forms.Label()
        State_OriginLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        City_TownLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        POBoxLabel = New System.Windows.Forms.Label()
        ZIP_CodeLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        NOK_TitleLabel = New System.Windows.Forms.Label()
        NOK_FullNameLabel = New System.Windows.Forms.Label()
        NOK_AddressLabel = New System.Windows.Forms.Label()
        NOK_PhoneNumberLabel = New System.Windows.Forms.Label()
        NOK_EmailLabel = New System.Windows.Forms.Label()
        NOK_RelationshipLabel = New System.Windows.Forms.Label()
        Institution_NameLabel = New System.Windows.Forms.Label()
        Inst_AddressLabel = New System.Windows.Forms.Label()
        Inst_FromLabel = New System.Windows.Forms.Label()
        Inst_ToLabel = New System.Windows.Forms.Label()
        Inst_GraduatedLabel = New System.Windows.Forms.Label()
        Inst_QualificationLabel = New System.Windows.Forms.Label()
        Date_RegisteredLabel = New System.Windows.Forms.Label()
        Course_RegisteredLabel = New System.Windows.Forms.Label()
        Training_SessionLabel = New System.Windows.Forms.Label()
        Current_ClassLabel = New System.Windows.Forms.Label()
        Est_Grad_DateLabel = New System.Windows.Forms.Label()
        GraduatedLabel = New System.Windows.Forms.Label()
        Me.grpboxPersonalInformation.SuspendLayout()
        CType(Me.BioDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxEducationalInformation.SuspendLayout()
        Me.grpboxContactInformation.SuspendLayout()
        Me.grpboxCourseInformation.SuspendLayout()
        Me.grpboxNOKInformation.SuspendLayout()
        CType(Me.BioDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BioDataBindingNavigator.SuspendLayout()
        Me.grpboxAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Registration_NumberLabel
        '
        Registration_NumberLabel.AutoSize = True
        Registration_NumberLabel.Location = New System.Drawing.Point(4, 22)
        Registration_NumberLabel.Name = "Registration_NumberLabel"
        Registration_NumberLabel.Size = New System.Drawing.Size(106, 13)
        Registration_NumberLabel.TabIndex = 0
        Registration_NumberLabel.Text = "Registration Number:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(80, 48)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 2
        TitleLabel.Text = "Title:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(58, 75)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 4
        SurnameLabel.Text = "Surname:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(50, 101)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 6
        First_NameLabel.Text = "First Name:"
        '
        'Other_NamesLabel
        '
        Other_NamesLabel.AutoSize = True
        Other_NamesLabel.Location = New System.Drawing.Point(38, 127)
        Other_NamesLabel.Name = "Other_NamesLabel"
        Other_NamesLabel.Size = New System.Drawing.Size(72, 13)
        Other_NamesLabel.TabIndex = 8
        Other_NamesLabel.Text = "Other Names:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(65, 153)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(77, 259)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 12
        DOBLabel.Text = "DOB:"
        '
        'Marital_StatusLabel
        '
        Marital_StatusLabel.AutoSize = True
        Marital_StatusLabel.Location = New System.Drawing.Point(204, 153)
        Marital_StatusLabel.Name = "Marital_StatusLabel"
        Marital_StatusLabel.Size = New System.Drawing.Size(74, 13)
        Marital_StatusLabel.TabIndex = 15
        Marital_StatusLabel.Text = "Marital Status:"
        '
        'LGA_OriginLabel
        '
        LGA_OriginLabel.AutoSize = True
        LGA_OriginLabel.Location = New System.Drawing.Point(49, 180)
        LGA_OriginLabel.Name = "LGA_OriginLabel"
        LGA_OriginLabel.Size = New System.Drawing.Size(61, 13)
        LGA_OriginLabel.TabIndex = 17
        LGA_OriginLabel.Text = "LGA Origin:"
        '
        'State_OriginLabel
        '
        State_OriginLabel.AutoSize = True
        State_OriginLabel.Location = New System.Drawing.Point(204, 180)
        State_OriginLabel.Name = "State_OriginLabel"
        State_OriginLabel.Size = New System.Drawing.Size(65, 13)
        State_OriginLabel.TabIndex = 19
        State_OriginLabel.Text = "State Origin:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(75, 206)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "Email:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(29, 232)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 23
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(29, 21)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 0
        AddressLabel.Text = "Address:"
        '
        'City_TownLabel
        '
        City_TownLabel.AutoSize = True
        City_TownLabel.Location = New System.Drawing.Point(18, 77)
        City_TownLabel.Name = "City_TownLabel"
        City_TownLabel.Size = New System.Drawing.Size(59, 13)
        City_TownLabel.TabIndex = 2
        City_TownLabel.Text = "City/Town:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(200, 76)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 4
        StateLabel.Text = "State:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(31, 103)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 6
        CountryLabel.Text = "Country:"
        '
        'POBoxLabel
        '
        POBoxLabel.AutoSize = True
        POBoxLabel.Location = New System.Drawing.Point(201, 130)
        POBoxLabel.Name = "POBoxLabel"
        POBoxLabel.Size = New System.Drawing.Size(43, 13)
        POBoxLabel.TabIndex = 8
        POBoxLabel.Text = "POBox:"
        '
        'ZIP_CodeLabel
        '
        ZIP_CodeLabel.AutoSize = True
        ZIP_CodeLabel.Location = New System.Drawing.Point(22, 130)
        ZIP_CodeLabel.Name = "ZIP_CodeLabel"
        ZIP_CodeLabel.Size = New System.Drawing.Size(55, 13)
        ZIP_CodeLabel.TabIndex = 10
        ZIP_CodeLabel.Text = "ZIP Code:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Location = New System.Drawing.Point(229, 232)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(59, 13)
        NationalityLabel.TabIndex = 25
        NationalityLabel.Text = "Nationality:"
        '
        'NOK_TitleLabel
        '
        NOK_TitleLabel.AutoSize = True
        NOK_TitleLabel.Location = New System.Drawing.Point(3, 21)
        NOK_TitleLabel.Name = "NOK_TitleLabel"
        NOK_TitleLabel.Size = New System.Drawing.Size(30, 13)
        NOK_TitleLabel.TabIndex = 0
        NOK_TitleLabel.Text = "Title:"
        '
        'NOK_FullNameLabel
        '
        NOK_FullNameLabel.AutoSize = True
        NOK_FullNameLabel.Location = New System.Drawing.Point(3, 48)
        NOK_FullNameLabel.Name = "NOK_FullNameLabel"
        NOK_FullNameLabel.Size = New System.Drawing.Size(57, 13)
        NOK_FullNameLabel.TabIndex = 2
        NOK_FullNameLabel.Text = "Full Name:"
        '
        'NOK_AddressLabel
        '
        NOK_AddressLabel.AutoSize = True
        NOK_AddressLabel.Location = New System.Drawing.Point(3, 71)
        NOK_AddressLabel.Name = "NOK_AddressLabel"
        NOK_AddressLabel.Size = New System.Drawing.Size(103, 13)
        NOK_AddressLabel.TabIndex = 4
        NOK_AddressLabel.Text = "Residential Address:"
        '
        'NOK_PhoneNumberLabel
        '
        NOK_PhoneNumberLabel.AutoSize = True
        NOK_PhoneNumberLabel.Location = New System.Drawing.Point(3, 100)
        NOK_PhoneNumberLabel.Name = "NOK_PhoneNumberLabel"
        NOK_PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        NOK_PhoneNumberLabel.TabIndex = 6
        NOK_PhoneNumberLabel.Text = "Phone Number:"
        '
        'NOK_EmailLabel
        '
        NOK_EmailLabel.AutoSize = True
        NOK_EmailLabel.Location = New System.Drawing.Point(3, 127)
        NOK_EmailLabel.Name = "NOK_EmailLabel"
        NOK_EmailLabel.Size = New System.Drawing.Size(35, 13)
        NOK_EmailLabel.TabIndex = 8
        NOK_EmailLabel.Text = "Email:"
        '
        'NOK_RelationshipLabel
        '
        NOK_RelationshipLabel.AutoSize = True
        NOK_RelationshipLabel.Location = New System.Drawing.Point(195, 25)
        NOK_RelationshipLabel.Name = "NOK_RelationshipLabel"
        NOK_RelationshipLabel.Size = New System.Drawing.Size(68, 13)
        NOK_RelationshipLabel.TabIndex = 10
        NOK_RelationshipLabel.Text = "Relationship:"
        '
        'Institution_NameLabel
        '
        Institution_NameLabel.AutoSize = True
        Institution_NameLabel.Location = New System.Drawing.Point(11, 22)
        Institution_NameLabel.Name = "Institution_NameLabel"
        Institution_NameLabel.Size = New System.Drawing.Size(86, 13)
        Institution_NameLabel.TabIndex = 0
        Institution_NameLabel.Text = "Institution Name:"
        '
        'Inst_AddressLabel
        '
        Inst_AddressLabel.AutoSize = True
        Inst_AddressLabel.Location = New System.Drawing.Point(11, 48)
        Inst_AddressLabel.Name = "Inst_AddressLabel"
        Inst_AddressLabel.Size = New System.Drawing.Size(96, 13)
        Inst_AddressLabel.TabIndex = 2
        Inst_AddressLabel.Text = "Institution Address:"
        '
        'Inst_FromLabel
        '
        Inst_FromLabel.AutoSize = True
        Inst_FromLabel.Location = New System.Drawing.Point(14, 101)
        Inst_FromLabel.Name = "Inst_FromLabel"
        Inst_FromLabel.Size = New System.Drawing.Size(33, 13)
        Inst_FromLabel.TabIndex = 4
        Inst_FromLabel.Text = "From:"
        '
        'Inst_ToLabel
        '
        Inst_ToLabel.AutoSize = True
        Inst_ToLabel.Location = New System.Drawing.Point(229, 103)
        Inst_ToLabel.Name = "Inst_ToLabel"
        Inst_ToLabel.Size = New System.Drawing.Size(23, 13)
        Inst_ToLabel.TabIndex = 6
        Inst_ToLabel.Text = "To:"
        '
        'Inst_GraduatedLabel
        '
        Inst_GraduatedLabel.AutoSize = True
        Inst_GraduatedLabel.Location = New System.Drawing.Point(14, 126)
        Inst_GraduatedLabel.Name = "Inst_GraduatedLabel"
        Inst_GraduatedLabel.Size = New System.Drawing.Size(60, 13)
        Inst_GraduatedLabel.TabIndex = 8
        Inst_GraduatedLabel.Text = "Graduated:"
        '
        'Inst_QualificationLabel
        '
        Inst_QualificationLabel.AutoSize = True
        Inst_QualificationLabel.Location = New System.Drawing.Point(170, 129)
        Inst_QualificationLabel.Name = "Inst_QualificationLabel"
        Inst_QualificationLabel.Size = New System.Drawing.Size(68, 13)
        Inst_QualificationLabel.TabIndex = 10
        Inst_QualificationLabel.Text = "Qualification:"
        '
        'Date_RegisteredLabel
        '
        Date_RegisteredLabel.AutoSize = True
        Date_RegisteredLabel.Location = New System.Drawing.Point(20, 23)
        Date_RegisteredLabel.Name = "Date_RegisteredLabel"
        Date_RegisteredLabel.Size = New System.Drawing.Size(87, 13)
        Date_RegisteredLabel.TabIndex = 0
        Date_RegisteredLabel.Text = "Date Registered:"
        '
        'Course_RegisteredLabel
        '
        Course_RegisteredLabel.AutoSize = True
        Course_RegisteredLabel.Location = New System.Drawing.Point(10, 48)
        Course_RegisteredLabel.Name = "Course_RegisteredLabel"
        Course_RegisteredLabel.Size = New System.Drawing.Size(97, 13)
        Course_RegisteredLabel.TabIndex = 2
        Course_RegisteredLabel.Text = "Course Registered:"
        '
        'Training_SessionLabel
        '
        Training_SessionLabel.AutoSize = True
        Training_SessionLabel.Location = New System.Drawing.Point(19, 75)
        Training_SessionLabel.Name = "Training_SessionLabel"
        Training_SessionLabel.Size = New System.Drawing.Size(88, 13)
        Training_SessionLabel.TabIndex = 4
        Training_SessionLabel.Text = "Training Session:"
        '
        'Current_ClassLabel
        '
        Current_ClassLabel.AutoSize = True
        Current_ClassLabel.Location = New System.Drawing.Point(35, 102)
        Current_ClassLabel.Name = "Current_ClassLabel"
        Current_ClassLabel.Size = New System.Drawing.Size(72, 13)
        Current_ClassLabel.TabIndex = 6
        Current_ClassLabel.Text = "Current Class:"
        '
        'Est_Grad_DateLabel
        '
        Est_Grad_DateLabel.AutoSize = True
        Est_Grad_DateLabel.Location = New System.Drawing.Point(30, 130)
        Est_Grad_DateLabel.Name = "Est_Grad_DateLabel"
        Est_Grad_DateLabel.Size = New System.Drawing.Size(77, 13)
        Est_Grad_DateLabel.TabIndex = 8
        Est_Grad_DateLabel.Text = "Est Grad Date:"
        '
        'GraduatedLabel
        '
        GraduatedLabel.AutoSize = True
        GraduatedLabel.Location = New System.Drawing.Point(47, 160)
        GraduatedLabel.Name = "GraduatedLabel"
        GraduatedLabel.Size = New System.Drawing.Size(60, 13)
        GraduatedLabel.TabIndex = 10
        GraduatedLabel.Text = "Graduated:"
        '
        'grpboxPersonalInformation
        '
        Me.grpboxPersonalInformation.Controls.Add(Me.State_OriginComboBox)
        Me.grpboxPersonalInformation.Controls.Add(NationalityLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.NationalityTextBox)
        Me.grpboxPersonalInformation.Controls.Add(Phone_NumberLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.Phone_NumberTextBox)
        Me.grpboxPersonalInformation.Controls.Add(EmailLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.EmailTextBox)
        Me.grpboxPersonalInformation.Controls.Add(State_OriginLabel)
        Me.grpboxPersonalInformation.Controls.Add(LGA_OriginLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.LGA_OriginTextBox)
        Me.grpboxPersonalInformation.Controls.Add(Me.Marital_StatusComboBox)
        Me.grpboxPersonalInformation.Controls.Add(Marital_StatusLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.PassportPictureBox)
        Me.grpboxPersonalInformation.Controls.Add(DOBLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.DOBDateTimePicker)
        Me.grpboxPersonalInformation.Controls.Add(GenderLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.GenderComboBox)
        Me.grpboxPersonalInformation.Controls.Add(Other_NamesLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.Other_NamesTextBox)
        Me.grpboxPersonalInformation.Controls.Add(First_NameLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.First_NameTextBox)
        Me.grpboxPersonalInformation.Controls.Add(SurnameLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.SurnameTextBox)
        Me.grpboxPersonalInformation.Controls.Add(TitleLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.TitleComboBox)
        Me.grpboxPersonalInformation.Controls.Add(Registration_NumberLabel)
        Me.grpboxPersonalInformation.Controls.Add(Me.Registration_NumberTextBox)
        Me.grpboxPersonalInformation.Location = New System.Drawing.Point(12, 12)
        Me.grpboxPersonalInformation.Name = "grpboxPersonalInformation"
        Me.grpboxPersonalInformation.Size = New System.Drawing.Size(370, 283)
        Me.grpboxPersonalInformation.TabIndex = 0
        Me.grpboxPersonalInformation.TabStop = False
        Me.grpboxPersonalInformation.Text = "Personal Information"
        '
        'State_OriginComboBox
        '
        Me.State_OriginComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.State_OriginComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.State_OriginComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "State_Origin", True))
        Me.State_OriginComboBox.FormattingEnabled = True
        Me.State_OriginComboBox.Items.AddRange(New Object() {"Abia State", "Adamawa State", "Akwa Ibom State", "Anambra State", "Bauchi State", "Bayelsa State", "Benue State", "Borno State", "Cross River State", "Delta State", "Ebonyi State", "Edo State", "Ekiti State", "FCT Abuja", "Gombe State", "Imo State", "Jigawa State", "Kaduna State", "Kano State", "Katsina State", "Kebbi State", "Kogi State", "Kwara State", "Lagos State", "Nasarawa State", "Niger State", "Ogun State", "Ondo State", "Osun State", "Oyo State", "Plateau State", "Rivers State", "Sokoto State", "Taraba State", "Yobe State", "Zamfara State"})
        Me.State_OriginComboBox.Location = New System.Drawing.Point(275, 177)
        Me.State_OriginComboBox.Name = "State_OriginComboBox"
        Me.State_OriginComboBox.Size = New System.Drawing.Size(87, 21)
        Me.State_OriginComboBox.TabIndex = 9
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
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(294, 229)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(68, 20)
        Me.NationalityTextBox.TabIndex = 12
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(116, 229)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Phone_NumberTextBox.TabIndex = 11
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(116, 203)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(246, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'LGA_OriginTextBox
        '
        Me.LGA_OriginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "LGA_Origin", True))
        Me.LGA_OriginTextBox.Location = New System.Drawing.Point(116, 177)
        Me.LGA_OriginTextBox.Name = "LGA_OriginTextBox"
        Me.LGA_OriginTextBox.Size = New System.Drawing.Size(82, 20)
        Me.LGA_OriginTextBox.TabIndex = 8
        '
        'Marital_StatusComboBox
        '
        Me.Marital_StatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Marital_StatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Marital_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Marital_Status", True))
        Me.Marital_StatusComboBox.FormattingEnabled = True
        Me.Marital_StatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Engaged", "Seperated", "Divorced", "Widowed"})
        Me.Marital_StatusComboBox.Location = New System.Drawing.Point(282, 150)
        Me.Marital_StatusComboBox.Name = "Marital_StatusComboBox"
        Me.Marital_StatusComboBox.Size = New System.Drawing.Size(80, 21)
        Me.Marital_StatusComboBox.TabIndex = 7
        '
        'PassportPictureBox
        '
        Me.PassportPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PassportPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BioDataBindingSource, "Passport", True))
        Me.PassportPictureBox.Location = New System.Drawing.Point(262, 19)
        Me.PassportPictureBox.Name = "PassportPictureBox"
        Me.PassportPictureBox.Size = New System.Drawing.Size(100, 105)
        Me.PassportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassportPictureBox.TabIndex = 15
        Me.PassportPictureBox.TabStop = False
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BioDataBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(116, 255)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(246, 20)
        Me.DOBDateTimePicker.TabIndex = 13
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(116, 150)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(82, 21)
        Me.GenderComboBox.TabIndex = 6
        '
        'Other_NamesTextBox
        '
        Me.Other_NamesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Other_Names", True))
        Me.Other_NamesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Other_NamesTextBox.Location = New System.Drawing.Point(116, 124)
        Me.Other_NamesTextBox.Name = "Other_NamesTextBox"
        Me.Other_NamesTextBox.Size = New System.Drawing.Size(140, 22)
        Me.Other_NamesTextBox.TabIndex = 5
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(116, 98)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(140, 22)
        Me.First_NameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(116, 72)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(140, 23)
        Me.SurnameTextBox.TabIndex = 3
        '
        'TitleComboBox
        '
        Me.TitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Title", True))
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"Mr.", "Ms.", "Mrs.", "Dr.", "Engr.", "Prof.", "Chief", "Pst.", "Rev."})
        Me.TitleComboBox.Location = New System.Drawing.Point(116, 45)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(140, 21)
        Me.TitleComboBox.TabIndex = 2
        '
        'Registration_NumberTextBox
        '
        Me.Registration_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Registration_Number", True))
        Me.Registration_NumberTextBox.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration_NumberTextBox.Location = New System.Drawing.Point(116, 19)
        Me.Registration_NumberTextBox.Name = "Registration_NumberTextBox"
        Me.Registration_NumberTextBox.Size = New System.Drawing.Size(140, 23)
        Me.Registration_NumberTextBox.TabIndex = 1
        '
        'grpboxEducationalInformation
        '
        Me.grpboxEducationalInformation.Controls.Add(Inst_QualificationLabel)
        Me.grpboxEducationalInformation.Controls.Add(Me.Inst_QualificationTextBox)
        Me.grpboxEducationalInformation.Controls.Add(Inst_GraduatedLabel)
        Me.grpboxEducationalInformation.Controls.Add(Me.Inst_GraduatedCheckBox)
        Me.grpboxEducationalInformation.Controls.Add(Inst_ToLabel)
        Me.grpboxEducationalInformation.Controls.Add(Me.Inst_ToTextBox)
        Me.grpboxEducationalInformation.Controls.Add(Inst_FromLabel)
        Me.grpboxEducationalInformation.Controls.Add(Me.Inst_FromTextBox)
        Me.grpboxEducationalInformation.Controls.Add(Inst_AddressLabel)
        Me.grpboxEducationalInformation.Controls.Add(Me.Inst_AddressTextBox)
        Me.grpboxEducationalInformation.Controls.Add(Institution_NameLabel)
        Me.grpboxEducationalInformation.Controls.Add(Me.Institution_NameTextBox)
        Me.grpboxEducationalInformation.Location = New System.Drawing.Point(388, 333)
        Me.grpboxEducationalInformation.Name = "grpboxEducationalInformation"
        Me.grpboxEducationalInformation.Size = New System.Drawing.Size(370, 152)
        Me.grpboxEducationalInformation.TabIndex = 0
        Me.grpboxEducationalInformation.TabStop = False
        Me.grpboxEducationalInformation.Text = "Educational Information"
        '
        'Inst_QualificationTextBox
        '
        Me.Inst_QualificationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_Qualification", True))
        Me.Inst_QualificationTextBox.Location = New System.Drawing.Point(244, 126)
        Me.Inst_QualificationTextBox.Name = "Inst_QualificationTextBox"
        Me.Inst_QualificationTextBox.Size = New System.Drawing.Size(117, 20)
        Me.Inst_QualificationTextBox.TabIndex = 31
        '
        'Inst_GraduatedCheckBox
        '
        Me.Inst_GraduatedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BioDataBindingSource, "Inst_Graduated", True))
        Me.Inst_GraduatedCheckBox.Location = New System.Drawing.Point(116, 121)
        Me.Inst_GraduatedCheckBox.Name = "Inst_GraduatedCheckBox"
        Me.Inst_GraduatedCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.Inst_GraduatedCheckBox.TabIndex = 30
        Me.Inst_GraduatedCheckBox.UseVisualStyleBackColor = True
        '
        'Inst_ToTextBox
        '
        Me.Inst_ToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_To", True))
        Me.Inst_ToTextBox.Location = New System.Drawing.Point(258, 100)
        Me.Inst_ToTextBox.Name = "Inst_ToTextBox"
        Me.Inst_ToTextBox.Size = New System.Drawing.Size(103, 20)
        Me.Inst_ToTextBox.TabIndex = 29
        '
        'Inst_FromTextBox
        '
        Me.Inst_FromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_From", True))
        Me.Inst_FromTextBox.Location = New System.Drawing.Point(113, 101)
        Me.Inst_FromTextBox.Name = "Inst_FromTextBox"
        Me.Inst_FromTextBox.Size = New System.Drawing.Size(106, 20)
        Me.Inst_FromTextBox.TabIndex = 28
        '
        'Inst_AddressTextBox
        '
        Me.Inst_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Inst_Address", True))
        Me.Inst_AddressTextBox.Location = New System.Drawing.Point(113, 45)
        Me.Inst_AddressTextBox.Multiline = True
        Me.Inst_AddressTextBox.Name = "Inst_AddressTextBox"
        Me.Inst_AddressTextBox.Size = New System.Drawing.Size(248, 49)
        Me.Inst_AddressTextBox.TabIndex = 27
        '
        'Institution_NameTextBox
        '
        Me.Institution_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Institution_Name", True))
        Me.Institution_NameTextBox.Location = New System.Drawing.Point(113, 19)
        Me.Institution_NameTextBox.Name = "Institution_NameTextBox"
        Me.Institution_NameTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Institution_NameTextBox.TabIndex = 26
        '
        'grpboxContactInformation
        '
        Me.grpboxContactInformation.Controls.Add(ZIP_CodeLabel)
        Me.grpboxContactInformation.Controls.Add(Me.ZIP_CodeTextBox)
        Me.grpboxContactInformation.Controls.Add(POBoxLabel)
        Me.grpboxContactInformation.Controls.Add(Me.POBoxTextBox)
        Me.grpboxContactInformation.Controls.Add(CountryLabel)
        Me.grpboxContactInformation.Controls.Add(Me.CountryComboBox)
        Me.grpboxContactInformation.Controls.Add(StateLabel)
        Me.grpboxContactInformation.Controls.Add(Me.StateComboBox)
        Me.grpboxContactInformation.Controls.Add(City_TownLabel)
        Me.grpboxContactInformation.Controls.Add(Me.City_TownTextBox)
        Me.grpboxContactInformation.Controls.Add(AddressLabel)
        Me.grpboxContactInformation.Controls.Add(Me.AddressTextBox)
        Me.grpboxContactInformation.Location = New System.Drawing.Point(388, 12)
        Me.grpboxContactInformation.Name = "grpboxContactInformation"
        Me.grpboxContactInformation.Size = New System.Drawing.Size(370, 155)
        Me.grpboxContactInformation.TabIndex = 0
        Me.grpboxContactInformation.TabStop = False
        Me.grpboxContactInformation.Text = "Contact Information"
        '
        'ZIP_CodeTextBox
        '
        Me.ZIP_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "ZIP Code", True))
        Me.ZIP_CodeTextBox.Location = New System.Drawing.Point(83, 127)
        Me.ZIP_CodeTextBox.Name = "ZIP_CodeTextBox"
        Me.ZIP_CodeTextBox.Size = New System.Drawing.Size(111, 20)
        Me.ZIP_CodeTextBox.TabIndex = 18
        '
        'POBoxTextBox
        '
        Me.POBoxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "POBox", True))
        Me.POBoxTextBox.Location = New System.Drawing.Point(249, 127)
        Me.POBoxTextBox.Name = "POBoxTextBox"
        Me.POBoxTextBox.Size = New System.Drawing.Size(112, 20)
        Me.POBoxTextBox.TabIndex = 19
        '
        'CountryComboBox
        '
        Me.CountryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CountryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Country", True))
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anfuilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Amernia", "Aruba", "Australia", "Austra", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzergoviana", "Botswana", "Brazil", "Brenei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "China", "Christmas Island", "Cocos (Keeling) Islands", "Colombia", "Comoros", "Democratic Republic of Kongo (Kinshasa)", "Congo, Repulic of (Brazzaville)", "Cook Islands", "Costa Rica", "Ivory Coast", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecador", "Egypt", "El Salvdor", "Equitorial Guinea", "Eritrea", "Estonia", "Ethopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finlanad", "France", "French Guiana", "French Polynesia", "French Southern Territories", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Great Britain", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran (Islamic Repuclic of)", "Iraq", "Ireland", "Isreal", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Democratic People's Rep (North Korea)", "Korea, Republic Of (South Korea)", "Kosovo", "Kuwait", "Kyrgyzstan", "Loa, People's Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Leichtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia, Rep. Of", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia, Federal States Of", "Moldova, Rebublc Of", "Monaco", "Mongolia", "Montenegro", "Montserrat", "Morocco", "Mozambique", "Myanmar, Burma", "Nambia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "North Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Phillipines", "Pitcairm Island", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion Island", "Romania", "Russian Federation", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenandines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Sierra Leone", "Singapore", "Slovakia (Slovak Republic)", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan (Republic Of China)", "Tajikistan", "Tanzania (Uninted Republic Of)", "Thailand", "Tibet", "Timor-Leste (East Timor)", "Togo", "Tokelau", "Tongo", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State (Holy See)", "Venezuela", "Vietnam", "Virgin Island (British)", "Virgin Island (U.S.)", "Wallsis and Futuna Islands", "Western Sahara", "Yemen", "Zmabia", "Zimbabwe"})
        Me.CountryComboBox.Location = New System.Drawing.Point(83, 100)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(278, 21)
        Me.CountryComboBox.TabIndex = 17
        '
        'StateComboBox
        '
        Me.StateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.StateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "State", True))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"Abia State", "Adamawa State", "Akwa Ibom State", "Anambra State", "Bauchi State", "Bayelsa State", "Benue State", "Borno State", "Cross River State", "Delta State", "Ebonyi State", "Edo State", "Ekiti State", "FCT Abuja", "Gombe State", "Imo State", "Jigawa State", "Kaduna State", "Kano State", "Katsina State", "Kebbi State", "Kogi State", "Kwara State", "Lagos State", "Nasarawa State", "Niger State", "Ogun State", "Ondo State", "Osun State", "Oyo State", "Plateau State", "Rivers State", "Sokoto State", "Taraba State", "Yobe State", "Zamfara State"})
        Me.StateComboBox.Location = New System.Drawing.Point(241, 73)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StateComboBox.TabIndex = 16
        '
        'City_TownTextBox
        '
        Me.City_TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "City/Town", True))
        Me.City_TownTextBox.Location = New System.Drawing.Point(83, 74)
        Me.City_TownTextBox.Name = "City_TownTextBox"
        Me.City_TownTextBox.Size = New System.Drawing.Size(111, 20)
        Me.City_TownTextBox.TabIndex = 15
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(83, 18)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(278, 49)
        Me.AddressTextBox.TabIndex = 14
        '
        'grpboxCourseInformation
        '
        Me.grpboxCourseInformation.Controls.Add(GraduatedLabel)
        Me.grpboxCourseInformation.Controls.Add(Me.GraduatedCheckBox)
        Me.grpboxCourseInformation.Controls.Add(Est_Grad_DateLabel)
        Me.grpboxCourseInformation.Controls.Add(Me.Est_Grad_DateDateTimePicker)
        Me.grpboxCourseInformation.Controls.Add(Current_ClassLabel)
        Me.grpboxCourseInformation.Controls.Add(Me.Current_ClassComboBox)
        Me.grpboxCourseInformation.Controls.Add(Training_SessionLabel)
        Me.grpboxCourseInformation.Controls.Add(Me.Training_SessionComboBox)
        Me.grpboxCourseInformation.Controls.Add(Course_RegisteredLabel)
        Me.grpboxCourseInformation.Controls.Add(Me.Course_RegisteredComboBox)
        Me.grpboxCourseInformation.Controls.Add(Date_RegisteredLabel)
        Me.grpboxCourseInformation.Controls.Add(Me.Date_RegisteredDateTimePicker)
        Me.grpboxCourseInformation.Location = New System.Drawing.Point(12, 298)
        Me.grpboxCourseInformation.Name = "grpboxCourseInformation"
        Me.grpboxCourseInformation.Size = New System.Drawing.Size(370, 187)
        Me.grpboxCourseInformation.TabIndex = 0
        Me.grpboxCourseInformation.TabStop = False
        Me.grpboxCourseInformation.Text = "Course Information"
        '
        'GraduatedCheckBox
        '
        Me.GraduatedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BioDataBindingSource, "Graduated", True))
        Me.GraduatedCheckBox.Location = New System.Drawing.Point(116, 155)
        Me.GraduatedCheckBox.Name = "GraduatedCheckBox"
        Me.GraduatedCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.GraduatedCheckBox.TabIndex = 25
        Me.GraduatedCheckBox.UseVisualStyleBackColor = True
        '
        'Est_Grad_DateDateTimePicker
        '
        Me.Est_Grad_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BioDataBindingSource, "Est_Grad_Date", True))
        Me.Est_Grad_DateDateTimePicker.Location = New System.Drawing.Point(113, 126)
        Me.Est_Grad_DateDateTimePicker.Name = "Est_Grad_DateDateTimePicker"
        Me.Est_Grad_DateDateTimePicker.Size = New System.Drawing.Size(249, 20)
        Me.Est_Grad_DateDateTimePicker.TabIndex = 24
        '
        'Current_ClassComboBox
        '
        Me.Current_ClassComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Current_ClassComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Current_ClassComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Current_Class", True))
        Me.Current_ClassComboBox.FormattingEnabled = True
        Me.Current_ClassComboBox.Items.AddRange(New Object() {"Class 1", "Class 2", "Class 3", "Class 4", "Class 5", "Class 6"})
        Me.Current_ClassComboBox.Location = New System.Drawing.Point(113, 99)
        Me.Current_ClassComboBox.Name = "Current_ClassComboBox"
        Me.Current_ClassComboBox.Size = New System.Drawing.Size(249, 21)
        Me.Current_ClassComboBox.TabIndex = 23
        '
        'Training_SessionComboBox
        '
        Me.Training_SessionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Training_SessionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Training_SessionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Training_Session", True))
        Me.Training_SessionComboBox.FormattingEnabled = True
        Me.Training_SessionComboBox.Items.AddRange(New Object() {"Morning Session", "Afternoon Session", "Evening Session", "Flexible Package", "Home Service"})
        Me.Training_SessionComboBox.Location = New System.Drawing.Point(113, 72)
        Me.Training_SessionComboBox.Name = "Training_SessionComboBox"
        Me.Training_SessionComboBox.Size = New System.Drawing.Size(249, 21)
        Me.Training_SessionComboBox.TabIndex = 22
        '
        'Course_RegisteredComboBox
        '
        Me.Course_RegisteredComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Course_RegisteredComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Course_RegisteredComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "Course_Registered", True))
        Me.Course_RegisteredComboBox.FormattingEnabled = True
        Me.Course_RegisteredComboBox.Items.AddRange(New Object() {"Certificate Package", "Diploma Package", "Executive Package", "Networking Course", "Maintainance and Repairs", "Professional Package", "N+", "A+", "CCNA", "CCNP", "CCIE", "MCSE", "Security+", "MCITP", "CISSP", "CEH", "MOS", "MOE", "Oracle", "PMP", "DBMS"})
        Me.Course_RegisteredComboBox.Location = New System.Drawing.Point(113, 45)
        Me.Course_RegisteredComboBox.Name = "Course_RegisteredComboBox"
        Me.Course_RegisteredComboBox.Size = New System.Drawing.Size(249, 21)
        Me.Course_RegisteredComboBox.TabIndex = 21
        '
        'Date_RegisteredDateTimePicker
        '
        Me.Date_RegisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BioDataBindingSource, "Date_Registered", True))
        Me.Date_RegisteredDateTimePicker.Location = New System.Drawing.Point(113, 19)
        Me.Date_RegisteredDateTimePicker.Name = "Date_RegisteredDateTimePicker"
        Me.Date_RegisteredDateTimePicker.Size = New System.Drawing.Size(249, 20)
        Me.Date_RegisteredDateTimePicker.TabIndex = 20
        Me.Date_RegisteredDateTimePicker.Value = New Date(2014, 4, 7, 15, 24, 17, 0)
        '
        'grpboxNOKInformation
        '
        Me.grpboxNOKInformation.Controls.Add(NOK_RelationshipLabel)
        Me.grpboxNOKInformation.Controls.Add(Me.NOK_RelationshipComboBox)
        Me.grpboxNOKInformation.Controls.Add(NOK_EmailLabel)
        Me.grpboxNOKInformation.Controls.Add(Me.NOK_EmailTextBox)
        Me.grpboxNOKInformation.Controls.Add(NOK_PhoneNumberLabel)
        Me.grpboxNOKInformation.Controls.Add(Me.NOK_PhoneNumberTextBox)
        Me.grpboxNOKInformation.Controls.Add(NOK_AddressLabel)
        Me.grpboxNOKInformation.Controls.Add(Me.NOK_AddressTextBox)
        Me.grpboxNOKInformation.Controls.Add(NOK_FullNameLabel)
        Me.grpboxNOKInformation.Controls.Add(Me.NOK_FullNameTextBox)
        Me.grpboxNOKInformation.Controls.Add(NOK_TitleLabel)
        Me.grpboxNOKInformation.Controls.Add(Me.NOK_TitleComboBox)
        Me.grpboxNOKInformation.Location = New System.Drawing.Point(388, 173)
        Me.grpboxNOKInformation.Name = "grpboxNOKInformation"
        Me.grpboxNOKInformation.Size = New System.Drawing.Size(370, 154)
        Me.grpboxNOKInformation.TabIndex = 0
        Me.grpboxNOKInformation.TabStop = False
        Me.grpboxNOKInformation.Text = "Next Of Kin Information"
        '
        'NOK_RelationshipComboBox
        '
        Me.NOK_RelationshipComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NOK_RelationshipComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NOK_RelationshipComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Relationship", True))
        Me.NOK_RelationshipComboBox.FormattingEnabled = True
        Me.NOK_RelationshipComboBox.Items.AddRange(New Object() {"Father", "Mother", "Brother", "Sister", "Uncle", "Aunty", "Nephew", "Mother-in-Law", "Father-in-Law", "Foster Father", "Foster Mother", "Guadian", "Fiance", "Fiancee"})
        Me.NOK_RelationshipComboBox.Location = New System.Drawing.Point(273, 22)
        Me.NOK_RelationshipComboBox.Name = "NOK_RelationshipComboBox"
        Me.NOK_RelationshipComboBox.Size = New System.Drawing.Size(88, 21)
        Me.NOK_RelationshipComboBox.TabIndex = 33
        '
        'NOK_EmailTextBox
        '
        Me.NOK_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Email", True))
        Me.NOK_EmailTextBox.Location = New System.Drawing.Point(116, 124)
        Me.NOK_EmailTextBox.Name = "NOK_EmailTextBox"
        Me.NOK_EmailTextBox.Size = New System.Drawing.Size(245, 20)
        Me.NOK_EmailTextBox.TabIndex = 37
        '
        'NOK_PhoneNumberTextBox
        '
        Me.NOK_PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_PhoneNumber", True))
        Me.NOK_PhoneNumberTextBox.Location = New System.Drawing.Point(116, 98)
        Me.NOK_PhoneNumberTextBox.Name = "NOK_PhoneNumberTextBox"
        Me.NOK_PhoneNumberTextBox.Size = New System.Drawing.Size(245, 20)
        Me.NOK_PhoneNumberTextBox.TabIndex = 36
        '
        'NOK_AddressTextBox
        '
        Me.NOK_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Address", True))
        Me.NOK_AddressTextBox.Location = New System.Drawing.Point(116, 72)
        Me.NOK_AddressTextBox.Name = "NOK_AddressTextBox"
        Me.NOK_AddressTextBox.Size = New System.Drawing.Size(246, 20)
        Me.NOK_AddressTextBox.TabIndex = 35
        '
        'NOK_FullNameTextBox
        '
        Me.NOK_FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_FullName", True))
        Me.NOK_FullNameTextBox.Location = New System.Drawing.Point(116, 46)
        Me.NOK_FullNameTextBox.Name = "NOK_FullNameTextBox"
        Me.NOK_FullNameTextBox.Size = New System.Drawing.Size(245, 20)
        Me.NOK_FullNameTextBox.TabIndex = 34
        '
        'NOK_TitleComboBox
        '
        Me.NOK_TitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NOK_TitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NOK_TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BioDataBindingSource, "NOK_Title", True))
        Me.NOK_TitleComboBox.FormattingEnabled = True
        Me.NOK_TitleComboBox.Items.AddRange(New Object() {"Mr.", "Ms.", "Mrs.", "Dr.", "Engr.", "Prof.", "Chief", "Pst.", "Rev."})
        Me.NOK_TitleComboBox.Location = New System.Drawing.Point(116, 19)
        Me.NOK_TitleComboBox.Name = "NOK_TitleComboBox"
        Me.NOK_TitleComboBox.Size = New System.Drawing.Size(73, 21)
        Me.NOK_TitleComboBox.TabIndex = 32
        '
        'BioDataTableAdapter
        '
        Me.BioDataTableAdapter.ClearBeforeFill = True
        '
        'BioDataBindingNavigator
        '
        Me.BioDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BioDataBindingNavigator.BindingSource = Me.BioDataBindingSource
        Me.BioDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BioDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BioDataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BioDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BioDataBindingNavigatorSaveItem})
        Me.BioDataBindingNavigator.Location = New System.Drawing.Point(9, 685)
        Me.BioDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BioDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BioDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BioDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BioDataBindingNavigator.Name = "BioDataBindingNavigator"
        Me.BioDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BioDataBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.BioDataBindingNavigator.TabIndex = 1
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
        'grpboxAction
        '
        Me.grpboxAction.Controls.Add(Me.bttnExit)
        Me.grpboxAction.Controls.Add(Me.bttnEdit)
        Me.grpboxAction.Controls.Add(Me.bttnDelete)
        Me.grpboxAction.Controls.Add(Me.bttnClear)
        Me.grpboxAction.Controls.Add(Me.bttnNew)
        Me.grpboxAction.Controls.Add(Me.bttnSave)
        Me.grpboxAction.Location = New System.Drawing.Point(12, 628)
        Me.grpboxAction.Name = "grpboxAction"
        Me.grpboxAction.Size = New System.Drawing.Size(746, 64)
        Me.grpboxAction.TabIndex = 0
        Me.grpboxAction.TabStop = False
        Me.grpboxAction.Text = "Action"
        '
        'bttnExit
        '
        Me.bttnExit.Location = New System.Drawing.Point(23, 18)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(94, 36)
        Me.bttnExit.TabIndex = 42
        Me.bttnExit.Text = "E&xit"
        Me.bttnExit.UseVisualStyleBackColor = True
        '
        'bttnEdit
        '
        Me.bttnEdit.Enabled = False
        Me.bttnEdit.Location = New System.Drawing.Point(129, 18)
        Me.bttnEdit.Name = "bttnEdit"
        Me.bttnEdit.Size = New System.Drawing.Size(94, 36)
        Me.bttnEdit.TabIndex = 41
        Me.bttnEdit.Text = "&Edit"
        Me.bttnEdit.UseVisualStyleBackColor = True
        '
        'bttnDelete
        '
        Me.bttnDelete.Location = New System.Drawing.Point(332, 18)
        Me.bttnDelete.Name = "bttnDelete"
        Me.bttnDelete.Size = New System.Drawing.Size(94, 36)
        Me.bttnDelete.TabIndex = 40
        Me.bttnDelete.Text = "&Delete"
        Me.bttnDelete.UseVisualStyleBackColor = True
        '
        'bttnClear
        '
        Me.bttnClear.Location = New System.Drawing.Point(232, 18)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(94, 36)
        Me.bttnClear.TabIndex = 40
        Me.bttnClear.Text = "&Clear"
        Me.bttnClear.UseVisualStyleBackColor = True
        '
        'bttnNew
        '
        Me.bttnNew.Location = New System.Drawing.Point(526, 18)
        Me.bttnNew.Name = "bttnNew"
        Me.bttnNew.Size = New System.Drawing.Size(94, 36)
        Me.bttnNew.TabIndex = 39
        Me.bttnNew.Text = "&New"
        Me.bttnNew.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(639, 18)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(94, 36)
        Me.bttnSave.TabIndex = 38
        Me.bttnSave.Text = "&Save"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'chkEdit
        '
        Me.chkEdit.AutoSize = True
        Me.chkEdit.Location = New System.Drawing.Point(275, 685)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(15, 14)
        Me.chkEdit.TabIndex = 22
        Me.chkEdit.UseVisualStyleBackColor = True
        '
        'lblControlBox
        '
        Me.lblControlBox.Location = New System.Drawing.Point(6, 684)
        Me.lblControlBox.Name = "lblControlBox"
        Me.lblControlBox.Size = New System.Drawing.Size(346, 25)
        Me.lblControlBox.TabIndex = 23
        Me.lblControlBox.Text = "..."
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(620, 695)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(138, 15)
        Me.lblAbout.TabIndex = 45
        Me.lblAbout.Text = "© 2014 Invasion Systems"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BioDataTableAdapter = Me.BioDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Invasion_Systems_e_Registration_Portal.RecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 491)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 131)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employment Record"
        '
        'frmNewRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 719)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblControlBox)
        Me.Controls.Add(Me.chkEdit)
        Me.Controls.Add(Me.grpboxAction)
        Me.Controls.Add(Me.BioDataBindingNavigator)
        Me.Controls.Add(Me.grpboxEducationalInformation)
        Me.Controls.Add(Me.grpboxCourseInformation)
        Me.Controls.Add(Me.grpboxNOKInformation)
        Me.Controls.Add(Me.grpboxContactInformation)
        Me.Controls.Add(Me.grpboxPersonalInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNewRegistration"
        Me.Text = "New Registration"
        Me.grpboxPersonalInformation.ResumeLayout(False)
        Me.grpboxPersonalInformation.PerformLayout()
        CType(Me.BioDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxEducationalInformation.ResumeLayout(False)
        Me.grpboxEducationalInformation.PerformLayout()
        Me.grpboxContactInformation.ResumeLayout(False)
        Me.grpboxContactInformation.PerformLayout()
        Me.grpboxCourseInformation.ResumeLayout(False)
        Me.grpboxCourseInformation.PerformLayout()
        Me.grpboxNOKInformation.ResumeLayout(False)
        Me.grpboxNOKInformation.PerformLayout()
        CType(Me.BioDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BioDataBindingNavigator.ResumeLayout(False)
        Me.BioDataBindingNavigator.PerformLayout()
        Me.grpboxAction.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpboxPersonalInformation As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxEducationalInformation As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxContactInformation As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxCourseInformation As System.Windows.Forms.GroupBox
    Friend WithEvents grpboxNOKInformation As System.Windows.Forms.GroupBox
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
    Friend WithEvents NationalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LGA_OriginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Marital_StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PassportPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Other_NamesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Registration_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZIP_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POBoxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents City_TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOK_RelationshipComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NOK_EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOK_PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOK_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOK_FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOK_TitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Inst_QualificationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Inst_GraduatedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Inst_ToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Inst_FromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Inst_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Institution_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GraduatedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Current_ClassComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Training_SessionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Course_RegisteredComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents grpboxAction As System.Windows.Forms.GroupBox
    Friend WithEvents bttnEdit As System.Windows.Forms.Button
    Friend WithEvents bttnClear As System.Windows.Forms.Button
    Friend WithEvents bttnNew As System.Windows.Forms.Button
    Friend WithEvents bttnSave As System.Windows.Forms.Button
    Friend WithEvents bttnExit As System.Windows.Forms.Button
    Friend WithEvents State_OriginComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkEdit As System.Windows.Forms.CheckBox
    Friend WithEvents bttnDelete As System.Windows.Forms.Button
    Friend WithEvents lblControlBox As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents Est_Grad_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_RegisteredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
