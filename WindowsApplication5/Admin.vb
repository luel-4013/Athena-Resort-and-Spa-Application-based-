Imports MySql.Data.MySqlClient
Public Class Admin
    Dim Mysqlconn As MySqlConnection
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Employeeinfo.Show()





    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub button2_Click_1(sender As Object, e As EventArgs) Handles button2.Click
        Accounting.Show()


    End Sub




    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Price_edit.Show()
    End Sub

    Private Sub GroupBox4_Enter_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Show()
    End Sub
End Class
