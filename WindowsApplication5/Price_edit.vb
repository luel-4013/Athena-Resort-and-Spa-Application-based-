Imports MySql.Data.MySqlClient
Public Class Price_edit
    Dim Mysqlconn As MySqlConnection
    Dim Mysqlconn1 As MySqlConnection
    Dim index As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            query = "select * from athena.room"
            command = New MySqlCommand(query, Mysqlconn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            Mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()

        End Try

        Dim command1
        'Dim OID
        Mysqlconn1 = New MySqlConnection
        Mysqlconn1.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim sda1 As New MySqlDataAdapter
        Dim dbdataset1 As New DataTable
        Dim bsource1 As New BindingSource
        Try
            Mysqlconn1.Open()
            Dim query1 As String
            query1 = "select * from athena.package"
            command1 = New MySqlCommand(query1, Mysqlconn1)
            sda1.SelectCommand = command1
            sda1.Fill(dbdataset1)

            bsource1.DataSource = dbdataset1
            DataGridView2.DataSource = bsource1
            sda.Update(dbdataset1)
            Mysqlconn1.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn1.Dispose()

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TextBox2.Text = selectedRow.Cells(0).Value.ToString()
        TextBox1.Text = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)
        TextBox4.Text = selectedRow.Cells(0).Value.ToString()
        TextBox3.Text = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String

            query = "Update athena.room set Room_No='" & TextBox2.Text & "', Room_Price='" & TextBox1.Text & "' where Room_No='" & TextBox2.Text & "'"

            command = New MySqlCommand(query, Mysqlconn)
            reader = command.ExecuteReader



            'Dim OID
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource
            Try
                Mysqlconn.Open()
                query = "select * from athena.room"
                command = New MySqlCommand(query, Mysqlconn)
                sda.SelectCommand = command
                sda.Fill(dbdataset)

                bsource.DataSource = dbdataset
                DataGridView1.DataSource = bsource
                sda.Update(dbdataset)
                Mysqlconn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Mysqlconn.Dispose()

            End Try



            reader.Close()
            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
        TextBox1.Clear()



        Dim command1
        'Dim OID
        Mysqlconn1 = New MySqlConnection
        Mysqlconn1.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader1 As MySqlDataReader
        Try
            Mysqlconn1.Open()
            Dim query1 As String

            query1 = "Update athena.package set Package_No='" & TextBox4.Text & "', Package_Price='" & TextBox3.Text & "' where Package_No='" & TextBox4.Text & "'"

            command1 = New MySqlCommand(query1, Mysqlconn1)
            reader1 = command1.ExecuteReader

            MessageBox.Show("Data Updated")

            'Dim OID
            Mysqlconn1 = New MySqlConnection
            Mysqlconn1.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
            Dim sda1 As New MySqlDataAdapter
            Dim dbdataset1 As New DataTable
            Dim bsource1 As New BindingSource
            Try
                Mysqlconn1.Open()
                query1 = "select * from athena.package"
                command1 = New MySqlCommand(query1, Mysqlconn1)
                sda1.SelectCommand = command1
                sda1.Fill(dbdataset1)

                bsource1.DataSource = dbdataset1
                DataGridView2.DataSource = bsource1
                sda1.Update(dbdataset1)
                Mysqlconn1.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Mysqlconn1.Dispose()

            End Try



            reader1.Close()
            Mysqlconn1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
        TextBox1.Clear()



    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class