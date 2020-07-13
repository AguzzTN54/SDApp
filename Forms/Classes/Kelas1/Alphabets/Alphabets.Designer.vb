<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alphabets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alphabets))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(78, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 335)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(889, 535)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 58)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(804, 535)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 58)
        Me.Button5.TabIndex = 6
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Alphabets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(984, 621)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alphabets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alphabets"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
