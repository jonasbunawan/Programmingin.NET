Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class Form1
    Dim vcDir As String = "C:\Temp\INF20013_A03_T006\"
    Dim vcDataFile As String = "Ass3.accdb"
    Dim vcLogFile As String = "Log.TXT"
    Dim vcStuDumpFile As String = "STUDUMP.TXT"
    Dim vcExcelFile As String = "Students.xls"
    Dim vcTransactionCount As Integer = 0

    Dim vcConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 vcDir & vcDataFile

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Directory.Exists(vcDir) = False Then
            Directory.CreateDirectory(vcDir)
        End If
        DatabaseSetup()
    End Sub

    Sub DatabaseSetup()
        Dim vSQLStudentTableStr As String = "Create Table STUDENT(" & _
                                "  StuID            CHAR(4)     Primary Key" & _
                                ", Name             CHAR(50)" & _
                                ", SubjectsPassed   Integer);"
        Dim vSQLUnitTableStr As String = "Create Table UNIT(" & _
                                "  UnitCode         CHAR(7)     Primary Key" & _
                                ", Title            CHAR(30));"
        Dim vSQLResultTableStr As String = "Create Table RESULT(" & _
                                "  StuID            CHAR(4)     " & _
                                ", UnitCode         CHAR(7)     " & _
                                ", Grade            Integer" & _
                                ", CONSTRAINT PK_Result PRIMARY KEY(StuID, UnitCode));"

        If File.Exists(vcDir & vcDataFile) = False Then
            CreateAccessDatabase(vcDir & vcDataFile)
            CreateAccessTable(vSQLStudentTableStr, vcDir & vcDataFile)
            CreateAccessTable(vSQLUnitTableStr, vcDir & vcDataFile)
            CreateAccessTable(vSQLResultTableStr, vcDir & vcDataFile)
        End If
    End Sub

    Public Function CreateAccessDatabase( _
    ByVal pDatabaseFullPath As String) As Boolean
        Dim vBoolean As Boolean
        Dim rtvCat As New ADOX.Catalog()
        Try


            'Make sure the folder
            'provided in the path exists. If file name w/o path 
            'is  specified,  the database will be created in your
            'application folder.

            Dim sCreateString As String
            sCreateString = _
              "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
               pDatabaseFullPath
            rtvCat.Create(sCreateString)

            vBoolean = True

        Catch Excep As System.Runtime.InteropServices.COMException
            vBoolean = False
            'do whatever else you need to do here, log, 
            'msgbox etc.
        Finally
            rtvCat = Nothing
        End Try
        Return vBoolean
    End Function
    'DEMO
    '      If CreateAccessDatabase("F:\test.mdb") = True Then
    '           MsgBox("Database Created")
    '      Else
    '           MsgBox("Database Creation Failed")
    '      End If

    Public Function CreateAccessTable(ByVal pCreateTableStr As String, ByVal pDatabasePath As String) As Boolean
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvSQLConnection As New OleDbConnection
        Dim rtvSQLCommand As New OleDbCommand
        Dim vBoolean As Boolean

        Try
            rtvSQLConnection.ConnectionString = vConnStr
            rtvSQLCommand.Connection = rtvSQLConnection
            rtvSQLCommand.CommandText = pCreateTableStr
            rtvSQLConnection.Open()
            rtvSQLCommand.ExecuteNonQuery()
            vBoolean = True
        Catch ex As Exception
            vBoolean = False
        Finally
            rtvSQLConnection.Close()
        End Try
        Return vBoolean
    End Function

    Private Sub Task3RestoretoDefault_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task3RestoretoDefault_Btn.Click
        RestoreToDefault()
    End Sub

    Sub RestoreToDefault()
        ClearTable("STUDENT")
        AddSTUDENTData("S009", "Adam Appleby", 0)
        AddSTUDENTData("S082", "Brenda Bignal", 0)
        AddSTUDENTData("S215", "Carol Carlott", 0)
        AddSTUDENTData("S307", "David Dongle", 0)
        AddSTUDENTData("S312", "Emma Evans", 0)
        AddSTUDENTData("S445", "Fred Fosters", 0)

        ClearTable("UNIT")
        AddUnitData("U101", "Intro Programming")
        AddUnitData("U102", "Intro Database")
        AddUnitData("U103", "Intro Networking")
        AddUnitData("U104", "Intro to Web Development")
        AddUnitData("U105", "Advanced Programming")
        AddUnitData("U106", "Advanced Database")
        AddUnitData("U107", "Advanced Networking")
        AddUnitData("U108", "Advanced to Web Development")

        ClearTable("RESULT")
        If File.Exists(vcDir & vcLogFile) Then
            File.Delete(vcDir & vcLogFile)
        End If
    End Sub

    Sub ClearTable(ByVal pTableName As String)
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "DELETE FROM " & pTableName

        Try
            rtvSQLConn.ConnectionString = vcConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            rtvSQLConn.Close()
        End Try
    End Sub

    Sub AddSTUDENTData(ByVal pStuId As String, ByVal pName As String, ByVal pSubjectsPassed As Integer)
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "INSERT INTO STUDENT (StuId, Name, SubjectsPassed) " & _
                             "VALUES ('" & pStuId & "', '" & pName & "', " & pSubjectsPassed & ");"

        Try
            rtvSQLConn.ConnectionString = vcConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            rtvSQLConn.Close()
        End Try

    End Sub

    Sub AddUNITData(ByVal pUnitCode As String, ByVal pTitle As String)
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "INSERT INTO UNIT (UnitCode, Title) " & _
                             "VALUES ('" & pUnitCode & "', '" & pTitle & "');"

        Try
            rtvSQLConn.ConnectionString = vcConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            rtvSQLConn.Close()
        End Try

    End Sub

    Sub AddRESULTData(ByVal pStuID As String, ByVal pUnitCode As String, ByVal pGrade As Integer)
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "INSERT INTO RESULT (StuID, UnitCode, Grade) " & _
                             "VALUES ('" & pStuID & "', '" & pUnitCode & "', " & pGrade & ");"

        Try
            rtvSQLConn.ConnectionString = vcConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            rtvSQLConn.Close()
        End Try

    End Sub

    Private Sub Task4Transaction_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task4Transaction_Btn.Click
        Transaction()
    End Sub

    Sub Transaction()
        Dim vTransaction As String = InputBox("Transaction Type: (AS=Add Student/AR=Add Result)")
        Dim vStuID As String
        Dim vName As String
        Dim vUnitCode As String
        Dim vGrade As Integer
        Dim vBoolean As Boolean = True
        Dim rtvSW As StreamWriter
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String
        Dim vStudentCount As Integer = 0
        Dim vUnitCount As Integer = 0
        Dim vResultCount As Integer = 0
        Dim vSubjectsPassed As Integer = 0

        If File.Exists(vcDir & vcLogFile) And vcTransactionCount = 0 Then
            vBoolean = False
        End If

        rtvSW = New StreamWriter(vcDir & vcLogFile, vBoolean)

        Try
            rtvSQLConn.ConnectionString = vcConnStr
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()

            If Not (vTransaction.ToUpper = "AS" Or vTransaction.ToUpper = "AR") Then
                rtvSW.WriteLine("Invalid Transaction")
            ElseIf vTransaction.ToUpper = "AS" Then
                vStuID = InputBox("Student ID: ")
                vName = InputBox("Student Name: ")
                vCmd = "SELECT COUNT(*) FROM STUDENT WHERE UCase(StuID) = '" & vStuID.ToUpper & "'"
                rtvSQLCmd.CommandText = vCmd
                vStudentCount = rtvSQLCmd.ExecuteScalar()

                rtvSW.WriteLine(vTransaction.ToUpper & "," & vStuID.ToUpper & "," & vName.ToUpper)

                If Not vStuID.Length = 4 Or vName = "" Then
                    rtvSW.WriteLine("Invalid Student Details" & vbCrLf)
                ElseIf vStudentCount >= 1 Then
                    rtvSW.WriteLine("Student ID already exists" & vbCrLf)
                Else
                    AddSTUDENTData(vStuID, vName, 0)
                    rtvSW.WriteLine("Student Added" & vbCrLf)
                End If
            Else
                vStuID = InputBox("Student ID: ")
                vUnitCode = InputBox("Unit Code: ")
                vGrade = InputBox("Grade: ")

                vCmd = "SELECT COUNT(*) FROM STUDENT WHERE UCase(StuID) = '" & vStuID.ToUpper & "'"
                rtvSQLCmd.CommandText = vCmd
                vStudentCount = rtvSQLCmd.ExecuteScalar()

                vCmd = "SELECT COUNT(*) FROM UNIT WHERE UCase(UnitCode) = '" & vUnitCode.ToUpper & "'"
                rtvSQLCmd.CommandText = vCmd
                vUnitCount = rtvSQLCmd.ExecuteScalar()

                vCmd = "SELECT COUNT(*) FROM RESULT WHERE UCase(StuID) = '" & vStuID.ToUpper & "' AND UCase(UnitCode) = '" & vUnitCode.ToUpper & "'"
                rtvSQLCmd.CommandText = vCmd
                vResultCount = rtvSQLCmd.ExecuteScalar()

                rtvSW.WriteLine(vTransaction.ToUpper & "," & vStuID.ToUpper & "," & vUnitCode.ToUpper & "," & vGrade)

                If vUnitCount < 1 Then
                    rtvSW.WriteLine("Invalid Unit Code" & vbCrLf)
                ElseIf vStudentCount < 1 Then
                    rtvSW.WriteLine("Invalid Student ID" & vbCrLf)
                ElseIf vResultCount > 0 Then
                    rtvSW.WriteLine("Unit/Student combo already exists" & vbCrLf)
                Else
                    AddRESULTData(vStuID, vUnitCode, vGrade)
                    rtvSW.WriteLine("Result Added")
                    vCmd = "SELECT SubjectsPassed FROM STUDENT WHERE UCase(StuID) = '" & vStuID.ToUpper & "'"
                    rtvSQLCmd.CommandText = vCmd
                    vSubjectsPassed = rtvSQLCmd.ExecuteScalar()

                    If vGrade >= 50 Then
                        vCmd = "UPDATE STUDENT SET SubjectsPassed = " & vSubjectsPassed + 1 & " WHERE UCase(StuID) = '" & vStuID.ToUpper & "'"
                        rtvSQLCmd.CommandText = vCmd
                        rtvSQLCmd.ExecuteNonQuery()
                        rtvSW.WriteLine("Student Incremented" & vbCrLf)
                    Else
                        rtvSW.WriteLine(vbCrLf)
                    End If
                End If
            End If
        Catch ex As Exception

        Finally
            rtvSQLConn.Close()
            rtvSW.Close()
            vcTransactionCount += 1
        End Try


    End Sub

    Private Sub Task5DisplayLogFile_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task5DisplayLogFile_Btn.Click
        DisplayLogFile_RTBx.Text = DisplayLogFile(vcDir & vcLogFile)
    End Sub

    Function DisplayLogFile(ByVal pLogFilePath As String) As String
        Dim vMessage As String = ""
        Dim rtvSR As StreamReader

        If File.Exists(pLogFilePath) Then
            rtvSR = New StreamReader(pLogFilePath)
            While rtvSR.Peek <> -1
                vMessage += rtvSR.ReadLine & vbCrLf
            End While
            rtvSR.Close()
        End If

        Return vMessage
    End Function

    Private Sub Task9DumpStudentData_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task9DumpStudentData_Btn.Click
        DumpData("STUDENT", vcDir & vcStuDumpFile, vcConnStr)
    End Sub

    Sub DumpData(ByVal pTableName As String, ByVal pFilePath As String, ByVal pConnStr As String)
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim rtvDataReader As OleDbDataReader
        Dim vBoolean As Boolean = True
        Dim rtvSW As StreamWriter

        If File.Exists(pFilePath) Then
            vBoolean = False
        End If

        rtvSW = New StreamWriter(pFilePath, vBoolean)
        rtvSW.WriteLine("Student ID,Name,Units Passed")

        rtvSQLConn.ConnectionString = pConnStr
        rtvSQLCmd.Connection = rtvSQLConn
        rtvSQLConn.Open()
        rtvSQLCmd.CommandText = "SELECT * FROM " & pTableName

        Try
            rtvDataReader = rtvSQLCmd.ExecuteReader
            While rtvDataReader.Read
                For Index = 0 To rtvDataReader.FieldCount - 1
                    rtvSW.Write(Trim(rtvDataReader.Item(Index)) & ",")
                Next
                rtvSW.WriteLine("")
            End While
        Catch ex As Exception

        Finally
            rtvDataReader.Close()
            rtvSW.Close()
            rtvSQLConn.Close()
        End Try
    End Sub

    Private Sub Task6DisplayResults_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task6DisplayResults_Btn.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Task7DisplayStudentData_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task7DisplayStudentData_Btn.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Task8GenerateExcel_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Task8GenerateExcel_Btn.Click
        GenerateExcel(vcDir & vcExcelFile, vcConnStr, "STUDENT")
    End Sub

    Sub GenerateExcel(ByVal pExcelFile As String, ByVal pConnStr As String, ByVal pTable As String)
        Dim rtvXLApp As New Excel.Application
        Dim rtvXLWb As Excel.Workbook
        Dim rtvXLWs As Excel.Worksheet
        Dim rtvSQLConn As New OleDbConnection(vcConnStr)
        Dim rtvSQLCmd As New OleDbCommand
        Dim rtvDataReader As OleDbDataReader
        Dim rtvExcelConnection As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                                      pExcelFile & ";Extended Properties=Excel 8.0;")
        Dim rtvExcelCommand As New OleDbCommand
        Dim vIndex As Integer = 2

        If File.Exists(pExcelFile) = True Then
            File.Delete(pExcelFile)
        End If

        rtvXLWb = rtvXLApp.Workbooks.Add
        rtvXLWs = rtvXLWb.Sheets("Sheet1")

        If File.Exists(pExcelFile) = True Then
            File.Delete(pExcelFile)
        End If

        rtvXLWb = rtvXLApp.Workbooks.Add
        rtvXLWs = rtvXLWb.Sheets("Sheet1")

        rtvXLWs.Cells(1, 1).value = "StuID"
        rtvXLWs.Cells(1, 2).value = "Name"
        rtvXLWs.Cells(1, 3).value = "SubjectsPassed"

        rtvXLWb.SaveAs(pExcelFile)

        rtvExcelConnection = New System.Data.OleDb.OleDbConnection _
            ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & _
             pExcelFile & ";Extended Properties=Excel 8.0;")
        Try
            rtvExcelConnection.Open()
            rtvExcelCommand.Connection = rtvExcelConnection

            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()

            rtvSQLCmd.CommandText = "SELECT * FROM " & pTable

            rtvDataReader = rtvSQLCmd.ExecuteReader

            While rtvDataReader.Read
                rtvExcelCommand.CommandText = "INSERT INTO [Sheet1$] (StuID, Name) VALUES('" & rtvDataReader.Item("StuId") & "',' " & rtvDataReader.Item("Name") & "')"
                rtvExcelCommand.ExecuteNonQuery()
                rtvXLWs.Cells(vIndex, 3).formula = "=value(" & rtvDataReader.Item("SubjectsPassed") & ")"
                vIndex += 1
            End While

            rtvDataReader.Close()

            rtvSQLCmd.CommandText = "SELECT COUNT(*) FROM STUDENT"

            rtvXLWs.Cells(rtvSQLCmd.ExecuteScalar() + 3, 1).value = "Total"
            rtvXLWs.Cells(rtvSQLCmd.ExecuteScalar() + 3, 3).Formula = "=sum(C2:C" & rtvSQLCmd.ExecuteScalar() + 1 & ")"

            rtvXLWb.Save()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            rtvExcelConnection.Close()
            rtvSQLCmd.Connection.Close()
            rtvXLWb.Close()
            rtvXLApp.Quit()
        End Try
    End Sub
End Class