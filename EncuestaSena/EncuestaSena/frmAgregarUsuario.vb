Public Class frmAgregarUsuario
    Sub AyudaGlobo(ByVal globo As ToolTip, ByVal boton As Button, ByVal mensaje As String)
        globo.RemoveAll()
        globo.SetToolTip(boton, mensaje)
        globo.InitialDelay = 1000
        globo.IsBalloon = False

    End Sub
    Public Sub SetToolTip(
control As Control,
caption As String
)
    End Sub

   
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        SQL = "UPDATE set usuario values('" & txtNombreRegistrar.Text & "','" & txtApellidoRegistrar.Text & "','" & txtTelefonoRegistrar.Text & "','" & txtEmailRegistrar.Text & "','A" & cbRolRegistrar.SelectedIndex & "')"
        'If rst(0) = txtIdRegistrar.Text Then
        'MsgBox("Esta Identificacion ya esta registrada")
        If BaseDatos.exec_Query(SQL, "Insertar") Then

            MsgBox("Datos Grabados Satisfactoriamente")
        Else
            MsgBox("Error al Grabar Registro")
        End If


    End Sub

    Private Sub tsbBuscar_Click(sender As Object, e As EventArgs) Handles tsbBuscar.Click
        SQL = ("SELECT * from usuario WHERE Id_Usu=" & txtIdRegistrar.Text)
        rst = BaseDatos.leer_Registro(SQL)
        If rst.Read() Then
            txtIdRegistrar.Text = rst(1)
            txtNombreRegistrar.Text = rst(2)
            txtApellidoRegistrar.Text = rst(3)
            txtTelefonoRegistrar.Text = rst(4)
            txtEmailRegistrar.Text = rst(5)
            cbRolRegistrar.SelectedIndex = rst(7)
        Else
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub frmAgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class