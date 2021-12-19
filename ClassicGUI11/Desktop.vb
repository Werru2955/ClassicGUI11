Public Class Desktop

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        FileBox.BackColor = Color.FromArgb(255, 58, 110, 165)
        Me.Size = My.Computer.Screen.WorkingArea.Size
        Me.SetDesktopLocation(0, 0)
        Taskbar.Show()

        Dim Desktop As String
        Desktop = My.Computer.FileSystem.SpecialDirectories.Desktop + "\"

        For Each i In My.Computer.FileSystem.GetFiles(Desktop)
            i = i.Replace(Desktop, "")

            FileBox.Items.Add(i)

        Next

    End Sub

    Private Sub FileBox_DoubleClick(sender As Object, e As EventArgs) Handles FileBox.DoubleClick
        Dim fbxsl As String
        Dim Desktop As String
        Desktop = My.Computer.FileSystem.SpecialDirectories.Desktop.ToString + "\"
        fbxsl = FileBox.FocusedItem.Text
        Process.Start(Desktop + fbxsl)
    End Sub


End Class
