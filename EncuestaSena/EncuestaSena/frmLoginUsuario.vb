Public Class frmLoginUsuario
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmLoginAdmin.Show()
        Me.Close()
    End Sub
    Private Sub frmLoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseDatos.conectar("root", "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngrsarUsu.Click
        SQL = "SELECT * from reg_usuario WHERE id_registro=" & txtIdUsu.Text
        rst = BaseDatos.leer_Registro(SQL)
        If txtIdUsu.Text = "" Then
            MessageBox.Show("El campo esta Vacío ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf rst.Read() Then
            If rst(0) = txtIdUsu.Text And rst(5) = "A" Then
                frmEncuestaporrealizar.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Usted no esta registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information
                            )
        End If
    End Sub

    Private Sub txtIdUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdUsu.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            SQL = "SELECT * from reg_usuario WHERE id_registro=" & txtIdUsu.Text
            rst = BaseDatos.leer_Registro(SQL)
            If txtIdUsu.Text = "" Then
                MessageBox.Show("El campo esta Vacío ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf rst.Read() Then
                If rst(0) = txtIdUsu.Text And rst(5) = "A" Then
                    frmEncuestaporrealizar.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Usted no esta registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information
                                )
            End If


        End If

    End Sub

    
    Private Sub txtIdUsu_TextChanged(sender As Object, e As EventArgs) Handles txtIdUsu.TextChanged

    End Sub
End Class
