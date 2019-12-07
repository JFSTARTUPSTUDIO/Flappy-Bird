<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.fundo = New System.Windows.Forms.Timer(Me.components)
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.chao2 = New System.Windows.Forms.PictureBox()
        Me.chao1 = New System.Windows.Forms.PictureBox()
        Me.back3 = New System.Windows.Forms.PictureBox()
        Me.back1 = New System.Windows.Forms.PictureBox()
        Me.voar = New System.Windows.Forms.Timer(Me.components)
        Me.back2 = New System.Windows.Forms.PictureBox()
        Me.chao3 = New System.Windows.Forms.PictureBox()
        Me.andar = New System.Windows.Forms.Timer(Me.components)
        Me.pontos = New System.Windows.Forms.Label()
        Me.barreira13 = New System.Windows.Forms.PictureBox()
        Me.barreira23 = New System.Windows.Forms.PictureBox()
        Me.barreira12 = New System.Windows.Forms.PictureBox()
        Me.barreira22 = New System.Windows.Forms.PictureBox()
        Me.barreira21 = New System.Windows.Forms.PictureBox()
        Me.barreira11 = New System.Windows.Forms.PictureBox()
        Me.barreiras = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chao2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chao1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chao3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barreira13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barreira23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barreira12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barreira22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barreira21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barreira11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fundo
        '
        Me.fundo.Enabled = True
        Me.fundo.Interval = 30
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.Image = Global.Flappy_Bird.My.Resources.Resources.bluebird_upflap
        Me.bird.Location = New System.Drawing.Point(218, 183)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(37, 28)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bird.TabIndex = 5
        Me.bird.TabStop = False
        '
        'chao2
        '
        Me.chao2.Image = Global.Flappy_Bird.My.Resources.Resources.base
        Me.chao2.Location = New System.Drawing.Point(237, 411)
        Me.chao2.Name = "chao2"
        Me.chao2.Size = New System.Drawing.Size(255, 117)
        Me.chao2.TabIndex = 3
        Me.chao2.TabStop = False
        '
        'chao1
        '
        Me.chao1.Image = Global.Flappy_Bird.My.Resources.Resources.base
        Me.chao1.Location = New System.Drawing.Point(-2, 411)
        Me.chao1.Name = "chao1"
        Me.chao1.Size = New System.Drawing.Size(240, 117)
        Me.chao1.TabIndex = 2
        Me.chao1.TabStop = False
        '
        'back3
        '
        Me.back3.Image = Global.Flappy_Bird.My.Resources.Resources.background_day
        Me.back3.Location = New System.Drawing.Point(488, -5)
        Me.back3.Name = "back3"
        Me.back3.Size = New System.Drawing.Size(255, 461)
        Me.back3.TabIndex = 4
        Me.back3.TabStop = False
        '
        'back1
        '
        Me.back1.Image = Global.Flappy_Bird.My.Resources.Resources.background_day
        Me.back1.Location = New System.Drawing.Point(0, -5)
        Me.back1.Name = "back1"
        Me.back1.Size = New System.Drawing.Size(238, 461)
        Me.back1.TabIndex = 0
        Me.back1.TabStop = False
        '
        'voar
        '
        Me.voar.Enabled = True
        Me.voar.Interval = 50
        '
        'back2
        '
        Me.back2.Image = Global.Flappy_Bird.My.Resources.Resources.background_day
        Me.back2.Location = New System.Drawing.Point(237, -5)
        Me.back2.Name = "back2"
        Me.back2.Size = New System.Drawing.Size(255, 461)
        Me.back2.TabIndex = 1
        Me.back2.TabStop = False
        '
        'chao3
        '
        Me.chao3.Image = Global.Flappy_Bird.My.Resources.Resources.base
        Me.chao3.Location = New System.Drawing.Point(477, 411)
        Me.chao3.Name = "chao3"
        Me.chao3.Size = New System.Drawing.Size(254, 117)
        Me.chao3.TabIndex = 6
        Me.chao3.TabStop = False
        '
        'andar
        '
        Me.andar.Enabled = True
        Me.andar.Interval = 30
        '
        'pontos
        '
        Me.pontos.AutoSize = True
        Me.pontos.BackColor = System.Drawing.Color.Transparent
        Me.pontos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pontos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pontos.Location = New System.Drawing.Point(-2, -1)
        Me.pontos.Name = "pontos"
        Me.pontos.Size = New System.Drawing.Size(27, 29)
        Me.pontos.TabIndex = 7
        Me.pontos.Text = "0"
        '
        'barreira13
        '
        Me.barreira13.BackColor = System.Drawing.Color.Transparent
        Me.barreira13.Image = Global.Flappy_Bird.My.Resources.Resources.pipe_red
        Me.barreira13.Location = New System.Drawing.Point(894, 230)
        Me.barreira13.Name = "barreira13"
        Me.barreira13.Size = New System.Drawing.Size(52, 307)
        Me.barreira13.TabIndex = 8
        Me.barreira13.TabStop = False
        '
        'barreira23
        '
        Me.barreira23.BackColor = System.Drawing.Color.Transparent
        Me.barreira23.Image = Global.Flappy_Bird.My.Resources.Resources.pipe_red_2
        Me.barreira23.Location = New System.Drawing.Point(894, -175)
        Me.barreira23.Name = "barreira23"
        Me.barreira23.Size = New System.Drawing.Size(52, 336)
        Me.barreira23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barreira23.TabIndex = 9
        Me.barreira23.TabStop = False
        '
        'barreira12
        '
        Me.barreira12.BackColor = System.Drawing.Color.Transparent
        Me.barreira12.Image = Global.Flappy_Bird.My.Resources.Resources.pipe_red
        Me.barreira12.Location = New System.Drawing.Point(688, 228)
        Me.barreira12.Name = "barreira12"
        Me.barreira12.Size = New System.Drawing.Size(52, 307)
        Me.barreira12.TabIndex = 10
        Me.barreira12.TabStop = False
        '
        'barreira22
        '
        Me.barreira22.BackColor = System.Drawing.Color.Transparent
        Me.barreira22.Image = Global.Flappy_Bird.My.Resources.Resources.pipe_red_2
        Me.barreira22.Location = New System.Drawing.Point(688, -177)
        Me.barreira22.Name = "barreira22"
        Me.barreira22.Size = New System.Drawing.Size(52, 336)
        Me.barreira22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barreira22.TabIndex = 11
        Me.barreira22.TabStop = False
        '
        'barreira21
        '
        Me.barreira21.BackColor = System.Drawing.Color.Transparent
        Me.barreira21.BackgroundImage = Global.Flappy_Bird.My.Resources.Resources.pipe_red_2
        Me.barreira21.ErrorImage = Global.Flappy_Bird.My.Resources.Resources.pipe_red_2
        Me.barreira21.Image = Global.Flappy_Bird.My.Resources.Resources.pipe_red_2
        Me.barreira21.InitialImage = Global.Flappy_Bird.My.Resources.Resources.pipe_red_2
        Me.barreira21.Location = New System.Drawing.Point(500, -177)
        Me.barreira21.Name = "barreira21"
        Me.barreira21.Size = New System.Drawing.Size(52, 336)
        Me.barreira21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barreira21.TabIndex = 13
        Me.barreira21.TabStop = False
        '
        'barreira11
        '
        Me.barreira11.BackColor = System.Drawing.Color.Transparent
        Me.barreira11.Image = Global.Flappy_Bird.My.Resources.Resources.pipe_red
        Me.barreira11.Location = New System.Drawing.Point(500, 228)
        Me.barreira11.Name = "barreira11"
        Me.barreira11.Size = New System.Drawing.Size(52, 307)
        Me.barreira11.TabIndex = 12
        Me.barreira11.TabStop = False
        '
        'barreiras
        '
        Me.barreiras.Enabled = True
        Me.barreiras.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Flappy_Bird.My.Resources.Resources.background_day
        Me.ClientSize = New System.Drawing.Size(489, 450)
        Me.Controls.Add(Me.chao1)
        Me.Controls.Add(Me.chao2)
        Me.Controls.Add(Me.chao3)
        Me.Controls.Add(Me.barreira21)
        Me.Controls.Add(Me.barreira11)
        Me.Controls.Add(Me.barreira22)
        Me.Controls.Add(Me.barreira12)
        Me.Controls.Add(Me.barreira23)
        Me.Controls.Add(Me.barreira13)
        Me.Controls.Add(Me.bird)
        Me.Controls.Add(Me.back3)
        Me.Controls.Add(Me.back2)
        Me.Controls.Add(Me.pontos)
        Me.Controls.Add(Me.back1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flappy Bird"
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chao2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chao1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chao3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barreira13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barreira23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barreira12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barreira22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barreira21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barreira11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back1 As PictureBox
    Friend WithEvents chao1 As PictureBox
    Friend WithEvents chao2 As PictureBox
    Friend WithEvents back3 As PictureBox
    Friend WithEvents fundo As Timer
    Friend WithEvents bird As PictureBox
    Friend WithEvents voar As Timer
    Friend WithEvents back2 As PictureBox
    Friend WithEvents chao3 As PictureBox
    Friend WithEvents andar As Timer
    Friend WithEvents pontos As Label
    Friend WithEvents barreira13 As PictureBox
    Friend WithEvents barreira23 As PictureBox
    Friend WithEvents barreira12 As PictureBox
    Friend WithEvents barreira22 As PictureBox
    Friend WithEvents barreira21 As PictureBox
    Friend WithEvents barreira11 As PictureBox
    Friend WithEvents barreiras As Timer
End Class
