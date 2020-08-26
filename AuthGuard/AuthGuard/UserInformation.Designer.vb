<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserInformation))
        Me.AuthDataSet = New AuthGuard.authDataSet()
        Me.UserDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataTableAdapter = New AuthGuard.authDataSetTableAdapters.UserDataTableAdapter()
        Me.TableAdapterManager = New AuthGuard.authDataSetTableAdapters.TableAdapterManager()
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
        Me.PassportPictureBox = New System.Windows.Forms.PictureBox()
        Me.RegistrationNumberLabel1 = New System.Windows.Forms.Label()
        Me.UsernameLabel1 = New System.Windows.Forms.Label()
        Me.PasswordLabel1 = New System.Windows.Forms.Label()
        Me.SurnameLabel1 = New System.Windows.Forms.Label()
        Me.FirstNameLabel1 = New System.Windows.Forms.Label()
        Me.ClearanceLevelLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        RegistrationNumberLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        ClearanceLevelLabel = New System.Windows.Forms.Label()
        CType(Me.AuthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserDataBindingNavigator.SuspendLayout()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegistrationNumberLabel
        '
        RegistrationNumberLabel.AutoSize = True
        RegistrationNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        RegistrationNumberLabel.Location = New System.Drawing.Point(12, 23)
        RegistrationNumberLabel.Name = "RegistrationNumberLabel"
        RegistrationNumberLabel.Size = New System.Drawing.Size(168, 21)
        RegistrationNumberLabel.TabIndex = 14
        RegistrationNumberLabel.Text = "Registration Number:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        UsernameLabel.Location = New System.Drawing.Point(93, 59)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(87, 21)
        UsernameLabel.TabIndex = 15
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        PasswordLabel.Location = New System.Drawing.Point(97, 95)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(83, 21)
        PasswordLabel.TabIndex = 16
        PasswordLabel.Text = "Password:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        SurnameLabel.Location = New System.Drawing.Point(102, 133)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(78, 21)
        SurnameLabel.TabIndex = 17
        SurnameLabel.Text = "Surname:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        FirstNameLabel.Location = New System.Drawing.Point(88, 167)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(92, 21)
        FirstNameLabel.TabIndex = 18
        FirstNameLabel.Text = "First Name:"
        '
        'ClearanceLevelLabel
        '
        ClearanceLevelLabel.AutoSize = True
        ClearanceLevelLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        ClearanceLevelLabel.Location = New System.Drawing.Point(52, 203)
        ClearanceLevelLabel.Name = "ClearanceLevelLabel"
        ClearanceLevelLabel.Size = New System.Drawing.Size(127, 21)
        ClearanceLevelLabel.TabIndex = 19
        ClearanceLevelLabel.Text = "Clearance Level:"
        '
        'AuthDataSet
        '
        Me.AuthDataSet.DataSetName = "authDataSet"
        Me.AuthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserDataBindingSource
        '
        Me.UserDataBindingSource.DataMember = "UserData"
        Me.UserDataBindingSource.DataSource = Me.AuthDataSet
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
        'UserDataBindingNavigator
        '
        Me.UserDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserDataBindingNavigator.BindingSource = Me.UserDataBindingSource
        Me.UserDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserDataBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.UserDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserDataBindingNavigatorSaveItem})
        Me.UserDataBindingNavigator.Location = New System.Drawing.Point(222, 237)
        Me.UserDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserDataBindingNavigator.Name = "UserDataBindingNavigator"
        Me.UserDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserDataBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.UserDataBindingNavigator.TabIndex = 0
        Me.UserDataBindingNavigator.Text = "BindingNavigator1"
        Me.UserDataBindingNavigator.Visible = False
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
        'PassportPictureBox
        '
        Me.PassportPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.UserDataBindingSource, "Passport", True))
        Me.PassportPictureBox.ErrorImage = Global.AuthGuard.My.Resources.Resources.BitLocker_icon
        Me.PassportPictureBox.Location = New System.Drawing.Point(401, 24)
        Me.PassportPictureBox.Name = "PassportPictureBox"
        Me.PassportPictureBox.Size = New System.Drawing.Size(131, 130)
        Me.PassportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PassportPictureBox.TabIndex = 14
        Me.PassportPictureBox.TabStop = False
        '
        'RegistrationNumberLabel1
        '
        Me.RegistrationNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrationNumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "RegistrationNumber", True))
        Me.RegistrationNumberLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RegistrationNumberLabel1.Location = New System.Drawing.Point(186, 23)
        Me.RegistrationNumberLabel1.Name = "RegistrationNumberLabel1"
        Me.RegistrationNumberLabel1.Size = New System.Drawing.Size(193, 23)
        Me.RegistrationNumberLabel1.TabIndex = 15
        Me.RegistrationNumberLabel1.Text = "Label1"
        '
        'UsernameLabel1
        '
        Me.UsernameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UsernameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "user", True))
        Me.UsernameLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel1.Location = New System.Drawing.Point(186, 59)
        Me.UsernameLabel1.Name = "UsernameLabel1"
        Me.UsernameLabel1.Size = New System.Drawing.Size(193, 23)
        Me.UsernameLabel1.TabIndex = 16
        Me.UsernameLabel1.Text = "Label1"
        '
        'PasswordLabel1
        '
        Me.PasswordLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PasswordLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordLabel1.Location = New System.Drawing.Point(186, 95)
        Me.PasswordLabel1.Name = "PasswordLabel1"
        Me.PasswordLabel1.Size = New System.Drawing.Size(193, 23)
        Me.PasswordLabel1.TabIndex = 17
        Me.PasswordLabel1.Text = "**********"
        '
        'SurnameLabel1
        '
        Me.SurnameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SurnameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "Surname", True))
        Me.SurnameLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SurnameLabel1.Location = New System.Drawing.Point(186, 131)
        Me.SurnameLabel1.Name = "SurnameLabel1"
        Me.SurnameLabel1.Size = New System.Drawing.Size(193, 23)
        Me.SurnameLabel1.TabIndex = 18
        Me.SurnameLabel1.Text = "Label1"
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FirstNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "FirstName", True))
        Me.FirstNameLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FirstNameLabel1.Location = New System.Drawing.Point(186, 167)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(193, 23)
        Me.FirstNameLabel1.TabIndex = 19
        Me.FirstNameLabel1.Text = "Label1"
        '
        'ClearanceLevelLabel1
        '
        Me.ClearanceLevelLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ClearanceLevelLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserDataBindingSource, "ClearanceLevel", True))
        Me.ClearanceLevelLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ClearanceLevelLabel1.Location = New System.Drawing.Point(186, 203)
        Me.ClearanceLevelLabel1.Name = "ClearanceLevelLabel1"
        Me.ClearanceLevelLabel1.Size = New System.Drawing.Size(193, 23)
        Me.ClearanceLevelLabel1.TabIndex = 20
        Me.ClearanceLevelLabel1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RegistrationNumberLabel1)
        Me.GroupBox1.Controls.Add(ClearanceLevelLabel)
        Me.GroupBox1.Controls.Add(Me.PassportPictureBox)
        Me.GroupBox1.Controls.Add(Me.ClearanceLevelLabel1)
        Me.GroupBox1.Controls.Add(RegistrationNumberLabel)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel1)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel1)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel1)
        Me.GroupBox1.Controls.Add(Me.SurnameLabel1)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 254)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'frmUserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 268)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UserDataBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserInformation"
        Me.Text = "User Information"
        CType(Me.AuthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserDataBindingNavigator.ResumeLayout(False)
        Me.UserDataBindingNavigator.PerformLayout()
        CType(Me.PassportPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents PassportPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RegistrationNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel1 As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel1 As System.Windows.Forms.Label
    Friend WithEvents SurnameLabel1 As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents ClearanceLevelLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
