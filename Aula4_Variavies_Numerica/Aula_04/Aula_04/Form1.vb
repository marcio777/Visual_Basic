Public Class Form1
    Dim nome As String
    Dim Nascimento As Integer
    Dim AnoAtual As Integer
    Dim Total As Integer
    Dim idade As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nascimento.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nome = InputBox("Qual e o seu Nome?", "Nome")
        txt_hoje.Text = Date.Today.Year
    End Sub

    Private Sub cmdcalcular_Click(sender As Object, e As EventArgs) Handles cmdcalcular.Click
        Nascimento = txt_nascimento.Text
        AnoAtual = txt_hoje.Text
        Total = AnoAtual - Nascimento
        idade = Total ' Converter para string para exibir o resultado
        MessageBox.Show("Olá " + nome + ", Esse ano você completa " + idade + " anos", "Resultado", MessageBoxButtons.OK)
    End Sub
End Class
