Public Class Form1
  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    Close()
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim a, b As Double
    If IsNumeric(TextBox1.Text) Then
      a = TextBox1.Text
    Else
      TextBox1.BackColor = Color.Salmon
    End If

    If IsNumeric(TextBox2.Text) Then
      b = TextBox2.Text
    Else
      TextBox2.BackColor = Color.Salmon
    End If

    MsgBox($"{a} + {b} = {a + b}", MsgBoxStyle.Information, "Výpočet")
  End Sub
End Class
