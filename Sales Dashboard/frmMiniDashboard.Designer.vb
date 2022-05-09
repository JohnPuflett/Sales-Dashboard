<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiniDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMiniDashboard))
        Me.picMainDashboard = New System.Windows.Forms.PictureBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
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
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.txtWeatherDescription = New System.Windows.Forms.TextBox()
        Me.txtWeatherFeelsLike = New System.Windows.Forms.TextBox()
        Me.txtWeatherTemp = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.timerUpdate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMainDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtSalesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtLabourChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMainDashboard
        '
        Me.picMainDashboard.Location = New System.Drawing.Point(615, 7)
        Me.picMainDashboard.Name = "picMainDashboard"
        Me.picMainDashboard.Size = New System.Drawing.Size(68, 49)
        Me.picMainDashboard.TabIndex = 0
        Me.picMainDashboard.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Black
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Red
        Me.txtStatus.Location = New System.Drawing.Point(507, 19)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(105, 16)
        Me.txtStatus.TabIndex = 175
        Me.txtStatus.TabStop = False
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.chrtSalesChart.Location = New System.Drawing.Point(11, 211)
        Me.chrtSalesChart.Name = "chrtSalesChart"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Blue
        Series1.Name = "Series1"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Green
        Series2.Name = "Series2"
        Me.chrtSalesChart.Series.Add(Series1)
        Me.chrtSalesChart.Series.Add(Series2)
        Me.chrtSalesChart.Size = New System.Drawing.Size(296, 154)
        Me.chrtSalesChart.TabIndex = 174
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
        Me.chrtLabourChart.Location = New System.Drawing.Point(11, 89)
        Me.chrtLabourChart.Name = "chrtLabourChart"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.Green
        Series3.IsVisibleInLegend = False
        Series3.Name = "Series1"
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.Blue
        Series4.Name = "Series2"
        Me.chrtLabourChart.Series.Add(Series3)
        Me.chrtLabourChart.Series.Add(Series4)
        Me.chrtLabourChart.Size = New System.Drawing.Size(296, 96)
        Me.chrtLabourChart.TabIndex = 173
        Me.chrtLabourChart.TabStop = False
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.White
        Me.TextBox15.Location = New System.Drawing.Point(85, 194)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(128, 14)
        Me.TextBox15.TabIndex = 145
        Me.TextBox15.TabStop = False
        Me.TextBox15.Text = "Sales Tracking"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFullDayTTL
        '
        Me.txtFullDayTTL.BackColor = System.Drawing.Color.Black
        Me.txtFullDayTTL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullDayTTL.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullDayTTL.ForeColor = System.Drawing.Color.White
        Me.txtFullDayTTL.Location = New System.Drawing.Point(527, 341)
        Me.txtFullDayTTL.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFullDayTTL.Name = "txtFullDayTTL"
        Me.txtFullDayTTL.Size = New System.Drawing.Size(30, 17)
        Me.txtFullDayTTL.TabIndex = 172
        Me.txtFullDayTTL.TabStop = False
        Me.txtFullDayTTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDayPartCC
        '
        Me.txtDayPartCC.BackColor = System.Drawing.Color.Black
        Me.txtDayPartCC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDayPartCC.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayPartCC.ForeColor = System.Drawing.Color.Yellow
        Me.txtDayPartCC.Location = New System.Drawing.Point(561, 323)
        Me.txtDayPartCC.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDayPartCC.Name = "txtDayPartCC"
        Me.txtDayPartCC.Size = New System.Drawing.Size(30, 17)
        Me.txtDayPartCC.TabIndex = 171
        Me.txtDayPartCC.TabStop = False
        Me.txtDayPartCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDayPartTTL
        '
        Me.txtDayPartTTL.BackColor = System.Drawing.Color.Black
        Me.txtDayPartTTL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDayPartTTL.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayPartTTL.ForeColor = System.Drawing.Color.White
        Me.txtDayPartTTL.Location = New System.Drawing.Point(527, 323)
        Me.txtDayPartTTL.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDayPartTTL.Name = "txtDayPartTTL"
        Me.txtDayPartTTL.Size = New System.Drawing.Size(30, 17)
        Me.txtDayPartTTL.TabIndex = 170
        Me.txtDayPartTTL.TabStop = False
        Me.txtDayPartTTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.Color.Black
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox28.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.ForeColor = System.Drawing.Color.White
        Me.TextBox28.Location = New System.Drawing.Point(561, 306)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(30, 11)
        Me.TextBox28.TabIndex = 169
        Me.TextBox28.TabStop = False
        Me.TextBox28.Text = "CC"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.Color.Black
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox27.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.ForeColor = System.Drawing.Color.White
        Me.TextBox27.Location = New System.Drawing.Point(527, 306)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(30, 11)
        Me.TextBox27.TabIndex = 168
        Me.TextBox27.TabStop = False
        Me.TextBox27.Text = "TTL"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.Color.Black
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox26.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.ForeColor = System.Drawing.Color.White
        Me.TextBox26.Location = New System.Drawing.Point(475, 344)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(43, 10)
        Me.TextBox26.TabIndex = 167
        Me.TextBox26.TabStop = False
        Me.TextBox26.Text = "Full Day"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.Color.Black
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox25.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.ForeColor = System.Drawing.Color.White
        Me.TextBox25.Location = New System.Drawing.Point(475, 326)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(43, 10)
        Me.TextBox25.TabIndex = 166
        Me.TextBox25.TabStop = False
        Me.TextBox25.Text = "Day Part"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaste
        '
        Me.txtTaste.BackColor = System.Drawing.Color.Black
        Me.txtTaste.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTaste.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaste.ForeColor = System.Drawing.Color.Yellow
        Me.txtTaste.Location = New System.Drawing.Point(617, 345)
        Me.txtTaste.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTaste.Name = "txtTaste"
        Me.txtTaste.Size = New System.Drawing.Size(43, 21)
        Me.txtTaste.TabIndex = 165
        Me.txtTaste.TabStop = False
        Me.txtTaste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAccurate
        '
        Me.txtAccurate.BackColor = System.Drawing.Color.Black
        Me.txtAccurate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccurate.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccurate.ForeColor = System.Drawing.Color.Yellow
        Me.txtAccurate.Location = New System.Drawing.Point(617, 306)
        Me.txtAccurate.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAccurate.Name = "txtAccurate"
        Me.txtAccurate.Size = New System.Drawing.Size(43, 21)
        Me.txtAccurate.TabIndex = 164
        Me.txtAccurate.TabStop = False
        Me.txtAccurate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFast
        '
        Me.txtFast.BackColor = System.Drawing.Color.Black
        Me.txtFast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFast.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFast.ForeColor = System.Drawing.Color.Yellow
        Me.txtFast.Location = New System.Drawing.Point(617, 267)
        Me.txtFast.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFast.Name = "txtFast"
        Me.txtFast.Size = New System.Drawing.Size(43, 21)
        Me.txtFast.TabIndex = 163
        Me.txtFast.TabStop = False
        Me.txtFast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClean
        '
        Me.txtClean.BackColor = System.Drawing.Color.Black
        Me.txtClean.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClean.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClean.ForeColor = System.Drawing.Color.Yellow
        Me.txtClean.Location = New System.Drawing.Point(617, 228)
        Me.txtClean.Margin = New System.Windows.Forms.Padding(0)
        Me.txtClean.Name = "txtClean"
        Me.txtClean.Size = New System.Drawing.Size(43, 21)
        Me.txtClean.TabIndex = 162
        Me.txtClean.TabStop = False
        Me.txtClean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFriendly
        '
        Me.txtFriendly.BackColor = System.Drawing.Color.Black
        Me.txtFriendly.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFriendly.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriendly.ForeColor = System.Drawing.Color.Yellow
        Me.txtFriendly.Location = New System.Drawing.Point(617, 189)
        Me.txtFriendly.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFriendly.Name = "txtFriendly"
        Me.txtFriendly.Size = New System.Drawing.Size(43, 21)
        Me.txtFriendly.TabIndex = 161
        Me.txtFriendly.TabStop = False
        Me.txtFriendly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtZOD
        '
        Me.txtZOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtZOD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtZOD.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZOD.ForeColor = System.Drawing.Color.White
        Me.txtZOD.Location = New System.Drawing.Point(617, 146)
        Me.txtZOD.Margin = New System.Windows.Forms.Padding(0)
        Me.txtZOD.Name = "txtZOD"
        Me.txtZOD.Size = New System.Drawing.Size(43, 21)
        Me.txtZOD.TabIndex = 160
        Me.txtZOD.TabStop = False
        Me.txtZOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOSAT
        '
        Me.txtOSAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOSAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOSAT.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOSAT.ForeColor = System.Drawing.Color.White
        Me.txtOSAT.Location = New System.Drawing.Point(617, 104)
        Me.txtOSAT.Margin = New System.Windows.Forms.Padding(0)
        Me.txtOSAT.Name = "txtOSAT"
        Me.txtOSAT.Size = New System.Drawing.Size(43, 21)
        Me.txtOSAT.TabIndex = 159
        Me.txtOSAT.TabStop = False
        Me.txtOSAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.Color.Black
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.ForeColor = System.Drawing.Color.White
        Me.TextBox24.Location = New System.Drawing.Point(617, 333)
        Me.TextBox24.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(43, 10)
        Me.TextBox24.TabIndex = 158
        Me.TextBox24.TabStop = False
        Me.TextBox24.Text = "Taste"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.Black
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.Color.White
        Me.TextBox23.Location = New System.Drawing.Point(617, 294)
        Me.TextBox23.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(43, 10)
        Me.TextBox23.TabIndex = 157
        Me.TextBox23.TabStop = False
        Me.TextBox23.Text = "Accurate"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.Black
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.Color.White
        Me.TextBox22.Location = New System.Drawing.Point(617, 255)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(43, 10)
        Me.TextBox22.TabIndex = 156
        Me.TextBox22.TabStop = False
        Me.TextBox22.Text = "Fast"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.Black
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.Color.White
        Me.TextBox21.Location = New System.Drawing.Point(617, 216)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(43, 10)
        Me.TextBox21.TabIndex = 155
        Me.TextBox21.TabStop = False
        Me.TextBox21.Text = "Clean"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Black
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.ForeColor = System.Drawing.Color.White
        Me.TextBox20.Location = New System.Drawing.Point(617, 177)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(43, 10)
        Me.TextBox20.TabIndex = 154
        Me.TextBox20.TabStop = False
        Me.TextBox20.Text = "Friendly"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.White
        Me.TextBox19.Location = New System.Drawing.Point(617, 129)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(43, 14)
        Me.TextBox19.TabIndex = 153
        Me.TextBox19.TabStop = False
        Me.TextBox19.Text = "ZOD"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.ForeColor = System.Drawing.Color.White
        Me.TextBox18.Location = New System.Drawing.Point(617, 88)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(43, 14)
        Me.TextBox18.TabIndex = 152
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = "OSAT"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.Black
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox17.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.ForeColor = System.Drawing.Color.White
        Me.TextBox17.Location = New System.Drawing.Point(118, 16)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(28, 10)
        Me.TextBox17.TabIndex = 151
        Me.TextBox17.TabStop = False
        Me.TextBox17.Text = "Feels"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Black
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox16.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.ForeColor = System.Drawing.Color.White
        Me.TextBox16.Location = New System.Drawing.Point(72, 16)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(26, 10)
        Me.TextBox16.TabIndex = 150
        Me.TextBox16.TabStop = False
        Me.TextBox16.Text = "Temp"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeatherDescription
        '
        Me.txtWeatherDescription.BackColor = System.Drawing.Color.Black
        Me.txtWeatherDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeatherDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeatherDescription.ForeColor = System.Drawing.Color.White
        Me.txtWeatherDescription.Location = New System.Drawing.Point(63, 31)
        Me.txtWeatherDescription.Name = "txtWeatherDescription"
        Me.txtWeatherDescription.Size = New System.Drawing.Size(106, 13)
        Me.txtWeatherDescription.TabIndex = 149
        Me.txtWeatherDescription.TabStop = False
        Me.txtWeatherDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeatherFeelsLike
        '
        Me.txtWeatherFeelsLike.BackColor = System.Drawing.Color.Black
        Me.txtWeatherFeelsLike.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeatherFeelsLike.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeatherFeelsLike.ForeColor = System.Drawing.Color.White
        Me.txtWeatherFeelsLike.Location = New System.Drawing.Point(146, 14)
        Me.txtWeatherFeelsLike.Name = "txtWeatherFeelsLike"
        Me.txtWeatherFeelsLike.Size = New System.Drawing.Size(20, 13)
        Me.txtWeatherFeelsLike.TabIndex = 148
        Me.txtWeatherFeelsLike.TabStop = False
        Me.txtWeatherFeelsLike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeatherTemp
        '
        Me.txtWeatherTemp.BackColor = System.Drawing.Color.Black
        Me.txtWeatherTemp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeatherTemp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeatherTemp.ForeColor = System.Drawing.Color.White
        Me.txtWeatherTemp.Location = New System.Drawing.Point(98, 14)
        Me.txtWeatherTemp.Name = "txtWeatherTemp"
        Me.txtWeatherTemp.Size = New System.Drawing.Size(20, 13)
        Me.txtWeatherTemp.TabIndex = 147
        Me.txtWeatherTemp.TabStop = False
        Me.txtWeatherTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClock
        '
        Me.txtClock.BackColor = System.Drawing.Color.Black
        Me.txtClock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClock.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClock.ForeColor = System.Drawing.Color.White
        Me.txtClock.Location = New System.Drawing.Point(178, 16)
        Me.txtClock.Name = "txtClock"
        Me.txtClock.Size = New System.Drawing.Size(323, 23)
        Me.txtClock.TabIndex = 146
        Me.txtClock.TabStop = False
        Me.txtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.White
        Me.TextBox14.Location = New System.Drawing.Point(85, 72)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(128, 14)
        Me.TextBox14.TabIndex = 144
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = "Labour Tracking"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Gray
        Me.PictureBox12.Location = New System.Drawing.Point(5, 83)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(308, 108)
        Me.PictureBox12.TabIndex = 142
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox11.Location = New System.Drawing.Point(607, 87)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(63, 87)
        Me.PictureBox11.TabIndex = 141
        Me.PictureBox11.TabStop = False
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.White
        Me.TextBox13.Location = New System.Drawing.Point(618, 62)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(43, 14)
        Me.TextBox13.TabIndex = 140
        Me.TextBox13.TabStop = False
        Me.TextBox13.Text = "VOC"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(601, 70)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(75, 312)
        Me.PictureBox10.TabIndex = 139
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(470, 298)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(122, 67)
        Me.PictureBox9.TabIndex = 138
        Me.PictureBox9.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Black
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.White
        Me.TextBox12.Location = New System.Drawing.Point(335, 338)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(43, 10)
        Me.TextBox12.TabIndex = 130
        Me.TextBox12.TabStop = False
        Me.TextBox12.Text = "Day Proj $"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFullDaySalesProjection
        '
        Me.txtFullDaySalesProjection.BackColor = System.Drawing.Color.Black
        Me.txtFullDaySalesProjection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullDaySalesProjection.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullDaySalesProjection.ForeColor = System.Drawing.Color.Yellow
        Me.txtFullDaySalesProjection.Location = New System.Drawing.Point(379, 330)
        Me.txtFullDaySalesProjection.Margin = New System.Windows.Forms.Padding(0)
        Me.txtFullDaySalesProjection.Name = "txtFullDaySalesProjection"
        Me.txtFullDaySalesProjection.Size = New System.Drawing.Size(80, 23)
        Me.txtFullDaySalesProjection.TabIndex = 129
        Me.txtFullDaySalesProjection.TabStop = False
        Me.txtFullDaySalesProjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Black
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(330, 300)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(43, 10)
        Me.TextBox11.TabIndex = 128
        Me.TextBox11.TabStop = False
        Me.TextBox11.Text = "+/- %"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalesVariancePercentDaily
        '
        Me.txtSalesVariancePercentDaily.BackColor = System.Drawing.Color.Black
        Me.txtSalesVariancePercentDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSalesVariancePercentDaily.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesVariancePercentDaily.ForeColor = System.Drawing.Color.Yellow
        Me.txtSalesVariancePercentDaily.Location = New System.Drawing.Point(378, 293)
        Me.txtSalesVariancePercentDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSalesVariancePercentDaily.Name = "txtSalesVariancePercentDaily"
        Me.txtSalesVariancePercentDaily.Size = New System.Drawing.Size(84, 21)
        Me.txtSalesVariancePercentDaily.TabIndex = 127
        Me.txtSalesVariancePercentDaily.TabStop = False
        Me.txtSalesVariancePercentDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(472, 275)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 10)
        Me.TextBox2.TabIndex = 126
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "+/- Hrs"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(472, 251)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(50, 10)
        Me.TextBox9.TabIndex = 125
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "Sched Hrs"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Black
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(472, 228)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(50, 10)
        Me.TextBox10.TabIndex = 124
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "Allowed Hrs"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(405, 72)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(129, 14)
        Me.TextBox8.TabIndex = 123
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "1/2 Hour Tracking"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(332, 276)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(43, 10)
        Me.TextBox5.TabIndex = 122
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "+/- $"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(332, 253)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(43, 10)
        Me.TextBox6.TabIndex = 121
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "Projected $"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(332, 229)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(43, 10)
        Me.TextBox7.TabIndex = 120
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "Actual $"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(561, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(30, 14)
        Me.TextBox3.TabIndex = 119
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "Prev"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(527, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(30, 14)
        Me.TextBox4.TabIndex = 118
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Curr"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(475, 162)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 10)
        Me.TextBox1.TabIndex = 117
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "+/- Hrs"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScheduledLabourLabel
        '
        Me.ScheduledLabourLabel.BackColor = System.Drawing.Color.Black
        Me.ScheduledLabourLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ScheduledLabourLabel.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduledLabourLabel.ForeColor = System.Drawing.Color.White
        Me.ScheduledLabourLabel.Location = New System.Drawing.Point(473, 139)
        Me.ScheduledLabourLabel.Name = "ScheduledLabourLabel"
        Me.ScheduledLabourLabel.Size = New System.Drawing.Size(50, 10)
        Me.ScheduledLabourLabel.TabIndex = 116
        Me.ScheduledLabourLabel.TabStop = False
        Me.ScheduledLabourLabel.Text = "Sched Hrs"
        Me.ScheduledLabourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AllowedLabourLabel
        '
        Me.AllowedLabourLabel.BackColor = System.Drawing.Color.Black
        Me.AllowedLabourLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AllowedLabourLabel.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllowedLabourLabel.ForeColor = System.Drawing.Color.White
        Me.AllowedLabourLabel.Location = New System.Drawing.Point(475, 115)
        Me.AllowedLabourLabel.Name = "AllowedLabourLabel"
        Me.AllowedLabourLabel.Size = New System.Drawing.Size(50, 10)
        Me.AllowedLabourLabel.TabIndex = 115
        Me.AllowedLabourLabel.TabStop = False
        Me.AllowedLabourLabel.Text = "Allowed Hrs"
        Me.AllowedLabourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DailySalesLabel
        '
        Me.DailySalesLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DailySalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DailySalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySalesLabel.ForeColor = System.Drawing.Color.White
        Me.DailySalesLabel.Location = New System.Drawing.Point(405, 194)
        Me.DailySalesLabel.Name = "DailySalesLabel"
        Me.DailySalesLabel.Size = New System.Drawing.Size(129, 14)
        Me.DailySalesLabel.TabIndex = 114
        Me.DailySalesLabel.TabStop = False
        Me.DailySalesLabel.Text = "Daily Tracking"
        Me.DailySalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PreviousSalesLabel
        '
        Me.PreviousSalesLabel.BackColor = System.Drawing.Color.Black
        Me.PreviousSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PreviousSalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousSalesLabel.ForeColor = System.Drawing.Color.White
        Me.PreviousSalesLabel.Location = New System.Drawing.Point(418, 92)
        Me.PreviousSalesLabel.Name = "PreviousSalesLabel"
        Me.PreviousSalesLabel.Size = New System.Drawing.Size(40, 14)
        Me.PreviousSalesLabel.TabIndex = 113
        Me.PreviousSalesLabel.TabStop = False
        Me.PreviousSalesLabel.Text = "Prev"
        Me.PreviousSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CurrentSalesLabel
        '
        Me.CurrentSalesLabel.BackColor = System.Drawing.Color.Black
        Me.CurrentSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentSalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentSalesLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentSalesLabel.Location = New System.Drawing.Point(372, 92)
        Me.CurrentSalesLabel.Name = "CurrentSalesLabel"
        Me.CurrentSalesLabel.Size = New System.Drawing.Size(40, 14)
        Me.CurrentSalesLabel.TabIndex = 112
        Me.CurrentSalesLabel.TabStop = False
        Me.CurrentSalesLabel.Text = "Curr"
        Me.CurrentSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceLabel
        '
        Me.SalesVarianceLabel.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesVarianceLabel.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceLabel.ForeColor = System.Drawing.Color.White
        Me.SalesVarianceLabel.Location = New System.Drawing.Point(326, 162)
        Me.SalesVarianceLabel.Name = "SalesVarianceLabel"
        Me.SalesVarianceLabel.Size = New System.Drawing.Size(40, 10)
        Me.SalesVarianceLabel.TabIndex = 111
        Me.SalesVarianceLabel.TabStop = False
        Me.SalesVarianceLabel.Text = "+/- $"
        Me.SalesVarianceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProjectedSalesLabel
        '
        Me.ProjectedSalesLabel.BackColor = System.Drawing.Color.Black
        Me.ProjectedSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProjectedSalesLabel.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectedSalesLabel.ForeColor = System.Drawing.Color.White
        Me.ProjectedSalesLabel.Location = New System.Drawing.Point(326, 139)
        Me.ProjectedSalesLabel.Name = "ProjectedSalesLabel"
        Me.ProjectedSalesLabel.Size = New System.Drawing.Size(40, 10)
        Me.ProjectedSalesLabel.TabIndex = 110
        Me.ProjectedSalesLabel.TabStop = False
        Me.ProjectedSalesLabel.Text = "Projected $"
        Me.ProjectedSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ActualSalesLabel
        '
        Me.ActualSalesLabel.BackColor = System.Drawing.Color.Black
        Me.ActualSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActualSalesLabel.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualSalesLabel.ForeColor = System.Drawing.Color.White
        Me.ActualSalesLabel.Location = New System.Drawing.Point(326, 115)
        Me.ActualSalesLabel.Name = "ActualSalesLabel"
        Me.ActualSalesLabel.Size = New System.Drawing.Size(40, 10)
        Me.ActualSalesLabel.TabIndex = 109
        Me.ActualSalesLabel.TabStop = False
        Me.ActualSalesLabel.Text = "Actual $"
        Me.ActualSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabourVarianceDaily
        '
        Me.LabourVarianceDaily.BackColor = System.Drawing.Color.Black
        Me.LabourVarianceDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourVarianceDaily.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVarianceDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVarianceDaily.Location = New System.Drawing.Point(534, 268)
        Me.LabourVarianceDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourVarianceDaily.Name = "LabourVarianceDaily"
        Me.LabourVarianceDaily.Size = New System.Drawing.Size(50, 23)
        Me.LabourVarianceDaily.TabIndex = 108
        Me.LabourVarianceDaily.TabStop = False
        Me.LabourVarianceDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedDaily
        '
        Me.LabourSchedDaily.BackColor = System.Drawing.Color.Black
        Me.LabourSchedDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourSchedDaily.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedDaily.Location = New System.Drawing.Point(534, 245)
        Me.LabourSchedDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourSchedDaily.Name = "LabourSchedDaily"
        Me.LabourSchedDaily.Size = New System.Drawing.Size(50, 23)
        Me.LabourSchedDaily.TabIndex = 107
        Me.LabourSchedDaily.TabStop = False
        Me.LabourSchedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedDaily
        '
        Me.LabourAllowedDaily.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourAllowedDaily.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedDaily.Location = New System.Drawing.Point(534, 221)
        Me.LabourAllowedDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourAllowedDaily.Name = "LabourAllowedDaily"
        Me.LabourAllowedDaily.Size = New System.Drawing.Size(50, 23)
        Me.LabourAllowedDaily.TabIndex = 106
        Me.LabourAllowedDaily.TabStop = False
        Me.LabourAllowedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourVariancePrevious
        '
        Me.LabourVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.LabourVariancePrevious.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourVariancePrevious.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVariancePrevious.Location = New System.Drawing.Point(560, 153)
        Me.LabourVariancePrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourVariancePrevious.Name = "LabourVariancePrevious"
        Me.LabourVariancePrevious.Size = New System.Drawing.Size(30, 23)
        Me.LabourVariancePrevious.TabIndex = 105
        Me.LabourVariancePrevious.TabStop = False
        Me.LabourVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedPrevious
        '
        Me.LabourSchedPrevious.BackColor = System.Drawing.Color.Black
        Me.LabourSchedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourSchedPrevious.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedPrevious.Location = New System.Drawing.Point(562, 130)
        Me.LabourSchedPrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourSchedPrevious.Name = "LabourSchedPrevious"
        Me.LabourSchedPrevious.Size = New System.Drawing.Size(30, 23)
        Me.LabourSchedPrevious.TabIndex = 104
        Me.LabourSchedPrevious.TabStop = False
        Me.LabourSchedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedPrevious
        '
        Me.LabourAllowedPrevious.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourAllowedPrevious.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedPrevious.Location = New System.Drawing.Point(562, 107)
        Me.LabourAllowedPrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourAllowedPrevious.Name = "LabourAllowedPrevious"
        Me.LabourAllowedPrevious.Size = New System.Drawing.Size(30, 23)
        Me.LabourAllowedPrevious.TabIndex = 103
        Me.LabourAllowedPrevious.TabStop = False
        Me.LabourAllowedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourVarianceCurrent
        '
        Me.LabourVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourVarianceCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourVarianceCurrent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVarianceCurrent.Location = New System.Drawing.Point(527, 153)
        Me.LabourVarianceCurrent.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourVarianceCurrent.Name = "LabourVarianceCurrent"
        Me.LabourVarianceCurrent.Size = New System.Drawing.Size(30, 23)
        Me.LabourVarianceCurrent.TabIndex = 102
        Me.LabourVarianceCurrent.TabStop = False
        Me.LabourVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedCurrent
        '
        Me.LabourSchedCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourSchedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourSchedCurrent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedCurrent.Location = New System.Drawing.Point(529, 130)
        Me.LabourSchedCurrent.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourSchedCurrent.Name = "LabourSchedCurrent"
        Me.LabourSchedCurrent.Size = New System.Drawing.Size(30, 23)
        Me.LabourSchedCurrent.TabIndex = 101
        Me.LabourSchedCurrent.TabStop = False
        Me.LabourSchedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedCurrent
        '
        Me.LabourAllowedCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LabourAllowedCurrent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedCurrent.Location = New System.Drawing.Point(529, 107)
        Me.LabourAllowedCurrent.Margin = New System.Windows.Forms.Padding(0)
        Me.LabourAllowedCurrent.Name = "LabourAllowedCurrent"
        Me.LabourAllowedCurrent.Size = New System.Drawing.Size(30, 23)
        Me.LabourAllowedCurrent.TabIndex = 100
        Me.LabourAllowedCurrent.TabStop = False
        Me.LabourAllowedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SalesVarianceDaily
        '
        Me.SalesVarianceDaily.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesVarianceDaily.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceDaily.Location = New System.Drawing.Point(384, 268)
        Me.SalesVarianceDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesVarianceDaily.Name = "SalesVarianceDaily"
        Me.SalesVarianceDaily.Size = New System.Drawing.Size(78, 23)
        Me.SalesVarianceDaily.TabIndex = 99
        Me.SalesVarianceDaily.TabStop = False
        Me.SalesVarianceDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedDaily
        '
        Me.SalesProjectedDaily.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesProjectedDaily.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedDaily.Location = New System.Drawing.Point(384, 243)
        Me.SalesProjectedDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesProjectedDaily.Name = "SalesProjectedDaily"
        Me.SalesProjectedDaily.Size = New System.Drawing.Size(78, 23)
        Me.SalesProjectedDaily.TabIndex = 98
        Me.SalesProjectedDaily.TabStop = False
        Me.SalesProjectedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualDaily
        '
        Me.SalesActualDaily.BackColor = System.Drawing.Color.Black
        Me.SalesActualDaily.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesActualDaily.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualDaily.Location = New System.Drawing.Point(384, 219)
        Me.SalesActualDaily.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesActualDaily.Name = "SalesActualDaily"
        Me.SalesActualDaily.Size = New System.Drawing.Size(78, 23)
        Me.SalesActualDaily.TabIndex = 97
        Me.SalesActualDaily.TabStop = False
        Me.SalesActualDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVariancePrevious
        '
        Me.SalesVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.SalesVariancePrevious.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesVariancePrevious.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVariancePrevious.Location = New System.Drawing.Point(418, 155)
        Me.SalesVariancePrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesVariancePrevious.Name = "SalesVariancePrevious"
        Me.SalesVariancePrevious.Size = New System.Drawing.Size(46, 23)
        Me.SalesVariancePrevious.TabIndex = 96
        Me.SalesVariancePrevious.TabStop = False
        Me.SalesVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedPrevious
        '
        Me.SalesProjectedPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesProjectedPrevious.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedPrevious.Location = New System.Drawing.Point(418, 132)
        Me.SalesProjectedPrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesProjectedPrevious.Name = "SalesProjectedPrevious"
        Me.SalesProjectedPrevious.Size = New System.Drawing.Size(46, 23)
        Me.SalesProjectedPrevious.TabIndex = 95
        Me.SalesProjectedPrevious.TabStop = False
        Me.SalesProjectedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualPrevious
        '
        Me.SalesActualPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesActualPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesActualPrevious.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualPrevious.Location = New System.Drawing.Point(418, 107)
        Me.SalesActualPrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesActualPrevious.Name = "SalesActualPrevious"
        Me.SalesActualPrevious.Size = New System.Drawing.Size(46, 23)
        Me.SalesActualPrevious.TabIndex = 94
        Me.SalesActualPrevious.TabStop = False
        Me.SalesActualPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceCurrent
        '
        Me.SalesVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesVarianceCurrent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceCurrent.Location = New System.Drawing.Point(370, 155)
        Me.SalesVarianceCurrent.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesVarianceCurrent.Name = "SalesVarianceCurrent"
        Me.SalesVarianceCurrent.Size = New System.Drawing.Size(46, 23)
        Me.SalesVarianceCurrent.TabIndex = 93
        Me.SalesVarianceCurrent.TabStop = False
        Me.SalesVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedCurrent
        '
        Me.SalesProjectedCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesProjectedCurrent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedCurrent.Location = New System.Drawing.Point(370, 132)
        Me.SalesProjectedCurrent.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesProjectedCurrent.Name = "SalesProjectedCurrent"
        Me.SalesProjectedCurrent.Size = New System.Drawing.Size(46, 23)
        Me.SalesProjectedCurrent.TabIndex = 92
        Me.SalesProjectedCurrent.TabStop = False
        Me.SalesProjectedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualCurrent
        '
        Me.SalesActualCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesActualCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalesActualCurrent.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualCurrent.Location = New System.Drawing.Point(370, 107)
        Me.SalesActualCurrent.Margin = New System.Windows.Forms.Padding(0)
        Me.SalesActualCurrent.Name = "SalesActualCurrent"
        Me.SalesActualCurrent.Size = New System.Drawing.Size(46, 23)
        Me.SalesActualCurrent.TabIndex = 91
        Me.SalesActualCurrent.TabStop = False
        Me.SalesActualCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(325, 89)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(142, 96)
        Me.PictureBox4.TabIndex = 133
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(470, 89)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(122, 96)
        Me.PictureBox5.TabIndex = 134
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gray
        Me.PictureBox3.Location = New System.Drawing.Point(319, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(276, 108)
        Me.PictureBox3.TabIndex = 132
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(325, 211)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(142, 154)
        Me.PictureBox7.TabIndex = 136
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(470, 211)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(122, 85)
        Me.PictureBox8.TabIndex = 137
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Gray
        Me.PictureBox6.Location = New System.Drawing.Point(319, 205)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(276, 166)
        Me.PictureBox6.TabIndex = 135
        Me.PictureBox6.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Gray
        Me.PictureBox13.Location = New System.Drawing.Point(5, 205)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(308, 167)
        Me.PictureBox13.TabIndex = 143
        Me.PictureBox13.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(683, 328)
        Me.PictureBox2.TabIndex = 131
        Me.PictureBox2.TabStop = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.Filter = "LiveSales.txt"
        Me.FileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FileSystemWatcher1.Path = "C:\Wendys"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Clock
        '
        Me.Clock.Enabled = True
        Me.Clock.Interval = 500
        '
        'timerUpdate
        '
        Me.timerUpdate.Enabled = True
        Me.timerUpdate.Interval = 60000
        '
        'frmMiniDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(683, 384)
        Me.Controls.Add(Me.txtStatus)
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
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.txtWeatherDescription)
        Me.Controls.Add(Me.txtWeatherFeelsLike)
        Me.Controls.Add(Me.txtWeatherTemp)
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
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picMainDashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-683, 413)
        Me.Name = "frmMiniDashboard"
        Me.Text = "miniDashBoard"
        CType(Me.picMainDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtSalesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtLabourChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMainDashboard As PictureBox
    Friend WithEvents txtStatus As TextBox
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
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents txtWeatherDescription As TextBox
    Friend WithEvents txtWeatherFeelsLike As TextBox
    Friend WithEvents txtWeatherTemp As TextBox
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
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Clock As Timer
    Friend WithEvents timerUpdate As Timer
End Class
