Imports System.Data.SqlClient

Public Class ConvierteDataReaderADataSet


    '******Convertir un DataReader a un DataSet*************************************************************************************************
    Public Function convertirDataReaderADataSet(ByVal SqlDataReader As SqlDataReader) As DataSet
        Dim dataSet As DataSet = New DataSet
        Dim i As Integer = 0
        Do
            Dim schemaTable As DataTable = SqlDataReader.GetSchemaTable
            Dim dataTable As DataTable = New DataTable
            If Not (schemaTable Is Nothing) Then
                i = 0
                While i < schemaTable.Rows.Count
                    Dim dataRow As DataRow = schemaTable.Rows(i)
                    Dim columnName As String = CType(dataRow("ColumnName"), String)
                    Dim column As DataColumn = New DataColumn(columnName, CType(dataRow("DataType"), Type))
                    dataTable.Columns.Add(column)
                    System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
                End While
                dataSet.Tables.Add(dataTable)
                While SqlDataReader.Read
                    Dim dataRow As DataRow = dataTable.NewRow
                    i = 0
                    While i < SqlDataReader.FieldCount
                        dataRow(i) = SqlDataReader.GetValue(i)
                        System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
                    End While
                    dataTable.Rows.Add(dataRow)
                End While
            Else
                Dim column As DataColumn = New DataColumn("RowsAffected")
                dataTable.Columns.Add(column)
                dataSet.Tables.Add(dataTable)
                Dim dataRow As DataRow = dataTable.NewRow
                dataRow(0) = SqlDataReader.RecordsAffected
                dataTable.Rows.Add(dataRow)
            End If
        Loop While SqlDataReader.NextResult
        Return dataSet
    End Function



End Class
