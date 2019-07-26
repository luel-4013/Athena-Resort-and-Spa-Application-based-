Imports MySql.Data.MySqlClient
Public Class Register
    Dim Mysqlconn As MySqlConnection
    Dim Mysqlconn1 As MySqlConnection
    Dim Mysqlconn2 As MySqlConnection
    Dim index As Integer
    Const tax_rate = 0.15


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
            query = "select * from athena.Payment_info"
            command = New MySqlCommand(query, Mysqlconn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            DataGridView3.DataSource = bsource
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


        Dim command2

        'Dim OID
        Mysqlconn2 = New MySqlConnection
        Mysqlconn2.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim sda2 As New MySqlDataAdapter
        Dim dbdataset2 As New DataTable
        Dim bsource2 As New BindingSource
        Try
            Mysqlconn.Open()
            Dim query2 As String
            query2 = "select * from athena.room"
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView3.Rows(index)
        id.Text = selectedRow.Cells(0).Value.ToString()
        Fname.Text = selectedRow.Cells(1).Value.ToString()
        Lname.Text = selectedRow.Cells(2).Value.ToString()
        Adate.Text = selectedRow.Cells(3).Value.ToString()
        Ddate.Text = selectedRow.Cells(4).Value.ToString()
        Nbed.Text = selectedRow.Cells(5).Value.ToString()
        TextBox5.Text = selectedRow.Cells(6).Value.ToString()
        package.Text = selectedRow.Cells(7).Value.ToString()
        Eadress.Text = selectedRow.Cells(8).Value.ToString()
        Pnumber.Text = selectedRow.Cells(9).Value.ToString()

    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)
        Pprice.Text = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub DataGridView1_CelltClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Rprice.Text = selectedRow.Cells(1).Value.ToString()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Tax.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim paprice As Double
        Dim Roprice As Double
        Dim subtot As Double
        Dim total As Double
        Dim taxx As Double
        If IsNumeric(Pprice.Text & Rprice.Text) Then
            paprice = Val(Pprice.Text)
            Roprice = Val(Rprice.Text)
            subtot = paprice + Roprice
            Tax.Text = subtot * tax_rate

        End If
        If IsNumeric(Tax.Text) Then
            taxx = Val(Tax.Text)
            total = taxx + subtot
            TextBox2.Text = total
        End If


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        TextBox1.Clear()
        TextBox1.AppendText(vbTab + "Athena Resort and spa" + Environment.NewLine)
        TextBox1.AppendText(vbTab + "D.Z Debrezeyit " + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)

        TextBox1.AppendText("Room Type " + vbTab + vbTab + Nbed.Text + Environment.NewLine)
        TextBox1.AppendText("Package " + vbTab + vbTab + vbTab + package.Text + Environment.NewLine)
        TextBox1.AppendText("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)

        TextBox1.AppendText("Package Price " + vbTab + vbTab + Pprice.Text + Environment.NewLine)
        TextBox1.AppendText("Room Price  " + vbTab + vbTab + Rprice.Text + Environment.NewLine)

        TextBox1.AppendText("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)
        TextBox1.AppendText("Tax(15.00%) " + vbTab + vbTab + Tax.Text + Environment.NewLine)

        TextBox1.AppendText("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)
        TextBox1.AppendText("Total " + vbTab + vbTab + vbTab + TextBox2.Text + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)
        TextBox1.AppendText(vbTab + "    " + Environment.NewLine)
        TextBox1.AppendText(TextBox3.Text + vbTab + vbTab + TextBox4.Text + Environment.NewLine)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub lbldate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = DateTime.Now.ToLongDateString
        TextBox4.Text = DateTime.Now.ToLongTimeString
        FilterData("")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim command
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "insert into athena.accounting values('" & id.Text & "','" & Fname.Text & "' ,'" & Lname.Text & "','" & Adate.Text & "','" & Ddate.Text & "','" & Nbed.Text & "','" & TextBox5.Text & "','" & package.Text & "','" & Eadress.Text & "','" & Pnumber.Text & "','" & Pprice.Text & "','" & Rprice.Text & "','" & Tax.Text & "','" & TextBox2.Text & "')"
            command = New MySqlCommand(query, Mysqlconn)
            reader = command.ExecuteReader


            MessageBox.Show("Data Inserted!")
            'Dim OID
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id.Clear()
        Fname.Clear()
        Lname.Clear()
        Adate.Clear()
        Ddate.Clear()
        Nbed.Clear()
        package.Clear()
        Eadress.Clear()
        Pnumber.Clear()
        Pprice.Clear()
        Rprice.Clear()
        Tax.Clear()
        TextBox2.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

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


            DataGridView3.DataSource = dbdataset


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FilterData(TextBox6.Text)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class