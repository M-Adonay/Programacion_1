Public Class Form1
    Dim objdirecciones = New direcciones()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDepto.Items.AddRange(objdirecciones.depto)
    End Sub

    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepto.SelectedIndexChanged
        cboMun.Items.Clear()
        cboMun.Text = ""
        cboMun.Items.AddRange(objdirecciones.mun(cboDepto.SelectedIndex))
    End Sub
End Class

Class direcciones
    Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan", "San Salvador", "La Paz", "Santa Ana", "Cabañas"}
    Public mun()() As String = {
        New String() {"Seleccione un depto."},
        New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},
        New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},
        New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},
        New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},
        New String() {"Seleccione un municipio", "San Salvador", "San Marcos", "San Martin", "Santo Tomas"},
        New String() {"Seleccione un municipio", "El Rosario", "Jerusalen", "Olocuilta", "San Emigdio"},
        New String() {"Seleccione un municipio", "Santa Ana", "El Congo", "Metapan", "Chalchuapa"},
        New String() {"Seleccione un municipio", "Victoria", "Dolores", "Jutiapa", "Cinquera"}
    }

End Class