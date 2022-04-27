Imports System.IO

Public Class Dashboard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        DoIt()
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
        'UpdateStatusInfo
        Dim strStatus As String
        Dim intTime As Integer = (CInt(DateTime.Now.Hour) * 100) + CInt(DateTime.Now.Minute)
        If intTime > (Module1.intOpen * 100) And intTime <= Module1.DP1 Then
            strStatus = "6558 - DP1"
        ElseIf intTime > Module1.DP1 And intTime <= Module1.DP2 Then
            strStatus = "6558 - DP2"
        ElseIf intTime > Module1.DP2 And intTime <= Module1.DP3 Then
            strStatus = "6558 - DP3"
        ElseIf intTime > Module1.DP3 And intTime <= Module1.DP4 Then
            strStatus = "6558 - DP4"
        ElseIf intTime > Module1.DP4 And intTime <= Module1.DP5 Then
            strStatus = "6558 - DP5"
        ElseIf intTime > Module1.DP5 And intTime <= Module1.DP6 Then
            strStatus = "6558 - DP6"
        Else
            strStatus = "CLOSED"
        End If
        txtStatus.Text = strStatus
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
        'ActivateChart
        For i = 0 To intTotalOpenPeriods - 1
            chrtLabourChart.Series(1).Points.AddXY(i, 0)                            'Create Labour Allowed Chart points
            chrtLabourChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)  'Label the X-Axis
            chrtLabourChart.Series(0).Points.AddXY(i, 0)                            'Create Sched Labour Chart points
            chrtSalesChart.Series(1).Points.AddXY(i, 0)                             'Create Sales Projection Chart points
            chrtSalesChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)   'Label the X-Axis
            chrtSalesChart.Series(0).Points.AddXY(i, 0)                             'Create Live Sales Chart points
        Next
        DoIt()                                                              'Run Main Sub Right Away
    End Sub

    Public Sub DoIt()
        On Error Resume Next
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
        Module1.intOpen = CInt(strConfigArray(0))                                       'Load Open Time
        Module1.intClose = CInt(strConfigArray(1))                                      'Load Close Time
        Dim intTotalOpenPeriods As Integer = (Module1.intClose - Module1.intOpen) * 2   'Calculate number of open periods

        'Where are we on the list -
        Dim intHour As Integer = CInt(DateTime.Now.Hour)
        Dim intMinute As Integer = CInt(DateTime.Now.Minute)
        Dim decSalesActualCurrent, decSalesProjectedCurrent, decSalesVarianceCurrent As Decimal
        Dim decSalesActualPrevious, decSalesProjectedPrevious, decSalesVariancePrevious As Decimal
        Dim decSalesLiveTotal, decSalesProjectedTotal, decSalesVarianceTotal As Decimal
        Dim intLabourAllowedCurrent, intLabourSchedCurrent, intLabourVarianceCurrent As Integer
        Dim intLabourAllowedPrevious, intLabourSchedPrevious, intLabourVariancePrevious As Integer
        Dim intLabourAllowedTotal, intLabourSchedTotal, intLabourVarianceTotal As Integer

        If intHour >= Module1.intClose Or intHour <= Module1.intOpen Then
            txtStatus.Text = "CLOSED"
        Else
            txtStatus.Text = "6558"
        End If
        '''''Needs to be fixed for differing closing times
        If intHour > 21 Then                                            'If After 10pm then set to closing hour
            intHour = 30
        ElseIf intHour < 7 Then
            intHour = 30
        Else
            intHour = (intHour * 2) - 14                                'Calculate the whole hour
            If intMinute > 29 Then                                      'Add one for the half hours
                intHour += 1
            End If
        End If

        'Let's Array Our Live Sales from our LiveSales.txt file and Calculate Our Current Daily Sales
        Dim decLiveSalesArray(48) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\LiveSales.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited             'Set file as delimited
            MyReader.SetDelimiters(",")                                     'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            While Not MyReader.EndOfData
                intRow += 1
                currentRow = MyReader.ReadFields()                          'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                         'Cycle through each field on this line
                    If intIndex = 3 Then                                    'Grab only the 3rd field (sales)
                        If intHour <= intTotalOpenPeriods Then              'Make sure we are within our open hours
                            decLiveSalesArray(intRow) = CDec(currentField)  'Put it into the array
                        Else
                            decLiveSalesArray(intRow) = 0                   'If we are after close then put a zero in
                        End If
                    ElseIf intIndex = 5 Then
                        intIndex = 0
                    End If
                    intIndex += 1                                           'Move to the next field
                Next
                If intRow > intHour Then Exit While                         'If we are outside the open hours then jump out
            End While
        End Using



        'Let's Array Our Projected Sales from our SalesProjections.txt file
        Dim decProjectedSalesArray(34) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\SalesProjections.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited             'Set file as delimited
            MyReader.SetDelimiters(",")                                     'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            decSalesProjectedTotal = 0
            While Not MyReader.EndOfData                                    'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                                 'Move to the next line
                currentRow = MyReader.ReadFields()                          'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                         'Cycle through each field on this line
                    If intIndex = 3 Then                                    'Grab only the 3rd field (sales)
                        decProjectedSalesArray(intRow) = CDec(currentField) 'Put it into the array
                    End If
                    If intIndex = 3 Then                                    'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                           'Move to the next field
                Next
                'If intRow > intHour Then Exit While
            End While
        End Using

        'Let's Array Our Scheduled Labour from our SchedLabour.txt
        Dim intSchedLabourArray(34) As Integer
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\SchedLabour.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited             'Set file as delimited
            MyReader.SetDelimiters(",")                                     'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            While Not MyReader.EndOfData                                    'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                                 'Move to the next line
                currentRow = MyReader.ReadFields()                          'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                         'Cycle through each field on this line
                    If intIndex = 3 Then                                    'Grab only the 2nd field (sched hours)
                        intSchedLabourArray(intRow) = CInt(currentField)    'Put it into the array
                    End If
                    If intIndex = 3 Then                                    'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                           'Move to the next field
                Next
            End While
        End Using

        'Let's Array Our Manning Guides
        'Start with DP1
        Dim decManningGuide1(13, 3) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide1.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = -1
            For i = 0 To 12                                             'Cycle through all 12 lines
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    intIndex += 1                                       'Move to the next Field (starting at -1 so first field is 0)
                    decManningGuide1(i, intIndex) = CDec(currentField)  'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then                                'If end of line then reset back to the beginning
                        intIndex = -1
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using
        'Next with DP2
        Dim decManningGuide2(13, 3) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide23.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = -1
            For i = 0 To 12                                             'Cycle through all 12 lines
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    intIndex += 1                                       'Move to the next Field (starting at -1 so first field is 0)
                    decManningGuide2(i, intIndex) = CDec(currentField)  'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then                                'If end of line then reset back to the beginning
                        intIndex = -1
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using
        'Next with DP3
        Dim decManningGuide3(13, 3) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide23.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = -1
            For i = 0 To 12                                             'Cycle through all 12 lines
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    intIndex += 1                                       'Move to the next Field (starting at -1 so first field is 0)
                    decManningGuide3(i, intIndex) = CDec(currentField)  'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then                                'If end of line then reset back to the beginning
                        intIndex = -1
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using
        'Next with DP4
        Dim decManningGuide4(13, 3) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide45.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = -1
            For i = 0 To 12                                             'Cycle through all 12 lines
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    intIndex += 1                                       'Move to the next Field (starting at -1 so first field is 0)
                    decManningGuide4(i, intIndex) = CDec(currentField)  'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then                                'If end of line then reset back to the beginning
                        intIndex = -1
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using
        'Next with DP5
        Dim decManningGuide5(13, 3) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide45.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = -1
            For i = 0 To 12                                             'Cycle through all 12 lines
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    intIndex += 1                                       'Move to the next Field (starting at -1 so first field is 0)
                    decManningGuide5(i, intIndex) = CDec(currentField)  'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then                                'If end of line then reset back to the beginning
                        intIndex = -1
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using
        'Finally DP6
        Dim decManningGuide6(13, 3) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide6.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = -1
            For i = 0 To 12
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    intIndex += 1                                       'Move to the next Field (starting at -1 so first field is 0)
                    decManningGuide6(i, intIndex) = CDec(currentField)  'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then
                        intIndex = -1                                   'If end of line then reset back to the beginning
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using

        'Let's Build our allowed labour Array
        Dim intAllowedLabourArray(48)
        Dim intTime As Integer
        For i = 0 To intHour
            If i Mod 2 = 0 Then
                intTime = (i + (Module1.intOpen * 2)) * 50              'Convert loop to real time based on opening time
            Else
                intTime = ((i + (Module1.intOpen * 2) - 1) * 50) + 30   'Adjust for half hours
            End If
            If intTime < Module1.DP1 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide1(j, 0) And decLiveSalesArray(i) < decManningGuide1(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide1(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP1 - 1 And intTime < Module1.DP2 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide2(j, 0) And decLiveSalesArray(i) < decManningGuide2(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide2(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP2 - 1 And intTime < Module1.DP3 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide3(j, 0) And decLiveSalesArray(i) < decManningGuide3(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide3(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP3 - 1 And intTime < Module1.DP4 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide4(j, 0) And decLiveSalesArray(i) < decManningGuide4(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide4(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP4 - 1 And intTime < Module1.DP5 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide5(j, 0) And decLiveSalesArray(i) < decManningGuide5(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide5(j, 2))
                        Exit For
                    End If
                Next j
            Else
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide6(j, 0) And decLiveSalesArray(i) < decManningGuide6(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide6(j, 2))
                        Exit For
                    End If
                Next j
            End If
        Next i
        If intHour >= intTotalOpenPeriods Then                          'If we are beyond operating hours
            intAllowedLabourArray(intHour) = 0                          'Make our allowed labour zero
        End If
        'Lets Sum it All Up
        For i = 0 To intHour - 1
            decSalesLiveTotal += decLiveSalesArray(i)                   'Sum up Live Sales for the day so far
            decSalesProjectedTotal += decProjectedSalesArray(i)         'Sum up Projected Sales for the day so far
            intLabourAllowedTotal += intAllowedLabourArray(i)           'Sum up Allowed Labour for the day so far
            intLabourSchedTotal += intSchedLabourArray(i)               'Sum up Sched Labour for the day so far
        Next
        Dim decFullDaySalesProjection As Decimal                        'Sum up Projected Sales for the entire day
        For i = 0 To intTotalOpenPeriods                                '
            decFullDaySalesProjection += decProjectedSalesArray(i)      '
        Next                                                            '


        'Let's update the Sales Dashboard
        decSalesActualCurrent = decLiveSalesArray(intHour)                              'Populate Actual Sales Current from Array
        decSalesProjectedCurrent = decProjectedSalesArray(intHour)                      'Populate Projected Sales Current from Array
        decSalesVarianceCurrent = decSalesActualCurrent - decSalesProjectedCurrent      'Calculate Sales Variance Current
        decSalesActualPrevious = decLiveSalesArray(intHour - 1)                         'Populate Actual Sales Previous From Array
        decSalesProjectedPrevious = decProjectedSalesArray(intHour - 1)                 'Populate Projected Sales Previous From Array
        decSalesVariancePrevious = decSalesActualPrevious - decSalesProjectedPrevious   'Calculate Sales Variance Previous
        decSalesVarianceTotal = decSalesLiveTotal - decSalesProjectedTotal              'Calculate Sales Variance for Day So Far

        'Fill in Sales Data
        'Current Sales
        Me.SalesActualCurrent.Text = CStr(CInt(decSalesActualCurrent))                   'Display Current Actual Sales
        Me.SalesProjectedCurrent.Text = CStr(CInt(decSalesProjectedCurrent))             'Display Current Projected Sales
        If decSalesVarianceCurrent > 0 Then                                              'If Sales Variance is positive then make it green
            Me.SalesVarianceCurrent.ForeColor = Color.LimeGreen
            Me.SalesVarianceCurrent.Text = "+" & CStr(CInt(decSalesVarianceCurrent))     'Show a + sign if positive
        Else                                                                             'If sales Variance is negative then make it red
            Me.SalesVarianceCurrent.ForeColor = Color.Red
            Me.SalesVarianceCurrent.Text = CStr(CInt(decSalesVarianceCurrent))
        End If
        'Previous Sales
        Me.SalesActualPrevious.Text = CStr(CInt(decSalesActualPrevious))                 'Display Previous Actual Sales
        Me.SalesProjectedPrevious.Text = CStr(CInt(decSalesProjectedPrevious))           'Display Previous Projected Sales
        If decSalesVariancePrevious > 0 Then                                             'If Sales Variance is positive then make it green
            Me.SalesVariancePrevious.ForeColor = Color.LimeGreen
            Me.SalesVariancePrevious.Text = "+" & CStr(CInt(decSalesVariancePrevious))   'Show a + sign if positve
        Else                                                                             'If sales Variance is negative then make it red
            Me.SalesVariancePrevious.ForeColor = Color.Red
            Me.SalesVariancePrevious.Text = CStr(CInt(decSalesVariancePrevious))
        End If
        'Daily Sales
        Me.SalesActualDaily.Text = CStr(CInt(decSalesLiveTotal))                         'Display Actual Daily Sales So Far
        Me.SalesProjectedDaily.Text = CStr(CInt(decSalesProjectedTotal))                 'Display Projected Daily Sales So Far
        If decSalesVarianceTotal > 0 Then                                                'If Daily Sales Variance is positve then make it green
            Me.SalesVarianceDaily.ForeColor = Color.LimeGreen
            Me.SalesVarianceDaily.Text = "+" & CStr(CInt(decSalesVarianceTotal))         'Show a + sign if positive
        Else                                                                             'If sales Variance is negative than zero then make it red
            Me.SalesVarianceDaily.ForeColor = Color.Red
            Me.SalesVarianceDaily.Text = CStr(CInt(decSalesVarianceTotal))
        End If
        If decSalesProjectedTotal > 0 Then
            Dim SalesPercent As Single = CSng((decSalesLiveTotal - decSalesProjectedTotal) / decSalesProjectedTotal)
            Dim FormattedSalesPercent As String = FormatPercent(SalesPercent)
            Me.txtSalesVariancePercentDaily.Text = FormattedSalesPercent
            If SalesPercent < 0 Then
                Me.txtSalesVariancePercentDaily.ForeColor = Color.Red
            ElseIf SalesPercent > 0 Then
                Me.txtSalesVariancePercentDaily.ForeColor = Color.LimeGreen
            Else
                Me.txtSalesVariancePercentDaily.ForeColor = Color.Yellow
            End If
        End If


        Me.txtFullDaySalesProjection.Text = CStr(CInt(decFullDaySalesProjection))


        'Let's Update the Labour Dashboard
        intLabourAllowedCurrent = intAllowedLabourArray(intHour)                        'Populate Allowed Current Labour
        intLabourAllowedPrevious = intAllowedLabourArray(intHour - 1)                   'Populate Allowed Previous Labour
        intLabourSchedCurrent = intSchedLabourArray(intHour)                            'Populate Scheduled Current Labour
        intLabourSchedPrevious = intSchedLabourArray(intHour - 1)                       'Populate Scheduled Previous Labour
        intLabourVarianceCurrent = intLabourSchedCurrent - intLabourAllowedCurrent      'Calculate Current Labour Variance
        intLabourVariancePrevious = intLabourSchedPrevious - intLabourAllowedPrevious   'Calculate Previous Labour Variance
        intLabourVarianceTotal = intLabourSchedTotal - intLabourAllowedTotal            'Calculate Labour Variance for Day So Far
        'Fill in Labour Data
        'Current Labour
        Me.LabourAllowedCurrent.Text = CStr(intLabourAllowedCurrent)                    'Display Current Allowed Labour
        Me.LabourSchedCurrent.Text = CStr(intLabourSchedCurrent)                        'Display Current Scheduled Labour
        If intLabourVarianceCurrent > 0 Then                                            'If Labour Variance is positive then make it red
            Me.LabourVarianceCurrent.ForeColor = Color.Red
            Me.LabourVarianceCurrent.Text = "+" & CStr(intLabourVarianceCurrent)        'Show a + sign if positive
        Else                                                                            'If Labour Variance is zero or negative then make it green
            Me.LabourVarianceCurrent.ForeColor = Color.LimeGreen
            Me.LabourVarianceCurrent.Text = CStr(intLabourVarianceCurrent)
        End If
        'Previous Labour
        Me.LabourAllowedPrevious.Text = CStr(intLabourAllowedPrevious)                  'Display Previous Allowed Labour
        Me.LabourSchedPrevious.Text = CStr(intLabourSchedPrevious)                      'Display Previous Scheduled Labour
        If intLabourVariancePrevious > 0 Then                                           'If Labour Variance is positive then make it red
            Me.LabourVariancePrevious.ForeColor = Color.Red
            Me.LabourVariancePrevious.Text = "+" & CStr(intLabourVariancePrevious)      'Show a + sign if positive
        Else                                                                            'If Labour Variance is zero of negative then make it green
            Me.LabourVariancePrevious.ForeColor = Color.LimeGreen
            Me.LabourVariancePrevious.Text = CStr(intLabourVariancePrevious)
        End If
        'Daily Labour
        Me.LabourAllowedDaily.Text = CStr(intLabourAllowedTotal)                        'Display Daily Allowed Labour so far
        Me.LabourSchedDaily.Text = CStr(intLabourSchedTotal)                            'Display Daily Scheduled Labour so far
        If intLabourVarianceTotal > 0 Then                                              'If Labour Variance is positive then make it red
            Me.LabourVarianceDaily.ForeColor = Color.Red
            Me.LabourVarianceDaily.Text = "+" & CStr(intLabourVarianceTotal)            'Show a + sign if positive
        Else                                                                            'If sales Variance is zero or negative then make it green
            Me.LabourVarianceDaily.ForeColor = Color.LimeGreen
            Me.LabourVarianceDaily.Text = CStr(intLabourVarianceTotal)
        End If


        'Let's Grab our Weather
        Dim strWeatherArray(3) As String
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\weather.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 0
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the Weather.txt file
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line                                            
                    strWeatherArray(intIndex) = currentField            'Put it into the array
                    intIndex += 1
                Next                                                    'Next Field
            End While
        End Using
        'Display the Weather to The Dashboard
        Me.txtWeatherTemp.Text = strWeatherArray(0)                     'Display Temp
        Me.txtWeatherFeelsLike.Text = strWeatherArray(1)                'Display Feels Like
        Me.txtWeatherDescription.Text = strWeatherArray(2)              'Display Weather Description


        'Let's Grab our VOC
        Dim strVOCArray(9) As String
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\smg.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 0
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the Weather.txt file
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line                                            
                    strVOCArray(intIndex) = currentField                'Put it into the array
                    intIndex += 1
                Next                                                    'Next Field
            End While
        End Using
        'Set Up the Colours
        If CDec(strVOCArray(8)) >= Module1.VOCGreen Then
            txtOSAT.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(8)) < Module1.VOCRed Then
            txtOSAT.ForeColor = Color.Red
        Else txtOSAT.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(7)) = 0 Then
            txtZOD.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(7)) > 10 Then
            txtZOD.ForeColor = Color.Red
        Else txtZOD.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(4)) >= Module1.VOCGreen Then
            txtFriendly.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(4)) < Module1.VOCRed Then
            txtFriendly.ForeColor = Color.Red
        Else txtFriendly.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(3)) >= Module1.VOCGreen Then
            txtClean.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(3)) < Module1.VOCRed Then
            txtClean.ForeColor = Color.Red
        Else txtClean.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(2)) >= Module1.VOCGreen Then
            txtFast.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(2)) < Module1.VOCRed Then
            txtFast.ForeColor = Color.Red
        Else txtFast.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(1)) >= Module1.VOCGreen Then
            txtAccurate.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(1)) < Module1.VOCRed Then
            txtAccurate.ForeColor = Color.Red
        Else txtAccurate.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(0)) >= Module1.VOCGreen Then
            txtTaste.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(0)) < Module1.VOCRed Then
            txtTaste.ForeColor = Color.Red
        Else txtTaste.ForeColor = Color.Yellow
        End If
        'Display the Weather to The Dashboard
        Me.txtOSAT.Text = strVOCArray(8)                                'Display OSAT
        Me.txtZOD.Text = strVOCArray(7)                                 'Display ZOD
        Me.txtFriendly.Text = strVOCArray(4)                            'Display Friendly
        Me.txtClean.Text = strVOCArray(3)                               'Display Clean
        Me.txtFast.Text = strVOCArray(2)                                'Display Fast
        Me.txtAccurate.Text = strVOCArray(1)                            'Display Accurate
        Me.txtTaste.Text = strVOCArray(0)                               'Display Taste

        'Let's Get The DT Data
        Dim strDTArray(3) As String
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\LiveDTTimes.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 0
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the Weather.txt file
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line                                            
                    strDTArray(intIndex) = currentField                 'Put it into the array
                    intIndex += 1
                Next                                                    'Next Field
            End While
        End Using
        'Set Up the DT Colours
        If CInt(strDTArray(0)) <= Module1.TTLGreen Then
            txtDayPartTTL.ForeColor = Color.LimeGreen
        ElseIf CInt(strDTArray(0)) >= Module1.TTLRed Then
            txtDayPartTTL.ForeColor = Color.Red
        Else
            txtDayPartTTL.ForeColor = Color.Yellow
        End If
        If CInt(strDTArray(2)) <= Module1.TTLGreen Then
            txtFullDayTTL.ForeColor = Color.LimeGreen
        ElseIf CInt(strDTArray(2)) >= Module1.TTLRed Then
            txtFullDayTTL.ForeColor = Color.Red
        Else
            txtFullDayTTL.ForeColor = Color.Yellow
        End If
        'Display The DT Data
        Me.txtDayPartTTL.Text = strDTArray(0)
        Me.txtDayPartCC.Text = strDTArray(1)
        Me.txtFullDayTTL.Text = strDTArray(2)

        'Update Charts
        Dim strLiveSalesArray(48) As String                                                     'Set up a string array for live sales values
        For i = 0 To intTotalOpenPeriods
            chrtLabourChart.Series(0).Points.ElementAt(i).SetValueY(intAllowedLabourArray(i))
            chrtLabourChart.Series(1).Points.ElementAt(i).SetValueY(intSchedLabourArray(i))
            chrtSalesChart.Series(0).Points.ElementAt(i).SetValueY(decProjectedSalesArray(i))
            If i > intHour Then                                                                 'See if we are in the future
                strLiveSalesArray(i) = Nothing                                                  'If we are in the future then make value empty
            Else
                strLiveSalesArray(i) = CStr(decLiveSalesArray(i))                               'Convert all current Sales values to strings
            End If
            chrtSalesChart.Series(1).Points.ElementAt(i).SetValueY(strLiveSalesArray(i))        'Update point on graph
        Next
        chrtLabourChart.Update()
        chrtSalesChart.Update()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
