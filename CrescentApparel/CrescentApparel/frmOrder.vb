Public Class frmOrder

    'Crescent Apparel Shirt Order Form by Naomi Keller
    'Version 1.6. Last updated 2/9/2019.
    'This program allows the user to customer order a shirt and then fill out payment and shipping information.

    Dim sizeChoice As String = ""
    Dim colorString As String = ""
    Public basePrice As Double = 0.00
    Dim shirtCustom As String = ""
    Public firstName As String = ""
    Public lastName As String = ""
    Public cardNum As String = ""
    Public cardCode As String = ""
    Public cityName As String = ""
    Public streetAdd As String = ""
    Public stateName As String = ""
    Public zipCode As String = ""
    Public shippingSelect As String = ""

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Size calculation'

        sizeChoice = ""

        If radSmall.Checked Then
            sizeChoice = "Small"
            basePrice = 15.0
        ElseIf radMedium.Checked Then
            sizeChoice = "Medium"
            basePrice = 16.0
        ElseIf radLarge.Checked Then
            sizeChoice = "Large"
            basePrice = 17.0
        End If

        'Color Selection'

        If radPurple.Checked Then
            colorString = "Purple"
        ElseIf radWhite.Checked Then
            colorString = "White"
        ElseIf radBlue.Checked Then
            colorString = "Blue"
        End If

        'Custom Design Selection'

        If chkBack.Checked Then
            shirtCustom += "Back Logo. "
            basePrice += 2.0
        End If
        If chkFront.Checked Then
            shirtCustom += "Front Logo. "
            basePrice += 2.0
        End If
        If chkSleeve.Checked Then
            shirtCustom += "Black Sleeves. "
            basePrice += 5.0
        End If

        'Sending base total to text box'

        txtSelectionTotal.Text = basePrice.ToString("c2")

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        If txtSelectionTotal.Text = "" Then
            MsgBox("Please confirm your selection.")
        Else         'Sending the user to complete the next form'
            Dim frmPay As New frmPay
            frmPay.Show()
        End If
    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        If zipCode = "" Then 'Checking the user has done the other form.
            MsgBox("Please complete the forms before confirming your order.")
        Else
            'Lets the user confirm all information is correct before placing the order
            Dim result = MsgBox("Please confirm your information is correct before placing the order. Click cancel if changes are needed." + vbCrLf + vbCrLf +
                        "Name: " + firstName + " " + lastName + vbCrLf +
                        "Credit Card: " + cardNum + " VIN: " + cardCode + vbCrLf +
                        "Shipping Address: " + streetAdd + ", " + cityName + ", " + stateName + " " + zipCode + vbCrLf +
                        shippingSelect + vbCrLf +
                        "Shirt: " + sizeChoice + ", " + colorString + ", " + shirtCustom, MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then
                MsgBox("Thank you for shopping with us! We have placed your order. Your order will be shipped, and the program will now close.")
                Me.Close()
            End If
        End If
    End Sub
End Class
