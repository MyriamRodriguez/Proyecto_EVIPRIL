Imports System.Data.SqlClient
Public Class FrmInventario
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        If Txtserie.Text = "" Or Txtcalibre.Text = "" Or Txtfabricacion.Text = "" Or CboTipoArma.Text = "" Or Cbomodelo.Text = "" Or Cbomarca.Text = "" Then
            MsgBox("No puede dejar campos vacios.")
        Else
            AgregarArma()
            Txtcalibre.Text = ""
            Txtserie.Text = ""
            Txtfabricacion.Text = ""
            CboTipoArma.Text = ""
            Cbomodelo.SelectedIndex = -1
            Cbomarca.SelectedIndex = -1
        End If
    End Sub

    Private Sub Btnatras_Click(sender As Object, e As EventArgs) Handles Btnatras.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub tBtninicio_Click(sender As Object, e As EventArgs) Handles tBtninicio.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoArma()
        CargarModelo()
        CargarMarca()
        Cbomarca.Text = ""
        Cbomodelo.Text = ""
        CboTipoArma.Text = ""
    End Sub

    Private Sub CargarTipoArma()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarTipoArma1"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoArma")
                CboTipoArma.DataSource = ds.Tables(0)
                CboTipoArma.DisplayMember = ds.Tables(0).Columns("TipoArma").ToString
                CboTipoArma.ValueMember = ds.Tables(0).Columns("IdTipoArma").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarModelo()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Modelo")
                Cbomodelo.DataSource = ds.Tables(0)
                Cbomodelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                Cbomodelo.ValueMember = ds.Tables(0).Columns("IdModelo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarMarca()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Marca")
                Cbomarca.DataSource = ds.Tables(0)
                Cbomarca.DisplayMember = ds.Tables(0).Columns("Marca").ToString
                Cbomarca.ValueMember = ds.Tables(0).Columns("IdMarca").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub AgregarArma()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertInventarioArmas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Serie", SqlDbType.NVarChar).Value = Txtserie.Text
                    .Parameters.Add("@Calibre", SqlDbType.NVarChar).Value = Txtcalibre.Text
                    .Parameters.Add("@Fabricacion", SqlDbType.NVarChar).Value = Txtfabricacion.Text
                    .Parameters.Add("@IdTipoArma", SqlDbType.Int).Value = CboTipoArma.SelectedValue
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = Cbomodelo.SelectedValue

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
End Class