Public Class frmDouble
    Private Sub frmDouble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGet.Text = frm1.txtNum.Text
    End Sub

    Private Sub btnDbl_Click(sender As Object, e As EventArgs) Handles btnDbl.Click
        Dim dblDoubled = Convert.ToDouble(txtGet.Text) * 2
        txtDbl.Text = Convert.ToString(dblDoubled)
        frm1.txtReturn.Text = txtDbl.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class