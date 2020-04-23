<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThePetPoject1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThePetPoject1))
        Me.picPaw1 = New System.Windows.Forms.PictureBox()
        Me.picPaw2 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFavorite = New System.Windows.Forms.Label()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picFish = New System.Windows.Forms.PictureBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lblVote = New System.Windows.Forms.Label()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.picCat2 = New System.Windows.Forms.PictureBox()
        Me.picBird2 = New System.Windows.Forms.PictureBox()
        Me.picDog2 = New System.Windows.Forms.PictureBox()
        Me.picFish2 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPaw1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaw2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFish2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPaw1
        '
        Me.picPaw1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPaw1.Image = CType(resources.GetObject("picPaw1.Image"), System.Drawing.Image)
        Me.picPaw1.Location = New System.Drawing.Point(23, 12)
        Me.picPaw1.Name = "picPaw1"
        Me.picPaw1.Size = New System.Drawing.Size(84, 62)
        Me.picPaw1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPaw1.TabIndex = 1
        Me.picPaw1.TabStop = False
        '
        'picPaw2
        '
        Me.picPaw2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPaw2.Image = CType(resources.GetObject("picPaw2.Image"), System.Drawing.Image)
        Me.picPaw2.Location = New System.Drawing.Point(554, 12)
        Me.picPaw2.Name = "picPaw2"
        Me.picPaw2.Size = New System.Drawing.Size(84, 62)
        Me.picPaw2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPaw2.TabIndex = 2
        Me.picPaw2.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Peru
        Me.lblName.Font = New System.Drawing.Font("Ravie", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(113, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(435, 50)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "The Pet Project"
        '
        'lblFavorite
        '
        Me.lblFavorite.AutoSize = True
        Me.lblFavorite.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavorite.Location = New System.Drawing.Point(219, 105)
        Me.lblFavorite.Name = "lblFavorite"
        Me.lblFavorite.Size = New System.Drawing.Size(197, 26)
        Me.lblFavorite.TabIndex = 5
        Me.lblFavorite.Text = "Who Is Your Favorite?"
        '
        'picDog
        '
        Me.picDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(139, 152)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(145, 126)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDog.TabIndex = 6
        Me.picDog.TabStop = False
        '
        'picCat
        '
        Me.picCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCat.Image = CType(resources.GetObject("picCat.Image"), System.Drawing.Image)
        Me.picCat.Location = New System.Drawing.Point(352, 152)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(145, 126)
        Me.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCat.TabIndex = 7
        Me.picCat.TabStop = False
        '
        'picFish
        '
        Me.picFish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFish.Image = CType(resources.GetObject("picFish.Image"), System.Drawing.Image)
        Me.picFish.Location = New System.Drawing.Point(139, 302)
        Me.picFish.Name = "picFish"
        Me.picFish.Size = New System.Drawing.Size(145, 126)
        Me.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFish.TabIndex = 8
        Me.picFish.TabStop = False
        '
        'picBird
        '
        Me.picBird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBird.Image = CType(resources.GetObject("picBird.Image"), System.Drawing.Image)
        Me.picBird.Location = New System.Drawing.Point(352, 302)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(145, 126)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 9
        Me.picBird.TabStop = False
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Red
        Me.btnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.Location = New System.Drawing.Point(259, 494)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(118, 32)
        Me.btnClick.TabIndex = 10
        Me.btnClick.Text = "Click Me!"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'lblVote
        '
        Me.lblVote.AutoSize = True
        Me.lblVote.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVote.Location = New System.Drawing.Point(60, 446)
        Me.lblVote.Name = "lblVote"
        Me.lblVote.Size = New System.Drawing.Size(542, 34)
        Me.lblVote.TabIndex = 11
        Me.lblVote.Text = "To Cast Your Vote Please Click The Button Below"
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.Location = New System.Drawing.Point(259, 549)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(118, 108)
        Me.lstOut.TabIndex = 12
        '
        'picCat2
        '
        Me.picCat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCat2.Image = CType(resources.GetObject("picCat2.Image"), System.Drawing.Image)
        Me.picCat2.Location = New System.Drawing.Point(397, 549)
        Me.picCat2.Name = "picCat2"
        Me.picCat2.Size = New System.Drawing.Size(76, 62)
        Me.picCat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCat2.TabIndex = 13
        Me.picCat2.TabStop = False
        Me.picCat2.Visible = False
        '
        'picBird2
        '
        Me.picBird2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBird2.Image = CType(resources.GetObject("picBird2.Image"), System.Drawing.Image)
        Me.picBird2.Location = New System.Drawing.Point(397, 617)
        Me.picBird2.Name = "picBird2"
        Me.picBird2.Size = New System.Drawing.Size(76, 62)
        Me.picBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird2.TabIndex = 14
        Me.picBird2.TabStop = False
        Me.picBird2.Visible = False
        '
        'picDog2
        '
        Me.picDog2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDog2.Image = CType(resources.GetObject("picDog2.Image"), System.Drawing.Image)
        Me.picDog2.Location = New System.Drawing.Point(163, 549)
        Me.picDog2.Name = "picDog2"
        Me.picDog2.Size = New System.Drawing.Size(76, 62)
        Me.picDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDog2.TabIndex = 15
        Me.picDog2.TabStop = False
        Me.picDog2.Visible = False
        '
        'picFish2
        '
        Me.picFish2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFish2.Image = CType(resources.GetObject("picFish2.Image"), System.Drawing.Image)
        Me.picFish2.Location = New System.Drawing.Point(163, 617)
        Me.picFish2.Name = "picFish2"
        Me.picFish2.Size = New System.Drawing.Size(76, 62)
        Me.picFish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFish2.TabIndex = 16
        Me.picFish2.TabStop = False
        Me.picFish2.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(209, 702)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(341, 702)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ThePetPoject1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(666, 749)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.picFish2)
        Me.Controls.Add(Me.picDog2)
        Me.Controls.Add(Me.picBird2)
        Me.Controls.Add(Me.picCat2)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblVote)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.picFish)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.lblFavorite)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picPaw2)
        Me.Controls.Add(Me.picPaw1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ThePetPoject1"
        Me.Text = "The Pet Project"
        CType(Me.picPaw1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaw2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFish2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPaw1 As PictureBox
    Friend WithEvents picPaw2 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblFavorite As Label
    Friend WithEvents picDog As PictureBox
    Friend WithEvents picCat As PictureBox
    Friend WithEvents picFish As PictureBox
    Friend WithEvents picBird As PictureBox
    Friend WithEvents btnClick As Button
    Friend WithEvents lblVote As Label
    Friend WithEvents lstOut As ListBox
    Friend WithEvents picCat2 As PictureBox
    Friend WithEvents picBird2 As PictureBox
    Friend WithEvents picDog2 As PictureBox
    Friend WithEvents picFish2 As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
