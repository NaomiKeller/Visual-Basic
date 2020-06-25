Public Class frmPay
    Dim taxRate As Double = 0.07
    Dim salesTax As Double = 0.00
    Dim orderTotal As Double = 0.00
    Dim selectionTotal As Double = 0.00


    Private Sub frmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectionTotal = frmOrder.basePrice
        'This loads the basePrice from the first form into the new form so that shipping can be added (or not be added if free)
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        'Error checking... if user doesn't fill the form completely it will prompt them.

        Dim zipCheck = CInt(txtZip.Text)
        Dim creditCheck = Convert.ToInt64(txtCard.Text)
        Dim codeCheck = CInt(txtCode.Text)

        If txtFname.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtLname.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtCard.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtCode.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtCity.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtStreet.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtState.Text = "" Then
            MsgBox("Please complete all fields")
        ElseIf txtZip.Text = "" Then
            MsgBox("Please complete all fields")
            'The following makes sure the user enters valid information (to the best of my ability)
        ElseIf zipCheck < 10000 Or zipCheck > 99999 Then
            MsgBox("Zip Code Invalid. Zip Codes are 5 digit numbers.")
        ElseIf creditCheck < 100_000_000_000_0000 Or creditCheck > 999_999_999_999_9999 Then
            MsgBox("Credit Card Invalid. Credit Card numbers consist of 16 digits.")
        ElseIf codeCheck < 100 Or codeCheck > 999 Then
            MsgBox("Credit Card VIN code invalid. It should be a 3 digit number.")
        Else

            frmOrder.firstName = CStr(txtFname.Text)
            frmOrder.lastName = CStr(txtLname.Text)
            frmOrder.cardNum = CStr(txtCard.Text)
            frmOrder.cardCode = CStr(txtCode.Text)
            frmOrder.cityName = CStr(txtCity.Text)
            frmOrder.streetAdd = CStr(txtStreet.Text)
            frmOrder.stateName = CStr(txtState.Text)
            frmOrder.zipCode = CStr(txtZip.Text)


            If radTwoDay.Checked Then
                selectionTotal += 10

                frmOrder.shippingSelect = "2 Day Shipping"

                salesTax = selectionTotal * taxRate
                orderTotal = selectionTotal + salesTax

                frmOrder.txtTax.Text = salesTax.ToString("c2")
                frmOrder.txtTotal.Text = orderTotal.ToString("c2")

                Me.Close()

            ElseIf radThreeDay.Checked Then

                selectionTotal += 8

                frmOrder.shippingSelect = "3 Day Shipping"

                salesTax = selectionTotal * taxRate
                orderTotal = selectionTotal + salesTax

                frmOrder.txtTax.Text = salesTax.ToString("c2")
                frmOrder.txtTotal.Text = orderTotal.ToString("c2")

                Me.Close()
            Else

                frmOrder.shippingSelect = "Free Shipping"

                salesTax = selectionTotal * taxRate
                orderTotal = selectionTotal + salesTax

                frmOrder.txtTax.Text = salesTax.ToString("c2")
                frmOrder.txtTotal.Text = orderTotal.ToString("c2")

                Me.Close()
            End If
        End If
    End Sub


End Class
