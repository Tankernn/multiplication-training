Public Class SettingsForm
    'Variables for settings
    Public boolRandomize, boolTryAgain As Boolean
    Public iIncorrect, iCorrect, iArrayLength, iTestLength As Integer
    'Array to hold the questions
    Public iQuestions(2, 0) As Integer

    Dim progress As New ProgressForm


    Private Sub cmdStart_Click(sender As System.Object, e As System.EventArgs) Handles cmdStart.Click

        readSettings()

        Try 'Catch exception if no table was selected
            createQuestions()
        Catch ex As Exception
            MsgBox("You must select at least one table!")
            Exit Sub
        End Try


        'Do the test the desired amount of times

        'Set maximum value for the prograssbar
        progress.ProgressBar2.Maximum = iTestLength
        Try
            For i = 1 To iTestLength
                If boolRandomize Then 'Shuffle the array?
                    performTest(shuffleArray(iQuestions)) 'Shuffle and test
                Else
                    performTest(iQuestions) 'Just test
                End If
                'Update value on ProgressBar2
                progress.ProgressBar2.Value = i
            Next

            progress.Close()
            Me.Show()
        Catch ex As Exception 'Return to the settings form
            Me.Show()
            progress.Close()
            Exit Sub
        End Try


        'Create and show the ResultsForm
        Dim pf As New ResultsForm
        pf.Show()

    End Sub

    Private Sub cbAlla_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbAll.CheckedChanged
        'Set all checkboxes to checked or not
        If cbAll.Checked Then
            cb1.Checked = True
            cb2.Checked = True
            cb3.Checked = True
            cb4.Checked = True
            cb5.Checked = True
            cb6.Checked = True
            cb7.Checked = True
            cb8.Checked = True
            cb9.Checked = True
            cb10.Checked = True
        Else
            cb1.Checked = False
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cb5.Checked = False
            cb6.Checked = False
            cb7.Checked = False
            cb8.Checked = False
            cb9.Checked = False
            cb10.Checked = False
        End If
    End Sub

    Private Sub performTest(uppgifter As Integer(,))
        'Reset counters
        iIncorrect = 0
        iCorrect = 0

        Dim iUserAnswer, iCorrectAnswer As Integer
        Dim boolAlreadyGuessedWrong As Boolean 'Keeps track of if the user has already guessed wrong, so that no points will be awarded after having guessed wrong once



        'Set progressbar max value
        progress.ProgressBar1.Maximum = iArrayLength
        'Set label start value
        progress.Label1.Text = "1 / " & iArrayLength
        'Show the progress window
        progress.Show()

        'Hide settings-box
        Me.Hide()

        'Go through the questions and get answers
        For i = 0 To iArrayLength - 1
            'Calculate correct answer
            iCorrectAnswer = uppgifter((0), (i)) * uppgifter((1), (i))

            'Try until a number is entered, and if the user selected, try again until the correct answer is given
            While True
                Try
                    'Ask for the answer
                    Dim strAnswer As String = InputBox(uppgifter((0), (i)) & " X " & uppgifter((1), (i)))

                    'Allow the user to abort
                    If strAnswer = "" Then
                        Throw New OperationCanceledException
                    End If

                    iUserAnswer = strAnswer
                Catch ex1 As OperationCanceledException
                    If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Throw ex1
                    Else
                        Continue While
                    End If

                Catch ex As Exception 'Catch errors
                    MsgBox("Only numbers please!")
                    Continue While 'Try again
                End Try


                'Check answer
                If iCorrectAnswer = iUserAnswer Then 'Correct
                    'If the user already guessed wrong, no points are awarded
                    If Not boolAlreadyGuessedWrong Then
                        iCorrect += 1
                    End If
                    boolAlreadyGuessedWrong = False 'Reset variable

                    'Next question
                    Exit While
                Else 'Incorrect

                    'Try again or continue
                    If boolTryAgain Then
                        MsgBox("Wrong, try again!")

                        'If the user already guessed wrong, give no more incorrect points
                        If Not boolAlreadyGuessedWrong Then
                            iIncorrect += 1
                        End If

                        boolAlreadyGuessedWrong = True 'The user has been wrong

                        'Retry
                        Continue While
                    Else
                        MsgBox("Wrong, the answer is: " & iCorrectAnswer)
                        iIncorrect += 1
                        'Continue
                        Exit While
                    End If

                End If
            End While

            'Update progress form
            progress.Label1.Text = i + 1 & " / " & iArrayLength 'Label
            progress.ProgressBar1.Value = i + 1 'ProgressBar
        Next

    End Sub

    Private Sub createQuestions()
        'Reset the arraylength
        iArrayLength = 0

        'Read all checkboxes and create questions

        If cb1.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 1
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb2.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 2
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb3.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 3
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb4.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 4
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb5.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 5
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb6.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 6
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb7.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 7
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb8.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 8
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb9.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 9
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        If cb10.Checked Then
            For i = 1 To 10
                'Redim array
                ReDim Preserve iQuestions(2, iArrayLength + 1)
                'Add all values at the end
                iQuestions((0), (iArrayLength)) = 10
                iQuestions((1), (iArrayLength)) = i
                iArrayLength += 1
            Next
        End If

        Try
            'Try to get the first value, if there is none, throw exception
            Dim temp As Integer = iQuestions(0, 1)
        Catch ex As Exception
            Throw ex
        End Try
        'Remove the last position
        ReDim Preserve iQuestions(2, iArrayLength - 1)
    End Sub

    Private Function shuffleArray(oldArray As Integer(,)) As Integer(,) 'Shuffle the array, and return the shuffle one
        Dim r As New Random 'Randomizer
        Dim newArray(2, iArrayLength) As Integer 'The new, shuffled array
        Dim iTagna(iArrayLength) As Integer 'Keeping track of which positions are already taken


        For i = 0 To iArrayLength - 1 'Go through the entire array
            While True 'Try again until Exit While
                Dim randomnummer As Integer = r.Next(0, iArrayLength)

                If iTagna(randomnummer) = 1 Then 'Check that the position is not taken
                    Continue While 'Try again
                Else

                    newArray((0), (i)) = oldArray((0), (randomnummer)) 'First factor
                    newArray((1), (i)) = oldArray((1), (randomnummer)) 'Second factor
                    iTagna(randomnummer) = 1 'Mark the position as taken
                    Exit While 'Stop trying
                End If

            End While
        Next

        Return newArray

    End Function

    Private Sub readSettings() 'Reads settings from the form
        boolRandomize = rbRandom.Checked
        boolTryAgain = rbTryAgain.Checked

        'Test length
        If rbLong.Checked Then
            iTestLength = 3 'All questions trice
        ElseIf rbMedium.Checked Then
            iTestLength = 2 'All questions twice
        Else
            iTestLength = 1 'All questions once
        End If
    End Sub
End Class
