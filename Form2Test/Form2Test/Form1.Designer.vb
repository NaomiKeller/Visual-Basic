<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnNewForm = New System.Windows.Forms.Button()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.txtReturn = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(20, 43)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(125, 20)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Enter a Number:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(151, 43)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        '
        'btnNewForm
        '
        Me.btnNewForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewForm.Location = New System.Drawing.Point(99, 80)
        Me.btnNewForm.Name = "btnNewForm"
        Me.btnNewForm.Size = New System.Drawing.Size(87, 37)
        Me.btnNewForm.TabIndex = 0
        Me.btnNewForm.Text = "ENTER"
        Me.btnNewForm.UseVisualStyleBackColor = True
        '
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        Me.lblReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturn.Location = New System.Drawing.Point(12, 133)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(133, 20)
        Me.lblReturn.TabIndex = 3
        Me.lblReturn.Text = "Number returned:"
        '
        'txtReturn
        '
        Me.txtReturn.Location = New System.Drawing.Point(151, 133)
        Me.txtReturn.Name = "txtReturn"
        Me.txtReturn.ReadOnly = True
        Me.txtReturn.Size = New System.Drawing.Size(100, 20)
        Me.txtReturn.TabIndex = 4
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(107, 174)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 38)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 238)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtReturn)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.btnNewForm)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "frm1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnNewForm As Button
    Friend WithEvents lblReturn As Label
    Friend WithEvents txtReturn As TextBox
    Friend WithEvents btnQuit As Button
End Class
