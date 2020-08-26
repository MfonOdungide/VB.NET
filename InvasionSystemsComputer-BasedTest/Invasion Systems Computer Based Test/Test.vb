Imports System.Media
Public Class frmTest
    Dim path = System.Windows.Forms.Application.StartupPath
    Dim Warning, Critical As String
    Dim MyPlayer As New SoundPlayer()
    Private NumberOfQuestion = Val(frmConfirmation.txtNo_Of_Questions.Text)
    Private Sub Uncheck()
        OptionA.Checked = False
        OptionB.Checked = False
        OptionC.Checked = False
        OptionD.Checked = False
    End Sub

    Private Sub bttnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNext.Click

        If bttnNext.Text = "START" Then
            Timer.Enabled = True
            bttnNext.Text = "Next"
            txtInstruction.Visible = False
            Cover.Visible = False
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Exam Starts"
            Uncheck()
            QuestionCount()
            Randomize()

        ElseIf bttnNext.Text = "Next" Then
            If txtQuestionNumber.Text <> 0 Then 'This field can bring bug if system isnt running perfectly, but it reduces error in number of questions.
                'Source of the options are gotten from the QuestionCount
                Mark()
                Logging()
                Uncheck()
                QuestionCount()
                Randomize()
            Else
                'Do nothing
            End If

        ElseIf bttnNext.Text = "Submit" Then
            Mark()
            Logging()
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Exam Ended"
            frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf & "Score: " & txtScore.Text & "/" & txtNo_Of_Questions.Text & vbCrLf & "Remaining Time: " & lblTimer.Text & " Minutes" & vbCrLf & "============" & vbCrLf

            Me.Enabled = False
            Timer.Enabled = False
            frmResult.Show()
            Uncheck()
            Result()

        End If

    End Sub
    Private Sub Result()
        Dim result As New Form
        result.Name = "frmResult"
        '  frmResult.txtScore.Text = Me.txtScore.Text
        frmResult.Show()
        Me.Enabled = False
    End Sub
    Private Sub Randomize()
        Dim max As Integer
        Dim randomize As New Random
        ' max = NumberOfQuestion + 1
        max = Val(txtNo_Of_Questions.Text) + 1
        txtQ.Text = randomize.Next(1, max)
    End Sub
    Private Sub txtQ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQ.TextChanged
        'random number that generates the change of question
        BindingNavigatorPositionItem.Text = Val(txtQ.Text)
        BindingNavigatorPositionItem.Focus()
        txtQ.Focus()

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Timer.Interval = 1000
        If hours_label.Text = "" Then
            hours_label.Text = "0"
        End If
        If minutes_label.Text = "" Then
            minutes_label.Text = "0"
        End If
        If seconds_label.Text = "" Then
            seconds_label.Text = "0"
        End If
        If hours_label.Text = "00" Then
            hours_label.Text = "0"
        End If
        If minutes_label.Text = "00" Then
            minutes_label.Text = "0"
        End If
        If seconds_label.Text = "00" Then
            seconds_label.Text = "0"
        End If
        If seconds_label.Text > "0" Then
            seconds_label.Text = seconds_label.Text - 1
        End If
        If minutes_label.Text > "0" Then
            If seconds_label.Text = "0" Then
                minutes_label.Text = minutes_label.Text - 1
                seconds_label.Text = "59"
            End If
        End If
        If hours_label.Text > "0" Then
            If minutes_label.Text = "0" Then
                If seconds_label.Text = "0" Then
                    hours_label.Text = hours_label.Text - 1
                    minutes_label.Text = "59"
                    seconds_label.Text = "59"
                End If
            End If
        End If

        If seconds_label.Text = "0" Then
            If minutes_label.Text = "0" Then
                If hours_label.Text = "0" Then
                    Timer.Enabled = False
                    Me.Enabled = False
                    frmResult.Show()
                End If
            End If
        End If

        lblTimer.Text = hours_label.Text & " : " & minutes_label.Text & " : " & seconds_label.Text

        If Val(hours_label.Text) = 0 And Val(minutes_label.Text) = 5 And Val(seconds_label.Text) = 1 Then
            My.Computer.Audio.Play(My.Resources.Warning, AudioPlayMode.Background)
            lblTimer.ForeColor = Color.Yellow
            lblTimerInformation.Visible = True
            lblTimerInformation.ForeColor = Color.Yellow
            lblTimerInformation.Text = "You have less than 5 Minutes Remaining"
            blink.Enabled = True

        End If
        If Val(hours_label.Text) <= 0 And Val(minutes_label.Text) = 1 And Val(seconds_label.Text) = 1 Then
            My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
            lblTimer.ForeColor = Color.Red
            lblTimerInformation.Visible = True
            lblTimerInformation.ForeColor = Color.Red
            lblTimerInformation.Text = "You have less than 60 Seconds Remaining"
            blink.Enabled = True
        End If


    End Sub

    Private Sub QuestionCount()
        txtQuestionNumber.Text = Val(txtQuestionNumber.Text) + 1
        Progress()
        If lblNo_Of_Questions.Text = txtQuestionNumber.Text Then
            bttnNext.Text = "Submit"
        Else

        End If
    End Sub
    Private Sub Progress()
        Dim percentage As Integer
        percentage = ((Val(txtQuestionNumber.Text) / txtNo_Of_Questions.Text) * 100)
        If ProgressBar.Value < 100 Then
            ProgressBar.Value = percentage
            ' ProgressBar.Value += 5
        Else
            'do nothing
        End If
    End Sub
    Private Sub Mark()
        Dim score As Integer
        'Dim Grade As Integer
        'Dim numberOfQuestions As Integer
        'numberOfQuestions = Val(txtNo_Of_Questions.Text)

        If txtChosenOption.Text = CorrectOption.Text Then
            score = Val(txtScore.Text) + 1
        ElseIf txtChosenOption.Text <> CorrectOption.Text Then
            score = Val(txtScore.Text) + 0
        End If
        txtScore.Text = score
        ' Grade = ((score / numberOfQuestions) * 100)
        'txtScore.Text = Grade
    End Sub

    Private Sub OptionA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionA.CheckedChanged
        If OptionA.Checked = True Then
            txtChosenOption.Text = "A"
        Else
            txtChosenOption.Text = ""
        End If

    End Sub

    Private Sub OptionB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionB.CheckedChanged
        If OptionB.Checked = True Then
            txtChosenOption.Text = "B"
        Else
            txtChosenOption.Text = ""
        End If

    End Sub

    Private Sub OptionC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionC.CheckedChanged
        If OptionC.Checked = True Then
            txtChosenOption.Text = "C"
        Else
            txtChosenOption.Text = ""
        End If

    End Sub

    Private Sub OptionD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionD.CheckedChanged
        If OptionD.Checked = True Then
            txtChosenOption.Text = "D"
        Else
            txtChosenOption.Text = ""
        End If

    End Sub

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterControl()
        ComputeTime()
        Try
            Me.SettingsTableAdapter.Fill(Me.DataDataSet.Settings)
            'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Settings' table. You can move, or remove it, as needed.
            Me.ExamsTableAdapter.Fill(Me.DataDataSet.Exams)
        Catch ex As Exception
            MessageBox.Show("Settings Database Query Error, Reconnect Database", "Quiz Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

        lblNo_Of_Questions.Text = txtNo_Of_Questions.Text
        lblTimer.Text = minutes_label.Text & ":" & seconds_label.Text

        'txtNo_Of_Questions.Text = Val(frmConfirmation.txtNo_Of_Questions.Text)

        'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Course5' table. You can move, or remove it, as needed.
        ' Me.Course5TableAdapter.Fill(Me._Q_ADatabaseDataSet.Course5)
        'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Course4' table. You can move, or remove it, as needed.
        'Me.Course4TableAdapter.Fill(Me._Q_ADatabaseDataSet.Course4)
        'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Course3' table. You can move, or remove it, as needed.
        'Me.Course3TableAdapter.Fill(Me._Q_ADatabaseDataSet.Course3)
        'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Course2' table. You can move, or remove it, as needed.
        'Me.Course2TableAdapter.Fill(Me._Q_ADatabaseDataSet.Course2)
        'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Course1' table. You can move, or remove it, as needed.
        ' Me.Course1TableAdapter.Fill(Me._Q_ADatabaseDataSet.Course1)


        ' txtCourse.Text = "Course1"
        'Dim Subject As String
        'Subject = txtCourse.Text


        Try
            'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.Mathematics' table. You can move, or remove it, as needed.
            '  Me.BindingSource.DataMember = (Subject)
            ' Me.Course1TableAdapter.Fill(Me._Q_ADatabaseDataSet.Course1)
            'TODO: This line of code loads data into the '_Q_ADatabaseDataSet.English' table. You can move, or remove it, as needed.
            'Me.EnglishTableAdapter.Fill(Me._Q_ADatabaseDataSet.English)
        Catch ex As Exception
            MessageBox.Show("Database Query Error, Reconnect Database", "Quiz Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            frmLogin.Show()
        End Try

    End Sub

    Private Sub bttnEndExams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnEndExams.Click
        Mark()
        Logging()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf + DateAndTime.Today & " " & Format(TimeOfDay, "HH:mm:ss") & " Exam Ended"
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf & "Score: " & txtScore.Text & "/" & txtNo_Of_Questions.Text & vbCrLf & "Remaining Time: " & lblTimer.Text & " Minutes" & vbCrLf & "============" & vbCrLf
        Me.Enabled = False
        Timer.Enabled = False
        frmResult.Show()

    End Sub

    Private Sub txtQuestionNumber_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuestionNumber.TextChanged
        lblQuestionNumber.Text = txtQuestionNumber.Text
    End Sub
    Private Sub Logging()
        frmLog.txtFile.Text = frmLog.txtFile.Text & vbCrLf & "(" & txtQuestionNumber.Text & ") Q" & txtQ.Text & " - ChosenOption [" & txtChosenOption.Text & "], " & "CorrectOption [" & CorrectOption.Text & "]"

    End Sub

    Private Sub blink_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blink.Tick
        If lblTimerInformation.Visible = True Then
            lblTimerInformation.Visible = False
        Else
            lblTimerInformation.Visible = True
        End If

        If Val(seconds_label.Text) = 45 Then    ' blinks the control using seconds field on timer for (60-45)=15secs
            blink.Enabled = False
        End If

    End Sub
    Private Sub CenterControl()
        grpHolder.Top = (Me.ClientSize.Height / 2) - (grpHolder.Height / 2)
        grpHolder.Left = (Me.ClientSize.Width / 2) - (grpHolder.Width / 2)

    End Sub

    Private Sub Center_Control_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        CenterControl()
    End Sub

    Private Sub ComputeTime()
        Dim numerator, denominator As Integer
        Dim remainder As Double
        Dim result, X As Double
        Dim calc As Decimal
        denominator = "60"
        numerator = Val(frmConfirmation.lblTimeAllowed.Text)
        calc = numerator / denominator
        If numerator > denominator Then
            remainder = Math.Truncate(calc)
            X = calc - remainder
            result = X * denominator
            hours_label.Text = remainder
            minutes_label.Text = Math.Round(result)
            seconds_label.Text = "00"
            'txtReminder.Text = X
            'txtResult.Text = calc
            If X = 0 Then
                minutes_label.Text = "00"
            End If
        Else
            hours_label.Text = "00"
            minutes_label.Text = numerator
            seconds_label.Text = "00"
            'do nothing
        End If
    End Sub
End Class