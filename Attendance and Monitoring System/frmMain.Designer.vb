<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabPageStudentInfo = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cmbSection = New MetroFramework.Controls.MetroComboBox()
        Me.btnUpdateStudent = New MetroFramework.Controls.MetroButton()
        Me.btnAddStudent = New MetroFramework.Controls.MetroButton()
        Me.cmbCourse = New MetroFramework.Controls.MetroComboBox()
        Me.txtStudentNumber = New MetroFramework.Controls.MetroTextBox()
        Me.cmbStatus = New MetroFramework.Controls.MetroComboBox()
        Me.radFemale = New MetroFramework.Controls.MetroRadioButton()
        Me.radMale = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.txtYearLevel = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDeleteStudent = New MetroFramework.Controls.MetroButton()
        Me.lblTimer = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabPageRecordAttendance = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAddRecord = New MetroFramework.Controls.MetroButton()
        Me.cmbStudentStatus = New MetroFramework.Controls.MetroComboBox()
        Me.txtStudNumberStatus = New MetroFramework.Controls.MetroTextBox()
        Me.tabPageStudentRecords = New MetroFramework.Controls.MetroTabPage()
        Me.pnlStudNumRecords = New System.Windows.Forms.Panel()
        Me.txtStudNumRecordsFilter = New MetroFramework.Controls.MetroTextBox()
        Me.btnStudentRecordsFilter = New MetroFramework.Controls.MetroButton()
        Me.radSectionRecordsFilter = New MetroFramework.Controls.MetroRadioButton()
        Me.radCourseRecordsFilter = New MetroFramework.Controls.MetroRadioButton()
        Me.radStudentRecordsNumber = New MetroFramework.Controls.MetroRadioButton()
        Me.pnlCourseRecords = New System.Windows.Forms.Panel()
        Me.cmbCourseRecordsFilter = New MetroFramework.Controls.MetroComboBox()
        Me.pnlSectionRecords = New System.Windows.Forms.Panel()
        Me.cmbSectionRecordsFilter = New MetroFramework.Controls.MetroComboBox()
        Me.gridStudRecord = New System.Windows.Forms.DataGridView()
        Me.tabPageAttendanceRecord = New MetroFramework.Controls.MetroTabPage()
        Me.FilterDate = New MetroFramework.Controls.MetroButton()
        Me.lblToAttendance = New MetroFramework.Controls.MetroLabel()
        Me.lblFromAttendance = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lblAbsentCounter = New MetroFramework.Controls.MetroLabel()
        Me.lblPresentCounter = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.pnlAttendanceStudNo = New System.Windows.Forms.Panel()
        Me.txtAttendanceStudNoFilter = New MetroFramework.Controls.MetroTextBox()
        Me.btnAttendanceFilter = New MetroFramework.Controls.MetroButton()
        Me.radAttendanceSection = New MetroFramework.Controls.MetroRadioButton()
        Me.radAttendanceCourse = New MetroFramework.Controls.MetroRadioButton()
        Me.radAttendanceStudNo = New MetroFramework.Controls.MetroRadioButton()
        Me.gridAttendanceRecord = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridDataRecord = New System.Windows.Forms.DataGridView()
        Me.pnlAttendanceCourse = New System.Windows.Forms.Panel()
        Me.cmbAttendanceCourseFilter = New MetroFramework.Controls.MetroComboBox()
        Me.pnlAttendanceSection = New System.Windows.Forms.Panel()
        Me.cmbAttendanceSectionFilter = New MetroFramework.Controls.MetroComboBox()
        Me.tabPagePrintRecord = New MetroFramework.Controls.MetroTabPage()
        Me.btnClearFile = New MetroFramework.Controls.MetroButton()
        Me.btnSaveFile = New MetroFramework.Controls.MetroButton()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.tabPagePrintAttendance = New MetroFramework.Controls.MetroTabPage()
        Me.courseFilterAttendance = New System.Windows.Forms.Panel()
        Me.cmbCourseAttendance = New MetroFramework.Controls.MetroComboBox()
        Me.sectionFilterAttendance = New System.Windows.Forms.Panel()
        Me.cmbSectionAttendance = New MetroFramework.Controls.MetroComboBox()
        Me.btnSaveAttendance = New MetroFramework.Controls.MetroButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.btnClearAttendance = New MetroFramework.Controls.MetroButton()
        Me.btnSearchAttendance = New MetroFramework.Controls.MetroButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.PrintPreviewControl2 = New System.Windows.Forms.PrintPreviewControl()
        Me.MetroDateTime3 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroDateTime4 = New MetroFramework.Controls.MetroDateTime()
        Me.lblFromAttendanceRecord = New MetroFramework.Controls.MetroLabel()
        Me.lblToAttendanceRecord = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New MetroFramework.Controls.MetroButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tempDataGridRecord = New System.Windows.Forms.DataGridView()
        Me.txtLogs = New System.Windows.Forms.RichTextBox()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnClearLogs = New MetroFramework.Controls.MetroButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tabPageStudentInfo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabPageRecordAttendance.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageStudentRecords.SuspendLayout()
        Me.pnlStudNumRecords.SuspendLayout()
        Me.pnlCourseRecords.SuspendLayout()
        Me.pnlSectionRecords.SuspendLayout()
        CType(Me.gridStudRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageAttendanceRecord.SuspendLayout()
        Me.pnlAttendanceStudNo.SuspendLayout()
        CType(Me.gridAttendanceRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.gridDataRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAttendanceCourse.SuspendLayout()
        Me.pnlAttendanceSection.SuspendLayout()
        Me.tabPagePrintRecord.SuspendLayout()
        Me.tabPagePrintAttendance.SuspendLayout()
        Me.courseFilterAttendance.SuspendLayout()
        Me.sectionFilterAttendance.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempDataGridRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.UpdateToolStripMenuItem.Text = "Edit"
        '
        'tabPageStudentInfo
        '
        Me.tabPageStudentInfo.Controls.Add(Me.PictureBox5)
        Me.tabPageStudentInfo.Controls.Add(Me.PictureBox4)
        Me.tabPageStudentInfo.Controls.Add(Me.MetroLabel7)
        Me.tabPageStudentInfo.Controls.Add(Me.cmbSection)
        Me.tabPageStudentInfo.Controls.Add(Me.btnUpdateStudent)
        Me.tabPageStudentInfo.Controls.Add(Me.btnAddStudent)
        Me.tabPageStudentInfo.Controls.Add(Me.cmbCourse)
        Me.tabPageStudentInfo.Controls.Add(Me.txtStudentNumber)
        Me.tabPageStudentInfo.Controls.Add(Me.cmbStatus)
        Me.tabPageStudentInfo.Controls.Add(Me.radFemale)
        Me.tabPageStudentInfo.Controls.Add(Me.radMale)
        Me.tabPageStudentInfo.Controls.Add(Me.MetroLabel1)
        Me.tabPageStudentInfo.Controls.Add(Me.txtAddress)
        Me.tabPageStudentInfo.Controls.Add(Me.txtYearLevel)
        Me.tabPageStudentInfo.Controls.Add(Me.txtLastName)
        Me.tabPageStudentInfo.Controls.Add(Me.txtFirstName)
        Me.tabPageStudentInfo.Controls.Add(Me.PictureBox1)
        Me.tabPageStudentInfo.HorizontalScrollbarBarColor = True
        Me.tabPageStudentInfo.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPageStudentInfo.HorizontalScrollbarSize = 10
        Me.tabPageStudentInfo.Location = New System.Drawing.Point(4, 38)
        Me.tabPageStudentInfo.Name = "tabPageStudentInfo"
        Me.tabPageStudentInfo.Size = New System.Drawing.Size(647, 287)
        Me.tabPageStudentInfo.TabIndex = 0
        Me.tabPageStudentInfo.Text = "Student Information"
        Me.tabPageStudentInfo.VerticalScrollbarBarColor = True
        Me.tabPageStudentInfo.VerticalScrollbarHighlightOnWheel = False
        Me.tabPageStudentInfo.VerticalScrollbarSize = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(542, 103)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 42
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(475, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 41
        Me.PictureBox4.TabStop = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(33, 19)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(187, 25)
        Me.MetroLabel7.TabIndex = 40
        Me.MetroLabel7.Text = "Add Student to Data"
        '
        'cmbSection
        '
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.ItemHeight = 23
        Me.cmbSection.Items.AddRange(New Object() {"PCEIT-03-301A", "PCEIT-03-301P", "PCEIT-03-302A", "PCEIT-03-302P", "PCEIT-03-303A", "PCEIT-03-303P"})
        Me.cmbSection.Location = New System.Drawing.Point(461, 148)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.PromptText = "Section"
        Me.cmbSection.Size = New System.Drawing.Size(147, 29)
        Me.cmbSection.TabIndex = 14
        Me.cmbSection.UseSelectable = True
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.Location = New System.Drawing.Point(461, 252)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(147, 32)
        Me.btnUpdateStudent.TabIndex = 16
        Me.btnUpdateStudent.Text = "Update"
        Me.btnUpdateStudent.UseSelectable = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(308, 252)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(147, 32)
        Me.btnAddStudent.TabIndex = 15
        Me.btnAddStudent.Text = "Add"
        Me.btnAddStudent.UseSelectable = True
        '
        'cmbCourse
        '
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 23
        Me.cmbCourse.Items.AddRange(New Object() {"Bachelor of Science in Computer Engineering", "Bachelor of Science in Civil Engineering", "Bachelor of Science in Electrical Engineering", "Bachelor of Science in Information Technology"})
        Me.cmbCourse.Location = New System.Drawing.Point(155, 148)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.PromptText = "Course"
        Me.cmbCourse.Size = New System.Drawing.Size(300, 29)
        Me.cmbCourse.TabIndex = 13
        Me.cmbCourse.UseSelectable = True
        '
        'txtStudentNumber
        '
        '
        '
        '
        Me.txtStudentNumber.CustomButton.Image = Nothing
        Me.txtStudentNumber.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtStudentNumber.CustomButton.Name = ""
        Me.txtStudentNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStudentNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStudentNumber.CustomButton.TabIndex = 1
        Me.txtStudentNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStudentNumber.CustomButton.UseSelectable = True
        Me.txtStudentNumber.CustomButton.Visible = False
        Me.txtStudentNumber.Lines = New String(-1) {}
        Me.txtStudentNumber.Location = New System.Drawing.Point(155, 119)
        Me.txtStudentNumber.MaxLength = 32767
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentNumber.PromptText = "Student No."
        Me.txtStudentNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStudentNumber.SelectedText = ""
        Me.txtStudentNumber.SelectionLength = 0
        Me.txtStudentNumber.SelectionStart = 0
        Me.txtStudentNumber.ShortcutsEnabled = True
        Me.txtStudentNumber.Size = New System.Drawing.Size(147, 23)
        Me.txtStudentNumber.TabIndex = 6
        Me.txtStudentNumber.UseSelectable = True
        Me.txtStudentNumber.WaterMark = "Student No."
        Me.txtStudentNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStudentNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.ItemHeight = 23
        Me.cmbStatus.Items.AddRange(New Object() {"Regular", "Irregular"})
        Me.cmbStatus.Location = New System.Drawing.Point(33, 148)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.PromptText = "Status"
        Me.cmbStatus.Size = New System.Drawing.Size(116, 29)
        Me.cmbStatus.TabIndex = 9
        Me.cmbStatus.UseSelectable = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(530, 82)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(61, 15)
        Me.radFemale.TabIndex = 5
        Me.radFemale.Text = "Female"
        Me.radFemale.UseSelectable = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(475, 82)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(49, 15)
        Me.radMale.TabIndex = 4
        Me.radMale.Text = "Male"
        Me.radMale.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(501, 58)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Gender"
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(278, 1)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(155, 90)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PromptText = "Address"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(300, 23)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMark = "Address"
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtYearLevel
        '
        '
        '
        '
        Me.txtYearLevel.CustomButton.Image = Nothing
        Me.txtYearLevel.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtYearLevel.CustomButton.Name = ""
        Me.txtYearLevel.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtYearLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtYearLevel.CustomButton.TabIndex = 1
        Me.txtYearLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtYearLevel.CustomButton.UseSelectable = True
        Me.txtYearLevel.CustomButton.Visible = False
        Me.txtYearLevel.Lines = New String(-1) {}
        Me.txtYearLevel.Location = New System.Drawing.Point(308, 119)
        Me.txtYearLevel.MaxLength = 32767
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearLevel.PromptText = "Year Level"
        Me.txtYearLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtYearLevel.SelectedText = ""
        Me.txtYearLevel.SelectionLength = 0
        Me.txtYearLevel.SelectionStart = 0
        Me.txtYearLevel.ShortcutsEnabled = True
        Me.txtYearLevel.Size = New System.Drawing.Size(147, 23)
        Me.txtYearLevel.TabIndex = 7
        Me.txtYearLevel.UseSelectable = True
        Me.txtYearLevel.WaterMark = "Year Level"
        Me.txtYearLevel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtYearLevel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLastName
        '
        '
        '
        '
        Me.txtLastName.CustomButton.Image = Nothing
        Me.txtLastName.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtLastName.CustomButton.Name = ""
        Me.txtLastName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastName.CustomButton.TabIndex = 1
        Me.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastName.CustomButton.UseSelectable = True
        Me.txtLastName.CustomButton.Visible = False
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(308, 61)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PromptText = "Last Name"
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShortcutsEnabled = True
        Me.txtLastName.Size = New System.Drawing.Size(147, 23)
        Me.txtLastName.TabIndex = 2
        Me.txtLastName.UseSelectable = True
        Me.txtLastName.WaterMark = "Last Name"
        Me.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFirstName
        '
        '
        '
        '
        Me.txtFirstName.CustomButton.Image = Nothing
        Me.txtFirstName.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtFirstName.CustomButton.Name = ""
        Me.txtFirstName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstName.CustomButton.TabIndex = 1
        Me.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstName.CustomButton.UseSelectable = True
        Me.txtFirstName.CustomButton.Visible = False
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(155, 61)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PromptText = "First Name"
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.ShortcutsEnabled = True
        Me.txtFirstName.Size = New System.Drawing.Size(147, 23)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.WaterMark = "First Name"
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.Location = New System.Drawing.Point(0, 249)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(644, 35)
        Me.btnDeleteStudent.TabIndex = 17
        Me.btnDeleteStudent.Text = "Delete"
        Me.btnDeleteStudent.UseSelectable = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(179, 157)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(21, 19)
        Me.lblTimer.TabIndex = 37
        Me.lblTimer.Text = "--"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabPageRecordAttendance)
        Me.MetroTabControl1.Controls.Add(Me.tabPageStudentInfo)
        Me.MetroTabControl1.Controls.Add(Me.tabPageStudentRecords)
        Me.MetroTabControl1.Controls.Add(Me.tabPageAttendanceRecord)
        Me.MetroTabControl1.Controls.Add(Me.tabPagePrintRecord)
        Me.MetroTabControl1.Controls.Add(Me.tabPagePrintAttendance)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(24, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 6
        Me.MetroTabControl1.Size = New System.Drawing.Size(655, 329)
        Me.MetroTabControl1.TabIndex = 18
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabPageRecordAttendance
        '
        Me.tabPageRecordAttendance.Controls.Add(Me.PictureBox3)
        Me.tabPageRecordAttendance.Controls.Add(Me.MetroLabel6)
        Me.tabPageRecordAttendance.Controls.Add(Me.PictureBox2)
        Me.tabPageRecordAttendance.Controls.Add(Me.lblTimer)
        Me.tabPageRecordAttendance.Controls.Add(Me.btnAddRecord)
        Me.tabPageRecordAttendance.Controls.Add(Me.cmbStudentStatus)
        Me.tabPageRecordAttendance.Controls.Add(Me.txtStudNumberStatus)
        Me.tabPageRecordAttendance.HorizontalScrollbarBarColor = True
        Me.tabPageRecordAttendance.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPageRecordAttendance.HorizontalScrollbarSize = 10
        Me.tabPageRecordAttendance.Location = New System.Drawing.Point(4, 38)
        Me.tabPageRecordAttendance.Name = "tabPageRecordAttendance"
        Me.tabPageRecordAttendance.Size = New System.Drawing.Size(647, 287)
        Me.tabPageRecordAttendance.TabIndex = 2
        Me.tabPageRecordAttendance.Text = "Record"
        Me.tabPageRecordAttendance.VerticalScrollbarBarColor = True
        Me.tabPageRecordAttendance.VerticalScrollbarHighlightOnWheel = False
        Me.tabPageRecordAttendance.VerticalScrollbarSize = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(370, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(205, 192)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(63, 53)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(207, 25)
        Me.MetroLabel6.TabIndex = 39
        Me.MetroLabel6.Text = "Add Record of Student"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(83, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(81, 182)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(232, 34)
        Me.btnAddRecord.TabIndex = 4
        Me.btnAddRecord.Text = "Add"
        Me.btnAddRecord.UseSelectable = True
        '
        'cmbStudentStatus
        '
        Me.cmbStudentStatus.FormattingEnabled = True
        Me.cmbStudentStatus.ItemHeight = 23
        Me.cmbStudentStatus.Items.AddRange(New Object() {"Present", "Absent"})
        Me.cmbStudentStatus.Location = New System.Drawing.Point(179, 122)
        Me.cmbStudentStatus.Name = "cmbStudentStatus"
        Me.cmbStudentStatus.PromptText = "Status"
        Me.cmbStudentStatus.Size = New System.Drawing.Size(134, 29)
        Me.cmbStudentStatus.TabIndex = 3
        Me.cmbStudentStatus.UseSelectable = True
        '
        'txtStudNumberStatus
        '
        '
        '
        '
        Me.txtStudNumberStatus.CustomButton.Image = Nothing
        Me.txtStudNumberStatus.CustomButton.Location = New System.Drawing.Point(112, 1)
        Me.txtStudNumberStatus.CustomButton.Name = ""
        Me.txtStudNumberStatus.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStudNumberStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStudNumberStatus.CustomButton.TabIndex = 1
        Me.txtStudNumberStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStudNumberStatus.CustomButton.UseSelectable = True
        Me.txtStudNumberStatus.CustomButton.Visible = False
        Me.txtStudNumberStatus.DisplayIcon = True
        Me.txtStudNumberStatus.Icon = CType(resources.GetObject("txtStudNumberStatus.Icon"), System.Drawing.Image)
        Me.txtStudNumberStatus.Lines = New String(-1) {}
        Me.txtStudNumberStatus.Location = New System.Drawing.Point(179, 93)
        Me.txtStudNumberStatus.MaxLength = 32767
        Me.txtStudNumberStatus.Name = "txtStudNumberStatus"
        Me.txtStudNumberStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudNumberStatus.PromptText = "Student Number"
        Me.txtStudNumberStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStudNumberStatus.SelectedText = ""
        Me.txtStudNumberStatus.SelectionLength = 0
        Me.txtStudNumberStatus.SelectionStart = 0
        Me.txtStudNumberStatus.ShortcutsEnabled = True
        Me.txtStudNumberStatus.Size = New System.Drawing.Size(134, 23)
        Me.txtStudNumberStatus.TabIndex = 2
        Me.txtStudNumberStatus.UseSelectable = True
        Me.txtStudNumberStatus.WaterMark = "Student Number"
        Me.txtStudNumberStatus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStudNumberStatus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabPageStudentRecords
        '
        Me.tabPageStudentRecords.Controls.Add(Me.pnlStudNumRecords)
        Me.tabPageStudentRecords.Controls.Add(Me.btnStudentRecordsFilter)
        Me.tabPageStudentRecords.Controls.Add(Me.radSectionRecordsFilter)
        Me.tabPageStudentRecords.Controls.Add(Me.radCourseRecordsFilter)
        Me.tabPageStudentRecords.Controls.Add(Me.radStudentRecordsNumber)
        Me.tabPageStudentRecords.Controls.Add(Me.pnlCourseRecords)
        Me.tabPageStudentRecords.Controls.Add(Me.pnlSectionRecords)
        Me.tabPageStudentRecords.Controls.Add(Me.btnDeleteStudent)
        Me.tabPageStudentRecords.Controls.Add(Me.gridStudRecord)
        Me.tabPageStudentRecords.HorizontalScrollbarBarColor = True
        Me.tabPageStudentRecords.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPageStudentRecords.HorizontalScrollbarSize = 10
        Me.tabPageStudentRecords.Location = New System.Drawing.Point(4, 38)
        Me.tabPageStudentRecords.Name = "tabPageStudentRecords"
        Me.tabPageStudentRecords.Size = New System.Drawing.Size(647, 287)
        Me.tabPageStudentRecords.TabIndex = 1
        Me.tabPageStudentRecords.Text = "Student Records"
        Me.tabPageStudentRecords.VerticalScrollbarBarColor = True
        Me.tabPageStudentRecords.VerticalScrollbarHighlightOnWheel = False
        Me.tabPageStudentRecords.VerticalScrollbarSize = 10
        '
        'pnlStudNumRecords
        '
        Me.pnlStudNumRecords.BackColor = System.Drawing.Color.Transparent
        Me.pnlStudNumRecords.Controls.Add(Me.txtStudNumRecordsFilter)
        Me.pnlStudNumRecords.Location = New System.Drawing.Point(3, 8)
        Me.pnlStudNumRecords.Name = "pnlStudNumRecords"
        Me.pnlStudNumRecords.Size = New System.Drawing.Size(169, 36)
        Me.pnlStudNumRecords.TabIndex = 54
        '
        'txtStudNumRecordsFilter
        '
        '
        '
        '
        Me.txtStudNumRecordsFilter.CustomButton.Image = Nothing
        Me.txtStudNumRecordsFilter.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtStudNumRecordsFilter.CustomButton.Name = ""
        Me.txtStudNumRecordsFilter.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStudNumRecordsFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStudNumRecordsFilter.CustomButton.TabIndex = 1
        Me.txtStudNumRecordsFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStudNumRecordsFilter.CustomButton.UseSelectable = True
        Me.txtStudNumRecordsFilter.CustomButton.Visible = False
        Me.txtStudNumRecordsFilter.Lines = New String(-1) {}
        Me.txtStudNumRecordsFilter.Location = New System.Drawing.Point(11, 6)
        Me.txtStudNumRecordsFilter.MaxLength = 32767
        Me.txtStudNumRecordsFilter.Name = "txtStudNumRecordsFilter"
        Me.txtStudNumRecordsFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudNumRecordsFilter.PromptText = "Student No."
        Me.txtStudNumRecordsFilter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStudNumRecordsFilter.SelectedText = ""
        Me.txtStudNumRecordsFilter.SelectionLength = 0
        Me.txtStudNumRecordsFilter.SelectionStart = 0
        Me.txtStudNumRecordsFilter.ShortcutsEnabled = True
        Me.txtStudNumRecordsFilter.Size = New System.Drawing.Size(147, 23)
        Me.txtStudNumRecordsFilter.TabIndex = 44
        Me.txtStudNumRecordsFilter.UseSelectable = True
        Me.txtStudNumRecordsFilter.WaterMark = "Student No."
        Me.txtStudNumRecordsFilter.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStudNumRecordsFilter.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnStudentRecordsFilter
        '
        Me.btnStudentRecordsFilter.Location = New System.Drawing.Point(567, 8)
        Me.btnStudentRecordsFilter.Name = "btnStudentRecordsFilter"
        Me.btnStudentRecordsFilter.Size = New System.Drawing.Size(77, 36)
        Me.btnStudentRecordsFilter.TabIndex = 53
        Me.btnStudentRecordsFilter.Text = "Filter"
        Me.btnStudentRecordsFilter.UseSelectable = True
        '
        'radSectionRecordsFilter
        '
        Me.radSectionRecordsFilter.AutoSize = True
        Me.radSectionRecordsFilter.Location = New System.Drawing.Point(499, 20)
        Me.radSectionRecordsFilter.Name = "radSectionRecordsFilter"
        Me.radSectionRecordsFilter.Size = New System.Drawing.Size(62, 15)
        Me.radSectionRecordsFilter.TabIndex = 52
        Me.radSectionRecordsFilter.Text = "Section"
        Me.radSectionRecordsFilter.UseSelectable = True
        '
        'radCourseRecordsFilter
        '
        Me.radCourseRecordsFilter.AutoSize = True
        Me.radCourseRecordsFilter.Location = New System.Drawing.Point(433, 20)
        Me.radCourseRecordsFilter.Name = "radCourseRecordsFilter"
        Me.radCourseRecordsFilter.Size = New System.Drawing.Size(60, 15)
        Me.radCourseRecordsFilter.TabIndex = 51
        Me.radCourseRecordsFilter.Text = "Course"
        Me.radCourseRecordsFilter.UseSelectable = True
        '
        'radStudentRecordsNumber
        '
        Me.radStudentRecordsNumber.AutoSize = True
        Me.radStudentRecordsNumber.Checked = True
        Me.radStudentRecordsNumber.Location = New System.Drawing.Point(316, 20)
        Me.radStudentRecordsNumber.Name = "radStudentRecordsNumber"
        Me.radStudentRecordsNumber.Size = New System.Drawing.Size(111, 15)
        Me.radStudentRecordsNumber.TabIndex = 50
        Me.radStudentRecordsNumber.TabStop = True
        Me.radStudentRecordsNumber.Text = "Student Number"
        Me.radStudentRecordsNumber.UseSelectable = True
        '
        'pnlCourseRecords
        '
        Me.pnlCourseRecords.BackColor = System.Drawing.Color.Transparent
        Me.pnlCourseRecords.Controls.Add(Me.cmbCourseRecordsFilter)
        Me.pnlCourseRecords.Location = New System.Drawing.Point(3, 8)
        Me.pnlCourseRecords.Name = "pnlCourseRecords"
        Me.pnlCourseRecords.Size = New System.Drawing.Size(307, 36)
        Me.pnlCourseRecords.TabIndex = 55
        '
        'cmbCourseRecordsFilter
        '
        Me.cmbCourseRecordsFilter.FormattingEnabled = True
        Me.cmbCourseRecordsFilter.ItemHeight = 23
        Me.cmbCourseRecordsFilter.Items.AddRange(New Object() {"Bachelor of Science in Computer Engineering", "Bachelor of Science in Civil Engineering", "Bachelor of Science in Electrical Engineering", "Bachelor of Science in Information Technology"})
        Me.cmbCourseRecordsFilter.Location = New System.Drawing.Point(3, 3)
        Me.cmbCourseRecordsFilter.Name = "cmbCourseRecordsFilter"
        Me.cmbCourseRecordsFilter.PromptText = "Course"
        Me.cmbCourseRecordsFilter.Size = New System.Drawing.Size(300, 29)
        Me.cmbCourseRecordsFilter.TabIndex = 45
        Me.cmbCourseRecordsFilter.UseSelectable = True
        '
        'pnlSectionRecords
        '
        Me.pnlSectionRecords.BackColor = System.Drawing.Color.Transparent
        Me.pnlSectionRecords.Controls.Add(Me.cmbSectionRecordsFilter)
        Me.pnlSectionRecords.Location = New System.Drawing.Point(3, 8)
        Me.pnlSectionRecords.Name = "pnlSectionRecords"
        Me.pnlSectionRecords.Size = New System.Drawing.Size(169, 36)
        Me.pnlSectionRecords.TabIndex = 56
        '
        'cmbSectionRecordsFilter
        '
        Me.cmbSectionRecordsFilter.FormattingEnabled = True
        Me.cmbSectionRecordsFilter.ItemHeight = 23
        Me.cmbSectionRecordsFilter.Items.AddRange(New Object() {"PCEIT-03-301A", "PCEIT-03-301P", "PCEIT-03-302A", "PCEIT-03-302P", "PCEIT-03-303A", "PCEIT-03-303P"})
        Me.cmbSectionRecordsFilter.Location = New System.Drawing.Point(12, 3)
        Me.cmbSectionRecordsFilter.Name = "cmbSectionRecordsFilter"
        Me.cmbSectionRecordsFilter.PromptText = "Section"
        Me.cmbSectionRecordsFilter.Size = New System.Drawing.Size(147, 29)
        Me.cmbSectionRecordsFilter.TabIndex = 46
        Me.cmbSectionRecordsFilter.UseSelectable = True
        '
        'gridStudRecord
        '
        Me.gridStudRecord.AllowUserToAddRows = False
        Me.gridStudRecord.AllowUserToDeleteRows = False
        Me.gridStudRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridStudRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStudRecord.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridStudRecord.Location = New System.Drawing.Point(0, 50)
        Me.gridStudRecord.Name = "gridStudRecord"
        Me.gridStudRecord.ReadOnly = True
        Me.gridStudRecord.Size = New System.Drawing.Size(644, 201)
        Me.gridStudRecord.TabIndex = 2
        '
        'tabPageAttendanceRecord
        '
        Me.tabPageAttendanceRecord.Controls.Add(Me.FilterDate)
        Me.tabPageAttendanceRecord.Controls.Add(Me.lblToAttendance)
        Me.tabPageAttendanceRecord.Controls.Add(Me.lblFromAttendance)
        Me.tabPageAttendanceRecord.Controls.Add(Me.MetroLabel4)
        Me.tabPageAttendanceRecord.Controls.Add(Me.MetroLabel5)
        Me.tabPageAttendanceRecord.Controls.Add(Me.lblAbsentCounter)
        Me.tabPageAttendanceRecord.Controls.Add(Me.lblPresentCounter)
        Me.tabPageAttendanceRecord.Controls.Add(Me.MetroDateTime2)
        Me.tabPageAttendanceRecord.Controls.Add(Me.MetroDateTime1)
        Me.tabPageAttendanceRecord.Controls.Add(Me.pnlAttendanceStudNo)
        Me.tabPageAttendanceRecord.Controls.Add(Me.btnAttendanceFilter)
        Me.tabPageAttendanceRecord.Controls.Add(Me.radAttendanceSection)
        Me.tabPageAttendanceRecord.Controls.Add(Me.radAttendanceCourse)
        Me.tabPageAttendanceRecord.Controls.Add(Me.radAttendanceStudNo)
        Me.tabPageAttendanceRecord.Controls.Add(Me.gridAttendanceRecord)
        Me.tabPageAttendanceRecord.Controls.Add(Me.gridDataRecord)
        Me.tabPageAttendanceRecord.Controls.Add(Me.pnlAttendanceCourse)
        Me.tabPageAttendanceRecord.Controls.Add(Me.pnlAttendanceSection)
        Me.tabPageAttendanceRecord.HorizontalScrollbarBarColor = True
        Me.tabPageAttendanceRecord.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPageAttendanceRecord.HorizontalScrollbarSize = 10
        Me.tabPageAttendanceRecord.Location = New System.Drawing.Point(4, 38)
        Me.tabPageAttendanceRecord.Name = "tabPageAttendanceRecord"
        Me.tabPageAttendanceRecord.Size = New System.Drawing.Size(647, 287)
        Me.tabPageAttendanceRecord.TabIndex = 3
        Me.tabPageAttendanceRecord.Text = "Attendance Record"
        Me.tabPageAttendanceRecord.VerticalScrollbarBarColor = True
        Me.tabPageAttendanceRecord.VerticalScrollbarHighlightOnWheel = False
        Me.tabPageAttendanceRecord.VerticalScrollbarSize = 10
        '
        'FilterDate
        '
        Me.FilterDate.Location = New System.Drawing.Point(550, 226)
        Me.FilterDate.Name = "FilterDate"
        Me.FilterDate.Size = New System.Drawing.Size(86, 59)
        Me.FilterDate.TabIndex = 56
        Me.FilterDate.Text = "Filter"
        Me.FilterDate.UseSelectable = True
        '
        'lblToAttendance
        '
        Me.lblToAttendance.AutoSize = True
        Me.lblToAttendance.Location = New System.Drawing.Point(403, 261)
        Me.lblToAttendance.Name = "lblToAttendance"
        Me.lblToAttendance.Size = New System.Drawing.Size(22, 19)
        Me.lblToAttendance.TabIndex = 55
        Me.lblToAttendance.Text = "To"
        '
        'lblFromAttendance
        '
        Me.lblFromAttendance.AutoSize = True
        Me.lblFromAttendance.Location = New System.Drawing.Point(389, 229)
        Me.lblFromAttendance.Name = "lblFromAttendance"
        Me.lblFromAttendance.Size = New System.Drawing.Size(41, 19)
        Me.lblFromAttendance.TabIndex = 54
        Me.lblFromAttendance.Text = "From"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(416, 181)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel4.TabIndex = 38
        Me.MetroLabel4.Text = "Total Absent"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(519, 181)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel5.TabIndex = 39
        Me.MetroLabel5.Text = "Total Present"
        '
        'lblAbsentCounter
        '
        Me.lblAbsentCounter.AutoSize = True
        Me.lblAbsentCounter.Location = New System.Drawing.Point(448, 204)
        Me.lblAbsentCounter.Name = "lblAbsentCounter"
        Me.lblAbsentCounter.Size = New System.Drawing.Size(21, 19)
        Me.lblAbsentCounter.TabIndex = 51
        Me.lblAbsentCounter.Text = "--"
        '
        'lblPresentCounter
        '
        Me.lblPresentCounter.AutoSize = True
        Me.lblPresentCounter.Location = New System.Drawing.Point(553, 204)
        Me.lblPresentCounter.Name = "lblPresentCounter"
        Me.lblPresentCounter.Size = New System.Drawing.Size(21, 19)
        Me.lblPresentCounter.TabIndex = 52
        Me.lblPresentCounter.Text = "--"
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime2.Location = New System.Drawing.Point(436, 256)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(4, 29)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(108, 29)
        Me.MetroDateTime2.TabIndex = 53
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(436, 224)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(4, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(108, 29)
        Me.MetroDateTime1.TabIndex = 50
        '
        'pnlAttendanceStudNo
        '
        Me.pnlAttendanceStudNo.BackColor = System.Drawing.Color.Transparent
        Me.pnlAttendanceStudNo.Controls.Add(Me.txtAttendanceStudNoFilter)
        Me.pnlAttendanceStudNo.Location = New System.Drawing.Point(3, 8)
        Me.pnlAttendanceStudNo.Name = "pnlAttendanceStudNo"
        Me.pnlAttendanceStudNo.Size = New System.Drawing.Size(169, 36)
        Me.pnlAttendanceStudNo.TabIndex = 47
        '
        'txtAttendanceStudNoFilter
        '
        '
        '
        '
        Me.txtAttendanceStudNoFilter.CustomButton.Image = Nothing
        Me.txtAttendanceStudNoFilter.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtAttendanceStudNoFilter.CustomButton.Name = ""
        Me.txtAttendanceStudNoFilter.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAttendanceStudNoFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAttendanceStudNoFilter.CustomButton.TabIndex = 1
        Me.txtAttendanceStudNoFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAttendanceStudNoFilter.CustomButton.UseSelectable = True
        Me.txtAttendanceStudNoFilter.CustomButton.Visible = False
        Me.txtAttendanceStudNoFilter.Lines = New String(-1) {}
        Me.txtAttendanceStudNoFilter.Location = New System.Drawing.Point(11, 6)
        Me.txtAttendanceStudNoFilter.MaxLength = 32767
        Me.txtAttendanceStudNoFilter.Name = "txtAttendanceStudNoFilter"
        Me.txtAttendanceStudNoFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAttendanceStudNoFilter.PromptText = "Student No."
        Me.txtAttendanceStudNoFilter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAttendanceStudNoFilter.SelectedText = ""
        Me.txtAttendanceStudNoFilter.SelectionLength = 0
        Me.txtAttendanceStudNoFilter.SelectionStart = 0
        Me.txtAttendanceStudNoFilter.ShortcutsEnabled = True
        Me.txtAttendanceStudNoFilter.Size = New System.Drawing.Size(147, 23)
        Me.txtAttendanceStudNoFilter.TabIndex = 44
        Me.txtAttendanceStudNoFilter.UseSelectable = True
        Me.txtAttendanceStudNoFilter.WaterMark = "Student No."
        Me.txtAttendanceStudNoFilter.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAttendanceStudNoFilter.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAttendanceFilter
        '
        Me.btnAttendanceFilter.Location = New System.Drawing.Point(567, 8)
        Me.btnAttendanceFilter.Name = "btnAttendanceFilter"
        Me.btnAttendanceFilter.Size = New System.Drawing.Size(77, 36)
        Me.btnAttendanceFilter.TabIndex = 43
        Me.btnAttendanceFilter.Text = "Filter"
        Me.btnAttendanceFilter.UseSelectable = True
        '
        'radAttendanceSection
        '
        Me.radAttendanceSection.AutoSize = True
        Me.radAttendanceSection.Location = New System.Drawing.Point(499, 20)
        Me.radAttendanceSection.Name = "radAttendanceSection"
        Me.radAttendanceSection.Size = New System.Drawing.Size(62, 15)
        Me.radAttendanceSection.TabIndex = 42
        Me.radAttendanceSection.Text = "Section"
        Me.radAttendanceSection.UseSelectable = True
        '
        'radAttendanceCourse
        '
        Me.radAttendanceCourse.AutoSize = True
        Me.radAttendanceCourse.Location = New System.Drawing.Point(433, 20)
        Me.radAttendanceCourse.Name = "radAttendanceCourse"
        Me.radAttendanceCourse.Size = New System.Drawing.Size(60, 15)
        Me.radAttendanceCourse.TabIndex = 41
        Me.radAttendanceCourse.Text = "Course"
        Me.radAttendanceCourse.UseSelectable = True
        '
        'radAttendanceStudNo
        '
        Me.radAttendanceStudNo.AutoSize = True
        Me.radAttendanceStudNo.Checked = True
        Me.radAttendanceStudNo.Location = New System.Drawing.Point(316, 20)
        Me.radAttendanceStudNo.Name = "radAttendanceStudNo"
        Me.radAttendanceStudNo.Size = New System.Drawing.Size(111, 15)
        Me.radAttendanceStudNo.TabIndex = 40
        Me.radAttendanceStudNo.TabStop = True
        Me.radAttendanceStudNo.Text = "Student Number"
        Me.radAttendanceStudNo.UseSelectable = True
        '
        'gridAttendanceRecord
        '
        Me.gridAttendanceRecord.AllowUserToAddRows = False
        Me.gridAttendanceRecord.AllowUserToDeleteRows = False
        Me.gridAttendanceRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridAttendanceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAttendanceRecord.ContextMenuStrip = Me.ContextMenuStrip2
        Me.gridAttendanceRecord.Location = New System.Drawing.Point(0, 177)
        Me.gridAttendanceRecord.Name = "gridAttendanceRecord"
        Me.gridAttendanceRecord.ReadOnly = True
        Me.gridAttendanceRecord.Size = New System.Drawing.Size(376, 110)
        Me.gridAttendanceRecord.TabIndex = 4
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRecordToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(148, 26)
        '
        'DeleteRecordToolStripMenuItem
        '
        Me.DeleteRecordToolStripMenuItem.Name = "DeleteRecordToolStripMenuItem"
        Me.DeleteRecordToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DeleteRecordToolStripMenuItem.Text = "Delete Record"
        '
        'gridDataRecord
        '
        Me.gridDataRecord.AllowUserToAddRows = False
        Me.gridDataRecord.AllowUserToDeleteRows = False
        Me.gridDataRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridDataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDataRecord.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridDataRecord.Location = New System.Drawing.Point(0, 50)
        Me.gridDataRecord.Name = "gridDataRecord"
        Me.gridDataRecord.ReadOnly = True
        Me.gridDataRecord.Size = New System.Drawing.Size(644, 128)
        Me.gridDataRecord.TabIndex = 3
        '
        'pnlAttendanceCourse
        '
        Me.pnlAttendanceCourse.BackColor = System.Drawing.Color.Transparent
        Me.pnlAttendanceCourse.Controls.Add(Me.cmbAttendanceCourseFilter)
        Me.pnlAttendanceCourse.Location = New System.Drawing.Point(3, 8)
        Me.pnlAttendanceCourse.Name = "pnlAttendanceCourse"
        Me.pnlAttendanceCourse.Size = New System.Drawing.Size(307, 36)
        Me.pnlAttendanceCourse.TabIndex = 48
        '
        'cmbAttendanceCourseFilter
        '
        Me.cmbAttendanceCourseFilter.FormattingEnabled = True
        Me.cmbAttendanceCourseFilter.ItemHeight = 23
        Me.cmbAttendanceCourseFilter.Items.AddRange(New Object() {"Bachelor of Science in Computer Engineering", "Bachelor of Science in Civil Engineering", "Bachelor of Science in Electrical Engineering", "Bachelor of Science in Information Technology"})
        Me.cmbAttendanceCourseFilter.Location = New System.Drawing.Point(3, 3)
        Me.cmbAttendanceCourseFilter.Name = "cmbAttendanceCourseFilter"
        Me.cmbAttendanceCourseFilter.PromptText = "Course"
        Me.cmbAttendanceCourseFilter.Size = New System.Drawing.Size(300, 29)
        Me.cmbAttendanceCourseFilter.TabIndex = 45
        Me.cmbAttendanceCourseFilter.UseSelectable = True
        '
        'pnlAttendanceSection
        '
        Me.pnlAttendanceSection.BackColor = System.Drawing.Color.Transparent
        Me.pnlAttendanceSection.Controls.Add(Me.cmbAttendanceSectionFilter)
        Me.pnlAttendanceSection.Location = New System.Drawing.Point(3, 8)
        Me.pnlAttendanceSection.Name = "pnlAttendanceSection"
        Me.pnlAttendanceSection.Size = New System.Drawing.Size(169, 36)
        Me.pnlAttendanceSection.TabIndex = 49
        '
        'cmbAttendanceSectionFilter
        '
        Me.cmbAttendanceSectionFilter.FormattingEnabled = True
        Me.cmbAttendanceSectionFilter.ItemHeight = 23
        Me.cmbAttendanceSectionFilter.Items.AddRange(New Object() {"PCEIT-03-301A", "PCEIT-03-301P", "PCEIT-03-302A", "PCEIT-03-302P", "PCEIT-03-303A", "PCEIT-03-303P"})
        Me.cmbAttendanceSectionFilter.Location = New System.Drawing.Point(12, 3)
        Me.cmbAttendanceSectionFilter.Name = "cmbAttendanceSectionFilter"
        Me.cmbAttendanceSectionFilter.PromptText = "Section"
        Me.cmbAttendanceSectionFilter.Size = New System.Drawing.Size(147, 29)
        Me.cmbAttendanceSectionFilter.TabIndex = 46
        Me.cmbAttendanceSectionFilter.UseSelectable = True
        '
        'tabPagePrintRecord
        '
        Me.tabPagePrintRecord.Controls.Add(Me.btnClearFile)
        Me.tabPagePrintRecord.Controls.Add(Me.btnSaveFile)
        Me.tabPagePrintRecord.Controls.Add(Me.PrintPreviewControl1)
        Me.tabPagePrintRecord.HorizontalScrollbarBarColor = True
        Me.tabPagePrintRecord.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPagePrintRecord.HorizontalScrollbarSize = 10
        Me.tabPagePrintRecord.Location = New System.Drawing.Point(4, 38)
        Me.tabPagePrintRecord.Name = "tabPagePrintRecord"
        Me.tabPagePrintRecord.Size = New System.Drawing.Size(647, 287)
        Me.tabPagePrintRecord.TabIndex = 4
        Me.tabPagePrintRecord.Text = "Print Record"
        Me.tabPagePrintRecord.VerticalScrollbarBarColor = True
        Me.tabPagePrintRecord.VerticalScrollbarHighlightOnWheel = False
        Me.tabPagePrintRecord.VerticalScrollbarSize = 10
        '
        'btnClearFile
        '
        Me.btnClearFile.Location = New System.Drawing.Point(538, 251)
        Me.btnClearFile.Name = "btnClearFile"
        Me.btnClearFile.Size = New System.Drawing.Size(106, 33)
        Me.btnClearFile.TabIndex = 21
        Me.btnClearFile.Text = "Clear"
        Me.btnClearFile.UseSelectable = True
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(426, 251)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(106, 33)
        Me.btnSaveFile.TabIndex = 20
        Me.btnSaveFile.Text = "Save"
        Me.btnSaveFile.UseSelectable = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(3, 3)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(641, 242)
        Me.PrintPreviewControl1.TabIndex = 20
        Me.PrintPreviewControl1.Zoom = 1.0R
        '
        'tabPagePrintAttendance
        '
        Me.tabPagePrintAttendance.Controls.Add(Me.courseFilterAttendance)
        Me.tabPagePrintAttendance.Controls.Add(Me.sectionFilterAttendance)
        Me.tabPagePrintAttendance.Controls.Add(Me.btnSaveAttendance)
        Me.tabPagePrintAttendance.Controls.Add(Me.MetroRadioButton2)
        Me.tabPagePrintAttendance.Controls.Add(Me.btnClearAttendance)
        Me.tabPagePrintAttendance.Controls.Add(Me.btnSearchAttendance)
        Me.tabPagePrintAttendance.Controls.Add(Me.MetroRadioButton1)
        Me.tabPagePrintAttendance.Controls.Add(Me.PrintPreviewControl2)
        Me.tabPagePrintAttendance.Controls.Add(Me.MetroDateTime3)
        Me.tabPagePrintAttendance.Controls.Add(Me.MetroDateTime4)
        Me.tabPagePrintAttendance.Controls.Add(Me.lblFromAttendanceRecord)
        Me.tabPagePrintAttendance.Controls.Add(Me.lblToAttendanceRecord)
        Me.tabPagePrintAttendance.HorizontalScrollbarBarColor = True
        Me.tabPagePrintAttendance.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPagePrintAttendance.HorizontalScrollbarSize = 10
        Me.tabPagePrintAttendance.Location = New System.Drawing.Point(4, 38)
        Me.tabPagePrintAttendance.Name = "tabPagePrintAttendance"
        Me.tabPagePrintAttendance.Size = New System.Drawing.Size(647, 287)
        Me.tabPagePrintAttendance.TabIndex = 5
        Me.tabPagePrintAttendance.Text = "Print Attendance"
        Me.tabPagePrintAttendance.VerticalScrollbarBarColor = True
        Me.tabPagePrintAttendance.VerticalScrollbarHighlightOnWheel = False
        Me.tabPagePrintAttendance.VerticalScrollbarSize = 10
        '
        'courseFilterAttendance
        '
        Me.courseFilterAttendance.BackColor = System.Drawing.Color.Transparent
        Me.courseFilterAttendance.Controls.Add(Me.cmbCourseAttendance)
        Me.courseFilterAttendance.Location = New System.Drawing.Point(174, 208)
        Me.courseFilterAttendance.Name = "courseFilterAttendance"
        Me.courseFilterAttendance.Size = New System.Drawing.Size(307, 36)
        Me.courseFilterAttendance.TabIndex = 62
        '
        'cmbCourseAttendance
        '
        Me.cmbCourseAttendance.FormattingEnabled = True
        Me.cmbCourseAttendance.ItemHeight = 23
        Me.cmbCourseAttendance.Items.AddRange(New Object() {"Bachelor of Science in Computer Engineering", "Bachelor of Science in Civil Engineering", "Bachelor of Science in Electrical Engineering", "Bachelor of Science in Information Technology"})
        Me.cmbCourseAttendance.Location = New System.Drawing.Point(3, 3)
        Me.cmbCourseAttendance.Name = "cmbCourseAttendance"
        Me.cmbCourseAttendance.PromptText = "Course"
        Me.cmbCourseAttendance.Size = New System.Drawing.Size(300, 29)
        Me.cmbCourseAttendance.TabIndex = 45
        Me.cmbCourseAttendance.UseSelectable = True
        '
        'sectionFilterAttendance
        '
        Me.sectionFilterAttendance.BackColor = System.Drawing.Color.Transparent
        Me.sectionFilterAttendance.Controls.Add(Me.cmbSectionAttendance)
        Me.sectionFilterAttendance.Location = New System.Drawing.Point(174, 208)
        Me.sectionFilterAttendance.Name = "sectionFilterAttendance"
        Me.sectionFilterAttendance.Size = New System.Drawing.Size(169, 36)
        Me.sectionFilterAttendance.TabIndex = 63
        '
        'cmbSectionAttendance
        '
        Me.cmbSectionAttendance.FormattingEnabled = True
        Me.cmbSectionAttendance.ItemHeight = 23
        Me.cmbSectionAttendance.Items.AddRange(New Object() {"PCEIT-03-301A", "PCEIT-03-301P", "PCEIT-03-302A", "PCEIT-03-302P", "PCEIT-03-303A", "PCEIT-03-303P"})
        Me.cmbSectionAttendance.Location = New System.Drawing.Point(12, 3)
        Me.cmbSectionAttendance.Name = "cmbSectionAttendance"
        Me.cmbSectionAttendance.PromptText = "Section"
        Me.cmbSectionAttendance.Size = New System.Drawing.Size(147, 29)
        Me.cmbSectionAttendance.TabIndex = 46
        Me.cmbSectionAttendance.UseSelectable = True
        '
        'btnSaveAttendance
        '
        Me.btnSaveAttendance.Location = New System.Drawing.Point(487, 251)
        Me.btnSaveAttendance.Name = "btnSaveAttendance"
        Me.btnSaveAttendance.Size = New System.Drawing.Size(74, 33)
        Me.btnSaveAttendance.TabIndex = 22
        Me.btnSaveAttendance.Text = "Save"
        Me.btnSaveAttendance.UseSelectable = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(343, 257)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(78, 15)
        Me.MetroRadioButton2.TabIndex = 63
        Me.MetroRadioButton2.Text = "By Section"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'btnClearAttendance
        '
        Me.btnClearAttendance.Location = New System.Drawing.Point(568, 251)
        Me.btnClearAttendance.Name = "btnClearAttendance"
        Me.btnClearAttendance.Size = New System.Drawing.Size(74, 33)
        Me.btnClearAttendance.TabIndex = 23
        Me.btnClearAttendance.Text = "Clear"
        Me.btnClearAttendance.UseSelectable = True
        '
        'btnSearchAttendance
        '
        Me.btnSearchAttendance.Location = New System.Drawing.Point(487, 211)
        Me.btnSearchAttendance.Name = "btnSearchAttendance"
        Me.btnSearchAttendance.Size = New System.Drawing.Size(155, 36)
        Me.btnSearchAttendance.TabIndex = 61
        Me.btnSearchAttendance.Text = "Search"
        Me.btnSearchAttendance.UseSelectable = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Checked = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(231, 257)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(76, 15)
        Me.MetroRadioButton1.TabIndex = 62
        Me.MetroRadioButton1.TabStop = True
        Me.MetroRadioButton1.Text = "By Course"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'PrintPreviewControl2
        '
        Me.PrintPreviewControl2.AutoZoom = False
        Me.PrintPreviewControl2.Location = New System.Drawing.Point(3, 3)
        Me.PrintPreviewControl2.Name = "PrintPreviewControl2"
        Me.PrintPreviewControl2.Size = New System.Drawing.Size(641, 194)
        Me.PrintPreviewControl2.TabIndex = 21
        Me.PrintPreviewControl2.Zoom = 1.0R
        '
        'MetroDateTime3
        '
        Me.MetroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime3.Location = New System.Drawing.Point(60, 211)
        Me.MetroDateTime3.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime3.Name = "MetroDateTime3"
        Me.MetroDateTime3.Size = New System.Drawing.Size(108, 29)
        Me.MetroDateTime3.TabIndex = 57
        '
        'MetroDateTime4
        '
        Me.MetroDateTime4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime4.Location = New System.Drawing.Point(60, 246)
        Me.MetroDateTime4.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime4.Name = "MetroDateTime4"
        Me.MetroDateTime4.Size = New System.Drawing.Size(108, 29)
        Me.MetroDateTime4.TabIndex = 58
        '
        'lblFromAttendanceRecord
        '
        Me.lblFromAttendanceRecord.AutoSize = True
        Me.lblFromAttendanceRecord.Location = New System.Drawing.Point(13, 216)
        Me.lblFromAttendanceRecord.Name = "lblFromAttendanceRecord"
        Me.lblFromAttendanceRecord.Size = New System.Drawing.Size(41, 19)
        Me.lblFromAttendanceRecord.TabIndex = 59
        Me.lblFromAttendanceRecord.Text = "From"
        '
        'lblToAttendanceRecord
        '
        Me.lblToAttendanceRecord.AutoSize = True
        Me.lblToAttendanceRecord.Location = New System.Drawing.Point(27, 251)
        Me.lblToAttendanceRecord.Name = "lblToAttendanceRecord"
        Me.lblToAttendanceRecord.Size = New System.Drawing.Size(22, 19)
        Me.lblToAttendanceRecord.TabIndex = 60
        Me.lblToAttendanceRecord.Text = "To"
        '
        'Timer1
        '
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(399, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(89, 23)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseSelectable = True
        '
        'PrintDocument1
        '
        '
        'PrintDocument2
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.DataGridView1.Location = New System.Drawing.Point(-566, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(376, 110)
        Me.DataGridView1.TabIndex = 20
        '
        'tempDataGridRecord
        '
        Me.tempDataGridRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tempDataGridRecord.Location = New System.Drawing.Point(-2099, 29)
        Me.tempDataGridRecord.Name = "tempDataGridRecord"
        Me.tempDataGridRecord.Size = New System.Drawing.Size(240, 150)
        Me.tempDataGridRecord.TabIndex = 21
        '
        'txtLogs
        '
        Me.txtLogs.Location = New System.Drawing.Point(3, 3)
        Me.txtLogs.Name = "txtLogs"
        Me.txtLogs.Size = New System.Drawing.Size(641, 231)
        Me.txtLogs.TabIndex = 41
        Me.txtLogs.Text = ""
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnClearLogs)
        Me.MetroTabPage1.Controls.Add(Me.txtLogs)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(647, 287)
        Me.MetroTabPage1.TabIndex = 6
        Me.MetroTabPage1.Text = "Logs"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(3, 240)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(641, 44)
        Me.btnClearLogs.TabIndex = 42
        Me.btnClearLogs.Text = "Clear Logs"
        Me.btnClearLogs.UseSelectable = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 415)
        Me.Controls.Add(Me.tempDataGridRecord)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "Main"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tabPageStudentInfo.ResumeLayout(False)
        Me.tabPageStudentInfo.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabPageRecordAttendance.ResumeLayout(False)
        Me.tabPageRecordAttendance.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageStudentRecords.ResumeLayout(False)
        Me.tabPageStudentRecords.PerformLayout()
        Me.pnlStudNumRecords.ResumeLayout(False)
        Me.pnlCourseRecords.ResumeLayout(False)
        Me.pnlSectionRecords.ResumeLayout(False)
        CType(Me.gridStudRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageAttendanceRecord.ResumeLayout(False)
        Me.tabPageAttendanceRecord.PerformLayout()
        Me.pnlAttendanceStudNo.ResumeLayout(False)
        CType(Me.gridAttendanceRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.gridDataRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAttendanceCourse.ResumeLayout(False)
        Me.pnlAttendanceSection.ResumeLayout(False)
        Me.tabPagePrintRecord.ResumeLayout(False)
        Me.tabPagePrintAttendance.ResumeLayout(False)
        Me.tabPagePrintAttendance.PerformLayout()
        Me.courseFilterAttendance.ResumeLayout(False)
        Me.sectionFilterAttendance.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempDataGridRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabPageStudentInfo As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtYearLevel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStudentNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents radFemale As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMale As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnDeleteStudent As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUpdateStudent As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddStudent As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbCourse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblTimer As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tabPageStudentRecords As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gridStudRecord As DataGridView
    Friend WithEvents tabPageRecordAttendance As MetroFramework.Controls.MetroTabPage
    Friend WithEvents cmbSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabPageAttendanceRecord As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gridAttendanceRecord As DataGridView
    Friend WithEvents btnAddRecord As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbStudentStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtStudNumberStatus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeleteRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlAttendanceStudNo As Panel
    Friend WithEvents txtAttendanceStudNoFilter As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAttendanceFilter As MetroFramework.Controls.MetroButton
    Friend WithEvents radAttendanceSection As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radAttendanceCourse As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radAttendanceStudNo As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents pnlAttendanceCourse As Panel
    Friend WithEvents cmbAttendanceCourseFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents pnlAttendanceSection As Panel
    Friend WithEvents cmbAttendanceSectionFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnLogout As MetroFramework.Controls.MetroButton
    Friend WithEvents tabPagePrintRecord As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnSaveFile As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlStudNumRecords As Panel
    Friend WithEvents txtStudNumRecordsFilter As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnStudentRecordsFilter As MetroFramework.Controls.MetroButton
    Friend WithEvents radSectionRecordsFilter As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radCourseRecordsFilter As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radStudentRecordsNumber As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents pnlCourseRecords As Panel
    Friend WithEvents cmbCourseRecordsFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents pnlSectionRecords As Panel
    Friend WithEvents cmbSectionRecordsFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblPresentCounter As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAbsentCounter As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents FilterDate As MetroFramework.Controls.MetroButton
    Friend WithEvents lblToAttendance As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFromAttendance As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClearFile As MetroFramework.Controls.MetroButton
    Friend WithEvents tabPagePrintAttendance As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnClearAttendance As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveAttendance As MetroFramework.Controls.MetroButton
    Friend WithEvents PrintPreviewControl2 As PrintPreviewControl
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents btnSearchAttendance As MetroFramework.Controls.MetroButton
    Friend WithEvents lblToAttendanceRecord As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFromAttendanceRecord As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime4 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroDateTime3 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents gridDataRecord As DataGridView
    Friend WithEvents courseFilterAttendance As Panel
    Friend WithEvents cmbCourseAttendance As MetroFramework.Controls.MetroComboBox
    Friend WithEvents sectionFilterAttendance As Panel
    Friend WithEvents cmbSectionAttendance As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tempDataGridRecord As DataGridView
    Friend WithEvents txtLogs As RichTextBox
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnClearLogs As MetroFramework.Controls.MetroButton
End Class
