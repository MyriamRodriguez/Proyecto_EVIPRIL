Public Class PantallaPrincipal
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Reporte.Show()
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNombre.Text = Identificador.Nombre
    End Sub

<<<<<<< HEAD
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

=======
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmEmpleado.Show()
>>>>>>> 26012660d2f321534ffb70ffe3d6a1d8b76afeae
    End Sub
End Class