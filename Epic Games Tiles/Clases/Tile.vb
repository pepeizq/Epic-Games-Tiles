Public Class Tile

    Public Titulo As String
    Public ID As String
    Public Enlace As String

    Public ImagenFondo As String
    Public ImagenLogo As String

    Public Sub New(ByVal titulo As String, ByVal id As String, ByVal enlace As String,
                   ByVal imagenFondo As String, ByVal imagenLogo As String)
        Me.Titulo = titulo
        Me.ID = id
        Me.Enlace = enlace

        Me.ImagenFondo = imagenFondo
        Me.ImagenLogo = imagenLogo
    End Sub
End Class