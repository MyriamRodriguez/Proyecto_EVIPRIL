Public Class FrmPrestaciones
    Private Sub FrmPrestaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboPreaviso.Items.Add("Si")
        CboPreaviso.Items.Add("No")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
