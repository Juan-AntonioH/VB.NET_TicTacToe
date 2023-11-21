<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.LabelJugador1 = New System.Windows.Forms.Label()
        Me.LabelJugador2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoJuego = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reset = New System.Windows.Forms.ToolStripMenuItem()
        Me.Propiedades = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarJuego = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contador1 = New System.Windows.Forms.TextBox()
        Me.Contador2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.PictureBox()
        Me.Button13 = New System.Windows.Forms.PictureBox()
        Me.Button14 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.PictureBox()
        Me.Button15 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.PictureBox()
        Me.Button16 = New System.Windows.Forms.PictureBox()
        Me.Button12 = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelJugador1
        '
        Me.LabelJugador1.AutoSize = True
        Me.LabelJugador1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJugador1.Location = New System.Drawing.Point(45, 24)
        Me.LabelJugador1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelJugador1.Name = "LabelJugador1"
        Me.LabelJugador1.Size = New System.Drawing.Size(147, 32)
        Me.LabelJugador1.TabIndex = 0
        Me.LabelJugador1.Text = "Jugador 1"
        '
        'LabelJugador2
        '
        Me.LabelJugador2.AutoSize = True
        Me.LabelJugador2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJugador2.Location = New System.Drawing.Point(402, 24)
        Me.LabelJugador2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LabelJugador2.Name = "LabelJugador2"
        Me.LabelJugador2.Size = New System.Drawing.Size(147, 32)
        Me.LabelJugador2.TabIndex = 1
        Me.LabelJugador2.Text = "Jugador 2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem, Me.Ayuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoJuego, Me.Reset, Me.Propiedades, Me.CerrarJuego})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'NuevoJuego
        '
        Me.NuevoJuego.Name = "NuevoJuego"
        Me.NuevoJuego.Size = New System.Drawing.Size(173, 22)
        Me.NuevoJuego.Text = "Nuevo Juego"
        '
        'Reset
        '
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(173, 22)
        Me.Reset.Text = "Reset"
        '
        'Propiedades
        '
        Me.Propiedades.Name = "Propiedades"
        Me.Propiedades.Size = New System.Drawing.Size(173, 22)
        Me.Propiedades.Text = "Propiedades Juego"
        '
        'CerrarJuego
        '
        Me.CerrarJuego.Name = "CerrarJuego"
        Me.CerrarJuego.Size = New System.Drawing.Size(173, 22)
        Me.CerrarJuego.Text = "Cerrar Juego"
        '
        'Ayuda
        '
        Me.Ayuda.Name = "Ayuda"
        Me.Ayuda.Size = New System.Drawing.Size(53, 20)
        Me.Ayuda.Text = "Ayuda"
        '
        'Contador1
        '
        Me.Contador1.Enabled = False
        Me.Contador1.Location = New System.Drawing.Point(256, 24)
        Me.Contador1.Name = "Contador1"
        Me.Contador1.ReadOnly = True
        Me.Contador1.Size = New System.Drawing.Size(100, 32)
        Me.Contador1.TabIndex = 3
        Me.Contador1.Text = "0"
        Me.Contador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Contador2
        '
        Me.Contador2.Enabled = False
        Me.Contador2.Location = New System.Drawing.Point(601, 24)
        Me.Contador2.Name = "Contador2"
        Me.Contador2.ReadOnly = True
        Me.Contador2.Size = New System.Drawing.Size(100, 32)
        Me.Contador2.TabIndex = 4
        Me.Contador2.Text = "0"
        Me.Contador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelJugador1)
        Me.Panel1.Controls.Add(Me.Contador2)
        Me.Panel1.Controls.Add(Me.LabelJugador2)
        Me.Panel1.Controls.Add(Me.Contador1)
        Me.Panel1.Location = New System.Drawing.Point(7, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 81)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(84, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 150)
        Me.Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button1.TabIndex = 21
        Me.Button1.TabStop = False
        Me.Button1.Tag = "1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(240, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 150)
        Me.Button2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button2.TabIndex = 22
        Me.Button2.TabStop = False
        Me.Button2.Tag = "2"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(396, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 150)
        Me.Button3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button3.TabIndex = 23
        Me.Button3.TabStop = False
        Me.Button3.Tag = "3"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button13.Location = New System.Drawing.Point(552, 124)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(150, 150)
        Me.Button13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button13.TabIndex = 24
        Me.Button13.TabStop = False
        Me.Button13.Tag = "4"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button14.Location = New System.Drawing.Point(552, 280)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(150, 150)
        Me.Button14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button14.TabIndex = 28
        Me.Button14.TabStop = False
        Me.Button14.Tag = "8"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Location = New System.Drawing.Point(396, 280)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 150)
        Me.Button6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button6.TabIndex = 27
        Me.Button6.TabStop = False
        Me.Button6.Tag = "7"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Location = New System.Drawing.Point(240, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 150)
        Me.Button5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button5.TabIndex = 26
        Me.Button5.TabStop = False
        Me.Button5.Tag = "6"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(84, 280)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 150)
        Me.Button4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button4.TabIndex = 25
        Me.Button4.TabStop = False
        Me.Button4.Tag = "5"
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button15.Location = New System.Drawing.Point(552, 436)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(150, 150)
        Me.Button15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button15.TabIndex = 32
        Me.Button15.TabStop = False
        Me.Button15.Tag = "12"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button9.Location = New System.Drawing.Point(396, 436)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(150, 150)
        Me.Button9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button9.TabIndex = 31
        Me.Button9.TabStop = False
        Me.Button9.Tag = "11"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.Location = New System.Drawing.Point(240, 436)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(150, 150)
        Me.Button8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button8.TabIndex = 30
        Me.Button8.TabStop = False
        Me.Button8.Tag = "10"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button7.Location = New System.Drawing.Point(84, 436)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(150, 150)
        Me.Button7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button7.TabIndex = 29
        Me.Button7.TabStop = False
        Me.Button7.Tag = "9"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button16.Location = New System.Drawing.Point(552, 592)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(150, 150)
        Me.Button16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button16.TabIndex = 36
        Me.Button16.TabStop = False
        Me.Button16.Tag = "16"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button12.Location = New System.Drawing.Point(396, 592)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(150, 150)
        Me.Button12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button12.TabIndex = 35
        Me.Button12.TabStop = False
        Me.Button12.Tag = "15"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button11.Location = New System.Drawing.Point(240, 592)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(150, 150)
        Me.Button11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button11.TabIndex = 34
        Me.Button11.TabStop = False
        Me.Button11.Tag = "14"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button10.Location = New System.Drawing.Point(84, 592)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(150, 150)
        Me.Button10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Button10.TabIndex = 33
        Me.Button10.TabStop = False
        Me.Button10.Tag = "13"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Tic Tac Toe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJugador1 As Label
    Friend WithEvents LabelJugador2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoJuego As ToolStripMenuItem
    Friend WithEvents Reset As ToolStripMenuItem
    Friend WithEvents Propiedades As ToolStripMenuItem
    Friend WithEvents CerrarJuego As ToolStripMenuItem
    Friend WithEvents Contador1 As TextBox
    Friend WithEvents Contador2 As TextBox
    Friend WithEvents Ayuda As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As PictureBox
    Friend WithEvents Button2 As PictureBox
    Friend WithEvents Button3 As PictureBox
    Friend WithEvents Button13 As PictureBox
    Friend WithEvents Button14 As PictureBox
    Friend WithEvents Button6 As PictureBox
    Friend WithEvents Button5 As PictureBox
    Friend WithEvents Button4 As PictureBox
    Friend WithEvents Button15 As PictureBox
    Friend WithEvents Button9 As PictureBox
    Friend WithEvents Button8 As PictureBox
    Friend WithEvents Button7 As PictureBox
    Friend WithEvents Button16 As PictureBox
    Friend WithEvents Button12 As PictureBox
    Friend WithEvents Button11 As PictureBox
    Friend WithEvents Button10 As PictureBox
End Class
