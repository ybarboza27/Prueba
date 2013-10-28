Public Class DatosServidorSQL


    Private nombreServidorSQL As String = ""
    Private nombreBaseDatos As String = ""

    'Constructor de la clase DataFrutaEmbolsada
    Public Sub New(ByVal nombreServidorSQL As String, ByVal nombreBaseDatos As String)
        Me.nombreServidorSQL = nombreServidorSQL
        Me.nombreBaseDatos = nombreBaseDatos
    End Sub

    ' Get y Set de la variabale nombreServidorSQL. 
    Public Property GetSetnombreServidorSQL As String
        Get
            ' devuelve el contenido de la variable del nombreservidorSQL.
            Return Me.nombreServidorSQL
        End Get
        ' Esta parte es la que asigna el valor a la variable del nombreservidorSQL.
        Set(nuevoNomberServidor As String)
            Me.nombreServidorSQL = nuevoNomberServidor
        End Set
    End Property

    ' Get y Set de la variabale nombreBaseDatos. 
    Public Property GetSetnombreBaseDatos As String
        Get
            ' devuelve el contenido de la variable del nombreBaseDatos.
            Return Me.nombreBaseDatos
        End Get
        ' Esta parte es la que asigna el valor a la variable del nombreBaseDatos.
        Set(nuevoNombreBaseDatos As String)
            Me.nombreBaseDatos = nuevoNombreBaseDatos
        End Set
    End Property

End Class
