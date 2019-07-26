Imports MySql.Data.MySqlClient
Public Class qrgeneator
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

    Dim Index As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
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


            DataGridView1.DataSource = dbdataset


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click








    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PictureBox1.Image = QR_Generator.Encode(TextBox1.Text & vbNewLine & TextBox2.Text & vbNewLine & TextBox3.Text)

        Catch ex As Exception
        Finally
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs)
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
            query = "select * from athena.room"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)
        TextBox1.Text = selectedRow.Cells(6).Value.ToString()
        TextBox2.Text = selectedRow.Cells(1).Value.ToString() & selectedRow.Cells(0).Value.ToString()

        TextBox3.Text = selectedRow.Cells(7).Value.ToString()
    End Sub

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) Handles Button3.Click
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
            query = "select * from athena.payment_info"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FilterData(TextBox4.Text)

    End Sub
End Class