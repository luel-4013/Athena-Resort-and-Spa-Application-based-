Imports MySql.Data.MySqlClient

Public Class BookReq
    Dim Mysqlconn As MySqlConnection
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
            query = "select * from athena.Customer_account"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Width = 1250

        Me.Text = ""
        GroupBox1.Location = New Point(790, 10)
        GroupBox1.Width = 593
        GroupBox1.Height = 650



        GroupBox1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Width = 750
    End Sub

    Private Sub EXITToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DISPLAYToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub INSERTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)
        id.Text = selectedRow.Cells(0).Value.ToString()
        Fname.Text = selectedRow.Cells(1).Value.ToString()
        Lname.Text = selectedRow.Cells(2).Value.ToString()
        Adate.Text = selectedRow.Cells(3).Value.ToString()
        Ddate.Text = selectedRow.Cells(4).Value.ToString()
        Nbed.Text = selectedRow.Cells(5).Value.ToString()
        package.Text = selectedRow.Cells(6).Value.ToString()
        Eadress.Text = selectedRow.Cells(7).Value.ToString()
        Pnumber.Text = selectedRow.Cells(8).Value.ToString()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MysqlConn As MySqlConnection


        Dim command
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "insert into athena.Payment_info values('" & id.Text & "','" & Fname.Text & "' ,'" & Lname.Text & "','" & Adate.Text & "','" & Ddate.Text & "','" & Nbed.Text & "','" & RNo.Text & "','" & package.Text & "','" & Eadress.Text & "','" & Pnumber.Text & "')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader


            MessageBox.Show("Data Sent!")
            Me.Width = 940
            'Dim OID
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource

           
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        id.Clear()
        Fname.Clear()
        Lname.Clear()
        Adate.Clear()
        Ddate.Clear()
        Nbed.Clear()
        package.Clear()
        Eadress.Clear()
        Pnumber.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub BookReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            query = "select * from Customer_account WHERE CONCAT(FirstName, LastName) like '%" & valuetosearch & "%'"
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class