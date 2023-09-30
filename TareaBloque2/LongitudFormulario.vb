'AQUI LAS CONDICIONES QUE SE DEBEN CUMPLIR AL EJECUTAR EL EVENTO CLICK
Public Class LongitudFormulario

    'Este codigo pertenece al boton convertir
    Private Sub lblConvertir_Click(sender As Object, e As EventArgs) Handles lblConvertir.Click

        'Declaramos variables para cada combo box y les asignamos el metodo selectedItem
        'para saber que item a seleccionado el usuario y lo convertimos a string
        Dim medidaOrigen As String = box1.SelectedItem.ToString()
        Dim medidaDestino As String = box2.SelectedItem.ToString()
        Dim valor As Double


        'Hace desaparecer la imagen al dar clik a convertir
        ImgLongitudes.Visible = False
        Button1.Visible = True

        If Double.TryParse(lblNumero.Text, valor) Then

            Dim resultado As Double

            If medidaOrigen = "Kilometro" AndAlso medidaDestino = "Kilometro" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")


                'asigno a la variable resultado el metodo correspondiente y llamo la variable de retorno (valor)
                'Y luego al lblResultado le asigno la variable resultado para mostrarlo en el form


                'Inicio para km
            ElseIf medidaOrigen = "Kilometro" AndAlso medidaDestino = "Metro" Then
                resultado = ConvertirAKilometrosAMetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Kilometro" AndAlso medidaDestino = "Centimetro" Then
                resultado = ConvertirAKilometrosACentimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Kilometro" AndAlso medidaDestino = "Milimetro" Then
                resultado = ConvertirAKilometrosAMilimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Kilometro" AndAlso medidaDestino = "Pie" Then
                resultado = ConvertirAKilometrosAPie(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Kilometro" AndAlso medidaDestino = "Pulgada" Then
                resultado = ConvertirAKilometrosAPulgadas(valor)
                lblResultado.Text = resultado
                'Final kms

                'inicio metros
            ElseIf medidaOrigen = "Metro" AndAlso medidaDestino = "Metro" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Metro" AndAlso medidaDestino = "Kilometro" Then
                resultado = ConvertirMetrosAKilometros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Metro" AndAlso medidaDestino = "Centimetro" Then
                resultado = ConvertirMetrosACentimetro(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Metro" AndAlso medidaDestino = "Milimetro" Then
                resultado = ConvertirMetrosAMilimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Metro" AndAlso medidaDestino = "Pie" Then
                resultado = ConvertirMetrosAPies(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Metro" AndAlso medidaDestino = "Pulgada" Then
                resultado = ConvertirMetrosAPulgadas(valor)
                lblResultado.Text = resultado
                'fINAL METROS

                'Inicio centimetros
            ElseIf medidaOrigen = "Centimetro" AndAlso medidaDestino = "Centimetro" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Centimetro" AndAlso medidaDestino = "Kilometro" Then
                resultado = ConvertirCentimetrosAKilometros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Centimetro" AndAlso medidaDestino = "Metro" Then
                resultado = ConvertirCentimetrosAMetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Centimetro" AndAlso medidaDestino = "Milimetro" Then
                resultado = ConvertirCentimetrosAMilimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Centimetro" AndAlso medidaDestino = "Pie" Then
                resultado = ConvertirCentimetrosAPies(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Centimetro" AndAlso medidaDestino = "Pulgada" Then
                resultado = ConvertirCentimetrosAPulgadas(valor)
                lblResultado.Text = resultado
                'FIN CENTIMETROS

                'Inicio Milimetros
            ElseIf medidaOrigen = "Milimetro" AndAlso medidaDestino = "Milimetro" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Milimetro" AndAlso medidaDestino = "Kilometro" Then
                resultado = ConvertirMilimetrosAKilometros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Milimetro" AndAlso medidaDestino = "Metro" Then
                resultado = ConvertirMilimetrosAMetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Milimetro" AndAlso medidaDestino = "Centimetro" Then
                resultado = ConvertirMilimetrosACentimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Milimetro" AndAlso medidaDestino = "Pie" Then
                resultado = ConvertirMilimetrosAPies(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Milimetro" AndAlso medidaDestino = "Pulgada" Then
                resultado = ConvertirMilimetrosAPulgadas(valor)
                lblResultado.Text = resultado
                'FIN MILIMETROS

                'Inicio Pies
            ElseIf medidaOrigen = "Pie" AndAlso medidaDestino = "Pie" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Pie" AndAlso medidaDestino = "Kilometro" Then
                resultado = ConvertirPiesAKilometros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pie" AndAlso medidaDestino = "Metro" Then
                resultado = ConvertirPiesAMetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pie" AndAlso medidaDestino = "Centimetro" Then
                resultado = ConvertirPiesACentimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pie" AndAlso medidaDestino = "Milimetro" Then
                resultado = ConvertirPiesAMilimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pie" AndAlso medidaDestino = "Pulgada" Then
                resultado = ConvertirPiesAPulgadas(valor)
                lblResultado.Text = resultado
                'FIN PIES

                'Inicio pulgadas
            ElseIf medidaOrigen = "Pulgada" AndAlso medidaDestino = "Pulgada" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medidaOrigen = "Pulgada" AndAlso medidaDestino = "Kilometro" Then
                resultado = ConvertirPulgadasAKilometros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pulgada" AndAlso medidaDestino = "Metro" Then
                resultado = ConvertirPulgadasAMetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pulgada" AndAlso medidaDestino = "Centimetro" Then
                resultado = ConvertirPulgadasACentimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pulgada" AndAlso medidaDestino = "Milimetro" Then
                resultado = ConvertirPulgadasAMilimetros(valor)
                lblResultado.Text = resultado

            ElseIf medidaOrigen = "Pulgada" AndAlso medidaDestino = "Pie" Then
                resultado = ConvertirPulgadasAPies(valor)
                lblResultado.Text = resultado
                'FIN PULGADAS   

            End If
        Else
            MessageBox.Show("Ingrese un dato numerico")
        End If

    End Sub









    'Declarando metodos para el boton convertir
    'Declaro los metodos para obtener el valor y asignarlo a la variable resultado
    Private Function ConvertirAKilometrosAMetros(valor As Double) As Double
        Return valor * 1000
    End Function

    Private Function ConvertirAKilometrosACentimetros(valor As Double) As Double
        Return valor * 100000
    End Function

    Private Function ConvertirAKilometrosAMilimetros(valor As Double) As Double
        Return valor * 1000000
    End Function

    Private Function ConvertirAKilometrosAPie(valor As Double) As Double
        Return valor * 3281
    End Function

    Private Function ConvertirAKilometrosAPulgadas(valor As Double) As Double
        Return valor * 39370
    End Function

    Private Function ConvertirMetrosAKilometros(valor As Double) As Double
        Return valor / 1000
    End Function

    Private Function ConvertirMetrosACentimetro(valor As Double) As Double
        Return valor * 100
    End Function

    Private Function ConvertirMetrosAMilimetros(valor As Double) As Double
        Return valor * 1000
    End Function

    Private Function ConvertirMetrosAPies(valor As Double) As Double
        Return valor * 3.281
    End Function

    Private Function ConvertirMetrosAPulgadas(valor As Double) As Double
        Return valor * 39.37
    End Function

    Private Function ConvertirCentimetrosAKilometros(valor As Double) As Double
        Return valor / 100000
    End Function

    Private Function ConvertirCentimetrosAMetros(valor As Double) As Double
        Return valor / 100
    End Function

    Private Function ConvertirCentimetrosAMilimetros(valor As Double) As Double
        Return valor * 10
    End Function

    Private Function ConvertirCentimetrosAPies(valor As Double) As Double
        Return valor / 30.48
    End Function

    Private Function ConvertirCentimetrosAPulgadas(valor As Double) As Double
        Return valor / 2.54
    End Function

    Private Function ConvertirMilimetrosAKilometros(valor As Double) As Double
        Return valor / 1000000
    End Function

    Private Function ConvertirMilimetrosAMetros(valor As Double) As Double
        Return valor / 1000
    End Function

    Private Function ConvertirMilimetrosACentimetros(valor As Double) As Double
        Return valor / 10
    End Function

    Private Function ConvertirMilimetrosAPies(valor As Double) As Double
        Return valor / 304.8
    End Function

    Private Function ConvertirMilimetrosAPulgadas(valor As Double) As Double
        Return valor / 25.4
    End Function

    Private Function ConvertirPiesAKilometros(valor As Double) As Double
        Return valor / 3281
    End Function

    Private Function ConvertirPiesAMetros(valor As Double) As Double
        Return valor / 3.281
    End Function

    Private Function ConvertirPiesACentimetros(valor As Double) As Double
        Return valor * 30.48
    End Function

    Private Function ConvertirPiesAMilimetros(valor As Double) As Double
        Return valor * 304.8
    End Function

    Private Function ConvertirPiesAPulgadas(valor As Double) As Double
        Return valor * 12
    End Function

    Private Function ConvertirPulgadasAKilometros(valor As Double) As Double
        Return valor / 39370
    End Function

    Private Function ConvertirPulgadasAMetros(valor As Double) As Double
        Return valor / 39.37
    End Function

    Private Function ConvertirPulgadasACentimetros(valor As Double) As Double
        Return valor * 2.54
    End Function

    Private Function ConvertirPulgadasAMilimetros(valor As Double) As Double
        Return valor * 25.4
    End Function

    Private Function ConvertirPulgadasAPies(valor As Double) As Double
        Return valor / 12
    End Function




    'Esto pertenece al label donde se ingresa el numero a convertir
    Private Sub lblNumero_TextChanged(sender As Object, e As EventArgs) Handles lblNumero.TextChanged

        'Esto es para validar que el usuario ingrese un numero mayor a cero
        'Y que no ingrese letras
        Dim valor As Double
        If Double.TryParse(lblNumero.Text, valor) Then
            If valor <= 0 Then
                MessageBox.Show("Ingresa un numero mayor a cero")
                lblNumero.Text = ""
            End If

        Else
            If Not String.IsNullOrWhiteSpace(lblNumero.Text) Then
                MessageBox.Show("No se admiten letras")
            End If
            lblNumero.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'esto limpia todo
        box1.SelectedIndex = -1
        box2.SelectedIndex = -1
        lblNumero.Text = ""
        lblResultado.Text = ""

        ImgLongitudes.Visible = True
    End Sub

End Class