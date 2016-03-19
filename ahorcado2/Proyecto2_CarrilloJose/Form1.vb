Public Class Cargar_Palabras

    'variable que lleva la cuenta de las palabras ingresadas
    Public contador As Byte

    'creacion del .txt
    Public Ruta As IO.StreamWriter


        'Agregar palabras a la lista
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Txt_palabras.Text <> "" Then 'si esta vacio no entra
            If Txt_palabras.Text.Length >= 6 Then 'si la palabra es menor a 6 no entra
                Lista_palabras.Items.Add(Txt_palabras.Text) 'agrega una palabra en la lista
                contador = contador + 1 'aumenta el contador para indicar cuantas palabras ha incresado
                Txt_palabras.Text = "" 'limpia la caja de texto
                lb_contador.Text = "Palabras: " & contador 'actualiza el label con la cantidad de palabras que lleva ingresadas
            End If
        End If
        Txt_palabras.Focus()

        'cuando cumpre el requisito de 15 palabras se bloquea el boton
        If contador = 15 Then
            btn_agregar.Enabled = False
        End If
    End Sub

    'Eliminar palabras de la lista
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        If Lista_palabras.SelectedItem <> "" Then 'si seleciona una palabra entra el "if"
            Lista_palabras.Items.Remove(Lista_palabras.SelectedItem) 'elimina una palabra de la lista
            contador = contador - 1 'disminuye el contador para indicar cuantas palabras ha incresado
            lb_contador.Text = "Palabras: " & contador 'actualiza el label con la cantidad de palabras que lleva ingresadas
            btn_agregar.Enabled = True 'activa el boton de ingresar denuevo
        End If
    End Sub

    'Crea un archivo .txt 
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim x As Byte 'contador

        If contador = 15 Then

            Ruta = New IO.StreamWriter("E:\Palabras.txt") 'crea el archivo .txt

            'incresa las palabras al .txt
            For x = 0 To Lista_palabras.Items.Count - 1
                Ruta.WriteLine(Lista_palabras.Items(x))
            Next

            Ruta.Close() 'cierra el archivo

            MessageBox.Show("Guardado con exito")
        Else
            MsgBox("Alerta: Debe ingresar las 15 palabras", MsgBoxStyle.Exclamation, "Mensaje de error")
        End If
    End Sub

    'Proceso para que solo permita Letras en el text box
    Private Sub Txt_palabras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_palabras.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class
