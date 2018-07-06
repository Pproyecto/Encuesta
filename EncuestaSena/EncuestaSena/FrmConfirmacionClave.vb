
Public Class FrmConfirmacionClave
    Private Sub TxtConfirmarContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmacionClave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SQL = "SELECT * from adm WHERE id_adm='" & codusuario & "'"
            rst = BaseDatos.leer_Registro(SQL)
            If rst.Read() Then
                If txtContrasenaA.Text = rst(1) Then
                    txtNuevaClave.Enabled = True
                    txtConfirmacionClave.Enabled = True
                    MessageBox.Show("las contraseñas  coinciden", "usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnCambiarClaveAdm.Enabled = True
                    txtContrasenaA.Enabled = False
                    txtNuevaClave.Focus()
                Else
                    MsgBox("las contraseñas no coinciden")
                    txtNuevaClave.Enabled = False
                    txtConfirmacionClave.Enabled = False
                    btnCambiarClaveAdm.Enabled = False
                End If
            Else
            End If
            SQL = "UPDATE  adm set contraseña_adm='" & txtConfirmacionClave.Text & "'"
            If txtConfirmacionClave.Text = "" Or txtNuevaClave.Text = "" Then
                MessageBox.Show("Hay Campos en Blancos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContrasenaA.Focus()
            End If
            If BaseDatos.exec_Query(SQL, "Actualizar") Then
                MessageBox.Show("Actualizacion exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al Actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MsgBox("Las claves no coinciden")
        End If

        Me.Close()
    End Sub


    Private Sub btnCambiarClaveAdm_Click(sender As Object, e As EventArgs) Handles btnCambiarClaveAdm.Click
        SQL = "UPDATE  adm set contraseña_adm='" & txtConfirmacionClave.Text & "'"
        If BaseDatos.exec_Query(SQL, "Actualizar") Then
            MessageBox.Show("Actualizacion exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al Actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        MsgBox("Las claves no coinciden")



        Me.Close()
    End Sub



    Private Sub btnCambiarClaveAdm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnCambiarClaveAdm.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SQL = "UPDATE  adm set contraseña_adm='" & txtConfirmacionClave.Text & "'"
            If txtConfirmacionClave.Text = "" Or txtNuevaClave.Text = "" Then
                txtConfirmacionClave.Enabled = False
                txtNuevaClave.Enabled = False
                MessageBox.Show("Hay campos en Blancos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Error al Actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'MsgBox("Las claves no coinciden")


        Me.Close()
    End Sub

    Private Sub FrmConfirmacionClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtConfirmacionClave.Enabled = False
        txtNuevaClave.Enabled = False
        btnCambiarClaveAdm.Enabled = False
    End Sub

    Private Sub txtContrasenaA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasenaA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SQL = ("SELECT * from adm Where id_adm='" & codusuario & "'")
            rst = BaseDatos.leer_Registro(SQL)
            If rst.Read() Then
                If txtContrasenaA.Text = rst(1) Then
                    txtConfirmacionClave.Enabled = True
                    txtNuevaClave.Enabled = True
                Else
                    MsgBox("hola")
                End If
            Else
                MsgBox("no hay nada")
            End If
        End If
    End Sub

    Private Sub txtContrasenaA_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenaA.TextChanged

    End Sub

    Private Sub txtConfirmacionClave_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmacionClave.TextChanged

    End Sub
End Class