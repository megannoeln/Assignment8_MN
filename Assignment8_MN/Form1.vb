Public Class frmRainfall
    'Megan Noel
    'IT 102
    'Assignment 9

    'This application gathers rainfall data from the user and then displays some statistics




    'declare class level variables and array
    Dim dblRainfall(11) As Double
    Dim strMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Dim strSeason() As String = {"Winter", "Winter", "Spring", "Spring", "Spring", "Summer", "Summer", "Summer", "Fall", "Fall", "Fall", "Winter"}

    Dim strMaximumMonth As String
    Dim strMinimumMonth As String

    Dim dblSeasonRainfall As Double

    'call procedure to get rainfall data
    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Load_Rainfall()

    End Sub


    'Get rainfall data for each month and display each one in list box
    Private Sub Load_Rainfall()
        Dim strAmount As String
        Dim strInputMonth As String
        Dim blnOk As Boolean
        Dim intIndex As Integer

        For intIndex = 0 To dblRainfall.Length - 1
            strInputMonth = strMonth(intIndex)
            blnOk = False

            Do Until blnOk = True
                strAmount = InputBox("Please enter rainfall for " & strInputMonth)
                If Double.TryParse(strAmount, dblRainfall(intIndex)) Then
                    If dblRainfall(intIndex) > 0 Then
                        lstRainfallData.Items.Add("Rainfall for " & strInputMonth & " is " & dblRainfall(intIndex) & " inches")
                        blnOk = True
                    Else
                        MessageBox.Show("Rainfall must be greater than 0")
                    End If
                Else
                    MessageBox.Show("Please enter a numeric value for rainfall")
                End If
            Loop

        Next

        btnGetData.Enabled = False
        btnDisplay.Enabled = True
    End Sub




    'close program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    'call functions for statistics calculations and display
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim dblTotal As Double
        Dim dblMaximum As Double
        Dim dblMinimum As Double
        Dim dblAverage As Double
        Dim strMaxRainfallSeason As String

        strMaxRainfallSeason = GetSeason()
        dblTotal = GetTotal()
        dblMaximum = GetMaximum()
        dblMinimum = GetMinimum()
        dblAverage = GetAverage()

        Call DisplayTotals(dblTotal, dblMaximum, strMaximumMonth, dblMinimum, strMinimumMonth, dblAverage, strMaxRainfallSeason)
    End Sub

    'get season and its rainfall total
    Private Function GetSeason()
        Dim dblWinterRain As Double
        Dim dblSpringRain As Double
        Dim dblSummerRain As Double
        Dim dblFallRain As Double
        Dim intIndex As Integer
        Dim strMaxRainfallSeason As String

        For intIndex = 0 To dblRainfall.Length - 1
            If strSeason(intIndex) = "Winter" Then
                dblWinterRain += dblRainfall(intIndex)
            Else
                If strSeason(intIndex) = "Spring" Then
                    dblSpringRain += dblRainfall(intIndex)
                Else
                    If strSeason(intIndex) = "Summer" Then
                        dblSummerRain += dblRainfall(intIndex)
                    Else
                        If strSeason(intIndex) = "Fall" Then
                            dblFallRain += dblRainfall(intIndex)
                        End If
                    End If
                End If
            End If
        Next

        Dim dblMax As Double

        If dblWinterRain > dblMax Then
            strMaxRainfallSeason = "Winter"
            dblMax = dblWinterRain
            dblSeasonRainfall = dblWinterRain
        End If

        If dblSpringRain > dblMax Then
            strMaxRainfallSeason = "Spring"
            dblMax = dblSpringRain
            dblSeasonRainfall = dblSpringRain
        End If

        If dblSummerRain > dblMax Then
            strMaxRainfallSeason = "Summer"
            dblMax = dblSummerRain
            dblSeasonRainfall = dblSummerRain
        End If

        If dblFallRain > dblMax Then
            strMaxRainfallSeason = "Fall"
            dblMax = dblFallRain
            dblSeasonRainfall = dblFallRain
        End If

        Return strMaxRainfallSeason
    End Function




    'function to get total rainfall
    Private Function GetTotal() As Double
        Dim dblTotal As Double
        Dim intIndex As Integer

        For intIndex = 0 To dblRainfall.Length - 1
            dblTotal += dblRainfall(intIndex)
        Next
        Return dblTotal
    End Function

    'function to get maximum rainfall
    Private Function GetMaximum()
        Dim dblMaximum As Double
        Dim intIndex As Integer

        For intIndex = 0 To dblRainfall.Length - 1
            If dblRainfall(intIndex) > dblMaximum Then
                dblMaximum = dblRainfall(intIndex)
                strMaximumMonth = strMonth(intIndex)
            End If
        Next
        Return dblMaximum
    End Function

    'function to get minimum rainfall
    Private Function GetMinimum() As Double
        Dim dblMinimum As Double = 1000
        Dim intIndex As Integer

        For intIndex = 0 To dblRainfall.Length - 1
            If dblRainfall(intIndex) < dblMinimum Then
                dblMinimum = dblRainfall(intIndex)
                strMinimumMonth = strMonth(intIndex)
            End If
        Next
        Return dblMinimum
    End Function


    'function to get average rainfall
    Private Function GetAverage() As Double
        Dim dblTotal As Double
        Dim dblAverage As Double

        dblTotal = GetTotal()
        dblAverage = dblTotal / dblRainfall.Length
        Return dblAverage

    End Function

    'procedure to display statistiscs
    Private Sub DisplayTotals(ByVal dblTotal As Double, ByVal dblMaximum As Double, ByVal strMaximumMonth As String, ByVal dblMinimum As Double, ByVal strMinimumMonth As String, ByVal dblAverage As Double, ByVal strMaxRainfallSeason As String)
        lstStatistics.Items.Add("The total rainfall for the year is " & dblTotal & " inches")
        lstStatistics.Items.Add("The maximum rainfall is " & dblMaximum & " inches" & " during " & strMaximumMonth)
        lstStatistics.Items.Add("The minimum rainfall is " & dblMinimum & " inches" & " during " & strMinimumMonth)
        lstStatistics.Items.Add("The average rainfall for the year is " & Math.Round(dblAverage, 2) & " inches")
        lstStatistics.Items.Add("The season with the most rainfall was " & strMaxRainfallSeason & " with " & dblSeasonRainfall & " inches")
    End Sub


End Class
