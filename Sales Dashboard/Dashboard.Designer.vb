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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SalesActualCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualCurrent.Location = New System.Drawing.Point(634, 122)
        Me.SalesActualCurrent.Name = "SalesActualCurrent"
        Me.SalesActualCurrent.Size = New System.Drawing.Size(144, 41)
        Me.SalesActualCurrent.TabIndex = 2
        Me.SalesActualCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedCurrent
        '
        Me.SalesProjectedCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedCurrent.Location = New System.Drawing.Point(634, 169)
        Me.SalesProjectedCurrent.Name = "SalesProjectedCurrent"
        Me.SalesProjectedCurrent.Size = New System.Drawing.Size(144, 41)
        Me.SalesProjectedCurrent.TabIndex = 3
        Me.SalesProjectedCurrent.Text = "450"
        Me.SalesProjectedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVarianceCurrent
        '
        Me.SalesVarianceCurrent.BackColor = System.Drawing.Color.Black
        Me.SalesVarianceCurrent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVarianceCurrent.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVarianceCurrent.Location = New System.Drawing.Point(634, 216)
        Me.SalesVarianceCurrent.Name = "SalesVarianceCurrent"
        Me.SalesVarianceCurrent.Size = New System.Drawing.Size(144, 41)
        Me.SalesVarianceCurrent.TabIndex = 4
        Me.SalesVarianceCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesVariancePrevious
        '
        Me.SalesVariancePrevious.BackColor = System.Drawing.Color.Black
        Me.SalesVariancePrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesVariancePrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesVariancePrevious.Location = New System.Drawing.Point(844, 216)
        Me.SalesVariancePrevious.Name = "SalesVariancePrevious"
        Me.SalesVariancePrevious.Size = New System.Drawing.Size(144, 41)
        Me.SalesVariancePrevious.TabIndex = 7
        Me.SalesVariancePrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesProjectedPrevious
        '
        Me.SalesProjectedPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesProjectedPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesProjectedPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesProjectedPrevious.Location = New System.Drawing.Point(844, 169)
        Me.SalesProjectedPrevious.Name = "SalesProjectedPrevious"
        Me.SalesProjectedPrevious.Size = New System.Drawing.Size(144, 41)
        Me.SalesProjectedPrevious.TabIndex = 6
        Me.SalesProjectedPrevious.Text = "450"
        Me.SalesProjectedPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesActualPrevious
        '
        Me.SalesActualPrevious.BackColor = System.Drawing.Color.Black
        Me.SalesActualPrevious.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesActualPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.SalesActualPrevious.Location = New System.Drawing.Point(844, 122)
        Me.SalesActualPrevious.Name = "SalesActualPrevious"
        Me.SalesActualPrevious.Size = New System.Drawing.Size(144, 41)
        Me.SalesActualPrevious.TabIndex = 5
        Me.SalesActualPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.SalesVariancePrevious)
        Me.Controls.Add(Me.SalesProjectedPrevious)
        Me.Controls.Add(Me.SalesActualPrevious)
        Me.Controls.Add(Me.SalesVarianceCurrent)
        Me.Controls.Add(Me.SalesProjectedCurrent)
        Me.Controls.Add(Me.SalesActualCurrent)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
