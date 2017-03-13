
Imports System.Data.SqlClient
Public Class FrmEmpleado
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstadoCivil()
        CargarProfesion()
    End Sub

    Private Sub CargarProfesion()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Profesion")
                cboProfesion.DataSource = ds.Tables(0)
                cboProfesion.DisplayMember = ds.Tables(0).Columns("Profesion").ToString
                cboProfesion.ValueMember = ds.Tables(0).Columns("IdProfesion").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarEstadoCivil()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarEstadoCivil"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "EstadoCivil")
                cboEstadoCivil.DataSource = ds.Tables(0)
                cboEstadoCivil.DisplayMember = ds.Tables(0).Columns("EstadoCivil").ToString
                cboEstadoCivil.ValueMember = ds.Tables(0).Columns("IdEstadoCivil").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub AgregarEmpleado()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = txtNumIdentidad.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = txtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = txtApellido.Text
                    .Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = txtTelefono.Text
                    .Parameters.Add("@FechaNac", SqlDbType.Date).Value = dtpFechaNacimiento.Value
                    .Parameters.Add("@NumCuenta", SqlDbType.Int).Value = txtNumCuenta.Text
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = cboProfesion.SelectedValue
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = cboEstadoCivil.SelectedValue
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDireccion.Text = "" Or txtNumCuenta.Text = "" Or txtNumIdentidad.Text = "" Or txtTelefono.Text = "" Then
            MsgBox("No puede dejar campos vacios.")
        Else

            AgregarEmpleado()
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Close()
        PantallaPrincipal.Show()
    End Sub

End Class