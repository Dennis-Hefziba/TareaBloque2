Public Class tiempoFormulario
    Private Sub lblConvertir_Click(sender As Object, e As EventArgs) Handles lblTempConvertir.Click
        Dim medOrigen As String = boxUno.SelectedItem.ToString()
        Dim medDestino As String = boxDos.SelectedItem.ToString()
        Dim val As Double

        ImgTemp.Visible = False
        btnNuevo.Visible = True

        If Double.TryParse(lblTempEnt.Text, val) Then

            Dim resultado As Double

            If medOrigen = "Segundo" AndAlso medDestino = "Segundo" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medOrigen = "Segundo" AndAlso medDestino = "Minuto" Then
                resultado = convetirSegundoAMinuto(val)
                lblTempResultado.Text = resultado

            ElseIf medOrigen = "Segundo" AndAlso medDestino = "Hora" Then
                resultado = convetirSegundoAHora(val)
                lblTempResultado.Text = resultado

            ElseIf medOrigen = "Minuto" AndAlso medDestino = "Minuto" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medOrigen = "Minuto" AndAlso medDestino = "Segundo" Then
                resultado = convetirMinutoASegundo(val)
                lblTempResultado.Text = resultado

            ElseIf medOrigen = "Minuto" AndAlso medDestino = "Hora" Then
                resultado = convetirMinutoAHora(val)
                lblTempResultado.Text = resultado

            ElseIf medOrigen = "Hora" AndAlso medDestino = "Hora" Then
                MessageBox.Show("No se puede convertir hacia el mismo valor, selecciona otro")

            ElseIf medOrigen = "Hora" AndAlso medDestino = "Segundo" Then
                resultado = convetirHoraASegundo(val)
                lblTempResultado.Text = resultado

            ElseIf medOrigen = "Hora" AndAlso medDestino = "Minuto" Then
                resultado = convetirHoraAMinuto(val)
                lblTempResultado.Text = resultado

            End If
        Else
            MessageBox.Show("Ingrese un dato numerico")
        End If


    End Sub

    Public Function convetirSegundoAMinuto(ByVal val As Double) As Double
        Return val / 60
    End Function

    Public Function convetirSegundoAHora(ByVal val As Double) As Double
        Return val / 3600
    End Function

    Public Function convetirMinutoASegundo(ByVal val As Double) As Double
        Return val * 60
    End Function

    Public Function convetirMinutoAHora(ByVal val As Double) As Double
        Return val / 60
    End Function

    Public Function convetirHoraASegundo(ByVal val As Double) As Double
        Return val * 3600
    End Function

    Public Function convetirHoraAMinuto(ByVal val As Double) As Double
        Return val * 60
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        boxUno.SelectedIndex = -1
        boxDos.SelectedIndex = -1
        lblTempEnt.Text = ""
        lblTempResultado.Text = ""

        ImgTemp.Visible = True
    End Sub
End Class