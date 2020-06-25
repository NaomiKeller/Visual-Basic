Public Class frmPizzaWizard
    Dim sizeChoice As String = ""
    Dim toppingsString As String = ""
    Dim basePrice As Double = 0.00
    Dim salesTax As Double = 0.00
    Dim orderTotal As Double = 0.00
    Dim taxRate As Double = 0.07

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        toppingsString = ""

        If radSmall.Checked Then
            sizeChoice = "Small"
            basePrice = 5.0
        ElseIf radMedium.Checked Then
            sizeChoice = "Medium"
            basePrice = 7.0
        ElseIf radLarge.Checked Then
            sizeChoice = "Large"
            basePrice = 9.0
        Else
            MsgBox("ERROR... You did not select a size.")
        End If

        If chkCheese.Checked Then
            toppingsString += "Cheese"
        End If
        If chkMushrooms.Checked Then
            toppingsString += "Mushrooms"
            basePrice += 0.5
        End If
        If chkPepperoni.Checked Then
            toppingsString += "Pepperoni"
            basePrice += 0.5
        End If
        If chkSausage.Checked Then
            toppingsString += "Sausage"
            basePrice += 0.5
        End If

        salesTax = basePrice * taxRate
        orderTotal = basePrice + salesTax

        txtPrice.Text = basePrice.ToString("c2")
        txtTax.Text = salesTax.ToString("c2")
        txtTotal.Text = orderTotal.ToString("c2")

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If orderTotal = 0.00 Then
            MsgBox("Please calculate your order first")
        ElseIf txtFname.Text = "" Then
            MsgBox("ERROR... Please enter a first name")
        ElseIf txtLname.Text = "" Then
            MsgBox("ERROR... Please enter a last name")
        Else
            MsgBox("Customer info: " + cboTitle.Text + " " + txtFname.Text + " " + txtLname.Text + " " + vbCrLf + "Size: " + sizeChoice + vbCrLf + "Toppings: " + toppingsString + vbCrLf + "Order Total: " + orderTotal.ToString("c2"))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
