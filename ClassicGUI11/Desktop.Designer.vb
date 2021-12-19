<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Wallpaper = New System.Windows.Forms.PictureBox()
        Me.FileBox = New System.Windows.Forms.ListView()
        CType(Me.Wallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wallpaper
        '
        Me.Wallpaper.BackColor = System.Drawing.Color.Transparent
        Me.Wallpaper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wallpaper.Location = New System.Drawing.Point(0, 0)
        Me.Wallpaper.Name = "Wallpaper"
        Me.Wallpaper.Size = New System.Drawing.Size(800, 450)
        Me.Wallpaper.TabIndex = 0
        Me.Wallpaper.TabStop = False
        '
        'FileBox
        '
        Me.FileBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileBox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileBox.ForeColor = System.Drawing.Color.White
        Me.FileBox.HideSelection = False
        Me.FileBox.Location = New System.Drawing.Point(0, 0)
        Me.FileBox.Name = "FileBox"
        Me.FileBox.Size = New System.Drawing.Size(800, 450)
        Me.FileBox.TabIndex = 1
        Me.FileBox.UseCompatibleStateImageBehavior = False
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.FileBox)
        Me.Controls.Add(Me.Wallpaper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.Text = "Form1"
        CType(Me.Wallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Wallpaper As PictureBox
    Friend WithEvents FileBox As ListView
End Class
