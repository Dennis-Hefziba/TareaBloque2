<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class almacenamientoFormulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(almacenamientoFormulario))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.imgLoad = New System.Windows.Forms.PictureBox()
        Me.btnConvertir = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.opciones = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.opciones2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgAl = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.imgLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "De"
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(280, 375)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(75, 23)
        Me.nuevo.TabIndex = 45
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'imgLoad
        '
        Me.imgLoad.Image = CType(resources.GetObject("imgLoad.Image"), System.Drawing.Image)
        Me.imgLoad.Location = New System.Drawing.Point(280, 271)
        Me.imgLoad.Name = "imgLoad"
        Me.imgLoad.Size = New System.Drawing.Size(70, 58)
        Me.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLoad.TabIndex = 35
        Me.imgLoad.TabStop = False
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(249, 332)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(130, 40)
        Me.btnConvertir.TabIndex = 39
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEntrada
        '
        Me.txtEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtEntrada.Location = New System.Drawing.Point(97, 179)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(187, 20)
        Me.txtEntrada.TabIndex = 36
        Me.txtEntrada.Text = " "
        Me.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'opciones
        '
        Me.opciones.AllowDrop = True
        Me.opciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.opciones.FormattingEnabled = True
        Me.opciones.Items.AddRange(New Object() {"Megabyte", "Gigabyte", "Terabyte"})
        Me.opciones.Location = New System.Drawing.Point(97, 230)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(187, 21)
        Me.opciones.TabIndex = 32
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(361, 257)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(433, 431)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'txtResultado
        '
        Me.txtResultado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(349, 179)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(183, 20)
        Me.txtResultado.TabIndex = 37
        '
        'opciones2
        '
        Me.opciones2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.opciones2.FormattingEnabled = True
        Me.opciones2.Items.AddRange(New Object() {"Megabyte", "Gigabyte", "Terabyte"})
        Me.opciones2.Location = New System.Drawing.Point(349, 230)
        Me.opciones2.Name = "opciones2"
        Me.opciones2.Size = New System.Drawing.Size(183, 21)
        Me.opciones2.TabIndex = 34
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(558, -74)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(412, 412)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 44
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-192, 271)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(318, 310)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 43
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Almacenamiento"
        '
        'imgAl
        '
        Me.imgAl.Image = CType(resources.GetObject("imgAl.Image"), System.Drawing.Image)
        Me.imgAl.Location = New System.Drawing.Point(280, 62)
        Me.imgAl.Name = "imgAl"
        Me.imgAl.Size = New System.Drawing.Size(71, 70)
        Me.imgAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAl.TabIndex = 41
        Me.imgAl.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "a"
        '
        'almacenamientoFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 428)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.imgLoad)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.opciones2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgAl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "almacenamientoFormulario"
        Me.Text = "almacenamientoFormulario"
        CType(Me.imgLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents nuevo As Button
    Friend WithEvents imgLoad As PictureBox
    Friend WithEvents btnConvertir As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents opciones As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents opciones2 As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents imgAl As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
