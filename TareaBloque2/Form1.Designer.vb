<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LongiPic = New System.Windows.Forms.PictureBox()
        Me.labelSeleccione = New System.Windows.Forms.Label()
        Me.masaPic = New System.Windows.Forms.PictureBox()
        Me.almacePic = New System.Windows.Forms.PictureBox()
        Me.tiempoPic = New System.Windows.Forms.PictureBox()
        Me.lblLongitud = New System.Windows.Forms.Label()
        Me.lblMasa = New System.Windows.Forms.Label()
        Me.lblAlmacenamiento = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        CType(Me.LongiPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.masaPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.almacePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tiempoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LongiPic
        '
        Me.LongiPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LongiPic.Image = CType(resources.GetObject("LongiPic.Image"), System.Drawing.Image)
        Me.LongiPic.Location = New System.Drawing.Point(85, 104)
        Me.LongiPic.Name = "LongiPic"
        Me.LongiPic.Size = New System.Drawing.Size(107, 103)
        Me.LongiPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LongiPic.TabIndex = 0
        Me.LongiPic.TabStop = False
        '
        'labelSeleccione
        '
        Me.labelSeleccione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelSeleccione.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSeleccione.Location = New System.Drawing.Point(79, 30)
        Me.labelSeleccione.Name = "labelSeleccione"
        Me.labelSeleccione.Size = New System.Drawing.Size(150, 30)
        Me.labelSeleccione.TabIndex = 1
        Me.labelSeleccione.Text = "Seleccione"
        '
        'masaPic
        '
        Me.masaPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.masaPic.Image = CType(resources.GetObject("masaPic.Image"), System.Drawing.Image)
        Me.masaPic.Location = New System.Drawing.Point(228, 104)
        Me.masaPic.Name = "masaPic"
        Me.masaPic.Size = New System.Drawing.Size(107, 103)
        Me.masaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.masaPic.TabIndex = 2
        Me.masaPic.TabStop = False
        '
        'almacePic
        '
        Me.almacePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.almacePic.Image = CType(resources.GetObject("almacePic.Image"), System.Drawing.Image)
        Me.almacePic.Location = New System.Drawing.Point(85, 285)
        Me.almacePic.Name = "almacePic"
        Me.almacePic.Size = New System.Drawing.Size(107, 103)
        Me.almacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.almacePic.TabIndex = 3
        Me.almacePic.TabStop = False
        '
        'tiempoPic
        '
        Me.tiempoPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tiempoPic.Image = CType(resources.GetObject("tiempoPic.Image"), System.Drawing.Image)
        Me.tiempoPic.Location = New System.Drawing.Point(228, 285)
        Me.tiempoPic.Name = "tiempoPic"
        Me.tiempoPic.Size = New System.Drawing.Size(107, 103)
        Me.tiempoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tiempoPic.TabIndex = 4
        Me.tiempoPic.TabStop = False
        '
        'lblLongitud
        '
        Me.lblLongitud.AutoSize = True
        Me.lblLongitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitud.Location = New System.Drawing.Point(100, 219)
        Me.lblLongitud.Name = "lblLongitud"
        Me.lblLongitud.Size = New System.Drawing.Size(71, 20)
        Me.lblLongitud.TabIndex = 5
        Me.lblLongitud.Text = "Longitud"
        '
        'lblMasa
        '
        Me.lblMasa.AutoSize = True
        Me.lblMasa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasa.Location = New System.Drawing.Point(253, 219)
        Me.lblMasa.Name = "lblMasa"
        Me.lblMasa.Size = New System.Drawing.Size(48, 20)
        Me.lblMasa.TabIndex = 6
        Me.lblMasa.Text = "Masa"
        '
        'lblAlmacenamiento
        '
        Me.lblAlmacenamiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAlmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacenamiento.Location = New System.Drawing.Point(73, 401)
        Me.lblAlmacenamiento.Name = "lblAlmacenamiento"
        Me.lblAlmacenamiento.Size = New System.Drawing.Size(129, 20)
        Me.lblAlmacenamiento.TabIndex = 7
        Me.lblAlmacenamiento.Text = "Almacenamiento"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(253, 401)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(61, 20)
        Me.lblTiempo.TabIndex = 8
        Me.lblTiempo.Text = "Tiempo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 450)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblAlmacenamiento)
        Me.Controls.Add(Me.lblMasa)
        Me.Controls.Add(Me.lblLongitud)
        Me.Controls.Add(Me.tiempoPic)
        Me.Controls.Add(Me.almacePic)
        Me.Controls.Add(Me.masaPic)
        Me.Controls.Add(Me.labelSeleccione)
        Me.Controls.Add(Me.LongiPic)
        Me.Name = "Form1"
        Me.Text = "          "
        CType(Me.LongiPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.masaPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.almacePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tiempoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LongiPic As PictureBox
    Friend WithEvents labelSeleccione As Label
    Friend WithEvents masaPic As PictureBox
    Friend WithEvents almacePic As PictureBox
    Friend WithEvents tiempoPic As PictureBox
    Friend WithEvents lblLongitud As Label
    Friend WithEvents lblMasa As Label
    Friend WithEvents lblAlmacenamiento As Label
    Friend WithEvents lblTiempo As Label
End Class
