Imports MySql.Data.MySqlClient
Public Class PriceEdit
    Dim index As Integer
    Private Sub EXITToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub DISPLAYToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub INSERTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MysqlConn As MySqlConnection


        Dim command


        Dim command1
        Dim MysqlConn1 As MySqlConnection
        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
        Dim reader1 As MySqlDataReader
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            MysqlConn1.Open()
            Dim query As String

            query = "insert into Room values('" & TextBox4.Text & "' ,'" & TextBox1.Text & " ')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader

            Dim query1 As String
            query1 = "insert into Package values('" & TextBox2.Text & "' ,'" & TextBox3.Text & " ')"
            command1 = New MySqlCommand(query1, MysqlConn1)
            reader1 = command1.ExecuteReader

            MessageBox.Show("Data Inserted!")
            'Dim OID
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
            MysqlConn1 = New MySqlConnection
            MysqlConn1.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource

            Dim sda1 As New MySqlDataAdapter
            Dim dbdataset1 As New DataTable
            Dim bsource1 As New BindingSource

            MysqlConn.Open()
            MysqlConn1.Open()
            query1 = "select * from leul.Package"
            query = "select * from leul.Room"

            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            command1 = New MySqlCommand(query1, MysqlConn1)
            sda1.SelectCommand = command1
            sda1.Fill(dbdataset1)

            bsource.DataSource = dbdataset
            DataGridView2.DataSource = bsource
            sda.Update(dbdataset)

            bsource1.DataSource = dbdataset1
            DataGridView1.DataSource = bsource1
            sda1.Update(dbdataset)
            MysqlConn.Close()

            MysqlConn1.Close()








        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            MysqlConn1.Dispose()


        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()


    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MysqlConn As MySqlConnection
        Dim command
        Dim MysqlConn1 As MySqlConnection
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "select * from leul.Room"



            command = New MySqlCommand(query, Mysqlconn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            DataGridView2.DataSource = bsource
            sda.Update(dbdataset)
            MysqlConn.Close()


            Dim command1
            'Dim OID
            MysqlConn1 = New MySqlConnection
            MysqlConn1.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
            Dim sda1 As New MySqlDataAdapter
            Dim dbdataset1 As New DataTable
            Dim bsource1 As New BindingSource

            Try
                MysqlConn.Open()
                Dim query1 As String
                query1 = "select * from leul.Package"



                command1 = New MySqlCommand(query1, MysqlConn)
                sda1.SelectCommand = command1
                sda1.Fill(dbdataset1)

                bsource1.DataSource = dbdataset1
                DataGridView1.DataSource = bsource1
                sda.Update(dbdataset1)
                MysqlConn1.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        Finally
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)
        TextBox4.Text = selectedRow.Cells(0).Value.ToString()
        TextBox1.Text = selectedRow.Cells(1).Value.ToString()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MysqlConn As MySqlConnection

        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String

            query = "delete from Room where Room Type='" & TextBox4.Text & "'"

            command = New MySqlCommand(query, Mysqlconn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Deleted")
            

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
           

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TextBox2.Text = selectedRow.Cells(0).Value.ToString()
        TextBox3.Text = selectedRow.Cells(1).Value.ToString()
    End Sub
End Class