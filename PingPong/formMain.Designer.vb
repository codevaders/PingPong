<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Me.timerGame = New System.Windows.Forms.Timer(Me.components)
        Me.outputStatus = New System.Windows.Forms.TextBox()
        Me.timerView = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'timerGame
        '
        '
        'outputStatus
        '
        Me.outputStatus.Enabled = False
        Me.outputStatus.Location = New System.Drawing.Point(92, 12)
        Me.outputStatus.Name = "outputStatus"
        Me.outputStatus.ReadOnly = True
        Me.outputStatus.Size = New System.Drawing.Size(100, 20)
        Me.outputStatus.TabIndex = 0
        '
        'timerView
        '
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.outputStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formMain"
        Me.Text = "Ping Pong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timerGame As Timer
    Friend WithEvents outputStatus As TextBox
    Friend WithEvents timerView As Timer
End Class
