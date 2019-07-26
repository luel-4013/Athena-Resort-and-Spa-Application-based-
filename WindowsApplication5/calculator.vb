Public Class calculator
    Dim iCelsius, iFahrenheit, iKelvin As Double
    Dim iOperation As String
    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim Opera As String
   

    Private Sub btnSpace_Click(sender As Object, e As EventArgs) Handles btnSpace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub
    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click
        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)
        Else
            txtDisplay.Text = "-" + txtDisplay.Text
        End If
    End Sub
    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtDisplay.Text = "0"
        lblShowOp.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        lblShowOp.Text = ""
    End Sub
    Private Sub btnPi_Click(sender As Object, e As EventArgs)
        txtDisplay.Text = "3.141592653589976323"
    End Sub
    Private Sub btnLog_Click(sender As Object, e As EventArgs)
        Dim ilog As Double

        ilog = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
        ilog = Math.Log10(ilog)
        txtDisplay.Text = System.Convert.ToString(ilog)
    End Sub
    Private Sub btnSqrt_Click(sender As Object, e As EventArgs)

        Dim iSqrt As Double

        iSqrt = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")")
        iSqrt = Math.Sqrt(iSqrt)
        txtDisplay.Text = System.Convert.ToString(iSqrt)
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Width = 430
        txtDisplay.Width = 380
        Me.Text = "Scientific Calculator"
    End Sub


   
    Private Sub button_click(sender As Object, e As EventArgs) Handles Button8.Click, Button7.Click, Button6.Click, Button20.Click, Button16.Click, Button15.Click, Button14.Click, Button12.Click, Button11.Click, Button10.Click

        'Code for button 0 to 9
        Dim b As Button = sender
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = b.Text
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If

    End Sub

    Private Sub Arithmetic_Operatr(sender As Object, e As EventArgs) Handles Button9.Click, Button5.Click, Button17.Click, Button13.Click

        'this codes are for +, -, *, /, Mod, Exp
        Dim ops As Button = sender
        firstnum = txtDisplay.Text
        lblShowOp.Text = txtDisplay.Text
        txtDisplay.Text = ""
        Opera = ops.Text
        lblShowOp.Text = lblShowOp.Text + " " + Opera

    End Sub
    Private Sub btnTan_Click(sender As Object, e As EventArgs)
        Dim iTan As Double

        iTan = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")")
        iTan = Math.Tan(iTan)
        txtDisplay.Text = System.Convert.ToString(iTan)
    End Sub
    Private Sub btnTanh_Click(sender As Object, e As EventArgs)
        Dim iTanh As Double

        iTanh = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")")
        iTanh = Math.Tanh(iTanh)
        txtDisplay.Text = System.Convert.ToString(iTanh)

    End Sub
    Private Sub btnBin_Click(sender As Object, e As EventArgs)
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 2)
    End Sub
    Private Sub btnOct_Click(sender As Object, e As EventArgs)
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 8)
    End Sub
    Private Sub btnHex_Click(sender As Object, e As EventArgs)
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 16)
    End Sub
    Private Sub btnDec_Click(sender As Object, e As EventArgs)
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs)
        Dim iCos As Double

        iCos = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")")
        iCos = Math.Cos(iCos)
        txtDisplay.Text = System.Convert.ToString(iCos)

    End Sub
    Private Sub btnCosh_Click(sender As Object, e As EventArgs)
        Dim iCosh As Double

        iCosh = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")")
        iCosh = Math.Cosh(iCosh)
        txtDisplay.Text = System.Convert.ToString(iCosh)

    End Sub

    Private Sub Sin_Click(sender As Object, e As EventArgs)
        Dim iSin As Double

        iSin = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")")
        iSin = Math.Sin(iSin)
        txtDisplay.Text = System.Convert.ToString(iSin)

    End Sub
    Private Sub Sinh_Click(sender As Object, e As EventArgs)
        Dim iSinh As Double

        iSinh = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")")
        iSinh = Math.Sinh(iSinh)
        txtDisplay.Text = System.Convert.ToString(iSinh)
    End Sub
    Private Sub btnPerc_Click(sender As Object, e As EventArgs)
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnx3_Click(sender As Object, e As EventArgs)
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub
    Private Sub btnx2_Click(sender As Object, e As EventArgs)
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub
    Private Sub btn1x_Click(sender As Object, e As EventArgs)
        Dim a As Double
        a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text))
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub
    Private Sub btnlnx_Click(sender As Object, e As EventArgs)
        Dim ilog As Double = Double.Parse(txtDisplay.Text)
        lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
        ilog = Math.Log(ilog)
        txtDisplay.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        'lines of code for the equal
        secondnum = txtDisplay.Text
        If Opera = "+" Then
            answer = firstnum + secondnum
            txtDisplay.Text = answer
            lblShowOp.Text = ""
        ElseIf Opera = "-" Then
            answer = firstnum - secondnum
            txtDisplay.Text = answer
            lblShowOp.Text = ""
        ElseIf Opera = "*" Then
            answer = firstnum * secondnum
            txtDisplay.Text = answer
            lblShowOp.Text = ""
        ElseIf Opera = "/" Then
            answer = firstnum / secondnum
            txtDisplay.Text = answer
            lblShowOp.Text = ""
        ElseIf Opera = "Mod" Then
            answer = firstnum Mod secondnum
            txtDisplay.Text = answer
            lblShowOp.Text = ""
        ElseIf Opera = "Exp" Then
            answer = firstnum ^ secondnum
            txtDisplay.Text = answer
            lblShowOp.Text = ""
        End If


    End Sub
    Private Sub txtDisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisplay.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
End Class

