<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasaFormulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasaFormulario))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.lblMasaConvertir = New System.Windows.Forms.Label()
        Me.lblMasaNumero = New System.Windows.Forms.TextBox()
        Me.boxMasa1 = New System.Windows.Forms.ComboBox()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblMasaResultado = New System.Windows.Forms.TextBox()
        Me.boxMasa2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'imagen
        '
        Me.imagen.Image = CType(resources.GetObject("imagen.Image"), System.Drawing.Image)
        Me.imagen.Location = New System.Drawing.Point(258, 243)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(70, 58)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 20
        Me.imagen.TabStop = False
        '
        'lblMasaConvertir
        '
        Me.lblMasaConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasaConvertir.Location = New System.Drawing.Point(227, 304)
        Me.lblMasaConvertir.Name = "lblMasaConvertir"
        Me.lblMasaConvertir.Size = New System.Drawing.Size(130, 40)
        Me.lblMasaConvertir.TabIndex = 24
        Me.lblMasaConvertir.Text = "Convertir"
        Me.lblMasaConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMasaNumero
        '
        Me.lblMasaNumero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMasaNumero.Location = New System.Drawing.Point(75, 151)
        Me.lblMasaNumero.Name = "lblMasaNumero"
        Me.lblMasaNumero.Size = New System.Drawing.Size(187, 20)
        Me.lblMasaNumero.TabIndex = 21
        Me.lblMasaNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boxMasa1
        '
        Me.boxMasa1.AllowDrop = True
        Me.boxMasa1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boxMasa1.FormattingEnabled = True
        Me.boxMasa1.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Gramo", "Miligramo", "Libra", "Onza"})
        Me.boxMasa1.Location = New System.Drawing.Point(75, 202)
        Me.boxMasa1.Name = "boxMasa1"
        Me.boxMasa1.Size = New System.Drawing.Size(187, 21)
        Me.boxMasa1.TabIndex = 17
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDe.Location = New System.Drawing.Point(-33, 142)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(30, 20)
        Me.lblDe.TabIndex = 16
        Me.lblDe.Text = "De"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(334, 229)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(433, 431)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'lblMasaResultado
        '
        Me.lblMasaResultado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMasaResultado.Enabled = False
        Me.lblMasaResultado.Location = New System.Drawing.Point(327, 151)
        Me.lblMasaResultado.Name = "lblMasaResultado"
        Me.lblMasaResultado.Size = New System.Drawing.Size(183, 20)
        Me.lblMasaResultado.TabIndex = 22
        '
        'boxMasa2
        '
        Me.boxMasa2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boxMasa2.FormattingEnabled = True
        Me.boxMasa2.Items.AddRange(New Object() {"Tonelada", "Kilogramo", "Gramo", "Miligramo", "Libra", "Onza"})
        Me.boxMasa2.Location = New System.Drawing.Point(327, 202)
        Me.boxMasa2.Name = "boxMasa2"
        Me.boxMasa2.Size = New System.Drawing.Size(183, 21)
        Me.boxMasa2.TabIndex = 19
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(536, -102)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(412, 412)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-143, 288)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(318, 310)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Masas"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(258, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "De"
        '
        'MasaFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.lblMasaConvertir)
        Me.Controls.Add(Me.lblMasaNumero)
        Me.Controls.Add(Me.boxMasa1)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblMasaResultado)
        Me.Controls.Add(Me.boxMasa2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "MasaFormulario"
        Me.Text = "MasaFormulario"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents imagen As PictureBox
    Friend WithEvents lblMasaConvertir As Label
    Friend WithEvents lblMasaNumero As TextBox
    Friend WithEvents boxMasa1 As ComboBox
    Friend WithEvents lblDe As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblMasaResultado As TextBox
    Friend WithEvents boxMasa2 As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
