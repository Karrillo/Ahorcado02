Imports System.Windows.Forms

Public Class Proyecto
   

    Private Sub CargarLasPalabrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarLasPalabrasToolStripMenuItem.Click

        Cargar_Palabras.MdiParent = Me 'no deja salir del MDI
        Cargar_Palabras.Show() 'muestra el form

    End Sub

    Private Sub JugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem.Click

        Juego.MdiParent = Me 'no deja salir del MDI
        Juego.Show() 'muestra el form


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End 'salir
    End Sub
End Class
