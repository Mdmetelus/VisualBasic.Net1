Public Class frmQuote

    Private Sub txtLife_TextChanged(sender As Object, e As EventArgs) Handles txtLife.TextChanged

    End Sub

    Private Sub txtLife_Click(sender As Object, e As EventArgs) Handles txtLife.Click
        txtQuote.Text = "I Like Life, Its Something To Do."
    End Sub

    Private Sub txtFuture_Click(sender As Object, e As EventArgs) Handles txtFuture.Click
        txtQuote.Text = "The Future isn't What it Used To Be."
    End Sub

    Private Sub txtTruth_Click(sender As Object, e As EventArgs) Handles txtTruth.Click
        txtQuote.Text = "Tell The Truth And Run."
    End Sub

    Private Sub txtLife_Leave(sender As Object, e As EventArgs) Handles txtLife.Leave

    End Sub
End Class
