Public Class frmOpciAdministrador

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        RegistroUsuario.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        frmLoginUsuario.Show()
        Me.Close()
    End Sub

   
    Private Sub btnCrearEncuesta_Click(sender As Object, e As EventArgs) Handles btnCrearEncuesta.Click
        FrmCrearEncuesta1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        FrmConfirmacionClave.Show()
    End Sub
End Class