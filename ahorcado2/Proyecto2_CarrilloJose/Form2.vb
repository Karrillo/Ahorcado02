Imports System.IO
Public Class Juego

    Public Palabras(14) As String 'contiene las palabras del .txt
    Public Letras(11) As Char 'contiene la palabra elegida por el random en char
    Dim Simbolos(11) As Char 'contiene la misma cantidad de "_" q caracteres de la palabra
    Public cantidad As Byte 'contiene la cantidad de caracteres tiene la palabra
    Public vidas As Byte = 4
    Public elegida As Byte 'variable para el random
    Public palabra As String 'contiene la palabras elegida
    Public vec As Boolean = False 'variable que indica si tiene todas las 15 palabras 

    'Inicio del juego
    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click

        Extraer()

        If vec = False Then
            juego()
        Else
            Close()
        End If

        btn_inicio.Enabled = False
    End Sub

    'Proceso del juego para comenzar 
    Public Sub juego()

        'random
        Dim aleatorio As New Random
        Dim elegida As Byte = aleatorio.Next(0, 14)



        'cuenta los caracteres que tiene la palabra escogida por el random
        cantidad = Palabras(elegida).Length

        'convierte la palabra en una cadena de caracteres
        Letras = Palabras(elegida).ToCharArray

        'agrega la palabra elegida
        palabra = Palabras(elegida)

        'agrega un "_" por cada caracter que contenga la palabra
        For x = 0 To cantidad - 1
            Simbolos(x) = "_"
        Next

        'imprime en un label los "_"
        simbolo()

        'imprime en un label las vidas
        lb_vidas.Text = "Vidas: " & vidas

        'habilita el boton para agregar letras
        btn_letra.Enabled = True
    End Sub

    'Extraer las palabras del .txt al arreglo
    Public Sub Extraer()
        Dim Palabra As String 'guarda la palabra para luego guardarla en el arreglo
        Dim x As Byte 'contador

        If File.Exists("E:\Palabras.txt") = False Then 'pregunta si el .txt existe
            MsgBox("El .TxT aun no es creado", MessageBoxIcon.Error, " Mensaje de error")
            vec = True
        Else
            'si es creado abre el .txt 
            Dim ruta As New StreamReader("E:\Palabras.txt") 'crea la ruta para el txt
            Dim lineas() As String = File.ReadAllLines("E:\Palabras.txt")


            'si el txt no tiene 15 palabras=lineas da error
            If lineas.Length < 15 Then
                MsgBox("Aun no tiene las 15 palabras Guardadas", MessageBoxIcon.Error, " Mensaje de error")
                vec = True
            Else
                'si tiene las 15 lineas abre el archivo y agrega las palabras al arreglo
                Do While x < 15
                    Palabra = ruta.ReadLine() 'extrae la palabra del .txt
                    Palabras(x) = Palabra 'ingresa la palabra en el arreglo
                    x += 1
                Loop
                ruta.Close() 'tierra el archivo
            End If
        End If

    End Sub

    'Imprime en el label
    Public Sub simbolo()

        'variable donde se guarda lo q contenga el arreglo simbolos para imprimirlo en el label
        Dim texto As String = ""

        For x = 0 To cantidad - 1
            texto = texto & Simbolos(x) 'texto es igual a lo que contiene el arreglo simbolos
            texto = texto & " " 'agrega un espacio entre el caracter que contenga simbolos
        Next

        lb_letras.Text = texto
    End Sub

    'Proceso para que solo permita letras
    Private Sub txt_letra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_letra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Encontrado la palabra
    Private Sub btn_letra_Click(sender As Object, e As EventArgs) Handles btn_letra.Click

        Dim letra As Char 'contiene el caracter que ingresa en la caja de texto
        Dim verificar As Boolean = False
        letra = txt_letra.Text

        'verifica una por una
        If txt_letra.Text <> "" Then

            For x = 0 To cantidad - 1
                'la letra ingresada la compara con las del arreglo char de la palabra
                If Letras(x) = letra Then 'si la encuentra sustituye "_" por la letra
                    Simbolos(x) = letra

                    simbolo()

                    verificar = True
                End If
            Next

            'si no encuentra una letra igual
            If verificar = False Then
                MsgBox("Letra Equivocada", MessageBoxIcon.Information, " Mensaje Informativo")
                vidas = vidas - 1
                List_error.Items.Add(letra)
                'hace visible las imagenes que se encuentran ocultas 
                If vidas = 3 Then
                    Ahorcado4.Visible = True
                ElseIf vidas = 2 Then
                    Ahorcado3.Visible = True
                    Ahorcado4.Visible = False
                ElseIf vidas = 1 Then
                    Ahorcado2.Visible = True
                    Ahorcado3.Visible = False
                ElseIf vidas = 0 Then
                    Ahorcado1.Visible = True
                    Ahorcado2.Visible = False
                End If

            Else

                MsgBox("Acerto", MessageBoxIcon.Information, " Mensaje Informativo")

            End If

        End If


        'si las vidas llega a 0 muentra un mensaje q perdio y habilita el boton de reinicio
        If vidas = 0 Then
            MsgBox("Perdistes !!! La palabra era: " & palabra, MessageBoxIcon.Information, " Mensaje Informativo")

            btn_reinicio.Visible = True
            btn_letra.Enabled = False

        End If

        'si con contiene "_" Gana
        If Simbolos.Contains("_") = False Then
            MsgBox("Felicidades!! Has GANADO !!!", MessageBoxIcon.Information, " Mensaje Informativo")

            btn_reinicio.Visible = True
            btn_letra.Enabled = False

        End If

        lb_vidas.Text = "Vidas: " & vidas
        txt_letra.Text = ""
        txt_letra.Focus()

    End Sub

    'Reinicio
    Private Sub btn_reinicio_Click(sender As Object, e As EventArgs) Handles btn_reinicio.Click
        txt_letra.Text = "" 'limpia el txtbox 
        txt_letra.Focus()

        vidas = 4 'vuelve las vidas a lo original

        'limpia el arreglo de simbolos
        For x = 0 To cantidad - 1
            Simbolos(x) = ""
        Next

        juego()
        simbolo()

        btn_letra.Enabled = True 'habilita el boton para ingresar letras

        'hace invidible todas las imagines a lo original
        Ahorcado1.Visible = False
        Ahorcado2.Visible = False
        Ahorcado3.Visible = False
        Ahorcado4.Visible = False

    End Sub


End Class