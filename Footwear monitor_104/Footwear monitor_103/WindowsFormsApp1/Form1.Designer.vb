Namespace WindowsFormsApp1
	Partial Public Class Form1
		''' <summary>
		''' 必需的设计器变量。
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' 清理所有正在使用的资源。
		''' </summary>
		''' <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

#Region "Windows 窗体设计器生成的代码"

		''' <summary>
		''' 设计器支持所需的方法 - 不要修改
		''' 使用代码编辑器修改此方法的内容。
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gpbCom = New System.Windows.Forms.GroupBox()
            Me.cmbComBaud = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.btnSportClose = New System.Windows.Forms.Button()
            Me.cmbOutInterface = New System.Windows.Forms.ComboBox()
            Me.btnSportOpen = New System.Windows.Forms.Button()
            Me.cmbComPort = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.sfd = New System.Windows.Forms.SaveFileDialog()
            Me.btnInventory = New System.Windows.Forms.Button()
            Me.btninvStop = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.stdSerialData = New System.Windows.Forms.TextBox()
            Me.std = New System.Windows.Forms.OpenFileDialog()
            Me.label4 = New System.Windows.Forms.Label()
            Me.cmbRegion = New System.Windows.Forms.ComboBox()
            Me.cmbFreqStart = New System.Windows.Forms.ComboBox()
            Me.cmbFreqEnd = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.btnGetFreq = New System.Windows.Forms.Button()
            Me.btnSetFreq = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.Close_Realy = New System.Windows.Forms.Button()
            Me.Release_Realy = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.label7 = New System.Windows.Forms.Label()
            Me.btnGetOutInterface = New System.Windows.Forms.Button()
            Me.btnSetOutInterface = New System.Windows.Forms.Button()
            Me.btnGetWorkMode = New System.Windows.Forms.Button()
            Me.btnGetTxPower = New System.Windows.Forms.Button()
            Me.btnSetWorkMode = New System.Windows.Forms.Button()
            Me.cmbWorkmode = New System.Windows.Forms.ComboBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.btnSetTxPower = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.cmbTxPower = New System.Windows.Forms.ComboBox()
            Me.lsvTagsActive = New System.Windows.Forms.ListView()
            Me.colNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCodeLen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colRssi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colCw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.txtNGlog = New System.Windows.Forms.TextBox()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.gpbCom.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gpbCom
            '
            Me.gpbCom.Controls.Add(Me.cmbComBaud)
            Me.gpbCom.Controls.Add(Me.label3)
            Me.gpbCom.Controls.Add(Me.btnSportClose)
            Me.gpbCom.Controls.Add(Me.cmbOutInterface)
            Me.gpbCom.Controls.Add(Me.btnSportOpen)
            Me.gpbCom.Controls.Add(Me.cmbComPort)
            Me.gpbCom.Controls.Add(Me.label2)
            Me.gpbCom.Location = New System.Drawing.Point(541, 1361)
            Me.gpbCom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gpbCom.Name = "gpbCom"
            Me.gpbCom.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gpbCom.Size = New System.Drawing.Size(387, 113)
            Me.gpbCom.TabIndex = 15
            Me.gpbCom.TabStop = False
            Me.gpbCom.Text = "Serial Connect"
            '
            'cmbComBaud
            '
            Me.cmbComBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbComBaud.FormattingEnabled = True
            Me.cmbComBaud.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200"})
            Me.cmbComBaud.Location = New System.Drawing.Point(94, 72)
            Me.cmbComBaud.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cmbComBaud.Name = "cmbComBaud"
            Me.cmbComBaud.Size = New System.Drawing.Size(124, 21)
            Me.cmbComBaud.TabIndex = 5
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(38, 72)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(37, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "buad："
            '
            'btnSportClose
            '
            Me.btnSportClose.Location = New System.Drawing.Point(278, 67)
            Me.btnSportClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnSportClose.Name = "btnSportClose"
            Me.btnSportClose.Size = New System.Drawing.Size(92, 40)
            Me.btnSportClose.TabIndex = 3
            Me.btnSportClose.Text = "CLOSE(&C)"
            Me.btnSportClose.UseVisualStyleBackColor = True
            '
            'cmbOutInterface
            '
            Me.cmbOutInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOutInterface.FormattingEnabled = True
            Me.cmbOutInterface.Items.AddRange(New Object() {"RS232", "RS485", "RJ45", "Wieggand", "WiFi", "USB", "KeyBoard", "CDC_COM"})
            Me.cmbOutInterface.Location = New System.Drawing.Point(211, 78)
            Me.cmbOutInterface.Name = "cmbOutInterface"
            Me.cmbOutInterface.Size = New System.Drawing.Size(82, 21)
            Me.cmbOutInterface.TabIndex = 87
            Me.cmbOutInterface.Visible = False
            '
            'btnSportOpen
            '
            Me.btnSportOpen.Location = New System.Drawing.Point(278, 19)
            Me.btnSportOpen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.btnSportOpen.Name = "btnSportOpen"
            Me.btnSportOpen.Size = New System.Drawing.Size(92, 37)
            Me.btnSportOpen.TabIndex = 2
            Me.btnSportOpen.Text = "OPEN(&O)"
            Me.btnSportOpen.UseVisualStyleBackColor = True
            '
            'cmbComPort
            '
            Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbComPort.FormattingEnabled = True
            Me.cmbComPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5"})
            Me.cmbComPort.Location = New System.Drawing.Point(94, 28)
            Me.cmbComPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.cmbComPort.Name = "cmbComPort"
            Me.cmbComPort.Size = New System.Drawing.Size(124, 21)
            Me.cmbComPort.TabIndex = 1
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(38, 28)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(50, 25)
            Me.label2.TabIndex = 0
            Me.label2.Text = "port："
            '
            'sfd
            '
            Me.sfd.Filter = "*.txt|*.txt|*.*|*.*"
            '
            'btnInventory
            '
            Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.btnInventory.Location = New System.Drawing.Point(946, 1367)
            Me.btnInventory.Name = "btnInventory"
            Me.btnInventory.Size = New System.Drawing.Size(118, 54)
            Me.btnInventory.TabIndex = 65
            Me.btnInventory.Text = "Start"
            Me.btnInventory.UseVisualStyleBackColor = True
            '
            'btninvStop
            '
            Me.btninvStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.btninvStop.Location = New System.Drawing.Point(946, 1427)
            Me.btninvStop.Name = "btninvStop"
            Me.btninvStop.Size = New System.Drawing.Size(118, 54)
            Me.btninvStop.TabIndex = 66
            Me.btninvStop.Text = "Stop"
            Me.btninvStop.UseVisualStyleBackColor = True
            '
            'btnClear
            '
            Me.btnClear.Location = New System.Drawing.Point(1172, 1097)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(63, 27)
            Me.btnClear.TabIndex = 73
            Me.btnClear.Text = "Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            Me.btnClear.Visible = False
            '
            'stdSerialData
            '
            Me.stdSerialData.Location = New System.Drawing.Point(839, 1621)
            Me.stdSerialData.Margin = New System.Windows.Forms.Padding(2)
            Me.stdSerialData.Multiline = True
            Me.stdSerialData.Name = "stdSerialData"
            Me.stdSerialData.Size = New System.Drawing.Size(225, 278)
            Me.stdSerialData.TabIndex = 74
            Me.stdSerialData.Visible = False
            '
            'std
            '
            Me.std.Filter = "*.bin|*.BIN"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(26, 17)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(62, 13)
            Me.label4.TabIndex = 77
            Me.label4.Text = "Freq Band："
            '
            'cmbRegion
            '
            Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRegion.FormattingEnabled = True
            Me.cmbRegion.Items.AddRange(New Object() {"Custom", "USA", "Korea", "Europe", "Japan", "Malaysia", "Europe3", "China_1", "China_2"})
            Me.cmbRegion.Location = New System.Drawing.Point(107, 17)
            Me.cmbRegion.Name = "cmbRegion"
            Me.cmbRegion.Size = New System.Drawing.Size(82, 21)
            Me.cmbRegion.TabIndex = 78
            '
            'cmbFreqStart
            '
            Me.cmbFreqStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFreqStart.FormattingEnabled = True
            Me.cmbFreqStart.Location = New System.Drawing.Point(107, 60)
            Me.cmbFreqStart.Name = "cmbFreqStart"
            Me.cmbFreqStart.Size = New System.Drawing.Size(82, 21)
            Me.cmbFreqStart.TabIndex = 79
            '
            'cmbFreqEnd
            '
            Me.cmbFreqEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFreqEnd.FormattingEnabled = True
            Me.cmbFreqEnd.Location = New System.Drawing.Point(286, 60)
            Me.cmbFreqEnd.Name = "cmbFreqEnd"
            Me.cmbFreqEnd.Size = New System.Drawing.Size(82, 21)
            Me.cmbFreqEnd.TabIndex = 80
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(20, 63)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(59, 13)
            Me.label5.TabIndex = 81
            Me.label5.Text = "Freq Start："
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(234, 63)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(32, 13)
            Me.label6.TabIndex = 82
            Me.label6.Text = "End："
            '
            'btnGetFreq
            '
            Me.btnGetFreq.Location = New System.Drawing.Point(226, 15)
            Me.btnGetFreq.Name = "btnGetFreq"
            Me.btnGetFreq.Size = New System.Drawing.Size(75, 23)
            Me.btnGetFreq.TabIndex = 83
            Me.btnGetFreq.Text = "Get"
            Me.btnGetFreq.UseVisualStyleBackColor = True
            '
            'btnSetFreq
            '
            Me.btnSetFreq.Location = New System.Drawing.Point(316, 15)
            Me.btnSetFreq.Name = "btnSetFreq"
            Me.btnSetFreq.Size = New System.Drawing.Size(75, 23)
            Me.btnSetFreq.TabIndex = 84
            Me.btnSetFreq.Text = "Set"
            Me.btnSetFreq.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.btnSetFreq)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.btnGetFreq)
            Me.groupBox1.Controls.Add(Me.cmbRegion)
            Me.groupBox1.Controls.Add(Me.cmbFreqStart)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.cmbFreqEnd)
            Me.groupBox1.Location = New System.Drawing.Point(1134, 924)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(79, 48)
            Me.groupBox1.TabIndex = 85
            Me.groupBox1.TabStop = False
            '
            'Close_Realy
            '
            Me.Close_Realy.Location = New System.Drawing.Point(1118, 860)
            Me.Close_Realy.Name = "Close_Realy"
            Me.Close_Realy.Size = New System.Drawing.Size(117, 38)
            Me.Close_Realy.TabIndex = 85
            Me.Close_Realy.Text = "ON_Relay"
            Me.Close_Realy.UseVisualStyleBackColor = True
            Me.Close_Realy.Visible = False
            '
            'Release_Realy
            '
            Me.Release_Realy.Location = New System.Drawing.Point(1118, 816)
            Me.Release_Realy.Name = "Release_Realy"
            Me.Release_Realy.Size = New System.Drawing.Size(117, 38)
            Me.Release_Realy.TabIndex = 85
            Me.Release_Realy.Text = "OFF_Relay"
            Me.Release_Realy.UseVisualStyleBackColor = True
            Me.Release_Realy.Visible = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.label7)
            Me.GroupBox2.Controls.Add(Me.btnGetOutInterface)
            Me.GroupBox2.Controls.Add(Me.btnSetOutInterface)
            Me.GroupBox2.Controls.Add(Me.btnGetWorkMode)
            Me.GroupBox2.Controls.Add(Me.btnGetTxPower)
            Me.GroupBox2.Controls.Add(Me.btnSetWorkMode)
            Me.GroupBox2.Controls.Add(Me.cmbWorkmode)
            Me.GroupBox2.Controls.Add(Me.label10)
            Me.GroupBox2.Controls.Add(Me.btnSetTxPower)
            Me.GroupBox2.Controls.Add(Me.label1)
            Me.GroupBox2.Controls.Add(Me.cmbTxPower)
            Me.GroupBox2.Location = New System.Drawing.Point(1134, 978)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(79, 55)
            Me.GroupBox2.TabIndex = 91
            Me.GroupBox2.TabStop = False
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(39, 89)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(72, 13)
            Me.label7.TabIndex = 101
            Me.label7.Text = "OutInterface："
            '
            'btnGetOutInterface
            '
            Me.btnGetOutInterface.Location = New System.Drawing.Point(264, 97)
            Me.btnGetOutInterface.Name = "btnGetOutInterface"
            Me.btnGetOutInterface.Size = New System.Drawing.Size(75, 23)
            Me.btnGetOutInterface.TabIndex = 100
            Me.btnGetOutInterface.Text = "Get"
            Me.btnGetOutInterface.UseVisualStyleBackColor = True
            '
            'btnSetOutInterface
            '
            Me.btnSetOutInterface.Location = New System.Drawing.Point(345, 100)
            Me.btnSetOutInterface.Name = "btnSetOutInterface"
            Me.btnSetOutInterface.Size = New System.Drawing.Size(75, 23)
            Me.btnSetOutInterface.TabIndex = 99
            Me.btnSetOutInterface.Text = "Set"
            Me.btnSetOutInterface.UseVisualStyleBackColor = True
            '
            'btnGetWorkMode
            '
            Me.btnGetWorkMode.Location = New System.Drawing.Point(264, 68)
            Me.btnGetWorkMode.Name = "btnGetWorkMode"
            Me.btnGetWorkMode.Size = New System.Drawing.Size(75, 23)
            Me.btnGetWorkMode.TabIndex = 98
            Me.btnGetWorkMode.Text = "Get"
            Me.btnGetWorkMode.UseVisualStyleBackColor = True
            '
            'btnGetTxPower
            '
            Me.btnGetTxPower.Location = New System.Drawing.Point(264, 32)
            Me.btnGetTxPower.Name = "btnGetTxPower"
            Me.btnGetTxPower.Size = New System.Drawing.Size(75, 23)
            Me.btnGetTxPower.TabIndex = 97
            Me.btnGetTxPower.Text = "Get"
            Me.btnGetTxPower.UseVisualStyleBackColor = True
            '
            'btnSetWorkMode
            '
            Me.btnSetWorkMode.Location = New System.Drawing.Point(345, 71)
            Me.btnSetWorkMode.Name = "btnSetWorkMode"
            Me.btnSetWorkMode.Size = New System.Drawing.Size(75, 23)
            Me.btnSetWorkMode.TabIndex = 96
            Me.btnSetWorkMode.Text = "Set"
            Me.btnSetWorkMode.UseVisualStyleBackColor = True
            '
            'cmbWorkmode
            '
            Me.cmbWorkmode.DisplayMember = "2"
            Me.cmbWorkmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWorkmode.FormattingEnabled = True
            Me.cmbWorkmode.Items.AddRange(New Object() {"AnswerMode", "ActiveMode"})
            Me.cmbWorkmode.Location = New System.Drawing.Point(161, 66)
            Me.cmbWorkmode.Name = "cmbWorkmode"
            Me.cmbWorkmode.Size = New System.Drawing.Size(82, 21)
            Me.cmbWorkmode.TabIndex = 95
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(52, 64)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(66, 13)
            Me.label10.TabIndex = 94
            Me.label10.Text = "WorkMode："
            '
            'btnSetTxPower
            '
            Me.btnSetTxPower.Location = New System.Drawing.Point(345, 34)
            Me.btnSetTxPower.Name = "btnSetTxPower"
            Me.btnSetTxPower.Size = New System.Drawing.Size(75, 23)
            Me.btnSetTxPower.TabIndex = 93
            Me.btnSetTxPower.Text = "Set"
            Me.btnSetTxPower.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(30, 35)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(86, 13)
            Me.label1.TabIndex = 91
            Me.label1.Text = "RfPower（dbm）："
            '
            'cmbTxPower
            '
            Me.cmbTxPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTxPower.FormattingEnabled = True
            Me.cmbTxPower.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33"})
            Me.cmbTxPower.Location = New System.Drawing.Point(161, 32)
            Me.cmbTxPower.Name = "cmbTxPower"
            Me.cmbTxPower.Size = New System.Drawing.Size(82, 21)
            Me.cmbTxPower.TabIndex = 92
            '
            'lsvTagsActive
            '
            Me.lsvTagsActive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNum, Me.colCode, Me.colCodeLen, Me.colCount, Me.colRssi, Me.colCw})
            Me.lsvTagsActive.FullRowSelect = True
            Me.lsvTagsActive.GridLines = True
            Me.lsvTagsActive.HideSelection = False
            Me.lsvTagsActive.Location = New System.Drawing.Point(541, 1621)
            Me.lsvTagsActive.Name = "lsvTagsActive"
            Me.lsvTagsActive.Size = New System.Drawing.Size(293, 278)
            Me.lsvTagsActive.TabIndex = 92
            Me.lsvTagsActive.UseCompatibleStateImageBehavior = False
            Me.lsvTagsActive.View = System.Windows.Forms.View.Details
            Me.lsvTagsActive.Visible = False
            '
            'colNum
            '
            Me.colNum.Tag = "activecolNum"
            Me.colNum.Text = "No."
            Me.colNum.Width = 25
            '
            'colCode
            '
            Me.colCode.Tag = "activecolCode"
            Me.colCode.Text = "Data"
            Me.colCode.Width = 229
            '
            'colCodeLen
            '
            Me.colCodeLen.Tag = "activecolCodeLen"
            Me.colCodeLen.Text = "Len"
            Me.colCodeLen.Width = 40
            '
            'colCount
            '
            Me.colCount.Tag = "activecolCount"
            Me.colCount.Text = "Cnt(Ant1/2/3/4)"
            Me.colCount.Width = 80
            '
            'colRssi
            '
            Me.colRssi.Tag = "colRssia"
            Me.colRssi.Text = "RSSI(dBm)"
            '
            'colCw
            '
            Me.colCw.Tag = "activecolCw"
            Me.colCw.Text = "Channel"
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox1.Location = New System.Drawing.Point(12, 220)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.Size = New System.Drawing.Size(523, 280)
            Me.TextBox1.TabIndex = 93
            '
            'TextBox2
            '
            Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox2.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox2.Location = New System.Drawing.Point(12, 506)
            Me.TextBox2.Multiline = True
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.ReadOnly = True
            Me.TextBox2.Size = New System.Drawing.Size(523, 280)
            Me.TextBox2.TabIndex = 94
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox3.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox3.Location = New System.Drawing.Point(12, 792)
            Me.TextBox3.Multiline = True
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.ReadOnly = True
            Me.TextBox3.Size = New System.Drawing.Size(523, 280)
            Me.TextBox3.TabIndex = 95
            '
            'TextBox4
            '
            Me.TextBox4.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox4.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox4.Location = New System.Drawing.Point(12, 1067)
            Me.TextBox4.Multiline = True
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.ReadOnly = True
            Me.TextBox4.Size = New System.Drawing.Size(523, 280)
            Me.TextBox4.TabIndex = 96
            '
            'TextBox5
            '
            Me.TextBox5.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox5.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox5.Location = New System.Drawing.Point(541, 220)
            Me.TextBox5.Multiline = True
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.ReadOnly = True
            Me.TextBox5.Size = New System.Drawing.Size(523, 280)
            Me.TextBox5.TabIndex = 97
            '
            'TextBox6
            '
            Me.TextBox6.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox6.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox6.Location = New System.Drawing.Point(541, 506)
            Me.TextBox6.Multiline = True
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.Size = New System.Drawing.Size(523, 280)
            Me.TextBox6.TabIndex = 98
            '
            'TextBox7
            '
            Me.TextBox7.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox7.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox7.Location = New System.Drawing.Point(541, 792)
            Me.TextBox7.Multiline = True
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.ReadOnly = True
            Me.TextBox7.Size = New System.Drawing.Size(523, 280)
            Me.TextBox7.TabIndex = 99
            '
            'TextBox8
            '
            Me.TextBox8.BackColor = System.Drawing.SystemColors.ControlDark
            Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox8.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.TextBox8.Location = New System.Drawing.Point(541, 1075)
            Me.TextBox8.Multiline = True
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.ReadOnly = True
            Me.TextBox8.Size = New System.Drawing.Size(523, 279)
            Me.TextBox8.TabIndex = 100
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
            Me.Label8.Location = New System.Drawing.Point(34, 66)
            Me.Label8.Name = "Label8"
            Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label8.Size = New System.Drawing.Size(1021, 86)
            Me.Label8.TabIndex = 101
            Me.Label8.Text = "MT800 Footwear checking system"
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'txtNGlog
            '
            Me.txtNGlog.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNGlog.ForeColor = System.Drawing.Color.Red
            Me.txtNGlog.Location = New System.Drawing.Point(12, 1361)
            Me.txtNGlog.Multiline = True
            Me.txtNGlog.Name = "txtNGlog"
            Me.txtNGlog.Size = New System.Drawing.Size(523, 538)
            Me.txtNGlog.TabIndex = 102
            '
            'lblStatus
            '
            Me.lblStatus.AutoSize = True
            Me.lblStatus.Font = New System.Drawing.Font("Yu Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStatus.Location = New System.Drawing.Point(541, 1540)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(129, 45)
            Me.lblStatus.TabIndex = 103
            Me.lblStatus.Text = "Label9"
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(1077, 1911)
            Me.ControlBox = False
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.txtNGlog)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.TextBox8)
            Me.Controls.Add(Me.TextBox7)
            Me.Controls.Add(Me.TextBox6)
            Me.Controls.Add(Me.TextBox5)
            Me.Controls.Add(Me.Release_Realy)
            Me.Controls.Add(Me.TextBox4)
            Me.Controls.Add(Me.TextBox3)
            Me.Controls.Add(Me.TextBox2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.lsvTagsActive)
            Me.Controls.Add(Me.Close_Realy)
            Me.Controls.Add(Me.stdSerialData)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btninvStop)
            Me.Controls.Add(Me.btnInventory)
            Me.Controls.Add(Me.gpbCom)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.Text = "Form1"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.gpbCom.ResumeLayout(False)
            Me.gpbCom.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private gpbCom As System.Windows.Forms.GroupBox
        Private cmbComBaud As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Public WithEvents btnSportClose As System.Windows.Forms.Button
        Public WithEvents btnSportOpen As System.Windows.Forms.Button
        Public WithEvents cmbComPort As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private sfd As System.Windows.Forms.SaveFileDialog
        Private WithEvents btnInventory As System.Windows.Forms.Button
        Private WithEvents btninvStop As System.Windows.Forms.Button
        Private WithEvents btnClear As System.Windows.Forms.Button
        Private stdSerialData As System.Windows.Forms.TextBox
        Private std As System.Windows.Forms.OpenFileDialog
        Private label4 As System.Windows.Forms.Label
        Private WithEvents cmbRegion As System.Windows.Forms.ComboBox
        Private WithEvents cmbFreqStart As System.Windows.Forms.ComboBox
        Private cmbFreqEnd As System.Windows.Forms.ComboBox
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private WithEvents btnGetFreq As System.Windows.Forms.Button
        Private WithEvents btnSetFreq As System.Windows.Forms.Button
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents Close_Realy As System.Windows.Forms.Button
        Private WithEvents Release_Realy As System.Windows.Forms.Button
        Private cmbOutInterface As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox2 As GroupBox
        Private WithEvents label7 As Label
        Private WithEvents btnGetOutInterface As Button
        Private WithEvents btnSetOutInterface As Button
        Private WithEvents btnGetWorkMode As Button
        Private WithEvents btnGetTxPower As Button
        Private WithEvents btnSetWorkMode As Button
        Private WithEvents cmbWorkmode As ComboBox
        Private WithEvents label10 As Label
        Private WithEvents btnSetTxPower As Button
        Private WithEvents label1 As Label
        Private WithEvents cmbTxPower As ComboBox
        Private WithEvents lsvTagsActive As ListView
        Private WithEvents colNum As ColumnHeader
        Private WithEvents colCode As ColumnHeader
        Private WithEvents colCodeLen As ColumnHeader
        Private WithEvents colCount As ColumnHeader
        Private WithEvents colRssi As ColumnHeader
        Private WithEvents colCw As ColumnHeader
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents TextBox3 As TextBox
        Friend WithEvents TextBox4 As TextBox
        Friend WithEvents TextBox5 As TextBox
        Friend WithEvents TextBox6 As TextBox
        Friend WithEvents TextBox7 As TextBox
        Friend WithEvents TextBox8 As TextBox
        Friend WithEvents Label8 As Label
        Friend WithEvents Timer1 As Timer
        Friend WithEvents txtNGlog As TextBox
        Friend WithEvents lblStatus As Label
    End Class
End Namespace

