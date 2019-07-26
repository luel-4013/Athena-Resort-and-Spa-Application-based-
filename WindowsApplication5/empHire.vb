Imports MySql.Data.MySqlClient
Public Class empHire



    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles bday.ValueChanged
        Dim d1, d2 As Date

        Dim days, months, years As Long

        d1 = bday.Value.ToShortDateString
        d2 = Now.ToShortDateString

        years = Year(d1)
        months = Month(d1)
        days = d1.Day

        years = Year(d2) - years
        months = Month(d2) - months
        days = d2.Day - days

        If Math.Sign(days) = -1 Then
            days = 30 - Math.Abs(days)
            months = months - 1
        End If

        If Math.Sign(months) = -1 Then
            months = 12 - Math.Abs(months)
            years = years - 1
        End If

        age.Text = years.ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim MysqlConn As MySqlConnection


        Dim command
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "insert into employee values('" & TextBox9.Text & "','" & TextBox1.Text & "' ,'" & TextBox2.Text & "','" & TextBox3.Text & "','" & bday.Value & "','" & age.Text & "','" & TextBox10.Text & "','" & hire.Value & "','" & TextBox4.Text & "','" & TextBox8.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox11.Text & "')"
            command = New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader


            MessageBox.Show("Data Inserted!")
            'Dim OID
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource

            MysqlConn.Open()
            query = "select * from athena.employee"
            command = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = command
            sda.Fill(dbdataset)

            bsource.DataSource = dbdataset
            Employeeinfo.DataGridView2.DataSource = bsource
            sda.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        age.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MysqlConn As MySqlConnection
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String

            query = "Update athena.employee set empid='" & TextBox9.Text & "',firstname='" & TextBox1.Text & "',lastname='" & TextBox2.Text & "',adress='" & TextBox3.Text & "',bday='" & bday.Text & "',age='" & age.Text & "',Gender='" & TextBox10.Text & "',hiredate='" & hire.Text & "',contact='" & TextBox4.Text & "',position='" & TextBox8.Text & "',emergency_Name='" & TextBox5.Text & "',emergency_Phone='" & TextBox7.Text & "',Salary='" & TextBox11.Text & "' where empid='" & TextBox9.Text & "'"

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
                query = "select * from athena.employee"
                command = New MySqlCommand(query, Mysqlconn)
                sda.SelectCommand = command
                sda.Fill(dbdataset)

                bsource.DataSource = dbdataset
                Employeeinfo.DataGridView2.DataSource = bsource
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
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        age.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox10.Clear()

    End Sub

    Private Sub empHire_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        age.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged

    End Sub

    Private Sub empHire_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Mysqlconn As MySqlConnection
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String

            query = "delete from employee where empID='" & TextBox9.Text & "'"

            command = New MySqlCommand(query, Mysqlconn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Deleted")

            'Dim OID
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
            Dim sda As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource
            Try
                Mysqlconn.Open()
                query = "select * from athena.employee"
                command = New MySqlCommand(query, Mysqlconn)
                sda.SelectCommand = command
                sda.Fill(dbdataset)

                bsource.DataSource = dbdataset
                Employeeinfo.DataGridView2.DataSource = bsource
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
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        age.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox10.Clear()
    End Sub
End Class
