Public Class FrmPlanilla

    Private Sub CalcularPlanilla()
        Dim SueldoDiario, Complemento, SueldoQuincenal, SubTotal, Ihss, DeducUniforme, Rap, OtrasDeduc, TotalDeduc, TotalPagar As Double
        Dim DiasTrabajados As Integer

        SueldoDiario = CDbl(TxtSueldoDiario.Text)
        DiasTrabajados = CDbl(TxtDiasTrabajados.Text)
        Complemento = CDbl(TxtComplemento.Text)
        DeducUniforme = CDbl(TxtDeducUniforme.Text)
        OtrasDeduc = CDbl(TxtOtrasDeduc.Text)

        SueldoQuincenal = SueldoDiario * DiasTrabajados
        SubTotal = SueldoQuincenal + Complemento
        Ihss = SubTotal * 0.035
        Rap = SubTotal * 0.015
        TotalDeduc = Ihss + DeducUniforme + Rap + OtrasDeduc
        TotalPagar = SubTotal - TotalDeduc

    End Sub

    Private Sub PbxCalcular_Click(sender As Object, e As EventArgs) Handles PbxCalcular.Click
        Call CalcularPlanilla()
    End Sub

    Private Sub PbxHome_Click(sender As Object, e As EventArgs) Handles PbxHome.Click
        FrmPantallaPrincipal.Show()
    End Sub
End Class