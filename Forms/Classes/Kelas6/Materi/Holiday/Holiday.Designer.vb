<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Holiday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Holiday))
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.WebView1 = New Microsoft.Toolkit.Forms.UI.Controls.WebView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.WebView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.Color.Brown
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.ForeColor = System.Drawing.Color.White
        Me.NextBtn.Location = New System.Drawing.Point(549, 522)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(89, 38)
        Me.NextBtn.TabIndex = 22
        Me.NextBtn.Text = "NEXT"
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.Brown
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(330, 522)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(89, 38)
        Me.BackBtn.TabIndex = 21
        Me.BackBtn.Text = "BACK"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'WebView1
        '
        Me.WebView1.Location = New System.Drawing.Point(58, 164)
        Me.WebView1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebView1.Name = "WebView1"
        Me.WebView1.Size = New System.Drawing.Size(868, 350)
        Me.WebView1.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(855, 528)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 61)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(777, 528)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 61)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 621)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.WebView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.Name = "Holiday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holiday"
        CType(Me.WebView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NextBtn As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents WebView1 As Microsoft.Toolkit.Forms.UI.Controls.WebView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
