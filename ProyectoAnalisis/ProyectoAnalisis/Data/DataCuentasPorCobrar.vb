Imports System.Data.SqlClient

Public Class DataCuentasPorCobrar


    'Enviar nombreServidorSQL y nombreBaseDatos
    Dim datosServidor As New DatosServidorSQL("YULI-PC\YULI", "rycFrutas")
    Dim convertidor As New ConvierteDataReaderADataSet

    Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

    '******Ingresar una información del CUENTAS POR COBRAR *****************************************************************************************
    Public Function ingresarCuentaPorCobrar(idCliente As Integer, fechaDeEntrega As Date,
            monto As Integer, kilosPendientes As Integer, idFruto As Integer) As String

        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")


        Dim salida As String = ""
        Dim comando As New SqlCommand("ingresarCuentaPorCobrar", conexionSQL)
        Dim salidaQuery As Integer = 0
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idCliente ", idCliente)
        comando.Parameters.AddWithValue("@fechaDeEntrega", fechaDeEntrega)
        comando.Parameters.AddWithValue("@monto", monto)
        comando.Parameters.AddWithValue("@kilosPendientes", kilosPendientes)
        comando.Parameters.AddWithValue("@idFruto", idFruto)

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

    '******Eliminar información de la CUENTA POR COBRAR*************************************************************************************************

    Public Function eliminarCuentaPorCobrar(id As Integer, fechaDeEntrega As Date, idFruto As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim salida As String = ""
        Dim salidaQuery As Integer = 0
        Dim comandoSQL As New SqlCommand("eliminarCuentaPorCobrar", conexionSQL)

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@id", id)
        comandoSQL.Parameters.AddWithValue("@fechaDeEntrega", fechaDeEntrega)
        comandoSQL.Parameters.AddWithValue("@idFruto", idFruto)

        Try
            conexionSQL.Open()
            salidaQuery = comandoSQL.ExecuteNonQuery()

            If (salidaQuery >= 1) Then
                salida = "La información se ha eliminado correctamente!"
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

    '******Mostrar información especifica de alguna CUENTA POR COBRAR *************************************************************************************************
    Public Function mostrarCuentaPorCobrar(cedula As String, fechaDeEntrega As Date, nombreFruto As String) As DataSet
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarCuentaPorCobrar", conexionSQL)
        Dim dataSet As New DataSet

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@cedula", cedula)
        comandoSQL.Parameters.AddWithValue("@fechaDeEntrega", fechaDeEntrega)
        comandoSQL.Parameters.AddWithValue("@nombreFruto", nombreFruto)

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

    '******Mostrar toda la información de las CUENTAS POR PAGAR *************************************************************************************************
    Public Function mostrarCuentasPorCobrarClienteTodas(idCliente As Integer) As DataSet

        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")

        Dim comandoSQL As New SqlCommand("mostrarCuentasPorCobrarClienteTodas", conexionSQL)
        Dim dataSet As New DataSet

        comandoSQL.CommandType = CommandType.StoredProcedure
        comandoSQL.Parameters.AddWithValue("@idCliente", idCliente)

        Try
            conexionSQL.Open()
            Dim SqlDataReader As SqlDataReader = comandoSQL.ExecuteReader()
            dataSet = convertidor.convertirDataReaderADataSet(SqlDataReader)
        Catch ex As Exception
            dataSet = Nothing
            MsgBox(ex.Message)
        Finally
            conexionSQL.Dispose()
            comandoSQL.Dispose()

        End Try
        Return dataSet
    End Function

    '******Modifica la información de CUENTAS POR COBRAR *****************************************************************************************
    Public Function modificarCuentaPorCobrar(idCliente As Integer, fechaDeEntrega As Date,
            monto As Integer, kilosPendientes As Integer, idFruto As Integer, id As Integer) As String
        Dim conexionSQL As New SqlConnection("Data Source=" & datosServidor.GetSetnombreServidorSQL & ";Initial Catalog=" & datosServidor.GetSetnombreBaseDatos & ";Integrated Security=True")
        Dim salida As String = ""
        Dim comando As New SqlCommand("modificarCuentaPorCobrar", conexionSQL)
        Dim salidaQuery As Integer = 0
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idCliente", idCliente)
        comando.Parameters.AddWithValue("@fechaDeEntrega", fechaDeEntrega)
        comando.Parameters.AddWithValue("@monto", monto)
        comando.Parameters.AddWithValue("@kilosPendientes", kilosPendientes)
        comando.Parameters.AddWithValue("@idFruto", idFruto)
        comando.Parameters.AddWithValue("@id", id)

        Try
            conexionSQL.Open()
            salidaQuery = comando.ExecuteNonQuery()
            If (salidaQuery >= 1) Then
                salida = "La información se ha modificado correctamente"
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

End Class
