
Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec

Imports MySql.Data.MySqlClient



Public Class serviceprovider
    WithEvents MyWebCam As WebCamCapture
    Dim reader As QRCodeDecoder
    Dim Mysqlconn As MySqlConnection
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

    Private Sub serviceprovider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False

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
            reader = New QRCodeDecoder
            TextBox1.Text = reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "select * from athena.payment_info"
            command = New MySqlCommand(query, Mysqlconn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            DataGridView2.DataSource = bsource
            sda.Update(dbdataset)
            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()

        End Try

        Dim command2
        Dim Mysqlconn2 As MySqlConnection
        'Dim OID
        Mysqlconn2 = New MySqlConnection
        Mysqlconn2.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim sda2 As New MySqlDataAdapter
        Dim dbdataset2 As New DataTable
        Dim bsource2 As New BindingSource
        Try
            Mysqlconn.Open()
            Dim query2 As String
            query2 = "select * from athena.package"
            command2 = New MySqlCommand(query2, Mysqlconn2)
            sda2.SelectCommand = command2
            sda2.Fill(dbdataset2)

            bsource2.DataSource = dbdataset2
            DataGridView1.DataSource = bsource2
            sda.Update(dbdataset2)
            Mysqlconn2.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn2.Dispose()

        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub FilterData(valuetosearch As String)
        Dim MysqlConn As MySqlConnection
        Dim command
        'Dim OID
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select * from payment_info WHERE CONCAT(First_Name, Last_Name) like '%" & valuetosearch & "%'"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)


            DataGridView2.DataSource = dbdataset


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FilterData(TextBox4.Text)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class