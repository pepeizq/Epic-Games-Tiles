Public Class Tile

    Public Titulo As String
    Public ID As String
    Public Enlace As String

    Public ImagenPequeña As Grid
    Public ImagenMediana As Grid
    Public ImagenAncha As Grid
    Public ImagenGrande As Grid

    Public Sub New(ByVal titulo As String, ByVal id As String, ByVal enlace As String,
                   ByVal imagenPequeña As Grid, ByVal imagenMediana As Grid, ByVal imagenAncha As Grid, ByVal imagenGrande As Grid)
        Me.Titulo = titulo
        Me.ID = id
        Me.Enlace = enlace

        Me.ImagenPequeña = imagenPequeña
        Me.ImagenMediana = imagenMediana
        Me.ImagenAncha = imagenAncha
        Me.ImagenGrande = imagenGrande
    End Sub
End Class
