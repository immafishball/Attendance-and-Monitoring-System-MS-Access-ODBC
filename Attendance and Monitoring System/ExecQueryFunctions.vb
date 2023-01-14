Public Class ExecQueryFunctions

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\attendance.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand

    Dim present As Integer
    Dim absent As Integer

    Public Sub ShowAlert(ByVal message As String, ByVal alerttype As frmAlert.AlertTypeEnum)
        Dim alert As frmAlert = New frmAlert
        alert.SetAlert(message, alerttype)
    End Sub

    Public Sub ExecuteSqlQuery(ByVal command As String, ByVal outputdt As DataGridView)
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = command

            da.SelectCommand = cmd
            da.Fill(dt)

            outputdt.DataSource = dt
        Catch ex As Exception
            ShowAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function CheckIfAdmin(ByVal username As String) As Boolean
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()

            sql = "SELECT TableUsers.ID, TableUsers.Username, TableUsers.Password, TableUsers.isAdmin
FROM TableUsers
WHERE (((TableUsers.Username)=""" & username & """) AND ((TableUsers.isAdmin)=False));"

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function

    Public Function GetName(ByVal username As String) As String
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Dim result As String

        Try
            con.Open()

            sql = "SELECT [LastName] & """ & ", " & """ & [FirstName] AS [Full Name], TableInfo.StudentNumber
FROM TableInfo
WHERE (((TableInfo.StudentNumber)=""" & username & """));
"

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        If dt.Rows.Count > 0 Then
            result = dt.Rows(0).Item(0)
        End If

        Return result
    End Function

    Public Sub AddStudent(ByVal FName As String, ByVal LName As String, ByVal Gender As String, ByVal Address As String, ByVal StudentNumber As String, ByVal YearLevel As String, ByVal Status As String, ByVal Course As String, ByVal stuSection As String)
        Dim i As Integer

        Try
            con.Open()
            sql = "INSERT INTO TableInfo ( [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection] ) VALUES ('" & FName & "', '" & LName & "', '" & Gender & "', '" & Address & "', '" & StudentNumber & "', '" & YearLevel & "', '" & Status & "', '" & Course & "', '" & stuSection & "');"

            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                ShowAlert("New record has been successfully added!", frmAlert.AlertTypeEnum.Success)
            Else
                ShowAlert("Failed to add new record", frmAlert.AlertTypeEnum.Failed)
            End If
        Catch ex As Exception
            ShowAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
        End Try
    End Sub

    Public Sub UpdateStudent(ByVal FName As String, ByVal LName As String, ByVal Gender As String, ByVal Address As String, ByVal StudentNumber As String, ByVal YearLevel As String, ByVal Status As String, ByVal Course As String, ByVal stuSection As String, ByVal ID As String)
        Dim i As Integer
        Try
            con.Open()
            sql = "UPDATE TableInfo SET [FirstName]='" & FName & "', [LastName]='" & LName & "', [Gender]='" & Gender & "', [Address]='" & Address & "', [StudentNumber]='" & StudentNumber & "', [YearLevel]='" & YearLevel & "', [Status]='" & Status & "', [Course]='" & Course & "', [studSection]='" & stuSection & "' WHERE ID=" & Val(ID) & ";"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                ShowAlert("Record has been successfully updated!", frmAlert.AlertTypeEnum.Success)
            Else
                ShowAlert("Please select data to be updated!", frmAlert.AlertTypeEnum.Info)
            End If
        Catch ex As Exception
            ShowAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteStudent(ByVal ID As String)
        Dim i As Integer

        Try
            con.Open()
            sql = "Delete * from TableInfo WHERE ID=" & Val(ID) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                ShowAlert("Record has been deleted successfully!", frmAlert.AlertTypeEnum.Success)
            Else
                ShowAlert("Please select data to be deleted!", frmAlert.AlertTypeEnum.Info)
            End If

        Catch ex As Exception
            ShowAlert("No data is found", frmAlert.AlertTypeEnum.Failed)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub CheckStudentAbsent(ByVal ID As String, ByVal Rangefrom As DateTime, ByVal Rangeto As DateTime, ByVal outputdt As DataGridView, Optional ByVal listall As Boolean = False)
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()

            If listall = True Then
                sql = "SELECT TableRecords.ID, [LastName] & """ & ", " & """ & [FirstName] AS [Full Name], TableInfo.StudentNumber, TableRecords.Present, TableRecords.curDate, TableInfo.Course, TableInfo.studSection
FROM TableInfo LEFT JOIN TableRecords ON TableInfo.[StudentNumber] = TableRecords.[StudentNumber]
WHERE (((TableInfo.StudentNumber)=""" & ID & """) AND ((TableRecords.StudentNumber) Is Not Null));"
            Else
                sql = "SELECT TableRecords.ID, [LastName] & """ & "," & """ & [FirstName] AS [Full Name], TableInfo.StudentNumber, TableRecords.Present, TableRecords.curDate, TableInfo.Course, TableInfo.studSection
FROM TableInfo LEFT JOIN TableRecords ON TableInfo.[StudentNumber] = TableRecords.[StudentNumber]
WHERE (((TableInfo.StudentNumber)=""" & ID & """) AND ((TableRecords.curDate)>#" & Rangefrom.Date.AddDays(1).ToString("MM/dd/yyyy") & "# And (TableRecords.curDate)<#" & Rangeto.Date.ToString("MM/dd/yyyy") & "#) AND ((TableRecords.StudentNumber) Is Not Null));"
            End If

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            outputdt.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function CheckUserInClassList(ByVal StudentID As String) As Boolean
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()

            sql = "SELECT * FROM TableInfo WHERE StudentNumber =""" & StudentID & """;"

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function

    Public Function CheckUserIfRegistered(ByVal StudentID As String, ByVal FirstName As String, ByVal LastName As String) As Boolean
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()

            sql = "SELECT * FROM TableInfo WHERE StudentNumber =""" & StudentID & """ AND FirstName = """ & FirstName & """ AND LastName = """ & LastName & """;"

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function

    Public Function CheckUserRegistered(ByVal username As String) As Boolean
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()

            sql = "SELECT * FROM TableUsers WHERE Username =""" & username & """;"

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function
End Class
