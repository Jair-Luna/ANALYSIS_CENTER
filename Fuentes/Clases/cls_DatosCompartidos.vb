Public Class cls_DatosCompartidos

    Private Shared instancia As cls_DatosCompartidos

    Public arregloReceta() As String

    Private Sub New()
        arregloReceta = New String() {}
    End Sub

    Public Shared Function obtenerInstancia() As cls_DatosCompartidos
        If instancia Is Nothing Then
            instancia = New cls_DatosCompartidos()
        End If
        Return instancia
    End Function

    Public Sub agregarElemento(ByVal nuevoElemento As String)
        ReDim Preserve arregloReceta(arregloReceta.Length)
        arregloReceta(arregloReceta.Length - 1) = nuevoElemento
    End Sub

    Public Function indiceActual() As Integer
        Return arregloReceta.Length
    End Function

    Public Sub limpiarArreglo()
        ReDim arregloReceta(-1)
    End Sub

End Class
