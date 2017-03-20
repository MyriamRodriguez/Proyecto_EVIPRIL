Public Class Inventario
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        If Txtcodigo.Text = "" Or Txtserie.Text = "" Or Txtcalibre.Text = "" Or Txtfabricacion.Text = "" Or Txttipoarma.Text = "" Or Cbomodelo.Text = "" Or Cbomarca.Text = "" Then
            MsgBox("No puede dejar campos vacios.")
        Else

        End If
    End Sub

    Private Sub Btnatras_Click(sender As Object, e As EventArgs) Handles Btnatras.Click
        Close()
    End Sub

    Private Sub tBtninicio_Click(sender As Object, e As EventArgs) Handles tBtninicio.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub
End Class