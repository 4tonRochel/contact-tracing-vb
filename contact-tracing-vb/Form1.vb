Imports WebCam_Capture
Imports MessagingToolkit
Imports MessagingToolkit.QRCode.Codec
Imports QRCoder
Imports System.IO

Public Class Form1
    Dim Decode As QRCodeDecoder
    Dim gender As String
    Dim Q1 As String
    WithEvents Mycam As WebCamCapture
    Dim Decoder As QRCodeDecoder


    Private Sub txtbxFName_TextChanged(sender As Object, e As EventArgs) Handles txtbxFName.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        TextBox2.Text = "Full Name:" + txtbxFName.Text + "" + txtbxLName.Text + "" & vbCrLf &
            "Age: " + txtbxAge.Text & vbCrLf &
            "Address: " + txtbxAddress.Text & vbCrLf &
            "Gender: " + cbxGender.Text & vbCrLf &
            "Phone Number: " + txtbxPNum.Text & vbCrLf &
            "Question 1: " + cbxQ1.Text & vbCrLf &
            "Question 2: " + checklistQ2.Text & vbCrLf

        Dim GenQR As New QRCodeGenerator
        Dim Info = GenQR.CreateQrCode(TextBox2.Text, QRCodeGenerator.ECCLevel.Q)
        Dim Code As New QRCode(Info)
        pcbxGenerate.Image = Code.GetGraphic(3)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SaveQR As New SaveFileDialog
        SaveQR.FileName = "QR Code"
        SaveQR.Filter = "Png Files Only (*.png) |*.png"
        If SaveQR.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                pcbxGenerate.Image.Save(SaveQR.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Saved!")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Try

            StartWebCam()
            TextBox1.Clear()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub StartWebCam()
        Try
            StopWebCam()
            Mycam = New WebCamCapture
            Mycam.Start(0)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Mycam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles Mycam.ImageCaptured
        pcbxScan.Image = e.WebCamImage

    End Sub
    Private Sub StopWebCam()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Try
            StopWebCam()
            Decoder = New QRCodeDecoder
            TextBox1.Text = Decoder.Decode(New Data.QRCodeBitmapImage(pcbxGenerate.Image))
            MsgBox("QR Code is detected!")
        Catch ex As Exception

        End Try
    End Sub
End Class
