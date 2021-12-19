<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taskbar
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
        Me.components = New System.ComponentModel.Container()
        Me.StartButton = New System.Windows.Forms.PictureBox()
        Me.Time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackgroundImage = Global.ClassicGUI11.My.Resources.Resources.App002
        Me.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StartButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StartButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.StartButton.Location = New System.Drawing.Point(0, 0)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(28, 28)
        Me.StartButton.TabIndex = 0
        Me.StartButton.TabStop = False
        '
        'Time
        '
        Me.Time.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Time.AutoSize = True
        Me.Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Time.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(579, 6)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(51, 15)
        Me.Time.TabIndex = 1
        Me.Time.Text = "%time%"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Taskbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 28)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.StartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Taskbar"
        Me.Text = "s"
        Me.TopMost = True
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As PictureBox
    Friend WithEvents Time As Label
    Friend WithEvents Timer1 As Timer
End Class
