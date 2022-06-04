Imports System.IO

Public Class Dashboard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
#If DEBUG Then
        Debug.WriteLine("Started By FileSystemWatcher")
#End If
        FileSystemWatcher1.EnableRaisingEvents = False
        Master.Doit()
        FileSystemWatcher1.EnableRaisingEvents = True
    End Sub

    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        Dim time As DateTime = DateTime.Now
        Dim Format As String = "ddd d-MM-yyyy  h:mm:ss tt"
        Me.txtClock.Text = time.ToString(Format)
        'Check if restart time
        Format = "Hmmss"                                            'Format Time
        Dim strRestart As String = CStr(Module1.intOpen) & "0000"   'Calculate Opening time in same format
        If time.ToString(Format) = strRestart Then                  'If they match then restart
            Application.Restart()
        End If

    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Read the config file
        Dim strConfigArray(2) As String
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\SalesConfig.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 0
            For i = 0 To 1
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    If intIndex = 1 Then                                'Grab only the 3rd field (sales)
                        strConfigArray(i) = currentField                'Put it into the array
                        intIndex = 0
                    ElseIf intIndex = 0 Then
                        intIndex = 1
                    End If
                Next
            Next i
        End Using

        'Set Open and Close Times
        Module1.intOpen = 630   'CInt(strConfigArray(0))                                       'Open Time
        Module1.intClose = 2200   'CInt(strConfigArray(1))                                      'Close Time
        'Dim intTotalOpenPeriods As Integer = (Module1.intClose - Module1.intOpen) * 2   'Calc number of open periods
        Dim intTotalOpenPeriods As Integer = 1
        Dim intCountdown As Integer = Module1.intOpen
        Dim strCountdown As String
        Do
#If DEBUG Then
            Debug.WriteLine("Total Periods: " & CStr(intTotalOpenPeriods) & " " & CStr(intCountdown))
#End If
            intTotalOpenPeriods += 1
            strCountdown = CStr(intCountdown)
            If strCountdown.Substring(strCountdown.Length - 2) = "00" Then
                intCountdown += 30
            Else
                intCountdown += 70
            End If
        Loop Until intCountdown = Module1.intClose
        Dim strSeriesLabelArray(48) As String                                           'Create Array for Chart labels
        Dim intIndex2 As Integer = 0
        For i = 0 To intTotalOpenPeriods - 1 Step 2                                     'Loop through the parts
            strSeriesLabelArray(i) = CStr(Module1.intOpen + intIndex2) & ":30"          'Label the odd periods as on the hour
            strSeriesLabelArray(i + 1) = CStr(Module1.intOpen + intIndex2) & ":00"      'Label the even periods as 30 after
            intIndex2 += 1
        Next
        strSeriesLabelArray(intTotalOpenPeriods) = CStr(Module1.intClose) & ":00"

        'Initialize Charts
        For i = 0 To intTotalOpenPeriods - 1
            chrtLabourChart.Series(1).Points.AddXY(i, 0)                            'Create Sched Labour Chart points
            chrtLabourChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)  'Label the X-Axis
            chrtSalesChart.Series(0).Points.AddXY(i, 0)                             'Create Projected Sales Chart points
            chrtSalesChart.Series(0).Points(i).AxisLabel = strSeriesLabelArray(i)   'Label the X-Axis
        Next
        Me.Left = 0
        Me.Top = 0
#If DEBUG Then
        Debug.WriteLine("Started By Startup Activation")
#End If
        Master.Doit()                                                              'Run Main Sub Right Away
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles timerUpdate.Tick
#If DEBUG Then
        Debug.WriteLine("Started By timerUpdate")
#End If
        Master.Doit()
    End Sub

    Private Sub picMini_Click(sender As Object, e As EventArgs) Handles picMini.Click
        Dim strComputerName As String = Environment.MachineName.ToString()  'Get Machine Name
        If strComputerName = "06588MGR" Then                         'If we are The Back Office then
            'frmMiniDashboard.Left = -1927
            'frmMiniDashboard.Top = 7
        End If
        frmMiniDashboard.Visible = True
        Me.Visible = False
        frmActive = Me
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
