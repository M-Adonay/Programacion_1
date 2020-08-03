Public Class Form1
    Private Sub CalculadoraBasica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As SByte
        ntabla = txtntabla.Text

        lstTablas.Items.Clear()

        If ntabla <= 12 Then
            For i = 1 To 10
                lstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())

            Next
        Else
            lstTablas.Items.Add("Solo tablas menores o iguales a 12.")
        End If
    End Sub
End Class
