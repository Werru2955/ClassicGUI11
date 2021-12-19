Public Class Start
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopStyle.BackColor = Color.FromArgb(255, 11, 37, 107)
        Me.BackColor = Color.FromArgb(255, 212, 208, 200)
        Label6.BackColor = Color.FromArgb(255, 212, 208, 200)
        Label6.Text = Environment.UserName
        Me.TopMost.Equals(True)
        Me.Location = New Point(0, My.Computer.Screen.WorkingArea.Height - 506)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Process.Start("iexplore")
    End Sub

    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        Panel1.BackColor = Color.FromArgb(255, 212, 208, 200)
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click
        Process.Start("C:\Users\" + Environment.UserName + "\Documents")
    End Sub
End Class