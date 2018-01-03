<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbStraight = New System.Windows.Forms.RadioButton()
        Me.rbRandom = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTryAgain = New System.Windows.Forms.RadioButton()
        Me.rbCorrectAnswer = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbAll = New System.Windows.Forms.CheckBox()
        Me.cb10 = New System.Windows.Forms.CheckBox()
        Me.cb9 = New System.Windows.Forms.CheckBox()
        Me.cb8 = New System.Windows.Forms.CheckBox()
        Me.cb7 = New System.Windows.Forms.CheckBox()
        Me.cb6 = New System.Windows.Forms.CheckBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbShort = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbLong = New System.Windows.Forms.RadioButton()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbStraight)
        Me.GroupBox1.Controls.Add(Me.rbRandom)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Straight or randomized?"
        '
        'rbStraight
        '
        Me.rbStraight.AutoSize = True
        Me.rbStraight.Location = New System.Drawing.Point(7, 44)
        Me.rbStraight.Name = "rbStraight"
        Me.rbStraight.Size = New System.Drawing.Size(61, 17)
        Me.rbStraight.TabIndex = 1
        Me.rbStraight.Text = "Straight"
        Me.rbStraight.UseVisualStyleBackColor = True
        '
        'rbRandom
        '
        Me.rbRandom.AutoSize = True
        Me.rbRandom.Checked = True
        Me.rbRandom.Location = New System.Drawing.Point(7, 20)
        Me.rbRandom.Name = "rbRandom"
        Me.rbRandom.Size = New System.Drawing.Size(84, 17)
        Me.rbRandom.TabIndex = 0
        Me.rbRandom.TabStop = True
        Me.rbRandom.Text = "Randomized"
        Me.rbRandom.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTryAgain)
        Me.GroupBox2.Controls.Add(Me.rbCorrectAnswer)
        Me.GroupBox2.Location = New System.Drawing.Point(161, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 67)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "What happens on wrong answer?"
        '
        'rbTryAgain
        '
        Me.rbTryAgain.AutoSize = True
        Me.rbTryAgain.Location = New System.Drawing.Point(7, 44)
        Me.rbTryAgain.Name = "rbTryAgain"
        Me.rbTryAgain.Size = New System.Drawing.Size(69, 17)
        Me.rbTryAgain.TabIndex = 1
        Me.rbTryAgain.Text = "Try again"
        Me.rbTryAgain.UseVisualStyleBackColor = True
        '
        'rbCorrectAnswer
        '
        Me.rbCorrectAnswer.AutoSize = True
        Me.rbCorrectAnswer.Checked = True
        Me.rbCorrectAnswer.Location = New System.Drawing.Point(7, 20)
        Me.rbCorrectAnswer.Name = "rbCorrectAnswer"
        Me.rbCorrectAnswer.Size = New System.Drawing.Size(177, 17)
        Me.rbCorrectAnswer.TabIndex = 0
        Me.rbCorrectAnswer.TabStop = True
        Me.rbCorrectAnswer.Text = "The correct answer is presented"
        Me.rbCorrectAnswer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbAll)
        Me.GroupBox3.Controls.Add(Me.cb10)
        Me.GroupBox3.Controls.Add(Me.cb9)
        Me.GroupBox3.Controls.Add(Me.cb8)
        Me.GroupBox3.Controls.Add(Me.cb7)
        Me.GroupBox3.Controls.Add(Me.cb6)
        Me.GroupBox3.Controls.Add(Me.cb5)
        Me.GroupBox3.Controls.Add(Me.cb4)
        Me.GroupBox3.Controls.Add(Me.cb3)
        Me.GroupBox3.Controls.Add(Me.cb2)
        Me.GroupBox3.Controls.Add(Me.cb1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Which tables?"
        '
        'cbAll
        '
        Me.cbAll.AutoSize = True
        Me.cbAll.Location = New System.Drawing.Point(7, 140)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(37, 17)
        Me.cbAll.TabIndex = 10
        Me.cbAll.Text = "All"
        Me.cbAll.UseVisualStyleBackColor = True
        '
        'cb10
        '
        Me.cb10.AutoSize = True
        Me.cb10.Location = New System.Drawing.Point(95, 116)
        Me.cb10.Name = "cb10"
        Me.cb10.Size = New System.Drawing.Size(68, 17)
        Me.cb10.TabIndex = 9
        Me.cb10.Text = "Table 10"
        Me.cb10.UseVisualStyleBackColor = True
        '
        'cb9
        '
        Me.cb9.AutoSize = True
        Me.cb9.Location = New System.Drawing.Point(95, 92)
        Me.cb9.Name = "cb9"
        Me.cb9.Size = New System.Drawing.Size(62, 17)
        Me.cb9.TabIndex = 8
        Me.cb9.Text = "Table 9"
        Me.cb9.UseVisualStyleBackColor = True
        '
        'cb8
        '
        Me.cb8.AutoSize = True
        Me.cb8.Location = New System.Drawing.Point(95, 68)
        Me.cb8.Name = "cb8"
        Me.cb8.Size = New System.Drawing.Size(62, 17)
        Me.cb8.TabIndex = 7
        Me.cb8.Text = "Table 8"
        Me.cb8.UseVisualStyleBackColor = True
        '
        'cb7
        '
        Me.cb7.AutoSize = True
        Me.cb7.Location = New System.Drawing.Point(95, 44)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(62, 17)
        Me.cb7.TabIndex = 6
        Me.cb7.Text = "Table 7"
        Me.cb7.UseVisualStyleBackColor = True
        '
        'cb6
        '
        Me.cb6.AutoSize = True
        Me.cb6.Location = New System.Drawing.Point(95, 20)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(62, 17)
        Me.cb6.TabIndex = 5
        Me.cb6.Text = "Table 6"
        Me.cb6.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.Location = New System.Drawing.Point(7, 116)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(62, 17)
        Me.cb5.TabIndex = 4
        Me.cb5.Text = "Table 5"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Location = New System.Drawing.Point(7, 92)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(62, 17)
        Me.cb4.TabIndex = 3
        Me.cb4.Text = "Table 4"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(7, 68)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(62, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Table 3"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(7, 44)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(62, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Table 2"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(7, 20)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(62, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Table 1"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbShort)
        Me.GroupBox4.Controls.Add(Me.rbMedium)
        Me.GroupBox4.Controls.Add(Me.rbLong)
        Me.GroupBox4.Location = New System.Drawing.Point(199, 87)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(177, 170)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "How long test?"
        '
        'rbShort
        '
        Me.rbShort.AutoSize = True
        Me.rbShort.Location = New System.Drawing.Point(7, 68)
        Me.rbShort.Name = "rbShort"
        Me.rbShort.Size = New System.Drawing.Size(50, 17)
        Me.rbShort.TabIndex = 2
        Me.rbShort.TabStop = True
        Me.rbShort.Text = "Short"
        Me.rbShort.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(7, 44)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbLong
        '
        Me.rbLong.AutoSize = True
        Me.rbLong.Checked = True
        Me.rbLong.Location = New System.Drawing.Point(7, 20)
        Me.rbLong.Name = "rbLong"
        Me.rbLong.Size = New System.Drawing.Size(49, 17)
        Me.rbLong.TabIndex = 0
        Me.rbLong.TabStop = True
        Me.rbLong.Text = "Long"
        Me.rbLong.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(13, 264)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(363, 23)
        Me.cmdStart.TabIndex = 4
        Me.cmdStart.Text = "Start test!"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 294)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SettingsForm"
        Me.Text = "Multiplication training"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbStraight As System.Windows.Forms.RadioButton
    Friend WithEvents rbRandom As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTryAgain As System.Windows.Forms.RadioButton
    Friend WithEvents rbCorrectAnswer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAll As System.Windows.Forms.CheckBox
    Friend WithEvents cb10 As System.Windows.Forms.CheckBox
    Friend WithEvents cb9 As System.Windows.Forms.CheckBox
    Friend WithEvents cb8 As System.Windows.Forms.CheckBox
    Friend WithEvents cb7 As System.Windows.Forms.CheckBox
    Friend WithEvents cb6 As System.Windows.Forms.CheckBox
    Friend WithEvents cb5 As System.Windows.Forms.CheckBox
    Friend WithEvents cb4 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbShort As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rbLong As System.Windows.Forms.RadioButton
    Friend WithEvents cmdStart As System.Windows.Forms.Button

End Class
