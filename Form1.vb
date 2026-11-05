Public Class Form1
  Private Sub btnVerifica_Click(sender As Object, e As EventArgs) Handles btnVerifica.Click
    'Declara a Variável que armazenará o nome inserido no textbox
    Dim strNome As String
    strNome = txtNome.Text
    'O Nome é João?
    If strNome <> "João" Then
      MessageBox.Show("O nome NÃO é João.", "Comparação")
    End If

  End Sub

  Private Sub btnVerificaNumero_Click(sender As Object, e As EventArgs) Handles btnVerificaNumero.Click
    'Declara a Variável
    Dim intNumero As Integer
    Try
      'Pega o número do textbox
      intNumero = txtValor.Text
    Catch
      Exit Sub
    End Try
    'O número é menor que  27?
    If intNumero < 27 Then
      MessageBox.Show("intNumero' é menor que 27? SIM!", "Comparação")
    Else
      MessageBox.Show("intNumero' é menor que 27? NÃO!", "Comparação")
    End If

  End Sub
End Class
