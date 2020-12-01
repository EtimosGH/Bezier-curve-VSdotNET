<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nud_x_tg_deb = New System.Windows.Forms.NumericUpDown()
        Me.nud_x_deb = New System.Windows.Forms.NumericUpDown()
        Me.lb_deb = New System.Windows.Forms.Label()
        Me.gb_pts = New System.Windows.Forms.GroupBox()
        Me.lb_y = New System.Windows.Forms.Label()
        Me.lb_x = New System.Windows.Forms.Label()
        Me.nud_y_tg_fin = New System.Windows.Forms.NumericUpDown()
        Me.nud_y_fin = New System.Windows.Forms.NumericUpDown()
        Me.nud_y_tg_deb = New System.Windows.Forms.NumericUpDown()
        Me.nud_y_deb = New System.Windows.Forms.NumericUpDown()
        Me.lb_fin = New System.Windows.Forms.Label()
        Me.lb_tg_debut = New System.Windows.Forms.Label()
        Me.lb_tg_fin = New System.Windows.Forms.Label()
        Me.nud_x_tg_fin = New System.Windows.Forms.NumericUpDown()
        Me.nud_x_fin = New System.Windows.Forms.NumericUpDown()
        Me.bt_help = New System.Windows.Forms.Button()
        Me.gb_nb_seg = New System.Windows.Forms.GroupBox()
        Me.lb_nb_seg = New System.Windows.Forms.Label()
        Me.nud_nb_seg = New System.Windows.Forms.NumericUpDown()
        Me.chart_graph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SelectCurve = New System.Windows.Forms.ComboBox()
        Me.SelectionGB = New System.Windows.Forms.GroupBox()
        Me.DeleteCurveBt = New System.Windows.Forms.Button()
        Me.AddCurveBt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Vert = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRouge = New System.Windows.Forms.NumericUpDown()
        Me.CVert = New System.Windows.Forms.NumericUpDown()
        Me.CBleu = New System.Windows.Forms.NumericUpDown()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_x_tg_deb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_x_deb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_pts.SuspendLayout()
        CType(Me.nud_y_tg_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_y_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_y_tg_deb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_y_deb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_x_tg_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_x_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_nb_seg.SuspendLayout()
        CType(Me.nud_nb_seg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart_graph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectionGB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CRouge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CVert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBleu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(45, 70)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 198)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'nud_x_tg_deb
        '
        Me.nud_x_tg_deb.Location = New System.Drawing.Point(105, 53)
        Me.nud_x_tg_deb.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_x_tg_deb.Name = "nud_x_tg_deb"
        Me.nud_x_tg_deb.Size = New System.Drawing.Size(45, 20)
        Me.nud_x_tg_deb.TabIndex = 2
        '
        'nud_x_deb
        '
        Me.nud_x_deb.Location = New System.Drawing.Point(105, 32)
        Me.nud_x_deb.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_x_deb.Name = "nud_x_deb"
        Me.nud_x_deb.Size = New System.Drawing.Size(45, 20)
        Me.nud_x_deb.TabIndex = 3
        '
        'lb_deb
        '
        Me.lb_deb.AutoSize = True
        Me.lb_deb.Location = New System.Drawing.Point(65, 33)
        Me.lb_deb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_deb.Name = "lb_deb"
        Me.lb_deb.Size = New System.Drawing.Size(36, 13)
        Me.lb_deb.TabIndex = 4
        Me.lb_deb.Text = "Début"
        '
        'gb_pts
        '
        Me.gb_pts.Controls.Add(Me.lb_y)
        Me.gb_pts.Controls.Add(Me.lb_x)
        Me.gb_pts.Controls.Add(Me.nud_y_tg_fin)
        Me.gb_pts.Controls.Add(Me.nud_y_fin)
        Me.gb_pts.Controls.Add(Me.nud_y_tg_deb)
        Me.gb_pts.Controls.Add(Me.nud_y_deb)
        Me.gb_pts.Controls.Add(Me.lb_fin)
        Me.gb_pts.Controls.Add(Me.lb_tg_debut)
        Me.gb_pts.Controls.Add(Me.lb_tg_fin)
        Me.gb_pts.Controls.Add(Me.nud_x_tg_fin)
        Me.gb_pts.Controls.Add(Me.nud_x_fin)
        Me.gb_pts.Controls.Add(Me.lb_deb)
        Me.gb_pts.Controls.Add(Me.nud_x_tg_deb)
        Me.gb_pts.Controls.Add(Me.nud_x_deb)
        Me.gb_pts.Location = New System.Drawing.Point(15, 73)
        Me.gb_pts.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_pts.Name = "gb_pts"
        Me.gb_pts.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_pts.Size = New System.Drawing.Size(217, 133)
        Me.gb_pts.TabIndex = 5
        Me.gb_pts.TabStop = False
        Me.gb_pts.Text = "Definition des points"
        '
        'lb_y
        '
        Me.lb_y.AutoSize = True
        Me.lb_y.Location = New System.Drawing.Point(151, 17)
        Me.lb_y.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_y.Name = "lb_y"
        Me.lb_y.Size = New System.Drawing.Size(14, 13)
        Me.lb_y.TabIndex = 15
        Me.lb_y.Text = "Y"
        '
        'lb_x
        '
        Me.lb_x.AutoSize = True
        Me.lb_x.Location = New System.Drawing.Point(104, 17)
        Me.lb_x.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_x.Name = "lb_x"
        Me.lb_x.Size = New System.Drawing.Size(14, 13)
        Me.lb_x.TabIndex = 14
        Me.lb_x.Text = "X"
        '
        'nud_y_tg_fin
        '
        Me.nud_y_tg_fin.Location = New System.Drawing.Point(153, 94)
        Me.nud_y_tg_fin.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_y_tg_fin.Name = "nud_y_tg_fin"
        Me.nud_y_tg_fin.Size = New System.Drawing.Size(45, 20)
        Me.nud_y_tg_fin.TabIndex = 13
        '
        'nud_y_fin
        '
        Me.nud_y_fin.Location = New System.Drawing.Point(153, 73)
        Me.nud_y_fin.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_y_fin.Name = "nud_y_fin"
        Me.nud_y_fin.Size = New System.Drawing.Size(45, 20)
        Me.nud_y_fin.TabIndex = 12
        '
        'nud_y_tg_deb
        '
        Me.nud_y_tg_deb.Location = New System.Drawing.Point(153, 53)
        Me.nud_y_tg_deb.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_y_tg_deb.Name = "nud_y_tg_deb"
        Me.nud_y_tg_deb.Size = New System.Drawing.Size(45, 20)
        Me.nud_y_tg_deb.TabIndex = 11
        '
        'nud_y_deb
        '
        Me.nud_y_deb.Location = New System.Drawing.Point(153, 32)
        Me.nud_y_deb.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_y_deb.Name = "nud_y_deb"
        Me.nud_y_deb.Size = New System.Drawing.Size(45, 20)
        Me.nud_y_deb.TabIndex = 10
        '
        'lb_fin
        '
        Me.lb_fin.AutoSize = True
        Me.lb_fin.Location = New System.Drawing.Point(80, 75)
        Me.lb_fin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_fin.Name = "lb_fin"
        Me.lb_fin.Size = New System.Drawing.Size(21, 13)
        Me.lb_fin.TabIndex = 9
        Me.lb_fin.Text = "Fin"
        '
        'lb_tg_debut
        '
        Me.lb_tg_debut.AutoSize = True
        Me.lb_tg_debut.Location = New System.Drawing.Point(13, 54)
        Me.lb_tg_debut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_tg_debut.Name = "lb_tg_debut"
        Me.lb_tg_debut.Size = New System.Drawing.Size(89, 13)
        Me.lb_tg_debut.TabIndex = 8
        Me.lb_tg_debut.Text = "Tangeante début"
        '
        'lb_tg_fin
        '
        Me.lb_tg_fin.AutoSize = True
        Me.lb_tg_fin.Location = New System.Drawing.Point(29, 96)
        Me.lb_tg_fin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_tg_fin.Name = "lb_tg_fin"
        Me.lb_tg_fin.Size = New System.Drawing.Size(73, 13)
        Me.lb_tg_fin.TabIndex = 7
        Me.lb_tg_fin.Text = "Tangeante fin"
        '
        'nud_x_tg_fin
        '
        Me.nud_x_tg_fin.Location = New System.Drawing.Point(105, 94)
        Me.nud_x_tg_fin.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_x_tg_fin.Name = "nud_x_tg_fin"
        Me.nud_x_tg_fin.Size = New System.Drawing.Size(45, 20)
        Me.nud_x_tg_fin.TabIndex = 6
        '
        'nud_x_fin
        '
        Me.nud_x_fin.Location = New System.Drawing.Point(105, 73)
        Me.nud_x_fin.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_x_fin.Name = "nud_x_fin"
        Me.nud_x_fin.Size = New System.Drawing.Size(45, 20)
        Me.nud_x_fin.TabIndex = 5
        '
        'bt_help
        '
        Me.bt_help.BackColor = System.Drawing.SystemColors.Info
        Me.bt_help.Location = New System.Drawing.Point(15, 350)
        Me.bt_help.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_help.Name = "bt_help"
        Me.bt_help.Size = New System.Drawing.Size(23, 20)
        Me.bt_help.TabIndex = 6
        Me.bt_help.Text = "?"
        Me.bt_help.UseVisualStyleBackColor = False
        '
        'gb_nb_seg
        '
        Me.gb_nb_seg.Controls.Add(Me.lb_nb_seg)
        Me.gb_nb_seg.Controls.Add(Me.nud_nb_seg)
        Me.gb_nb_seg.Location = New System.Drawing.Point(15, 210)
        Me.gb_nb_seg.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_nb_seg.Name = "gb_nb_seg"
        Me.gb_nb_seg.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_nb_seg.Size = New System.Drawing.Size(217, 64)
        Me.gb_nb_seg.TabIndex = 10
        Me.gb_nb_seg.TabStop = False
        Me.gb_nb_seg.Text = "Précision de la courbe"
        '
        'lb_nb_seg
        '
        Me.lb_nb_seg.AutoSize = True
        Me.lb_nb_seg.Location = New System.Drawing.Point(10, 27)
        Me.lb_nb_seg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_nb_seg.Name = "lb_nb_seg"
        Me.lb_nb_seg.Size = New System.Drawing.Size(107, 13)
        Me.lb_nb_seg.TabIndex = 4
        Me.lb_nb_seg.Text = "Nombre de segments"
        '
        'nud_nb_seg
        '
        Me.nud_nb_seg.Location = New System.Drawing.Point(121, 25)
        Me.nud_nb_seg.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_nb_seg.Name = "nud_nb_seg"
        Me.nud_nb_seg.Size = New System.Drawing.Size(80, 20)
        Me.nud_nb_seg.TabIndex = 3
        '
        'chart_graph
        '
        Me.chart_graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea4.Name = "ChartArea1"
        Me.chart_graph.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chart_graph.Legends.Add(Legend4)
        Me.chart_graph.Location = New System.Drawing.Point(236, 19)
        Me.chart_graph.Margin = New System.Windows.Forms.Padding(2)
        Me.chart_graph.Name = "chart_graph"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.MarkerBorderWidth = 0
        Series4.Name = "Series1"
        Me.chart_graph.Series.Add(Series4)
        Me.chart_graph.Size = New System.Drawing.Size(399, 351)
        Me.chart_graph.TabIndex = 0
        Me.chart_graph.Text = "Chart1"
        '
        'SelectCurve
        '
        Me.SelectCurve.FormattingEnabled = True
        Me.SelectCurve.Location = New System.Drawing.Point(5, 19)
        Me.SelectCurve.Name = "SelectCurve"
        Me.SelectCurve.Size = New System.Drawing.Size(106, 21)
        Me.SelectCurve.TabIndex = 11
        '
        'SelectionGB
        '
        Me.SelectionGB.Controls.Add(Me.DeleteCurveBt)
        Me.SelectionGB.Controls.Add(Me.AddCurveBt)
        Me.SelectionGB.Controls.Add(Me.SelectCurve)
        Me.SelectionGB.Location = New System.Drawing.Point(15, 19)
        Me.SelectionGB.Name = "SelectionGB"
        Me.SelectionGB.Size = New System.Drawing.Size(217, 49)
        Me.SelectionGB.TabIndex = 12
        Me.SelectionGB.TabStop = False
        Me.SelectionGB.Text = "Selection courbe"
        '
        'DeleteCurveBt
        '
        Me.DeleteCurveBt.Location = New System.Drawing.Point(167, 18)
        Me.DeleteCurveBt.Name = "DeleteCurveBt"
        Me.DeleteCurveBt.Size = New System.Drawing.Size(44, 23)
        Me.DeleteCurveBt.TabIndex = 13
        Me.DeleteCurveBt.Text = "Del."
        Me.DeleteCurveBt.UseVisualStyleBackColor = True
        '
        'AddCurveBt
        '
        Me.AddCurveBt.Location = New System.Drawing.Point(117, 18)
        Me.AddCurveBt.Name = "AddCurveBt"
        Me.AddCurveBt.Size = New System.Drawing.Size(44, 23)
        Me.AddCurveBt.TabIndex = 12
        Me.AddCurveBt.Text = "New"
        Me.AddCurveBt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBleu)
        Me.GroupBox1.Controls.Add(Me.CVert)
        Me.GroupBox1.Controls.Add(Me.CRouge)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Vert)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 58)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Couleur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bleu"
        '
        'Vert
        '
        Me.Vert.AutoSize = True
        Me.Vert.Location = New System.Drawing.Point(92, 16)
        Me.Vert.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Vert.Name = "Vert"
        Me.Vert.Size = New System.Drawing.Size(26, 13)
        Me.Vert.TabIndex = 6
        Me.Vert.Text = "Vert"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rouge"
        '
        'CRouge
        '
        Me.CRouge.Location = New System.Drawing.Point(8, 31)
        Me.CRouge.Margin = New System.Windows.Forms.Padding(2)
        Me.CRouge.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.CRouge.Name = "CRouge"
        Me.CRouge.Size = New System.Drawing.Size(45, 20)
        Me.CRouge.TabIndex = 8
        Me.CRouge.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'CVert
        '
        Me.CVert.Location = New System.Drawing.Point(83, 31)
        Me.CVert.Margin = New System.Windows.Forms.Padding(2)
        Me.CVert.Name = "CVert"
        Me.CVert.Size = New System.Drawing.Size(45, 20)
        Me.CVert.TabIndex = 9
        Me.CVert.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'CBleu
        '
        Me.CBleu.Location = New System.Drawing.Point(153, 31)
        Me.CBleu.Margin = New System.Windows.Forms.Padding(2)
        Me.CBleu.Name = "CBleu"
        Me.CBleu.Size = New System.Drawing.Size(45, 20)
        Me.CBleu.TabIndex = 10
        Me.CBleu.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(739, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SelectionGB)
        Me.Controls.Add(Me.chart_graph)
        Me.Controls.Add(Me.gb_nb_seg)
        Me.Controls.Add(Me.bt_help)
        Me.Controls.Add(Me.gb_pts)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Courbes de bezier"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_x_tg_deb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_x_deb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_pts.ResumeLayout(False)
        Me.gb_pts.PerformLayout()
        CType(Me.nud_y_tg_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_y_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_y_tg_deb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_y_deb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_x_tg_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_x_fin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_nb_seg.ResumeLayout(False)
        Me.gb_nb_seg.PerformLayout()
        CType(Me.nud_nb_seg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_graph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectionGB.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CRouge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CVert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBleu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nud_x_tg_deb As NumericUpDown
    Friend WithEvents nud_x_deb As NumericUpDown
    Friend WithEvents lb_deb As Label
    Friend WithEvents gb_pts As GroupBox
    Friend WithEvents lb_fin As Label
    Friend WithEvents lb_tg_debut As Label
    Friend WithEvents lb_tg_fin As Label
    Friend WithEvents nud_x_tg_fin As NumericUpDown
    Friend WithEvents nud_x_fin As NumericUpDown
    Friend WithEvents bt_help As Button
    Friend WithEvents gb_nb_seg As GroupBox
    Friend WithEvents lb_nb_seg As Label
    Friend WithEvents nud_nb_seg As NumericUpDown
    Friend WithEvents nud_y_fin As NumericUpDown
    Friend WithEvents nud_y_tg_deb As NumericUpDown
    Friend WithEvents nud_y_deb As NumericUpDown
    Friend WithEvents lb_x As Label
    Friend WithEvents nud_y_tg_fin As NumericUpDown
    Friend WithEvents lb_y As Label
    Friend WithEvents chart_graph As DataVisualization.Charting.Chart
    Friend WithEvents SelectCurve As ComboBox
    Friend WithEvents SelectionGB As GroupBox
    Friend WithEvents DeleteCurveBt As Button
    Friend WithEvents AddCurveBt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Vert As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBleu As NumericUpDown
    Friend WithEvents CVert As NumericUpDown
    Friend WithEvents CRouge As NumericUpDown
End Class
