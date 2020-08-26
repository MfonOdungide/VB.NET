<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim MatricNumberLabel As System.Windows.Forms.Label
        Dim CourseCodeLabel As System.Windows.Forms.Label
        Dim CourseTitleLabel As System.Windows.Forms.Label
        Dim IntroductionLabel As System.Windows.Forms.Label
        Dim TopicsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.UserData_DataSet = New EIE_eLearning.UserData_DataSet()
        Me.CatalogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalogTableAdapter = New EIE_eLearning.UserData_DataSetTableAdapters.CatalogTableAdapter()
        Me.TableAdapterManager = New EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.CatalogDataGridView = New System.Windows.Forms.DataGridView()
        Me.Topics = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoursesTableAdapter = New EIE_eLearning.UserData_DataSetTableAdapters.CoursesTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bttnTakeCourse = New System.Windows.Forms.Button()
        Me.TopicsLabel1 = New System.Windows.Forms.Label()
        Me.IntroductionLabel1 = New System.Windows.Forms.Label()
        Me.CourseTitleLabel1 = New System.Windows.Forms.Label()
        Me.CourseCodeLabel1 = New System.Windows.Forms.Label()
        Me.MatricNumberLabel1 = New System.Windows.Forms.Label()
        Me.AuthorLabel1 = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatricNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopicsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntroductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Field9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Field10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AuthorLabel = New System.Windows.Forms.Label()
        MatricNumberLabel = New System.Windows.Forms.Label()
        CourseCodeLabel = New System.Windows.Forms.Label()
        CourseTitleLabel = New System.Windows.Forms.Label()
        IntroductionLabel = New System.Windows.Forms.Label()
        TopicsLabel = New System.Windows.Forms.Label()
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CatalogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(10, 40)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 0
        AuthorLabel.Text = "Author:"
        '
        'MatricNumberLabel
        '
        MatricNumberLabel.AutoSize = True
        MatricNumberLabel.Location = New System.Drawing.Point(10, 63)
        MatricNumberLabel.Name = "MatricNumberLabel"
        MatricNumberLabel.Size = New System.Drawing.Size(79, 13)
        MatricNumberLabel.TabIndex = 2
        MatricNumberLabel.Text = "Matric Number:"
        '
        'CourseCodeLabel
        '
        CourseCodeLabel.AutoSize = True
        CourseCodeLabel.Location = New System.Drawing.Point(10, 86)
        CourseCodeLabel.Name = "CourseCodeLabel"
        CourseCodeLabel.Size = New System.Drawing.Size(71, 13)
        CourseCodeLabel.TabIndex = 4
        CourseCodeLabel.Text = "Course Code:"
        '
        'CourseTitleLabel
        '
        CourseTitleLabel.AutoSize = True
        CourseTitleLabel.Location = New System.Drawing.Point(10, 109)
        CourseTitleLabel.Name = "CourseTitleLabel"
        CourseTitleLabel.Size = New System.Drawing.Size(66, 13)
        CourseTitleLabel.TabIndex = 6
        CourseTitleLabel.Text = "Course Title:"
        '
        'IntroductionLabel
        '
        IntroductionLabel.AutoSize = True
        IntroductionLabel.Location = New System.Drawing.Point(10, 155)
        IntroductionLabel.Name = "IntroductionLabel"
        IntroductionLabel.Size = New System.Drawing.Size(47, 13)
        IntroductionLabel.TabIndex = 8
        IntroductionLabel.Text = "Content:"
        '
        'TopicsLabel
        '
        TopicsLabel.AutoSize = True
        TopicsLabel.Location = New System.Drawing.Point(10, 132)
        TopicsLabel.Name = "TopicsLabel"
        TopicsLabel.Size = New System.Drawing.Size(45, 13)
        TopicsLabel.TabIndex = 10
        TopicsLabel.Text = "Module:"
        '
        'UserData_DataSet
        '
        Me.UserData_DataSet.DataSetName = "UserData_DataSet"
        Me.UserData_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatalogBindingSource
        '
        Me.CatalogBindingSource.DataMember = "Catalog"
        Me.CatalogBindingSource.DataSource = Me.UserData_DataSet
        '
        'CatalogTableAdapter
        '
        Me.CatalogTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatalogTableAdapter = Me.CatalogTableAdapter
        Me.TableAdapterManager.CoursesTableAdapter = Nothing
        Me.TableAdapterManager.GradesTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserDataTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboSort)
        Me.GroupBox1.Controls.Add(Me.CatalogDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 380)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search:"
        '
        'cboSort
        '
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Location = New System.Drawing.Point(62, 21)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(269, 21)
        Me.cboSort.TabIndex = 0
        '
        'CatalogDataGridView
        '
        Me.CatalogDataGridView.AllowUserToAddRows = False
        Me.CatalogDataGridView.AllowUserToDeleteRows = False
        Me.CatalogDataGridView.AllowUserToOrderColumns = True
        Me.CatalogDataGridView.AllowUserToResizeColumns = False
        Me.CatalogDataGridView.AllowUserToResizeRows = False
        Me.CatalogDataGridView.AutoGenerateColumns = False
        Me.CatalogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CatalogDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CatalogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CatalogDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CatalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CatalogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Topics, Me.AuthorDataGridViewTextBoxColumn, Me.MatricNumberDataGridViewTextBoxColumn, Me.GroupDataGridViewTextBoxColumn, Me.CourseCodeDataGridViewTextBoxColumn, Me.CourseTitleDataGridViewTextBoxColumn, Me.TopicsDataGridViewTextBoxColumn, Me.IntroductionDataGridViewTextBoxColumn, Me.Field9DataGridViewTextBoxColumn, Me.Field10DataGridViewTextBoxColumn})
        Me.CatalogDataGridView.DataSource = Me.CatalogBindingSource
        Me.CatalogDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.CatalogDataGridView.Name = "CatalogDataGridView"
        Me.CatalogDataGridView.ReadOnly = True
        Me.CatalogDataGridView.Size = New System.Drawing.Size(319, 316)
        Me.CatalogDataGridView.TabIndex = 1
        '
        'Topics
        '
        Me.Topics.DataPropertyName = "Topics"
        Me.Topics.HeaderText = "Modules"
        Me.Topics.Name = "Topics"
        Me.Topics.ReadOnly = True
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "Courses"
        Me.CoursesBindingSource.DataSource = Me.UserData_DataSet
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bttnTakeCourse)
        Me.GroupBox2.Controls.Add(TopicsLabel)
        Me.GroupBox2.Controls.Add(Me.TopicsLabel1)
        Me.GroupBox2.Controls.Add(IntroductionLabel)
        Me.GroupBox2.Controls.Add(Me.IntroductionLabel1)
        Me.GroupBox2.Controls.Add(CourseTitleLabel)
        Me.GroupBox2.Controls.Add(Me.CourseTitleLabel1)
        Me.GroupBox2.Controls.Add(CourseCodeLabel)
        Me.GroupBox2.Controls.Add(Me.CourseCodeLabel1)
        Me.GroupBox2.Controls.Add(MatricNumberLabel)
        Me.GroupBox2.Controls.Add(Me.MatricNumberLabel1)
        Me.GroupBox2.Controls.Add(AuthorLabel)
        Me.GroupBox2.Controls.Add(Me.AuthorLabel1)
        Me.GroupBox2.Location = New System.Drawing.Point(366, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 380)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'bttnTakeCourse
        '
        Me.bttnTakeCourse.Location = New System.Drawing.Point(246, 332)
        Me.bttnTakeCourse.Name = "bttnTakeCourse"
        Me.bttnTakeCourse.Size = New System.Drawing.Size(136, 32)
        Me.bttnTakeCourse.TabIndex = 12
        Me.bttnTakeCourse.Text = "Take Course"
        Me.bttnTakeCourse.UseVisualStyleBackColor = True
        '
        'TopicsLabel1
        '
        Me.TopicsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TopicsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatalogBindingSource, "Topics", True))
        Me.TopicsLabel1.Location = New System.Drawing.Point(96, 132)
        Me.TopicsLabel1.Name = "TopicsLabel1"
        Me.TopicsLabel1.Size = New System.Drawing.Size(286, 20)
        Me.TopicsLabel1.TabIndex = 11
        '
        'IntroductionLabel1
        '
        Me.IntroductionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IntroductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatalogBindingSource, "Introduction", True))
        Me.IntroductionLabel1.Location = New System.Drawing.Point(96, 155)
        Me.IntroductionLabel1.Name = "IntroductionLabel1"
        Me.IntroductionLabel1.Size = New System.Drawing.Size(286, 163)
        Me.IntroductionLabel1.TabIndex = 9
        '
        'CourseTitleLabel1
        '
        Me.CourseTitleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CourseTitleLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatalogBindingSource, "CourseTitle", True))
        Me.CourseTitleLabel1.Location = New System.Drawing.Point(96, 109)
        Me.CourseTitleLabel1.Name = "CourseTitleLabel1"
        Me.CourseTitleLabel1.Size = New System.Drawing.Size(286, 20)
        Me.CourseTitleLabel1.TabIndex = 7
        '
        'CourseCodeLabel1
        '
        Me.CourseCodeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CourseCodeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatalogBindingSource, "CourseCode", True))
        Me.CourseCodeLabel1.Location = New System.Drawing.Point(96, 86)
        Me.CourseCodeLabel1.Name = "CourseCodeLabel1"
        Me.CourseCodeLabel1.Size = New System.Drawing.Size(286, 20)
        Me.CourseCodeLabel1.TabIndex = 5
        '
        'MatricNumberLabel1
        '
        Me.MatricNumberLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MatricNumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatalogBindingSource, "MatricNumber", True))
        Me.MatricNumberLabel1.Location = New System.Drawing.Point(96, 63)
        Me.MatricNumberLabel1.Name = "MatricNumberLabel1"
        Me.MatricNumberLabel1.Size = New System.Drawing.Size(286, 20)
        Me.MatricNumberLabel1.TabIndex = 3
        '
        'AuthorLabel1
        '
        Me.AuthorLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AuthorLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CatalogBindingSource, "Author", True))
        Me.AuthorLabel1.Location = New System.Drawing.Point(96, 40)
        Me.AuthorLabel1.Name = "AuthorLabel1"
        Me.AuthorLabel1.Size = New System.Drawing.Size(286, 20)
        Me.AuthorLabel1.TabIndex = 1
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Location = New System.Drawing.Point(624, 399)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(139, 13)
        Me.lblAbout.TabIndex = 5
        Me.lblAbout.Text = "© 2013 CSSolutions Limited"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatricNumberDataGridViewTextBoxColumn
        '
        Me.MatricNumberDataGridViewTextBoxColumn.DataPropertyName = "MatricNumber"
        Me.MatricNumberDataGridViewTextBoxColumn.HeaderText = "MatricNumber"
        Me.MatricNumberDataGridViewTextBoxColumn.Name = "MatricNumberDataGridViewTextBoxColumn"
        Me.MatricNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupDataGridViewTextBoxColumn
        '
        Me.GroupDataGridViewTextBoxColumn.DataPropertyName = "Group"
        Me.GroupDataGridViewTextBoxColumn.HeaderText = "Group"
        Me.GroupDataGridViewTextBoxColumn.Name = "GroupDataGridViewTextBoxColumn"
        Me.GroupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseCodeDataGridViewTextBoxColumn
        '
        Me.CourseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode"
        Me.CourseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode"
        Me.CourseCodeDataGridViewTextBoxColumn.Name = "CourseCodeDataGridViewTextBoxColumn"
        Me.CourseCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseTitleDataGridViewTextBoxColumn
        '
        Me.CourseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle"
        Me.CourseTitleDataGridViewTextBoxColumn.HeaderText = "CourseTitle"
        Me.CourseTitleDataGridViewTextBoxColumn.Name = "CourseTitleDataGridViewTextBoxColumn"
        Me.CourseTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TopicsDataGridViewTextBoxColumn
        '
        Me.TopicsDataGridViewTextBoxColumn.DataPropertyName = "Topics"
        Me.TopicsDataGridViewTextBoxColumn.HeaderText = "Topics"
        Me.TopicsDataGridViewTextBoxColumn.Name = "TopicsDataGridViewTextBoxColumn"
        Me.TopicsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IntroductionDataGridViewTextBoxColumn
        '
        Me.IntroductionDataGridViewTextBoxColumn.DataPropertyName = "Introduction"
        Me.IntroductionDataGridViewTextBoxColumn.HeaderText = "Introduction"
        Me.IntroductionDataGridViewTextBoxColumn.Name = "IntroductionDataGridViewTextBoxColumn"
        Me.IntroductionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Field9DataGridViewTextBoxColumn
        '
        Me.Field9DataGridViewTextBoxColumn.DataPropertyName = "Field9"
        Me.Field9DataGridViewTextBoxColumn.HeaderText = "Field9"
        Me.Field9DataGridViewTextBoxColumn.Name = "Field9DataGridViewTextBoxColumn"
        Me.Field9DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Field10DataGridViewTextBoxColumn
        '
        Me.Field10DataGridViewTextBoxColumn.DataPropertyName = "Field10"
        Me.Field10DataGridViewTextBoxColumn.HeaderText = "Field10"
        Me.Field10DataGridViewTextBoxColumn.Name = "Field10DataGridViewTextBoxColumn"
        Me.Field10DataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 421)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CatalogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserData_DataSet As EIE_eLearning.UserData_DataSet
    Friend WithEvents CatalogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatalogTableAdapter As EIE_eLearning.UserData_DataSetTableAdapters.CatalogTableAdapter
    Friend WithEvents TableAdapterManager As EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoursesTableAdapter As EIE_eLearning.UserData_DataSetTableAdapters.CoursesTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CatalogDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TopicsLabel1 As System.Windows.Forms.Label
    Friend WithEvents IntroductionLabel1 As System.Windows.Forms.Label
    Friend WithEvents CourseTitleLabel1 As System.Windows.Forms.Label
    Friend WithEvents CourseCodeLabel1 As System.Windows.Forms.Label
    Friend WithEvents MatricNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents AuthorLabel1 As System.Windows.Forms.Label
    Friend WithEvents bttnTakeCourse As System.Windows.Forms.Button
    Friend WithEvents cboSort As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents Topics As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatricNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TopicsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntroductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Field9DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Field10DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
