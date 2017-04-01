Public Class FrmPantallaPrincipal
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Reporte.Show()
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNombre.Text = Identificador.Nombre
    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Close()
        FrmTipoContrato.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) 

    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        FrmPlanilla.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmEmpleado.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        FrmCliente.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmInventario.Show()
    End Sub
End Class