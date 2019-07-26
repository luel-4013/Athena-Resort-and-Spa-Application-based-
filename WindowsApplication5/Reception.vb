Imports MySql.Data.MySqlClient
Public Class Reception
    Dim Mysqlconn As MySqlConnection
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        qrgeneator.Show()

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs)
        chef.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        BookReq.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RoomA.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Checkout.Show()
    End Sub

    Private Sub Reception_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)

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
            query = "select COUNT(`customer_id`) FROM `customer_account`"
            command = New MySqlCommand(query, Mysqlconn)
            Mysqlconn.Open()
            Label2.Text = command.ExecuteScalar().ToString()
            Mysqlconn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class