<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDouble
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
        Me.txtGet = New System.Windows.Forms.TextBox()
        Me.btnDbl = New System.Windows.Forms.Button()
        Me.txtDbl = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGet
        '
        Me.txtGet.Location = New System.Drawing.Point(15, 15)
        Me.txtGet.Name = "txtGet"
        Me.txtGet.ReadOnly = True
        Me.txtGet.Size = New System.Drawing.Size(126, 20)
        Me.txtGet.TabIndex = 0
        '
        'btnDbl
        '
        Me.btnDbl.Location = New System.Drawing.Point(26, 41)
        Me.btnDbl.Name = "btnDbl"
        Me.btnDbl.Size = New System.Drawing.Size(101, 36)
        Me.btnDbl.TabIndex = 1
        Me.btnDbl.Text = "DOUBLE"
        Me.btnDbl.UseVisualStyleBackColor = True
        '
        'txtDbl
        '
        Me.txtDbl.Location = New System.Drawing.Point(27, 83)
        Me.txtDbl.Name = "txtDbl"
        Me.txtDbl.ReadOnly = True
        Me.txtDbl.Size = New System.Drawing.Size(100, 20)
        Me.txtDbl.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(27, 149)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 32)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmDouble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(161, 188)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtDbl)
        Me.Controls.Add(Me.btnDbl)
        Me.Controls.Add(Me.txtGet)
        Me.Name = "frmDouble"
        Me.Text = "Double"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGet As TextBox
    Friend WithEvents btnDbl As Button
    Friend WithEvents txtDbl As TextBox
    Friend WithEvents btnClose As Button
End Class
