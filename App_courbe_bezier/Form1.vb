Public Class Form1
    Dim tab As List(Of PointF) 'DataVisualization.Charting.DataPoint)
    Dim listCourbes As List(Of Courbes)
    Dim courbe As Courbes
    'Dim x_deb, x_tg_deb, x_tg_fin, x_fin As Decimal
    'Dim y_deb, y_tg_deb, y_fin, y_tg_fin As Decimal
    'Dim nbSeg As Int16
    Public nbCurves As Int16 = 0
    Public except_EA_SelectedIndexChanged As Boolean = False
    Public except_EA_nud_ValueChanged As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        init_nud()
        nud_nb_seg.Minimum = 1
        nud_nb_seg.Maximum = 1000
        nud_nb_seg.DecimalPlaces = 0

        'zone de test'
        nud_x_deb.Value = -1
        nud_y_deb.Value = -1
        nud_x_tg_deb.Value = 1
        nud_y_tg_deb.Value = 0
        nud_x_tg_fin.Value = 0
        nud_y_tg_fin.Value = 1
        nud_x_fin.Value = 1
        nud_y_fin.Value = 1
        nud_nb_seg.Value = 4
        'FIN zone'

        initchart()
        listCourbes = New List(Of Courbes)
    End Sub

    Private Sub chart_graph_Click(sender As Object, e As MouseEventArgs) Handles chart_graph.Click
        Dim chartpos As PointF
        chartpos = New PointF(chart_graph.ChartAreas("Defaut").AxisX.PixelPositionToValue(e.X), chart_graph.ChartAreas("Defaut").AxisY.PixelPositionToValue(e.Y))
    End Sub

    Private Sub AddCurveBt_Click(sender As Object, e As EventArgs) Handles AddCurveBt.Click
        except_EA_SelectedIndexChanged = True

        SelectCurve.Items.Add(nbCurves)
        SelectCurve.SelectedIndex = SelectCurve.Items.IndexOf(nbCurves)

        listCourbes.Add(New Courbes)
        listCourbes(nbCurves).name = "Courbe " + nbCurves.ToString()
        addSeries(listCourbes(nbCurves).name)

        GetCurveValue(listCourbes(SelectCurve.Text))


        nbCurves += 1
        except_EA_SelectedIndexChanged = False
    End Sub

    Private Sub init_nud() 'ok
        For Each nud As NumericUpDown In gb_pts.Controls.OfType(Of NumericUpDown)
            nud.Minimum = -1
            nud.Maximum = 1
            nud.DecimalPlaces = 1
            nud.Increment = 0.1
        Next
    End Sub

    Private Sub initValues(courbe As Courbes)
        courbe.x_deb = nud_x_deb.Value
        courbe.y_deb = nud_y_deb.Value
        courbe.x_tg_deb = nud_x_tg_deb.Value
        courbe.y_tg_deb = nud_y_tg_deb.Value
        courbe.x_tg_fin = nud_x_tg_fin.Value
        courbe.y_tg_fin = nud_y_tg_fin.Value
        courbe.x_fin = nud_x_fin.Value
        courbe.y_fin = nud_y_fin.Value
        courbe.nbSeg = nud_nb_seg.Value
    End Sub

    Private Sub GetCurveValue(courbe As Courbes)
        except_EA_nud_ValueChanged = True
        nud_x_deb.Value = courbe.x_deb
        nud_y_deb.Value = courbe.y_deb
        nud_x_tg_deb.Value = courbe.x_tg_deb
        nud_y_tg_deb.Value = courbe.y_tg_deb
        nud_x_tg_fin.Value = courbe.x_tg_fin
        nud_y_tg_fin.Value = courbe.y_tg_fin
        nud_x_fin.Value = courbe.x_fin
        nud_y_fin.Value = courbe.y_fin
        nud_nb_seg.Value = courbe.nbSeg
        except_EA_nud_ValueChanged = False
    End Sub

    Private Sub DeleteCurveBt_Click(sender As Object, e As EventArgs) Handles DeleteCurveBt.Click ', SelectCurve.SelectedIndexChanged
        Try
            chart_graph.Series(listCourbes(SelectCurve.Text).name).Points.Clear()
            chart_graph.Series.Remove(chart_graph.Series(listCourbes(SelectCurve.Text).name))
            SelectCurve.Items.RemoveAt(SelectCurve.FindStringExact(SelectCurve.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ColorChange.Click
        Dim MyDialog As New ColorDialog()
        MyDialog.AllowFullOpen = False
        MyDialog.ShowHelp = True
        MyDialog.Color = chart_graph.Series(listCourbes(SelectCurve.Text).name).Color

        If MyDialog.ShowDialog() = DialogResult.OK Then
            chart_graph.Series(listCourbes(SelectCurve.Text).name).Color = MyDialog.Color
        End If
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud_x_deb.ValueChanged, nud_x_tg_fin.ValueChanged, nud_x_tg_deb.ValueChanged, nud_x_fin.ValueChanged, nud_nb_seg.ValueChanged, nud_y_tg_fin.ValueChanged, nud_y_tg_deb.ValueChanged, nud_y_fin.ValueChanged, nud_y_deb.ValueChanged

        If (SelectCurve.Text <> "" And except_EA_nud_ValueChanged = False) Then

            initValues(listCourbes(SelectCurve.Text))
            SetSeriePoints(listCourbes(SelectCurve.Text).name)
        End If
    End Sub

    Public Function calcPoint(x_deb As Decimal, x_tg_deb As Decimal, x_fin As Decimal, x_tg_fin As Decimal, y_deb As Decimal, y_tg_deb As Decimal, y_fin As Decimal, y_tg_fin As Decimal, t As Decimal) As PointF
        Dim x As Decimal
        Dim y As Decimal
        Dim point As PointF
        x = ((1 - t) ^ 3) * x_deb + 3 * t * ((1 - t) ^ 2) * x_tg_deb + 3 * (t ^ 2) * (1 - t) * x_tg_fin + (t ^ 3) * x_fin
        y = ((1 - t) ^ 3) * y_deb + 3 * t * ((1 - t) ^ 2) * y_tg_deb + 3 * (t ^ 2) * (1 - t) * y_tg_fin + (t ^ 3) * y_fin
        point.X = x
        point.Y = y
        Return point
    End Function

    Public Sub actualiserTab(courbe As Courbes)
        tab = New List(Of PointF)
        Dim fact As Decimal
        fact = 1 / nud_nb_seg.Value
        For n = 0 To nud_nb_seg.Value
            tab.Add(calcPoint(courbe.x_deb, courbe.x_tg_deb, courbe.x_fin, courbe.x_tg_fin, courbe.y_deb, courbe.y_tg_deb, courbe.y_fin, courbe.y_tg_fin, n * fact))
        Next n
    End Sub

    Sub initchart()

        chart_graph.ChartAreas.Clear()
        chart_graph.ChartAreas.Add("Defaut")
        chart_graph.ChartAreas("Defaut").AxisX.Interval = 0.1
        chart_graph.ChartAreas("Defaut").AxisX.MajorGrid.LineColor = Color.LightBlue
        chart_graph.ChartAreas("Defaut").AxisX.Maximum = 1
        chart_graph.ChartAreas("Defaut").AxisX.Minimum = -1

        chart_graph.ChartAreas("Defaut").AxisY.MajorGrid.LineColor = Color.LightBlue
        chart_graph.ChartAreas("Defaut").AxisY.Interval = 0.1
        chart_graph.ChartAreas("Defaut").AxisY.Maximum = 1
        chart_graph.ChartAreas("Defaut").AxisY.Minimum = -1

        chart_graph.Series.Clear()

    End Sub

    'Sub updateSeries()
    'Try
    '       chart_graph.Series(listCourbes(SelectCurve.Text).name).Points.Clear()
    'For Each pt As PointF In tab
    '           chart_graph.Series(listCourbes(SelectCurve.Text).name).Points.AddXY(pt.X, pt.Y)
    'Next
    'Catch
    '
    'End Try
    'End Sub

    Sub addSeries(name As String)
        chart_graph.Series.Add(name)
        chart_graph.Series(name).ChartType = DataVisualization.Charting.SeriesChartType.Line
        SetSeriePoints(name)
    End Sub

    Sub SetSeriePoints(name As String)
        actualiserTab(listCourbes(SelectCurve.Text))
        chart_graph.Series(name).Points.Clear()

        For Each pt As PointF In tab
            chart_graph.Series(name).Points.AddXY(pt.X, pt.Y)
        Next
    End Sub

    Private Sub SelectCurve_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectCurve.SelectedIndexChanged
        If except_EA_SelectedIndexChanged = False Then
            GetCurveValue(listCourbes(SelectCurve.Text))
        End If
    End Sub
End Class

