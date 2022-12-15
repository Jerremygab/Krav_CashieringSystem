Public Class Form3
    'Hello
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ui2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ui1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class