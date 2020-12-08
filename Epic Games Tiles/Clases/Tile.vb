Public Class Tile

    Public Titulo As String
    Public IDEpic As String
    Public IDSteam As String
    Public Enlace As String

    Public ImagenPequeña As String
    Public ImagenMediana As String
    Public ImagenAncha As String
    Public ImagenGrande As String

    Public Sub New(ByVal titulo As String, ByVal idEpic As String, ByVal idSteam As String, ByVal enlace As String,
                   ByVal imagenPequeña As String, ByVal imagenMediana As String, ByVal imagenAncha As String, ByVal imagenGrande As String)
        Me.Titulo = titulo
        Me.IDEpic = idEpic
        Me.IDSteam = idSteam
        Me.Enlace = enlace

        Me.ImagenPequeña = imagenPequeña
        Me.ImagenMediana = imagenMediana
        Me.ImagenAncha = imagenAncha
        Me.ImagenGrande = imagenGrande
    End Sub
End Class