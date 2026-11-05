Public Class Form1
  Private Sub btnMatDecimal_Click(sender As Object, e As EventArgs) Handles btnMatDecimal.Click
    'Declara Variável
    Dim dblNumero As Double

    'Atribui valor, multiplica e mostra
    dblNumero = 45.34
    dblNumero *= 4.333
    MessageBox.Show("Teste de Multiplicação. " & dblNumero.ToString, "Pontos Flutuantes")

    'Atribui valor, divide e mostra
    dblNumero = 12
    dblNumero /= 7
    MessageBox.Show("Teste de Divisão. " & dblNumero.ToString, "Pontos Flutuantes")

  End Sub
End Class
