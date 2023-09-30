Public Class Form1
    Private Sub Form1_Clik(sender As Object, e As EventArgs) Handles LongiPic.Click

        'Aqui creamos los objetos para abrir el formulario desde el form principal
        Dim longitudFormulario As New LongitudFormulario()
        longitudFormulario.Show()
    End Sub

    Private Sub masaPic_Click(sender As Object, e As EventArgs) Handles masaPic.Click


        Dim formularioMasa As New MasaFormulario()
        formularioMasa.Show()
    End Sub
End Class
