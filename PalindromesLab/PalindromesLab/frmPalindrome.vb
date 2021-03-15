'Author: Bruce Brown
'Date: 2/4/2021
'Purpose: This program is designed to get text from a user and determine if it is a palindrome, as well as display verification result.

Option Strict On
Option Explicit On

Public Class frmPalindrome

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Declare Variables
        Dim intWordLength As Integer
        Dim strTempWord As String

        'Verification Variable
        Dim blnIsPalindrome As Boolean

        'Output Variable
        Dim strOutput As String

        'Assign Variables
        blnIsPalindrome = True
        strTempWord = txtPalindrome.Text.ToLower
        strOutput = ""


        'Display a message if input text is blank
        If strTempWord = "" Then
            MessageBox.Show("You forgot to enter text!")
            txtPalindrome.Focus()
        Else
            intWordLength = strTempWord.Length
        End If


        'Verify if the word is a Palindrome
        For intCounter As Integer = 1 To CInt(intWordLength / 2)
            If Not GetChar(strTempWord, intCounter).Equals(GetChar(strTempWord, intWordLength - intCounter + 1)) Then
                blnIsPalindrome = False
                strOutput = "This is not a Palindrome. Please try again."
            End If
        Next

        If blnIsPalindrome = True Then
            strOutput = "This is a Palindrome. Good job!"
        End If

        'Display Output
        lblOutput.Text = strOutput
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the input text and focuses on the text box
        txtPalindrome.Clear()
        txtPalindrome.Focus()
    End Sub

    Private Sub txtPalindrome_TextChanged(sender As Object, e As EventArgs) Handles txtPalindrome.TextChanged
        'Refresh the output when the text input has been changed
        lblOutput.Text = String.Empty
    End Sub
End Class
