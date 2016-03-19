<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_letra = New System.Windows.Forms.Button()
        Me.btn_reinicio = New System.Windows.Forms.Button()
        Me.txt_letra = New System.Windows.Forms.TextBox()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.lb_letras = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.lb_vidas = New System.Windows.Forms.Label()
        Me.Ahorcado4 = New System.Windows.Forms.PictureBox()
        Me.Ahorcado3 = New System.Windows.Forms.PictureBox()
        Me.Ahorcado2 = New System.Windows.Forms.PictureBox()
        Me.Ahorcado1 = New System.Windows.Forms.PictureBox()
        Me.List_error = New System.Windows.Forms.ListBox()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ahorcado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ahorcado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ahorcado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ahorcado1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_inicio
        '
        Me.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicio.Location = New System.Drawing.Point(12, 12)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(75, 23)
        Me.btn_inicio.TabIndex = 0
        Me.btn_inicio.Text = "Iniciar"
        Me.btn_inicio.UseVisualStyleBackColor = True
        '
        'btn_letra
        '
        Me.btn_letra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_letra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_letra.Enabled = False
        Me.btn_letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_letra.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_letra.Location = New System.Drawing.Point(12, 283)
        Me.btn_letra.Name = "btn_letra"
        Me.btn_letra.Size = New System.Drawing.Size(75, 39)
        Me.btn_letra.TabIndex = 1
        Me.btn_letra.Text = "Agregar"
        Me.btn_letra.UseVisualStyleBackColor = True
        '
        'btn_reinicio
        '
        Me.btn_reinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_reinicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reinicio.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reinicio.Location = New System.Drawing.Point(93, 12)
        Me.btn_reinicio.Name = "btn_reinicio"
        Me.btn_reinicio.Size = New System.Drawing.Size(75, 23)
        Me.btn_reinicio.TabIndex = 2
        Me.btn_reinicio.Text = "Reinicio"
        Me.btn_reinicio.UseVisualStyleBackColor = True
        Me.btn_reinicio.Visible = False
        '
        'txt_letra
        '
        Me.txt_letra.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_letra.Location = New System.Drawing.Point(106, 283)
        Me.txt_letra.MaxLength = 1
        Me.txt_letra.Multiline = True
        Me.txt_letra.Name = "txt_letra"
        Me.txt_letra.Size = New System.Drawing.Size(35, 39)
        Me.txt_letra.TabIndex = 3
        Me.txt_letra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PB
        '
        Me.PB.InitialImage = Nothing
        Me.PB.Location = New System.Drawing.Point(171, 12)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(192, 259)
        Me.PB.TabIndex = 4
        Me.PB.TabStop = False
        '
        'lb_letras
        '
        Me.lb_letras.AutoSize = True
        Me.lb_letras.BackColor = System.Drawing.Color.Transparent
        Me.lb_letras.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_letras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_letras.Location = New System.Drawing.Point(167, 300)
        Me.lb_letras.Name = "lb_letras"
        Me.lb_letras.Size = New System.Drawing.Size(196, 23)
        Me.lb_letras.TabIndex = 5
        Me.lb_letras.Text = "_ _ _ _ _ _ _ _ _ _ _ _"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.BackColor = System.Drawing.Color.Transparent
        Me.lb.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb.Location = New System.Drawing.Point(9, 355)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(170, 16)
        Me.lb.TabIndex = 6
        Me.lb.Text = "Letras Equivocadas:"
        '
        'lb_vidas
        '
        Me.lb_vidas.AutoSize = True
        Me.lb_vidas.BackColor = System.Drawing.Color.Transparent
        Me.lb_vidas.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_vidas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_vidas.Location = New System.Drawing.Point(281, 274)
        Me.lb_vidas.Name = "lb_vidas"
        Me.lb_vidas.Size = New System.Drawing.Size(82, 20)
        Me.lb_vidas.TabIndex = 8
        Me.lb_vidas.Text = "Vidas: 0"
        '
        'Ahorcado4
        '
        Me.Ahorcado4.Image = CType(resources.GetObject("Ahorcado4.Image"), System.Drawing.Image)
        Me.Ahorcado4.Location = New System.Drawing.Point(171, 12)
        Me.Ahorcado4.Name = "Ahorcado4"
        Me.Ahorcado4.Size = New System.Drawing.Size(192, 259)
        Me.Ahorcado4.TabIndex = 9
        Me.Ahorcado4.TabStop = False
        Me.Ahorcado4.Visible = False
        '
        'Ahorcado3
        '
        Me.Ahorcado3.Image = CType(resources.GetObject("Ahorcado3.Image"), System.Drawing.Image)
        Me.Ahorcado3.Location = New System.Drawing.Point(171, 12)
        Me.Ahorcado3.Name = "Ahorcado3"
        Me.Ahorcado3.Size = New System.Drawing.Size(192, 259)
        Me.Ahorcado3.TabIndex = 10
        Me.Ahorcado3.TabStop = False
        Me.Ahorcado3.Visible = False
        '
        'Ahorcado2
        '
        Me.Ahorcado2.Image = CType(resources.GetObject("Ahorcado2.Image"), System.Drawing.Image)
        Me.Ahorcado2.Location = New System.Drawing.Point(171, 12)
        Me.Ahorcado2.Name = "Ahorcado2"
        Me.Ahorcado2.Size = New System.Drawing.Size(192, 259)
        Me.Ahorcado2.TabIndex = 11
        Me.Ahorcado2.TabStop = False
        Me.Ahorcado2.Visible = False
        '
        'Ahorcado1
        '
        Me.Ahorcado1.Image = CType(resources.GetObject("Ahorcado1.Image"), System.Drawing.Image)
        Me.Ahorcado1.Location = New System.Drawing.Point(171, 12)
        Me.Ahorcado1.Name = "Ahorcado1"
        Me.Ahorcado1.Size = New System.Drawing.Size(192, 259)
        Me.Ahorcado1.TabIndex = 12
        Me.Ahorcado1.TabStop = False
        Me.Ahorcado1.Visible = False
        '
        'List_error
        '
        Me.List_error.BackColor = System.Drawing.Color.White
        Me.List_error.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_error.ForeColor = System.Drawing.Color.Black
        Me.List_error.FormattingEnabled = True
        Me.List_error.HorizontalScrollbar = True
        Me.List_error.Location = New System.Drawing.Point(185, 337)
        Me.List_error.Name = "List_error"
        Me.List_error.Size = New System.Drawing.Size(18, 43)
        Me.List_error.TabIndex = 13
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(385, 380)
        Me.Controls.Add(Me.List_error)
        Me.Controls.Add(Me.Ahorcado1)
        Me.Controls.Add(Me.Ahorcado2)
        Me.Controls.Add(Me.Ahorcado3)
        Me.Controls.Add(Me.Ahorcado4)
        Me.Controls.Add(Me.lb_vidas)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.lb_letras)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.txt_letra)
        Me.Controls.Add(Me.btn_reinicio)
        Me.Controls.Add(Me.btn_letra)
        Me.Controls.Add(Me.btn_inicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Juego"
        Me.Text = "Ahorcado"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ahorcado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ahorcado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ahorcado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ahorcado1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_inicio As System.Windows.Forms.Button
    Friend WithEvents btn_letra As System.Windows.Forms.Button
    Friend WithEvents btn_reinicio As System.Windows.Forms.Button
    Friend WithEvents txt_letra As System.Windows.Forms.TextBox
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents lb_letras As System.Windows.Forms.Label
    Friend WithEvents lb As System.Windows.Forms.Label
    Friend WithEvents lb_vidas As System.Windows.Forms.Label
    Friend WithEvents Ahorcado4 As System.Windows.Forms.PictureBox
    Friend WithEvents Ahorcado3 As System.Windows.Forms.PictureBox
    Friend WithEvents Ahorcado2 As System.Windows.Forms.PictureBox
    Friend WithEvents Ahorcado1 As System.Windows.Forms.PictureBox
    Friend WithEvents List_error As System.Windows.Forms.ListBox
End Class
