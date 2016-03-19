<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargar_Palabras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargar_Palabras))
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lb_contador = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Lista_palabras = New System.Windows.Forms.ListBox()
        Me.Txt_palabras = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.Image = CType(resources.GetObject("btn_borrar.Image"), System.Drawing.Image)
        Me.btn_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_borrar.Location = New System.Drawing.Point(220, 189)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(118, 30)
        Me.btn_borrar.TabIndex = 2
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.Location = New System.Drawing.Point(7, 308)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(121, 52)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.Location = New System.Drawing.Point(220, 142)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(118, 30)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'lb_contador
        '
        Me.lb_contador.AutoSize = True
        Me.lb_contador.BackColor = System.Drawing.Color.Transparent
        Me.lb_contador.Font = New System.Drawing.Font("Perpetua Titling MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_contador.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_contador.Location = New System.Drawing.Point(225, 324)
        Me.lb_contador.Name = "lb_contador"
        Me.lb_contador.Size = New System.Drawing.Size(113, 18)
        Me.lb_contador.TabIndex = 3
        Me.lb_contador.Text = "Palabras: 0"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label.Location = New System.Drawing.Point(4, 8)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(488, 13)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Tiene que agregar 15 palabras que no sean menores a 6 ni mayor a 12 letras"
        '
        'Lista_palabras
        '
        Me.Lista_palabras.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista_palabras.FormattingEnabled = True
        Me.Lista_palabras.Location = New System.Drawing.Point(346, 24)
        Me.Lista_palabras.Name = "Lista_palabras"
        Me.Lista_palabras.Size = New System.Drawing.Size(146, 329)
        Me.Lista_palabras.TabIndex = 5
        '
        'Txt_palabras
        '
        Me.Txt_palabras.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_palabras.Location = New System.Drawing.Point(194, 94)
        Me.Txt_palabras.MaxLength = 12
        Me.Txt_palabras.Name = "Txt_palabras"
        Me.Txt_palabras.Size = New System.Drawing.Size(144, 21)
        Me.Txt_palabras.TabIndex = 1
        Me.Txt_palabras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cargar_Palabras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(504, 365)
        Me.Controls.Add(Me.Txt_palabras)
        Me.Controls.Add(Me.Lista_palabras)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.lb_contador)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_borrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Cargar_Palabras"
        Me.Text = "Cargar Palabras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lb_contador As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Lista_palabras As System.Windows.Forms.ListBox
    Friend WithEvents Txt_palabras As System.Windows.Forms.TextBox

End Class
