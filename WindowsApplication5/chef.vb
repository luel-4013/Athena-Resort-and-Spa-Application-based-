Imports MySql.Data.MySqlClient
Public Class chef
    Dim Mysqlconn As MySqlConnection
    Dim index As Integer
    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)

        TextBox9.Text = selectedRow.Cells(0).Value.ToString()
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
            query = "select * from athena.room_service"
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

  
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=athena"
        Dim reader As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim query As String

            query = "delete from room_service where Room_No='" & TextBox9.Text & "'"

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
                query = "select * from athena.room_service"
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

    Private Sub chef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Show()
    End Sub
End Class