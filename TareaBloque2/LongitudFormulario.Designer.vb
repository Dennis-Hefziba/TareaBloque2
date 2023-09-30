<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LongitudFormulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LongitudFormulario))
        Me.lblDe = New System.Windows.Forms.Label()
        Me.box1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.box2 = New System.Windows.Forms.ComboBox()
        Me.ImgLongitudes = New System.Windows.Forms.PictureBox()
        Me.lblNumero = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblConvertir = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ImgLongitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDe.Location = New System.Drawing.Point(17, 209)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(30, 20)
        Me.lblDe.TabIndex = 1
        Me.lblDe.Text = "De"
        '
        'box1
        '
        Me.box1.AllowDrop = True
        Me.box1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box1.FormattingEnabled = True
        Me.box1.Items.AddRange(New Object() {"Kilometro", "Metro", "Centimetro", "Milimetro", "Pie", "Pulgada"})
        Me.box1.Location = New System.Drawing.Point(53, 209)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(187, 21)
        Me.box1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "a"
        '
        'box2
        '
        Me.box2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box2.FormattingEnabled = True
        Me.box2.Items.AddRange(New Object() {"Kilometro", "Metro", "Centimetro", "Milimetro", "Pie", "Pulgada"})
        Me.box2.Location = New System.Drawing.Point(305, 209)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(183, 21)
        Me.box2.TabIndex = 4
        '
        'ImgLongitudes
        '
        Me.ImgLongitudes.Image = CType(resources.GetObject("ImgLongitudes.Image"), System.Drawing.Image)
        Me.ImgLongitudes.Location = New System.Drawing.Point(236, 250)
        Me.ImgLongitudes.Name = "ImgLongitudes"
        Me.ImgLongitudes.Size = New System.Drawing.Size(70, 58)
        Me.ImgLongitudes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLongitudes.TabIndex = 5
        Me.ImgLongitudes.TabStop = False
        '
        'lblNumero
        '
        Me.lblNumero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNumero.Location = New System.Drawing.Point(53, 158)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(187, 20)
        Me.lblNumero.TabIndex = 6
        Me.lblNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultado
        '
        Me.lblResultado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResultado.Enabled = False
        Me.lblResultado.Location = New System.Drawing.Point(305, 158)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(183, 20)
        Me.lblResultado.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "="
        '
        'lblConvertir
        '
        Me.lblConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertir.Location = New System.Drawing.Point(205, 311)
        Me.lblConvertir.Name = "lblConvertir"
        Me.lblConvertir.Size = New System.Drawing.Size(130, 40)
        Me.lblConvertir.TabIndex = 9
        Me.lblConvertir.Text = "Convertir"
        Me.lblConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(284, 236)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(433, 431)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(236, 41)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Longitudes"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-160, 311)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(318, 310)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(438, -82)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(412, 412)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(233, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LongitudFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ImgLongitudes)
        Me.Controls.Add(Me.lblConvertir)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.box1)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "LongitudFormulario"
        Me.Text = "LongitudFormulario"
        CType(Me.ImgLongitudes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDe As Label
    Friend WithEvents box1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents box2 As ComboBox
    Friend WithEvents ImgLongitudes As PictureBox
    Friend WithEvents lblNumero As TextBox
    Friend WithEvents lblResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblConvertir As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button
End Class
