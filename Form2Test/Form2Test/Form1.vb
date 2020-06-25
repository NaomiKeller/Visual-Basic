Public Class frm1
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewForm_Click(sender As Object, e As EventArgs) Handles btnNewForm.Click
        Dim newForm As New frmDouble
        newForm.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
