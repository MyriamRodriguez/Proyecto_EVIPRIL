Public Class FrmContratoEmpleado
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
        FrmTipoContrato.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub FrmContratoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class