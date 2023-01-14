Imports System.IO
Imports System.IO.File

Public Class frmStudent
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\attendance.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand

    Private sqlQuery As New ExecQueryFunctions

    Public Property StringPass As String

    Public Sub AddLog(ByVal text As String)
        Dim filename As String = Application.StartupPath & "\test.log"
        Dim sw As StreamWriter = AppendText(filename)

        sw.WriteLine(Now() & " " & text)
        sw.Close()
    End Sub

#Region "Add Record"
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        If txtStudNumberStatus.Text = Nothing Or cmbStudentStatus.SelectedItem = Nothing Then
            ShowAlert("Please fill up all required informations", frmAlert.AlertTypeEnum.Failed)
        Else
            AddRecord()
        End If
    End Sub

    Private Sub AddRecord()
        Dim status As Integer = cmbStudentStatus.SelectedIndex - 1
        Dim i As Integer
        Try
            con.Open()
            sql = "INSERT INTO TableRecords ( [StudentNumber], [Present], [curDate] ) VALUES ('" & txtStudNumberStatus.Text & "', '" & status & "', '" & lblTimer.Text & "');"

            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                ShowAlert("New record has been successfully added!", frmAlert.AlertTypeEnum.Success)
            Else
                ShowAlert("Failed to add new record", frmAlert.AlertTypeEnum.Success)
            End If
        Catch ex As Exception
            ShowAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
        Finally
            con.Close()
            cmbStudentStatus.Text = ""
            cmbStudentStatus.SelectedItem = Nothing
        End Try
    End Sub
#End Region

#Region "Show Alert"
    Public Sub ShowAlert(ByVal message As String, ByVal alerttype As frmAlert.AlertTypeEnum)
        Dim alert As frmAlert = New frmAlert
        alert.SetAlert(message, alerttype)
    End Sub
#End Region

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        AddLog("Student named " & txtLastName.Text & " has logged out")
        ShowAlert("Successfully logged out!", frmAlert.AlertTypeEnum.Info)
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedIndex = 1 Then
            GetData(StringPass, gridTemp)
        End If
    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudNumberStatus.Text = StringPass
        Timer1.Start()
    End Sub

    Private Sub GetData(ByVal studnum As String, ByVal datagrid As DataGridView)
        Dim sqlcmd As String = "SELECT [ID], [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
FROM TableInfo
WHERE (((StudentNumber)=""" & studnum & """));"

        sqlQuery.ExecuteSqlQuery(sqlcmd, datagrid)

        If datagrid.CurrentCell Is Nothing Then
            ShowAlert("No data found", frmAlert.AlertTypeEnum.Info)
            gridAttendanceRecord.DataSource = Nothing
            gridAttendanceRecord.Refresh()
        Else
            sqlQuery.CheckStudentAbsent(studnum, Nothing, Nothing, gridAttendanceRecord, True)
        End If

        txtFirstName.Text = gridTemp.Rows(0).Cells(1).Value
        txtLastName.Text = gridTemp.Rows(0).Cells(2).Value
        If gridTemp.Rows(0).Cells(3).Value = "Male" Then
            radMale.Checked = True
            radFemale.Checked = False
        Else
            radMale.Checked = False
            radFemale.Checked = True
        End If
        txtAddress.Text = gridTemp.Rows(0).Cells(4).Value
        txtStudentNumber.Text = gridTemp.Rows(0).Cells(5).Value
        txtYearLevel.Text = gridTemp.Rows(0).Cells(6).Value
        cmbStatus.Text = gridTemp.Rows(0).Cells(7).Value
        cmbCourse.Text = gridTemp.Rows(0).Cells(8).Value
        cmbSection.Text = gridTemp.Rows(0).Cells(9).Value
    End Sub

    Private Sub gridAttendanceRecord_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridAttendanceRecord.DataBindingComplete
        gridAttendanceRecord.Columns("ID").Visible = False
        gridAttendanceRecord.Columns("StudentNumber").HeaderText = "Student Number"
        gridAttendanceRecord.Columns("curDate").HeaderText = "Date"
        gridAttendanceRecord.Columns("studSection").HeaderText = "Section"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")
    End Sub
End Class