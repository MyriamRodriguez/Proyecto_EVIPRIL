Public Class FrmTipoContrato
    Private Sub FrmTipoContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarTipocontrato()
    End Sub
    Private Sub LlenarTipocontrato()
        CboTipoContrato.Items.Add("Cliente")
        CboTipoContrato.Items.Add("Empleado")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If CboTipoContrato.Text = "Cliente" Then
            Close()
            FrmContratoCliente.Show()
        Else
            CboTipoContrato.Text = "Emleado"
            Close()
            FrmContratoEmpleado.Show()

        End If
    End Sub
End Class