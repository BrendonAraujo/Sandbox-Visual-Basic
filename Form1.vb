Public Class Form1
  Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
    'Declara as Variáveis
    Dim intConta As Integer = 0

    'Chamada da Sub rotina LimpaLista
    LimpaLista()

    'Executa Loop enquanto intConta < 5
    Do While intConta < 5
      'Adiciona o número na Lista
      lstDados.Items.Add(intConta.ToString)
      intConta += 1
    Loop
  End Sub

  Private Sub LimpaLista()
    'Limpa a Lista
    lstDados.Items.Clear()
  End Sub


End Class
