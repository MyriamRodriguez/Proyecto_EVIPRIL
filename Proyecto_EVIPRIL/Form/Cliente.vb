Imports System.Data.SqlClient

Public Class FrmCliente
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call AgregarCliente()
    End Sub

    Private Sub AgregarCliente()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertClientes"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    .Parameters.Add("@NombreCompañia", SqlDbType.NVarChar).Value = TxtCompañia.Text
                    .Parameters.Add("@NombreContacto", SqlDbType.NVarChar).Value = TxtNombre.Text
                    .Parameters.Add("@Direccion", SqlDbType.VarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = TxtTelefono.Text
                    .ExecuteNonQuery()
                    MsgBox("Guardado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Me.Close()
        PantallaPrincipal.Show()
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Close()
        PantallaPrincipal.Show()
    End Sub
End Class