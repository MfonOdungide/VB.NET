<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbUserAccount = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGenerateSessionReport = New System.Windows.Forms.Label()
        Me.lblClearUserLog = New System.Windows.Forms.Label()
        Me.lblSaveSessionLog = New System.Windows.Forms.Label()
        Me.lblClearSessionLog = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLevel = New System.Windows.Forms.TextBox()
        Me.chkDisableAnonynousAdmin = New System.Windows.Forms.CheckBox()
        Me.chkConWindow = New System.Windows.Forms.CheckBox()
        Me.chkWindowsExecution = New System.Windows.Forms.CheckBox()
        Me.chkMultithreading = New System.Windows.Forms.CheckBox()
        Me.chkAnonynousData = New System.Windows.Forms.CheckBox()
        Me.tbApplication = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.lblViewCurrent = New System.Windows.Forms.Label()
        Me.lblChangePassword = New System.Windows.Forms.Label()
        Me.bttnApply = New System.Windows.Forms.Button()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbUserAccount.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbApplication.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbUserAccount)
        Me.TabControl1.Controls.Add(Me.tbApplication)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(399, 387)
        Me.TabControl1.TabIndex = 0
        '
        'tbUserAccount
        '
        Me.tbUserAccount.BackColor = System.Drawing.SystemColors.Control
        Me.tbUserAccount.Controls.Add(Me.GroupBox3)
        Me.tbUserAccount.Controls.Add(Me.GroupBox2)
        Me.tbUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserAccount.Location = New System.Drawing.Point(4, 25)
        Me.tbUserAccount.Name = "tbUserAccount"
        Me.tbUserAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tbUserAccount.Size = New System.Drawing.Size(391, 358)
        Me.tbUserAccount.TabIndex = 0
        Me.tbUserAccount.Text = "Application"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblGenerateSessionReport)
        Me.GroupBox3.Controls.Add(Me.lblClearUserLog)
        Me.GroupBox3.Controls.Add(Me.lblSaveSessionLog)
        Me.GroupBox3.Controls.Add(Me.lblClearSessionLog)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 161)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Log"
        '
        'lblGenerateSessionReport
        '
        Me.lblGenerateSessionReport.AutoSize = True
        Me.lblGenerateSessionReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerateSessionReport.Location = New System.Drawing.Point(15, 125)
        Me.lblGenerateSessionReport.Name = "lblGenerateSessionReport"
        Me.lblGenerateSessionReport.Size = New System.Drawing.Size(134, 16)
        Me.lblGenerateSessionReport.TabIndex = 9
        Me.lblGenerateSessionReport.Text = "Generate Log Report"
        '
        'lblClearUserLog
        '
        Me.lblClearUserLog.AutoSize = True
        Me.lblClearUserLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearUserLog.Location = New System.Drawing.Point(15, 29)
        Me.lblClearUserLog.Name = "lblClearUserLog"
        Me.lblClearUserLog.Size = New System.Drawing.Size(98, 16)
        Me.lblClearUserLog.TabIndex = 6
        Me.lblClearUserLog.Text = "Clear User Log"
        '
        'lblSaveSessionLog
        '
        Me.lblSaveSessionLog.AutoSize = True
        Me.lblSaveSessionLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveSessionLog.Location = New System.Drawing.Point(15, 93)
        Me.lblSaveSessionLog.Name = "lblSaveSessionLog"
        Me.lblSaveSessionLog.Size = New System.Drawing.Size(118, 16)
        Me.lblSaveSessionLog.TabIndex = 8
        Me.lblSaveSessionLog.Text = "Save Session Log"
        '
        'lblClearSessionLog
        '
        Me.lblClearSessionLog.AutoSize = True
        Me.lblClearSessionLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearSessionLog.Location = New System.Drawing.Point(15, 61)
        Me.lblClearSessionLog.Name = "lblClearSessionLog"
        Me.lblClearSessionLog.Size = New System.Drawing.Size(118, 16)
        Me.lblClearSessionLog.TabIndex = 7
        Me.lblClearSessionLog.Text = "Clear Session Log"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLevel)
        Me.GroupBox2.Controls.Add(Me.chkDisableAnonynousAdmin)
        Me.GroupBox2.Controls.Add(Me.chkConWindow)
        Me.GroupBox2.Controls.Add(Me.chkWindowsExecution)
        Me.GroupBox2.Controls.Add(Me.chkMultithreading)
        Me.GroupBox2.Controls.Add(Me.chkAnonynousData)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 179)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Application"
        '
        'lblLevel
        '
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(351, 22)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.ReadOnly = True
        Me.lblLevel.Size = New System.Drawing.Size(21, 22)
        Me.lblLevel.TabIndex = 7
        Me.lblLevel.Visible = False
        '
        'chkDisableAnonynousAdmin
        '
        Me.chkDisableAnonynousAdmin.AutoSize = True
        Me.chkDisableAnonynousAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisableAnonynousAdmin.Location = New System.Drawing.Point(6, 148)
        Me.chkDisableAnonynousAdmin.Name = "chkDisableAnonynousAdmin"
        Me.chkDisableAnonynousAdmin.Size = New System.Drawing.Size(228, 20)
        Me.chkDisableAnonynousAdmin.TabIndex = 5
        Me.chkDisableAnonynousAdmin.Text = "Disable Anonynous Administrator "
        Me.chkDisableAnonynousAdmin.UseVisualStyleBackColor = True
        '
        'chkConWindow
        '
        Me.chkConWindow.AutoSize = True
        Me.chkConWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConWindow.Location = New System.Drawing.Point(6, 52)
        Me.chkConWindow.Name = "chkConWindow"
        Me.chkConWindow.Size = New System.Drawing.Size(236, 20)
        Me.chkConWindow.TabIndex = 2
        Me.chkConWindow.Text = "Allow Running Concurrent Windows"
        Me.chkConWindow.UseVisualStyleBackColor = True
        '
        'chkWindowsExecution
        '
        Me.chkWindowsExecution.AutoSize = True
        Me.chkWindowsExecution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWindowsExecution.Location = New System.Drawing.Point(6, 116)
        Me.chkWindowsExecution.Name = "chkWindowsExecution"
        Me.chkWindowsExecution.Size = New System.Drawing.Size(264, 20)
        Me.chkWindowsExecution.TabIndex = 4
        Me.chkWindowsExecution.Text = "Allow Windows Process Style Execution"
        Me.chkWindowsExecution.UseVisualStyleBackColor = True
        '
        'chkMultithreading
        '
        Me.chkMultithreading.AutoSize = True
        Me.chkMultithreading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultithreading.Location = New System.Drawing.Point(6, 20)
        Me.chkMultithreading.Name = "chkMultithreading"
        Me.chkMultithreading.Size = New System.Drawing.Size(156, 20)
        Me.chkMultithreading.TabIndex = 1
        Me.chkMultithreading.Text = "Enable Multithreading"
        Me.chkMultithreading.UseVisualStyleBackColor = True
        '
        'chkAnonynousData
        '
        Me.chkAnonynousData.AutoSize = True
        Me.chkAnonynousData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnonynousData.Location = New System.Drawing.Point(6, 84)
        Me.chkAnonynousData.Name = "chkAnonynousData"
        Me.chkAnonynousData.Size = New System.Drawing.Size(257, 20)
        Me.chkAnonynousData.TabIndex = 3
        Me.chkAnonynousData.Text = "Allow Sending Server Anonynous Data"
        Me.chkAnonynousData.UseVisualStyleBackColor = True
        '
        'tbApplication
        '
        Me.tbApplication.BackColor = System.Drawing.SystemColors.Control
        Me.tbApplication.Controls.Add(Me.GroupBox1)
        Me.tbApplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApplication.Location = New System.Drawing.Point(4, 25)
        Me.tbApplication.Name = "tbApplication"
        Me.tbApplication.Padding = New System.Windows.Forms.Padding(3)
        Me.tbApplication.Size = New System.Drawing.Size(391, 358)
        Me.tbApplication.TabIndex = 1
        Me.tbApplication.Text = "User Account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLogout)
        Me.GroupBox1.Controls.Add(Me.lblNewUser)
        Me.GroupBox1.Controls.Add(Me.lblViewCurrent)
        Me.GroupBox1.Controls.Add(Me.lblChangePassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 138)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Account"
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(10, 105)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(49, 16)
        Me.lblLogout.TabIndex = 0
        Me.lblLogout.Text = "Logout"
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUser.Location = New System.Drawing.Point(10, 79)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(110, 16)
        Me.lblNewUser.TabIndex = 0
        Me.lblNewUser.Text = "Create New User"
        '
        'lblViewCurrent
        '
        Me.lblViewCurrent.AutoSize = True
        Me.lblViewCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewCurrent.Location = New System.Drawing.Point(10, 29)
        Me.lblViewCurrent.Name = "lblViewCurrent"
        Me.lblViewCurrent.Size = New System.Drawing.Size(155, 16)
        Me.lblViewCurrent.TabIndex = 0
        Me.lblViewCurrent.Text = "View Current User Profile"
        '
        'lblChangePassword
        '
        Me.lblChangePassword.AutoSize = True
        Me.lblChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePassword.Location = New System.Drawing.Point(10, 53)
        Me.lblChangePassword.Name = "lblChangePassword"
        Me.lblChangePassword.Size = New System.Drawing.Size(118, 16)
        Me.lblChangePassword.TabIndex = 0
        Me.lblChangePassword.Text = "Change Password"
        '
        'bttnApply
        '
        Me.bttnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnApply.Enabled = False
        Me.bttnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnApply.Location = New System.Drawing.Point(321, 392)
        Me.bttnApply.Name = "bttnApply"
        Me.bttnApply.Size = New System.Drawing.Size(75, 28)
        Me.bttnApply.TabIndex = 12
        Me.bttnApply.Text = "&Apply"
        Me.bttnApply.UseVisualStyleBackColor = True
        '
        'bttnCancel
        '
        Me.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCancel.Location = New System.Drawing.Point(240, 392)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(75, 29)
        Me.bttnCancel.TabIndex = 11
        Me.bttnCancel.Text = "&Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = True
        '
        'bttnOK
        '
        Me.bttnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnOK.Location = New System.Drawing.Point(159, 393)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(75, 28)
        Me.bttnOK.TabIndex = 10
        Me.bttnOK.Text = "&OK"
        Me.bttnOK.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.bttnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bttnCancel
        Me.ClientSize = New System.Drawing.Size(399, 422)
        Me.Controls.Add(Me.bttnOK)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnApply)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.tbUserAccount.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbApplication.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbUserAccount As System.Windows.Forms.TabPage
    Friend WithEvents tbApplication As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLevel As System.Windows.Forms.TextBox
    Friend WithEvents chkDisableAnonynousAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkConWindow As System.Windows.Forms.CheckBox
    Friend WithEvents chkWindowsExecution As System.Windows.Forms.CheckBox
    Friend WithEvents chkMultithreading As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnonynousData As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogout As System.Windows.Forms.Label
    Friend WithEvents lblNewUser As System.Windows.Forms.Label
    Friend WithEvents lblViewCurrent As System.Windows.Forms.Label
    Friend WithEvents lblChangePassword As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGenerateSessionReport As System.Windows.Forms.Label
    Friend WithEvents lblClearUserLog As System.Windows.Forms.Label
    Friend WithEvents lblSaveSessionLog As System.Windows.Forms.Label
    Friend WithEvents lblClearSessionLog As System.Windows.Forms.Label
    Friend WithEvents bttnApply As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents bttnOK As System.Windows.Forms.Button
End Class
