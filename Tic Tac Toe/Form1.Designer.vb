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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BotonImagen1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.BotonImagen2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ordenador = New System.Windows.Forms.CheckBox()
        Me.Cuadricula = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cuadricula.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jugador 1:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Jugador 1"
        '
        'BotonImagen1
        '
        Me.BotonImagen1.Location = New System.Drawing.Point(47, 72)
        Me.BotonImagen1.Name = "BotonImagen1"
        Me.BotonImagen1.Size = New System.Drawing.Size(66, 23)
        Me.BotonImagen1.TabIndex = 4
        Me.BotonImagen1.Text = "Imagen:"
        Me.BotonImagen1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(32, 119)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Por defecto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(304, 119)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Por defecto"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'BotonImagen2
        '
        Me.BotonImagen2.Location = New System.Drawing.Point(319, 72)
        Me.BotonImagen2.Name = "BotonImagen2"
        Me.BotonImagen2.Size = New System.Drawing.Size(66, 23)
        Me.BotonImagen2.TabIndex = 9
        Me.BotonImagen2.Text = "Imagen:"
        Me.BotonImagen2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(400, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(129, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "Jugador 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Jugador 2:"
        '
        'Ordenador
        '
        Me.Ordenador.AutoSize = True
        Me.Ordenador.Location = New System.Drawing.Point(422, 172)
        Me.Ordenador.Name = "Ordenador"
        Me.Ordenador.Size = New System.Drawing.Size(76, 17)
        Me.Ordenador.TabIndex = 11
        Me.Ordenador.Text = "Ordenador"
        Me.Ordenador.UseVisualStyleBackColor = True
        '
        'Cuadricula
        '
        Me.Cuadricula.Controls.Add(Me.RadioButton2)
        Me.Cuadricula.Controls.Add(Me.RadioButton1)
        Me.Cuadricula.Location = New System.Drawing.Point(12, 218)
        Me.Cuadricula.Name = "Cuadricula"
        Me.Cuadricula.Size = New System.Drawing.Size(525, 49)
        Me.Cuadricula.TabIndex = 12
        Me.Cuadricula.TabStop = False
        Me.Cuadricula.Text = "Cuadrícula"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(319, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "4 x 4"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(152, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "3 x 3"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(164, 273)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(93, 29)
        Me.Aceptar.TabIndex = 13
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(292, 273)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(93, 29)
        Me.Cancelar.TabIndex = 14
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tic_Tac_Toe.My.Resources.Resources.jugador2
        Me.PictureBox2.Location = New System.Drawing.Point(400, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.jugador1
        Me.PictureBox1.Location = New System.Drawing.Point(128, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 318)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cuadricula)
        Me.Controls.Add(Me.Ordenador)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.BotonImagen2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BotonImagen1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Propiedades del Juego"
        Me.Cuadricula.ResumeLayout(False)
        Me.Cuadricula.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotonImagen1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BotonImagen2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Ordenador As CheckBox
    Friend WithEvents Cuadricula As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Aceptar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
