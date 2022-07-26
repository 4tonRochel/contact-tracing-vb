<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtbxFName = New System.Windows.Forms.TextBox()
        Me.txtbxLName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.lblADD = New System.Windows.Forms.Label()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtbxPNum = New System.Windows.Forms.TextBox()
        Me.lblPNum = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.grpbxQ1 = New System.Windows.Forms.GroupBox()
        Me.cbxQ1 = New System.Windows.Forms.ComboBox()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pcbxGenerate = New System.Windows.Forms.PictureBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.checklistQ2 = New System.Windows.Forms.CheckedListBox()
        Me.pcbxScan = New System.Windows.Forms.PictureBox()
        Me.grpbxQ1.SuspendLayout()
        CType(Me.pcbxGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(405, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Tracing Form"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(12, 57)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(80, 19)
        Me.lblFName.TabIndex = 1
        Me.lblFName.Text = "First Name:"
        '
        'txtbxFName
        '
        Me.txtbxFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFName.Location = New System.Drawing.Point(16, 79)
        Me.txtbxFName.Name = "txtbxFName"
        Me.txtbxFName.Size = New System.Drawing.Size(206, 26)
        Me.txtbxFName.TabIndex = 2
        '
        'txtbxLName
        '
        Me.txtbxLName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLName.Location = New System.Drawing.Point(249, 79)
        Me.txtbxLName.Name = "txtbxLName"
        Me.txtbxLName.Size = New System.Drawing.Size(206, 26)
        Me.txtbxLName.TabIndex = 4
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(245, 57)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(79, 19)
        Me.lblLName.TabIndex = 3
        Me.lblLName.Text = "Last Name:"
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddress.Location = New System.Drawing.Point(170, 141)
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(285, 26)
        Me.txtbxAddress.TabIndex = 8
        '
        'lblADD
        '
        Me.lblADD.AutoSize = True
        Me.lblADD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADD.Location = New System.Drawing.Point(166, 119)
        Me.lblADD.Name = "lblADD"
        Me.lblADD.Size = New System.Drawing.Size(125, 19)
        Me.lblADD.TabIndex = 7
        Me.lblADD.Text = "Complete Address:"
        '
        'txtbxAge
        '
        Me.txtbxAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAge.Location = New System.Drawing.Point(16, 141)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.Size = New System.Drawing.Size(87, 26)
        Me.txtbxAge.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(12, 119)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 19)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age:"
        '
        'txtbxPNum
        '
        Me.txtbxPNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPNum.Location = New System.Drawing.Point(249, 208)
        Me.txtbxPNum.Name = "txtbxPNum"
        Me.txtbxPNum.Size = New System.Drawing.Size(206, 26)
        Me.txtbxPNum.TabIndex = 10
        '
        'lblPNum
        '
        Me.lblPNum.AutoSize = True
        Me.lblPNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNum.Location = New System.Drawing.Point(245, 186)
        Me.lblPNum.Name = "lblPNum"
        Me.lblPNum.Size = New System.Drawing.Size(104, 19)
        Me.lblPNum.TabIndex = 9
        Me.lblPNum.Text = "Phone Number:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(12, 186)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(57, 19)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Gender:"
        '
        'grpbxQ1
        '
        Me.grpbxQ1.Controls.Add(Me.cbxQ1)
        Me.grpbxQ1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxQ1.Location = New System.Drawing.Point(16, 301)
        Me.grpbxQ1.Name = "grpbxQ1"
        Me.grpbxQ1.Size = New System.Drawing.Size(439, 100)
        Me.grpbxQ1.TabIndex = 15
        Me.grpbxQ1.TabStop = False
        Me.grpbxQ1.Text = "Have you come into contact with a person who has a confirmed or suspected case of" &
    " COVID-19 within the past 14 days?"
        '
        'cbxQ1
        '
        Me.cbxQ1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxQ1.FormattingEnabled = True
        Me.cbxQ1.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbxQ1.Location = New System.Drawing.Point(6, 53)
        Me.cbxQ1.Name = "cbxQ1"
        Me.cbxQ1.Size = New System.Drawing.Size(121, 27)
        Me.cbxQ1.TabIndex = 32
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(18, 417)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(292, 19)
        Me.lblQ2.TabIndex = 16
        Me.lblQ2.Text = "Are you experiencing any of the following?"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(870, 571)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 34)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(505, 301)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(457, 252)
        Me.TextBox1.TabIndex = 23
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pcbxGenerate
        '
        Me.pcbxGenerate.Location = New System.Drawing.Point(516, 43)
        Me.pcbxGenerate.Name = "pcbxGenerate"
        Me.pcbxGenerate.Size = New System.Drawing.Size(195, 191)
        Me.pcbxGenerate.TabIndex = 25
        Me.pcbxGenerate.TabStop = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnGenerate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(505, 238)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 41)
        Me.btnGenerate.TabIndex = 26
        Me.btnGenerate.Text = "Generate QR"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(621, 237)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 41)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save QR"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCapture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(852, 238)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(110, 41)
        Me.btnCapture.TabIndex = 29
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.SkyBlue
        Me.btnScan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.Location = New System.Drawing.Point(736, 238)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(110, 41)
        Me.btnScan.TabIndex = 28
        Me.btnScan.Text = "Scan QR"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(862, 9)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 30
        Me.TextBox2.Visible = False
        '
        'cbxGender
        '
        Me.cbxGender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        Me.cbxGender.Location = New System.Drawing.Point(16, 212)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(121, 27)
        Me.cbxGender.TabIndex = 31
        '
        'checklistQ2
        '
        Me.checklistQ2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.checklistQ2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checklistQ2.FormattingEnabled = True
        Me.checklistQ2.Items.AddRange(New Object() {"New and Persistent cough", "Shortness of breath or any difficulty breathing", "Fever", "No Symptoms"})
        Me.checklistQ2.Location = New System.Drawing.Point(23, 449)
        Me.checklistQ2.Name = "checklistQ2"
        Me.checklistQ2.Size = New System.Drawing.Size(432, 84)
        Me.checklistQ2.TabIndex = 34
        '
        'pcbxScan
        '
        Me.pcbxScan.Location = New System.Drawing.Point(748, 43)
        Me.pcbxScan.Name = "pcbxScan"
        Me.pcbxScan.Size = New System.Drawing.Size(195, 191)
        Me.pcbxScan.TabIndex = 35
        Me.pcbxScan.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(968, 617)
        Me.Controls.Add(Me.pcbxScan)
        Me.Controls.Add(Me.checklistQ2)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.pcbxGenerate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.grpbxQ1)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtbxPNum)
        Me.Controls.Add(Me.lblPNum)
        Me.Controls.Add(Me.txtbxAddress)
        Me.Controls.Add(Me.lblADD)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtbxLName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.txtbxFName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Contact Tracing"
        Me.grpbxQ1.ResumeLayout(False)
        CType(Me.pcbxGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents txtbxFName As TextBox
    Friend WithEvents txtbxLName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents lblADD As Label
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtbxPNum As TextBox
    Friend WithEvents lblPNum As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents grpbxQ1 As GroupBox
    Friend WithEvents lblQ2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents pcbxGenerate As PictureBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents cbxQ1 As ComboBox
    Friend WithEvents checklistQ2 As CheckedListBox
    Friend WithEvents pcbxScan As PictureBox
End Class
