Public Class Taskbar


    Private Sub Taskbar_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.SetDesktopLocation(0, My.Computer.Screen.WorkingArea.Height - 28)
        Me.Size = New Size(My.Computer.Screen.WorkingArea.Width, 28)
        Me.BackColor = Color.FromArgb(255, 212, 208, 200)
        Me.TopMost.Equals(True)
        Timer1.Start()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Time.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost.Equals(True)
        Time.Text = My.Computer.Clock.LocalTime.ToShortTimeString.ToString

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Start.Show()
    End Sub
End Class