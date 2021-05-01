Public Class C_Productos

    Private codigo, nombre, valor, precio, cantidad As String

    'Public Sub New(cod As String, nom As String, val As String, pre As String, cant As String)
    'codigo = cod
    'nombre = nom
    'valor = val
    'precio = pre
    'cantidad = cant
    'End Sub

    Public Property P_codigo As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property P_Nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property P_Valor As String
        Get
            Return valor
        End Get
        Set(value As String)
            valor = value
        End Set
    End Property

    Public Property P_Precio As String
        Get
            Return precio
        End Get
        Set(value As String)
            precio = value
        End Set
    End Property

    Public Property P_Cantidad As String
        Get
            Return cantidad
        End Get
        Set(value As String)
            cantidad = value
        End Set
    End Property

    'para sacar IVA y VENTA 
    Function calcularIVA() As Double
        Return (P_Valor * 0.13)
    End Function

    Function calcularVENTA() As Double
        Return (P_Valor * P_Cantidad)
    End Function

End Class

