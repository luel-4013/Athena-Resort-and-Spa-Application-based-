Imports MySql.Data.MySqlClient
Public Class Employeeinfo
    Dim Mysqlconn As MySqlConnection
    Dim index As Integer
    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

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
            query = "select * from athena.employee"
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

 
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

   


    Private Sub EXITToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub FILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub INSERTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTToolStripMenuItem.Click
        empHire.Show()

        Me.Width = 760
        Me.Text = "INSERT"
    End Sub

    Private Sub DISPLAYToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Me.Width = 760
        Me.Text = "INSERT"
        empHire.Close()
    End Sub

  
    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Employeeinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

   
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FilterData(TextBox4.Text)

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
            query = "select * from employee WHERE CONCAT(firstName, lastname) like '%" & valuetosearch & "%'"
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

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)
        empHire.TextBox9.Text = selectedRow.Cells(0).Value.ToString()
        empHire.TextBox1.Text = selectedRow.Cells(1).Value.ToString()
        empHire.TextBox2.Text = selectedRow.Cells(2).Value.ToString()
        empHire.TextBox3.Text = selectedRow.Cells(3).Value.ToString()

        empHire.age.Text = selectedRow.Cells(5).Value.ToString()
        empHire.TextBox10.Text = selectedRow.Cells(6).Value.ToString()

        empHire.TextBox4.Text = selectedRow.Cells(8).Value.ToString()
        empHire.TextBox8.Text = selectedRow.Cells(9).Value.ToString()

        empHire.TextBox5.Text = selectedRow.Cells(10).Value.ToString()

        empHire.TextBox7.Text = selectedRow.Cells(11).Value.ToString()
        empHire.TextBox11.Text = selectedRow.Cells(12).Value.ToString()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class