Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Public Class qrscanner
    WithEvents MyWebCam As WebCamCapture
    Dim Reader As QRCodeDecoder

    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebCam.ImageCaptured
        PictureBox1.Image = e.WebCamImage

    End Sub
    Private Sub StartWebcam()
        StopWebcam()
        MyWebCam = New WebCamCapture
        MyWebCam.Start(0)
        MyWebCam.Start(0)



    End Sub
    Private Sub StopWebcam()
        Try
            MyWebCam.Stop()
            MyWebCam.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StartWebcam()
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StopWebcam()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            StopWebcam()
            Reader = New QRCodeDecoder
            TextBox1.Text = Reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("QR code is detected")

        Catch ex As Exception
            StartWebcam()

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "PNG|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)



        End If
    End Sub
End Class