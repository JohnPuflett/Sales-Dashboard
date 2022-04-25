<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SalesActualCurrent = New System.Windows.Forms.TextBox()
        Me.SalesProjectedCurrent = New System.Windows.Forms.TextBox()
        Me.SalesVarianceCurrent = New System.Windows.Forms.TextBox()
        Me.SalesVariancePrevious = New System.Windows.Forms.TextBox()
        Me.SalesProjectedPrevious = New System.Windows.Forms.TextBox()
        Me.SalesActualPrevious = New System.Windows.Forms.TextBox()
        Me.SalesVarianceDaily = New System.Windows.Forms.TextBox()
        Me.SalesProjectedDaily = New System.Windows.Forms.TextBox()
        Me.SalesActualDaily = New System.Windows.Forms.TextBox()
        Me.LabourVarianceDaily = New System.Windows.Forms.TextBox()
        Me.LabourSchedDaily = New System.Windows.Forms.TextBox()
        Me.LabourAllowedDaily = New System.Windows.Forms.TextBox()
        Me.LabourVariancePrevious = New System.Windows.Forms.TextBox()
        Me.LabourSchedPrevious = New System.Windows.Forms.TextBox()
        Me.LabourAllowedPrevious = New System.Windows.Forms.TextBox()
        Me.LabourVarianceCurrent = New System.Windows.Forms.TextBox()
        Me.LabourSchedCurrent = New System.Windows.Forms.TextBox()
        Me.LabourAllowedCurrent = New System.Windows.Forms.TextBox()
        Me.ActualSalesLabel = New System.Windows.Forms.TextBox()
        Me.ProjectedSalesLabel = New System.Windows.Forms.TextBox()
        Me.SalesVarianceLabel = New System.Windows.Forms.TextBox()
        Me.CurrentSalesLabel = New System.Windows.Forms.TextBox()
        Me.PreviousSalesLabel = New System.Windows.Forms.TextBox()
        Me.DailySalesLabel = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ScheduledLabourLabel = New System.Windows.Forms.TextBox()
        Me.AllowedLabourLabel = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.SalesVariancePercentDaily = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.FullDayProjection = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FileSystemWatcher1.Path = "C:\Wendys"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'SalesActualCurrent
        '
        Me.SalesActualCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesActualCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesActualCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualCurrent.Location = New System.Drawing.Point(679, 277)
        Me.SalesActualCurrent.Name = "SalesActualCurrent"
        Me.SalesActualCurrent.Size = New System.Drawing.Size(80, 41)
        Me.SalesActualCurrent.TabIndex = 2
        Me.SalesActualCurrent.TabStop = False
        Me.SalesActualCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedCurrent
        '
        Me.SalesProjectedCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesProjectedCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedCurrent.Location = New System.Drawing.Point(679, 324)
        Me.SalesProjectedCurrent.Name = "SalesProjectedCurrent"
        Me.SalesProjectedCurrent.Size = New System.Drawing.Size(80, 41)
        Me.SalesProjectedCurrent.TabIndex = 3
        Me.SalesProjectedCurrent.TabStop = False
        Me.SalesProjectedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceCurrent
        '
        Me.SalesVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVarianceCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceCurrent.Location = New System.Drawing.Point(679, 371)
        Me.SalesVarianceCurrent.Name = "SalesVarianceCurrent"
        Me.SalesVarianceCurrent.Size = New System.Drawing.Size(80, 41)
        Me.SalesVarianceCurrent.TabIndex = 4
        Me.SalesVarianceCurrent.TabStop = False
        Me.SalesVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVariancePrevious
        '
        Me.SalesVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.SalesVariancePrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVariancePrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVariancePrevious.Location = New System.Drawing.Point(765, 371)
        Me.SalesVariancePrevious.Name = "SalesVariancePrevious"
        Me.SalesVariancePrevious.Size = New System.Drawing.Size(80, 41)
        Me.SalesVariancePrevious.TabIndex = 7
        Me.SalesVariancePrevious.TabStop = False
        Me.SalesVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedPrevious
        '
        Me.SalesProjectedPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesProjectedPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedPrevious.Location = New System.Drawing.Point(765, 324)
        Me.SalesProjectedPrevious.Name = "SalesProjectedPrevious"
        Me.SalesProjectedPrevious.Size = New System.Drawing.Size(80, 41)
        Me.SalesProjectedPrevious.TabIndex = 6
        Me.SalesProjectedPrevious.TabStop = False
        Me.SalesProjectedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualPrevious
        '
        Me.SalesActualPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesActualPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesActualPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualPrevious.Location = New System.Drawing.Point(765, 277)
        Me.SalesActualPrevious.Name = "SalesActualPrevious"
        Me.SalesActualPrevious.Size = New System.Drawing.Size(80, 41)
        Me.SalesActualPrevious.TabIndex = 5
        Me.SalesActualPrevious.TabStop = False
        Me.SalesActualPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceDaily
        '
        Me.SalesVarianceDaily.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVarianceDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceDaily.Location = New System.Drawing.Point(745, 602)
        Me.SalesVarianceDaily.Name = "SalesVarianceDaily"
        Me.SalesVarianceDaily.Size = New System.Drawing.Size(100, 41)
        Me.SalesVarianceDaily.TabIndex = 10
        Me.SalesVarianceDaily.TabStop = False
        Me.SalesVarianceDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedDaily
        '
        Me.SalesProjectedDaily.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesProjectedDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedDaily.Location = New System.Drawing.Point(745, 555)
        Me.SalesProjectedDaily.Name = "SalesProjectedDaily"
        Me.SalesProjectedDaily.Size = New System.Drawing.Size(100, 41)
        Me.SalesProjectedDaily.TabIndex = 9
        Me.SalesProjectedDaily.TabStop = False
        Me.SalesProjectedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualDaily
        '
        Me.SalesActualDaily.BackColor = System.Drawing.Color.Black
        Me.SalesActualDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesActualDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualDaily.Location = New System.Drawing.Point(745, 508)
        Me.SalesActualDaily.Name = "SalesActualDaily"
        Me.SalesActualDaily.Size = New System.Drawing.Size(100, 41)
        Me.SalesActualDaily.TabIndex = 8
        Me.SalesActualDaily.TabStop = False
        Me.SalesActualDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabourVarianceDaily
        '
        Me.LabourVarianceDaily.BackColor = System.Drawing.Color.Black
        Me.LabourVarianceDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourVarianceDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVarianceDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVarianceDaily.Location = New System.Drawing.Point(1021, 599)
        Me.LabourVarianceDaily.Name = "LabourVarianceDaily"
        Me.LabourVarianceDaily.Size = New System.Drawing.Size(100, 41)
        Me.LabourVarianceDaily.TabIndex = 19
        Me.LabourVarianceDaily.TabStop = False
        Me.LabourVarianceDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedDaily
        '
        Me.LabourSchedDaily.BackColor = System.Drawing.Color.Black
        Me.LabourSchedDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourSchedDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedDaily.Location = New System.Drawing.Point(1021, 552)
        Me.LabourSchedDaily.Name = "LabourSchedDaily"
        Me.LabourSchedDaily.Size = New System.Drawing.Size(100, 41)
        Me.LabourSchedDaily.TabIndex = 18
        Me.LabourSchedDaily.TabStop = False
        Me.LabourSchedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedDaily
        '
        Me.LabourAllowedDaily.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourAllowedDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedDaily.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedDaily.Location = New System.Drawing.Point(1021, 505)
        Me.LabourAllowedDaily.Name = "LabourAllowedDaily"
        Me.LabourAllowedDaily.Size = New System.Drawing.Size(100, 41)
        Me.LabourAllowedDaily.TabIndex = 17
        Me.LabourAllowedDaily.TabStop = False
        Me.LabourAllowedDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourVariancePrevious
        '
        Me.LabourVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.LabourVariancePrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourVariancePrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVariancePrevious.Location = New System.Drawing.Point(1061, 371)
        Me.LabourVariancePrevious.Name = "LabourVariancePrevious"
        Me.LabourVariancePrevious.Size = New System.Drawing.Size(60, 41)
        Me.LabourVariancePrevious.TabIndex = 16
        Me.LabourVariancePrevious.TabStop = False
        Me.LabourVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedPrevious
        '
        Me.LabourSchedPrevious.BackColor = System.Drawing.Color.Black
        Me.LabourSchedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourSchedPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedPrevious.Location = New System.Drawing.Point(1061, 324)
        Me.LabourSchedPrevious.Name = "LabourSchedPrevious"
        Me.LabourSchedPrevious.Size = New System.Drawing.Size(60, 41)
        Me.LabourSchedPrevious.TabIndex = 15
        Me.LabourSchedPrevious.TabStop = False
        Me.LabourSchedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedPrevious
        '
        Me.LabourAllowedPrevious.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourAllowedPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedPrevious.Location = New System.Drawing.Point(1061, 277)
        Me.LabourAllowedPrevious.Name = "LabourAllowedPrevious"
        Me.LabourAllowedPrevious.Size = New System.Drawing.Size(60, 41)
        Me.LabourAllowedPrevious.TabIndex = 14
        Me.LabourAllowedPrevious.TabStop = False
        Me.LabourAllowedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourVarianceCurrent
        '
        Me.LabourVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourVarianceCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourVarianceCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourVarianceCurrent.Location = New System.Drawing.Point(995, 371)
        Me.LabourVarianceCurrent.Name = "LabourVarianceCurrent"
        Me.LabourVarianceCurrent.Size = New System.Drawing.Size(60, 41)
        Me.LabourVarianceCurrent.TabIndex = 13
        Me.LabourVarianceCurrent.TabStop = False
        Me.LabourVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourSchedCurrent
        '
        Me.LabourSchedCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourSchedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourSchedCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourSchedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourSchedCurrent.Location = New System.Drawing.Point(995, 324)
        Me.LabourSchedCurrent.Name = "LabourSchedCurrent"
        Me.LabourSchedCurrent.Size = New System.Drawing.Size(60, 41)
        Me.LabourSchedCurrent.TabIndex = 12
        Me.LabourSchedCurrent.TabStop = False
        Me.LabourSchedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabourAllowedCurrent
        '
        Me.LabourAllowedCurrent.BackColor = System.Drawing.Color.Black
        Me.LabourAllowedCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabourAllowedCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabourAllowedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.LabourAllowedCurrent.Location = New System.Drawing.Point(995, 277)
        Me.LabourAllowedCurrent.Name = "LabourAllowedCurrent"
        Me.LabourAllowedCurrent.Size = New System.Drawing.Size(60, 41)
        Me.LabourAllowedCurrent.TabIndex = 11
        Me.LabourAllowedCurrent.TabStop = False
        Me.LabourAllowedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ActualSalesLabel
        '
        Me.ActualSalesLabel.BackColor = System.Drawing.Color.Black
        Me.ActualSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ActualSalesLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualSalesLabel.ForeColor = System.Drawing.Color.White
        Me.ActualSalesLabel.Location = New System.Drawing.Point(573, 289)
        Me.ActualSalesLabel.Name = "ActualSalesLabel"
        Me.ActualSalesLabel.Size = New System.Drawing.Size(100, 26)
        Me.ActualSalesLabel.TabIndex = 20
        Me.ActualSalesLabel.TabStop = False
        Me.ActualSalesLabel.Text = "Actual $"
        Me.ActualSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProjectedSalesLabel
        '
        Me.ProjectedSalesLabel.BackColor = System.Drawing.Color.Black
        Me.ProjectedSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectedSalesLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectedSalesLabel.ForeColor = System.Drawing.Color.White
        Me.ProjectedSalesLabel.Location = New System.Drawing.Point(573, 336)
        Me.ProjectedSalesLabel.Name = "ProjectedSalesLabel"
        Me.ProjectedSalesLabel.Size = New System.Drawing.Size(100, 26)
        Me.ProjectedSalesLabel.TabIndex = 21
        Me.ProjectedSalesLabel.TabStop = False
        Me.ProjectedSalesLabel.Text = "Projected $"
        Me.ProjectedSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceLabel
        '
        Me.SalesVarianceLabel.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVarianceLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceLabel.ForeColor = System.Drawing.Color.White
        Me.SalesVarianceLabel.Location = New System.Drawing.Point(573, 383)
        Me.SalesVarianceLabel.Name = "SalesVarianceLabel"
        Me.SalesVarianceLabel.Size = New System.Drawing.Size(100, 26)
        Me.SalesVarianceLabel.TabIndex = 22
        Me.SalesVarianceLabel.TabStop = False
        Me.SalesVarianceLabel.Text = "+/- $"
        Me.SalesVarianceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CurrentSalesLabel
        '
        Me.CurrentSalesLabel.BackColor = System.Drawing.Color.Black
        Me.CurrentSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentSalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentSalesLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentSalesLabel.Location = New System.Drawing.Point(679, 236)
        Me.CurrentSalesLabel.Name = "CurrentSalesLabel"
        Me.CurrentSalesLabel.Size = New System.Drawing.Size(80, 35)
        Me.CurrentSalesLabel.TabIndex = 23
        Me.CurrentSalesLabel.TabStop = False
        Me.CurrentSalesLabel.Text = "Curr"
        Me.CurrentSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PreviousSalesLabel
        '
        Me.PreviousSalesLabel.BackColor = System.Drawing.Color.Black
        Me.PreviousSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviousSalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousSalesLabel.ForeColor = System.Drawing.Color.White
        Me.PreviousSalesLabel.Location = New System.Drawing.Point(765, 236)
        Me.PreviousSalesLabel.Name = "PreviousSalesLabel"
        Me.PreviousSalesLabel.Size = New System.Drawing.Size(80, 35)
        Me.PreviousSalesLabel.TabIndex = 24
        Me.PreviousSalesLabel.TabStop = False
        Me.PreviousSalesLabel.Text = "Prev"
        Me.PreviousSalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DailySalesLabel
        '
        Me.DailySalesLabel.BackColor = System.Drawing.Color.Black
        Me.DailySalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DailySalesLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailySalesLabel.ForeColor = System.Drawing.Color.White
        Me.DailySalesLabel.Location = New System.Drawing.Point(765, 449)
        Me.DailySalesLabel.Name = "DailySalesLabel"
        Me.DailySalesLabel.Size = New System.Drawing.Size(257, 35)
        Me.DailySalesLabel.TabIndex = 25
        Me.DailySalesLabel.TabStop = False
        Me.DailySalesLabel.Text = "Daily Tracking"
        Me.DailySalesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(889, 371)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "+/- Hrs"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ScheduledLabourLabel
        '
        Me.ScheduledLabourLabel.BackColor = System.Drawing.Color.Black
        Me.ScheduledLabourLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScheduledLabourLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduledLabourLabel.ForeColor = System.Drawing.Color.White
        Me.ScheduledLabourLabel.Location = New System.Drawing.Point(889, 324)
        Me.ScheduledLabourLabel.Name = "ScheduledLabourLabel"
        Me.ScheduledLabourLabel.Size = New System.Drawing.Size(100, 26)
        Me.ScheduledLabourLabel.TabIndex = 27
        Me.ScheduledLabourLabel.TabStop = False
        Me.ScheduledLabourLabel.Text = "Sched Hrs"
        Me.ScheduledLabourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AllowedLabourLabel
        '
        Me.AllowedLabourLabel.BackColor = System.Drawing.Color.Black
        Me.AllowedLabourLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AllowedLabourLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllowedLabourLabel.ForeColor = System.Drawing.Color.White
        Me.AllowedLabourLabel.Location = New System.Drawing.Point(889, 277)
        Me.AllowedLabourLabel.Name = "AllowedLabourLabel"
        Me.AllowedLabourLabel.Size = New System.Drawing.Size(100, 26)
        Me.AllowedLabourLabel.TabIndex = 26
        Me.AllowedLabourLabel.TabStop = False
        Me.AllowedLabourLabel.Text = "Allowed Hrs"
        Me.AllowedLabourLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(1061, 236)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(60, 35)
        Me.TextBox3.TabIndex = 30
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "Prev"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(995, 236)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 35)
        Me.TextBox4.TabIndex = 29
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Curr"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(639, 614)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 26)
        Me.TextBox5.TabIndex = 34
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "+/- $"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(639, 567)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 26)
        Me.TextBox6.TabIndex = 33
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "Projected $"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(639, 520)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 26)
        Me.TextBox7.TabIndex = 32
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "Actual $"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(712, 186)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(257, 35)
        Me.TextBox8.TabIndex = 35
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "1/2 Hour Tracking"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(915, 611)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "+/- Hrs"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(915, 564)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 26)
        Me.TextBox9.TabIndex = 37
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "Sched Hrs"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Black
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(915, 517)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 26)
        Me.TextBox10.TabIndex = 36
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "Allowed Hrs"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Black
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(639, 661)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 26)
        Me.TextBox11.TabIndex = 40
        Me.TextBox11.TabStop = False
        Me.TextBox11.Text = "+/- %"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVariancePercentDaily
        '
        Me.SalesVariancePercentDaily.BackColor = System.Drawing.Color.Black
        Me.SalesVariancePercentDaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesVariancePercentDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVariancePercentDaily.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVariancePercentDaily.Location = New System.Drawing.Point(745, 649)
        Me.SalesVariancePercentDaily.Name = "SalesVariancePercentDaily"
        Me.SalesVariancePercentDaily.Size = New System.Drawing.Size(100, 41)
        Me.SalesVariancePercentDaily.TabIndex = 39
        Me.SalesVariancePercentDaily.TabStop = False
        Me.SalesVariancePercentDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Black
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.White
        Me.TextBox12.Location = New System.Drawing.Point(639, 708)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 26)
        Me.TextBox12.TabIndex = 42
        Me.TextBox12.TabStop = False
        Me.TextBox12.Text = "Day Proj $"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FullDayProjection
        '
        Me.FullDayProjection.BackColor = System.Drawing.Color.Black
        Me.FullDayProjection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FullDayProjection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullDayProjection.ForeColor = System.Drawing.Color.Yellow
        Me.FullDayProjection.Location = New System.Drawing.Point(745, 696)
        Me.FullDayProjection.Name = "FullDayProjection"
        Me.FullDayProjection.Size = New System.Drawing.Size(100, 41)
        Me.FullDayProjection.TabIndex = 41
        Me.FullDayProjection.TabStop = False
        Me.FullDayProjection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1282, 667)
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gray
        Me.PictureBox3.Location = New System.Drawing.Point(558, 211)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(574, 216)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(570, 225)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(283, 192)
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(859, 225)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(262, 192)
        Me.PictureBox5.TabIndex = 46
        Me.PictureBox5.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.FullDayProjection)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.SalesVariancePercentDaily)
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
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents SalesVarianceCurrent As TextBox
    Friend WithEvents SalesProjectedCurrent As TextBox
    Friend WithEvents SalesActualCurrent As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SalesVariancePrevious As TextBox
    Friend WithEvents SalesProjectedPrevious As TextBox
    Friend WithEvents SalesActualPrevious As TextBox
    Friend WithEvents SalesVarianceDaily As TextBox
    Friend WithEvents SalesProjectedDaily As TextBox
    Friend WithEvents SalesActualDaily As TextBox
    Friend WithEvents LabourVarianceDaily As TextBox
    Friend WithEvents LabourSchedDaily As TextBox
    Friend WithEvents LabourAllowedDaily As TextBox
    Friend WithEvents LabourVariancePrevious As TextBox
    Friend WithEvents LabourSchedPrevious As TextBox
    Friend WithEvents LabourAllowedPrevious As TextBox
    Friend WithEvents LabourVarianceCurrent As TextBox
    Friend WithEvents LabourSchedCurrent As TextBox
    Friend WithEvents LabourAllowedCurrent As TextBox
    Friend WithEvents DailySalesLabel As TextBox
    Friend WithEvents PreviousSalesLabel As TextBox
    Friend WithEvents CurrentSalesLabel As TextBox
    Friend WithEvents SalesVarianceLabel As TextBox
    Friend WithEvents ProjectedSalesLabel As TextBox
    Friend WithEvents ActualSalesLabel As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ScheduledLabourLabel As TextBox
    Friend WithEvents AllowedLabourLabel As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents FullDayProjection As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents SalesVariancePercentDaily As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
