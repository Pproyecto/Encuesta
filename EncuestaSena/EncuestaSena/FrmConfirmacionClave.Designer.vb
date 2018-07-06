<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmacionClave
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCambiarClaveAdm = New System.Windows.Forms.Button()
        Me.txtNuevaClave = New System.Windows.Forms.TextBox()
        Me.txtConfirmacionClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasenaA = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCambiarClaveAdm
        '
        Me.btnCambiarClaveAdm.Location = New System.Drawing.Point(72, 187)
        Me.btnCambiarClaveAdm.Name = "btnCambiarClaveAdm"
        Me.btnCambiarClaveAdm.Size = New System.Drawing.Size(139, 23)
        Me.btnCambiarClaveAdm.TabIndex = 0
        Me.btnCambiarClaveAdm.Text = "Confirmar Cambio"
        Me.btnCambiarClaveAdm.UseVisualStyleBackColor = True
        '
        'txtNuevaClave
        '
        Me.txtNuevaClave.Location = New System.Drawing.Point(92, 78)
        Me.txtNuevaClave.Name = "txtNuevaClave"
        Me.txtNuevaClave.Size = New System.Drawing.Size(139, 20)
        Me.txtNuevaClave.TabIndex = 2
        '
        'txtConfirmacionClave
        '
        Me.txtConfirmacionClave.Location = New System.Drawing.Point(92, 127)
        Me.txtConfirmacionClave.Name = "txtConfirmacionClave"
        Me.txtConfirmacionClave.Size = New System.Drawing.Size(139, 20)
        Me.txtConfirmacionClave.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clave Actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nueva clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirmar clave"
        '
        'txtContrasenaA
        '
        Me.txtContrasenaA.Location = New System.Drawing.Point(92, 33)
        Me.txtContrasenaA.Name = "txtContrasenaA"
        Me.txtContrasenaA.Size = New System.Drawing.Size(139, 20)
        Me.txtContrasenaA.TabIndex = 7
        '
        'FrmConfirmacionClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 236)
        Me.Controls.Add(Me.txtContrasenaA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirmacionClave)
        Me.Controls.Add(Me.txtNuevaClave)
        Me.Controls.Add(Me.btnCambiarClaveAdm)
        Me.Name = "FrmConfirmacionClave"
        Me.Text = "FrmConfirmacionClave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCambiarClaveAdm As System.Windows.Forms.Button
    Friend WithEvents txtNuevaClave As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmacionClave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContrasenaA As System.Windows.Forms.TextBox
End Class
