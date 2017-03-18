Imports System.Data.SqlClient

Public Class FrmReportes
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter

    Public Sub MostrarDatosEmpleado()
        da = New SqlDataAdapter("select e.NumIdentidad, e.Nombres,e.Apellidos,e.Direccion,e.Telefono,e.FechaNac,e.NumCuenta,p.Profesion,c.EstadoCivil from Empleado E inner join Profesion P on E.IdProfesion = p.IdProfesion inner join EstadoCivil C on E.IdEstadoCivil = C.IdEstadoCivil", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosContrato()
        da = New SqlDataAdapter("Select * from ContratoEmpleado", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosPlanilla()
        da = New SqlDataAdapter("Select * from Planilla", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosInventario()
        da = New SqlDataAdapter("Select * from InventarioArmas", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosCliente()
        da = New SqlDataAdapter("Select * from Clientes", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosPrestaciones()
        da = New SqlDataAdapter("Select * from Prestaciones", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        Dispose()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sele = 1 Then
            MostrarDatosEmpleado()
        ElseIf sele = 2 Then
            MostrarDatosPlanilla()
        ElseIf sele = 3 Then
            MostrarDatosInventario()
        ElseIf sele = 4 Then
            MostrarDatosCliente()
        ElseIf sele = 5 Then
            MostrarDatosPrestaciones()
        ElseIf sele = 6 Then
            MostrarDatosContrato()
        End If

    End Sub
End Class