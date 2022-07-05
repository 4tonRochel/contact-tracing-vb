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
        Me.radiobtnMale = New System.Windows.Forms.RadioButton()
        Me.radiobtnFemale = New System.Windows.Forms.RadioButton()
        Me.radiobtnOther = New System.Windows.Forms.RadioButton()
        Me.grpbxQ1 = New System.Windows.Forms.GroupBox()
        Me.radiobtnYes = New System.Windows.Forms.RadioButton()
        Me.radiobtnNo = New System.Windows.Forms.RadioButton()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.chbxCough = New System.Windows.Forms.CheckBox()
        Me.chbxBreathing = New System.Windows.Forms.CheckBox()
        Me.chbxFever = New System.Windows.Forms.CheckBox()
        Me.chbxNoSymptoms = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpbxQ1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(130, 9)
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
        'radiobtnMale
        '
        Me.radiobtnMale.AutoSize = True
        Me.radiobtnMale.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnMale.Location = New System.Drawing.Point(30, 208)
        Me.radiobtnMale.Name = "radiobtnMale"
        Me.radiobtnMale.Size = New System.Drawing.Size(56, 21)
        Me.radiobtnMale.TabIndex = 12
        Me.radiobtnMale.TabStop = True
        Me.radiobtnMale.Text = "Male"
        Me.radiobtnMale.UseVisualStyleBackColor = True
        '
        'radiobtnFemale
        '
        Me.radiobtnFemale.AutoSize = True
        Me.radiobtnFemale.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnFemale.Location = New System.Drawing.Point(30, 231)
        Me.radiobtnFemale.Name = "radiobtnFemale"
        Me.radiobtnFemale.Size = New System.Drawing.Size(69, 21)
        Me.radiobtnFemale.TabIndex = 13
        Me.radiobtnFemale.TabStop = True
        Me.radiobtnFemale.Text = "Female"
        Me.radiobtnFemale.UseVisualStyleBackColor = True
        '
        'radiobtnOther
        '
        Me.radiobtnOther.AutoSize = True
        Me.radiobtnOther.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnOther.Location = New System.Drawing.Point(30, 254)
        Me.radiobtnOther.Name = "radiobtnOther"
        Me.radiobtnOther.Size = New System.Drawing.Size(125, 21)
        Me.radiobtnOther.TabIndex = 14
        Me.radiobtnOther.TabStop = True
        Me.radiobtnOther.Text = "Prefer not to say"
        Me.radiobtnOther.UseVisualStyleBackColor = True
        '
        'grpbxQ1
        '
        Me.grpbxQ1.Controls.Add(Me.radiobtnNo)
        Me.grpbxQ1.Controls.Add(Me.radiobtnYes)
        Me.grpbxQ1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxQ1.Location = New System.Drawing.Point(16, 301)
        Me.grpbxQ1.Name = "grpbxQ1"
        Me.grpbxQ1.Size = New System.Drawing.Size(439, 100)
        Me.grpbxQ1.TabIndex = 15
        Me.grpbxQ1.TabStop = False
        Me.grpbxQ1.Text = "Have you come into contact with a person who has a confirmed or suspected case of" &
    " COVID-19 within the past 14 days?"
        '
        'radiobtnYes
        '
        Me.radiobtnYes.AutoSize = True
        Me.radiobtnYes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnYes.Location = New System.Drawing.Point(6, 61)
        Me.radiobtnYes.Name = "radiobtnYes"
        Me.radiobtnYes.Size = New System.Drawing.Size(49, 23)
        Me.radiobtnYes.TabIndex = 0
        Me.radiobtnYes.TabStop = True
        Me.radiobtnYes.Text = "Yes"
        Me.radiobtnYes.UseVisualStyleBackColor = True
        '
        'radiobtnNo
        '
        Me.radiobtnNo.AutoSize = True
        Me.radiobtnNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnNo.Location = New System.Drawing.Point(105, 61)
        Me.radiobtnNo.Name = "radiobtnNo"
        Me.radiobtnNo.Size = New System.Drawing.Size(47, 23)
        Me.radiobtnNo.TabIndex = 1
        Me.radiobtnNo.TabStop = True
        Me.radiobtnNo.Text = "No"
        Me.radiobtnNo.UseVisualStyleBackColor = True
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
        'chbxCough
        '
        Me.chbxCough.AutoSize = True
        Me.chbxCough.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxCough.Location = New System.Drawing.Point(22, 451)
        Me.chbxCough.Name = "chbxCough"
        Me.chbxCough.Size = New System.Drawing.Size(180, 21)
        Me.chbxCough.TabIndex = 17
        Me.chbxCough.Text = "New and persistent cough"
        Me.chbxCough.UseVisualStyleBackColor = True
        '
        'chbxBreathing
        '
        Me.chbxBreathing.AutoSize = True
        Me.chbxBreathing.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxBreathing.Location = New System.Drawing.Point(22, 478)
        Me.chbxBreathing.Name = "chbxBreathing"
        Me.chbxBreathing.Size = New System.Drawing.Size(302, 21)
        Me.chbxBreathing.TabIndex = 18
        Me.chbxBreathing.Text = "Shorthness of breath or any difficulty braething"
        Me.chbxBreathing.UseVisualStyleBackColor = True
        '
        'chbxFever
        '
        Me.chbxFever.AutoSize = True
        Me.chbxFever.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxFever.Location = New System.Drawing.Point(22, 505)
        Me.chbxFever.Name = "chbxFever"
        Me.chbxFever.Size = New System.Drawing.Size(61, 21)
        Me.chbxFever.TabIndex = 19
        Me.chbxFever.Text = "Fever"
        Me.chbxFever.UseVisualStyleBackColor = True
        '
        'chbxNoSymptoms
        '
        Me.chbxNoSymptoms.AutoSize = True
        Me.chbxNoSymptoms.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxNoSymptoms.Location = New System.Drawing.Point(22, 532)
        Me.chbxNoSymptoms.Name = "chbxNoSymptoms"
        Me.chbxNoSymptoms.Size = New System.Drawing.Size(110, 21)
        Me.chbxNoSymptoms.TabIndex = 20
        Me.chbxNoSymptoms.Text = "No Symptoms"
        Me.chbxNoSymptoms.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(17, 571)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 34)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(368, 571)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 34)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 617)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.chbxNoSymptoms)
        Me.Controls.Add(Me.chbxFever)
        Me.Controls.Add(Me.chbxBreathing)
        Me.Controls.Add(Me.chbxCough)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.grpbxQ1)
        Me.Controls.Add(Me.radiobtnOther)
        Me.Controls.Add(Me.radiobtnFemale)
        Me.Controls.Add(Me.radiobtnMale)
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
        Me.Name = "Form1"
        Me.Text = "Contact Tracing"
        Me.grpbxQ1.ResumeLayout(False)
        Me.grpbxQ1.PerformLayout()
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
    Friend WithEvents radiobtnMale As RadioButton
    Friend WithEvents radiobtnFemale As RadioButton
    Friend WithEvents radiobtnOther As RadioButton
    Friend WithEvents grpbxQ1 As GroupBox
    Friend WithEvents radiobtnNo As RadioButton
    Friend WithEvents radiobtnYes As RadioButton
    Friend WithEvents lblQ2 As Label
    Friend WithEvents chbxCough As CheckBox
    Friend WithEvents chbxBreathing As CheckBox
    Friend WithEvents chbxFever As CheckBox
    Friend WithEvents chbxNoSymptoms As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
End Class
