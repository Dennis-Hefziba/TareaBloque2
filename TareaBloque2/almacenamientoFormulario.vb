Public Class almacenamientoFormulario
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim medOrigen As String = opciones.SelectedItem.ToString()
        Dim medDestino As String = opciones2.SelectedItem.ToString()
        Dim val As Double

        imgLoad.Visible = False
        nuevo.Visible = True

        If Double.TryParse(txtEntrada.Text, val) Then
            Dim resultado As Double

            If medOrigen = "Megabyte" AndAlso medDestino = "Megabyte" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")
            ElseIf medOrigen = "Megabyte" AndAlso medDestino = "Gigabyte" Then
                resultado = convertirMegabyteAGb(val)
                txtResultado.Text = resultado

            ElseIf medOrigen = "Megabyte" AndAlso medDestino = "Terabyte" Then
                resultado = convertirMegabyteATb(val)
                txtResultado.Text = resultado

            ElseIf medOrigen = "Gigabyte" AndAlso medDestino = "Megabyte" Then
                resultado = convertirGigabyteAMb(val)
                txtResultado.Text = resultado

            ElseIf medOrigen = "Gigabyte" AndAlso medDestino = "Terabyte" Then
                resultado = convertirGigabyteATerabyte(val)
                txtResultado.Text = resultado

            ElseIf medOrigen = "Terabyte" AndAlso medDestino = "Megabyte" Then
                resultado = convertirTerabyteAMb(val)
                txtResultado.Text = resultado

            ElseIf medOrigen = "Terabyte" AndAlso medDestino = "Gigabyte" Then
                resultado = convertirTerabyteAGb(val)
                txtResultado.Text = resultado
            End If
        Else
            MessageBox.Show("Ingrese un dato numerico")
        End If


    End Sub

    'Inicio MB
    Public Function convertirMegabyteAGb(ByVal val As Double) As Double
        Return val / 1000
    End Function

    Public Function convertirMegabyteATb(ByVal val As Double) As Double
        Return val / 1000000
    End Function
    'Fin MB

    'Incio GB
    Public Function convertirGigabyteAMb(ByVal val As Double) As Double
        Return val * 1000
    End Function

    Public Function convertirGigabyteATerabyte(ByVal val As Double) As Double
        Return val / 1000
    End Function
    'Final GB

    'Inicio TB
    Public Function convertirTerabyteAMb(ByVal val As Double) As Double
        Return val * 1000000
    End Function

    Public Function convertirTerabyteAGb(ByVal val As Double) As Double
        Return val * 1000
    End Function

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click

        opciones.SelectedIndex = -1
        opciones2.SelectedIndex = -1
        txtEntrada.Text = ""
        txtResultado.Text = ""

        imgLoad.Visible = True

    End Sub
End Class