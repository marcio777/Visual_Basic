
Public Class Form1

    Dim Nome As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdola_Click(sender As Object, e As EventArgs) Handles cmdola.Click
        Nome = txtnome.Text
        MessageBox.Show("Olá " + Nome + " !", "Aula 3 ", MessageBoxButtons.OK)
    End Sub

    Private Sub cmdlimpar_Click(sender As Object, e As EventArgs) Handles cmdlimpar.Click
        txtnome.Text = ""
    End Sub
End Class
