<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizzaWizard))
        Me.lblHead = New System.Windows.Forms.Label()
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.BackColor = System.Drawing.SystemColors.Control
        Me.lblHead.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHead.Location = New System.Drawing.Point(36, 34)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(232, 38)
        Me.lblHead.TabIndex = 0
        Me.lblHead.Text = "Pizza Wizard"
        '
        'picPizza
        '
        Me.picPizza.Image = CType(resources.GetObject("picPizza.Image"), System.Drawing.Image)
        Me.picPizza.Location = New System.Drawing.Point(281, 12)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(219, 101)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizza.TabIndex = 1
        Me.picPizza.TabStop = False
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radMedium)
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Location = New System.Drawing.Point(34, 146)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(175, 87)
        Me.grpSize.TabIndex = 2
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(9, 64)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(99, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large (16"" , $9)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(9, 41)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(109, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium (14"" , $7)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(9, 20)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(97, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small (10"" , $5)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkMushrooms)
        Me.grpToppings.Controls.Add(Me.chkSausage)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Controls.Add(Me.chkCheese)
        Me.grpToppings.Location = New System.Drawing.Point(256, 146)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(219, 112)
        Me.grpToppings.TabIndex = 3
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Toppings: (cheese free, others $0.50)"
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(7, 87)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(80, 17)
        Me.chkMushrooms.TabIndex = 3
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(7, 64)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(68, 17)
        Me.chkSausage.TabIndex = 2
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(7, 41)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkPepperoni.TabIndex = 1
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Checked = True
        Me.chkCheese.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheese.Location = New System.Drawing.Point(7, 20)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 0
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(34, 257)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(103, 13)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "Enter Customer Info:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(34, 276)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Title"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(34, 305)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(57, 13)
        Me.lblFname.TabIndex = 6
        Me.lblFname.Text = "First Name"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(34, 335)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(58, 13)
        Me.lblLname.TabIndex = 7
        Me.lblLname.Text = "Last Name"
        '
        'cboTitle
        '
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Mr.", "Mrs.", "Ms."})
        Me.cboTitle.Location = New System.Drawing.Point(107, 273)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(57, 21)
        Me.cboTitle.TabIndex = 8
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(107, 302)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(100, 20)
        Me.txtFname.TabIndex = 9
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(107, 328)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(100, 20)
        Me.txtLname.TabIndex = 10
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(375, 273)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 11
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(375, 299)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 12
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(375, 325)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 13
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(292, 276)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(63, 13)
        Me.lblPrice.TabIndex = 14
        Me.lblPrice.Text = "Order Price:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(292, 302)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(80, 13)
        Me.lblTax.TabIndex = 15
        Me.lblTax.Text = "Sales Tax (7%):"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(292, 328)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Order Total:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(56, 395)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(119, 23)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "CALCULATE PRICE"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(214, 395)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(111, 23)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "SUBMIT ORDER"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(355, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "deliver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPizzaWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.cboTitle)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.picPizza)
        Me.Controls.Add(Me.lblHead)
        Me.Name = "frmPizzaWizard"
        Me.Text = "Pizza Wizard Order Form"
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHead As Label
    Friend WithEvents picPizza As PictureBox
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents chkMushrooms As CheckBox
    Friend WithEvents chkSausage As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents cboTitle As ComboBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class
