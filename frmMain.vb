Public Class HexDec
    Private Sub txtHex_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtHex.KeyPress

        Dim allowedChars As String = "abcdef1234567890"

        'Converting all lowercase letters to uppercase
        e.KeyChar = UCase(e.KeyChar)
        txtHex.Text = UCase(txtHex.Text)
        txtHex.Select(txtHex.Text.Length, 0)

        'Checking if the keypressed is allowed
        If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
            txtHex.Select(txtHex.Text.Length, 0)
        End If

        'Checking if punctuation or backspace
        If Char.IsPunctuation(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If

        'Checking is backspace
        If e.KeyChar = Convert.ToChar(Keys.Back) Then

            If txtHex.Text.Length = 1 Or txtHex.Text.Length = 0 Then
                txtHex.Text = ""
                txtDec.Text = ""
            ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then
                txtHex.Select(txtHex.Text.Length, 0)
                txtDec.Text = CLng("&H" & txtHex.Text.Substring(0, txtHex.Text.Length - 1))
            End If

        End If

        'Translating hex to decimal
        If e.KeyChar <> Convert.ToChar(Keys.Back) And Not Char.IsPunctuation(e.KeyChar) And allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
            txtDec.Text = CLng("&H" & txtHex.Text + e.KeyChar)
        ElseIf e.KeyChar <> Convert.ToChar(Keys.Back) And Not Char.IsPunctuation(e.KeyChar) And allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
            txtHex.Text = ""
        End If

    End Sub

    Private Sub txtDec_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles txtDec.KeyPress

        'Checking if is a number
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If

        'Checking if keypress is backspace
        If e.KeyChar = Convert.ToChar(Keys.Back) Then

            If txtDec.Text.Length = 1 Or txtDec.Text.Length = 0 Then
                txtHex.Text = ""
                txtDec.Text = ""
            ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then
                txtDec.Select(txtDec.Text.Length, 0)
                txtHex.Text = Hex(txtDec.Text.Substring(0, txtDec.Text.Length - 1))
            End If

        End If

        'Translating decimal to hex
        If e.KeyChar <> Convert.ToChar(Keys.Back) And IsNumeric(e.KeyChar) Then
            txtHex.Text = Hex(txtDec.Text + e.KeyChar)
        ElseIf e.KeyChar <> Convert.ToChar(Keys.Back) And IsNumeric(e.KeyChar) Then
            txtDec.Text = ""
        End If

    End Sub

End Class
