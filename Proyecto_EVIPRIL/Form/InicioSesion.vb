
Imports System.Data.SqlClient
Public Class FrmInicioSesion
    Private Sub BtnInisioSesion_Click(sender As Object, e As EventArgs) Handles BtnInisioSesion.Click
        Using cnn As New SqlConnection(My.Settings.ConexionEVIPRIL)

            Try
                cnn.Open()

                Dim user As String = Replace(TxtUsuario.Text, "", "'")
                Dim pass As String = SHA1(TxtContraseña.Text)

                Using cmd As New SqlCommand("Select * from Usuario Where Usuario = '" & user & "' and Contraseña = '" & pass & "'", cnn)

                    Dim reader As SqlDataReader = cmd.ExecuteReader


                    If reader.HasRows Then
                        reader.Read()
                        ' UsuarioActivo.NombreCompleto = String.Format("Bienvenido {0} {(1)}", reader.GetValue(1), reader.GetValue(2))
                        PantallaPrincipal.Show()
                    Else
                        MsgBox("Usuario y contraseña invalido")
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
End Class
