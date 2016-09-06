' Title:    INF20013 Business Systems Programming in .NET - Assignment1 - Financial Management Application
' Due Date: Monday, 25th August 2014 08:30 AM
' Author:   2084236 - Fei
'           700513X - Jonas Bunawan

Imports System.IO
Public Class MainMenu

    Private Sub ProceedingButton_Click(sender As System.Object, e As System.EventArgs) Handles ProceedingButton.Click
        Dim rvForm As New Form1
        DirectoryFilesCreation()

        rvForm.ShowDialog()
        rvForm = Nothing

        Me.Close()
    End Sub

    'The following sub procedure contains the code to structurize the directory and files that are needed to run the application. It will be called once a ProceddingButton, which takes user to the next step (Transaction Placement - Deposit/Withdraw), is clicked.
    Sub DirectoryFilesCreation()
        Dim vDirectory As String = "C:\temp\A1-2084236"
        Dim vCommaFile As FileStream
        Dim vTabFile As FileStream
        Dim vFixedFile As FileStream
        Dim vRanFile As FileStream
        Dim vEncryptFile As FileStream
        Dim vBinaryFile As FileStream

        If Directory.Exists(vDirectory) = False Then
            Directory.CreateDirectory(vDirectory)
        End If

        If File.Exists("C:\temp\A1-2084236\CommaFile.txt") = True Then
            File.Delete("C:\temp\A1-2084236\CommaFile.txt")
            vCommaFile = File.Create("C:\temp\A1-2084236\CommaFile.txt")
            vCommaFile.Close()
        Else
            vCommaFile = File.Create("C:\temp\A1-2084236\CommaFile.txt")
            vCommaFile.Close()
        End If

        If File.Exists("C:\temp\A1-2084236\TabFile.txt") = True Then
            File.Delete("C:\temp\A1-2084236\TabFile.txt")
            vTabFile = File.Create("C:\temp\A1-2084236\TabFile.txt")
            vTabFile.Close()
        Else
            vTabFile = File.Create("C:\temp\A1-2084236\TabFile.txt")
            vTabFile.Close()
        End If

        If File.Exists("C:\temp\A1-2084236\FixedFile.txt") = True Then
            File.Delete("C:\temp\A1-2084236\FixedFile.txt")
            vFixedFile = File.Create("C:\temp\A1-2084236\FixedFile.txt")
            vFixedFile.Close()
        Else
            vFixedFile = File.Create("C:\temp\A1-2084236\FixedFile.txt")
            vFixedFile.Close()
        End If

        If File.Exists("C:\temp\A1-2084236\RanFile.ran") = True Then
            File.Delete("C:\temp\A1-2084236\RanFile.ran")
            vRanFile = File.Create("C:\temp\A1-2084236\RanFile.ran")
            vRanFile.Close()
        Else
            vRanFile = File.Create("C:\temp\A1-2084236\RanFile.ran")
            vRanFile.Close()
        End If

        If File.Exists("C:\temp\A1-2084236\EncryptFile.txt") = True Then
            File.Delete("C:\temp\A1-2084236\EncryptFile.txt")
            vEncryptFile = File.Create("C:\temp\A1-2084236\EncryptFile.txt")
            vEncryptFile.Close()
        Else
            vEncryptFile = File.Create("C:\temp\A1-2084236\EncryptFile.txt")
            vEncryptFile.Close()
        End If

        If File.Exists("C:\temp\A1-2084236\BinaryFile.txt") = True Then
            File.Delete("C:\temp\A1-2084236\BinaryFile.txt")
            vBinaryFile = File.Create("C:\temp\A1-2084236\BinaryFile.txt")
            vBinaryFile.Close()
        Else
            vBinaryFile = File.Create("C:\temp\A1-2084236\BinaryFile.txt")
            vBinaryFile.Close()
        End If
    End Sub
End Class