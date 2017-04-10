﻿Imports System.Data.SqlClient
Public Class Registrar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub AgregarUsuario()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "AgregarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    .Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = TxtUsuario.Text
                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = TxtContraseña.Text
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumeroIdentidad.Text
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

    Private Sub BtnInisioSesion_Click(sender As Object, e As EventArgs) Handles BtnInisioSesion.Click
        AgregarUsuario()
        MsgBox("Usuario registrado")
    End Sub
End Class