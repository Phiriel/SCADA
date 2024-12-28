Imports AdvancedHMIControls

Public Class MainForm

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "C:\Users\phili\source\repos\SCADA\DataLog.csv"
        IO.File.WriteAllText(filePath, String.Empty)
    End Sub

    Private Sub LogToCSV(timestamp As DateTime, voltage As String, current As String, breakerStatus As String)
        Try
            ' Define the CSV file path
            Dim filePath As String = "C:\Users\phili\source\repos\SCADA\DataLog.csv"
            Debug.WriteLine($"Logging Data - Timestamp: {timestamp}, Voltage: {voltage}, Current: {current}, BreakerStatus: {breakerStatus}")

            ' Check if the file exists, if not, create it with a header
            If Not IO.File.Exists(filePath) Then
                IO.File.WriteAllText(filePath, "Timestamp,Voltage,Current,BreakerStatus" & Environment.NewLine)
            End If

            ' Format the log entry, leaving blank fields where data is not available
            Dim logEntry As String = $"{timestamp},{voltage},{current},{breakerStatus}"

            ' Append the data to the CSV file
            IO.File.AppendAllText(filePath, logEntry & Environment.NewLine)

        Catch ex As Exception
            ' Handle errors gracefully
            Debug.WriteLine("Error writing to CSV: " & ex.Message)
        End Try
    End Sub

    ' Temporary storage for values
    Private VoltageValue As String = ""
    Private CurrentValue As String = ""
    Private BreakerStatusValue As String = ""

    ' DataSubscriber for Voltage (40001)
    Private Sub DataSubscriber1_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber1.DataChanged
        Try
            If e.Values.Count > 0 Then
                VoltageValue = e.Values(0)
                Debug.WriteLine("Voltage Updated: " & VoltageValue)
                WriteToCSVIfComplete()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error in DataSubscriber1: " & ex.Message)
        End Try
    End Sub

    ' DataSubscriber for Current (40002)
    Private Sub DataSubscriber2_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber2.DataChanged
        Try
            If e.Values.Count > 0 Then
                CurrentValue = e.Values(0)
                Debug.WriteLine("Current Updated: " & CurrentValue)
                WriteToCSVIfComplete()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error in DataSubscriber2: " & ex.Message)
        End Try
    End Sub

    ' DataSubscriber for Breaker Status (40003)
    Private Sub DataSubscriber3_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber3.DataChanged
        Try
            If e.Values.Count > 0 Then
                BreakerStatusValue = e.Values(0)
                Debug.WriteLine("Breaker Status Updated: " & BreakerStatusValue)
                WriteToCSVIfComplete()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error in DataSubscriber3: " & ex.Message)
        End Try
    End Sub

    ' Function to log data only when all fields are updated
    Private Sub WriteToCSVIfComplete()
        If Not String.IsNullOrEmpty(VoltageValue) AndAlso Not String.IsNullOrEmpty(CurrentValue) AndAlso Not String.IsNullOrEmpty(BreakerStatusValue) Then
            LogToCSV(DateTime.Now, VoltageValue, CurrentValue, BreakerStatusValue)

            ' Reset temporary storage for the next set of updates
            VoltageValue = ""
            CurrentValue = ""
            BreakerStatusValue = ""
        End If
    End Sub


End Class