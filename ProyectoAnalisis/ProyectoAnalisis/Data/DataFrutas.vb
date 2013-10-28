Imports System.Data.SqlClient

Public Class DataFrutas


    'Enviar nombreServidorSQL y nombreBaseDatos
    Dim datosServidor As New DatosServidorSQL("YULI-PC\YULI", "rycFrutas")
    Dim convertidor As New ConvierteDataReaderADataSet

    Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")
    'Dim conexionSQL As New SqlConnection("Data Source=ARTURO;Initial Catalog=rycFrutas;Integrated Security=True")

    '******Ingresar una información de las frutas *****************************************************************************************
    Public Function ingresarFruta(nombreFruto As String, precio As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim comando As New SqlCommand("ingresarFruta", conexionSQL)
        Dim salidaQuery As Integer = 0
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@nombreFruto", nombreFruto)
        comando.Parameters.AddWithValue("@precio", precio)
        Try
            conexionSQL.Open()

            salidaQuery = comando.ExecuteNonQuery()
            If (salidaQuery >= 1) Then
                salida = "La información se ha ingresado correctamente"
            Else
                salida = "Error en el sistema!"
            End If
        Catch ex As Exception
            salida = "Error en el sistema" & vbCrLf & ex.Message
        Finally
            conexionSQL.Dispose()
            comando.Dispose()
        End Try
        Return salida
    End Function

    '******Eliminar información de las frutas*************************************************************************************************

    Public Function eliminarFruta(id As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("eliminarFruta", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@id", id)

        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()

            If (salidaQuery >= 1) Then
                salida = "Se ha eliminado la información con éxito!"
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

    '******Mostrar información de las frutas*************************************************************************************************

    Public Function mostrarFrutas() As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarFrutas", conexionSQL)
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

    '******Mostrar información de las frutas *************************************************************************************************

    Public Function mostrarFruta(id As Integer) As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarFruta", conexionSQL)
        Dim dataSet As New DataSet


        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@id", id)

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

    '****** Modifica la información del las frutas*************************************************************************************************

    Public Function modificarFruta(id As Integer, nombreFruto As String, precio As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("modificarFruta", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@id", id)
        comandoSQL.Parameters.AddWithValue("@nombreFruto", nombreFruto)
        comandoSQL.Parameters.AddWithValue("@precio", precio)
        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()
            If (salidaQuery >= 1) Then
                salida = "La información se ha modificado correctamente!"
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
End Class
