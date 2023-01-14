Imports System.Drawing.Printing
Imports System.IO
Imports System.IO.File
Imports MetroFramework
Public Class frmMain

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\attendance.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand

    Dim dataid 'temp variable to store ID from database table
    Dim current 'current header index
    Dim gender As String

    Dim studnum

    Dim checkifheader

    Private sqlQuery As New ExecQueryFunctions



#Region "Form Load and Closed"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedTab = tabPageRecordAttendance
        Timer1.Start()
        MetroDateTime2.Value.AddDays(1)
        Try
            con.Open()

            If con.State = ConnectionState.Open Then
                ShowAlert("Successfully connected to database", frmAlert.AlertTypeEnum.Success)
            Else
                ShowAlert("Connection failed", frmAlert.AlertTypeEnum.Failed)
            End If
        Catch ex As Exception
            ShowAlert(ex.Message, frmAlert.AlertTypeEnum.Info)
        Finally
            con.Close()

        End Try
    End Sub
#End Region

    Public Sub AddLog(ByVal text As String)
        Dim filename As String = Application.StartupPath & "\test.log"
        Dim sw As StreamWriter = AppendText(filename)

        sw.WriteLine(Now() & " " & text)
        sw.Close()
    End Sub

#Region "Add Student"
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        If txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or txtAddress.Text = Nothing Or txtStudentNumber.Text = Nothing Or txtYearLevel.Text = Nothing Or cmbStatus.SelectedItem = Nothing Or cmbCourse.SelectedItem = Nothing Or cmbSection.SelectedItem = Nothing Or (Not radFemale.Checked And Not radMale.Checked) Then
            ShowAlert("Please fill up all required informations", frmAlert.AlertTypeEnum.Info)
        Else
            If sqlQuery.CheckUserIfRegistered(txtStudentNumber.Text, txtFirstName.Text, txtLastName.Text) Then
                ShowAlert("Student already exist", frmAlert.AlertTypeEnum.Failed)
            Else
                Dim result As DialogResult = MetroMessageBox.Show(Me, "Do you want to add this data?", "Add Student", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    AddLog("Student with named " & txtLastName.Text & " has been added to " & cmbSection.Text)
                    sqlQuery.AddStudent(txtFirstName.Text, txtLastName.Text, gender, txtAddress.Text, txtStudentNumber.Text, txtYearLevel.Text, cmbStatus.Text, cmbCourse.Text, cmbSection.Text)
                    ClearInputs()
                Else
                    ShowAlert("No data added, it has been cancelled by the user.", frmAlert.AlertTypeEnum.Info)
                End If
            End If


        End If
    End Sub
#End Region

#Region "Update Student"
    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        If dataid = Nothing Then
            ShowAlert("Please select data first from student records", frmAlert.AlertTypeEnum.Failed)
        Else
            AddLog("Student with named " & txtLastName.Text & " has been updated")
            sqlQuery.UpdateStudent(txtFirstName.Text, txtLastName.Text, gender, txtAddress.Text, txtStudentNumber.Text, txtYearLevel.Text, cmbStatus.Text, cmbCourse.Text, cmbSection.Text, dataid)
            ClearInputs()
            dataid = Nothing
        End If
    End Sub

    Private Sub InitiateUpdate()
        Dim result As DialogResult = MetroFramework.MetroMessageBox.Show(Me, "Do you want to update this student record?", "Update Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            MetroTabControl1.SelectedIndex = 1

            txtFirstName.Text = gridStudRecord.CurrentRow.Cells(1).Value
            txtLastName.Text = gridStudRecord.CurrentRow.Cells(2).Value
            If gridStudRecord.CurrentRow.Cells(3).Value = "Male" Then
                radMale.Checked = True
                radFemale.Checked = False
            Else
                radMale.Checked = False
                radFemale.Checked = True
            End If
            txtAddress.Text = gridStudRecord.CurrentRow.Cells(4).Value
            txtStudentNumber.Text = gridStudRecord.CurrentRow.Cells(5).Value
            txtYearLevel.Text = gridStudRecord.CurrentRow.Cells(6).Value
            cmbStatus.Text = gridStudRecord.CurrentRow.Cells(7).Value
            cmbCourse.Text = gridStudRecord.CurrentRow.Cells(8).Value
            cmbSection.Text = gridStudRecord.CurrentRow.Cells(9).Value
        End If
    End Sub
#End Region

#Region "Delete Student"
    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Dim result As DialogResult = MetroMessageBox.Show(Me, "Do you want to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            AddLog("Student with named " & gridStudRecord.CurrentRow.Cells(2).Value & " has been deleted")
            sqlQuery.DeleteStudent(dataid)
            ClearInputs()
        Else
            ShowAlert("No data deleted, it has been cancelled by the user.", frmAlert.AlertTypeEnum.Info)
        End If
    End Sub
#End Region

#Region "Clear Inputs"
    Private Sub ClearInputs()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtStudentNumber.Text = ""
        txtYearLevel.Text = ""
        cmbStatus.Text = ""
        cmbStatus.SelectedItem = Nothing
        cmbCourse.Text = ""
        cmbCourse.SelectedItem = Nothing
        cmbSection.Text = ""
        cmbSection.SelectedItem = Nothing
        radFemale.Checked = False
        radMale.Checked = False
        txtFirstName.Focus()
    End Sub
#End Region

#Region "Show Alert"
    Public Sub ShowAlert(ByVal message As String, ByVal alerttype As frmAlert.AlertTypeEnum)
        Dim alert As frmAlert = New frmAlert
        alert.SetAlert(message, alerttype)
    End Sub
#End Region

#Region "Context Menu [Add/Delete/Update] Student"
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        MetroTabControl1.SelectedIndex = 1
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If dataid = Nothing Then
            ShowAlert("No data is currently selected", frmAlert.AlertTypeEnum.Failed)
        Else
            sqlQuery.DeleteStudent(dataid)
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If current Is Nothing Or checkifheader = -1 Or dataid = Nothing Then
            ShowAlert("Please choose what data to update", frmAlert.AlertTypeEnum.Info)
        Else
            InitiateUpdate()
        End If
    End Sub
#End Region

#Region "Timer"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt")
        txtLogs.Text = File.ReadAllText(Application.StartupPath & "\test.log")
    End Sub
#End Region

#Region "Gender Checker"
    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged, radFemale.CheckedChanged
        gender = sender.Text()
    End Sub
#End Region

#Region "MetroTab Checker to Load Data"
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedIndex = 2 Then
            Dim sqlcmd As String = "SELECT [ID], [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
FROM TableInfo;"

            sqlQuery.ExecuteSqlQuery(sqlcmd, gridStudRecord)
        ElseIf MetroTabControl1.SelectedIndex = 3 Then
            Dim sqlcmd As String = "SELECT [ID], [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
FROM TableInfo;"

            sqlQuery.ExecuteSqlQuery(sqlcmd, gridDataRecord)
        ElseIf MetroTabControl1.SelectedIndex = 4 Then
            If gridDataRecord.Rows.Count = 0 Then
                'no data dont export
                If PrintPreviewControl1.Document Is Nothing Then
                    ShowAlert("No data, please select from attendance record", frmAlert.AlertTypeEnum.Failed)
                End If
            Else
                PrintDocument1.DefaultPageSettings.Landscape = True
                PrintPreviewControl1.Document = PrintDocument1
                ShowAlert("Data is ready to be saved", frmAlert.AlertTypeEnum.Success)
            End If
        End If

    End Sub
#End Region

#Region "Grid Student Records"
    Private Sub gridStudRecord_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridStudRecord.CellDoubleClick
        checkifheader = e.RowIndex
        If current Is Nothing Or e.RowIndex = -1 Or dataid = Nothing Then
            ShowAlert("Please choose what data to update", frmAlert.AlertTypeEnum.Info)
        Else
            InitiateUpdate()
        End If
    End Sub

    Private Sub gridStudRecord_SelectionChanged(sender As Object, e As EventArgs) Handles gridStudRecord.SelectionChanged
        current = gridStudRecord.CurrentRow
    End Sub

    Private Sub gridStudRecord_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridStudRecord.DataBindingComplete
        gridStudRecord.Columns("ID").Visible = False
        gridStudRecord.Columns("FirstName").HeaderText = "First Name"
        gridStudRecord.Columns("LastName").HeaderText = "Last Name"
        gridStudRecord.Columns("StudentNumber").HeaderText = "Student Number"
        gridStudRecord.Columns("YearLevel").HeaderText = "Year Level"
        gridStudRecord.Columns("studSection").HeaderText = "Section"
    End Sub

    Private Sub gridStudRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridStudRecord.CellClick
        dataid = gridStudRecord.CurrentRow.Cells(0).Value
    End Sub
#End Region

#Region "Grid Data Recods"
    Private Sub gridDataRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDataRecord.CellClick
        sqlQuery.CheckStudentAbsent(gridDataRecord.CurrentRow.Cells(5).Value, MetroDateTime1.Value.Date, MetroDateTime2.Value.Date, gridAttendanceRecord, True)
    End Sub

    Private Sub gridDataRecord_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridDataRecord.DataBindingComplete
        gridDataRecord.Columns("ID").Visible = False
        gridDataRecord.Columns("FirstName").HeaderText = "First Name"
        gridDataRecord.Columns("LastName").HeaderText = "Last Name"
        gridDataRecord.Columns("StudentNumber").HeaderText = "Student Number"
        gridDataRecord.Columns("YearLevel").HeaderText = "Year Level"
        gridDataRecord.Columns("studSection").HeaderText = "Section"
    End Sub
#End Region

#Region "Calculate and Alert Absent"
    Dim present
    Dim absent

    Public Sub CalculateAndAlert()
        present = 0
        absent = 0
        For Each row As DataGridViewRow In gridAttendanceRecord.Rows
            If row.Cells(3).Value = True Then
                present += 1
            Else
                absent += 1
            End If
        Next
        lblAbsentCounter.Text = absent
        lblPresentCounter.Text = present

        Dim fullname As String
        'remove comment if want to use full name instead for alert
        If gridDataRecord.SelectedCells.Count = Nothing Then
            'no cell selected
        Else
            fullname = gridDataRecord.CurrentRow.Cells(2).Value '& ", " & gridDataRecord.CurrentRow.Cells(1).Value
        End If


        If absent >= 5 Then
            ShowAlert("Student named " & fullname & " has a total of " & absent & " absent", frmAlert.AlertTypeEnum.Failed)
        ElseIf absent = 3 Then
            ShowAlert("Student named " & fullname & " has a total Of " & absent & " absent", frmAlert.AlertTypeEnum.Warning)
        End If
    End Sub
#End Region

#Region "Grid Attendance Record"
    Private Sub gridAttendanceRecord_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridAttendanceRecord.DataBindingComplete
        gridAttendanceRecord.Columns("ID").Visible = False
        gridAttendanceRecord.Columns("StudentNumber").HeaderText = "Student Number"
        gridAttendanceRecord.Columns("curDate").HeaderText = "Date"
        gridAttendanceRecord.Columns("studSection").HeaderText = "Section"
        CalculateAndAlert()
    End Sub

    Private Sub gridAttendanceRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAttendanceRecord.CellClick
        studnum = gridAttendanceRecord.CurrentRow.Cells(0).Value
    End Sub
#End Region

#Region "Add Record [Present/Absent]"
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        If txtStudNumberStatus.Text = Nothing Or cmbStudentStatus.SelectedItem = Nothing Then
            ShowAlert("Please fill up all required informations", frmAlert.AlertTypeEnum.Failed)
        Else
            If AddStudAsStatus(txtStudNumberStatus.Text) = False Then
                AddLog("Student " & txtStudNumberStatus.Text & " has recorded an attendance")
                AddRecord()
            Else
                ShowAlert("Student number " & txtStudNumberStatus.Text & " cannot be found", frmAlert.AlertTypeEnum.Info)
                txtStudNumberStatus.Text = ""
                cmbStudentStatus.Text = ""
                cmbStudentStatus.SelectedItem = Nothing
            End If
        End If
    End Sub

    Private Function AddStudAsStatus(ByVal studnum As String) As Boolean
        Dim sqlcmd As String = "Select [ID], [FirstName], [LastName], [gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
From TableInfo
WHERE (((StudentNumber)=""" & studnum & """));"

        sqlQuery.ExecuteSqlQuery(sqlcmd, tempDataGridRecord)

        Dim status As Boolean = True

        If tempDataGridRecord.CurrentCell Is Nothing Then
            status = True
        Else
            status = False
        End If
        Return status

    End Function

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
            sqlQuery.CheckStudentAbsent(txtStudNumberStatus.Text, MetroDateTime1.Value.Date, MetroDateTime2.Value.Date, gridAttendanceRecord, False)

            txtStudNumberStatus.Text = ""
            cmbStudentStatus.Text = ""
            cmbStudentStatus.SelectedItem = Nothing
        End Try
    End Sub
#End Region

#Region "Delete Record [Present/Absent]"
    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        Dim i As Integer

        Try
            con.Open()
            sql = "Delete * from TableRecords WHERE ID=" & Val(studnum) & ""
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
            gridAttendanceRecord.DataSource = Nothing
            lblPresentCounter.Text = "--"
            lblAbsentCounter.Text = "--"
        End Try
    End Sub
#End Region

#Region "Filter Data Record [By StudNum/Section/Course]"
    Private Sub radAttendanceFilter_CheckedChanged(sender As Object, e As EventArgs) Handles radAttendanceStudNo.CheckedChanged, radAttendanceSection.CheckedChanged, radAttendanceCourse.CheckedChanged
        If radAttendanceStudNo.Checked Then
            pnlAttendanceStudNo.Visible = True
            pnlAttendanceCourse.Visible = False
            pnlAttendanceSection.Visible = False
        ElseIf radAttendanceSection.Checked Then
            pnlAttendanceCourse.Visible = False
            pnlAttendanceStudNo.Visible = False
            pnlAttendanceSection.Visible = True
        ElseIf radAttendanceCourse.Checked Then
            pnlAttendanceCourse.Visible = True
            pnlAttendanceStudNo.Visible = False
            pnlAttendanceSection.Visible = False
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnAttendanceFilter.Click
        If radAttendanceStudNo.Checked Then
            If txtAttendanceStudNoFilter.Text = Nothing Then
                ShowAlert("Insert what student number to filter", frmAlert.AlertTypeEnum.Failed)
            Else
                byStud(txtAttendanceStudNoFilter.Text, gridDataRecord)
            End If
        ElseIf radAttendanceSection.Checked Then
            If cmbAttendanceSectionFilter.SelectedItem = Nothing Then
                ShowAlert("Please select what section to filter", frmAlert.AlertTypeEnum.Failed)
            Else
                bySection(cmbAttendanceSectionFilter.Text, gridDataRecord)
            End If
        ElseIf radAttendanceCourse.Checked Then
            If cmbAttendanceCourseFilter.SelectedItem = Nothing Then
                ShowAlert("Please select what course to filter", frmAlert.AlertTypeEnum.Failed)
            Else
                byCourse(cmbAttendanceCourseFilter.SelectedItem, gridDataRecord)
            End If
        End If

    End Sub

    Private Sub byStud(ByVal studnum As String, ByVal datagrid As DataGridView)
        Dim sqlcmd As String = "SELECT [ID], [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
FROM TableInfo
WHERE (((StudentNumber)=""" & studnum & """));"

        sqlQuery.ExecuteSqlQuery(sqlcmd, datagrid)

        If datagrid.CurrentCell Is Nothing Then
            ShowAlert("No data found", frmAlert.AlertTypeEnum.Info)
            gridAttendanceRecord.DataSource = Nothing
            gridAttendanceRecord.Refresh()
        Else
            sqlQuery.CheckStudentAbsent(datagrid.CurrentRow.Cells(5).Value, MetroDateTime1.Value.Date, MetroDateTime2.Value.Date, gridAttendanceRecord, False)
        End If
    End Sub

    Private Sub bySection(ByVal ssection As String, ByVal datagrid As DataGridView)
        Dim sqlcmd As String = "SELECT [ID], [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
FROM TableInfo
WHERE (((studSection)=""" & ssection & """));"
        sqlQuery.ExecuteSqlQuery(sqlcmd, datagrid)

        If datagrid.CurrentCell Is Nothing Then
            ShowAlert("No data found", frmAlert.AlertTypeEnum.Info)
            gridAttendanceRecord.DataSource = Nothing
            gridAttendanceRecord.Refresh()
        Else
            sqlQuery.CheckStudentAbsent(datagrid.CurrentRow.Cells(5).Value, MetroDateTime1.Value.Date, MetroDateTime2.Value.Date, gridAttendanceRecord, False)
        End If
    End Sub

    Private Sub byCourse(ByVal course As String, ByVal datagrid As DataGridView)
        Dim sqlcmd As String = "SELECT [ID], [FirstName], [LastName], [Gender], [Address], [StudentNumber], [YearLevel], [Status], [Course], [studSection]
FROM TableInfo
WHERE (((Course)=""" & course & """));"

        sqlQuery.ExecuteSqlQuery(sqlcmd, datagrid)

        If datagrid.CurrentCell Is Nothing Then
            ShowAlert("No data found", frmAlert.AlertTypeEnum.Info)
            gridAttendanceRecord.DataSource = Nothing
            gridAttendanceRecord.Refresh()
        Else
            sqlQuery.CheckStudentAbsent(datagrid.CurrentRow.Cells(5).Value, MetroDateTime1.Value.Date, MetroDateTime2.Value.Date, gridAttendanceRecord, False)
        End If
    End Sub


#End Region

#Region "Logout Button"
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        AddLog("Admin has logged out")
        ShowAlert("Successfully logged out!", frmAlert.AlertTypeEnum.Info)
        frmLogin.Show()
        Me.Close()
    End Sub
#End Region

#Region "Print Record [Save/Show/Clear From Preview]"
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Private Sub btnClearFile_Click(sender As Object, e As EventArgs) Handles btnClearFile.Click
        PrintPreviewControl1.Document = Nothing
        AddLog("Records has been cleared")
        ShowAlert("Data has been cleared", frmAlert.AlertTypeEnum.Info)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim drawFontBold = New Font("Arial", 12, FontStyle.Bold)
        e.Graphics.DrawString("PDF File Output from Data Records | Date & Time: " + DateTime.Now, drawFontBold, Brushes.Black, 50, 50)
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = gridDataRecord.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x - 70, y, cell.Size.Width + 20, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case gridDataRecord.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(gridDataRecord.Columns(cell.ColumnIndex).HeaderText,
                                            gridDataRecord.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To gridDataRecord.RowCount - 1
            ' no need to try to print the new row
            If gridDataRecord.Rows(thisNDX).IsNewRow Then Exit For

            row = gridDataRecord.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x - 70, y, cell.Size.Width + 20, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case gridDataRecord.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      gridDataRecord.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        mRow = 0
        newpage = True
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        If PrintPreviewControl1.Document Is Nothing Then
            ShowAlert("Select data first from the Attendance Record Tab", frmAlert.AlertTypeEnum.Info)
        Else
            Dim sfd As New SaveFileDialog()

            sfd.Filter = "Portable Document Format (*.pdf)|*.pdf"
            sfd.DefaultExt = "pdf"
            sfd.FilterIndex = 2
            sfd.AddExtension = True
            sfd.RestoreDirectory = True

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    PrintDocument1.PrinterSettings = New PrinterSettings() With {
.PrinterName = "Microsoft Print to PDF",
.PrintToFile = True,
.PrintFileName = Path.Combine(Application.StartupPath, sfd.FileName)}
                    PrintDocument1.DefaultPageSettings.Landscape = True
                    PrintDocument1.Print()
                Catch ex As Exception
                    ShowAlert("Failed to save " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf", frmAlert.AlertTypeEnum.Failed)
                Finally
                    AddLog("Records has been exported as " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf file")
                    ShowAlert("Data named " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf has been saved", frmAlert.AlertTypeEnum.Info)
                End Try
            End If
        End If
    End Sub
#End Region

#Region "Filter Student Data Records"
    Private Sub radRecordsFilter_CheckedChanged(sender As Object, e As EventArgs) Handles radStudentRecordsNumber.CheckedChanged, radSectionRecordsFilter.CheckedChanged, radCourseRecordsFilter.CheckedChanged
        If radStudentRecordsNumber.Checked Then
            pnlStudNumRecords.Visible = True
            pnlCourseRecords.Visible = False
            pnlSectionRecords.Visible = False
        ElseIf radSectionRecordsFilter.Checked Then
            pnlStudNumRecords.Visible = False
            pnlCourseRecords.Visible = False
            pnlSectionRecords.Visible = True
        ElseIf radCourseRecordsFilter.Checked Then
            pnlStudNumRecords.Visible = False
            pnlCourseRecords.Visible = True
            pnlSectionRecords.Visible = False
        End If
    End Sub

    Private Sub btnStudentRecordsFilter_Click(sender As Object, e As EventArgs) Handles btnStudentRecordsFilter.Click
        If radStudentRecordsNumber.Checked Then
            If txtStudNumRecordsFilter.Text = Nothing Then
                ShowAlert("Insert what student number to filter", frmAlert.AlertTypeEnum.Failed)
            Else
                byStud(txtStudNumRecordsFilter.Text, gridStudRecord)
            End If
        ElseIf radSectionRecordsFilter.Checked Then
            If cmbSectionRecordsFilter.SelectedItem = Nothing Then
                ShowAlert("Please select what section to filter", frmAlert.AlertTypeEnum.Failed)
            Else
                bySection(cmbSectionRecordsFilter.Text, gridStudRecord)
            End If
        ElseIf radCourseRecordsFilter.Checked Then
            If cmbCourseRecordsFilter.SelectedItem = Nothing Then
                ShowAlert("Please select what course to filter", frmAlert.AlertTypeEnum.Failed)
            Else
                byCourse(cmbCourseRecordsFilter.SelectedItem, gridStudRecord)
            End If
        End If
    End Sub
#End Region

#Region "Print Attendance Record [Save/Show/Clear From Preview]"
    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        If PrintPreviewControl2.Document Is Nothing Then
            ShowAlert("Select data first from the selection", frmAlert.AlertTypeEnum.Info)
        Else
            Dim sfd As New SaveFileDialog()

            sfd.Filter = "Portable Document Format (*.pdf)|*.pdf"
            sfd.DefaultExt = "pdf"
            sfd.FilterIndex = 2
            sfd.AddExtension = True
            sfd.RestoreDirectory = True

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    PrintDocument2.PrinterSettings = New PrinterSettings() With {
.PrinterName = "Microsoft Print to PDF",
.PrintToFile = True,
.PrintFileName = Path.Combine(Application.StartupPath, sfd.FileName)}
                    PrintDocument2.DefaultPageSettings.Landscape = True
                    PrintDocument2.Print()
                Catch ex As Exception
                    ShowAlert("Failed to save " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf", frmAlert.AlertTypeEnum.Failed)
                Finally
                    AddLog("Students attendance record has been exported as " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf file")
                    ShowAlert("Data named " & Path.GetFileNameWithoutExtension(sfd.FileName) & ".pdf has been saved", frmAlert.AlertTypeEnum.Info)
                End Try
            End If
        End If
    End Sub

    Private Sub btnClearAttendance_Click(sender As Object, e As EventArgs) Handles btnClearAttendance.Click
        PrintPreviewControl2.Document = Nothing
        AddLog("Attendance record has been cleared")
        ShowAlert("Data has been cleared", frmAlert.AlertTypeEnum.Info)
    End Sub

    Private Sub PrintDocument2_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument2.BeginPrint
        mRow = 0
        newpage = True
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim drawFontBold = New Font("Arial", 12, FontStyle.Bold)
        e.Graphics.DrawString("PDF File Output from Attendance Records | Date & Time: " + DateTime.Now, drawFontBold, Brushes.Black, 50, 50)
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = DataGridView1.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x - 70, y, cell.Size.Width + 20, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText,
                                            DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridView1.RowCount - 1
            ' no need to try to print the new row
            If DataGridView1.Rows(thisNDX).IsNewRow Then Exit For

            row = DataGridView1.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x - 70, y, cell.Size.Width + 20, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      DataGridView1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub
#End Region

#Region "Filter Attendance Date"
    Private Sub btnSearchAttendance_Click(sender As Object, e As EventArgs) Handles btnSearchAttendance.Click

        If MetroDateTime3.Value.Date = MetroDateTime4.Value.Date Then
            ShowAlert("From and To Range must not be equal", frmAlert.AlertTypeEnum.Failed)
        ElseIf MetroDateTime3.Value.Date < MetroDateTime4.Value.Date Then
            If MetroRadioButton1.Checked And cmbCourseAttendance.SelectedItem = Nothing Then
                ShowAlert("Please select course to search", frmAlert.AlertTypeEnum.Failed)
            ElseIf MetroRadioButton2.Checked And cmbSectionAttendance.SelectedItem = Nothing Then
                ShowAlert("Please select section to search", frmAlert.AlertTypeEnum.Failed)
            Else
                FilterAttendancePDF()
            End If
        Else
            ShowAlert("Please enter valid date range", frmAlert.AlertTypeEnum.Failed)
        End If
    End Sub

    Public Sub FilterAttendancePDF()
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            con.Open()

            Dim RangeFrom As DateTime = MetroDateTime3.Value
            Dim RangeTo As DateTime = MetroDateTime4.Value

            If MetroRadioButton1.Checked Then
                sql = "SELECT TableRecords.ID, TableInfo.FirstName, TableInfo.LastName, TableInfo.StudentNumber, TableRecords.Present, TableRecords.curDate, TableInfo.Course, TableInfo.studSection
FROM TableInfo LEFT JOIN TableRecords ON TableInfo.[StudentNumber] = TableRecords.[StudentNumber]
WHERE (((TableRecords.curDate)>#" & RangeFrom.Date.ToString("MM/dd/yyyy") & "# AND (TableRecords.curDate)<#" & RangeTo.Date.AddDays(1).ToString("MM/dd/yyyy") & "#) AND ((TableInfo.Course)=""" & cmbCourseAttendance.Text & """) AND ((TableRecords.StudentNumber) Is Not Null));
"
            ElseIf MetroRadioButton2.Checked Then
                sql = "SELECT TableRecords.ID, TableInfo.FirstName, TableInfo.LastName, TableInfo.StudentNumber, TableRecords.Present, TableRecords.curDate, TableInfo.Course, TableInfo.studSection
FROM TableInfo LEFT JOIN TableRecords ON TableInfo.[StudentNumber] = TableRecords.[StudentNumber]
WHERE (((TableRecords.curDate)>#" & RangeFrom.Date.ToString("MM/dd/yyyy") & "# AND (TableRecords.curDate)<#" & RangeTo.Date.AddDays(1).ToString("MM/dd/yyyy") & "#) AND ((TableInfo.studSection)=""" & cmbSectionAttendance.Text & """) AND ((TableRecords.StudentNumber) Is Not Null));
"
            End If
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            If DataGridView1.Rows.Count = 0 Then
                'no data dont export
                ShowAlert("No data found!,Try searching again", frmAlert.AlertTypeEnum.Failed)
                PrintPreviewControl2.Document = Nothing
            Else
                PrintDocument2.DefaultPageSettings.Landscape = True
                PrintPreviewControl2.Document = PrintDocument2
                ShowAlert("Data is ready to be saved", frmAlert.AlertTypeEnum.Success)
            End If
        End Try
    End Sub

    Private Sub FilterDate_Click(sender As Object, e As EventArgs) Handles FilterDate.Click
        If MetroDateTime1.Value.Date = MetroDateTime2.Value.Date Then
            ShowAlert("From and To Range must not be equal", frmAlert.AlertTypeEnum.Failed)
        ElseIf MetroDateTime1.Value.Date < MetroDateTime2.Value.Date Then
            sqlQuery.CheckStudentAbsent(gridDataRecord.CurrentRow.Cells(5).Value, MetroDateTime1.Value.Date, MetroDateTime2.Value.Date, gridAttendanceRecord, False)
        Else
            ShowAlert("Please enter valid date range", frmAlert.AlertTypeEnum.Failed)
        End If
    End Sub

    Private Sub printAttendanceFilter(sender As Object, e As EventArgs) Handles MetroRadioButton2.CheckedChanged, MetroRadioButton1.CheckedChanged
        If MetroRadioButton1.Checked Then
            courseFilterAttendance.Visible = True
            sectionFilterAttendance.Visible = False
        ElseIf MetroRadioButton2.Checked Then
            courseFilterAttendance.Visible = False
            sectionFilterAttendance.Visible = True
        End If
    End Sub
#End Region

#Region "Temp DataGrid"
    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        DataGridView1.Columns("ID").Visible = False
        DataGridView1.Columns("FirstName").HeaderText = "First Name"
        DataGridView1.Columns("LastName").HeaderText = "Last Name"
        DataGridView1.Columns("StudentNumber").HeaderText = "Student Number"
        DataGridView1.Columns("curDate").HeaderText = "Date"
        DataGridView1.Columns("studSection").HeaderText = "Section"
    End Sub
#End Region

    Private Sub btnClearLogs_Click(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        File.WriteAllText(Application.StartupPath & "\test.log", "")
    End Sub
End Class