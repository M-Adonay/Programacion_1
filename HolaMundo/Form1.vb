Public Class Form1
    Private Sub CalculadoraBasica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblnum1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim num1, num2, respuesta As Double

        num1 = txtnum1.Text
        num2 = txtnum2.Text

        If optSuma.Checked Then
            lblrespuesta.Text = num1 + num2
        End If

        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2
        End If

        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100
        End If

        If optExponente.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If

        If optResiduo.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If

        Select Case cboOperaciones.SelectedIndex
            Case 1
                lblrespuesta.Text = num1 + num2

            Case 2
                lblrespuesta.Text = num1 - num2

            Case 3
                lblrespuesta.Text = num1 * num2

            Case 4
                lblrespuesta.Text = num1 / num2

            Case 5
                lblrespuesta.Text = num1 * num2 / 100

            Case 6
                lblrespuesta.Text = num1 ^ num2

            Case 7
                lblrespuesta.Text = num1 Mod num2
        End Select
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles optMultiplicar.CheckedChanged

    End Sub
End Class
