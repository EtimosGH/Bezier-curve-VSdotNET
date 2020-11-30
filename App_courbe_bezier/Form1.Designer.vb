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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(68, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 305)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'nud_x_tg_deb
        '
        Me.nud_x_tg_deb.Location = New System.Drawing.Point(157, 81)
        Me.nud_x_tg_deb.Name = "nud_x_tg_deb"
        Me.nud_x_tg_deb.Size = New System.Drawing.Size(67, 26)
        Me.nud_x_tg_deb.TabIndex = 2
        '
        'nud_x_deb
        '
        Me.nud_x_deb.Location = New System.Drawing.Point(157, 49)
        Me.nud_x_deb.Name = "nud_x_deb"
        Me.nud_x_deb.Size = New System.Drawing.Size(67, 26)
        Me.nud_x_deb.TabIndex = 3
        '
        'lb_deb
        '
        Me.lb_deb.AutoSize = True
        Me.lb_deb.Location = New System.Drawing.Point(98, 51)
        Me.lb_deb.Name = "lb_deb"
        Me.lb_deb.Size = New System.Drawing.Size(53, 20)
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
        Me.gb_pts.Location = New System.Drawing.Point(22, 21)
        Me.gb_pts.Name = "gb_pts"
        Me.gb_pts.Size = New System.Drawing.Size(326, 204)
        Me.gb_pts.TabIndex = 5
        Me.gb_pts.TabStop = False
        Me.gb_pts.Text = "Definition des points"
        '
        'lb_y
        '
        Me.lb_y.AutoSize = True
        Me.lb_y.Location = New System.Drawing.Point(226, 26)
        Me.lb_y.Name = "lb_y"
        Me.lb_y.Size = New System.Drawing.Size(20, 20)
        Me.lb_y.TabIndex = 15
        Me.lb_y.Text = "Y"
        '
        'lb_x
        '
        Me.lb_x.AutoSize = True
        Me.lb_x.Location = New System.Drawing.Point(156, 26)
        Me.lb_x.Name = "lb_x"
        Me.lb_x.Size = New System.Drawing.Size(20, 20)
        Me.lb_x.TabIndex = 14
        Me.lb_x.Text = "X"
        '
        'nud_y_tg_fin
        '
        Me.nud_y_tg_fin.Location = New System.Drawing.Point(230, 145)
        Me.nud_y_tg_fin.Name = "nud_y_tg_fin"
        Me.nud_y_tg_fin.Size = New System.Drawing.Size(67, 26)
        Me.nud_y_tg_fin.TabIndex = 13
        '
        'nud_y_fin
        '
        Me.nud_y_fin.Location = New System.Drawing.Point(230, 113)
        Me.nud_y_fin.Name = "nud_y_fin"
        Me.nud_y_fin.Size = New System.Drawing.Size(67, 26)
        Me.nud_y_fin.TabIndex = 12
        '
        'nud_y_tg_deb
        '
        Me.nud_y_tg_deb.Location = New System.Drawing.Point(230, 81)
        Me.nud_y_tg_deb.Name = "nud_y_tg_deb"
        Me.nud_y_tg_deb.Size = New System.Drawing.Size(67, 26)
        Me.nud_y_tg_deb.TabIndex = 11
        '
        'nud_y_deb
        '
        Me.nud_y_deb.Location = New System.Drawing.Point(230, 49)
        Me.nud_y_deb.Name = "nud_y_deb"
        Me.nud_y_deb.Size = New System.Drawing.Size(67, 26)
        Me.nud_y_deb.TabIndex = 10
        '
        'lb_fin
        '
        Me.lb_fin.AutoSize = True
        Me.lb_fin.Location = New System.Drawing.Point(120, 115)
        Me.lb_fin.Name = "lb_fin"
        Me.lb_fin.Size = New System.Drawing.Size(31, 20)
        Me.lb_fin.TabIndex = 9
        Me.lb_fin.Text = "Fin"
        '
        'lb_tg_debut
        '
        Me.lb_tg_debut.AutoSize = True
        Me.lb_tg_debut.Location = New System.Drawing.Point(20, 83)
        Me.lb_tg_debut.Name = "lb_tg_debut"
        Me.lb_tg_debut.Size = New System.Drawing.Size(131, 20)
        Me.lb_tg_debut.TabIndex = 8
        Me.lb_tg_debut.Text = "Tangeante début"
        '
        'lb_tg_fin
        '
        Me.lb_tg_fin.AutoSize = True
        Me.lb_tg_fin.Location = New System.Drawing.Point(44, 147)
        Me.lb_tg_fin.Name = "lb_tg_fin"
        Me.lb_tg_fin.Size = New System.Drawing.Size(107, 20)
        Me.lb_tg_fin.TabIndex = 7
        Me.lb_tg_fin.Text = "Tangeante fin"
        '
        'nud_x_tg_fin
        '
        Me.nud_x_tg_fin.Location = New System.Drawing.Point(157, 145)
        Me.nud_x_tg_fin.Name = "nud_x_tg_fin"
        Me.nud_x_tg_fin.Size = New System.Drawing.Size(67, 26)
        Me.nud_x_tg_fin.TabIndex = 6
        '
        'nud_x_fin
        '
        Me.nud_x_fin.Location = New System.Drawing.Point(157, 113)
        Me.nud_x_fin.Name = "nud_x_fin"
        Me.nud_x_fin.Size = New System.Drawing.Size(67, 26)
        Me.nud_x_fin.TabIndex = 5
        '
        'bt_help
        '
        Me.bt_help.BackColor = System.Drawing.SystemColors.Info
        Me.bt_help.Location = New System.Drawing.Point(22, 336)
        Me.bt_help.Name = "bt_help"
        Me.bt_help.Size = New System.Drawing.Size(35, 31)
        Me.bt_help.TabIndex = 6
        Me.bt_help.Text = "?"
        Me.bt_help.UseVisualStyleBackColor = False
        '
        'gb_nb_seg
        '
        Me.gb_nb_seg.Controls.Add(Me.lb_nb_seg)
        Me.gb_nb_seg.Controls.Add(Me.nud_nb_seg)
        Me.gb_nb_seg.Location = New System.Drawing.Point(22, 231)
        Me.gb_nb_seg.Name = "gb_nb_seg"
        Me.gb_nb_seg.Size = New System.Drawing.Size(326, 99)
        Me.gb_nb_seg.TabIndex = 10
        Me.gb_nb_seg.TabStop = False
        Me.gb_nb_seg.Text = "Précision de la courbe"
        '
        'lb_nb_seg
        '
        Me.lb_nb_seg.AutoSize = True
        Me.lb_nb_seg.Location = New System.Drawing.Point(15, 41)
        Me.lb_nb_seg.Name = "lb_nb_seg"
        Me.lb_nb_seg.Size = New System.Drawing.Size(161, 20)
        Me.lb_nb_seg.TabIndex = 4
        Me.lb_nb_seg.Text = "Nombre de segments"
        '
        'nud_nb_seg
        '
        Me.nud_nb_seg.Location = New System.Drawing.Point(182, 39)
        Me.nud_nb_seg.Name = "nud_nb_seg"
        Me.nud_nb_seg.Size = New System.Drawing.Size(120, 26)
        Me.nud_nb_seg.TabIndex = 3
        '
        'chart_graph
        '
        Me.chart_graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chart_graph.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chart_graph.Legends.Add(Legend1)
        Me.chart_graph.Location = New System.Drawing.Point(354, 30)
        Me.chart_graph.Name = "chart_graph"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.MarkerBorderWidth = 0
        Series1.Name = "Series1"
        Me.chart_graph.Series.Add(Series1)
        Me.chart_graph.Size = New System.Drawing.Size(599, 540)
        Me.chart_graph.TabIndex = 0
        Me.chart_graph.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1108, 712)
        Me.Controls.Add(Me.chart_graph)
        Me.Controls.Add(Me.gb_nb_seg)
        Me.Controls.Add(Me.bt_help)
        Me.Controls.Add(Me.gb_pts)
        Me.Controls.Add(Me.PictureBox1)
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
End Class
