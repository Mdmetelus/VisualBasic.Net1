Public Class frmTextBox

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        txtBox.Enabled = False
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        txtBox.Enabled = True

    End Sub

    Private Sub btnEnable_EnabledChanged(sender As Object, e As EventArgs) Handles btnEnable.EnabledChanged

    End Sub
End Class
