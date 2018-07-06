Imports System.Data.Odbc
Public Class BaseDatos
    Private Shared adaptador As OdbcDataAdapter
    Public Shared conexion As Odbc.OdbcConnection
    Public Shared Function conectar(ByVal user As String, ByVal pass As String) As Boolean
        Try
            conexion = New OdbcConnection("dsn=encuestar1.1;uid=" & user & ";pwd=" & pass & ";")
            conexion.Open()
            Return True
        Catch ex As OdbcException
            MsgBox(ex.ErrorCode)
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Shared orden As OdbcCommand
    Public Shared Function leer_Registro(ByVal sql As String) As OdbcDataReader
        Try
            orden = New OdbcCommand(sql, conexion)
            Return orden.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Error al Leer Registros en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Public Shared Function exec_Query(SQL As String, ByVal Result As String) As Boolean
        Try
            orden = New OdbcCommand(SQL, conexion)
            orden.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Error al " & Result & " Registro en la base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Shared Function Listar_Datos(ByVal sql As String) As DataTable
        Try
            Dim tab As New DataTable ' representa una tabla de datos en memoria 
            adaptador = New OdbcDataAdapter(sql, conexion)
            adaptador.Fill(tab) 'Funcion que llena el Datatable
            Return tab
        Catch ex As Exception
            MsgBox("!!!no se encontraron Datos a listar ¡¡¡", MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function



End Class