Public Class ResultsForm

    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub Results_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        'Print all data as text
        lblPoäng.Text = "Questions: " & SettingsForm.iArrayLength * SettingsForm.iTestLength & vbCrLf & "Correct answers: " & SettingsForm.iCorrect & vbCrLf & "Incorrect answers: " & SettingsForm.iIncorrect

        'Text to clarify the progressbar
        lblAndel.Text = "Percentage correct: " & SettingsForm.iCorrect & " / " & SettingsForm.iArrayLength * SettingsForm.iTestLength

        pbAndelrätt.Maximum = SettingsForm.iArrayLength * SettingsForm.iTestLength 'Set the maximum value to the number of questions
        pbAndelrätt.Value = SettingsForm.iCorrect 'Set the value to the number of correct answers
    End Sub
End Class