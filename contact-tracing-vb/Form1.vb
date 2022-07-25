Imports WebCam_Capture
Imports MessagingToolkit
Imports MessagingToolkit.Barcode
Imports MessagingToolkit.QRCode.Codec
Imports QRCoder
Imports System.IO

Public Class Form1
    Dim Decode As QRCodeDecoder
    Dim gender As String
    Dim Q1 As String
    WithEvents Mycam As WebCamCapture

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
        writefile.WriteLine("Gender:" + cbxGender.Text)
        writefile.WriteLine("Question 1:" + cbxQ1.Text)
        writefile.WriteLine("Question 2:" + checklistQ2.Text)






        writefile.WriteLine("")




        MessageBox.Show("Submitted!", "CONTACT TRACING FORM")

        writefile.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        TextBox2.Text = "Full Name:" + txtbxLName.Text + "" + txtbxFName.Text + "" & vbCrLf &
            "Age: " + txtbxAge.Text & vbCrLf &
            "Address: " + txtbxAddress.Text & vbCrLf &
            "Gender: " + cbxGender.Text & vbCrLf &
            "Phone Number: " + txtbxPNum.Text & vbCrLf &
            "Question 1: " + cbxQ1.Text & vbCrLf &
            "Question 2: " + checklistQ2.Text & vbCrLf

        Dim GenQR As New QRCodeGenerator
        Dim Info = GenQR.CreateQrCode(TextBox2.Text, QRCodeGenerator.ECCLevel.Q)
        Dim Code As New QRCode(Info)
        PictureBox.Image = Code.GetGraphic(3)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SaveQR As New SaveFileDialog
        SaveQR.FileName = "QR Code"
        SaveQR.Filter = "Png Files Only (*.png) |*.png"
        If SaveQR.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox.Image.Save(SaveQR.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Saved!")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Try

            StopWebCam()
            Mycam = New WebCamCapture
            Mycam.Start(0)


        Catch ex As Exception

        End Try
    End Sub
    Private Sub StopWebCam()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub StartWebCam()
        StartWebCam()
    End Sub
    Private Sub Mycam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles Mycam.ImageCaptured
        PictureBox.Image = e.WebCamImage

    End Sub

End Class
