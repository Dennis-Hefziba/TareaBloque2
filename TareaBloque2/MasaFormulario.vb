Public Class MasaFormulario
    Private Sub lblConvertir_Click(sender As Object, e As EventArgs) Handles lblMasaConvertir.Click

        Dim medidaOrigen As String = boxMasa1.SelectedItem.ToString()
        Dim medidaDestino As String = boxMasa2.SelectedItem.ToString()
        Dim valor As Double

        imagen.Visible = False

        If Double.TryParse(lblMasaNumero.Text, valor) Then

            Dim resultado As Double

            'Toneladas
            If medidaOrigen = "Tonelada" AndAlso medidaDestino = "Tonelada" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Tonelada" AndAlso medidaDestino = "Kilogramo" Then
                resultado = convertirTonAKil(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Tonelada" AndAlso medidaDestino = "Gramo" Then
                resultado = convertirTonAKil(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Tonelada" AndAlso medidaDestino = "Miligramo" Then
                resultado = convertirTonAMiligramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Tonelada" AndAlso medidaDestino = "Libra" Then
                resultado = convertirTonALibra(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Tonelada" AndAlso medidaDestino = "Onza" Then
                resultado = convertirTonAOnza(valor)
                lblMasaResultado.Text = resultado
                'Fin toneladas


                'Inicio kg
            ElseIf medidaOrigen = "Kilogramo" AndAlso medidaDestino = "Kilogramo" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Kilogramo" AndAlso medidaDestino = "Tonelada" Then
                resultado = convertirKilATonelada(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Kilogramo" AndAlso medidaDestino = "Gramo" Then
                resultado = convertirKilAGramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Kilogramo" AndAlso medidaDestino = "Miligramo" Then
                resultado = convertirKilAMiligramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Kilogramo" AndAlso medidaDestino = "Libra" Then
                resultado = convertirKilALibra(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Kilogramo" AndAlso medidaDestino = "Onza" Then
                resultado = convertirKilAOnza(valor)
                lblMasaResultado.Text = resultado
                'fin kg

                'GRAMOS
            ElseIf medidaOrigen = "Gramo" AndAlso medidaDestino = "Gramo" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Gramo" AndAlso medidaDestino = "Tonelada" Then
                resultado = convertirGramosATonelada(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Gramo" AndAlso medidaDestino = "Kilogramo" Then
                resultado = convertirGramosAKilogramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Gramo" AndAlso medidaDestino = "Miligramo" Then
                resultado = convertirGramosAMiligramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Gramo" AndAlso medidaDestino = "Libra" Then
                resultado = convertirGramosALibra(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Gramo" AndAlso medidaDestino = "Onza" Then
                resultado = convertirGramosAOnza(valor)
                lblMasaResultado.Text = resultado
                'fin gramos



                'MILIGRAMOS
            ElseIf medidaOrigen = "Miligramo" AndAlso medidaDestino = "Miligramo" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Miligramo" AndAlso medidaDestino = "Tonelada" Then
                resultado = convertirMiligramosATonelada(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Miligramo" AndAlso medidaDestino = "Kilogramo" Then
                resultado = convertirMiligramosAKilogramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Miligramo" AndAlso medidaDestino = "Gramo" Then
                resultado = convertirMiligramosAGramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Miligramo" AndAlso medidaDestino = "Libra" Then
                resultado = convertirMiligramosALibra(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Miligramo" AndAlso medidaDestino = "Onza" Then
                resultado = convertirMiligramosAOnza(valor)
                lblMasaResultado.Text = resultado
                'fin miligramos



                'LIBRAS
            ElseIf medidaOrigen = "Libra" AndAlso medidaDestino = "Libra" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Libra" AndAlso medidaDestino = "Tonelada" Then
                resultado = convertirLibrasATonelada(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Libra" AndAlso medidaDestino = "Kilogramo" Then
                resultado = convertirLibrasAKilogramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Libra" AndAlso medidaDestino = "Gramo" Then
                resultado = convertirLibrasAGramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Libra" AndAlso medidaDestino = "Miligramo" Then
                resultado = convertirLibrasAMiligramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Libra" AndAlso medidaDestino = "Onza" Then
                resultado = convertirLibrasAOnza(valor)
                lblMasaResultado.Text = resultado
                'fin libras



                'Onzas
            ElseIf medidaOrigen = "Onza" AndAlso medidaDestino = "Onza" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Onza" AndAlso medidaDestino = "Tonelada" Then
                resultado = convertirOnzaATonelada(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Onza" AndAlso medidaDestino = "Kilogramo" Then
                resultado = convertirOnzaAKilogramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Onza" AndAlso medidaDestino = "Gramo" Then
                resultado = convertirOnzaAGramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Onza" AndAlso medidaDestino = "Miligramo" Then
                resultado = convertirOnzaAMiligramo(valor)
                lblMasaResultado.Text = resultado

            ElseIf medidaOrigen = "Onza" AndAlso medidaDestino = "Libra" Then
                resultado = convertirOnzaALibra(valor)
                lblMasaResultado.Text = resultado
                'fin onzas



            End If
        Else
            MessageBox.Show("Ingrese un dato valido")
        End If
    End Sub

    'Metodos

    'TONELADAS
    Private Function convertirTonAKil(ByVal valor As Double) As Double
        Return valor * 1000
    End Function

    Private Function convertirTonAGramo(ByVal valor As Double) As Double
        Return valor * 1000000
    End Function

    Private Function convertirTonAMiligramo(ByVal valor As Double) As Double
        Return valor * 1000000000
    End Function

    Private Function convertirTonALibra(ByVal valor As Double) As Double
        Return valor * 2205
    End Function

    Private Function convertirTonAOnza(ByVal valor As Double) As Double
        Return valor * 35270
    End Function
    'FIN TONELADAS


    'Kilogramos
    Private Function convertirKilATonelada(ByVal valor As Double) As Double
        Return valor / 1000
    End Function

    Private Function convertirKilAGramo(ByVal valor As Double) As Double
        Return valor * 1000
    End Function

    Private Function convertirKilAMiligramo(ByVal valor As Double) As Double
        Return valor * 1000000
    End Function

    Private Function convertirKilALibra(ByVal valor As Double) As Double
        Return valor * 2.205
    End Function

    Private Function convertirKilAOnza(ByVal valor As Double) As Double
        Return valor * 35.274
    End Function
    'fin kg


    'GRAMOS
    Private Function convertirGramosATonelada(ByVal valor As Double) As Double
        Return valor / 1000000
    End Function

    Private Function convertirGramosAKilogramo(ByVal valor As Double) As Double
        Return valor / 1000
    End Function

    Private Function convertirGramosAMiligramo(ByVal valor As Double) As Double
        Return valor * 1000
    End Function

    Private Function convertirGramosALibra(ByVal valor As Double) As Double
        Return valor / 453.6
    End Function

    Private Function convertirGramosAOnza(ByVal valor As Double) As Double
        Return valor / 28.35
    End Function
    'Fin gramos

    'MILIGRAMOS
    Private Function convertirMiligramosATonelada(ByVal valor As Double) As Double
        Return valor / 1000000000
    End Function

    Private Function convertirMiligramosAKilogramo(ByVal valor As Double) As Double
        Return valor / 1000000
    End Function

    Private Function convertirMiligramosAGramo(ByVal valor As Double) As Double
        Return valor / 1000
    End Function

    Private Function convertirMiligramosALibra(ByVal valor As Double) As Double
        Return valor / 453600
    End Function

    Private Function convertirMiligramosAOnza(ByVal valor As Double) As Double
        Return valor / 28350
    End Function
    'Fin miligramos



    'LIBRAS
    Private Function convertirLibrasATonelada(ByVal valor As Double) As Double
        Return valor / 2205
    End Function

    Private Function convertirLibrasAKilogramo(ByVal valor As Double) As Double
        Return valor / 2.205
    End Function

    Private Function convertirLibrasAGramo(ByVal valor As Double) As Double
        Return valor * 453.6
    End Function

    Private Function convertirLibrasAMiligramo(ByVal valor As Double) As Double
        Return valor * 453600
    End Function

    Private Function convertirLibrasAOnza(ByVal valor As Double) As Double
        Return valor * 16
    End Function
    'Fin libras



    'ONZAS
    Private Function convertirOnzaATonelada(ByVal valor As Double) As Double
        Return valor / 35270
    End Function

    Private Function convertirOnzaAKilogramo(ByVal valor As Double) As Double
        Return valor / 35.274
    End Function

    Private Function convertirOnzaAGramo(ByVal valor As Double) As Double
        Return valor * 28.35
    End Function

    Private Function convertirOnzaAMiligramo(ByVal valor As Double) As Double
        Return valor * 28350
    End Function

    Private Function convertirOnzaALibra(ByVal valor As Double) As Double
        Return valor / 16
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        boxMasa1.SelectedIndex = -1
        boxMasa2.SelectedIndex = -1
        lblMasaNumero.Text = ""
        lblMasaResultado.Text = ""

        imagen.Visible = True
    End Sub

    Private Sub lblMasaNumero_TextChanged(sender As Object, e As EventArgs) Handles lblMasaNumero.TextChanged

        Dim valor As Double
        If Double.TryParse(lblMasaNumero.Text, valor) Then
            If valor <= 0 Then
                MessageBox.Show("Ingresa un numero mayor a cero")
                lblMasaNumero.Text = ""
            End If

        Else
            If Not String.IsNullOrWhiteSpace(lblMasaNumero.Text) Then
                MessageBox.Show("No se admiten letras")
            End If
            lblMasaNumero.Text = ""
        End If

    End Sub


    'Fin ONZAS  

End Class