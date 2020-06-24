<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNoRight = New System.Windows.Forms.Button()
        Me.btnNoLeft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The computer has detected that you are awesome. Is it possible that you are aweso" &
    "me?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(12, 56)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 44)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "&Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNoRight
        '
        Me.btnNoRight.Location = New System.Drawing.Point(302, 56)
        Me.btnNoRight.Name = "btnNoRight"
        Me.btnNoRight.Size = New System.Drawing.Size(75, 44)
        Me.btnNoRight.TabIndex = 4
        Me.btnNoRight.Text = "&No"
        Me.btnNoRight.UseVisualStyleBackColor = True
        '
        'btnNoLeft
        '
        Me.btnNoLeft.Location = New System.Drawing.Point(159, 56)
        Me.btnNoLeft.Name = "btnNoLeft"
        Me.btnNoLeft.Size = New System.Drawing.Size(75, 44)
        Me.btnNoLeft.TabIndex = 5
        Me.btnNoLeft.Text = "&No"
        Me.btnNoLeft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 112)
        Me.Controls.Add(Me.btnNoLeft)
        Me.Controls.Add(Me.btnNoRight)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Awesomness from ICE 1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNoRight As Button
    Friend WithEvents btnNoLeft As Button
End Class
