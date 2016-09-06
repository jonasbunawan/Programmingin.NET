' Title:    INF20013 Business Systems Programming in .NET - Assignment 3
' Due Date: Monday, 27th October 2014 08:30 AM
' Author:   700513X - Jonas Bunawan

Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class Form1

    Dim vcTransactionCount As Integer = 0

#Region "Event Handlers"
    ' Declaration of Transaction Count variable. This variable will be used as identifier of how many transactions have been processed since the first
    ' time the application is executed.


    ' Event handler that handles working directory existence and database preparation (DatabaseSetup() method will be called
    ' to prepare intended database to be used). This is considered to be solution of Task 1.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Directory.Exists("C:\Temp\INF20013_A03_T006\") = False Then
            Directory.CreateDirectory("C:\Temp\INF20013_A03_T006\")
        End If
        DatabaseSetup()
    End Sub

    ' Event handler that handles data restoration. Once user clicks Restore To Default button, the application will call relevant method(RestoreToDefault()
    ' to restore data to default state. It is a developed solution for Task 3.
    Private Sub Task3RestoretoDefault_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task3RestoretoDefault_Btn.Click
        RestoreToDefault()
    End Sub

    ' Event handler that handles transaction that is made by user. Transaction() method will be called as soon as user clicks transaction button
    ' , then asking user to input the kind of transaction that they are going to make. Task 4 Solution.
    Private Sub Task4Transaction_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task4Transaction_Btn.Click
        Transaction(InputBox("Transaction Type: (AS=Add Student/AR=Add Result)"), "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                             "C:\Temp\INF20013_A03_T006\Ass3.accdb")
    End Sub

    ' Event handler to display content of Log.TXT file onto supplied Rich Textbox on Application. A DisplayLogFile() method will be called
    ' to get intended information. Overcoming Task 5.
    Private Sub Task5DisplayLogFile_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task5DisplayLogFile_Btn.Click
        DisplayLogFile_RTBx.Text = DisplayLogFile("C:\Temp\INF20013_A03_T006\Log.TXT")
    End Sub

    ' Event handler that will open up another form to show the user specific information (Results Information) on datagridview tool. 
    ' Result of Task 6 Solution Development.
    Private Sub Task6DisplayResults_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task6DisplayResults_Btn.Click
        Form2.ShowDialog()
    End Sub

    ' Event handler that is similar to previous one (Task6DisplayResults) where user will be brought to a newly opened form as soon as
    ' the user clicks Display Student Button. Task 7 Resolution.
    Private Sub Task7DisplayStudentData_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task7DisplayStudentData_Btn.Click
        Form3.ShowDialog()
    End Sub

    ' Event handler which will generate a spreadsheet after user clicks generate excel button. Task 8 solution.
    Private Sub Task8GenerateExcel_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task8GenerateExcel_Btn.Click
        GenerateExcel("C:\Temp\INF20013_A03_T006\Students.xls", "C:\Temp\INF20013_A03_T006\Ass3.accdb", "STUDENT")
    End Sub

    ' Event handler which will dump Student Data to STUDUMP.TXT file in the form of comma separated after appropriate button is clicked by user. 
    ' Task 9 solution.
    Private Sub Task9DumpStudentData_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task9DumpStudentData_Btn.Click
        DumpData("STUDENT", "C:\Temp\INF20013_A03_T006\STUDUMP.TXT", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
    End Sub
#End Region

#Region "Methods"
    ' Database Setup() method is to configure the database that will be used by application. It will check whether expected database exists or not
    ' and then call 2 other methods, CreateAccessDatabase(), to create database; CreateAccessTable(), to create tables.
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
        Try
            If File.Exists("C:\Temp\INF20013_A03_T006\Ass3.accdb") = False Then
                CreateAccessDatabase("C:\Temp\INF20013_A03_T006\Ass3.accdb")
                CreateAccessTable(vSQLStudentTableStr, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
                CreateAccessTable(vSQLUnitTableStr, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
                CreateAccessTable(vSQLResultTableStr, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' CreateAccessDatabase() function is to create access database based on provided path where database should be created and stored in.
    ' It will return boolean value; true if database creation is successful or false if database creation is failed.
    Public Function CreateAccessDatabase(ByVal pDatabaseFullPath As String) As Boolean
        Dim vBoolean As Boolean
        Dim rtvCat As New ADOX.Catalog()
        Dim vCreateString As String

        Try
            vCreateString = _
              "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
               pDatabaseFullPath
            rtvCat.Create(vCreateString)

            vBoolean = True

        Catch Excep As System.Runtime.InteropServices.COMException
            MessageBox.Show(Excep.Message)
            vBoolean = False
        Finally
            rtvCat = Nothing
        End Try
        Return vBoolean
    End Function

    ' CreateAccessTable() function is to create table(s) on existing database. ' It will return boolean value; 
    ' true if table creation is successful or false if table creation is failed.
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
            MessageBox.Show(ex.Message)
            vBoolean = False
        Finally
            rtvSQLConnection.Close()
        End Try
        Return vBoolean
    End Function

    ' Following method will restore database onto default state when it is called and executed accordingly. Log.TXT file will also be deleted
    ' if it exists.
    Sub RestoreToDefault()
        ClearTable("STUDENT", "C:\Temp\INF20013_A03_T006\Ass3.accdb")

        'Add Default Student Data
        AddSTUDENTData("S009", "Adam Appleby", 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddSTUDENTData("S082", "Brenda Bignal", 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddSTUDENTData("S215", "Carol Carlott", 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddSTUDENTData("S307", "David Dongle", 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddSTUDENTData("S312", "Emma Evans", 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddSTUDENTData("S445", "Fred Fosters", 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")

        ClearTable("UNIT", "C:\Temp\INF20013_A03_T006\Ass3.accdb")

        'Add Default Unit Data.
        AddUNITData("U101", "Intro Programming", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U102", "Intro Database", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U103", "Intro Networking", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U104", "Intro to Web Development", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U105", "Advanced Programming", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U106", "Advanced Database", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U107", "Advanced Networking", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        AddUNITData("U108", "Advanced to Web Development", "C:\Temp\INF20013_A03_T006\Ass3.accdb")

        ClearTable("RESULT", "C:\Temp\INF20013_A03_T006\Ass3.accdb")
        If File.Exists("C:\Temp\INF20013_A03_T006\Log.TXT") Then
            File.Delete("C:\Temp\INF20013_A03_T006\Log.TXT")
        End If
    End Sub

    ' ClearTable() method is to clear table based on provided database(path) and table(table name) information.
    Sub ClearTable(ByVal pTableName As String, ByVal pDatabasePath As String)
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "DELETE FROM " & pTableName

        Try
            rtvSQLConn.ConnectionString = vConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvSQLConn.Close()
        End Try
    End Sub

    ' AddSTUDENTData() will be called when a new student information needs to be added into database.
    Sub AddSTUDENTData(ByVal pStuId As String, ByVal pName As String, ByVal pSubjectsPassed As Integer, ByVal pDatabasePath As String)
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "INSERT INTO STUDENT (StuId, Name, SubjectsPassed) " & _
                             "VALUES ('" & pStuId & "', '" & pName & "', " & pSubjectsPassed & ");"

        Try
            rtvSQLConn.ConnectionString = vConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvSQLConn.Close()
        End Try

    End Sub

    ' AddUNITData() will be called when a new unit information needs to be added into database.
    Sub AddUNITData(ByVal pUnitCode As String, ByVal pTitle As String, ByVal pDatabasePath As String)
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "INSERT INTO UNIT (UnitCode, Title) " & _
                             "VALUES ('" & pUnitCode & "', '" & pTitle & "');"

        Try
            rtvSQLConn.ConnectionString = vConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvSQLConn.Close()
        End Try

    End Sub

    ' AddRESULTData() will be called when a new result information needs to be added into database.
    Sub AddRESULTData(ByVal pStuID As String, ByVal pUnitCode As String, ByVal pGrade As Integer, ByVal pDatabasePath As String)
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim vCmd As String = "INSERT INTO RESULT (StuID, UnitCode, Grade) " & _
                             "VALUES ('" & pStuID & "', '" & pUnitCode & "', " & pGrade & ");"

        Try
            rtvSQLConn.ConnectionString = vConnStr
            rtvSQLCmd.CommandText = vCmd
            rtvSQLCmd.Connection = rtvSQLConn
            rtvSQLConn.Open()
            rtvSQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvSQLConn.Close()
        End Try

    End Sub

    ' Transaction() method is the major process on this application where it contains transaction handling based on user input.
    Sub Transaction(ByVal pTransaction As String, ByVal pConnStr As String)
        Dim vBoolean As Boolean = True
        Dim rtvSW As StreamWriter
        Dim rtvSQLConn As New OleDbConnection

        If File.Exists("C:\Temp\INF20013_A03_T006\Log.TXT") And vcTransactionCount = 0 Then
            vBoolean = False
        End If

        rtvSW = New StreamWriter("C:\Temp\INF20013_A03_T006\Log.TXT", vBoolean)

        Try
            rtvSQLConn.ConnectionString = pConnStr

            ' Check whether user inputs appropriate type of Transaction. It should be either AS or AR.
            If Not (pTransaction.ToUpper = "AS" Or pTransaction.ToUpper = "AR") Then
                rtvSW.WriteLine(pTransaction.ToUpper)
                rtvSW.WriteLine("Invalid Transaction" & vbCrLf)
            ElseIf pTransaction.ToUpper = "AS" Then
                AddStudent(InputBox("Student ID: "), InputBox("Student Name: "), rtvSW, rtvSQLConn)
            Else
                ' Adding result when transaction type comes to AR
                AddResult(InputBox("Student ID: "), InputBox("Unit Code: "), Val(InputBox("Grade: ")), rtvSW, rtvSQLConn)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvSQLConn.Close()
            rtvSW.Close()
            vcTransactionCount += 1
        End Try
    End Sub

    ' The following block of code is AddStudent method. It will be executed if the transaction is for adding a new student.
    Sub AddStudent(ByVal pStuID As String, ByVal pName As String, ByVal pSW As StreamWriter, ByVal pConn As OleDbConnection)
        Dim rtvSQLCmd As New OleDbCommand
        Dim vStudentCount As Integer = 0

        Try
            pConn.Open()
            rtvSQLCmd.Connection = pConn
            rtvSQLCmd.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE UCase(StuID) = '" & pStuID.ToUpper & "'"
            vStudentCount = rtvSQLCmd.ExecuteScalar()

            pSW.WriteLine("AS," & pStuID.ToUpper & "," & pName.ToUpper)

            If Not pStuID.Length = 4 Or pName = "" Then
                pSW.WriteLine("Invalid Student Details" & vbCrLf)
            ElseIf vStudentCount >= 1 Then
                pSW.WriteLine("Student ID already exists" & vbCrLf)
            Else
                AddSTUDENTData(pStuID, pName, 0, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
                pSW.WriteLine("Student Added" & vbCrLf)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            pConn.Close()
        End Try
    End Sub

    Sub AddResult(ByVal pStuID As String, ByVal pUnitCode As String, ByVal pGrade As Integer, ByVal pSW As StreamWriter, ByVal pConn As OleDbConnection)
        Dim rtvSQLCmd As New OleDbCommand
        Dim vStudentCount As Integer = 0
        Dim vUnitCount As Integer = 0
        Dim vResultCount As Integer = 0
        Dim vSubjectsPassed As Integer = 0

        Try
            pConn.Open()
            rtvSQLCmd.Connection = pConn

            rtvSQLCmd.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE UCase(StuID) = '" & pStuID.ToUpper & "'"
            vStudentCount = rtvSQLCmd.ExecuteScalar()

            rtvSQLCmd.CommandText = "SELECT COUNT(*) FROM UNIT WHERE UCase(UnitCode) = '" & pUnitCode.ToUpper & "'"
            vUnitCount = rtvSQLCmd.ExecuteScalar()

            rtvSQLCmd.CommandText = "SELECT COUNT(*) FROM RESULT WHERE UCase(StuID) = '" & pStuID.ToUpper & "' AND UCase(UnitCode) = '" & pUnitCode.ToUpper & "'"
            vResultCount = rtvSQLCmd.ExecuteScalar()

            pSW.WriteLine("AR," & pStuID.ToUpper & "," & pUnitCode.ToUpper & "," & pGrade)

            If vUnitCount < 1 Then
                pSW.WriteLine("Invalid Unit Code" & vbCrLf)
            ElseIf vStudentCount < 1 Then
                pSW.WriteLine("Invalid Student ID" & vbCrLf)
            ElseIf vResultCount > 0 Then
                pSW.WriteLine("Unit/Student combo already exists" & vbCrLf)
            Else
                AddRESULTData(pStuID, pUnitCode, pGrade, "C:\Temp\INF20013_A03_T006\Ass3.accdb")
                pSW.WriteLine("Result Added")
                rtvSQLCmd.CommandText = "SELECT SubjectsPassed FROM STUDENT WHERE UCase(StuID) = '" & pStuID.ToUpper & "'"
                vSubjectsPassed = rtvSQLCmd.ExecuteScalar()

                If pGrade >= 50 Then
                    rtvSQLCmd.CommandText = "UPDATE STUDENT SET SubjectsPassed = " & vSubjectsPassed + 1 & " WHERE UCase(StuID) = '" & pStuID.ToUpper & "'"
                    rtvSQLCmd.ExecuteNonQuery()
                    pSW.WriteLine("Student Incremented" & vbCrLf)
                Else
                    pSW.WriteLine(vbCrLf)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            pConn.Close()
        End Try
    End Sub

    ' DisplayLogFile() function will give user a result of Log.TXT file contents] if it exists.
    Function DisplayLogFile(ByVal pLogFilePath As String) As String
        Dim vMessage As String = ""
        Dim rtvSR As StreamReader

        If File.Exists(pLogFilePath) Then
            rtvSR = New StreamReader(pLogFilePath)
            While rtvSR.Peek <> -1
                vMessage += rtvSR.ReadLine & vbCrLf
            End While
            rtvSR.Close()
        Else
            vMessage = "Log.TXT file does not exists"
        End If

        Return vMessage
    End Function

    ' DumpData() method will back up data of a table based on specific input parameters. It will generate a file for those data as soon as it is called.
    Sub DumpData(ByVal pTableName As String, ByVal pFilePath As String, ByVal pDatabasePath As String)
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvSQLConn As New OleDbConnection
        Dim rtvSQLCmd As New OleDbCommand
        Dim rtvDataReader As OleDbDataReader
        Dim vBoolean As Boolean = True
        Dim rtvSW As StreamWriter

        If File.Exists(pFilePath) Then
            vBoolean = False
        End If

        rtvSW = New StreamWriter(pFilePath, vBoolean)

        rtvSQLConn.ConnectionString = vConnStr
        rtvSQLCmd.Connection = rtvSQLConn
        rtvSQLCmd.CommandText = "SELECT * FROM " & pTableName

        Try
            rtvSQLConn.Open()
            rtvDataReader = rtvSQLCmd.ExecuteReader
            While rtvDataReader.Read
                For Index = 0 To rtvDataReader.FieldCount - 1
                    rtvSW.Write(Trim(rtvDataReader.Item(Index)) & ",")
                Next
                rtvSW.WriteLine("")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvDataReader.Close()
            rtvSW.Close()
            rtvSQLConn.Close()
        End Try
    End Sub

    ' Generate a spreadsheet based on Student data schema. It will produce expected .xls file when it is called and executed on another method.
    Sub GenerateExcel(ByVal pExcelFile As String, ByVal pDatabasePath As String, ByVal pTable As String)
        Dim vConnStr As String = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                 pDatabasePath
        Dim rtvXLApp As New Excel.Application
        Dim rtvXLWb As Excel.Workbook
        Dim rtvXLWs As Excel.Worksheet
        Dim rtvSQLConn As New OleDbConnection(vConnStr)
        Dim rtvSQLCmd As New OleDbCommand
        Dim rtvDataReader As OleDbDataReader
        Dim rtvExcelConnection As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & _
                                                      pExcelFile & ";Extended Properties=Excel 8.0;")
        Dim rtvExcelCommand As New OleDbCommand
        Dim vIndex As Integer = 2

        ' Excel File Preparation
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

            ' Dump data onto spreadsheet that is created earlier.
            While rtvDataReader.Read
                rtvExcelCommand.CommandText = "INSERT INTO [Sheet1$] (StuID, Name) VALUES('" & rtvDataReader.Item("StuId") & "',' " & rtvDataReader.Item("Name") & "')"
                rtvExcelCommand.ExecuteNonQuery()
                rtvXLWs.Cells(vIndex, 3).formula = "=value(" & rtvDataReader.Item("SubjectsPassed") & ")"
                vIndex += 1
            End While

            rtvDataReader.Close()

            rtvSQLCmd.CommandText = "SELECT COUNT(*) FROM " & pTable

            rtvXLWs.Cells(rtvSQLCmd.ExecuteScalar() + 3, 1).value = "Total"
            rtvXLWs.Cells(rtvSQLCmd.ExecuteScalar() + 3, 3).Formula = "=sum(C2:C" & rtvSQLCmd.ExecuteScalar() + 1 & ")"

            rtvXLWb.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rtvExcelConnection.Close()
            rtvSQLCmd.Connection.Close()
            rtvXLWb.Close()
            rtvXLApp.Quit()
        End Try
    End Sub
#End Region
End Class