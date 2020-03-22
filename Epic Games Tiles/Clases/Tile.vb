Public Class Tile

    Public Titulo As String
    Public ID As String
    Public Enlace As String

    Public ImagenFondoHorizontal As String
    Public ImagenFondoVertical As String
    Public ImagenLogo As String

    Public Sub New(ByVal titulo As String, ByVal id As String, ByVal enlace As String,
                   ByVal imagenFondoHorizontal As String, ByVal imagenFondoVertical As String, ByVal imagenLogo As String)
        Me.Titulo = titulo
        Me.ID = id
        Me.Enlace = enlace

        Me.ImagenFondoHorizontal = imagenFondoHorizontal
        Me.ImagenFondoVertical = imagenFondoVertical
        Me.ImagenLogo = imagenLogo
    End Sub
End Class