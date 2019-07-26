Imports MySql.Data.MySqlClient
Public Class cashier
    Dim Mysqlconn As MySqlConnection
    Private Sub pictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        calculator.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Show()
        calculator.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Register.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try

            Dim query As String
            query = "select COUNT(`customer_id`) FROM `payment_info`"
            command = New MySqlCommand(query, Mysqlconn)
            Mysqlconn.Open()
            Label1.Text = command.ExecuteScalar().ToString()
            Mysqlconn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class