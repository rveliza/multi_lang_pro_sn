Public Class res_test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PictureBox1.Image = My.Resources.jet1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text = My.Resources.first_name + " " + My.Resources.last_name
    End Sub
End Class