<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.grpShipping = New System.Windows.Forms.GroupBox()
        Me.radThreeDay = New System.Windows.Forms.RadioButton()
        Me.radFree = New System.Windows.Forms.RadioButton()
        Me.radTwoDay = New System.Windows.Forms.RadioButton()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCardNum = New System.Windows.Forms.Label()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblAddLineDesc = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAddressLine = New System.Windows.Forms.Label()
        Me.grpShipping.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHead.Font = New System.Drawing.Font("Georgia", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblHead.Location = New System.Drawing.Point(145, 9)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Padding = New System.Windows.Forms.Padding(5, 8, 0, 10)
        Me.lblHead.Size = New System.Drawing.Size(393, 66)
        Me.lblHead.TabIndex = 1
        Me.lblHead.Text = "Crescent Apparel "
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.Location = New System.Drawing.Point(212, 75)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(270, 17)
        Me.lblMethod.TabIndex = 2
        Me.lblMethod.Text = "Method of Payment and Shipping Options"
        '
        'grpShipping
        '
        Me.grpShipping.Controls.Add(Me.radThreeDay)
        Me.grpShipping.Controls.Add(Me.radFree)
        Me.grpShipping.Controls.Add(Me.radTwoDay)
        Me.grpShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpShipping.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpShipping.Location = New System.Drawing.Point(42, 122)
        Me.grpShipping.Name = "grpShipping"
        Me.grpShipping.Size = New System.Drawing.Size(240, 131)
        Me.grpShipping.TabIndex = 3
        Me.grpShipping.TabStop = False
        Me.grpShipping.Text = "Shipping"
        '
        'radThreeDay
        '
        Me.radThreeDay.AutoSize = True
        Me.radThreeDay.Location = New System.Drawing.Point(18, 59)
        Me.radThreeDay.Name = "radThreeDay"
        Me.radThreeDay.Size = New System.Drawing.Size(171, 21)
        Me.radThreeDay.TabIndex = 2
        Me.radThreeDay.TabStop = True
        Me.radThreeDay.Text = "3 Day Shipping ($8)"
        Me.radThreeDay.UseVisualStyleBackColor = True
        '
        'radFree
        '
        Me.radFree.AutoSize = True
        Me.radFree.Location = New System.Drawing.Point(18, 84)
        Me.radFree.Name = "radFree"
        Me.radFree.Size = New System.Drawing.Size(211, 21)
        Me.radFree.TabIndex = 1
        Me.radFree.TabStop = True
        Me.radFree.Text = "Free (6-7 Business Days)"
        Me.radFree.UseVisualStyleBackColor = True
        '
        'radTwoDay
        '
        Me.radTwoDay.AutoSize = True
        Me.radTwoDay.Location = New System.Drawing.Point(18, 32)
        Me.radTwoDay.Name = "radTwoDay"
        Me.radTwoDay.Size = New System.Drawing.Size(180, 21)
        Me.radTwoDay.TabIndex = 0
        Me.radTwoDay.TabStop = True
        Me.radTwoDay.Text = "2 Day Shipping ($10)"
        Me.radTwoDay.UseVisualStyleBackColor = True
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.lblCode)
        Me.grpPayment.Controls.Add(Me.txtCode)
        Me.grpPayment.Controls.Add(Me.lblCardNum)
        Me.grpPayment.Controls.Add(Me.txtCard)
        Me.grpPayment.Controls.Add(Me.lblLname)
        Me.grpPayment.Controls.Add(Me.lblFname)
        Me.grpPayment.Controls.Add(Me.txtFname)
        Me.grpPayment.Controls.Add(Me.txtLname)
        Me.grpPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpPayment.Location = New System.Drawing.Point(298, 122)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(400, 219)
        Me.grpPayment.TabIndex = 4
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Information"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(34, 147)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(348, 17)
        Me.lblCode.TabIndex = 9
        Me.lblCode.Text = "Security Code (3 digit number on back of card)"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(34, 167)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(60, 23)
        Me.txtCode.TabIndex = 3
        '
        'lblCardNum
        '
        Me.lblCardNum.AutoSize = True
        Me.lblCardNum.Location = New System.Drawing.Point(31, 88)
        Me.lblCardNum.Name = "lblCardNum"
        Me.lblCardNum.Size = New System.Drawing.Size(321, 17)
        Me.lblCardNum.TabIndex = 7
        Me.lblCardNum.Text = "Credit Card Number (No spaces or hypens)"
        '
        'txtCard
        '
        Me.txtCard.Location = New System.Drawing.Point(34, 108)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(343, 23)
        Me.txtCard.TabIndex = 2
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(158, 27)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(85, 17)
        Me.lblLname.TabIndex = 4
        Me.lblLname.Text = "Last Name"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(31, 27)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(86, 17)
        Me.lblFname.TabIndex = 3
        Me.lblFname.Text = "First Name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(34, 47)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(121, 23)
        Me.txtFname.TabIndex = 0
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(161, 47)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(131, 23)
        Me.txtLname.TabIndex = 1
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDone.Location = New System.Drawing.Point(308, 622)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(120, 38)
        Me.btnDone.TabIndex = 8
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(Me.lblZip)
        Me.grpAddress.Controls.Add(Me.txtZip)
        Me.grpAddress.Controls.Add(Me.txtState)
        Me.grpAddress.Controls.Add(Me.lblState)
        Me.grpAddress.Controls.Add(Me.txtStreet)
        Me.grpAddress.Controls.Add(Me.lblAddLineDesc)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.Label1)
        Me.grpAddress.Controls.Add(Me.lblAddressLine)
        Me.grpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpAddress.Location = New System.Drawing.Point(42, 347)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(656, 260)
        Me.grpAddress.TabIndex = 6
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Shipping Address"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(9, 198)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(133, 17)
        Me.lblZip.TabIndex = 8
        Me.lblZip.Text = "Zip / Postal Code"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(12, 218)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 23)
        Me.txtZip.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(12, 164)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(415, 23)
        Me.txtState.TabIndex = 6
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(9, 143)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(190, 17)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "State / Province / Region"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(12, 108)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(415, 23)
        Me.txtStreet.TabIndex = 5
        '
        'lblAddLineDesc
        '
        Me.lblAddLineDesc.AutoSize = True
        Me.lblAddLineDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddLineDesc.Location = New System.Drawing.Point(118, 89)
        Me.lblAddLineDesc.Name = "lblAddLineDesc"
        Me.lblAddLineDesc.Size = New System.Drawing.Size(235, 15)
        Me.lblAddLineDesc.TabIndex = 3
        Me.lblAddLineDesc.Text = "*Street Address, P.O. Box, company name"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(12, 52)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(242, 23)
        Me.txtCity.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "City"
        '
        'lblAddressLine
        '
        Me.lblAddressLine.AutoSize = True
        Me.lblAddressLine.Location = New System.Drawing.Point(9, 87)
        Me.lblAddressLine.Name = "lblAddressLine"
        Me.lblAddressLine.Size = New System.Drawing.Size(103, 17)
        Me.lblAddressLine.TabIndex = 0
        Me.lblAddressLine.Text = "Address Line"
        '
        'frmPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(737, 677)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grpShipping)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.lblHead)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Name = "frmPay"
        Me.Text = "Crescent Apparel Payment Form"
        Me.grpShipping.ResumeLayout(False)
        Me.grpShipping.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHead As Label
    Friend WithEvents lblMethod As Label
    Friend WithEvents grpShipping As GroupBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblCardNum As Label
    Friend WithEvents txtCard As TextBox
    Friend WithEvents lblLname As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents radFree As RadioButton
    Friend WithEvents radTwoDay As RadioButton
    Friend WithEvents btnDone As Button
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAddressLine As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblAddLineDesc As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents radThreeDay As RadioButton
End Class
