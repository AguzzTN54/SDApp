<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlphaItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlphaItem))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.showAbjad = New System.Windows.Forms.Button()
        Me.getAlpha = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(572, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 123)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
        Me.Button1.FlatAppearance.BorderSize = 10
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(287, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 272)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(984, 621)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(889, 535)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 58)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(804, 535)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 58)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'showAbjad
        '
        Me.showAbjad.BackColor = System.Drawing.Color.White
        Me.showAbjad.BackgroundImage = CType(resources.GetObject("showAbjad.BackgroundImage"), System.Drawing.Image)
        Me.showAbjad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.showAbjad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showAbjad.Enabled = False
        Me.showAbjad.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
        Me.showAbjad.FlatAppearance.BorderSize = 0
        Me.showAbjad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showAbjad.Location = New System.Drawing.Point(332, 277)
        Me.showAbjad.Name = "showAbjad"
        Me.showAbjad.Size = New System.Drawing.Size(172, 192)
        Me.showAbjad.TabIndex = 5
        Me.showAbjad.UseVisualStyleBackColor = False
        '
        'getAlpha
        '
        Me.getAlpha.AutoSize = True
        Me.getAlpha.BackColor = System.Drawing.Color.Transparent
        Me.getAlpha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getAlpha.Location = New System.Drawing.Point(491, 261)
        Me.getAlpha.Name = "getAlpha"
        Me.getAlpha.Size = New System.Drawing.Size(27, 25)
        Me.getAlpha.TabIndex = 6
        Me.getAlpha.Text = "A"
        Me.getAlpha.Visible = False
        '
        'AlphaItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 621)
        Me.Controls.Add(Me.getAlpha)
        Me.Controls.Add(Me.showAbjad)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlphaItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abjad"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents showAbjad As System.Windows.Forms.Button
    Friend WithEvents getAlpha As System.Windows.Forms.Label
End Class
