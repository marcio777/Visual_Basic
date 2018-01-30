Public Class Form1
    Dim Alarme As Date

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = TimeOfDay
        If Alarme = Label1.Text Then
            Timer1.Enabled = False
            MessageBox.Show("Alarme da Hora")
        End If
    End Sub

    Private Sub cmdcap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcap.Click
        Alarme = MaskedTextBox1.Text
        Timer1.Enabled = True
    End Sub
End Class
