<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalog
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
        Dim TopicsLabel2 As System.Windows.Forms.Label
        Dim CourseCodeLabel As System.Windows.Forms.Label
        Dim CourseTitleLabel As System.Windows.Forms.Label
        Dim KeywordsLabel As System.Windows.Forms.Label
        Dim IntroductionLabel1 As System.Windows.Forms.Label
        Me.UserData_DataSet = New EIE_eLearning.UserData_DataSet()
        Me.CatalogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalogTableAdapter = New EIE_eLearning.UserData_DataSetTableAdapters.CatalogTableAdapter()
        Me.TableAdapterManager = New EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager()
        Me.CoursesTableAdapter = New EIE_eLearning.UserData_DataSetTableAdapters.CoursesTableAdapter()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopicsTextBox = New System.Windows.Forms.TextBox()
        Me.CoursesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CourseTitleTextBox = New System.Windows.Forms.TextBox()
        Me.KeywordsTextBox = New System.Windows.Forms.TextBox()
        Me.IntroductionTextBox = New System.Windows.Forms.TextBox()
        Me.Keywords = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        TopicsLabel2 = New System.Windows.Forms.Label()
        CourseCodeLabel = New System.Windows.Forms.Label()
        CourseTitleLabel = New System.Windows.Forms.Label()
        KeywordsLabel = New System.Windows.Forms.Label()
        IntroductionLabel1 = New System.Windows.Forms.Label()
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopicsLabel2
        '
        TopicsLabel2.AutoSize = True
        TopicsLabel2.Location = New System.Drawing.Point(349, 110)
        TopicsLabel2.Name = "TopicsLabel2"
        TopicsLabel2.Size = New System.Drawing.Size(50, 13)
        TopicsLabel2.TabIndex = 8
        TopicsLabel2.Text = "Modules:"
        '
        'CourseCodeLabel
        '
        CourseCodeLabel.AutoSize = True
        CourseCodeLabel.Location = New System.Drawing.Point(328, 32)
        CourseCodeLabel.Name = "CourseCodeLabel"
        CourseCodeLabel.Size = New System.Drawing.Size(71, 13)
        CourseCodeLabel.TabIndex = 9
        CourseCodeLabel.Text = "Course Code:"
        '
        'CourseTitleLabel
        '
        CourseTitleLabel.AutoSize = True
        CourseTitleLabel.Location = New System.Drawing.Point(333, 58)
        CourseTitleLabel.Name = "CourseTitleLabel"
        CourseTitleLabel.Size = New System.Drawing.Size(66, 13)
        CourseTitleLabel.TabIndex = 10
        CourseTitleLabel.Text = "Course Title:"
        '
        'KeywordsLabel
        '
        KeywordsLabel.AutoSize = True
        KeywordsLabel.Location = New System.Drawing.Point(343, 84)
        KeywordsLabel.Name = "KeywordsLabel"
        KeywordsLabel.Size = New System.Drawing.Size(56, 13)
        KeywordsLabel.TabIndex = 11
        KeywordsLabel.Text = "Keywords:"
        '
        'IntroductionLabel1
        '
        IntroductionLabel1.AutoSize = True
        IntroductionLabel1.Location = New System.Drawing.Point(333, 189)
        IntroductionLabel1.Name = "IntroductionLabel1"
        IntroductionLabel1.Size = New System.Drawing.Size(66, 13)
        IntroductionLabel1.TabIndex = 12
        IntroductionLabel1.Text = "Introduction:"
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
        Me.TableAdapterManager.CoursesTableAdapter = Me.CoursesTableAdapter
        Me.TableAdapterManager.GradesTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserDataTableAdapter = Nothing
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "Courses"
        Me.CoursesBindingSource.DataSource = Me.UserData_DataSet
        '
        'TopicsTextBox
        '
        Me.TopicsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoursesBindingSource, "Topics", True))
        Me.TopicsTextBox.Location = New System.Drawing.Point(405, 107)
        Me.TopicsTextBox.Multiline = True
        Me.TopicsTextBox.Name = "TopicsTextBox"
        Me.TopicsTextBox.ReadOnly = True
        Me.TopicsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TopicsTextBox.Size = New System.Drawing.Size(297, 73)
        Me.TopicsTextBox.TabIndex = 9
        '
        'CoursesDataGridView
        '
        Me.CoursesDataGridView.AllowUserToAddRows = False
        Me.CoursesDataGridView.AllowUserToDeleteRows = False
        Me.CoursesDataGridView.AllowUserToOrderColumns = True
        Me.CoursesDataGridView.AutoGenerateColumns = False
        Me.CoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CoursesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CoursesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Keywords})
        Me.CoursesDataGridView.DataSource = Me.CoursesBindingSource
        Me.CoursesDataGridView.Location = New System.Drawing.Point(12, 51)
        Me.CoursesDataGridView.Name = "CoursesDataGridView"
        Me.CoursesDataGridView.ReadOnly = True
        Me.CoursesDataGridView.Size = New System.Drawing.Size(300, 280)
        Me.CoursesDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CourseCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Course Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CourseTitle"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Course Title"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CourseCodeTextBox
        '
        Me.CourseCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoursesBindingSource, "CourseCode", True))
        Me.CourseCodeTextBox.Location = New System.Drawing.Point(405, 29)
        Me.CourseCodeTextBox.Name = "CourseCodeTextBox"
        Me.CourseCodeTextBox.Size = New System.Drawing.Size(297, 20)
        Me.CourseCodeTextBox.TabIndex = 10
        '
        'CourseTitleTextBox
        '
        Me.CourseTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoursesBindingSource, "CourseTitle", True))
        Me.CourseTitleTextBox.Location = New System.Drawing.Point(405, 55)
        Me.CourseTitleTextBox.Name = "CourseTitleTextBox"
        Me.CourseTitleTextBox.Size = New System.Drawing.Size(297, 20)
        Me.CourseTitleTextBox.TabIndex = 11
        '
        'KeywordsTextBox
        '
        Me.KeywordsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoursesBindingSource, "Keywords", True))
        Me.KeywordsTextBox.Location = New System.Drawing.Point(405, 81)
        Me.KeywordsTextBox.Name = "KeywordsTextBox"
        Me.KeywordsTextBox.Size = New System.Drawing.Size(297, 20)
        Me.KeywordsTextBox.TabIndex = 12
        '
        'IntroductionTextBox
        '
        Me.IntroductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoursesBindingSource, "Introduction", True))
        Me.IntroductionTextBox.Location = New System.Drawing.Point(405, 186)
        Me.IntroductionTextBox.Multiline = True
        Me.IntroductionTextBox.Name = "IntroductionTextBox"
        Me.IntroductionTextBox.ReadOnly = True
        Me.IntroductionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.IntroductionTextBox.Size = New System.Drawing.Size(297, 139)
        Me.IntroductionTextBox.TabIndex = 13
        '
        'Keywords
        '
        Me.Keywords.DataPropertyName = "Keywords"
        Me.Keywords.HeaderText = "Keywords"
        Me.Keywords.Name = "Keywords"
        Me.Keywords.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 20)
        Me.TextBox1.TabIndex = 15
        '
        'frmCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 381)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(IntroductionLabel1)
        Me.Controls.Add(Me.IntroductionTextBox)
        Me.Controls.Add(KeywordsLabel)
        Me.Controls.Add(Me.KeywordsTextBox)
        Me.Controls.Add(CourseTitleLabel)
        Me.Controls.Add(Me.CourseTitleTextBox)
        Me.Controls.Add(CourseCodeLabel)
        Me.Controls.Add(Me.CourseCodeTextBox)
        Me.Controls.Add(Me.CoursesDataGridView)
        Me.Controls.Add(TopicsLabel2)
        Me.Controls.Add(Me.TopicsTextBox)
        Me.Name = "frmCatalog"
        Me.Text = "Catelog"
        CType(Me.UserData_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserData_DataSet As EIE_eLearning.UserData_DataSet
    Friend WithEvents CatalogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatalogTableAdapter As EIE_eLearning.UserData_DataSetTableAdapters.CatalogTableAdapter
    Friend WithEvents TableAdapterManager As EIE_eLearning.UserData_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CoursesTableAdapter As EIE_eLearning.UserData_DataSetTableAdapters.CoursesTableAdapter
    Friend WithEvents CoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TopicsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoursesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CourseCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CourseTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeywordsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IntroductionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keywords As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
