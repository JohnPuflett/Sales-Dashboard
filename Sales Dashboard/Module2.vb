Module Master
    Public Sub Doit()
        On Error Resume Next
#If DEBUG Then
        Dim Stopwatch As New Stopwatch
        Stopwatch.Start()
#End If

        Dashboard.timerUpdate.Enabled = False
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
        Module1.intOpen = 630 'CInt(strConfigArray(0))                                       'Load Open Time
        Module1.intClose = 2200 'CInt(strConfigArray(1))                                      'Load Close Time
        Dim intTotalOpenPeriods As Integer = 1
        Dim intCountdown As Integer = Module1.intOpen
        Dim strCountdown As String
        Do
#If DEBUG Then
            Debug.WriteLine("Total Periods: " & CStr(intTotalOpenPeriods) & " " & CStr(intCountdown))
#End If
            intTotalOpenPeriods += 1
            If intTotalOpenPeriods > 48 Then
                Exit Sub
            End If
            strCountdown = CStr(intCountdown)

            If strCountdown.Substring(strCountdown.Length - 2) = "00" Then
                intCountdown += 30
            Else
                intCountdown += 70
            End If
        Loop Until intCountdown = Module1.intClose

        'Dim intTotalOpenPeriods As Integer = (Module1.intClose - Module1.intOpen) * 2   'Calculate number of open periods

        'Where are we on the list -
        Dim intHour As Integer = CInt(DateTime.Now.Hour)
        Dim intMinute As Integer = CInt(DateTime.Now.Minute)
        Dim decSalesActualCurrent, decSalesProjectedCurrent, decSalesVarianceCurrent As Decimal
        Dim decSalesActualPrevious, decSalesProjectedPrevious, decSalesVariancePrevious As Decimal
        Dim decSalesLiveTotal, decSalesProjectedTotal, decSalesVarianceTotal As Decimal
        Dim intLabourAllowedCurrent, intLabourSchedCurrent, intLabourVarianceCurrent As Integer
        Dim intLabourAllowedPrevious, intLabourSchedPrevious, intLabourVariancePrevious As Integer
        Dim intLabourAllowedTotal, intLabourSchedTotal, intLabourVarianceTotal As Integer

        '''''Needs to be fixed for differing closing times
        If intHour > 21 Then                                            'If After 10pm then set to closing hour
            intHour = 30
        ElseIf intHour < 6 Then
            intHour = 30
        Else
            intHour = (intHour * 2) - 12                                'Calculate the whole hour
            If intMinute < 30 Then                                      'Add one for the half hours
                intHour -= 1
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
#If DEBUG Then
                        Debug.WriteLine("Live Period Sales: " & CStr(decLiveSalesArray(intRow)))
#End If
                    ElseIf intIndex = 5 Then
                        intIndex = 0
                    End If
                    intIndex += 1                                           'Move to the next field
                Next
                If intRow > intHour Then Exit While                         'If we are outside the open hours then jump out
            End While
        End Using



        'Let's Array Our Projected Sales from our SalesProjections.txt file
        Dim decProjectedSalesArray(48) As Decimal
        Dim strOpenHours(48) As String
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
                    If intIndex = 2 Then                                    'Load up daypart labels
                        strOpenHours(intRow) = CStr(currentField)
#If DEBUG Then
                        Debug.WriteLine("Graph Labels: " & strOpenHours(intRow))
#End If
                    End If
                    If intIndex = 3 Then                                    'Grab only the 3rd field (sales)
                        decProjectedSalesArray(intRow) = CDec(currentField) 'Put it into the array
                    End If
                    If intIndex = 3 Then                                    'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                           'Move to the next field
                Next
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
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide2.txt")
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
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide3.txt")
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
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide4.txt")
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
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\ManningGuide5.txt")
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
        Dim strSeriesLabelArray(48) As String                                           'Create Array for Chart labels
        Dim intIndex2 As Integer = 0
        For i = 0 To intTotalOpenPeriods ' - 1 Step 2                                     'Loop through the parts
            'strSeriesLabelArray(i) = CStr(Module1.intOpen + intIndex2) & ":00"          'Label the odd periods as on the hour
            'strSeriesLabelArray(i + 1) = CStr(Module1.intOpen + intIndex2) & ":30"      'Label the even periods as 30 after
            'intIndex2 += 1
            strSeriesLabelArray(i) = strOpenHours(i)
        Next
        For i = 0 To intHour
            'If i Mod 2 = 0 Then
            '     intTime = (i + (Module1.intOpen * 2)) * 50              'Convert loop to real time based on opening time
            'Else
            '   intTime = ((i + (Module1.intOpen * 2) - 1) * 50) + 30   'Adjust for half hours
            'End If

            intTime = CInt(strSeriesLabelArray(i))
            If intTime < Module1.DP1 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide1(j, 0) And decLiveSalesArray(i) < decManningGuide1(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide1(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP1 - 1 And intTime <= Module1.DP2 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide2(j, 0) And decLiveSalesArray(i) < decManningGuide2(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide2(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP2 - 1 And intTime <= Module1.DP3 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide3(j, 0) And decLiveSalesArray(i) < decManningGuide3(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide3(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP3 - 1 And intTime <= Module1.DP4 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide4(j, 0) And decLiveSalesArray(i) < decManningGuide4(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide4(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf intTime > Module1.DP4 - 1 And intTime <= Module1.DP5 Then
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
        Dashboard.SalesActualCurrent.Text = CStr(CInt(decSalesActualCurrent))                   'Display Current Actual Sales
        Dashboard.SalesProjectedCurrent.Text = CStr(CInt(decSalesProjectedCurrent))             'Display Current Projected Sales
        frmMiniDashboard.SalesActualCurrent.Text = CStr(CInt(decSalesActualCurrent))                   'Display Current Actual Sales
        frmMiniDashboard.SalesProjectedCurrent.Text = CStr(CInt(decSalesProjectedCurrent))             'Display Current Projected Sales
        If decSalesVarianceCurrent > 0 Then                                              'If Sales Variance is positive then make it green
            Dashboard.SalesVarianceCurrent.ForeColor = Color.LimeGreen
            Dashboard.SalesVarianceCurrent.Text = "+" & CStr(CInt(decSalesVarianceCurrent))     'Show a + sign if positive
            frmMiniDashboard.SalesVarianceCurrent.ForeColor = Color.LimeGreen
            frmMiniDashboard.SalesVarianceCurrent.Text = "+" & CStr(CInt(decSalesVarianceCurrent))     'Show a + sign if positive
        Else                                                                             'If sales Variance is negative then make it red
            Dashboard.SalesVarianceCurrent.ForeColor = Color.Red
            Dashboard.SalesVarianceCurrent.Text = CStr(CInt(decSalesVarianceCurrent))
            frmMiniDashboard.SalesVarianceCurrent.ForeColor = Color.Red
            frmMiniDashboard.SalesVarianceCurrent.Text = CStr(CInt(decSalesVarianceCurrent))
        End If
        'Previous Sales
        Dashboard.SalesActualPrevious.Text = CStr(CInt(decSalesActualPrevious))                 'Display Previous Actual Sales
        Dashboard.SalesProjectedPrevious.Text = CStr(CInt(decSalesProjectedPrevious))           'Display Previous Projected Sales
        frmMiniDashboard.SalesActualPrevious.Text = CStr(CInt(decSalesActualPrevious))                 'Display Previous Actual Sales
        frmMiniDashboard.SalesProjectedPrevious.Text = CStr(CInt(decSalesProjectedPrevious))           'Display Previous Projected Sales
        If decSalesVariancePrevious > 0 Then                                             'If Sales Variance is positive then make it green
            Dashboard.SalesVariancePrevious.ForeColor = Color.LimeGreen
            Dashboard.SalesVariancePrevious.Text = "+" & CStr(CInt(decSalesVariancePrevious))   'Show a + sign if positve
            frmMiniDashboard.SalesVariancePrevious.ForeColor = Color.LimeGreen
            frmMiniDashboard.SalesVariancePrevious.Text = "+" & CStr(CInt(decSalesVariancePrevious))   'Show a + sign if positve
        Else                                                                             'If sales Variance is negative then make it red
            Dashboard.SalesVariancePrevious.ForeColor = Color.Red
            Dashboard.SalesVariancePrevious.Text = CStr(CInt(decSalesVariancePrevious))
            frmMiniDashboard.SalesVariancePrevious.ForeColor = Color.Red
            frmMiniDashboard.SalesVariancePrevious.Text = CStr(CInt(decSalesVariancePrevious))
        End If
        'Daily Sales
        Dashboard.SalesActualDaily.Text = CStr(CInt(decSalesLiveTotal))                         'Display Actual Daily Sales So Far
        Dashboard.SalesProjectedDaily.Text = CStr(CInt(decSalesProjectedTotal))                 'Display Projected Daily Sales So Far
        frmMiniDashboard.SalesActualDaily.Text = CStr(CInt(decSalesLiveTotal))                         'Display Actual Daily Sales So Far
        frmMiniDashboard.SalesProjectedDaily.Text = CStr(CInt(decSalesProjectedTotal))                 'Display Projected Daily Sales So Far
        If decSalesVarianceTotal > 0 Then                                                'If Daily Sales Variance is positve then make it green
            Dashboard.SalesVarianceDaily.ForeColor = Color.LimeGreen
            Dashboard.SalesVarianceDaily.Text = "+" & CStr(CInt(decSalesVarianceTotal))         'Show a + sign if positive
            frmMiniDashboard.SalesVarianceDaily.ForeColor = Color.LimeGreen
            frmMiniDashboard.SalesVarianceDaily.Text = "+" & CStr(CInt(decSalesVarianceTotal))         'Show a + sign if positive
        Else                                                                             'If sales Variance is negative than zero then make it red
            Dashboard.SalesVarianceDaily.ForeColor = Color.Red
            Dashboard.SalesVarianceDaily.Text = CStr(CInt(decSalesVarianceTotal))
            frmMiniDashboard.SalesVarianceDaily.ForeColor = Color.Red
            frmMiniDashboard.SalesVarianceDaily.Text = CStr(CInt(decSalesVarianceTotal))
        End If
        If decSalesProjectedTotal > 0 Then
            Dim SalesPercent As Single = CSng((decSalesLiveTotal - decSalesProjectedTotal) / decSalesProjectedTotal)
            Dim FormattedSalesPercent As String = FormatPercent(SalesPercent)
            If SalesPercent < 0 Then
                Dashboard.txtSalesVariancePercentDaily.ForeColor = Color.Red
                frmMiniDashboard.txtSalesVariancePercentDaily.ForeColor = Color.Red
            ElseIf SalesPercent > 0 Then
                FormattedSalesPercent = "+" & FormattedSalesPercent
                Dashboard.txtSalesVariancePercentDaily.ForeColor = Color.LimeGreen
                frmMiniDashboard.txtSalesVariancePercentDaily.ForeColor = Color.LimeGreen
            Else
                Dashboard.txtSalesVariancePercentDaily.ForeColor = Color.Yellow
                frmMiniDashboard.txtSalesVariancePercentDaily.ForeColor = Color.Yellow
            End If
            Dashboard.txtSalesVariancePercentDaily.Text = FormattedSalesPercent
            frmMiniDashboard.txtSalesVariancePercentDaily.Text = FormattedSalesPercent
        Else
            Dashboard.txtSalesVariancePercentDaily.Text = "--"
            frmMiniDashboard.txtSalesVariancePercentDaily.Text = "--"
        End If


        Dashboard.txtFullDaySalesProjection.Text = CStr(CInt(decFullDaySalesProjection))
        frmMiniDashboard.txtFullDaySalesProjection.Text = CStr(CInt(decFullDaySalesProjection))


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
        Dashboard.LabourAllowedCurrent.Text = CStr(intLabourAllowedCurrent)                    'Display Current Allowed Labour
        Dashboard.LabourSchedCurrent.Text = CStr(intLabourSchedCurrent)                        'Display Current Scheduled Labour
        frmMiniDashboard.LabourAllowedCurrent.Text = CStr(intLabourAllowedCurrent)                    'Display Current Allowed Labour
        frmMiniDashboard.LabourSchedCurrent.Text = CStr(intLabourSchedCurrent)                        'Display Current Scheduled Labour
        If intLabourVarianceCurrent > 0 Then                                            'If Labour Variance is positive then make it red
            Dashboard.LabourVarianceCurrent.ForeColor = Color.Red
            Dashboard.LabourVarianceCurrent.Text = "+" & CStr(intLabourVarianceCurrent)        'Show a + sign if positive
            frmMiniDashboard.LabourVarianceCurrent.ForeColor = Color.Red
            frmMiniDashboard.LabourVarianceCurrent.Text = "+" & CStr(intLabourVarianceCurrent)        'Show a + sign if positive
        Else                                                                            'If Labour Variance is zero or negative then make it green
            Dashboard.LabourVarianceCurrent.ForeColor = Color.LimeGreen
            Dashboard.LabourVarianceCurrent.Text = CStr(intLabourVarianceCurrent)
            frmMiniDashboard.LabourVarianceCurrent.ForeColor = Color.LimeGreen
            frmMiniDashboard.LabourVarianceCurrent.Text = CStr(intLabourVarianceCurrent)
        End If
        'Previous Labour
        Dashboard.LabourAllowedPrevious.Text = CStr(intLabourAllowedPrevious)                  'Display Previous Allowed Labour
        Dashboard.LabourSchedPrevious.Text = CStr(intLabourSchedPrevious)                      'Display Previous Scheduled Labour
        frmMiniDashboard.LabourAllowedPrevious.Text = CStr(intLabourAllowedPrevious)                  'Display Previous Allowed Labour
        frmMiniDashboard.LabourSchedPrevious.Text = CStr(intLabourSchedPrevious)                      'Display Previous Scheduled Labour
        If intLabourVariancePrevious > 0 Then                                           'If Labour Variance is positive then make it red
            Dashboard.LabourVariancePrevious.ForeColor = Color.Red
            Dashboard.LabourVariancePrevious.Text = "+" & CStr(intLabourVariancePrevious)      'Show a + sign if positive
            frmMiniDashboard.LabourVariancePrevious.ForeColor = Color.Red
            frmMiniDashboard.LabourVariancePrevious.Text = "+" & CStr(intLabourVariancePrevious)      'Show a + sign if positive
        Else                                                                            'If Labour Variance is zero of negative then make it green
            Dashboard.LabourVariancePrevious.ForeColor = Color.LimeGreen
            Dashboard.LabourVariancePrevious.Text = CStr(intLabourVariancePrevious)
            frmMiniDashboard.LabourVariancePrevious.ForeColor = Color.LimeGreen
            frmMiniDashboard.LabourVariancePrevious.Text = CStr(intLabourVariancePrevious)
        End If
        'Daily Labour
        Dashboard.LabourAllowedDaily.Text = CStr(intLabourAllowedTotal)                        'Display Daily Allowed Labour so far
        Dashboard.LabourSchedDaily.Text = CStr(intLabourSchedTotal)                            'Display Daily Scheduled Labour so far
        frmMiniDashboard.LabourAllowedDaily.Text = CStr(intLabourAllowedTotal)                        'Display Daily Allowed Labour so far
        frmMiniDashboard.LabourSchedDaily.Text = CStr(intLabourSchedTotal)                            'Display Daily Scheduled Labour so far
        If intLabourVarianceTotal > 0 Then                                              'If Labour Variance is positive then make it red
            Dashboard.LabourVarianceDaily.ForeColor = Color.Red
            Dashboard.LabourVarianceDaily.Text = "+" & CStr(intLabourVarianceTotal)            'Show a + sign if positive
            frmMiniDashboard.LabourVarianceDaily.ForeColor = Color.Red
            frmMiniDashboard.LabourVarianceDaily.Text = "+" & CStr(intLabourVarianceTotal)            'Show a + sign if positive
        Else                                                                            'If sales Variance is zero or negative then make it green
            Dashboard.LabourVarianceDaily.ForeColor = Color.LimeGreen
            Dashboard.LabourVarianceDaily.Text = CStr(intLabourVarianceTotal)
            frmMiniDashboard.LabourVarianceDaily.ForeColor = Color.LimeGreen
            frmMiniDashboard.LabourVarianceDaily.Text = CStr(intLabourVarianceTotal)
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
        Dashboard.txtWeatherTemp.Text = strWeatherArray(0)                     'Display Temp
        Dashboard.txtWeatherFeelsLike.Text = strWeatherArray(1)                'Display Feels Like
        Dashboard.txtWeatherDescription.Text = strWeatherArray(2)              'Display Weather Description
        frmMiniDashboard.txtWeatherTemp.Text = strWeatherArray(0)                     'Display Temp
        frmMiniDashboard.txtWeatherFeelsLike.Text = strWeatherArray(1)                'Display Feels Like
        frmMiniDashboard.txtWeatherDescription.Text = strWeatherArray(2)              'Display Weather Description


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
            Dashboard.txtOSAT.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(8)) <= Module1.VOCRed Then
            Dashboard.txtOSAT.ForeColor = Color.Red
        Else Dashboard.txtOSAT.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(7)) = 0 Then
            Dashboard.txtZOD.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(7)) > 10 Then
            Dashboard.txtZOD.ForeColor = Color.Red
        Else Dashboard.txtZOD.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(2)) >= Module1.VOCGreen Then
            Dashboard.txtFriendly.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(2)) <= Module1.VOCRed Then
            Dashboard.txtFriendly.ForeColor = Color.Red
        Else Dashboard.txtFriendly.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(1)) >= Module1.VOCGreen Then
            Dashboard.txtClean.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(1)) <= Module1.VOCRed Then
            Dashboard.txtClean.ForeColor = Color.Red
        Else Dashboard.txtClean.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(3)) >= Module1.VOCGreen Then
            Dashboard.txtFast.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(3)) <= Module1.VOCRed Then
            Dashboard.txtFast.ForeColor = Color.Red
        Else Dashboard.txtFast.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(4)) >= Module1.VOCGreen Then
            Dashboard.txtAccurate.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(4)) <= Module1.VOCRed Then
            Dashboard.txtAccurate.ForeColor = Color.Red
        Else Dashboard.txtAccurate.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(5)) >= Module1.VOCGreen Then
            Dashboard.txtTaste.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(5)) <= Module1.VOCRed Then
            Dashboard.txtTaste.ForeColor = Color.Red
        Else Dashboard.txtTaste.ForeColor = Color.Yellow
        End If
        'Display the VOC data to the dashboard
        Dashboard.txtOSAT.Text = strVOCArray(8)                                'Display OSAT
        Dashboard.txtZOD.Text = strVOCArray(7)                                 'Display ZOD
        Dashboard.txtFriendly.Text = strVOCArray(2)                            'Display Friendly
        Dashboard.txtClean.Text = strVOCArray(1)                               'Display Clean
        Dashboard.txtFast.Text = strVOCArray(3)                                'Display Fast
        Dashboard.txtAccurate.Text = strVOCArray(4)                            'Display Accurate
        Dashboard.txtTaste.Text = strVOCArray(5)                               'Display Taste

        'Same but for the Mini Dashboard
        If CDec(strVOCArray(8)) >= Module1.VOCGreen Then
            frmMiniDashboard.txtOSAT.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(8)) <= Module1.VOCRed Then
            frmMiniDashboard.txtOSAT.ForeColor = Color.Red
        Else frmMiniDashboard.txtOSAT.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(7)) = 0 Then
            frmMiniDashboard.txtZOD.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(7)) > 10 Then
            frmMiniDashboard.txtZOD.ForeColor = Color.Red
        Else frmMiniDashboard.txtZOD.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(2)) >= Module1.VOCGreen Then
            frmMiniDashboard.txtFriendly.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(2)) <= Module1.VOCRed Then
            frmMiniDashboard.txtFriendly.ForeColor = Color.Red
        Else frmMiniDashboard.txtFriendly.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(1)) >= Module1.VOCGreen Then
            frmMiniDashboard.txtClean.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(1)) <= Module1.VOCRed Then
            frmMiniDashboard.txtClean.ForeColor = Color.Red
        Else frmMiniDashboard.txtClean.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(3)) >= Module1.VOCGreen Then
            frmMiniDashboard.txtFast.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(3)) <= Module1.VOCRed Then
            frmMiniDashboard.txtFast.ForeColor = Color.Red
        Else frmMiniDashboard.txtFast.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(4)) >= Module1.VOCGreen Then
            frmMiniDashboard.txtAccurate.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(4)) <= Module1.VOCRed Then
            frmMiniDashboard.txtAccurate.ForeColor = Color.Red
        Else frmMiniDashboard.txtAccurate.ForeColor = Color.Yellow
        End If
        If CDec(strVOCArray(5)) >= Module1.VOCGreen Then
            frmMiniDashboard.txtTaste.ForeColor = Color.LimeGreen
        ElseIf CDec(strVOCArray(5)) <= Module1.VOCRed Then
            frmMiniDashboard.txtTaste.ForeColor = Color.Red
        Else frmMiniDashboard.txtTaste.ForeColor = Color.Yellow
        End If
        'Display the VOC data to the dashboard
        frmMiniDashboard.txtOSAT.Text = strVOCArray(8)                                'Display OSAT
        frmMiniDashboard.txtZOD.Text = strVOCArray(7)                                 'Display ZOD
        frmMiniDashboard.txtFriendly.Text = strVOCArray(2)                            'Display Friendly
        frmMiniDashboard.txtClean.Text = strVOCArray(1)                               'Display Clean
        frmMiniDashboard.txtFast.Text = strVOCArray(3)                                'Display Fast
        frmMiniDashboard.txtAccurate.Text = strVOCArray(4)                            'Display Accurate
        frmMiniDashboard.txtTaste.Text = strVOCArray(5)                               'Display Taste

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
        If strDTArray(0) <> "for" Then
            'Set Up the DT Colours
            If CInt(strDTArray(0)) <= Module1.TTLGreen Then
                Dashboard.txtDayPartTTL.ForeColor = Color.LimeGreen
            ElseIf CInt(strDTArray(0)) >= Module1.TTLRed Then
                Dashboard.txtDayPartTTL.ForeColor = Color.Red
            Else
                Dashboard.txtDayPartTTL.ForeColor = Color.Yellow
            End If
            If CInt(strDTArray(2)) <= Module1.TTLGreen Then
                Dashboard.txtFullDayTTL.ForeColor = Color.LimeGreen
            ElseIf CInt(strDTArray(2)) >= Module1.TTLRed Then
                Dashboard.txtFullDayTTL.ForeColor = Color.Red
            Else
                Dashboard.txtFullDayTTL.ForeColor = Color.Yellow
            End If
            'Display The DT Data
            Dashboard.txtDayPartTTL.Text = strDTArray(0)
            Dashboard.txtDayPartCC.Text = strDTArray(1)
            Dashboard.txtFullDayTTL.Text = strDTArray(2)
        End If
        If strDTArray(0) <> "for" Then
            'Set Up the DT Colours
            If CInt(strDTArray(0)) <= Module1.TTLGreen Then
                frmMiniDashboard.txtDayPartTTL.ForeColor = Color.LimeGreen
            ElseIf CInt(strDTArray(0)) >= Module1.TTLRed Then
                frmMiniDashboard.txtDayPartTTL.ForeColor = Color.Red
            Else
                frmMiniDashboard.txtDayPartTTL.ForeColor = Color.Yellow
            End If
            If CInt(strDTArray(2)) <= Module1.TTLGreen Then
                frmMiniDashboard.txtFullDayTTL.ForeColor = Color.LimeGreen
            ElseIf CInt(strDTArray(2)) >= Module1.TTLRed Then
                frmMiniDashboard.txtFullDayTTL.ForeColor = Color.Red
            Else
                frmMiniDashboard.txtFullDayTTL.ForeColor = Color.Yellow
            End If
            'Display The DT Data
            frmMiniDashboard.txtDayPartTTL.Text = strDTArray(0)
            frmMiniDashboard.txtDayPartCC.Text = strDTArray(1)
            frmMiniDashboard.txtFullDayTTL.Text = strDTArray(2)
        End If

        'Update Charts
        'Set Open and Close Times
        Module1.intOpen = CInt(strConfigArray(0))                                       'Open Time
        Module1.intClose = CInt(strConfigArray(1))                                      'Close Time

        'strSeriesLabelArray(intTotalOpenPeriods) = CStr(Module1.intClose) & ":00"
        Dashboard.chrtSalesChart.Series(0).Points.Clear()                                         'Clear all projected sales data points
        Dashboard.chrtSalesChart.Series(1).Points.Clear()                                         'Clear all live sales data point
        Dashboard.chrtLabourChart.Series(0).Points.Clear()                                        'Clear all allowed labour data point
        Dashboard.chrtLabourChart.Series(1).Points.Clear()                                        'Clear all scheduled labour data points
        For i = 0 To intTotalOpenPeriods - 1
            Dashboard.chrtLabourChart.Series(1).Points.AddXY(i, intSchedLabourArray(i))           'Plot Scheduled labour data points
            Dashboard.chrtSalesChart.Series(0).Points.AddXY(i, decProjectedSalesArray(i))         'Plot projected sales data points
            Dashboard.chrtLabourChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)      'Label the X-Axis
            Dashboard.chrtSalesChart.Series(0).Points(i).AxisLabel = strSeriesLabelArray(i)       'Label the X-Axis
        Next
        For i = 0 To intHour
            Dashboard.chrtLabourChart.Series(0).Points.AddXY(i, intAllowedLabourArray(i))         'Plot Allowed labour data point
            Dashboard.chrtSalesChart.Series(1).Points.AddXY(i, CInt(decLiveSalesArray(i)))        'Plot Live sales data points
        Next
        'strSeriesLabelArray(intTotalOpenPeriods) = CStr(Module1.intClose) & ":00"
        frmMiniDashboard.chrtSalesChart.Series(0).Points.Clear()                                         'Clear all projected sales data points
        frmMiniDashboard.chrtSalesChart.Series(1).Points.Clear()                                         'Clear all live sales data point
        frmMiniDashboard.chrtLabourChart.Series(0).Points.Clear()                                        'Clear all allowed labour data point
        frmMiniDashboard.chrtLabourChart.Series(1).Points.Clear()                                        'Clear all scheduled labour data points
        For i = 0 To intTotalOpenPeriods - 1
            frmMiniDashboard.chrtLabourChart.Series(1).Points.AddXY(i, intSchedLabourArray(i))           'Plot Scheduled labour data points
            frmMiniDashboard.chrtSalesChart.Series(0).Points.AddXY(i, decProjectedSalesArray(i))         'Plot projected sales data points
            frmMiniDashboard.chrtLabourChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)      'Label the X-Axis
            frmMiniDashboard.chrtSalesChart.Series(0).Points(i).AxisLabel = strSeriesLabelArray(i)       'Label the X-Axis
        Next
        For i = 0 To intHour
            frmMiniDashboard.chrtLabourChart.Series(0).Points.AddXY(i, intAllowedLabourArray(i))         'Plot Allowed labour data point
            frmMiniDashboard.chrtSalesChart.Series(1).Points.AddXY(i, CInt(decLiveSalesArray(i)))        'Plot Live sales data points
        Next

        'UpdateStatusInfo
        Dim strStatus As String
        intTime = (CInt(DateTime.Now.Hour) * 100) + CInt(DateTime.Now.Minute)           'Calculate current time as HHmm
        If CInt(DateTime.Now.Hour) >= Module1.intClose Then                             'If current time is after close then
            strStatus = "Closed"
        Else
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
            ElseIf intTime > Module1.DP5 And intTime < Module1.DP6 Then
                strStatus = "6558 - DP6"
            Else
                strStatus = "CLOSED"
            End If
        End If
        Dashboard.txtStatus.Text = strStatus
        frmMiniDashboard.txtStatus.Text = strStatus

        'Output Data.txt file for webpage to update
        Dim strComputerName As String = Environment.MachineName.ToString()  'Get Machine Name

        Dim strDataOutput As String = ""                                    'Clean Data Output Array
        If strComputerName = "DESKTOP-NIH3L5I" Then                         'If we are The Front Line Display then
            Dim strFileName As String = "C:\Wendys\Data.txt"                'This is the file location and name
            If System.IO.File.Exists(strFileName) = True Then               'See if file exists
                System.IO.File.Delete(strFileName)                          'If it does exist then delete it
            End If
            'Build Output file
            strData(0) = CStr(CInt(decSalesLiveTotal))          'Live Sales Total so far
            strData(2) = CStr(CInt(decSalesProjectedTotal))     'Projected Sales Total so far
            strData(1) = CStr(CInt(decSalesVarianceTotal))      'Sales Variance Total so far
            strData(3) = CStr(intLabourAllowedTotal)            'Allowed Labour Total so far
            strData(4) = CStr(intLabourSchedTotal)              'Scheduled Labour Total so far
            strData(5) = CStr(intLabourVarianceTotal)           'Labour Variance Total so far
            strData(6) = CStr(CInt(decSalesActualCurrent))      'Current Actual Sales
            strData(7) = CStr(CInt(decSalesProjectedCurrent))   'Current Projected Sales
            strData(8) = CStr(CInt(decSalesVarianceCurrent))    'Current Sales Variance
            strData(9) = CStr(CInt(decSalesActualPrevious))     'Previous Actual Sales
            strData(10) = CStr(CInt(decSalesProjectedPrevious)) 'Previous Projected Sales
            strData(11) = CStr(CInt(decSalesVariancePrevious))  'Previous Sales Variance
            strData(12) = CStr(intLabourAllowedCurrent)         'Current Allowed Labour
            strData(15) = CStr(intLabourAllowedPrevious)        'Previous Allowed Labour
            strData(13) = CStr(intLabourSchedCurrent)           'Current Scheduled Labour
            strData(16) = CStr(intLabourSchedPrevious)          'Previous Scheduled Labour
            strData(14) = CStr(intLabourVarianceCurrent)        'Current Labour Variance
            strData(17) = CStr(intLabourVariancePrevious)       'Previous Labour Variance
            strDataOutput = strData(0)                              'Start with first value
            For i = 1 To 17                                         'Loop through all data
                strDataOutput = strDataOutput & "," & strData(i)    'Add on susequent data values to make CSV file
            Next
            Dim file As System.IO.StreamWriter                                  'Open StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(strFileName, True) 'Create File
            file.WriteLine(strDataOutput)                                       'Put data values into file
            file.Close()
        End If
        With Dashboard.timerUpdate
            .Interval = 60000
            .Enabled = True
        End With
        With frmMiniDashboard.timerUpdate
            .Interval = 60000
            .Enabled = True
        End With
#If DEBUG Then
        Stopwatch.Stop()
        Debug.WriteLine("CurrentTime: " & Dashboard.txtClock.Text)
        Debug.WriteLine("Machine Name: " & strComputerName)
        Debug.WriteLine("Time Taken: " & Stopwatch.Elapsed.ToString)
#End If
    End Sub

End Module
