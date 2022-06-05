Module Master
    Public Sub Doit()
        On Error Resume Next
#If DEBUG Then
        Dim Stopwatch As New Stopwatch
        Stopwatch.Start()
#End If
        Dim myForm As Form
        If Dashboard.Visible = True Then
            myForm = Dashboard
        Else
            myForm = frmMiniDashboard
        End If
        ''''myForm.Controls("timerUpdate").Enabled = False
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
            strSeriesLabelArray(i) = strOpenHours(i)
        Next
        For i = 0 To intHour
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
        With myForm
            .Controls("SalesActualCurrent").Text = CStr(CInt(decSalesActualCurrent))                   'Display Current Actual Sales
            .Controls("SalesProjectedCurrent").Text = CStr(CInt(decSalesProjectedCurrent))                   'Display Current Actual Sales
            If decSalesVarianceCurrent > 0 Then                                              'If Sales Variance is positive then make it green
                .Controls("SalesVarianceCurrent").ForeColor = Color.LimeGreen
                .Controls("SalesVarianceCurrent").Text = "+" & CStr(CInt(decSalesVarianceCurrent))     'Show a + sign if positive
            Else                                                                             'If sales Variance is negative then make it red
                .Controls("SalesVarianceCurrent").ForeColor = Color.Red
                .Controls("SalesVarianceCurrent").Text = CStr(CInt(decSalesVarianceCurrent))
            End If
            'Previous Sales
            .Controls("SalesActualPrevious").Text = CStr(CInt(decSalesActualPrevious))                 'Display Previous Actual Sales
            .Controls("SalesProjectedPrevious").Text = CStr(CInt(decSalesProjectedPrevious))           'Display Previous Projected Sales
            If decSalesVariancePrevious > 0 Then                                             'If Sales Variance is positive then make it green
                .Controls("SalesVariancePrevious").ForeColor = Color.LimeGreen
                .Controls("SalesVariancePrevious").Text = "+" & CStr(CInt(decSalesVariancePrevious))   'Show a + sign if positve
            Else                                                                             'If sales Variance is negative then make it red
                .Controls("SalesVariancePrevious").ForeColor = Color.Red
                .Controls("SalesVariancePrevious").Text = CStr(CInt(decSalesVariancePrevious))
            End If
            'Daily Sales
            .Controls("SalesActualDaily").Text = CStr(CInt(decSalesLiveTotal))                         'Display Actual Daily Sales So Far
            .Controls("SalesProjectedDaily").Text = CStr(CInt(decSalesProjectedTotal))                 'Display Projected Daily Sales So Far
            If decSalesVarianceTotal > 0 Then                                                'If Daily Sales Variance is positve then make it green
                .Controls("SalesVarianceDaily").ForeColor = Color.LimeGreen
                .Controls("SalesVarianceDaily").Text = "+" & CStr(CInt(decSalesVarianceTotal))         'Show a + sign if positive
            Else                                                                             'If sales Variance is negative than zero then make it red
                .Controls("SalesVarianceDaily").ForeColor = Color.Red
                .Controls("SalesVarianceDaily").Text = CStr(CInt(decSalesVarianceTotal))
            End If
            If decSalesProjectedTotal > 0 Then
                Dim SalesPercent As Single = CSng((decSalesLiveTotal - decSalesProjectedTotal) / decSalesProjectedTotal)
                Dim FormattedSalesPercent As String = FormatPercent(SalesPercent)
                If SalesPercent < 0 Then
                    .Controls("txtSalesVariancePercentDaily").ForeColor = Color.Red
                ElseIf SalesPercent > 0 Then
                    FormattedSalesPercent = "+" & FormattedSalesPercent
                    .Controls("txtSalesVariancePercentDaily").ForeColor = Color.LimeGreen
                Else
                    .Controls("txtSalesVariancePercentDaily").ForeColor = Color.Yellow
                End If
                .Controls("txtSalesVariancePercentDaily").Text = FormattedSalesPercent
            Else
                .Controls("txtSalesVariancePercentDaily").Text = "--"
            End If
            .Controls("txtFullDaySalesProjection").Text = CStr(CInt(decFullDaySalesProjection))


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
            .Controls("LabourAllowedCurrent").Text = CStr(intLabourAllowedCurrent)                    'Display Current Allowed Labour
            .Controls("LabourSchedCurrent").Text = CStr(intLabourSchedCurrent)                        'Display Current Scheduled Labour
            If intLabourVarianceCurrent > 0 Then                                            'If Labour Variance is positive then make it red
                .Controls("LabourVarianceCurrent").ForeColor = Color.Red
                .Controls("LabourVarianceCurrent").Text = "+" & CStr(intLabourVarianceCurrent)        'Show a + sign if positive
            Else                                                                            'If Labour Variance is zero or negative then make it green
                .Controls("LabourVarianceCurrent").ForeColor = Color.LimeGreen
                .Controls("LabourVarianceCurrent").Text = CStr(intLabourVarianceCurrent)
            End If
            'Previous Labour
            .Controls("LabourAllowedPrevious").Text = CStr(intLabourAllowedPrevious)                  'Display Previous Allowed Labour
            .Controls("LabourSchedPrevious").Text = CStr(intLabourSchedPrevious)                      'Display Previous Scheduled Labour
            If intLabourVariancePrevious > 0 Then                                           'If Labour Variance is positive then make it red
                .Controls("LabourVariancePrevious").ForeColor = Color.Red
                .Controls("LabourVariancePrevious").Text = "+" & CStr(intLabourVariancePrevious)      'Show a + sign if positive
            Else                                                                            'If Labour Variance is zero of negative then make it green
                .Controls("LabourVariancePrevious").ForeColor = Color.LimeGreen
                .Controls("LabourVariancePrevious").Text = CStr(intLabourVariancePrevious)
            End If
            'Daily Labour
            .Controls("LabourAllowedDaily").Text = CStr(intLabourAllowedTotal)                        'Display Daily Allowed Labour so far
            .Controls("LabourSchedDaily").Text = CStr(intLabourSchedTotal)                            'Display Daily Scheduled Labour so far
            If intLabourVarianceTotal > 0 Then                                              'If Labour Variance is positive then make it red
                .Controls("LabourVarianceDaily").ForeColor = Color.Red
                .Controls("LabourVarianceDaily").Text = "+" & CStr(intLabourVarianceTotal)            'Show a + sign if positive
            Else                                                                            'If sales Variance is zero or negative then make it green
                .Controls("LabourVarianceDaily").ForeColor = Color.LimeGreen
                .Controls("LabourVarianceDaily").Text = CStr(intLabourVarianceTotal)
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
            .Controls("txtWeatherTemp").Text = strWeatherArray(0)                     'Display Temp
            .Controls("txtWeatherFeelsLike").Text = strWeatherArray(1)                'Display Feels Like
            .Controls("txtWeatherDescription").Text = strWeatherArray(2)              'Display Weather Description

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
                .Controls("txtOSAT").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(8)) <= Module1.VOCRed Then
                .Controls("txtOSAT").ForeColor = Color.Red
            Else .Controls("txtOSAT").ForeColor = Color.Yellow
            End If
            If CDec(strVOCArray(7)) = 0 Then
                .Controls("txtZOD").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(7)) > 10 Then
                .Controls("txtZOD").ForeColor = Color.Red
            Else .Controls("txtZOD").ForeColor = Color.Yellow
            End If
            If CDec(strVOCArray(2)) >= Module1.VOCGreen Then
                .Controls("txtFriendly").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(2)) <= Module1.VOCRed Then
                .Controls("txtFriendly").ForeColor = Color.Red
            Else .Controls("txtFriendly").ForeColor = Color.Yellow
            End If
            If CDec(strVOCArray(1)) >= Module1.VOCGreen Then
                .Controls("txtClean").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(1)) <= Module1.VOCRed Then
                .Controls("txtClean").ForeColor = Color.Red
            Else .Controls("txtClean").ForeColor = Color.Yellow
            End If
            If CDec(strVOCArray(3)) >= Module1.VOCGreen Then
                .Controls("txtFast").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(3)) <= Module1.VOCRed Then
                .Controls("txtFast").ForeColor = Color.Red
            Else .Controls("txtFast").ForeColor = Color.Yellow
            End If
            If CDec(strVOCArray(4)) >= Module1.VOCGreen Then
                .Controls("txtAccurate").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(4)) <= Module1.VOCRed Then
                .Controls("txtAccurate").ForeColor = Color.Red
            Else .Controls("txtAccurate").ForeColor = Color.Yellow
            End If
            If CDec(strVOCArray(5)) >= Module1.VOCGreen Then
                .Controls("txtTaste").ForeColor = Color.LimeGreen
            ElseIf CDec(strVOCArray(5)) <= Module1.VOCRed Then
                .Controls("txtTaste").ForeColor = Color.Red
            Else .Controls("txtTaste").ForeColor = Color.Yellow
            End If
            'Display the VOC data to the dashboard
            .Controls("txtOSAT").Text = strVOCArray(8)                                'Display OSAT
            .Controls("txtZOD").Text = strVOCArray(7)                                 'Display ZOD
            .Controls("txtFriendly").Text = strVOCArray(2)                            'Display Friendly
            .Controls("txtClean").Text = strVOCArray(1)                               'Display Clean
            .Controls("txtFast").Text = strVOCArray(3)                                'Display Fast
            .Controls("txtAccurate").Text = strVOCArray(4)                            'Display Accurate
            .Controls("txtTaste").Text = strVOCArray(5)                               'Display Taste


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
                    .Controls("txtDayPartTTL").ForeColor = Color.LimeGreen
                ElseIf CInt(strDTArray(0)) >= Module1.TTLRed Then
                    .Controls("txtDayPartTTL").ForeColor = Color.Red
                Else
                    .Controls("txtDayPartTTL").ForeColor = Color.Yellow
                End If
                If CInt(strDTArray(2)) <= Module1.TTLGreen Then
                    .Controls("txtFullDayTTL").ForeColor = Color.LimeGreen
                ElseIf CInt(strDTArray(2)) >= Module1.TTLRed Then
                    .Controls("txtFullDayTTL").ForeColor = Color.Red
                Else
                    .Controls("txtFullDayTTL").ForeColor = Color.Yellow
                End If
                'Display The DT Data
                .Controls("txtDayPartTTL").Text = strDTArray(0)
                .Controls("txtDayPartCC").Text = strDTArray(1)
                .Controls("txtFullDayTTL").Text = strDTArray(2)
            End If
        End With

        'Update Charts
        'Set Open and Close Times
        Module1.intOpen = CInt(strConfigArray(0))                                       'Open Time
        Module1.intClose = CInt(strConfigArray(1))                                      'Close Time

        With Dashboard
            .chrtSalesChart.Series(0).Points.Clear()                                         'Clear all projected sales data points
            .chrtSalesChart.Series(1).Points.Clear()                                         'Clear all live sales data point
            .chrtLabourChart.Series(0).Points.Clear()                                        'Clear all allowed labour data point
            .chrtLabourChart.Series(1).Points.Clear()                                        'Clear all scheduled labour data points
            For i = 0 To intTotalOpenPeriods - 1
                .chrtLabourChart.Series(1).Points.AddXY(i, intSchedLabourArray(i))           'Plot Scheduled labour data points
                .chrtSalesChart.Series(0).Points.AddXY(i, decProjectedSalesArray(i))         'Plot projected sales data points
                .chrtLabourChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)      'Label the X-Axis
                .chrtSalesChart.Series(0).Points(i).AxisLabel = strSeriesLabelArray(i)       'Label the X-Axis
            Next
            For i = 0 To intHour
                .chrtLabourChart.Series(0).Points.AddXY(i, intAllowedLabourArray(i))         'Plot Allowed labour data point
                .chrtSalesChart.Series(1).Points.AddXY(i, CInt(decLiveSalesArray(i)))        'Plot Live sales data points
            Next
        End With
        With frmMiniDashboard
            .chrtSalesChart.Series(0).Points.Clear()                                         'Clear all projected sales data points
            .chrtSalesChart.Series(1).Points.Clear()                                         'Clear all live sales data point
            .chrtLabourChart.Series(0).Points.Clear()                                        'Clear all allowed labour data point
            .chrtLabourChart.Series(1).Points.Clear()                                        'Clear all scheduled labour data points
            For i = 0 To intTotalOpenPeriods - 1
                .chrtLabourChart.Series(1).Points.AddXY(i, intSchedLabourArray(i))           'Plot Scheduled labour data points
                .chrtSalesChart.Series(0).Points.AddXY(i, decProjectedSalesArray(i))         'Plot projected sales data points
                .chrtLabourChart.Series(1).Points(i).AxisLabel = strSeriesLabelArray(i)      'Label the X-Axis
                .chrtSalesChart.Series(0).Points(i).AxisLabel = strSeriesLabelArray(i)       'Label the X-Axis
            Next
            For i = 0 To intHour
                .chrtLabourChart.Series(0).Points.AddXY(i, intAllowedLabourArray(i))         'Plot Allowed labour data point
                .chrtSalesChart.Series(1).Points.AddXY(i, CInt(decLiveSalesArray(i)))        'Plot Live sales data points
            Next
        End With
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

#If DEBUG Then
        Stopwatch.Stop()
        Debug.WriteLine("CurrentTime: " & Dashboard.txtClock.Text)
        Debug.WriteLine("Machine Name: " & strComputerName)
        Debug.WriteLine("Time Taken: " & Stopwatch.Elapsed.ToString)
#End If
    End Sub

End Module
