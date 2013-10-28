Imports System.Data.SqlClient

Public Class DataFrutaEmbolsada
    'Enviar nombreServidorSQL y nombreBaseDatos
    Dim datosServidor As New DatosServidorSQL("YULI-PC\YULI", "rycFrutas")
    Dim convertidor As New ConvierteDataReaderADataSet

    Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")
    'Dim conexionSQL As New SqlConnection("Data Source=ARTURO;Initial Catalog=rycFrutas;Integrated Security=True")

    '******Ingresar una información de la fruta embolsada*****************************************************************************************
    Public Function ingresarInfoFrutaEmbolsada(fechaEmbolse As Date, fechaProducción As Date, cantidaEmbolsada As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim comando As New SqlCommand("ingresarInfoFrutaEmbolsada", conexionSQL)
        Dim salidaQuery As Integer = 0
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@fechaEmbolse", fechaEmbolse)
        comando.Parameters.AddWithValue("@fechaProducción", fechaProducción)
        comando.Parameters.AddWithValue("@cantidad", cantidaEmbolsada)

        Try
            conexionSQL.Open()
            salidaQuery = comando.ExecuteNonQuery()
            If (salidaQuery >= 1) Then
                salida = "La información se ha almacenado correctamente"
            Else
                salida = "Error en el sistema!"
            End If
        Catch ex As Exception
            salida = "Error en el sistema! " & vbCrLf & ex.Message
        Finally
            conexionSQL.Dispose()
            comando.Dispose()
        End Try
        Return salida
    End Function

    '******Eliminar información de la fruta embolsada*************************************************************************************************

    Public Function eliminarInfoFrutaEmbolsada(idFrutaEmbolsada As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("eliminarInfoFrutaEmbolsada", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@idFrutaEmbolsada", idFrutaEmbolsada)

        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()

            If (salidaQuery >= 1) Then
                salida = "La información se ha eliminado correctamente"
            Else
                salida = "Error en el sistema!"
            End If
        Catch ex As Exception
            salida = "Error en el sistema!" & ex.Message
        Finally
            conexionSQL.Dispose()
            comandoSQL.Dispose()
        End Try
        Return salida
    End Function

    '******Mostrar información de la fruta embolsada todas*************************************************************************************************

    Public Function mostrarInfoFrutaEmbolsadaTodas() As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarInfoFrutaEmbolsadaTodas", conexionSQL)
        Dim dataSet As New DataSet

        Try
            conexionSQL.Open()
            Dim SqlDataReader As SqlDataReader = comandoSQL.ExecuteReader()
            dataSet = convertidor.convertirDataReaderADataSet(SqlDataReader)
        Catch ex As Exception
            dataSet = Nothing
        Finally
            conexionSQL.Dispose()
            comandoSQL.Dispose()
        End Try
        Return dataSet
    End Function

    '******Mostrar información de una fruta embolsada en especifico*************************************************************************************************

    Public Function mostrarInfoFrutaEmbolsada(idFrutaEmbolsada As Integer) As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarInfoFrutaEmbolsada", conexionSQL)
        Dim dataSet As New DataSet


        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@idFrutaEmbolsada", idFrutaEmbolsada)

        Try
            conexionSQL.Open()
            Dim SqlDataReader As SqlDataReader = comandoSQL.ExecuteReader()
            dataSet = convertidor.convertirDataReaderADataSet(SqlDataReader)
        Catch ex As Exception
            dataSet = Nothing
        Finally
            conexionSQL.Dispose()
            comandoSQL.Dispose()
        End Try
        Return dataSet
    End Function

    '****** Modifica la información de la tabla fruta embolsada*************************************************************************************************

    Public Function modificarInfoFrutaEmbolsada(idFrutaEmbolsada As Integer, fechaEmbolse As Date, fechaProducción As Date, cantidaEmbolsada As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("modificarInfoFrutaEmbolsada", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@idFrutaEmbolsada", idFrutaEmbolsada)
        comandoSQL.Parameters.AddWithValue("@fechaEmbolse", fechaEmbolse)
        comandoSQL.Parameters.AddWithValue("@fechaProducción", fechaProducción)
        comandoSQL.Parameters.AddWithValue("@cantidad", cantidaEmbolsada)

        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()

            If (salidaQuery >= 1) Then
                salida = "La información se ha modificado correctamente !"
            Else
                salida = "Error en el sistema!"
            End If
        Catch ex As Exception
            salida = "Error en el sistema!"
        Finally
            conexionSQL.Dispose()
            comandoSQL.Dispose()
        End Try
        Return salida
    End Function

End Class
