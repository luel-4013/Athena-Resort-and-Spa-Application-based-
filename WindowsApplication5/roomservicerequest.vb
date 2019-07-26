Imports MySql.Data.MySqlClient
Public Class roomservicerequest
    Dim Mysqlconn As MySqlConnection
    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command
        'Dim OID
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=leul"
        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            Mysqlconn.Open()
            Dim query As String
            query = "select * from leul.customer_info"
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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub
End Class