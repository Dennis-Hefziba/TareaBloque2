<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tiempoFormulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tiempoFormulario))
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.ImgTemp = New System.Windows.Forms.PictureBox()
        Me.lblTempConvertir = New System.Windows.Forms.Label()
        Me.lblTempEnt = New System.Windows.Forms.TextBox()
        Me.boxUno = New System.Windows.Forms.ComboBox()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTempResultado = New System.Windows.Forms.TextBox()
        Me.boxDos = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tempoImg = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ImgTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempoImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(242, 369)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'ImgTemp
        '
        Me.ImgTemp.Image = CType(resources.GetObject("ImgTemp.Image"), System.Drawing.Image)
        Me.ImgTemp.Location = New System.Drawing.Point(245, 262)
        Me.ImgTemp.Name = "ImgTemp"
        Me.ImgTemp.Size = New System.Drawing.Size(70, 58)
        Me.ImgTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgTemp.TabIndex = 20
        Me.ImgTemp.TabStop = False
        '
        'lblTempConvertir
        '
        Me.lblTempConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempConvertir.Location = New System.Drawing.Point(214, 323)
        Me.lblTempConvertir.Name = "lblTempConvertir"
        Me.lblTempConvertir.Size = New System.Drawing.Size(130, 40)
        Me.lblTempConvertir.TabIndex = 24
        Me.lblTempConvertir.Text = "Convertir"
        Me.lblTempConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTempEnt
        '
        Me.lblTempEnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTempEnt.Location = New System.Drawing.Point(62, 170)
        Me.lblTempEnt.Name = "lblTempEnt"
        Me.lblTempEnt.Size = New System.Drawing.Size(187, 20)
        Me.lblTempEnt.TabIndex = 21
        Me.lblTempEnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boxUno
        '
        Me.boxUno.AllowDrop = True
        Me.boxUno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boxUno.FormattingEnabled = True
        Me.boxUno.Items.AddRange(New Object() {"Segundo", "Hora", "Minuto"})
        Me.boxUno.Location = New System.Drawing.Point(62, 221)
        Me.boxUno.Name = "boxUno"
        Me.boxUno.Size = New System.Drawing.Size(187, 21)
        Me.boxUno.TabIndex = 17
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDe.Location = New System.Drawing.Point(26, 221)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(30, 20)
        Me.lblDe.TabIndex = 16
        Me.lblDe.Text = "De"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(293, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(433, 431)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'lblTempResultado
        '
        Me.lblTempResultado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTempResultado.Enabled = False
        Me.lblTempResultado.Location = New System.Drawing.Point(314, 170)
        Me.lblTempResultado.Name = "lblTempResultado"
        Me.lblTempResultado.Size = New System.Drawing.Size(183, 20)
        Me.lblTempResultado.TabIndex = 22
        '
        'boxDos
        '
        Me.boxDos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boxDos.FormattingEnabled = True
        Me.boxDos.Items.AddRange(New Object() {"Segundo", "Hora", "Minuto"})
        Me.boxDos.Location = New System.Drawing.Point(314, 221)
        Me.boxDos.Name = "boxDos"
        Me.boxDos.Size = New System.Drawing.Size(183, 21)
        Me.boxDos.TabIndex = 19
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(447, -70)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(412, 412)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-151, 323)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(318, 310)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tiempo"
        '
        'tempoImg
        '
        Me.tempoImg.Image = CType(resources.GetObject("tempoImg.Image"), System.Drawing.Image)
        Me.tempoImg.Location = New System.Drawing.Point(245, 53)
        Me.tempoImg.Name = "tempoImg"
        Me.tempoImg.Size = New System.Drawing.Size(71, 70)
        Me.tempoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tempoImg.TabIndex = 26
        Me.tempoImg.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "a"
        '
        'tiempoFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 450)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.ImgTemp)
        Me.Controls.Add(Me.lblTempConvertir)
        Me.Controls.Add(Me.lblTempEnt)
        Me.Controls.Add(Me.boxUno)
        Me.Controls.Add(Me.lblDe)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTempResultado)
        Me.Controls.Add(Me.boxDos)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tempoImg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "tiempoFormulario"
        Me.Text = "tiempoFormulario"
        CType(Me.ImgTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempoImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents ImgTemp As PictureBox
    Friend WithEvents lblTempConvertir As Label
    Friend WithEvents lblTempEnt As TextBox
    Friend WithEvents boxUno As ComboBox
    Friend WithEvents lblDe As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTempResultado As TextBox
    Friend WithEvents boxDos As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tempoImg As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
