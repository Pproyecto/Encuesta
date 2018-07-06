Public Class frmLoginAdmin

    Private Sub txtIdAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAdmin.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private acum As String = 1
    Private cont As Integer
    Private cont2 As Integer
    Private guardar As String
    Private Sub btnIngresarAdmin_Click(sender As Object, e As EventArgs) Handles btnIngresarAdmin.Click
        SQL = ("SELECT * FROM adm WHERE id_adm=" & txtIdAdmin.Text)
        rst = BaseDatos.leer_Registro(SQL)
        If rst.Read() Then
            If rst(0) = txtIdAdmin.Text And rst(1) = txtClaveAdmin.Text Then 'And rst(1) = "A" Then
                codusuario = txtIdAdmin.Text
                frmOpciAdministrador.Show()
                Me.Close()
            Else

                If acum <> txtIdAdmin.Text Then
                    cont = cont = 0
                End If
                If rst(5) <> txtClaveAdmin.Text And rst(0) = txtIdAdmin.Text Then
                    cont = cont + 1
                    MsgBox("Clave Incorrecta. Al tercer intento se bloqueará " & cont)
                    acum = txtIdAdmin.Text

                    If acum = txtIdAdmin.Text And cont >= 3 Then
                        MsgBox("BLoqueo")
                        acum = ""
                        cont = 0
                    End If


                End If
            End If

        Else
            cont = cont - 1
            MessageBox.Show("Usted no esta registrado. Por favor comunicarse con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            acum = ""

        End If



    End Sub

    Private Sub frmLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtClaveAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClaveAdmin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SQL = ("SELECT * FROM adm WHERE id_adm=" & txtIdAdmin.Text)
            rst = BaseDatos.leer_Registro(SQL)
            If rst.Read() Then
                If rst(0) = txtIdAdmin.Text And rst(1) = txtClaveAdmin.Text Then 'And rst(1) = "A" Then
                    frmOpciAdministrador.Show()
                    Me.Close()
                Else

                    If acum <> txtIdAdmin.Text Then
                        cont = cont = 0
                    End If
                    If rst(5) <> txtClaveAdmin.Text And rst(0) = txtIdAdmin.Text Then
                        cont = cont + 1
                        MsgBox("Clave Incorrecta. Al tercer intento se bloqueará " & cont)
                        acum = txtIdAdmin.Text

                        If acum = txtIdAdmin.Text And cont >= 3 Then
                            MsgBox("BLoqueo")
                            acum = ""
                            cont = 0
                        End If


                    End If

                End If

            Else
                cont = cont - 1
                MessageBox.Show("Usted no esta registrado. Por favor comunicarse con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                acum = ""

            End If
        End If

    End Sub

  
    Private Sub txtClaveAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtClaveAdmin.TextChanged

    End Sub
End Class