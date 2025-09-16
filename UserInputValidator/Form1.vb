Public Class Form1
    Private Sub btnValidator_Click(sender As Object, e As EventArgs) Handles btnValidator.Click
        Try
            If IsNumeric(txtAge.Text) And txtAge.Text > 0 Then
                lblResult.Text = "You are " + txtAge.Text + " years old"

            End If

            If txtAge.Text <= 0 Then
                Throw New FormatException

            End If
        Catch ex As FormatException
            lblResult.Text = "Age cannot be niggative."
        End Try

    End Sub
End Class
