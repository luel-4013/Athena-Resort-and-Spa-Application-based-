Imports MySql.Data.MySqlClient
Public Class Checkout
    Dim Mysqlconn As MySqlConnection
    Dim index As Integer
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String

            query = "delete from payment_info where customer_ID='" & TextBox9.Text & "'"

            command = New MySqlCommand(query, Mysqlconn)
            reader = command.ExecuteReader

            MessageBox.Show("Checked Out")

            'Dim OID
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource
            Try
                Mysqlconn.Open()
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



            reader.Close()
            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
        TextBox9.Clear()

    End Sub


    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

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
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)

        TextBox9.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FilterData(TextBox4.Text)
    End Sub
End Class