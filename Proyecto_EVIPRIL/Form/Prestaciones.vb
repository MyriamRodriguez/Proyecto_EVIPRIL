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
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumIdentidadEmpleado.KeyDown

    End Sub

    Private Sub txtNumIdentidadEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtNumIdentidadEmpleado.TextChanged
        If Me.txtNumIdentidadEmpleado.TextLength = 13 Then
            AccesoDatos.CargarDatosContrato(txtNumIdentidadEmpleado.Text, TxtNombre, TxtDia, TxtMes, TxtAño)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim FechaInicial As Date
        Dim FechaActual As Date
        Me.TxtSOM.Text = FormatCurrency(CDbl(Me.TxtSOM.Text))
        Me.TxtSOD.Text = FormatCurrency(CDbl(Me.TxtSOM.Text) / 30, 2)
        Me.TxtSOPM.Text = FormatCurrency((CDbl(Me.TxtSOM.Text) * 14) / 12, 2)
        Me.TxtSOPD.Text = FormatCurrency(CDbl(TxtSOPM.Text) / 30, 2)
        FechaInicial = CDate(String.Format("{0}-{1}-{2}", TxtAño.Text, TxtMes.Text, TxtDia.Text))
        FechaActual = CDate(String.Format("{0}-{1}-{2}", TxtAño1.Text, TxtMes1.Text, TxtDia1.Text))
        Dim diaActual As Integer
        Dim mesActual As Integer
        Dim anioActual As Integer

        Dim diaInicio As Integer
        Dim mesInicio As Integer
        Dim anioInicio As Integer
        Dim B As Integer
        Dim Mes As Integer
        Dim Anios As Integer
        Dim Meses As Integer
        Dim Dias As Integer


        diaActual = DatePart("d", FechaActual)
        mesActual = DatePart("m", FechaActual)
        anioActual = DatePart("yyyy", FechaActual)
        '**************************************'
        diaInicio = DatePart("d", FechaInicial)
        mesInicio = DatePart("m", FechaInicial)
        anioInicio = DatePart("yyyy", FechaInicial)

        B = 0
        Mes = mesInicio - 1

        ' si el mes es febrero
        If (Mes = 2) Then   ' *
            If ((anioActual / 4 = 0 And anioActual / 100.0! = 0) Or anioActual / 400 = 0) Then
                B = 29
            Else
                B = 28
            End If
        ElseIf (Mes <= 7) Then  '*
            If (Mes = 0) Then
                B = 31
            ElseIf (Mes / 2 = 0) Then
                B = 30
            Else
                B = 31
            End If

        ElseIf (Mes > 7) Then
            If (Mes / 2 = 0) Then
                B = 31
            Else
                B = 30
            End If
        End If

        If ((anioInicio > anioActual) Or (anioInicio = anioActual And mesInicio > mesActual) Or (anioInicio = anioActual And mesInicio = mesActual And diaInicio > diaActual)) Then
            MessageBox.Show("La fecha de inicio ha de ser anterior a la fecha Actual")
        Else
            If (mesInicio <= mesActual) Then
                Anios = anioActual - anioInicio
                If (diaInicio <= diaActual) Then
                    Meses = mesActual - mesInicio
                    Dias = diaActual - diaInicio
                Else
                    If (mesActual = mesInicio) Then
                        Anios = Anios - 1
                    End If
                    Meses = (mesActual - mesInicio - 1 + 12) / 12
                    Dias = B - (diaInicio - diaActual)
                End If
            Else
                Anios = anioActual - anioInicio - 1

                If (diaInicio > diaActual) Then
                    Meses = mesActual - mesInicio - 1 + 12
                    Dias = B - (diaInicio - diaActual)
                Else
                    Meses = mesActual - mesInicio + 12
                    Dias = diaActual - diaInicio
                End If
            End If

        End If '*


        Me.TxtAnioAnti.Text = Anios
        Me.TxtMesAnti.Text = Meses
        Me.TxtDiaAnti.Text = Dias

    End Sub
End Class
