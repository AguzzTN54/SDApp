﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MateriKelas3
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MateriKelas3))
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.WebView1 = New Microsoft.Toolkit.Forms.UI.Controls.WebView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.WebView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Transparent
		Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button4.Location = New System.Drawing.Point(809, 514)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(67, 66)
		Me.Button4.TabIndex = 31
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.Transparent
		Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
		Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button5.Location = New System.Drawing.Point(736, 514)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(67, 66)
		Me.Button5.TabIndex = 30
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Tomato
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(403, 503)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 26)
		Me.Button2.TabIndex = 29
		Me.Button2.Text = "Back"
		Me.Button2.UseVisualStyleBackColor = False
		Me.Button2.Visible = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.Tomato
		Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.White
		Me.Button3.Location = New System.Drawing.Point(484, 503)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 26)
		Me.Button3.TabIndex = 28
		Me.Button3.Text = "Next"
		Me.Button3.UseVisualStyleBackColor = False
		Me.Button3.Visible = False
		'
		'WebView1
		'
		Me.WebView1.Location = New System.Drawing.Point(71, 116)
		Me.WebView1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebView1.Name = "WebView1"
		Me.WebView1.Size = New System.Drawing.Size(843, 381)
		Me.WebView1.TabIndex = 27
		'
		'Button1
		'
		Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button1.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(71, 40)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(361, 70)
		Me.Button1.TabIndex = 26
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(71, 116)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(843, 421)
		Me.PictureBox1.TabIndex = 25
		Me.PictureBox1.TabStop = False
		'
		'MateriKelas3
		'
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(984, 621)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.WebView1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox1)
		Me.DoubleBuffered = True
		Me.Name = "MateriKelas3"
		CType(Me.WebView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents WebView1 As Microsoft.Toolkit.Forms.UI.Controls.WebView
	Friend WithEvents Button1 As Button
	Friend WithEvents PictureBox1 As PictureBox
End Class
