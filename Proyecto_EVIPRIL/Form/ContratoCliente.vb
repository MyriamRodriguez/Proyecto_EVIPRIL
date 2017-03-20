Public Class FrmContratoCliente
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
        FrmTipoContrato.Show()

    End Sub
End Class