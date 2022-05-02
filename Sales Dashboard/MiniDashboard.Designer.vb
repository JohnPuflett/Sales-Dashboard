<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiniDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiniDashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picMiniLogo = New System.Windows.Forms.PictureBox()
        Me.txtMiniClock = New System.Windows.Forms.TextBox()
        Me.picSmallForm = New System.Windows.Forms.PictureBox()
        Me.chrtSalesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrtLabourChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.txtFullDayTTL = New System.Windows.Forms.TextBox()
        Me.txtDayPartCC = New System.Windows.Forms.TextBox()
        Me.txtDayPartTTL = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.txtTaste = New System.Windows.Forms.TextBox()
        Me.txtAccurate = New System.Windows.Forms.TextBox()
        Me.txtFast = New System.Windows.Forms.TextBox()
        Me.txtClean = New System.Windows.Forms.TextBox()
        Me.txtFriendly = New System.Windows.Forms.TextBox()
        Me.txtZOD = New System.Windows.Forms.TextBox()
        Me.txtOSAT = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.txtWeatherDescription = New System.Windows.Forms.TextBox()
        Me.txtClock = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.txtFullDaySalesProjection = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.txtSalesVariancePercentDaily = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ScheduledLabourLabel = New System.Windows.Forms.TextBox()
        Me.AllowedLabourLabel = New System.Windows.Forms.TextBox()
        Me.DailySalesLabel = New System.Windows.Forms.TextBox()
        Me.PreviousSalesLabel = New System.Windows.Forms.TextBox()
        Me.CurrentSalesLabel = New System.Windows.Forms.TextBox()
        Me.SalesVarianceLabel = New System.Windows.Forms.TextBox()
        Me.ProjectedSalesLabel = New System.Windows.Forms.TextBox()
        Me.ActualSalesLabel = New System.Windows.Forms.TextBox()
        Me.LabourVarianceDaily = New System.Windows.Forms.TextBox()
        Me.LabourSchedDaily = New System.Windows.Forms.TextBox()
        Me.LabourAllowedDaily = New System.Windows.Forms.TextBox()
        Me.LabourVariancePrevious = New System.Windows.Forms.TextBox()
        Me.LabourSchedPrevious = New System.Windows.Forms.TextBox()
        Me.LabourAllowedPrevious = New System.Windows.Forms.TextBox()
        Me.LabourVarianceCurrent = New System.Windows.Forms.TextBox()
        Me.LabourSchedCurrent = New System.Windows.Forms.TextBox()
        Me.LabourAllowedCurrent = New System.Windows.Forms.TextBox()
        Me.SalesVarianceDaily = New System.Windows.Forms.TextBox()
        Me.SalesProjectedDaily = New System.Windows.Forms.TextBox()
        Me.SalesActualDaily = New System.Windows.Forms.TextBox()
        Me.SalesVariancePrevious = New System.Windows.Forms.TextBox()
        Me.SalesProjectedPrevious = New System.Windows.Forms.TextBox()
        Me.SalesActualPrevious = New System.Windows.Forms.TextBox()
        Me.SalesVarianceCurrent = New System.Windows.Forms.TextBox()
        Me.SalesProjectedCurrent = New System.Windows.Forms.TextBox()
        Me.SalesActualCurrent = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiniLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmallForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtSalesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtLabourChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 356)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'picMiniLogo
        '
        Me.picMiniLogo.Image = CType(resources.GetObject("picMiniLogo.Image"), System.Drawing.Image)
        Me.picMiniLogo.Location = New System.Drawing.Point(6, 3)
        Me.picMiniLogo.Name = "picMiniLogo"
        Me.picMiniLogo.Size = New System.Drawing.Size(64, 60)
        Me.picMiniLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMiniLogo.TabIndex = 1
        Me.picMiniLogo.TabStop = False
        '
        'txtMiniClock
        '
        Me.txtMiniClock.BackColor = System.Drawing.Color.Black
        Me.txtMiniClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiniClock.Font = New System.Drawing.Font("Arial Black", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiniClock.ForeColor = System.Drawing.Color.White
        Me.txtMiniClock.Location = New System.Drawing.Point(224, 12)
        Me.txtMiniClock.Name = "txtMiniClock"
        Me.txtMiniClock.Size = New System.Drawing.Size(310, 53)
        Me.txtMiniClock.TabIndex = 59
        Me.txtMiniClock.TabStop = False
        Me.txtMiniClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picSmallForm
        '
        Me.picSmallForm.Location = New System.Drawing.Point(966, -150)
        Me.picSmallForm.Name = "picSmallForm"
        Me.picSmallForm.Size = New System.Drawing.Size(68, 69)
        Me.picSmallForm.TabIndex = 168
        Me.picSmallForm.TabStop = False
        '
        'chrtSalesChart
        '
        ChartArea1.AxisX.Crossing = 0R
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.MajorGrid.Interval = 0R
        ChartArea1.AxisX.MajorGrid.IntervalOffset = 0R
        ChartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MinorGrid.Enabled = True
        ChartArea1.Name = "ChartArea1"
        Me.chrtSalesChart.ChartAreas.Add(ChartArea1)
        Me.chrtSalesChart.Location = New System.Drawing.Point(12, 272)
        Me.chrtSalesChart.Name = "chrtSalesChart"
        Series1.BorderWidth = 4
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Blue
        Series1.Name = "Series1"
        Series2.BorderWidth = 4
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Green
        Series2.Name = "Series2"
        Me.chrtSalesChart.Series.Add(Series1)
        Me.chrtSalesChart.Series.Add(Series2)
        Me.chrtSalesChart.Size = New System.Drawing.Size(284, 136)
        Me.chrtSalesChart.TabIndex = 167
        '
        'chrtLabourChart
        '
        ChartArea2.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea2.AxisX.Crossing = 0R
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisX.IsMarginVisible = False
        ChartArea2.AxisX.IsMarksNextToAxis = False
        ChartArea2.AxisX.IsStartedFromZero = False
        ChartArea2.AxisX.MajorGrid.Interval = 0R
        ChartArea2.AxisX.MajorGrid.IntervalOffset = 0R
        ChartArea2.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MinorGrid.Enabled = True
        ChartArea2.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes
        ChartArea2.AxisY.Crossing = 0R
        ChartArea2.CursorX.AutoScroll = False
        ChartArea2.CursorX.LineColor = System.Drawing.Color.Black
        ChartArea2.CursorX.Position = 0R
        ChartArea2.CursorY.Position = 0R
        ChartArea2.Name = "ChartArea1"
        Me.chrtLabourChart.ChartAreas.Add(ChartArea2)
        Me.chrtLabourChart.Location = New System.Drawing.Point(12, 103)
        Me.chrtLabourChart.Name = "chrtLabourChart"
        Series3.BorderWidth = 4
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.Green
        Series3.IsVisibleInLegend = False
        Series3.Name = "Series1"
        Series4.BorderWidth = 4
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.Blue
        Series4.Name = "Series2"
        Me.chrtLabourChart.Series.Add(Series3)
        Me.chrtLabourChart.Series.Add(Series4)
        Me.chrtLabourChart.Size = New System.Drawing.Size(284, 127)
        Me.chrtLabourChart.TabIndex = 166
        Me.chrtLabourChart.TabStop = False
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.White
        Me.TextBox15.Location = New System.Drawing.Point(95, 250)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(114, 16)
        Me.TextBox15.TabIndex = 142
        Me.TextBox15.TabStop = False
        Me.TextBox15.Text = "Sales Tracking"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFullDayTTL
        '
        Me.txtFullDayTTL.BackColor = System.Drawing.Color.Black
        Me.txtFullDayTTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullDayTTL.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullDayTTL.ForeColor = System.Drawing.Color.White
        Me.txtFullDayTTL.Location = New System.Drawing.Point(721, 512)
        Me.txtFullDayTTL.Name = "txtFullDayTTL"
        Me.txtFullDayTTL.Size = New System.Drawing.Size(60, 41)
        Me.txtFullDayTTL.TabIndex = 165
        Me.txtFullDayTTL.TabStop = False
        Me.txtFullDayTTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDayPartCC
        '
        Me.txtDayPartCC.BackColor = System.Drawing.Color.Black
        Me.txtDayPartCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDayPartCC.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayPartCC.ForeColor = System.Drawing.Color.Yellow
        Me.txtDayPartCC.Location = New System.Drawing.Point(792, 477)
        Me.txtDayPartCC.Name = "txtDayPartCC"
        Me.txtDayPartCC.Size = New System.Drawing.Size(60, 41)
        Me.txtDayPartCC.TabIndex = 164
        Me.txtDayPartCC.TabStop = False
        Me.txtDayPartCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDayPartTTL
        '
        Me.txtDayPartTTL.BackColor = System.Drawing.Color.Black
        Me.txtDayPartTTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDayPartTTL.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayPartTTL.ForeColor = System.Drawing.Color.White
        Me.txtDayPartTTL.Location = New System.Drawing.Point(721, 477)
        Me.txtDayPartTTL.Name = "txtDayPartTTL"
        Me.txtDayPartTTL.Size = New System.Drawing.Size(60, 41)
        Me.txtDayPartTTL.TabIndex = 163
        Me.txtDayPartTTL.TabStop = False
        Me.txtDayPartTTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.Color.Black
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox28.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.ForeColor = System.Drawing.Color.White
        Me.TextBox28.Location = New System.Drawing.Point(792, 447)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(60, 29)
        Me.TextBox28.TabIndex = 162
        Me.TextBox28.TabStop = False
        Me.TextBox28.Text = "Curr"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.Color.Black
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox27.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.ForeColor = System.Drawing.Color.White
        Me.TextBox27.Location = New System.Drawing.Point(721, 447)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(60, 29)
        Me.TextBox27.TabIndex = 161
        Me.TextBox27.TabStop = False
        Me.TextBox27.Text = "Curr"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.Color.Black
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.ForeColor = System.Drawing.Color.White
        Me.TextBox26.Location = New System.Drawing.Point(618, 523)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(87, 26)
        Me.TextBox26.TabIndex = 160
        Me.TextBox26.TabStop = False
        Me.TextBox26.Text = "Full Day"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.Color.Black
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.ForeColor = System.Drawing.Color.White
        Me.TextBox25.Location = New System.Drawing.Point(618, 487)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(87, 26)
        Me.TextBox25.TabIndex = 159
        Me.TextBox25.TabStop = False
        Me.TextBox25.Text = "Day Part"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaste
        '
        Me.txtTaste.BackColor = System.Drawing.Color.Black
        Me.txtTaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaste.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaste.ForeColor = System.Drawing.Color.Yellow
        Me.txtTaste.Location = New System.Drawing.Point(901, 516)
        Me.txtTaste.Name = "txtTaste"
        Me.txtTaste.Size = New System.Drawing.Size(87, 53)
        Me.txtTaste.TabIndex = 158
        Me.txtTaste.TabStop = False
        Me.txtTaste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAccurate
        '
        Me.txtAccurate.BackColor = System.Drawing.Color.Black
        Me.txtAccurate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccurate.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccurate.ForeColor = System.Drawing.Color.Yellow
        Me.txtAccurate.Location = New System.Drawing.Point(901, 439)
        Me.txtAccurate.Name = "txtAccurate"
        Me.txtAccurate.Size = New System.Drawing.Size(87, 53)
        Me.txtAccurate.TabIndex = 157
        Me.txtAccurate.TabStop = False
        Me.txtAccurate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFast
        '
        Me.txtFast.BackColor = System.Drawing.Color.Black
        Me.txtFast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFast.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFast.ForeColor = System.Drawing.Color.Yellow
        Me.txtFast.Location = New System.Drawing.Point(901, 360)
        Me.txtFast.Name = "txtFast"
        Me.txtFast.Size = New System.Drawing.Size(87, 53)
        Me.txtFast.TabIndex = 156
        Me.txtFast.TabStop = False
        Me.txtFast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClean
        '
        Me.txtClean.BackColor = System.Drawing.Color.Black
        Me.txtClean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClean.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClean.ForeColor = System.Drawing.Color.Yellow
        Me.txtClean.Location = New System.Drawing.Point(901, 282)
        Me.txtClean.Name = "txtClean"
        Me.txtClean.Size = New System.Drawing.Size(87, 53)
        Me.txtClean.TabIndex = 155
        Me.txtClean.TabStop = False
        Me.txtClean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFriendly
        '
        Me.txtFriendly.BackColor = System.Drawing.Color.Black
        Me.txtFriendly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFriendly.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriendly.ForeColor = System.Drawing.Color.Yellow
        Me.txtFriendly.Location = New System.Drawing.Point(901, 205)
        Me.txtFriendly.Name = "txtFriendly"
        Me.txtFriendly.Size = New System.Drawing.Size(87, 53)
        Me.txtFriendly.TabIndex = 154
        Me.txtFriendly.TabStop = False
        Me.txtFriendly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtZOD
        '
        Me.txtZOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtZOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZOD.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZOD.ForeColor = System.Drawing.Color.White
        Me.txtZOD.Location = New System.Drawing.Point(901, 119)
        Me.txtZOD.Name = "txtZOD"
        Me.txtZOD.Size = New System.Drawing.Size(87, 57)
        Me.txtZOD.TabIndex = 153
        Me.txtZOD.TabStop = False
        Me.txtZOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOSAT
        '
        Me.txtOSAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOSAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOSAT.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOSAT.ForeColor = System.Drawing.Color.White
        Me.txtOSAT.Location = New System.Drawing.Point(901, 35)
        Me.txtOSAT.Name = "txtOSAT"
        Me.txtOSAT.Size = New System.Drawing.Size(87, 57)
        Me.txtOSAT.TabIndex = 152
        Me.txtOSAT.TabStop = False
        Me.txtOSAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.Color.Black
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.ForeColor = System.Drawing.Color.White
        Me.TextBox24.Location = New System.Drawing.Point(901, 492)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(87, 26)
        Me.TextBox24.TabIndex = 151
        Me.TextBox24.TabStop = False
        Me.TextBox24.Text = "Taste"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.Black
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.Color.White
        Me.TextBox23.Location = New System.Drawing.Point(901, 415)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(87, 26)
        Me.TextBox23.TabIndex = 150
        Me.TextBox23.TabStop = False
        Me.TextBox23.Text = "Accurate"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.Black
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.Color.White
        Me.TextBox22.Location = New System.Drawing.Point(901, 336)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(87, 26)
        Me.TextBox22.TabIndex = 149
        Me.TextBox22.TabStop = False
        Me.TextBox22.Text = "Fast"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.Black
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.Color.White
        Me.TextBox21.Location = New System.Drawing.Point(901, 259)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(87, 26)
        Me.TextBox21.TabIndex = 148
        Me.TextBox21.TabStop = False
        Me.TextBox21.Text = "Clean"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Black
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.ForeColor = System.Drawing.Color.White
        Me.TextBox20.Location = New System.Drawing.Point(901, 181)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(87, 26)
        Me.TextBox20.TabIndex = 147
        Me.TextBox20.TabStop = False
        Me.TextBox20.Text = "Friendly"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.White
        Me.TextBox19.Location = New System.Drawing.Point(901, 86)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(87, 35)
        Me.TextBox19.TabIndex = 146
        Me.TextBox19.TabStop = False
        Me.TextBox19.Text = "ZOD"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.ForeColor = System.Drawing.Color.White
        Me.TextBox18.Location = New System.Drawing.Point(901, 2)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(87, 35)
        Me.TextBox18.TabIndex = 145
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = "OSAT"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeatherDescription
        '
        Me.txtWeatherDescription.BackColor = System.Drawing.Color.Black
        Me.txtWeatherDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeatherDescription.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeatherDescription.ForeColor = System.Drawing.Color.White
        Me.txtWeatherDescription.Location = New System.Drawing.Point(-192, -119)
        Me.txtWeatherDescription.Name = "txtWeatherDescription"
        Me.txtWeatherDescription.Size = New System.Drawing.Size(211, 25)
        Me.txtWeatherDescription.TabIndex = 144
        Me.txtWeatherDescription.TabStop = False
        Me.txtWeatherDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClock
        '
        Me.txtClock.BackColor = System.Drawing.Color.Black
        Me.txtClock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClock.Font = New System.Drawing.Font("Arial Black", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClock.ForeColor = System.Drawing.Color.White
        Me.txtClock.Location = New System.Drawing.Point(25, -150)
        Me.txtClock.Name = "txtClock"
        Me.txtClock.Size = New System.Drawing.Size(646, 46)
        Me.txtClock.TabIndex = 143
        Me.txtClock.TabStop = False
        Me.txtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.White
        Me.TextBox14.Location = New System.Drawing.Point(95, 82)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(114, 16)
        Me.TextBox14.TabIndex = 141
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = "Labour Tracking"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Gray
        Me.PictureBox12.Location = New System.Drawing.Point(6, 96)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(300, 144)
        Me.PictureBox12.TabIndex = 139
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox11.Location = New System.Drawing.Point(883, 2)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(127, 173)
        Me.PictureBox11.TabIndex = 138
        Me.PictureBox11.TabStop = False
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.White
        Me.TextBox13.Location = New System.Drawing.Point(901, -44)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(87, 28)
        Me.TextBox13.TabIndex = 137
        Me.TextBox13.TabStop = False
        Me.TextBox13.Text = "VOC"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Location = New System.Drawing.Point(871, -23)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(151, 602)
        Me.PictureBox10.TabIndex = 136
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Location = New System.Drawing.Point(613, 434)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(243, 134)
        Me.PictureBox9.TabIndex = 135
        Me.PictureBox9.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Black
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.White
        Me.TextBox12.Location = New System.Drawing.Point(337, 503)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(85, 26)
        Me.TextBox12.TabIndex = 128
        Me.TextBox12.TabStop = False
        Me.TextBox12.Text = "Day Proj $"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFullDaySalesProjection
        '
        Me.txtFullDaySalesProjection.BackColor = System.Drawing.Color.Black
        Me.txtFullDaySalesProjection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullDaySalesProjection.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullDaySalesProjection.ForeColor = System.Drawing.Color.Yellow
        Me.txtFullDaySalesProjection.Location = New System.Drawing.Point(428, 490)
        Me.txtFullDaySalesProjection.Name = "txtFullDaySalesProjection"
        Me.txtFullDaySalesProjection.Size = New System.Drawing.Size(161, 53)
        Me.txtFullDaySalesProjection.TabIndex = 127
        Me.txtFullDaySalesProjection.TabStop = False
        Me.txtFullDaySalesProjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Black
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(328, 426)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(85, 26)
        Me.TextBox11.TabIndex = 126
        Me.TextBox11.TabStop = False
        Me.TextBox11.Text = "+/- %"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalesVariancePercentDaily
        '
        Me.txtSalesVariancePercentDaily.BackColor = System.Drawing.Color.Black
        Me.txtSalesVariancePercentDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalesVariancePercentDaily.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesVariancePercentDaily.ForeColor = System.Drawing.Color.Yellow
        Me.txtSalesVariancePercentDaily.Location = New System.Drawing.Point(423, 413)
        Me.txtSalesVariancePercentDaily.Name = "txtSalesVariancePercentDaily"
        Me.txtSalesVariancePercentDaily.Size = New System.Drawing.Size(166, 48)
        Me.txtSalesVariancePercentDaily.TabIndex = 125
        Me.txtSalesVariancePercentDaily.TabStop = False
        Me.txtSalesVariancePercentDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(619, 376)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(71, 20)
        Me.TextBox2.TabIndex = 124
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "+/- Hrs"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(619, 329)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(71, 20)
        Me.TextBox9.TabIndex = 123
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "Sched Hrs"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Black
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(619, 282)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(71, 20)
        Me.TextBox10.TabIndex = 122
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "Allowed Hrs"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(458, -43)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(257, 28)
        Me.TextBox8.TabIndex = 121
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "1/2 Hour Tracking"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(332, 379)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 20)
        Me.TextBox5.TabIndex = 120
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "+/- $"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(332, 332)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(56, 20)
        Me.TextBox6.TabIndex = 119
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "Projected $"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(332, 285)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(56, 20)
        Me.TextBox7.TabIndex = 118
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "Actual $"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(642, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(48, 23)
        Me.TextBox3.TabIndex = 117
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "Prev"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(589, 108)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(46, 23)
        Me.TextBox4.TabIndex = 116
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Curr"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(518, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 20)
        Me.TextBox1.TabIndex = 115
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "+/- Hrs"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScheduledLabourLabel
        '
        Me.ScheduledLabourLabel.BackColor = System.Drawing.Color.Black
        Me.ScheduledLabourLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScheduledLabourLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduledLabourLabel.ForeColor = System.Drawing.Color.White
        Me.ScheduledLabourLabel.Location = New System.Drawing.Point(518, 176)
        Me.ScheduledLabourLabel.Name = "ScheduledLabourLabel"
        Me.ScheduledLabourLabel.Size = New System.Drawing.Size(71, 20)
        Me.ScheduledLabourLabel.TabIndex = 114
        Me.ScheduledLabourLabel.TabStop = False
        Me.ScheduledLabourLabel.Text = "Sched Hrs"
        Me.ScheduledLabourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AllowedLabourLabel
        '
        Me.AllowedLabourLabel.BackColor = System.Drawing.Color.Black
        Me.AllowedLabourLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AllowedLabourLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllowedLabourLabel.ForeColor = System.Drawing.Color.White
        Me.AllowedLabourLabel.Location = New System.Drawing.Point(518, 149)
        Me.AllowedLabourLabel.Name = "AllowedLabourLabel"
        Me.AllowedLabourLabel.Size = New System.Drawing.Size(71, 20)
        Me.AllowedLabourLabel.TabIndex = 113
        Me.AllowedLabourLabel.TabStop = False
        Me.AllowedLabourLabel.Text = "Allowed Hrs"
        Me.AllowedLabourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DailySalesLabel
        '
        Me.DailySalesLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DailySalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DailySalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySalesLabel.ForeColor = System.Drawing.Color.White
        Me.DailySalesLabel.Location = New System.Drawing.Point(454, 246)
        Me.DailySalesLabel.Name = "DailySalesLabel"
        Me.DailySalesLabel.Size = New System.Drawing.Size(135, 23)
        Me.DailySalesLabel.TabIndex = 112
        Me.DailySalesLabel.TabStop = False
        Me.DailySalesLabel.Text = "Daily Tracking"
        Me.DailySalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PreviousSalesLabel
        '
        Me.PreviousSalesLabel.BackColor = System.Drawing.Color.Black
        Me.PreviousSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviousSalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousSalesLabel.ForeColor = System.Drawing.Color.White
        Me.PreviousSalesLabel.Location = New System.Drawing.Point(441, 107)
        Me.PreviousSalesLabel.Name = "PreviousSalesLabel"
        Me.PreviousSalesLabel.Size = New System.Drawing.Size(52, 23)
        Me.PreviousSalesLabel.TabIndex = 111
        Me.PreviousSalesLabel.TabStop = False
        Me.PreviousSalesLabel.Text = "Prev"
        Me.PreviousSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CurrentSalesLabel
        '
        Me.CurrentSalesLabel.BackColor = System.Drawing.Color.Black
        Me.CurrentSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentSalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentSalesLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentSalesLabel.Location = New System.Drawing.Point(378, 107)
        Me.CurrentSalesLabel.Name = "CurrentSalesLabel"
        Me.CurrentSalesLabel.Size = New System.Drawing.Size(57, 23)
        Me.CurrentSalesLabel.TabIndex = 110
        Me.CurrentSalesLabel.TabStop = False
        Me.CurrentSalesLabel.Text = "Curr"
        Me.CurrentSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceLabel
        '
        Me.SalesVarianceLabel.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVarianceLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceLabel.ForeColor = System.Drawing.Color.White
        Me.SalesVarianceLabel.Location = New System.Drawing.Point(328, 202)
        Me.SalesVarianceLabel.Name = "SalesVarianceLabel"
        Me.SalesVarianceLabel.Size = New System.Drawing.Size(50, 20)
        Me.SalesVarianceLabel.TabIndex = 109
        Me.SalesVarianceLabel.TabStop = False
        Me.SalesVarianceLabel.Text = "+/- $"
        Me.SalesVarianceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProjectedSalesLabel
        '
        Me.ProjectedSalesLabel.BackColor = System.Drawing.Color.Black
        Me.ProjectedSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectedSalesLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectedSalesLabel.ForeColor = System.Drawing.Color.White
        Me.ProjectedSalesLabel.Location = New System.Drawing.Point(328, 176)
        Me.ProjectedSalesLabel.Name = "ProjectedSalesLabel"
        Me.ProjectedSalesLabel.Size = New System.Drawing.Size(50, 20)
        Me.ProjectedSalesLabel.TabIndex = 108
        Me.ProjectedSalesLabel.TabStop = False
        Me.ProjectedSalesLabel.Text = "Projected $"
        Me.ProjectedSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ActualSalesLabel
        '
        Me.ActualSalesLabel.BackColor = System.Drawing.Color.Black
        Me.ActualSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActualSalesLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualSalesLabel.ForeColor = System.Drawing.Color.White
        Me.ActualSalesLabel.Location = New System.Drawing.Point(328, 149)
        Me.ActualSalesLabel.Name = "ActualSalesLabel"
        Me.ActualSalesLabel.Size = New System.Drawing.Size(50, 20)
        Me.ActualSalesLabel.TabIndex = 107
        Me.ActualSalesLabel.TabStop = False
        Me.ActualSalesLabel.Text = "Actual $"
        Me.ActualSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabourVarianceDaily
        '
        Me.LabourVarianceDaily.BackColor = System.Drawing.Color.Black
        Me.LabourVarianceDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourVarianceDaily.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVarianceDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVarianceDaily.Location = New System.Drawing.Point(725, 364)
        Me.LabourVarianceDaily.Name = "LabourVarianceDaily"
        Me.LabourVarianceDaily.Size = New System.Drawing.Size(100, 53)
        Me.LabourVarianceDaily.TabIndex = 106
        Me.LabourVarianceDaily.TabStop = False
        Me.LabourVarianceDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedDaily
        '
        Me.LabourSchedDaily.BackColor = System.Drawing.Color.Black
        Me.LabourSchedDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourSchedDaily.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedDaily.Location = New System.Drawing.Point(725, 317)
        Me.LabourSchedDaily.Name = "LabourSchedDaily"
        Me.LabourSchedDaily.Size = New System.Drawing.Size(100, 53)
        Me.LabourSchedDaily.TabIndex = 105
        Me.LabourSchedDaily.TabStop = False
        Me.LabourSchedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedDaily
        '
        Me.LabourAllowedDaily.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourAllowedDaily.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedDaily.Location = New System.Drawing.Point(725, 270)
        Me.LabourAllowedDaily.Name = "LabourAllowedDaily"
        Me.LabourAllowedDaily.Size = New System.Drawing.Size(100, 53)
        Me.LabourAllowedDaily.TabIndex = 104
        Me.LabourAllowedDaily.TabStop = False
        Me.LabourAllowedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourVariancePrevious
        '
        Me.LabourVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.LabourVariancePrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourVariancePrevious.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVariancePrevious.Location = New System.Drawing.Point(641, 202)
        Me.LabourVariancePrevious.Name = "LabourVariancePrevious"
        Me.LabourVariancePrevious.Size = New System.Drawing.Size(49, 26)
        Me.LabourVariancePrevious.TabIndex = 103
        Me.LabourVariancePrevious.TabStop = False
        Me.LabourVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedPrevious
        '
        Me.LabourSchedPrevious.BackColor = System.Drawing.Color.Black
        Me.LabourSchedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourSchedPrevious.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedPrevious.Location = New System.Drawing.Point(641, 175)
        Me.LabourSchedPrevious.Name = "LabourSchedPrevious"
        Me.LabourSchedPrevious.Size = New System.Drawing.Size(49, 26)
        Me.LabourSchedPrevious.TabIndex = 102
        Me.LabourSchedPrevious.TabStop = False
        Me.LabourSchedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedPrevious
        '
        Me.LabourAllowedPrevious.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourAllowedPrevious.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedPrevious.Location = New System.Drawing.Point(641, 149)
        Me.LabourAllowedPrevious.Name = "LabourAllowedPrevious"
        Me.LabourAllowedPrevious.Size = New System.Drawing.Size(49, 28)
        Me.LabourAllowedPrevious.TabIndex = 101
        Me.LabourAllowedPrevious.TabStop = False
        Me.LabourAllowedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourVarianceCurrent
        '
        Me.LabourVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourVarianceCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourVarianceCurrent.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVarianceCurrent.Location = New System.Drawing.Point(589, 202)
        Me.LabourVarianceCurrent.Name = "LabourVarianceCurrent"
        Me.LabourVarianceCurrent.Size = New System.Drawing.Size(46, 26)
        Me.LabourVarianceCurrent.TabIndex = 100
        Me.LabourVarianceCurrent.TabStop = False
        Me.LabourVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedCurrent
        '
        Me.LabourSchedCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourSchedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourSchedCurrent.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedCurrent.Location = New System.Drawing.Point(589, 176)
        Me.LabourSchedCurrent.Name = "LabourSchedCurrent"
        Me.LabourSchedCurrent.Size = New System.Drawing.Size(46, 26)
        Me.LabourSchedCurrent.TabIndex = 99
        Me.LabourSchedCurrent.TabStop = False
        Me.LabourSchedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedCurrent
        '
        Me.LabourAllowedCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourAllowedCurrent.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedCurrent.Location = New System.Drawing.Point(589, 149)
        Me.LabourAllowedCurrent.Name = "LabourAllowedCurrent"
        Me.LabourAllowedCurrent.Size = New System.Drawing.Size(46, 28)
        Me.LabourAllowedCurrent.TabIndex = 98
        Me.LabourAllowedCurrent.TabStop = False
        Me.LabourAllowedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SalesVarianceDaily
        '
        Me.SalesVarianceDaily.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVarianceDaily.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceDaily.Location = New System.Drawing.Point(433, 366)
        Me.SalesVarianceDaily.Name = "SalesVarianceDaily"
        Me.SalesVarianceDaily.Size = New System.Drawing.Size(156, 53)
        Me.SalesVarianceDaily.TabIndex = 97
        Me.SalesVarianceDaily.TabStop = False
        Me.SalesVarianceDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedDaily
        '
        Me.SalesProjectedDaily.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesProjectedDaily.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedDaily.Location = New System.Drawing.Point(433, 319)
        Me.SalesProjectedDaily.Name = "SalesProjectedDaily"
        Me.SalesProjectedDaily.Size = New System.Drawing.Size(156, 53)
        Me.SalesProjectedDaily.TabIndex = 96
        Me.SalesProjectedDaily.TabStop = False
        Me.SalesProjectedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualDaily
        '
        Me.SalesActualDaily.BackColor = System.Drawing.Color.Black
        Me.SalesActualDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesActualDaily.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualDaily.Location = New System.Drawing.Point(433, 272)
        Me.SalesActualDaily.Name = "SalesActualDaily"
        Me.SalesActualDaily.Size = New System.Drawing.Size(156, 53)
        Me.SalesActualDaily.TabIndex = 95
        Me.SalesActualDaily.TabStop = False
        Me.SalesActualDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVariancePrevious
        '
        Me.SalesVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.SalesVariancePrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVariancePrevious.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVariancePrevious.Location = New System.Drawing.Point(441, 195)
        Me.SalesVariancePrevious.Name = "SalesVariancePrevious"
        Me.SalesVariancePrevious.Size = New System.Drawing.Size(52, 28)
        Me.SalesVariancePrevious.TabIndex = 94
        Me.SalesVariancePrevious.TabStop = False
        Me.SalesVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedPrevious
        '
        Me.SalesProjectedPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesProjectedPrevious.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedPrevious.Location = New System.Drawing.Point(441, 166)
        Me.SalesProjectedPrevious.Name = "SalesProjectedPrevious"
        Me.SalesProjectedPrevious.Size = New System.Drawing.Size(52, 28)
        Me.SalesProjectedPrevious.TabIndex = 93
        Me.SalesProjectedPrevious.TabStop = False
        Me.SalesProjectedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualPrevious
        '
        Me.SalesActualPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesActualPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesActualPrevious.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualPrevious.Location = New System.Drawing.Point(441, 136)
        Me.SalesActualPrevious.Name = "SalesActualPrevious"
        Me.SalesActualPrevious.Size = New System.Drawing.Size(52, 28)
        Me.SalesActualPrevious.TabIndex = 92
        Me.SalesActualPrevious.TabStop = False
        Me.SalesActualPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceCurrent
        '
        Me.SalesVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVarianceCurrent.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceCurrent.Location = New System.Drawing.Point(378, 195)
        Me.SalesVarianceCurrent.Name = "SalesVarianceCurrent"
        Me.SalesVarianceCurrent.Size = New System.Drawing.Size(57, 28)
        Me.SalesVarianceCurrent.TabIndex = 91
        Me.SalesVarianceCurrent.TabStop = False
        Me.SalesVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedCurrent
        '
        Me.SalesProjectedCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesProjectedCurrent.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedCurrent.Location = New System.Drawing.Point(378, 166)
        Me.SalesProjectedCurrent.Name = "SalesProjectedCurrent"
        Me.SalesProjectedCurrent.Size = New System.Drawing.Size(57, 28)
        Me.SalesProjectedCurrent.TabIndex = 90
        Me.SalesProjectedCurrent.TabStop = False
        Me.SalesProjectedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualCurrent
        '
        Me.SalesActualCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesActualCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesActualCurrent.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualCurrent.Location = New System.Drawing.Point(378, 136)
        Me.SalesActualCurrent.Name = "SalesActualCurrent"
        Me.SalesActualCurrent.Size = New System.Drawing.Size(57, 28)
        Me.SalesActualCurrent.TabIndex = 89
        Me.SalesActualCurrent.TabStop = False
        Me.SalesActualCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(324, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(182, 127)
        Me.PictureBox4.TabIndex = 130
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(512, 103)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(191, 127)
        Me.PictureBox5.TabIndex = 131
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gray
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(316, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(387, 144)
        Me.PictureBox3.TabIndex = 129
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Location = New System.Drawing.Point(328, 272)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(178, 136)
        Me.PictureBox7.TabIndex = 133
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Location = New System.Drawing.Point(613, 259)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(243, 169)
        Me.PictureBox8.TabIndex = 134
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Gray
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(312, 259)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(391, 157)
        Me.PictureBox6.TabIndex = 132
        Me.PictureBox6.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Gray
        Me.PictureBox13.Location = New System.Drawing.Point(6, 259)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(300, 157)
        Me.PictureBox13.TabIndex = 140
        Me.PictureBox13.TabStop = False
        '
        'MiniDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(715, 428)
        Me.Controls.Add(Me.picSmallForm)
        Me.Controls.Add(Me.chrtSalesChart)
        Me.Controls.Add(Me.chrtLabourChart)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.txtFullDayTTL)
        Me.Controls.Add(Me.txtDayPartCC)
        Me.Controls.Add(Me.txtDayPartTTL)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.TextBox27)
        Me.Controls.Add(Me.TextBox26)
        Me.Controls.Add(Me.TextBox25)
        Me.Controls.Add(Me.txtTaste)
        Me.Controls.Add(Me.txtAccurate)
        Me.Controls.Add(Me.txtFast)
        Me.Controls.Add(Me.txtClean)
        Me.Controls.Add(Me.txtFriendly)
        Me.Controls.Add(Me.txtZOD)
        Me.Controls.Add(Me.txtOSAT)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.txtWeatherDescription)
        Me.Controls.Add(Me.txtClock)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.txtFullDaySalesProjection)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.txtSalesVariancePercentDaily)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ScheduledLabourLabel)
        Me.Controls.Add(Me.AllowedLabourLabel)
        Me.Controls.Add(Me.DailySalesLabel)
        Me.Controls.Add(Me.PreviousSalesLabel)
        Me.Controls.Add(Me.CurrentSalesLabel)
        Me.Controls.Add(Me.SalesVarianceLabel)
        Me.Controls.Add(Me.ProjectedSalesLabel)
        Me.Controls.Add(Me.ActualSalesLabel)
        Me.Controls.Add(Me.LabourVarianceDaily)
        Me.Controls.Add(Me.LabourSchedDaily)
        Me.Controls.Add(Me.LabourAllowedDaily)
        Me.Controls.Add(Me.LabourVariancePrevious)
        Me.Controls.Add(Me.LabourSchedPrevious)
        Me.Controls.Add(Me.LabourAllowedPrevious)
        Me.Controls.Add(Me.LabourVarianceCurrent)
        Me.Controls.Add(Me.LabourSchedCurrent)
        Me.Controls.Add(Me.LabourAllowedCurrent)
        Me.Controls.Add(Me.SalesVarianceDaily)
        Me.Controls.Add(Me.SalesProjectedDaily)
        Me.Controls.Add(Me.SalesActualDaily)
        Me.Controls.Add(Me.SalesVariancePrevious)
        Me.Controls.Add(Me.SalesProjectedPrevious)
        Me.Controls.Add(Me.SalesActualPrevious)
        Me.Controls.Add(Me.SalesVarianceCurrent)
        Me.Controls.Add(Me.SalesProjectedCurrent)
        Me.Controls.Add(Me.SalesActualCurrent)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.txtMiniClock)
        Me.Controls.Add(Me.picMiniLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-707, 379)
        Me.MaximizeBox = False
        Me.Name = "MiniDashboard"
        Me.Text = "MiniDashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiniLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmallForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtSalesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtLabourChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picMiniLogo As PictureBox
    Friend WithEvents txtMiniClock As TextBox
    Friend WithEvents picSmallForm As PictureBox
    Friend WithEvents chrtSalesChart As DataVisualization.Charting.Chart
    Friend WithEvents chrtLabourChart As DataVisualization.Charting.Chart
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents txtFullDayTTL As TextBox
    Friend WithEvents txtDayPartCC As TextBox
    Friend WithEvents txtDayPartTTL As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents txtTaste As TextBox
    Friend WithEvents txtAccurate As TextBox
    Friend WithEvents txtFast As TextBox
    Friend WithEvents txtClean As TextBox
    Friend WithEvents txtFriendly As TextBox
    Friend WithEvents txtZOD As TextBox
    Friend WithEvents txtOSAT As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents txtWeatherDescription As TextBox
    Friend WithEvents txtClock As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents txtFullDaySalesProjection As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents txtSalesVariancePercentDaily As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ScheduledLabourLabel As TextBox
    Friend WithEvents AllowedLabourLabel As TextBox
    Friend WithEvents DailySalesLabel As TextBox
    Friend WithEvents PreviousSalesLabel As TextBox
    Friend WithEvents CurrentSalesLabel As TextBox
    Friend WithEvents SalesVarianceLabel As TextBox
    Friend WithEvents ProjectedSalesLabel As TextBox
    Friend WithEvents ActualSalesLabel As TextBox
    Friend WithEvents LabourVarianceDaily As TextBox
    Friend WithEvents LabourSchedDaily As TextBox
    Friend WithEvents LabourAllowedDaily As TextBox
    Friend WithEvents LabourVariancePrevious As TextBox
    Friend WithEvents LabourSchedPrevious As TextBox
    Friend WithEvents LabourAllowedPrevious As TextBox
    Friend WithEvents LabourVarianceCurrent As TextBox
    Friend WithEvents LabourSchedCurrent As TextBox
    Friend WithEvents LabourAllowedCurrent As TextBox
    Friend WithEvents SalesVarianceDaily As TextBox
    Friend WithEvents SalesProjectedDaily As TextBox
    Friend WithEvents SalesActualDaily As TextBox
    Friend WithEvents SalesVariancePrevious As TextBox
    Friend WithEvents SalesProjectedPrevious As TextBox
    Friend WithEvents SalesActualPrevious As TextBox
    Friend WithEvents SalesVarianceCurrent As TextBox
    Friend WithEvents SalesProjectedCurrent As TextBox
    Friend WithEvents SalesActualCurrent As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
End Class
