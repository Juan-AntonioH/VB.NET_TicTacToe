Public Class Form2
    Public Property jugador1 As String
    Public Property jugador2 As String
    Public Property imagen1 As Image
    Public Property imagen2 As Image
    Public Property cuadricula As Int16
    Public Property ordenador As Boolean

    Dim tablero(,) As Integer
    Dim ordenJugador As Int16
    Dim random As New Random()
    Dim finish = False
    Public Sub contenido()
        LabelJugador1.Text = jugador1
        LabelJugador2.Text = jugador2
        If cuadricula = 3 Then
            Me.Height = 650
            BotonesVisibles(False)
        Else
            Me.Height = 800
            BotonesVisibles(True)
        End If
        NuevaPartida()
    End Sub
    Private Sub BotonesVisibles(activar As Boolean)
        For i As Integer = 10 To 16
            Dim nombreBoton As String = "Button" & i.ToString()
            Dim boton As PictureBox = DirectCast(Me.Controls(nombreBoton), PictureBox)
            boton.Visible = activar
        Next
    End Sub
    Private Sub NuevoJuego_Click(sender As Object, e As EventArgs) Handles NuevoJuego.Click
        NuevaPartida()
    End Sub

    Private Sub NuevaPartida()
        For i As Integer = 1 To 16
            Dim nombreBoton As String = "Button" & i.ToString()
            Dim boton As PictureBox = DirectCast(Me.Controls(nombreBoton), PictureBox)
            boton.Image = Nothing
        Next
        tablero = New Integer(cuadricula, cuadricula) {}
        ordenJugador = random.Next(1, 3)
        finish = False
        Dim nombre As String = If(ordenJugador = 1, jugador1, jugador2)
        MsgBox("El primer jugador en iniciar la partida es: " & vbCrLf & vbCrLf & nombre, MsgBoxStyle.Information, "Orden jugador")
        If ordenador AndAlso ordenJugador = 2 Then
            TurnoOrdenador()
            ordenJugador = 1
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        NuevaPartida()
        Contador1.Text = 0
        Contador2.Text = 0
    End Sub

    Private Sub Propiedades_Click(sender As Object, e As EventArgs) Handles Propiedades.Click
        Form1.Show()
    End Sub

    Private Sub CerrarJuego_Click(sender As Object, e As EventArgs) Handles CerrarJuego.Click
        Close()
    End Sub

    Private Sub Ayuda_Click(sender As Object, e As EventArgs) Handles Ayuda.Click
        Dim mensaje As String =
    "Información sobre el funcionamiento del juego." & vbCrLf & vbCrLf &
    "El juego inicia una partida nueva la primera vez que lo inicias." & vbCrLf & vbCrLf &
    "En menú tendrás una opción para iniciar una nueva partida una vez un jugador gane." & vbCrLf & vbCrLf &
    "Reset reinicia los valores de victoria de cada jugador e inicia una nueva partida" & vbCrLf & vbCrLf &
    "Propiedades te permite elegir nuevos nombres, imagenes a usar, tamaño de cuadrícula o si quieres jugar contra la computadora." & vbCrLf & vbCrLf &
    "Cerrar para cerrar el juego, o darle a la X de la esquina hace el mismo efecto."

        MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button_click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim pictureBox As PictureBox = DirectCast(sender, PictureBox)

        Dim fila As Integer
        Dim columna As Integer

        If cuadricula = 3 Then
            'Obtener número según nombre del botón
            fila = (CInt(pictureBox.Name.Replace("Button", "")) - 1) \ cuadricula
            columna = (CInt(pictureBox.Name.Replace("Button", "")) - 1) Mod cuadricula
        Else
            'Obtener número según el nombre del tag para cuadricula 4x4
            fila = (CInt(pictureBox.Tag) - 1) \ cuadricula
            columna = (CInt(pictureBox.Tag) - 1) Mod cuadricula
        End If
        If Not finish AndAlso tablero(fila, columna) = 0 Then
            If ordenJugador = 1 Then
                pictureBox.Image = imagen1
                tablero(fila, columna) = 1
                ordenJugador = 2
            ElseIf ordenJugador = 2 And Not ordenador Then
                pictureBox.Image = imagen2
                tablero(fila, columna) = 2
                ordenJugador = 1
            End If
            If cuadricula = 3 Then
                ComprobarGanador3()
            Else
                ComprobarGanador4()
            End If
            If ordenador AndAlso ordenJugador = 2 AndAlso Not finish Then
                ' Es el turno de la máquina
                TurnoOrdenador()
                ordenJugador = 1
            End If
        End If

    End Sub

    Private Sub ComprobarGanador3()
        'Comprobando filas
        For fila As Integer = 0 To cuadricula - 1
            If tablero(fila, 0) <> 0 AndAlso tablero(fila, 0) = tablero(fila, 1) AndAlso tablero(fila, 1) = tablero(fila, 2) Then
                ' Hay un ganador en esta fila
                MostrarGanador(tablero(fila, 0))
                Return
            End If
        Next

        'Comprobando columnas
        For columna As Integer = 0 To cuadricula - 1
            If tablero(0, columna) <> 0 AndAlso tablero(0, columna) = tablero(1, columna) AndAlso tablero(1, columna) = tablero(2, columna) Then
                ' Hay un ganador en esta columna
                MostrarGanador(tablero(0, columna))
                Return
            End If
        Next

        'Comprobando diagonales
        If tablero(0, 0) <> 0 AndAlso tablero(0, 0) = tablero(1, 1) AndAlso tablero(1, 1) = tablero(2, 2) Then
            ' Hay un ganador en la diagonal principal
            MostrarGanador(tablero(0, 0))
            Return
        End If

        If tablero(0, 2) <> 0 AndAlso tablero(0, 2) = tablero(1, 1) AndAlso tablero(1, 1) = tablero(2, 0) Then
            ' Hay un ganador en la diagonal secundaria
            MostrarGanador(tablero(0, 2))
            Return
        End If

        If TableroLleno() Then
            MostrarEmpate()
        End If
    End Sub

    Private Sub ComprobarGanador4()
        'Comprobando filas
        For fila As Integer = 0 To cuadricula - 1
            If tablero(fila, 0) <> 0 And tablero(fila, 0) = tablero(fila, 1) And tablero(fila, 1) = tablero(fila, 2) And tablero(fila, 2) = tablero(fila, 3) Then
                ' Hay un ganador en esta fila
                MostrarGanador(tablero(fila, 0))
                Return
            End If
        Next

        ' Comprobando columnas
        For columna As Integer = 0 To cuadricula - 1
            If tablero(0, columna) <> 0 AndAlso tablero(0, columna) = tablero(1, columna) AndAlso tablero(1, columna) = tablero(2, columna) AndAlso tablero(2, columna) = tablero(3, columna) Then
                ' Hay un ganador en esta columna
                MostrarGanador(tablero(0, columna))
                Return
            End If
        Next

        'Comprobando diagonales
        If tablero(0, 0) <> 0 AndAlso tablero(0, 0) = tablero(1, 1) AndAlso tablero(1, 1) = tablero(2, 2) AndAlso tablero(2, 2) = tablero(3, 3) Then
            ' Hay un ganador en la diagonal principal
            MostrarGanador(tablero(0, 0))
            Return
        End If

        If tablero(0, 3) <> 0 AndAlso tablero(0, 3) = tablero(1, 2) AndAlso tablero(1, 2) = tablero(2, 1) AndAlso tablero(2, 1) = tablero(3, 0) Then
            ' Hay un ganador en la diagonal secundaria
            MostrarGanador(tablero(0, 3))
            Return
        End If

        If TableroLleno() Then
            MostrarEmpate()
        End If
    End Sub


    Private Sub MostrarGanador(jugador As Integer)
        finish = True
        Dim resultado As DialogResult = MessageBox.Show($"¡Jugador {jugador} ha ganado!" & vbCrLf & vbCrLf & "¿Quieres reiniciar la partida?", "¡Felicidades!", MessageBoxButtons.YesNo)
        If jugador = 1 Then
            Contador1.Text = CInt(Contador1.Text) + 1
        Else
            Contador2.Text = CInt(Contador2.Text) + 1
        End If
        If resultado = DialogResult.Yes Then
            NuevaPartida()
        End If

    End Sub

    Private Sub MostrarEmpate()
        finish = True
        Dim resultado As DialogResult = MessageBox.Show("El juego ha terminado en empate." & vbCrLf & vbCrLf & "¿Quieres reiniciar la partida?", "¡Empate!", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            NuevaPartida()
        End If
    End Sub

    Private Function TableroLleno() As Boolean
        For fila As Integer = 0 To cuadricula - 1
            For columna As Integer = 0 To cuadricula - 1
                If tablero(fila, columna) = 0 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Sub TurnoOrdenador()
        ' Busca la mejor jugada para la máquina y actualiza la interfaz gráfica
        Dim mejorJugada As Jugada = ObtenerMejorJugada()
        If mejorJugada IsNot Nothing Then
            Dim pictureBox As PictureBox = FindButton(mejorJugada.Fila, mejorJugada.Columna)

            If pictureBox IsNot Nothing Then
                pictureBox.Image = imagen2
                tablero(mejorJugada.Fila, mejorJugada.Columna) = 2
                ' También puedes realizar otras acciones relacionadas con la jugada, como actualizar la matriz del tablero.
            End If
        End If
        If cuadricula = 3 Then
            ComprobarGanador3()
        Else
            ComprobarGanador4()
        End If

    End Sub
    Private Function FindButton(row As Integer, column As Integer) As PictureBox

        If cuadricula = 3 Then
            Dim buttonName As String = "Button" & ((row * cuadricula) + column + 1).ToString()
            ' Busca el control PictureBox con el nombre correspondiente
            Return DirectCast(Me.Controls(buttonName), PictureBox)
        Else
            Dim buttonTag As String = ((row * cuadricula) + column + 1).ToString()
            For Each control As Control In Me.Controls
                If control.Tag IsNot Nothing AndAlso control.Tag.ToString() = buttonTag Then
                    Return control
                End If
            Next
        End If

        Return Nothing
    End Function
    Private Function ObtenerMejorJugada() As Jugada
        ' Aquí implementa la lógica para encontrar la mejor jugada

        ' Busca una jugada ganadora
        If cuadricula = 3 Then
            Dim jugadaGanadora As Jugada = BuscarJugadaGanadora3(2)
            If jugadaGanadora IsNot Nothing Then
                Return jugadaGanadora
            End If

            ' Bloquea al jugador
            Dim jugadaBloqueo As Jugada = BuscarJugadaGanadora3(1)
            If jugadaBloqueo IsNot Nothing Then
                Return jugadaBloqueo
            End If
        Else
            Dim jugadaGanadora As Jugada = BuscarJugadaGanadora4(2)
            If jugadaGanadora IsNot Nothing Then
                Return jugadaGanadora
            End If

            ' Bloquea al jugador
            Dim jugadaBloqueo As Jugada = BuscarJugadaGanadora4(1)
            If jugadaBloqueo IsNot Nothing Then
                Return jugadaBloqueo
            End If
        End If


        ' Si no hay una jugada ganadora o de bloqueo, realiza una jugada aleatoria
        Return RealizarJugadaAleatoria()
    End Function

    Private Function BuscarJugadaGanadora3(valor As Integer) As Jugada
        ' Aquí implementa la lógica para buscar una jugada que lleve a la victoria

        ' Buscar en filas
        For i As Integer = 0 To cuadricula - 1
            If tablero(i, 0) = valor AndAlso tablero(i, 1) = valor AndAlso tablero(i, 2) = 0 Then
                Return New Jugada(i, 2)
            ElseIf tablero(i, 0) = 0 AndAlso tablero(i, 1) = valor AndAlso tablero(i, 2) = valor Then
                Return New Jugada(i, 0)
            ElseIf tablero(i, 0) = valor AndAlso tablero(i, 1) = 0 AndAlso tablero(i, 2) = valor Then
                Return New Jugada(i, 1)
            End If
        Next

        ' Buscar en columnas
        For j As Integer = 0 To cuadricula - 1
            Dim i As Integer = 0
            If tablero(i, j) = valor AndAlso tablero(i + 1, j) = valor AndAlso tablero(i + 2, j) = 0 Then
                Return New Jugada(i + 2, j)
            ElseIf tablero(i, j) = 0 AndAlso tablero(i + 1, j) = valor AndAlso tablero(i + 2, j) = valor Then
                Return New Jugada(i, j)
            ElseIf tablero(i, j) = valor AndAlso tablero(i + 1, j) = 0 AndAlso tablero(i + 2, j) = valor Then
                Return New Jugada(i + 1, j)
            End If
        Next

        ' Buscar en diagonales (de izquierda a derecha)
        Dim fila As Integer = 0
        Dim columna As Integer = 0

        If tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna + 1) = valor AndAlso tablero(fila + 2, columna + 2) = 0 Then
            Return New Jugada(fila + 2, columna + 2)
        ElseIf tablero(fila, columna) = 0 AndAlso tablero(fila + 1, columna + 1) = valor AndAlso tablero(fila + 2, columna + 2) = valor Then
            Return New Jugada(fila, columna)
        ElseIf tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna + 1) = 0 AndAlso tablero(fila + 2, columna + 2) = valor Then
            Return New Jugada(fila + 1, columna + 1)
        End If

        fila = 0
        columna = cuadricula - 1
        ' Buscar en diagonales (de derecha a izquierda)

        If tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna - 1) = valor AndAlso tablero(fila + 2, columna - 2) = 0 Then
            Return New Jugada(fila + 2, columna - 2)
        ElseIf tablero(fila, columna) = 0 AndAlso tablero(fila + 1, columna - 1) = valor AndAlso tablero(fila + 2, columna - 2) = valor Then
            Return New Jugada(fila, columna)
        ElseIf tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna - 1) = 0 AndAlso tablero(fila + 2, columna - 2) = valor Then
            Return New Jugada(fila + 1, columna - 1)
        End If

        Return Nothing
    End Function
    Private Function BuscarJugadaGanadora4(valor As Integer) As Jugada
        ' Buscar en filas
        For i As Integer = 0 To cuadricula - 1
            Dim j As Integer = 0
            If tablero(i, j) = valor AndAlso tablero(i, j + 1) = valor AndAlso tablero(i, j + 2) = valor AndAlso tablero(i, j + 3) = 0 Then
                Return New Jugada(i, j + 3)
            ElseIf tablero(i, j) = 0 AndAlso tablero(i, j + 1) = valor AndAlso tablero(i, j + 2) = valor AndAlso tablero(i, j + 3) = valor Then
                Return New Jugada(i, j)
            ElseIf tablero(i, j) = valor AndAlso tablero(i, j + 1) = 0 AndAlso tablero(i, j + 2) = valor AndAlso tablero(i, j + 3) = valor Then
                Return New Jugada(i, j + 1)
            ElseIf tablero(i, j) = valor AndAlso tablero(i, j + 1) = valor AndAlso tablero(i, j + 2) = 0 AndAlso tablero(i, j + 3) = valor Then
                Return New Jugada(i, j + 2)
            End If
        Next

        ' Buscar en columnas
        For j As Integer = 0 To cuadricula - 1
            Dim i As Integer = 0
            If tablero(i, j) = valor AndAlso tablero(i + 1, j) = valor AndAlso tablero(i + 2, j) = valor AndAlso tablero(i + 3, j) = 0 Then
                Return New Jugada(i + 3, j)
            ElseIf tablero(i, j) = 0 AndAlso tablero(i + 1, j) = valor AndAlso tablero(i + 2, j) = valor AndAlso tablero(i + 3, j) = valor Then
                Return New Jugada(i, j)
            ElseIf tablero(i, j) = valor AndAlso tablero(i + 1, j) = 0 AndAlso tablero(i + 2, j) = valor AndAlso tablero(i + 3, j) = valor Then
                Return New Jugada(i + 1, j)
            ElseIf tablero(i, j) = valor AndAlso tablero(i + 1, j) = valor AndAlso tablero(i + 2, j) = 0 AndAlso tablero(i + 3, j) = valor Then
                Return New Jugada(i + 2, j)
            End If
        Next

        Dim fila As Integer = 0
        Dim columna As Integer = 0

        ' Buscar en diagonales (de izquierda a derecha)

        If tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna + 1) = valor AndAlso tablero(fila + 2, columna + 2) = valor AndAlso tablero(fila + 3, columna + 3) = 0 Then
            Return New Jugada(fila + 3, columna + 3)
        ElseIf tablero(fila, columna) = 0 AndAlso tablero(fila + 1, columna + 1) = valor AndAlso tablero(fila + 2, columna + 2) = valor AndAlso tablero(fila + 3, columna + 3) = valor Then
            Return New Jugada(fila, columna)
        ElseIf tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna + 1) = 0 AndAlso tablero(fila + 2, columna + 2) = valor AndAlso tablero(fila + 3, columna + 3) = valor Then
            Return New Jugada(fila + 1, columna + 1)
        ElseIf tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna + 1) = valor AndAlso tablero(fila + 2, columna + 2) = 0 AndAlso tablero(fila + 3, columna + 3) = valor Then
            Return New Jugada(fila + 2, columna + 2)
        End If


        ' Buscar en diagonales (de derecha a izquierda)
        fila = 0
        columna = cuadricula - 1
        If tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna - 1) = valor AndAlso tablero(fila + 2, columna - 2) = valor AndAlso tablero(fila + 3, columna - 3) = 0 Then
            Return New Jugada(fila + 3, columna - 3)
        ElseIf tablero(fila, columna) = 0 AndAlso tablero(fila + 1, columna - 1) = valor AndAlso tablero(fila + 2, columna - 2) = valor AndAlso tablero(fila + 3, columna - 3) = valor Then
            Return New Jugada(fila, columna)
        ElseIf tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna - 1) = 0 AndAlso tablero(fila + 2, columna - 2) = valor AndAlso tablero(fila + 3, columna - 3) = valor Then
            Return New Jugada(fila + 1, columna - 1)
        ElseIf tablero(fila, columna) = valor AndAlso tablero(fila + 1, columna - 1) = valor AndAlso tablero(fila + 2, columna - 2) = 0 AndAlso tablero(fila + 3, columna - 3) = valor Then
            Return New Jugada(fila + 2, columna - 2)
        End If

        Return Nothing
    End Function
    Private Function RealizarJugadaAleatoria() As Jugada
        ' Aquí implementa la lógica para realizar una jugada aleatoria en una posición vacía del tablero
        Dim rnd As New Random()
        Dim fila As Integer
        Dim columna As Integer

        Do
            fila = rnd.Next(0, cuadricula)
            columna = rnd.Next(0, cuadricula)
        Loop While tablero(fila, columna) <> 0

        Return New Jugada(fila, columna)
    End Function

    Private Class Jugada
        Public Property Fila As Integer
        Public Property Columna As Integer

        Public Sub New(fila As Integer, columna As Integer)
            Me.Fila = fila
            Me.Columna = columna
        End Sub
    End Class

End Class


'Private Function ComprobarLinea(a As Integer, b As Integer, c As Integer, d As Integer) As Boolean
'Return a <> 0 AndAlso a = b AndAlso b = c AndAlso c = d
'End Function

'Public Sub New(jugador1 As String, jugador2 As String, imagen1 As Image, imagen2 As Image, cuadricula As Int16, ordenador As Boolean)
'Me.jugador1 = jugador1
'Me.jugador2 = jugador2
'Me.imagen1 = imagen1
'Me.imagen2 = imagen2
'Me.cuadricula = cuadricula
'Me.ordenador = ordenador
' End Sub
