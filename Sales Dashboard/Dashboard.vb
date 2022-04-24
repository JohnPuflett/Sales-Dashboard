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
        Dim decSalesActualTotal, decSalesProjectedTotal, decSalesVarianceTotal As Decimal
        intHour = (intHour * 2) - 14
        If intMinute > 29 Then
            intHour += 1
        End If

        'Let's Array Our Live Sales from our LiveSales.txt file and Grab Our Current Sales Using Our Calculated Current intHour
        Dim decLiveSalesArray(34) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\LiveSales.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intTotalSales As Integer
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                             'Move to the next line
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    If intIndex = 3 Then                                'Grab only the 3rd field (sales)
                        decLiveSalesArray(intRow) = CDec(currentField)  'Put it into the array
                        intTotalSales += CInt(currentField)             'Add it to the running sales total
                    End If
                    If intIndex = 5 Then                                'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                       'Move to the next field
                Next
            End While
        End Using

        'Let's Array Our Projected Sales from our SalesProjections.txt file and Grab Our Current Sales Using Our Calculated Current intHour
        Dim decProjectedSalesArray(34) As Decimal
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\wendys\SalesProjections.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited         'Set file as delimited
            MyReader.SetDelimiters(",")                                 'Set Delimiter as ,
            Dim currentRow As String()
            Dim intTotalProjectedSales As Integer
            Dim intIndex As Integer = 1
            Dim intRow As Integer = -1
            While Not MyReader.EndOfData                                'Cycle Through Each Line of the LiveSales.txt file
                intRow += 1                                             'Move to the next line
                currentRow = MyReader.ReadFields()                      'Read the fields in that line
                Dim currentField As String
                For Each currentField In currentRow                     'Cycle through each field on this line
                    If intIndex = 3 Then                                'Grab only the 3rd field (sales)
                        decProjectedSalesArray(intRow) = CDec(currentField)  'Put it into the array
                        intTotalProjectedSales += CInt(currentField)             'Add it to the running sales total
                    End If
                    If intIndex = 3 Then                                'If end of line then go back to field 1
                        intIndex = 0
                    End If
                    intIndex += 1                                       'Move to the next field
                Next
            End While
        End Using



        decSalesActualCurrent = decLiveSalesArray(intHour)                          'Populate Actual Sales Current from Array
        decSalesProjectedCurrent = decProjectedSalesArray(intHour)                  'Populate Projected Sales Current from Array
        decSalesVarianceCurrent = decSalesActualCurrent - decSalesProjectedCurrent  'Calculate Sales Variance Current

        decSalesActualPrevious = decLiveSalesArray(intHour - 1)                         'Populate Actual Sales Previous From Array
        decSalesProjectedPrevious = decProjectedSalesArray(intHour - 1)                 'Populate Projected Sales Previous From Array
        decSalesVariancePrevious = decSalesActualPrevious - decSalesProjectedPrevious   'Calculate Sales Variance Previous

        Me.SalesActualCurrent.Text = CStr(decSalesActualCurrent)                    'Display Actual Sales
        Me.SalesProjectedCurrent.Text = CStr(decSalesProjectedCurrent)              'Display Projected Sales
        If decSalesVarianceCurrent > 0 Then                                         'If Sales Variance is greater than zero then make it green
            Me.SalesVarianceCurrent.ForeColor = Color.LimeGreen
            Me.SalesVarianceCurrent.Text = "+" & CStr(decSalesVarianceCurrent)
        Else                                                                        'If sales Variance is not greater than zero then make it red
            Me.SalesVarianceCurrent.ForeColor = Color.Red
            Me.SalesVarianceCurrent.Text = CStr(decSalesVarianceCurrent)
        End If

        Me.SalesActualPrevious.Text = CStr(decSalesActualPrevious)                  'Display Actual Sales
        Me.SalesProjectedPrevious.Text = CStr(decSalesProjectedPrevious)            'Display Projected Sales
        If decSalesVariancePrevious > 0 Then                                        'If Sales Variance is greater than zero then make it green
            Me.SalesVariancePrevious.ForeColor = Color.LimeGreen
            Me.SalesVariancePrevious.Text = "+" & CStr(decSalesVariancePrevious)
        Else                                                                        'If sales Variance is not greater than zero then make it red
            Me.SalesVariancePrevious.ForeColor = Color.Red
            Me.SalesVariancePrevious.Text = CStr(decSalesVariancePrevious)
        End If

    End Sub
End Class
