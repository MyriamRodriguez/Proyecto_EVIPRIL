﻿Public Class PantallaPrincipal
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Reporte.Show()
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNombre.Text = Identificador.Nombre
    End Sub
End Class