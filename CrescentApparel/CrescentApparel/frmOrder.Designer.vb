<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrder))
        Me.lblHead = New System.Windows.Forms.Label()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpColors = New System.Windows.Forms.GroupBox()
        Me.lblNoCost = New System.Windows.Forms.Label()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.radPurple = New System.Windows.Forms.RadioButton()
        Me.grpCustom = New System.Windows.Forms.GroupBox()
        Me.chkBack = New System.Windows.Forms.CheckBox()
        Me.chkFront = New System.Windows.Forms.CheckBox()
        Me.chkSleeve = New System.Windows.Forms.CheckBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblFinTotal = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.lblTotalExplaination = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSelectionTotal = New System.Windows.Forms.Label()
        Me.txtSelectionTotal = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.grpSize.SuspendLayout()
        Me.grpColors.SuspendLayout()
        Me.grpCustom.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHead.Font = New System.Drawing.Font("Georgia", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblHead.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblHead.Location = New System.Drawing.Point(213, 25)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Padding = New System.Windows.Forms.Padding(5, 8, 0, 10)
        Me.lblHead.Size = New System.Drawing.Size(393, 66)
        Me.lblHead.TabIndex = 0
        Me.lblHead.Text = "Crescent Apparel "
        '
        'grpSize
        '
        Me.grpSize.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radMedium)
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSize.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpSize.Location = New System.Drawing.Point(25, 126)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(203, 154)
        Me.grpSize.TabIndex = 2
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(16, 114)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(120, 24)
        Me.radLarge.TabIndex = 5
        Me.radLarge.Text = "Large ($17)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(16, 75)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(136, 24)
        Me.radMedium.TabIndex = 4
        Me.radMedium.Text = "Medium ($16)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(16, 36)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(118, 24)
        Me.radSmall.TabIndex = 3
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small ($15)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpColors
        '
        Me.grpColors.Controls.Add(Me.lblNoCost)
        Me.grpColors.Controls.Add(Me.radBlue)
        Me.grpColors.Controls.Add(Me.radWhite)
        Me.grpColors.Controls.Add(Me.radPurple)
        Me.grpColors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColors.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpColors.Location = New System.Drawing.Point(249, 126)
        Me.grpColors.Name = "grpColors"
        Me.grpColors.Size = New System.Drawing.Size(194, 154)
        Me.grpColors.TabIndex = 3
        Me.grpColors.TabStop = False
        Me.grpColors.Text = "Colors"
        '
        'lblNoCost
        '
        Me.lblNoCost.AutoSize = True
        Me.lblNoCost.Location = New System.Drawing.Point(6, 22)
        Me.lblNoCost.Name = "lblNoCost"
        Me.lblNoCost.Size = New System.Drawing.Size(170, 20)
        Me.lblNoCost.TabIndex = 3
        Me.lblNoCost.Text = " (No additional cost)"
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(16, 85)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(63, 24)
        Me.radBlue.TabIndex = 2
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Checked = True
        Me.radWhite.Location = New System.Drawing.Point(16, 55)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(73, 24)
        Me.radWhite.TabIndex = 1
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'radPurple
        '
        Me.radPurple.AutoSize = True
        Me.radPurple.Location = New System.Drawing.Point(16, 115)
        Me.radPurple.Name = "radPurple"
        Me.radPurple.Size = New System.Drawing.Size(78, 24)
        Me.radPurple.TabIndex = 0
        Me.radPurple.Text = "Purple"
        Me.radPurple.UseVisualStyleBackColor = True
        '
        'grpCustom
        '
        Me.grpCustom.Controls.Add(Me.chkBack)
        Me.grpCustom.Controls.Add(Me.chkFront)
        Me.grpCustom.Controls.Add(Me.chkSleeve)
        Me.grpCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpCustom.Location = New System.Drawing.Point(25, 296)
        Me.grpCustom.Name = "grpCustom"
        Me.grpCustom.Size = New System.Drawing.Size(418, 194)
        Me.grpCustom.TabIndex = 4
        Me.grpCustom.TabStop = False
        Me.grpCustom.Text = "Customize"
        '
        'chkBack
        '
        Me.chkBack.AutoSize = True
        Me.chkBack.Location = New System.Drawing.Point(22, 142)
        Me.chkBack.Name = "chkBack"
        Me.chkBack.Size = New System.Drawing.Size(160, 24)
        Me.chkBack.TabIndex = 2
        Me.chkBack.Text = "Back Logo (+$2)"
        Me.chkBack.UseVisualStyleBackColor = True
        '
        'chkFront
        '
        Me.chkFront.AutoSize = True
        Me.chkFront.Location = New System.Drawing.Point(22, 89)
        Me.chkFront.Name = "chkFront"
        Me.chkFront.Size = New System.Drawing.Size(163, 24)
        Me.chkFront.TabIndex = 1
        Me.chkFront.Text = "Front Logo (+$2)"
        Me.chkFront.UseVisualStyleBackColor = True
        '
        'chkSleeve
        '
        Me.chkSleeve.AutoSize = True
        Me.chkSleeve.Location = New System.Drawing.Point(22, 40)
        Me.chkSleeve.Name = "chkSleeve"
        Me.chkSleeve.Size = New System.Drawing.Size(274, 24)
        Me.chkSleeve.TabIndex = 0
        Me.chkSleeve.Text = "Dual Tone Black Sleeves (+$5)"
        Me.chkSleeve.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(612, 539)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(110, 27)
        Me.txtTotal.TabIndex = 5
        '
        'lblFinTotal
        '
        Me.lblFinTotal.AutoSize = True
        Me.lblFinTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinTotal.Location = New System.Drawing.Point(506, 542)
        Me.lblFinTotal.Name = "lblFinTotal"
        Me.lblFinTotal.Size = New System.Drawing.Size(103, 20)
        Me.lblFinTotal.TabIndex = 6
        Me.lblFinTotal.Text = "Final Total: "
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPay.Location = New System.Drawing.Point(107, 585)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(263, 33)
        Me.btnPay.TabIndex = 7
        Me.btnPay.Text = "PAYMENT AND SHIPPING"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnPlace
        '
        Me.btnPlace.BackColor = System.Drawing.Color.MediumPurple
        Me.btnPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlace.Location = New System.Drawing.Point(549, 577)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(153, 41)
        Me.btnPlace.TabIndex = 8
        Me.btnPlace.Text = "PLACE ORDER"
        Me.btnPlace.UseVisualStyleBackColor = False
        '
        'lblTotalExplaination
        '
        Me.lblTotalExplaination.AutoSize = True
        Me.lblTotalExplaination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExplaination.Location = New System.Drawing.Point(22, 493)
        Me.lblTotalExplaination.Name = "lblTotalExplaination"
        Me.lblTotalExplaination.Size = New System.Drawing.Size(451, 13)
        Me.lblTotalExplaination.TabIndex = 9
        Me.lblTotalExplaination.Text = "*Tax and shipping cost will be added after you complete the payment and shipping " &
    "information."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CrescentApparel.My.Resources.Resources.img
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(469, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 355)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(612, 509)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(59, 26)
        Me.txtTax.TabIndex = 10
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(567, 515)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(38, 20)
        Me.lblTax.TabIndex = 11
        Me.lblTax.Text = "Tax:"
        '
        'lblSelectionTotal
        '
        Me.lblSelectionTotal.AutoSize = True
        Me.lblSelectionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionTotal.Location = New System.Drawing.Point(134, 554)
        Me.lblSelectionTotal.Name = "lblSelectionTotal"
        Me.lblSelectionTotal.Size = New System.Drawing.Size(122, 17)
        Me.lblSelectionTotal.TabIndex = 12
        Me.lblSelectionTotal.Text = "Selection Total:"
        '
        'txtSelectionTotal
        '
        Me.txtSelectionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectionTotal.Location = New System.Drawing.Point(263, 551)
        Me.txtSelectionTotal.Name = "txtSelectionTotal"
        Me.txtSelectionTotal.Size = New System.Drawing.Size(53, 23)
        Me.txtSelectionTotal.TabIndex = 13
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConfirm.Location = New System.Drawing.Point(152, 515)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(169, 29)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "CONFIRM SHIRT"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(797, 645)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtSelectionTotal)
        Me.Controls.Add(Me.lblSelectionTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTotalExplaination)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblFinTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.grpCustom)
        Me.Controls.Add(Me.grpColors)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHead)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "frmOrder"
        Me.Text = "Crescent Apparel Order Form"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpColors.ResumeLayout(False)
        Me.grpColors.PerformLayout()
        Me.grpCustom.ResumeLayout(False)
        Me.grpCustom.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHead As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpColors As GroupBox
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents radPurple As RadioButton
    Friend WithEvents grpCustom As GroupBox
    Friend WithEvents chkBack As CheckBox
    Friend WithEvents chkFront As CheckBox
    Friend WithEvents chkSleeve As CheckBox
    Friend WithEvents lblNoCost As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblFinTotal As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents btnPlace As Button
    Friend WithEvents lblTotalExplaination As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSelectionTotal As Label
    Friend WithEvents txtSelectionTotal As TextBox
    Friend WithEvents btnConfirm As Button
End Class
