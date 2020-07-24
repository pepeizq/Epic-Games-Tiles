Public Class Tile

    Public Titulo As String
    Public ID As String
    Public Enlace As String

    Public ImagenHorizontal As String
    Public ImagenVertical As String
    Public ImagenLogo As String

    Public Sub New(ByVal titulo As String, ByVal id As String, ByVal enlace As String,
                   ByVal imagenHorizontal As String, ByVal imagenVertical As String, ByVal imagenLogo As String)
        Me.Titulo = titulo
        Me.ID = id
        Me.Enlace = enlace

        Me.ImagenHorizontal = imagenHorizontal
        Me.ImagenVertical = imagenVertical
        Me.ImagenLogo = imagenLogo
    End Sub
End Class