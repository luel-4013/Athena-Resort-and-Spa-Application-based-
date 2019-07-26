Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Width = 469
        GroupBox2.Height = 600

        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Width = 469
        GroupBox3.Height = 600

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Width = 469
        GroupBox2.Height = 600

        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Width = 469
        GroupBox1.Height = 600

        GroupBox1.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Text = "DELETE"
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Width = 469
        GroupBox3.Height = 600

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Width = 469
        GroupBox2.Height = 600

        GroupBox1.Visible = False
        GroupBox2.Visible = True
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
            query = "select *from athena.Admin_Login where username='" &
               txtUsername.Text & " ' and password= '" & txtPassword.Text & "'"
            command = New MySqlCommand(query, MysqlConn)


            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then


                Me.Visible = False
                Admin.Show()

            ElseIf count > 1 Then
                MessageBox.Show("User name and Password are duplicate")
            Else
                MessageBox.Show("User name and Pasword are not correct")

            End If
            MysqlConn.Close()
        Catch ex As Exception

        End Try
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim MysqlConn As MySqlConnection

        Dim command
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select *from athena.Reception_Login where username='" &
               txtUsername1.Text & " ' and password= '" & txtPassword1.Text & "'"
            command = New MySqlCommand(query, MysqlConn)


            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then


                Me.Visible = False
                Reception.Show()

            ElseIf count > 1 Then
                MessageBox.Show("User name and Password are duplicate")
            Else
                MessageBox.Show("User name and Pasword are not correct")

            End If
            MysqlConn.Close()
        Catch ex As Exception

        End Try
        txtUsername1.Clear()
        txtPassword1.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim MysqlConn As MySqlConnection

        Dim command
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select *from athena.Cashier_Login where username='" &
               txtUsername2.Text & " ' and password= '" & txtPassword2.Text & "'"
            command = New MySqlCommand(query, MysqlConn)


            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then


                Me.Visible = False
                cashier.Show()

            ElseIf count > 1 Then
                MessageBox.Show("User name and Password are duplicate")
            Else
                MessageBox.Show("User name and Pasword are not correct")

            End If
            MysqlConn.Close()
        Catch ex As Exception

        End Try
        txtUsername2.Clear()
        txtPassword2.Clear()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox4.Location = New Point(0, 0)
        GroupBox4.Width = 469
        GroupBox4.Height = 600

        GroupBox1.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox4.Location = New Point(0, 0)
        GroupBox4.Width = 469
        GroupBox4.Height = 600

        GroupBox1.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox4.Location = New Point(0, 0)
        GroupBox4.Width = 469
        GroupBox4.Height = 600

        GroupBox1.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Width = 469
        GroupBox3.Height = 600

        GroupBox4.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Width = 469
        GroupBox1.Height = 600

        GroupBox1.Visible = True
        GroupBox4.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox2.Location = New Point(0, 0)
        GroupBox2.Width = 469
        GroupBox2.Height = 600

        GroupBox1.Visible = True
        GroupBox4.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim MysqlConn As MySqlConnection

        Dim command
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select *from athena.Servicep_Login where username='" &
               TextBox2.Text & " ' and password= '" & TextBox1.Text & "'"
            command = New MySqlCommand(query, MysqlConn)


            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then


                Me.Visible = False
                serviceprovider.Show()

            ElseIf count > 1 Then
                MessageBox.Show("User name and Password are duplicate")
            Else
                MessageBox.Show("User name and Pasword are not correct")

            End If
            MysqlConn.Close()
        Catch ex As Exception

        End Try
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox5.Location = New Point(0, 0)
        GroupBox5.Width = 469
        GroupBox5.Height = 600

        GroupBox1.Visible = False
        GroupBox5.Visible = True
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox5.Location = New Point(0, 0)
        GroupBox5.Width = 469
        GroupBox5.Height = 600

        GroupBox5.Visible = True
        GroupBox2.Visible = False


    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox5.Location = New Point(0, 0)
        GroupBox5.Width = 469
        GroupBox5.Height = 600

        GroupBox5.Visible = True
        GroupBox3.Visible = False
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox5.Location = New Point(0, 0)
        GroupBox5.Width = 469
        GroupBox5.Height = 600

        GroupBox5.Visible = True

        GroupBox4.Visible = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Width = 469
        GroupBox3.Height = 600

        GroupBox3.Visible = True

        GroupBox5.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Width = 469
        GroupBox1.Height = 600

        GroupBox1.Visible = True

        GroupBox5.Visible = False
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox4.Location = New Point(0, 0)
        GroupBox4.Width = 469
        GroupBox4.Height = 600

        GroupBox4.Visible = True

        GroupBox5.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Width = 475
        Me.Text = "DELETE"
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Width = 469
        GroupBox3.Height = 600

        GroupBox3.Visible = True

        GroupBox5.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim MysqlConn As MySqlConnection

        Dim command
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select *from athena.Chef_login where username='" &
               TextBox4.Text & " ' and password= '" & TextBox3.Text & "'"
            command = New MySqlCommand(query, MysqlConn)


            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then


                Me.Visible = False
                chef.Show()

            ElseIf count > 1 Then
                MessageBox.Show("User name and Password are duplicate")
            Else
                MessageBox.Show("User name and Pasword are not correct")

            End If
            MysqlConn.Close()
        Catch ex As Exception

        End Try
    
    End Sub
End Class