﻿Public Class Form1
    Dim tab As List(Of PointF) 'DataVisualization.Charting.DataPoint)
    Dim x_deb, x_tg_deb, x_tg_fin, x_fin As Decimal
    Dim y_deb, y_tg_deb, y_fin, y_tg_fin As Decimal
    Dim serie1 As New DataVisualization.Charting.Series

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

        initValues()

    End Sub

    Private Sub chart_graph_Click(sender As Object, e As MouseEventArgs) Handles chart_graph.Click
        Dim chartpos As PointF
        chartpos = New PointF(chart_graph.ChartAreas("Defaut").AxisX.PixelPositionToValue(e.X), chart_graph.ChartAreas("Defaut").AxisY.PixelPositionToValue(e.Y))
    End Sub

    Private Sub init_nud()
        For Each nud As NumericUpDown In gb_pts.Controls.OfType(Of NumericUpDown)
            nud.Minimum = -1
            nud.Maximum = 1
            nud.DecimalPlaces = 1
            nud.Increment = 0.1
        Next
    End Sub

    Private Sub initValues()
        x_deb = nud_x_deb.Value
        y_deb = nud_y_deb.Value
        x_tg_deb = nud_x_tg_deb.Value
        y_tg_deb = nud_y_tg_deb.Value
        x_tg_fin = nud_x_tg_fin.Value
        y_tg_fin = nud_y_tg_fin.Value
        x_fin = nud_x_fin.Value
        y_fin = nud_y_fin.Value
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud_x_deb.ValueChanged, nud_x_tg_fin.ValueChanged, nud_x_tg_deb.ValueChanged, nud_x_fin.ValueChanged, nud_nb_seg.ValueChanged, nud_y_tg_fin.ValueChanged, nud_y_tg_deb.ValueChanged, nud_y_fin.ValueChanged, nud_y_deb.ValueChanged
        initValues()
        actualiserTab()
        inconnu()
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

    Public Sub actualiserTab()
        tab = New List(Of PointF)
        Dim fact As Decimal
         fact = 1 / nud_nb_seg.Value
        For n = 0 To nud_nb_seg.Value
            tab.Add(calcPoint(x_deb, x_tg_deb, x_fin, x_tg_fin, y_deb, y_tg_deb, y_fin, y_tg_fin, n * fact))
        Next n
    End Sub

    Sub inconnu()

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
        chart_graph.Series.Add("bezier")
        chart_graph.Series("bezier").Color = Color.Red
        chart_graph.Series("bezier").ChartType = DataVisualization.Charting.SeriesChartType.Line

        For Each pt As PointF In tab
            chart_graph.Series("bezier").Points.AddXY(pt.X, pt.Y)
        Next

    End Sub

    '   Sub abc()
    '  Dim graph = Panel_g.CreateGraphics()
    '     graph.Dispose() ; 
    'Dim stylo As Pen
    '   stylo = New Pen(Color.Red, 3)
    '  graph.DrawLines(stylo, tab.ToArray())
    ' End Sub

End Class
