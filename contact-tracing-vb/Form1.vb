Public Class Form1

    Dim gender As String
    Dim Q1 As String
    Private Sub txtbxFName_TextChanged(sender As Object, e As EventArgs) Handles txtbxFName.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim writefile As System.IO.StreamWriter
        writefile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\SherylMejia\Documents\contact tracing\contact-tracing-vb\contact-tracing-vb\Information.txt", True)
        writefile.WriteLine("INFORMATION")

        writefile.WriteLine("First Name:" + txtbxFName.Text)
        writefile.WriteLine("Last Name:" + txtbxLName.Text)
        writefile.WriteLine("Complete Address:" + txtbxAddress.Text)
        writefile.WriteLine("Age:" + txtbxAge.Text)
        writefile.WriteLine("Phone Number:" + txtbxPNum.Text)
        If radiobtnMale.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Male")
        ElseIf radiobtnFemale.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Female")
        ElseIf radiobtnOther.Checked Then
            writefile.WriteLine(lblGender.Text & " " & "Prefer not to say")
        End If


        If radiobtnYes.Checked Then
            writefile.WriteLine(grpbxQ1.Text & " " & radiobtnYes.Text)
        ElseIf radiobtnNo.Checked Then
            writefile.WriteLine(grpbxQ1.Text & " " & radiobtnNo.Text)
        End If


        If chbxCough.CheckState = CheckState.Checked Then
            writefile.WriteLine("Are you experiencing any of the following?: New and persistent cough")
        Else
            'Do Nothing
        End If
        If chbxBreathing.CheckState = CheckState.Checked Then
            writefile.WriteLine("Are you experiencing any of the following? : Shorthness of breath or any difficulty braething")
        Else
            'Do Nothing
        End If
        If chbxFever.CheckState = CheckState.Checked Then
            writefile.WriteLine("Are you experiencing any of the following?: Fever")
        Else
            'Do Nothing
        End If
        If chbxNoSymptoms.CheckState = CheckState.Checked Then
            writefile.WriteLine("Are you experiencing any of the following?: No Symptoms")
        Else
            'Do Nothing
        End If


        writefile.WriteLine("")

        chbxCough.Checked = False
        chbxBreathing.Checked = False
        chbxFever.Checked = False
        chbxNoSymptoms.Checked = False


        MessageBox.Show("Submitted!", "CONTACT TRACING FORM")

        writefile.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
