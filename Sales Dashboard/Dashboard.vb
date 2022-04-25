Imports System.IO

Public Class Dashboard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        'Where are we on the list -
        Dim intHour As Integer = CInt(DateTime.Now.Hour)
        Dim intMinute As Integer = CInt(DateTime.Now.Minute)
        Dim decSalesActualCurrent, decSalesProjectedCurrent, decSalesVarianceCurrent As Decimal
        Dim decSalesActualPrevious, decSalesProjectedPrevious, decSalesVariancePrevious As Decimal
        Dim decSalesLiveTotal, decSalesProjectedTotal, decSalesVarianceTotal As Decimal
        Dim intLabourAllowedCurrent, intLabourSchedCurrent, intLabourVarianceCurrent As Integer
        Dim intLabourAllowedPrevious, intLabourSchedPrevious, intLabourVariancePrevious As Integer
        Dim intLabourAllowedTotal, intLabourSchedTotal, intLabourVarianceTotal As Integer

        intHour = (intHour * 2) - 14
        If intMinute > 29 Then
            intHour += 1
        End If

        'Let's Array Our Live Sales from our LiveSales.txt file and Calculate Our Current Daily Sales
        Dim decLiveSalesArray(34) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\LiveSales.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                             'Move to the next line
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    If intIndex = 3 Then                                'Grab only the 3rd field (sales)
                        decLiveSalesArray(intRow) = CDec(currentField)  'Put it into the array
                    End If
                    If intIndex = 5 Then                                'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                       'Move to the next field
                Next
                If intRow > intHour Then Exit While
            End While
        End Using



        'Let's Array Our Projected Sales from our SalesProjections.txt file
        Dim decProjectedSalesArray(34) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\SalesProjections.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            decSalesProjectedTotal = 0
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                             'Move to the next line
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    If intIndex = 3 Then                                'Grab only the 3rd field (sales)
                        decProjectedSalesArray(intRow) = CDec(currentField)  'Put it into the array
                    End If
                    If intIndex = 3 Then                                'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                       'Move to the next field
                Next
                If intRow > intHour Then Exit While
            End While
        End Using



        'Let's Array Our Scheduled Labour from our SchedLabour.txt
        Dim intSchedLabourArray(34) As Integer
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\SchedLabour.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                             'Move to the next line
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    If intIndex = 3 Then                                'Grab only the 2nd field (sched hours)
                        intSchedLabourArray(intRow) = CInt(currentField)  'Put it into the array
                    End If
                    If intIndex = 3 Then                                'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                       'Move to the next field
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
        'Next with DP2,3
        Dim decManningGuide23(13, 3) As Decimal
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
                    decManningGuide23(i, intIndex) = CDec(currentField) 'Populate our 3d Array Line i, Field intIndex
                    If intIndex = 2 Then                                'If end of line then reset back to the beginning
                        intIndex = -1
                    End If
                Next                                                    'Next Field
            Next                                                        'Next Row
        End Using
        'Next with DP4,5
        Dim decManningGuide45(13, 3) As Decimal
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
                    decManningGuide45(i, intIndex) = CDec(currentField) 'Populate our 3d Array Line i, Field intIndex
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
        Dim intAllowedLabourArray(30)
        For i = 0 To intHour
            If i < 8 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide1(j, 0) And decLiveSalesArray(i) < decManningGuide1(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide1(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf i > 7 And i < 19 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide23(j, 0) And decLiveSalesArray(i) < decManningGuide23(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide23(j, 2))
                        Exit For
                    End If
                Next j
            ElseIf i > 18 And i < 31 Then
                For j = 0 To 12
                    If decLiveSalesArray(i) > decManningGuide45(j, 0) And decLiveSalesArray(i) < decManningGuide45(j, 1) Then
                        intAllowedLabourArray(i) = CInt(decManningGuide45(j, 2))
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

        'Lets Sum it All Up
        For i = 0 To intHour - 1
            decSalesLiveTotal += decLiveSalesArray(i)
            decSalesProjectedTotal += decProjectedSalesArray(i)
            intLabourAllowedTotal += intAllowedLabourArray(i)
            intLabourSchedTotal += intSchedLabourArray(i)
        Next


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
        Me.SalesActualCurrent.Text = CStr(CInt(decSalesActualCurrent))                        'Display Current Actual Sales
        Me.SalesProjectedCurrent.Text = CStr(CInt(decSalesProjectedCurrent))                  'Display Current Projected Sales
        If decSalesVarianceCurrent > 0 Then                                             'If Sales Variance is positive then make it green
            Me.SalesVarianceCurrent.ForeColor = Color.LimeGreen
            Me.SalesVarianceCurrent.Text = "+" & CStr(CInt(decSalesVarianceCurrent))          'Show a + sign if positive
        Else                                                                            'If sales Variance is negative then make it red
            Me.SalesVarianceCurrent.ForeColor = Color.Red
            Me.SalesVarianceCurrent.Text = CStr(CInt(decSalesVarianceCurrent))
        End If
        'Previous Sales
        Me.SalesActualPrevious.Text = CStr(CInt(decSalesActualPrevious))                      'Display Previous Actual Sales
        Me.SalesProjectedPrevious.Text = CStr(CInt(decSalesProjectedPrevious))                'Display Previous Projected Sales
        If decSalesVariancePrevious > 0 Then                                            'If Sales Variance is positive then make it green
            Me.SalesVariancePrevious.ForeColor = Color.LimeGreen
            Me.SalesVariancePrevious.Text = "+" & CStr(CInt(decSalesVariancePrevious))        'Show a + sign if positve
        Else                                                                            'If sales Variance is negative then make it red
            Me.SalesVariancePrevious.ForeColor = Color.Red
            Me.SalesVariancePrevious.Text = CStr(CInt(decSalesVariancePrevious))
        End If
        'Daily Sales
        Me.SalesActualDaily.Text = CStr(CInt(decSalesLiveTotal))                              'Display Actual Daily Sales So Far
        Me.SalesProjectedDaily.Text = CStr(CInt(decSalesProjectedTotal))                      'Display Projected Daily Sales So Far
        If decSalesVarianceTotal > 0 Then                                               'If Daily Sales Variance is positve then make it green
            Me.SalesVarianceDaily.ForeColor = Color.LimeGreen
            Me.SalesVarianceDaily.Text = "+" & CStr(CInt(decSalesVarianceTotal))              'Show a + sign if positive
        Else                                                                            'If sales Variance is negative than zero then make it red
            Me.SalesVarianceDaily.ForeColor = Color.Red
            Me.SalesVarianceDaily.Text = CStr(CInt(decSalesVarianceTotal))
        End If



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

    End Sub
End Class
