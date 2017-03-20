Imports System.Data.SqlClient
Public Class FrmContratoCliente
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
        FrmTipoContrato.Show()

    End Sub

    Private Sub FrmContratoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCliente()
        CboNombreCliente.Text = ""
    End Sub

    Private Sub AgregarContrato()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertContratoCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = TxtFechaInico.Text
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = TxtFechaFinal.Text
                    .Parameters.Add("@IdCliente", SqlDbType.Int).Value = CboNombreCliente.SelectedValue
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar).Value = TxtObservaciones.Text
                    .Parameters.Add("@NumeroGuardia", SqlDbType.Int).Value = TxtNguardias.Text


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

    Private Sub CargarCliente()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "NombreCompañia")
                CboNombreCliente.DataSource = ds.Tables(0)
                CboNombreCliente.DisplayMember = ds.Tables(0).Columns("NombreCompañia").ToString
                CboNombreCliente.ValueMember = ds.Tables(0).Columns("IdCliente").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles PbxGuardar.Click
        If TxtFechaInico.Text = "" Or TxtFechaInico.Text = "" Or CboNombreCliente.Text = "" Or TxtNguardias.Text = "" Or TxtObservaciones.Text = "" Then
            MsgBox("No puede dejar campos vacios.")
        Else
            AgregarContrato()
            TxtFechaFinal.Text = ""
            TxtFechaInico.Text = ""
            TxtNguardias.Text = ""
            TxtObservaciones.Text = ""
            CboNombreCliente.Text = ""
            TxtFechaInico.Focus()
        End If
    End Sub
End Class