<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest))
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Ctrl2 = New System.Windows.Forms.Label()
        Me.bttnEndExams = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.minutes_label = New System.Windows.Forms.Label()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSet()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.CorrectOption = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.txtQuestionNumber = New System.Windows.Forms.TextBox()
        Me.txtChosenOption = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.hours_label = New System.Windows.Forms.Label()
        Me.grpHolder = New System.Windows.Forms.GroupBox()
        Me.txtNo_Of_Questions = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.seconds_label = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTimerInformation = New System.Windows.Forms.Label()
        Me.lblShowExhibit = New System.Windows.Forms.Label()
        Me.lblNo_Of_Questions = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.Question = New System.Windows.Forms.RichTextBox()
        Me.OptionD = New System.Windows.Forms.RadioButton()
        Me.OptionC = New System.Windows.Forms.RadioButton()
        Me.OptionB = New System.Windows.Forms.RadioButton()
        Me.OptionA = New System.Windows.Forms.RadioButton()
        Me.bttnNext = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ExamsTableAdapter = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.ExamsTableAdapter()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.SettingsTableAdapter()
        Me.blink = New System.Windows.Forms.Timer(Me.components)
        Me.Cover = New System.Windows.Forms.Label()
        Me.txtInstruction = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHolder.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bttnEndExams)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 535)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Ctrl2
        '
        Me.Ctrl2.Location = New System.Drawing.Point(6, 628)
        Me.Ctrl2.Name = "Ctrl2"
        Me.Ctrl2.Size = New System.Drawing.Size(835, 36)
        Me.Ctrl2.TabIndex = 48
        Me.Ctrl2.Text = ".."
        '
        'bttnEndExams
        '
        Me.bttnEndExams.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnEndExams.Location = New System.Drawing.Point(90, 495)
        Me.bttnEndExams.Name = "bttnEndExams"
        Me.bttnEndExams.Size = New System.Drawing.Size(107, 34)
        Me.bttnEndExams.TabIndex = 4
        Me.bttnEndExams.Text = "End Exams"
        Me.bttnEndExams.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(211, 408)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'minutes_label
        '
        Me.minutes_label.AutoSize = True
        Me.minutes_label.Location = New System.Drawing.Point(269, 637)
        Me.minutes_label.Name = "minutes_label"
        Me.minutes_label.Size = New System.Drawing.Size(13, 13)
        Me.minutes_label.TabIndex = 24
        Me.minutes_label.Text = "1"
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.BindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator.Location = New System.Drawing.Point(330, 635)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator.Size = New System.Drawing.Size(255, 25)
        Me.BindingNavigator.TabIndex = 23
        Me.BindingNavigator.Text = "BindingNavigator1"
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
        'BindingSource
        '
        Me.BindingSource.DataMember = "Exams"
        Me.BindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'CorrectOption
        '
        Me.CorrectOption.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "CorrectOption", True))
        Me.CorrectOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectOption.Location = New System.Drawing.Point(677, 636)
        Me.CorrectOption.Name = "CorrectOption"
        Me.CorrectOption.Size = New System.Drawing.Size(49, 26)
        Me.CorrectOption.TabIndex = 38
        Me.CorrectOption.Text = "Answer"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(588, 637)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse.TabIndex = 48
        Me.txtCourse.Text = "Excel"
        '
        'txtQ
        '
        Me.txtQ.Location = New System.Drawing.Point(13, 635)
        Me.txtQ.Name = "txtQ"
        Me.txtQ.Size = New System.Drawing.Size(53, 20)
        Me.txtQ.TabIndex = 9
        Me.txtQ.Text = "txtQ"
        '
        'txtQuestionNumber
        '
        Me.txtQuestionNumber.Location = New System.Drawing.Point(67, 635)
        Me.txtQuestionNumber.Name = "txtQuestionNumber"
        Me.txtQuestionNumber.Size = New System.Drawing.Size(42, 20)
        Me.txtQuestionNumber.TabIndex = 19
        Me.txtQuestionNumber.Text = "0"
        '
        'txtChosenOption
        '
        Me.txtChosenOption.Location = New System.Drawing.Point(170, 635)
        Me.txtChosenOption.Name = "txtChosenOption"
        Me.txtChosenOption.Size = New System.Drawing.Size(54, 20)
        Me.txtChosenOption.TabIndex = 22
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(13, 232)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(20, 21)
        Me.lblB.TabIndex = 37
        Me.lblB.Text = "B"
        '
        'hours_label
        '
        Me.hours_label.AutoSize = True
        Me.hours_label.Location = New System.Drawing.Point(244, 637)
        Me.hours_label.Name = "hours_label"
        Me.hours_label.Size = New System.Drawing.Size(19, 13)
        Me.hours_label.TabIndex = 23
        Me.hours_label.Text = "00"
        '
        'grpHolder
        '
        Me.grpHolder.Controls.Add(Me.Ctrl2)
        Me.grpHolder.Controls.Add(Me.txtNo_Of_Questions)
        Me.grpHolder.Controls.Add(Me.CorrectOption)
        Me.grpHolder.Controls.Add(Me.txtCourse)
        Me.grpHolder.Controls.Add(Me.txtQ)
        Me.grpHolder.Controls.Add(Me.txtQuestionNumber)
        Me.grpHolder.Controls.Add(Me.txtChosenOption)
        Me.grpHolder.Controls.Add(Me.hours_label)
        Me.grpHolder.Controls.Add(Me.txtScore)
        Me.grpHolder.Controls.Add(Me.lblAbout)
        Me.grpHolder.Controls.Add(Me.seconds_label)
        Me.grpHolder.Controls.Add(Me.GroupBox4)
        Me.grpHolder.Controls.Add(Me.GroupBox3)
        Me.grpHolder.Controls.Add(Me.GroupBox2)
        Me.grpHolder.Controls.Add(Me.minutes_label)
        Me.grpHolder.Controls.Add(Me.BindingNavigator)
        Me.grpHolder.Location = New System.Drawing.Point(21, 12)
        Me.grpHolder.Name = "grpHolder"
        Me.grpHolder.Size = New System.Drawing.Size(1025, 667)
        Me.grpHolder.TabIndex = 2
        Me.grpHolder.TabStop = False
        '
        'txtNo_Of_Questions
        '
        Me.txtNo_Of_Questions.Location = New System.Drawing.Point(732, 637)
        Me.txtNo_Of_Questions.Name = "txtNo_Of_Questions"
        Me.txtNo_Of_Questions.Size = New System.Drawing.Size(62, 20)
        Me.txtNo_Of_Questions.TabIndex = 49
        Me.txtNo_Of_Questions.Text = "15"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(110, 635)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(54, 20)
        Me.txtScore.TabIndex = 20
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Transparent
        Me.lblAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(865, 646)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(138, 15)
        Me.lblAbout.TabIndex = 47
        Me.lblAbout.Text = "© 2014 Invasion Systems"
        '
        'seconds_label
        '
        Me.seconds_label.AutoSize = True
        Me.seconds_label.Location = New System.Drawing.Point(294, 637)
        Me.seconds_label.Name = "seconds_label"
        Me.seconds_label.Size = New System.Drawing.Size(19, 13)
        Me.seconds_label.TabIndex = 25
        Me.seconds_label.Text = "10"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTimer)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(226, 86)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(17, 16)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(194, 59)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.Text = "00:00:00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtInstruction)
        Me.GroupBox3.Controls.Add(Me.lblTimerInformation)
        Me.GroupBox3.Controls.Add(Me.Cover)
        Me.GroupBox3.Controls.Add(Me.lblShowExhibit)
        Me.GroupBox3.Controls.Add(Me.lblNo_Of_Questions)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblQuestionNumber)
        Me.GroupBox3.Controls.Add(Me.lblD)
        Me.GroupBox3.Controls.Add(Me.lblC)
        Me.GroupBox3.Controls.Add(Me.lblB)
        Me.GroupBox3.Controls.Add(Me.lblA)
        Me.GroupBox3.Controls.Add(Me.Question)
        Me.GroupBox3.Controls.Add(Me.OptionD)
        Me.GroupBox3.Controls.Add(Me.OptionC)
        Me.GroupBox3.Controls.Add(Me.OptionB)
        Me.GroupBox3.Controls.Add(Me.OptionA)
        Me.GroupBox3.Controls.Add(Me.bttnNext)
        Me.GroupBox3.Controls.Add(Me.ProgressBar)
        Me.GroupBox3.Location = New System.Drawing.Point(238, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(777, 617)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'lblTimerInformation
        '
        Me.lblTimerInformation.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerInformation.Location = New System.Drawing.Point(6, 547)
        Me.lblTimerInformation.Name = "lblTimerInformation"
        Me.lblTimerInformation.Size = New System.Drawing.Size(767, 30)
        Me.lblTimerInformation.TabIndex = 40
        Me.lblTimerInformation.Text = "Timer Information"
        Me.lblTimerInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTimerInformation.Visible = False
        '
        'lblShowExhibit
        '
        Me.lblShowExhibit.AutoSize = True
        Me.lblShowExhibit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.lblShowExhibit.Location = New System.Drawing.Point(673, 107)
        Me.lblShowExhibit.Name = "lblShowExhibit"
        Me.lblShowExhibit.Size = New System.Drawing.Size(90, 15)
        Me.lblShowExhibit.TabIndex = 39
        Me.lblShowExhibit.Text = "Show Exhibit"
        Me.lblShowExhibit.Visible = False
        '
        'lblNo_Of_Questions
        '
        Me.lblNo_Of_Questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblNo_Of_Questions.Location = New System.Drawing.Point(14, 69)
        Me.lblNo_Of_Questions.Name = "lblNo_Of_Questions"
        Me.lblNo_Of_Questions.Size = New System.Drawing.Size(32, 16)
        Me.lblNo_Of_Questions.TabIndex = 38
        Me.lblNo_Of_Questions.Text = "150"
        Me.lblNo_Of_Questions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "of"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(4, 23)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(52, 25)
        Me.lblQuestionNumber.TabIndex = 38
        Me.lblQuestionNumber.Text = "080"
        Me.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(13, 391)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(21, 21)
        Me.lblD.TabIndex = 37
        Me.lblD.Text = "D"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(13, 313)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(20, 21)
        Me.lblC.TabIndex = 37
        Me.lblC.Text = "C"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(12, 148)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 21)
        Me.lblA.TabIndex = 37
        Me.lblA.Text = "A"
        '
        'Question
        '
        Me.Question.BackColor = System.Drawing.SystemColors.Control
        Me.Question.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Question.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Question", True))
        Me.Question.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question.Location = New System.Drawing.Point(59, 21)
        Me.Question.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Question.Name = "Question"
        Me.Question.ReadOnly = True
        Me.Question.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Question.Size = New System.Drawing.Size(675, 88)
        Me.Question.TabIndex = 26
        Me.Question.Text = "Question"
        '
        'OptionD
        '
        Me.OptionD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "OptionD", True))
        Me.OptionD.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionD.Location = New System.Drawing.Point(34, 365)
        Me.OptionD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptionD.Name = "OptionD"
        Me.OptionD.Size = New System.Drawing.Size(675, 73)
        Me.OptionD.TabIndex = 23
        Me.OptionD.TabStop = True
        Me.OptionD.Text = "OptionD"
        Me.OptionD.UseVisualStyleBackColor = True
        '
        'OptionC
        '
        Me.OptionC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "OptionC", True))
        Me.OptionC.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionC.Location = New System.Drawing.Point(34, 287)
        Me.OptionC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptionC.Name = "OptionC"
        Me.OptionC.Size = New System.Drawing.Size(675, 73)
        Me.OptionC.TabIndex = 22
        Me.OptionC.TabStop = True
        Me.OptionC.Text = "OptionC"
        Me.OptionC.UseVisualStyleBackColor = True
        '
        'OptionB
        '
        Me.OptionB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "OptionB", True))
        Me.OptionB.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionB.Location = New System.Drawing.Point(34, 206)
        Me.OptionB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptionB.Name = "OptionB"
        Me.OptionB.Size = New System.Drawing.Size(675, 73)
        Me.OptionB.TabIndex = 25
        Me.OptionB.TabStop = True
        Me.OptionB.Text = "OptionB"
        Me.OptionB.UseVisualStyleBackColor = True
        '
        'OptionA
        '
        Me.OptionA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "OptionA", True))
        Me.OptionA.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionA.Location = New System.Drawing.Point(34, 123)
        Me.OptionA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptionA.Name = "OptionA"
        Me.OptionA.Size = New System.Drawing.Size(675, 73)
        Me.OptionA.TabIndex = 24
        Me.OptionA.TabStop = True
        Me.OptionA.Text = "OptionA"
        Me.OptionA.UseVisualStyleBackColor = True
        '
        'bttnNext
        '
        Me.bttnNext.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnNext.Location = New System.Drawing.Point(670, 580)
        Me.bttnNext.Name = "bttnNext"
        Me.bttnNext.Size = New System.Drawing.Size(92, 34)
        Me.bttnNext.TabIndex = 17
        Me.bttnNext.Text = "START"
        Me.bttnNext.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(6, 592)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(658, 18)
        Me.ProgressBar.TabIndex = 21
        '
        'ExamsTableAdapter
        '
        Me.ExamsTableAdapter.ClearBeforeFill = True
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DataDataSet
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'blink
        '
        Me.blink.Interval = 1000
        '
        'Cover
        '
        Me.Cover.Location = New System.Drawing.Point(10, 11)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(756, 552)
        Me.Cover.TabIndex = 52
        Me.Cover.Text = ".."
        '
        'txtInstruction
        '
        Me.txtInstruction.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtInstruction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInstruction.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstruction.Location = New System.Drawing.Point(38, 38)
        Me.txtInstruction.Name = "txtInstruction"
        Me.txtInstruction.Size = New System.Drawing.Size(700, 540)
        Me.txtInstruction.TabIndex = 53
        Me.txtInstruction.Text = resources.GetString("txtInstruction.Text")
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 675)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmTest"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Invasion Systems - CBOT"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHolder.ResumeLayout(False)
        Me.grpHolder.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Ctrl2 As System.Windows.Forms.Label
    Friend WithEvents bttnEndExams As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents minutes_label As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents CorrectOption As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtQ As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestionNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtChosenOption As System.Windows.Forms.TextBox
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents hours_label As System.Windows.Forms.Label
    Friend WithEvents grpHolder As System.Windows.Forms.GroupBox
    Friend WithEvents txtNo_Of_Questions As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents seconds_label As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents Question As System.Windows.Forms.RichTextBox
    Friend WithEvents OptionD As System.Windows.Forms.RadioButton
    Friend WithEvents OptionC As System.Windows.Forms.RadioButton
    Friend WithEvents OptionB As System.Windows.Forms.RadioButton
    Friend WithEvents OptionA As System.Windows.Forms.RadioButton
    Friend WithEvents bttnNext As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents lblShowExhibit As System.Windows.Forms.Label
    Friend WithEvents lblNo_Of_Questions As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataDataSet As Invasion_Systems_Computer_Based_Objective_Test.dataDataSet
    Friend WithEvents ExamsTableAdapter As Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.ExamsTableAdapter
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As Invasion_Systems_Computer_Based_Objective_Test.dataDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents lblTimerInformation As System.Windows.Forms.Label
    Friend WithEvents blink As System.Windows.Forms.Timer
    Friend WithEvents Cover As System.Windows.Forms.Label
    Friend WithEvents txtInstruction As System.Windows.Forms.RichTextBox
End Class
