Public Class Admin
    Private Sub MDBtn_Click(sender As Object, e As EventArgs) Handles MDBtn.Click
        Medical.Show()
    End Sub

    Private Sub HAbtn_Click(sender As Object, e As EventArgs) Handles HAbtn.Click
        AccountHandler.Show()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class