Public Class frm123

    Private Sub txtOne_TextChanged(sender As Object, e As EventArgs) Handles txtOne.TextChanged
        txtOne.ForeColor = Color.Red
    End Sub

    Private Sub txtOne_Leave(sender As Object, e As EventArgs) Handles txtOne.Leave
        txtOne.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        txtOne.TextAlign = HorizontalAlignment.Left
        txtTwo.TextAlign = HorizontalAlignment.Left
        txtThree.TextAlign = HorizontalAlignment.Left

    End Sub

    Private Sub txtTwo_TextChanged(sender As Object, e As EventArgs) Handles txtTwo.TextChanged
        txtTwo.ForeColor = Color.Red

    End Sub

    Private Sub txtTwo_Leave(sender As Object, e As EventArgs) Handles txtTwo.Leave
        txtTwo.ForeColor = Color.Black
    End Sub

    Private Sub txtThree_TextChanged(sender As Object, e As EventArgs) Handles txtThree.TextChanged
        txtThree.ForeColor = Color.Red
    End Sub

    Private Sub txtThree_Leave(sender As Object, e As EventArgs) Handles txtThree.Leave
        txtThree.ForeColor = Color.Black
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        txtOne.TextAlign = HorizontalAlignment.Right
        txtTwo.TextAlign = HorizontalAlignment.Right
        txtThree.TextAlign = HorizontalAlignment.Right

    End Sub
End Class
