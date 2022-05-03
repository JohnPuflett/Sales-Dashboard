Imports System.IO

Public Class frmMiniDashboard
    Private Sub picMainDashboard_Click(sender As Object, e As EventArgs) Handles picMainDashboard.Click
        Me.Visible = False
        Dashboard.Visible = True
        frmActive = Me
    End Sub

    Private Sub SalesActualPrevious_TextChanged(sender As Object, e As EventArgs) Handles SalesActualPrevious.TextChanged

    End Sub

    Private Sub frmMiniDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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
        Module1.intOpen = CInt(strConfigArray(0))                                       'Open Time
        Module1.intClose = CInt(strConfigArray(1))                                      'Close Time
        Dim intTotalOpenPeriods As Integer = (Module1.intClose - Module1.intOpen) * 2   'Calc number of open periods
        Dim strSeriesLabelArray(48) As String                                           'Create Array for Chart labels
        Dim intIndex2 As Integer = 0
        For i = 0 To intTotalOpenPeriods - 1 Step 2                                     'Loop through the parts
            strSeriesLabelArray(i) = CStr(Module1.intOpen + intIndex2) & ":00"          'Label the odd periods as on the hour
            strSeriesLabelArray(i + 1) = CStr(Module1.intOpen + intIndex2) & ":30"      'Label the even periods as 30 after
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
        Master.MiniDoIt()                                                              'Run Main Sub Right Away
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

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
#If DEBUG Then
        Debug.WriteLine("Started By FileSystemWatcher")
#End If
        Master.MiniDoIt()
    End Sub
End Class