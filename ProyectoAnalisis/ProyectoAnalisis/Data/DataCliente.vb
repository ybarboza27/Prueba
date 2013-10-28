Imports System.Data.SqlClient

Public Class DataCliente




    'Enviar nombreServidorSQL y nombreBaseDatos
    Dim datosServidor As New DatosServidorSQL("YULI-PC\YULI", "rycFrutas")
    Dim convertidor As New ConvierteDataReaderADataSet

    Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")
    'Dim conexionSQL As New SqlConnection("Data Source=ARTURO;Initial Catalog=rycFrutas;Integrated Security=True")

    '******Ingresar una información del CLIENTE *****************************************************************************************
    Public Function ingresarCliente(cedula As String, nombre As String, primerApellido As String,
                                     segundoApellido As String, telefono As String) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim comando As New SqlCommand("ingresarCliente", conexionSQL)
        Dim salidaQuery As Integer = 0
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@cedula", cedula)
        comando.Parameters.AddWithValue("@nombre", nombre)
        comando.Parameters.AddWithValue("@primerApellido", primerApellido)
        comando.Parameters.AddWithValue("@segundoApellido", segundoApellido)
        comando.Parameters.AddWithValue("@telefono", telefono)
        Try
            conexionSQL.Open()

            salidaQuery = comando.ExecuteNonQuery()
            If (salidaQuery >= 1) Then
                salida = "La información se ha ingresado correctamente"
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

    '******Eliminar información del CLIENTE *************************************************************************************************

    Public Function eliminarCliente(cedula As String) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("eliminarCliente", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@cedula", cedula)

        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()

            If (salidaQuery >= 1) Then
                salida = "La información se ha ingresado correctamente"
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

    '******Mostrar información del CLIENTE*************************************************************************************************

    Public Function mostrarClientes() As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarClientes", conexionSQL)
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

    '******Mostrar id y nombre del CLIENTE*************************************************************************************************

    Public Function infoCliente() As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("infoCliente", conexionSQL)
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

    '******Mostrar información del CLIENTE *************************************************************************************************

    Public Function mostrarCliente(cedula As String) As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarCliente", conexionSQL)
        Dim dataSet As New DataSet


        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@cedula", cedula)

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






    '******Mostrar información del precio/hora*************************************************************************************************

    Public Function consultarIdClientes(cedula As String) As Integer
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("consultarIdClientes", conexionSQL)
        Dim dataSet As New DataSet
        Dim idCliente As Integer
        Dim row As DataRow

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@cedula", cedula)

        Try
            conexionSQL.Open()
            Dim SqlDataReader As SqlDataReader = comandoSQL.ExecuteReader()

            dataSet = convertidor.convertirDataReaderADataSet(SqlDataReader)

            For Each row In dataSet.Tables(0).Rows
                idCliente = CInt(row("id").ToString)
            Next
            'precioHora = dataSet.
        Catch ex As Exception
            dataSet = Nothing
            MsgBox("se cayó " & ex.Message)
        Finally
            conexionSQL.Dispose()
            comandoSQL.Dispose()
        End Try
        MsgBox("se cayó " & idCliente)
        Return idCliente
    End Function

    '****** Modifica la información del CLIENTE*************************************************************************************************

    Public Function modificarCliente(id As Integer, cedula As String, nombre As String, primerApellido As String,
                                     segundoApellido As String, telefono As String) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("modificarCliente", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@id", id)
        comandoSQL.Parameters.AddWithValue("@cedula", cedula)
        comandoSQL.Parameters.AddWithValue("@nombre", nombre)
        comandoSQL.Parameters.AddWithValue("@primerApellido", primerApellido)
        comandoSQL.Parameters.AddWithValue("@segundoApellido", segundoApellido)
        comandoSQL.Parameters.AddWithValue("@telefono", telefono)
        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()

            If (salidaQuery >= 1) Then
                salida = "La información se ha ingresado correctamente"
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
