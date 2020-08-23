Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstEjercicios.Items.Clear()

        lstEjercicios.Items.Add("numeros pares del 1 al 20")
        For i = 2 To 20 Step 2
            lstEjercicios.Items.Add(i)

        Next

        lstEjercicios.Items.Add("numeros impares del 1 al 20")
        For i = 1 To 20 Step 2
            lstEjercicios.Items.Add(i)

        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnum.TextChanged

    End Sub

    Private Sub btnParimpar_Click(sender As Object, e As EventArgs) Handles btnParimpar.Click
        Dim num = txtnum.Text
        If num Mod 2 = 0 Then
            MessageBox.Show("El numero: " + num + " ,es par")
        Else
            MessageBox.Show("El numero: " + num + " ,es impar")
        End If
    End Sub

    Private Sub btnPrimo_Click(sender As Object, e As EventArgs) Handles btnPrimo.Click
        Dim num = txtnum.Text
        Dim i = 0, acu = 1
        While i < 3 And acu <= num
            If num Mod acu = 0 Then
                i += 1
            End If
            acu += 1
        End While
    End Sub
End Class
