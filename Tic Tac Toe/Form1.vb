Public Class Form1
    Private image1 As Image
    Private image2 As Image
    Private iniciado = False
    Private WithEvents form2 As Form2 = New Form2

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            image1 = PictureBox1.Image
            PictureBox1.Image = My.Resources.equis
        Else
            PictureBox1.Image = image1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            image2 = PictureBox2.Image
            PictureBox2.Image = My.Resources.circulo
        Else
            PictureBox2.Image = image2
        End If
    End Sub

    Private Sub BotonImagen1_Click(sender As Object, e As EventArgs) Handles BotonImagen1.Click
        Imagen(PictureBox1)
    End Sub

    Private Sub BotonImagen2_Click(sender As Object, e As EventArgs) Handles BotonImagen2.Click
        Imagen(PictureBox2)
    End Sub
    Private Sub Imagen(imagen As Object)
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            imagen.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        If iniciado Then
            Hide()
        Else
            MsgBox("La primera vez no puedes cancelar las propiedades.", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If RadioButton1.Checked Then
            form2.cuadricula = 3
        Else
            form2.cuadricula = 4
        End If
        form2.jugador1 = TextBox1.Text
        form2.jugador2 = TextBox2.Text
        form2.imagen1 = PictureBox1.Image
        form2.imagen2 = PictureBox2.Image
        form2.ordenador = Ordenador.Checked


        form2.contenido()
        If Not iniciado Then
            form2.Show()
            iniciado = True
        End If
        Hide()
    End Sub
    Private Sub form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles form2.FormClosed
        Me.Close()
    End Sub
End Class
