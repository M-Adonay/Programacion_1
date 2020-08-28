Public Class Form1
    Dim objEstadistica As New estadistica
    Private Sub btnMediaAritmetica_Click(sender As Object, e As EventArgs) Handles btnMediaAritmetica.Click
        lblRespuestaMedia.Text = objEstadistica.calcularMedia(txtserie.Text.Split(","))
        lblRespuestaVarianza.Text = objEstadistica.calcularVarianza(txtserie.Text.Split(","))
        lblRespuestaDesvTipica.Text = objEstadistica.calcularDesvTipica(txtserie.Text.Split(","))
    End Sub

    Private Sub grdEstadistica_KeyUp(sender As Object, e As KeyEventArgs) Handles grdEstadistica.KeyUp
        Dim nfilas = grdEstadistica.Rows.Count - 1,
            totalf1 = 0,
            totalx1xf1 = 0.0,
            totalx21xf1 = 0.0
        Dim fila As New DataGridViewRow
        For i = 0 To nfilas - 1
            fila = grdEstadistica.Rows(i)
            Dim x1 = 0, f1 = 0
            If fila.Cells("x1").Value <> "" Then
                x1 = Integer.Parse(fila.Cells("x1").Value.ToString())
            End If
            If fila.Cells("f1").Value <> "" Then
                f1 = Integer.Parse(fila.Cells("f1").Value.ToString())
            End If
            totalf1 += f1
            totalx1xf1 += x1 * f1
            totalx21xf1 += x1 ^ 2 * f1

            fila.Cells("n1").Value = totalf1.ToString()
            fila.Cells("x1xf1").Value = (x1 * f1).ToString()
            fila.Cells("x21xf1").Value = (x1 ^ 2 * f1).ToString()
        Next
        lbltotalf1.Text = totalf1.ToString()
        lbltotalx1xf1.Text = totalx1xf1.ToString()
        lbltotalx21xf1.Text = totalx21xf1.ToString()

        Dim media = Math.Round(totalx1xf1 / totalf1, 2),
            varianza = Math.Round(totalx21xf1 / totalf1 - media ^ 2, 2)
        lblRespuestaMedia.Text = media.ToString()
        lblRespuestaVarianza.Text = varianza.ToString()
        lblRespuestaDesvTipica.Text = Math.Round(Math.Sqrt(varianza), 2).ToString()

    End Sub

    Private Sub lbltotalx1xf1_Click(sender As Object, e As EventArgs) Handles lbltotalx1xf1.Click

    End Sub

    Private Sub lbltotalf1_Click(sender As Object, e As EventArgs) Handles lbltotalf1.Click

    End Sub

    Private Sub lbltotalx21xf1_Click(sender As Object, e As EventArgs) Handles lbltotalx21xf1.Click

    End Sub

    Private Sub lblRespuestaDesvTipica_Click(sender As Object, e As EventArgs) Handles lblRespuestaDesvTipica.Click

    End Sub

    Private Sub lbldesvtipica_Click(sender As Object, e As EventArgs) Handles lbldesvtipica.Click

    End Sub

    Private Sub lblVarianza_Click(sender As Object, e As EventArgs) Handles lblVarianza.Click

    End Sub

    Private Sub lblMedia_Click(sender As Object, e As EventArgs) Handles lblMedia.Click

    End Sub

    Private Sub lblRespuestaVarianza_Click(sender As Object, e As EventArgs) Handles lblRespuestaVarianza.Click

    End Sub

    Private Sub lblRespuestaMedia_Click(sender As Object, e As EventArgs) Handles lblRespuestaMedia.Click

    End Sub

    Private Sub lblserie_Click(sender As Object, e As EventArgs) Handles lblserie.Click

    End Sub

    Private Sub txtserie_TextChanged(sender As Object, e As EventArgs) Handles txtserie.TextChanged

    End Sub

    Private Sub grdEstadistica_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdEstadistica.CellContentClick

    End Sub
End Class
