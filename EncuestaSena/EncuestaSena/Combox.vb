Public Class Combox
    Public Sub llena_combo(ByVal cmb As ComboBox, ByVal sql As String, ByVal cod As String, ByVal nombre As String)
        Try
            cmb.DataSource = BaseDatos.Listar_Datos(sql)
            With cmb
                .ValueMember = cod
                .DisplayMember = nombre
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("no se encontraron registros asociados a la seleccion anterior")
        End Try
    End Sub
End Class
