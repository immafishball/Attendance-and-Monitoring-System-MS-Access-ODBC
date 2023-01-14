<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTimer = New MetroFramework.Controls.MetroLabel()
        Me.btnAddRecord = New MetroFramework.Controls.MetroButton()
        Me.cmbStudentStatus = New MetroFramework.Controls.MetroComboBox()
        Me.txtStudNumberStatus = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.gridAttendanceRecord = New System.Windows.Forms.DataGridView()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cmbSection = New MetroFramework.Controls.MetroComboBox()
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
        Me.btnLogout = New MetroFramework.Controls.MetroButton()
        Me.gridTemp = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.gridAttendanceRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(593, 360)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.PictureBox3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.PictureBox2)
        Me.MetroTabPage1.Controls.Add(Me.lblTimer)
        Me.MetroTabPage1.Controls.Add(Me.btnAddRecord)
        Me.MetroTabPage1.Controls.Add(Me.cmbStudentStatus)
        Me.MetroTabPage1.Controls.Add(Me.txtStudNumberStatus)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(585, 318)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Record"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(343, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(205, 192)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(36, 65)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(207, 25)
        Me.MetroLabel6.TabIndex = 46
        Me.MetroLabel6.Text = "Add Record of Student"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(56, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(152, 169)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(21, 19)
        Me.lblTimer.TabIndex = 44
        Me.lblTimer.Text = "--"
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(54, 194)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(232, 34)
        Me.btnAddRecord.TabIndex = 43
        Me.btnAddRecord.Text = "Add"
        Me.btnAddRecord.UseSelectable = True
        '
        'cmbStudentStatus
        '
        Me.cmbStudentStatus.FormattingEnabled = True
        Me.cmbStudentStatus.ItemHeight = 23
        Me.cmbStudentStatus.Items.AddRange(New Object() {"Present", "Absent"})
        Me.cmbStudentStatus.Location = New System.Drawing.Point(152, 134)
        Me.cmbStudentStatus.Name = "cmbStudentStatus"
        Me.cmbStudentStatus.PromptText = "Status"
        Me.cmbStudentStatus.Size = New System.Drawing.Size(134, 29)
        Me.cmbStudentStatus.TabIndex = 42
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
        Me.txtStudNumberStatus.Location = New System.Drawing.Point(152, 105)
        Me.txtStudNumberStatus.MaxLength = 32767
        Me.txtStudNumberStatus.Name = "txtStudNumberStatus"
        Me.txtStudNumberStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudNumberStatus.PromptText = "Student Number"
        Me.txtStudNumberStatus.ReadOnly = True
        Me.txtStudNumberStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStudNumberStatus.SelectedText = ""
        Me.txtStudNumberStatus.SelectionLength = 0
        Me.txtStudNumberStatus.SelectionStart = 0
        Me.txtStudNumberStatus.ShortcutsEnabled = True
        Me.txtStudNumberStatus.Size = New System.Drawing.Size(134, 23)
        Me.txtStudNumberStatus.TabIndex = 41
        Me.txtStudNumberStatus.UseSelectable = True
        Me.txtStudNumberStatus.WaterMark = "Student Number"
        Me.txtStudNumberStatus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStudNumberStatus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.gridAttendanceRecord)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage2.Controls.Add(Me.PictureBox5)
        Me.MetroTabPage2.Controls.Add(Me.PictureBox4)
        Me.MetroTabPage2.Controls.Add(Me.cmbSection)
        Me.MetroTabPage2.Controls.Add(Me.cmbCourse)
        Me.MetroTabPage2.Controls.Add(Me.txtStudentNumber)
        Me.MetroTabPage2.Controls.Add(Me.cmbStatus)
        Me.MetroTabPage2.Controls.Add(Me.radFemale)
        Me.MetroTabPage2.Controls.Add(Me.radMale)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage2.Controls.Add(Me.txtAddress)
        Me.MetroTabPage2.Controls.Add(Me.txtYearLevel)
        Me.MetroTabPage2.Controls.Add(Me.txtLastName)
        Me.MetroTabPage2.Controls.Add(Me.txtFirstName)
        Me.MetroTabPage2.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(585, 318)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Student Information"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'gridAttendanceRecord
        '
        Me.gridAttendanceRecord.AllowUserToAddRows = False
        Me.gridAttendanceRecord.AllowUserToDeleteRows = False
        Me.gridAttendanceRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gridAttendanceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAttendanceRecord.Location = New System.Drawing.Point(5, 158)
        Me.gridAttendanceRecord.Name = "gridAttendanceRecord"
        Me.gridAttendanceRecord.ReadOnly = True
        Me.gridAttendanceRecord.Size = New System.Drawing.Size(575, 157)
        Me.gridAttendanceRecord.TabIndex = 58
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(5, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(574, 19)
        Me.MetroLabel2.TabIndex = 57
        Me.MetroLabel2.Text = "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ My Attendance ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" &
    "━"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(514, 59)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 56
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(447, 59)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 55
        Me.PictureBox4.TabStop = False
        '
        'cmbSection
        '
        Me.cmbSection.Enabled = False
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.ItemHeight = 23
        Me.cmbSection.Items.AddRange(New Object() {"PCEIT-03-301A", "PCEIT-03-301P", "PCEIT-03-302A", "PCEIT-03-302P", "PCEIT-03-303A", "PCEIT-03-303P"})
        Me.cmbSection.Location = New System.Drawing.Point(433, 104)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.PromptText = "Section"
        Me.cmbSection.Size = New System.Drawing.Size(147, 29)
        Me.cmbSection.TabIndex = 54
        Me.cmbSection.UseSelectable = True
        '
        'cmbCourse
        '
        Me.cmbCourse.Enabled = False
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.ItemHeight = 23
        Me.cmbCourse.Items.AddRange(New Object() {"Bachelor of Science in Computer Engineering", "Bachelor of Science in Civil Engineering", "Bachelor of Science in Electrical Engineering", "Bachelor of Science in Information Technology"})
        Me.cmbCourse.Location = New System.Drawing.Point(127, 104)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.PromptText = "Course"
        Me.cmbCourse.Size = New System.Drawing.Size(300, 29)
        Me.cmbCourse.TabIndex = 53
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
        Me.txtStudentNumber.Location = New System.Drawing.Point(127, 75)
        Me.txtStudentNumber.MaxLength = 32767
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentNumber.PromptText = "Student No."
        Me.txtStudentNumber.ReadOnly = True
        Me.txtStudentNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStudentNumber.SelectedText = ""
        Me.txtStudentNumber.SelectionLength = 0
        Me.txtStudentNumber.SelectionStart = 0
        Me.txtStudentNumber.ShortcutsEnabled = True
        Me.txtStudentNumber.Size = New System.Drawing.Size(147, 23)
        Me.txtStudentNumber.TabIndex = 48
        Me.txtStudentNumber.UseSelectable = True
        Me.txtStudentNumber.WaterMark = "Student No."
        Me.txtStudentNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStudentNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbStatus
        '
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.ItemHeight = 23
        Me.cmbStatus.Items.AddRange(New Object() {"Regular", "Irregular"})
        Me.cmbStatus.Location = New System.Drawing.Point(5, 104)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.PromptText = "Status"
        Me.cmbStatus.Size = New System.Drawing.Size(116, 29)
        Me.cmbStatus.TabIndex = 50
        Me.cmbStatus.UseSelectable = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Enabled = False
        Me.radFemale.Location = New System.Drawing.Point(502, 38)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(61, 15)
        Me.radFemale.TabIndex = 47
        Me.radFemale.Text = "Female"
        Me.radFemale.UseSelectable = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Enabled = False
        Me.radMale.Location = New System.Drawing.Point(447, 38)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(49, 15)
        Me.radMale.TabIndex = 46
        Me.radMale.Text = "Male"
        Me.radMale.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(473, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 52
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
        Me.txtAddress.Location = New System.Drawing.Point(127, 46)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PromptText = "Address"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(300, 23)
        Me.txtAddress.TabIndex = 45
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
        Me.txtYearLevel.Location = New System.Drawing.Point(280, 75)
        Me.txtYearLevel.MaxLength = 32767
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearLevel.PromptText = "Year Level"
        Me.txtYearLevel.ReadOnly = True
        Me.txtYearLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtYearLevel.SelectedText = ""
        Me.txtYearLevel.SelectionLength = 0
        Me.txtYearLevel.SelectionStart = 0
        Me.txtYearLevel.ShortcutsEnabled = True
        Me.txtYearLevel.Size = New System.Drawing.Size(147, 23)
        Me.txtYearLevel.TabIndex = 49
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
        Me.txtLastName.Location = New System.Drawing.Point(280, 17)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PromptText = "Last Name"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShortcutsEnabled = True
        Me.txtLastName.Size = New System.Drawing.Size(147, 23)
        Me.txtLastName.TabIndex = 44
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
        Me.txtFirstName.Location = New System.Drawing.Point(127, 17)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PromptText = "First Name"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.ShortcutsEnabled = True
        Me.txtFirstName.Size = New System.Drawing.Size(147, 23)
        Me.txtFirstName.TabIndex = 43
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.WaterMark = "First Name"
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(399, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(89, 23)
        Me.btnLogout.TabIndex = 20
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseSelectable = True
        '
        'gridTemp
        '
        Me.gridTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTemp.Location = New System.Drawing.Point(-2000, 0)
        Me.gridTemp.Name = "gridTemp"
        Me.gridTemp.Size = New System.Drawing.Size(240, 150)
        Me.gridTemp.TabIndex = 21
        '
        'Timer1
        '
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 446)
        Me.Controls.Add(Me.gridTemp)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStudent"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "Student Dashboard"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.gridAttendanceRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTimer As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAddRecord As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbStudentStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtStudNumberStatus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogout As MetroFramework.Controls.MetroButton
    Friend WithEvents gridAttendanceRecord As DataGridView
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cmbSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbCourse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtStudentNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents radFemale As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMale As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtYearLevel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gridTemp As DataGridView
    Friend WithEvents Timer1 As Timer
End Class
