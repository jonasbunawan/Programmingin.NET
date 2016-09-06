' Title:    INF20013 Business Systems Programming in .NET - Assignment1 - Financial Management Application
' Due Date: Monday, 25th August 2014 08:30 AM
' Author:   2084236 - Fei
'           700513X - Jonas Bunawan

Imports System.IO
Public Class Form1

    Dim vcCommaFile As String = "C:\temp\A1-2084236\CommaFile.txt"
    Dim vcTabFile As String = "C:\temp\A1-2084236\TabFile.txt"
    Dim vcFixedFile As String = "C:\temp\A1-2084236\FixedFile.txt"
    Dim vcRanFile As String = "C:\temp\A1-2084236\RanFile.ran"
    Dim vcEncryptFile As String = "C:\temp\A1-2084236\EncryptFile.txt"
    Dim vcBinaryFile As String = "C:\temp\A1-2084236\BinaryFile.txt"

    'Event Handler to save deposit data that is made by user and update transaction history
    Private Sub DepositSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles DepositSaveButton.Click
        SavingFormattedDepositData()
        HistoryUpdate()
    End Sub

    'Event handler to show saved data to user
    Private Sub WithdrawShowDataButton_Click(sender As System.Object, e As System.EventArgs) Handles WithdrawShowDataButton.Click
        ShowData()
    End Sub

    'Event handler to save withdrawal data on a file and update file statistics for user acknowledgement
    Private Sub WithdrawSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles WithdrawSaveButton.Click
        UpdateFileStatistics()
        SavingFormattedWithdrawalData()
    End Sub

    'To save and format Deposit Data to desired files
    Sub SavingFormattedDepositData()
        Dim rtvTransaction As New FinancialDetails
        rtvTransaction.TransactionType = "Deposit"
        rtvTransaction.TransactionDate = DepositDateTimePicker.Value.ToShortDateString
        rtvTransaction.TransactionNumber = Val(DepositTransactionNumberTextBox.Text)
        rtvTransaction.Source = DepositSourceTextBox.Text
        rtvTransaction.Memo = DepositMemoTextBox.Text
        rtvTransaction.Amount = Val(DepositAmountTextBox.Text)

        Dim vZoneFormat As String

        Dim rvSW As StreamWriter
        Dim rvBW As BinaryWriter

        If DepositCommaFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcCommaFile, True)
            rvSW.WriteLine(rtvTransaction.TransactionType & "," & rtvTransaction.TransactionDate & "," & rtvTransaction.TransactionNumber & "," & rtvTransaction.Source & "," & rtvTransaction.Memo & "," & rtvTransaction.Amount)
            rvSW.Flush()
            rvSW.Close()
        End If

        If DepositTabFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcTabFile, True)
            rvSW.WriteLine(rtvTransaction.TransactionType & Chr(9) & rtvTransaction.TransactionDate & Chr(9) & rtvTransaction.TransactionNumber & Chr(9) & rtvTransaction.Source & Chr(9) & rtvTransaction.Memo & Chr(9) & rtvTransaction.Amount)
            rvSW.Flush()
            rvSW.Close()
        End If

        If DepositFixedFileRadioButton.Checked Then
            vZoneFormat = "{0, 8}{1, 15}{2, 3}{3, 30}{4, 200}{5, 8}"
            rvSW = New StreamWriter(vcFixedFile, True)
            rvSW.WriteLine(String.Format(vZoneFormat, rtvTransaction.TransactionType, DepositDateTimePicker.Value.ToShortDateString, rtvTransaction.TransactionNumber, rtvTransaction.Source, rtvTransaction.Memo, rtvTransaction.Amount))
            rvSW.Flush()
            rvSW.Close()
        End If

        If DepositRandomFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcRanFile, True)
            rvSW.WriteLine(rtvTransaction.TransactionType & ":" & rtvTransaction.TransactionDate & ":" & rtvTransaction.TransactionNumber & ";" & rtvTransaction.Source & ":" & rtvTransaction.Memo & ";" & rtvTransaction.Amount)
            rvSW.Flush()
            rvSW.Close()
        End If

        If DepositEncryptFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcEncryptFile, True)
            rvSW.WriteLine(Encryption(rtvTransaction.TransactionType) & "," & Encryption(rtvTransaction.TransactionDate) & "," & Encryption(rtvTransaction.TransactionNumber) & "," & Encryption(rtvTransaction.Source) & "," & Encryption(rtvTransaction.Memo) & "," & Encryption(rtvTransaction.Amount))
            rvSW.Flush()
            rvSW.Close()
        End If

        If DepositBinaryFileRadioButton.Checked Then
            rvBW = New BinaryWriter(New FileStream(vcBinaryFile, FileMode.Append))
            rvBW.Write(rtvTransaction.TransactionType & rtvTransaction.TransactionDate & rtvTransaction.TransactionNumber & rtvTransaction.Source & rtvTransaction.Memo & "AUD" & rtvTransaction.Amount)
            rvBW.Write(vbCrLf)
            rvBW.Flush()
            rvBW.Close()
        End If
    End Sub

    'A Sub procedure to update Transaction history details
    Sub HistoryUpdate()
        Dim vMessage As String = "Transaction History" & vbCrLf & vbCrLf
        Dim vCommaFileRecords As Integer = CountRecords(vcCommaFile)
        Dim vTabFileRecords As Integer = CountRecords(vcTabFile)
        Dim vFixedFileRecords As Integer = CountRecords(vcFixedFile)
        Dim vRandomFileRecords As Integer = CountRecords(vcRanFile)
        Dim vEncryptFileRecords As Integer = CountRecords(vcEncryptFile)
        Dim vBinaryFileRecords As Integer = CountRecords(vcBinaryFile)
        Dim vTotalRecords As Integer = vCommaFileRecords + vFixedFileRecords + vTabFileRecords + vRandomFileRecords + vEncryptFileRecords + vBinaryFileRecords
        Dim vTotalFileswithRecords As Integer

        If vCommaFileRecords > 0 Then
            vTotalFileswithRecords += 1
        End If

        If vTabFileRecords > 0 Then
            vTotalFileswithRecords += 1
        End If

        If vFixedFileRecords > 0 Then
            vTotalFileswithRecords += 1
        End If

        If vRandomFileRecords > 0 Then
            vTotalFileswithRecords += 1
        End If

        If vEncryptFileRecords > 0 Then
            vTotalFileswithRecords += 1
        End If

        If vBinaryFileRecords > 0 Then
            vTotalFileswithRecords += 1
        End If

        vMessage &= vCommaFileRecords & " Records in COMMA File" & vbCrLf &
                    vTabFileRecords & " Records in TAB File" & vbCrLf &
                    vFixedFileRecords & " Records in FIXED File" & vbCrLf &
                    vRandomFileRecords & " Records in RANDOM File" & vbCrLf &
                    vEncryptFileRecords & " Records in ENCRYPT File" & vbCrLf &
                    vBinaryFileRecords & " Records in BINARY File" & vbCrLf & vbCrLf &
                    "Total of " & vTotalRecords & " Records are saved in " & vTotalFileswithRecords & " Type(s) of Files"

        DepositTransactionHistoryGroupBox.Text = vMessage
    End Sub

    'ShowData Sub Procedure that contains the code to show saved data to the user
    Sub ShowData()
        Dim vString() As String
        Dim vFixedString As String
        Dim vSeparator() As String = {";", ":"}

        Dim rvSR As StreamReader
        Dim rvBR As BinaryReader

        If WithdrawDataListBox.Items.Count > 0 Then
            WithdrawDataListBox.Items.Clear()
        End If

        If WithdrawCommaFileRadioButton.Checked Then
            rvSR = New StreamReader(vcCommaFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(",")
                WithdrawDataListBox.Items.Add(vString(1) & "- " & vString(0) & " From " & vString(3) & " - Amount AU$" & vString(5))
            Loop
            rvSR.Close()
        End If

        If WithdrawTabFileRadioButton.Checked Then
            rvSR = New StreamReader(vcTabFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(Chr(9))
                WithdrawDataListBox.Items.Add(vString(1) & "- " & vString(0) & " From " & vString(3) & " - Amount AU$" & vString(5))
            Loop
            rvSR.Close()
        End If

        If WithdrawFixedFileRadioButton.Checked Then
            rvSR = New StreamReader(vcFixedFile)
            Do While rvSR.Peek <> -1
                vFixedString = rvSR.ReadLine().ToString
                WithdrawDataListBox.Items.Add(vFixedString.Substring(8, 15) & "- " & vFixedString.Substring(0, 8) & " From " & vFixedString.Substring(26, 30) & " - Amount AU$" & vFixedString.Substring(256, 8))
            Loop
            rvSR.Close()
        End If

        If WithdrawRandomFileRadioButton.Checked Then
            rvSR = New StreamReader(vcRanFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(vSeparator, StringSplitOptions.None)
                WithdrawDataListBox.Items.Add(vString(1) & "- " & vString(0) & " From " & vString(3) & " - Amount AU$" & vString(5))
            Loop
            rvSR.Close()
        End If

        If WithdrawEncryptFileRadioButton.Checked Then
            rvSR = New StreamReader(vcEncryptFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(",")
                WithdrawDataListBox.Items.Add(Decryption(vString(1)) & "- " & Decryption(vString(0)) & " From " & Decryption(vString(3)) & " - Amount AU$" & Decryption(vString(5)))
            Loop
            rvSR.Close()
        End If

        If WithdrawBinaryFileRadioButton.Checked Then
            rvBR = New BinaryReader(New FileStream(vcBinaryFile, FileMode.Open))
            Do While rvBR.PeekChar <> -1
                WithdrawDataListBox.Items.Add(rvBR.ReadString)
            Loop
            rvBR.Close()
        End If
    End Sub

    'A Sub Procedure to save and format withdrawal data onto a file
    Sub SavingFormattedWithdrawalData()
        Dim rtvTransaction As New FinancialDetails
        rtvTransaction.TransactionType = "Withdraw"
        rtvTransaction.TransactionDate = WithdrawDateTimePicker.Value.ToShortDateString
        rtvTransaction.TransactionNumber = Val(WithdrawTransactionNumberTextBox.Text)
        rtvTransaction.Destination = WithdrawDestinationTextBox.Text
        rtvTransaction.Memo = WithdrawMemoTextBox.Text
        rtvTransaction.Amount = Val(WithdrawAmountTextBox.Text)

        Dim vZoneFormat As String

        Dim rvSW As StreamWriter
        Dim rvBW As BinaryWriter

        If WithdrawCommaFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcCommaFile, True)
            rvSW.WriteLine(rtvTransaction.TransactionType & "," & rtvTransaction.TransactionDate & "," & rtvTransaction.TransactionNumber & "," & rtvTransaction.Destination & "," & rtvTransaction.Memo & "," & rtvTransaction.Amount)
            rvSW.Flush()
            rvSW.Close()
        End If

        If WithdrawTabFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcTabFile, True)
            rvSW.WriteLine(rtvTransaction.TransactionType & Chr(9) & rtvTransaction.TransactionDate & Chr(9) & rtvTransaction.TransactionNumber & Chr(9) & rtvTransaction.Destination & Chr(9) & rtvTransaction.Memo & Chr(9) & rtvTransaction.Amount)
            rvSW.Flush()
            rvSW.Close()
        End If

        If WithdrawFixedFileRadioButton.Checked Then
            vZoneFormat = "{0, 8}{1, 15}{2, 3}{3, 30}{4, 200}{5, 8}"
            rvSW = New StreamWriter(vcFixedFile, True)
            rvSW.WriteLine(String.Format(vZoneFormat, rtvTransaction.TransactionType, WithdrawDateTimePicker.Value.ToShortDateString, rtvTransaction.TransactionNumber, rtvTransaction.Destination, rtvTransaction.Memo, rtvTransaction.Amount))
            rvSW.Flush()
            rvSW.Close()
        End If

        If WithdrawRandomFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcRanFile, True)
            rvSW.WriteLine(rtvTransaction.TransactionType & ":" & rtvTransaction.TransactionDate & ":" & rtvTransaction.TransactionNumber & ";" & rtvTransaction.Destination & ":" & rtvTransaction.Memo & ";" & rtvTransaction.Amount)
            rvSW.Flush()
            rvSW.Close()
        End If

        If WithdrawEncryptFileRadioButton.Checked Then
            rvSW = New StreamWriter(vcEncryptFile, True)
            rvSW.WriteLine(Encryption(rtvTransaction.TransactionType) & "," & Encryption(rtvTransaction.TransactionDate) & "," & Encryption(rtvTransaction.TransactionNumber) & "," & Encryption(rtvTransaction.Destination) & "," & Encryption(rtvTransaction.Memo) & "," & Encryption(rtvTransaction.Amount))
            rvSW.Flush()
            rvSW.Close()
        End If

        If WithdrawBinaryFileRadioButton.Checked Then
            rvBW = New BinaryWriter(New FileStream(vcBinaryFile, FileMode.Append))
            rvBW.Write(rtvTransaction.TransactionType & rtvTransaction.TransactionDate & rtvTransaction.TransactionNumber & rtvTransaction.Destination & rtvTransaction.Memo & "AUD" & rtvTransaction.Amount)
            rvBW.Write(vbCrLf)
            rvBW.Flush()
            rvBW.Close()
        End If
    End Sub

    'A sub procedure to be called when user clicks Save button on Withdraw Transaction screen. It shows the chosen file statistics to the user.
    Sub UpdateFileStatistics()
        Dim vFileName As String = ""
        Dim vRecords As Integer
        Dim vTotal As Integer = 0
        Dim vString() As String
        Dim vBinaryString As String = ""
        Dim vFixedString As String
        Dim vBalance As Integer
        Dim vMessage As String = "File Statistics" & vbCrLf & vbCrLf
        Dim vSeparator() As String = {";", ":"}
        Dim vAmount As Integer

        Dim rvSR As StreamReader
        Dim rvBR As BinaryReader

        Dim rtvTransactionDetails As New FinancialDetails
        rtvTransactionDetails.Amount = Val(WithdrawAmountTextBox.Text)
        
        If WithdrawCommaFileRadioButton.Checked Then
            rvSR = New StreamReader(vcCommaFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(",")
                If vString(0) = "Withdraw" Then
                    vTotal -= Val(vString(5))
                Else
                    vTotal += Val(vString(5))
                End If
            Loop
            rvSR.Close()

            vFileName = vcCommaFile.Substring(19)
            vRecords = CountRecords(vcCommaFile)
            vBalance = vTotal - Val(rtvTransactionDetails.Amount)
        End If

        If WithdrawTabFileRadioButton.Checked Then
            rvSR = New StreamReader(vcTabFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(Chr(9))
                If vString(0) = "Withdraw" Then
                    vTotal -= Val(vString(5))
                Else
                    vTotal += Val(vString(5))
                End If
            Loop
            rvSR.Close()

            vFileName = vcTabFile.Substring(19)
            vRecords = CountRecords(vcTabFile)
            vBalance = vTotal - rtvTransactionDetails.Amount
        End If

        If WithdrawFixedFileRadioButton.Checked Then
            rvSR = New StreamReader(vcFixedFile)
            Do While rvSR.Peek <> -1
                vFixedString = rvSR.ReadLine().ToString
                If vFixedString.Substring(0, 8) = "Withdraw" Then
                    vTotal -= Val(vFixedString.Substring(256, 8))
                Else
                    vTotal += Val(vFixedString.Substring(256, 8))
                End If
            Loop
            rvSR.Close()

            vFileName = vcFixedFile.Substring(19)
            vRecords = CountRecords(vcFixedFile)
            vBalance = vTotal - rtvTransactionDetails.Amount
        End If

        If WithdrawRandomFileRadioButton.Checked Then
            rvSR = New StreamReader(vcRanFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(vSeparator, StringSplitOptions.None)
                If vString(0) = "Withdraw" Then
                    vTotal -= Val(vString(5))
                Else
                    vTotal += Val(vString(5))
                End If
            Loop
            rvSR.Close()

            vFileName = vcRanFile.Substring(19)
            vRecords = CountRecords(vcRanFile)
            vBalance = vTotal - rtvTransactionDetails.Amount
        End If

        If WithdrawEncryptFileRadioButton.Checked Then
            rvSR = New StreamReader(vcEncryptFile)
            Do While rvSR.Peek <> -1
                vString = rvSR.ReadLine().Split(",")
                If vString(0) = "Withdraw" Then
                    vTotal -= Val(Decryption(vString(5)))
                Else
                    vTotal += Val(Decryption(vString(5)))
                End If
            Loop
            rvSR.Close()

            vFileName = vcEncryptFile.Substring(19)
            vRecords = CountRecords(vcEncryptFile)
            vBalance = vTotal - rtvTransactionDetails.Amount
        End If

        If WithdrawBinaryFileRadioButton.Checked Then
            rvBR = New BinaryReader(New FileStream(vcBinaryFile, FileMode.Open))
            Do While rvBR.PeekChar <> -1
                vBinaryString = rvBR.ReadString.ToString
                vAmount = Val(vBinaryString.Substring((vBinaryString.IndexOf("AUD") + 3)))
                If vBinaryString.StartsWith("Withdraw") Then
                    vTotal -= vAmount
                Else
                    vTotal += vAmount
                End If
            Loop
            rvBR.Close()

            vFileName = vcBinaryFile.Substring(19)
            vRecords = CountRecords(vcBinaryFile)
            vBalance = vTotal - rtvTransactionDetails.Amount
        End If

        vMessage &= "File Name = " & vFileName & vbCrLf &
                    "No. of Records = " & vRecords & vbCrLf &
                    "Total of " & vRecords & " Records (AUD) = " & vTotal & vbCrLf & vbCrLf &
                    "Balance (AUD) = " & vBalance

        WithdrawFileStatisticsGroupBox.Text = vMessage
    End Sub


    'A CountRecords function to count recorded data on a file
    Function CountRecords(ByVal vFileName As String)
        Dim vCount As Integer

        Dim rvSR As New StreamReader(vFileName)

        Do While rvSR.Peek <> -1
            rvSR.ReadLine()
            vCount += 1
        Loop
        rvSR.Close()

        Return vCount
    End Function

    'An Encryption function to manipulate/encrypt data so that saved data is more secure
    Function Encryption(ByVal vEncryptee As String)
        Dim vResult As String = ""

        For vIndex As Integer = 0 To vEncryptee.Length - 1 Step 2
            vResult &= Chr(Asc(vEncryptee(vIndex)) - 1)
        Next

        For vIndex As Integer = 1 To vEncryptee.Length - 1 Step 2
            vResult = vResult.Insert(vIndex, Chr(Asc(vEncryptee(vIndex)) + 1))
        Next

        Return vResult
    End Function

    'A Decryption function to manipulate/decrypt data that is encrypted earlier on the same format so that saved data is more secure
    Function Decryption(ByVal vDecryptee As String)
        Dim vResult As String = ""

        For vIndex As Integer = 0 To vDecryptee.Length - 1 Step 2
            vResult &= Chr(Asc(vDecryptee(vIndex)) + 1)
        Next

        For vIndex As Integer = 1 To vDecryptee.Length - 1 Step 2
            vResult = vResult.Insert(vIndex, Chr(Asc(vDecryptee(vIndex)) - 1))
        Next

        Return vResult
    End Function
End Class
