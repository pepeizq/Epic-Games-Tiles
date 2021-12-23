Imports Epic_Games_Tiles.Configuracion
Imports Microsoft.Toolkit.Uwp.Helpers
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Newtonsoft.Json
Imports Windows.Storage
Imports Windows.Storage.AccessCache
Imports Windows.Storage.FileProperties
Imports Windows.Storage.Pickers
Imports Windows.UI
Imports Windows.UI.Xaml.Media.Animation

Module EpicGames

    Public anchoColumna As Integer = 180
    Dim clave As String = "EpicGamesCarpeta"
    Dim dominioImagenes As String = "https://cdn.cloudflare.steamstatic.com"

    Public Async Sub Generar(buscarCarpeta As Boolean)

        Dim modo As Integer = ApplicationData.Current.LocalSettings.Values("modo_tiles")

        Dim helper As New LocalObjectStorageHelper

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim pbProgreso As ProgressBar = pagina.FindName("pbProgreso")
        pbProgreso.Value = 0

        Dim tbProgreso As TextBlock = pagina.FindName("tbProgreso")
        tbProgreso.Text = String.Empty

        General.Estado(False)
        Cache.Estado(False)
        LimpiezaArchivos.Estado(False)

        Dim gv As AdaptiveGridView = pagina.FindName("gvTiles")
        gv.DesiredWidth = anchoColumna
        gv.Items.Clear()

        Dim listaJuegos As New List(Of Tile)
        Dim carpetaFicheros As StorageFolder = Nothing
        Dim errorCarpeta As Boolean = False

        Try
            carpetaFicheros = Await StorageFolder.GetFolderFromPathAsync(ApplicationData.Current.LocalFolder.Path + "\Juegos")
        Catch ex As Exception
            errorCarpeta = True
        End Try

        If errorCarpeta = True Then
            Try
                Await ApplicationData.Current.LocalFolder.CreateFolderAsync("Juegos", CreationCollisionOption.ReplaceExisting)
                carpetaFicheros = Await StorageFolder.GetFolderFromPathAsync(ApplicationData.Current.LocalFolder.Path + "\Juegos")
            Catch ex As Exception

            End Try
        End If

        If Not carpetaFicheros Is Nothing Then
            Dim listaFicheros As IReadOnlyList(Of IStorageItem) = Await carpetaFicheros.GetFilesAsync

            If Not listaFicheros Is Nothing Then
                If listaFicheros.Count > 0 Then
                    For Each fichero In listaFicheros
                        Dim propiedades As BasicProperties = Await fichero.GetBasicPropertiesAsync

                        If propiedades.Size > 0 Then
                            If fichero.Name.Contains("juego_") Then
                                Dim temp As Tile = Await helper.ReadFileAsync(Of Tile)("Juegos\" + fichero.Name)
                                listaJuegos.Add(temp)
                            End If
                        End If
                    Next
                End If
            End If
        End If

        If listaJuegos Is Nothing Then
            listaJuegos = New List(Of Tile)
        End If

        If modo = 0 Then
            Dim carpeta As StorageFolder = Nothing

            Try
                If buscarCarpeta = True Then
                    Dim carpetapicker As New FolderPicker()

                    carpetapicker.FileTypeFilter.Add("*")
                    carpetapicker.ViewMode = PickerViewMode.List

                    carpeta = Await carpetapicker.PickSingleFolderAsync()
                Else
                    carpeta = Await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(clave)
                End If
            Catch ex As Exception

            End Try

            If Not carpeta Is Nothing Then
                Dim gridProgreso As Grid = pagina.FindName("gridProgreso")
                Interfaz.Pestañas.Visibilidad(gridProgreso, Nothing, Nothing)

                Dim listaInstalado As New List(Of String)

                Dim subcarpetas1 As IReadOnlyList(Of StorageFolder) = Await carpeta.GetFoldersAsync()

                For Each subcarpeta1 As StorageFolder In subcarpetas1
                    If subcarpeta1.DisplayName.ToLower = "unrealenginelauncher" Then
                        Dim ficheros As IReadOnlyList(Of StorageFile) = Await subcarpeta1.GetFilesAsync()

                        For Each fichero As StorageFile In ficheros
                            If fichero.Name.ToLower = "launcherinstalled.dat" Then
                                Dim datosTexto As String = Await FileIO.ReadTextAsync(fichero)
                                Dim juegos As EpicGamesInstalado = JsonConvert.DeserializeObject(Of EpicGamesInstalado)(datosTexto)

                                For Each juego In juegos.Lista
                                    listaInstalado.Add(juego.Juego)
                                Next
                            End If
                        Next
                    End If
                Next

                Dim listaBBDD As List(Of EpicGamesBBDDJuego) = EpicGamesBBDD.Listado

                Dim i As Integer = 0
                For Each juegoBBDD In listaBBDD
                    Dim añadir As Boolean = True

                    For Each juegoGuardado In listaJuegos
                        If juegoGuardado.IDEpic = juegoBBDD.IDEpic Then
                            añadir = False
                        End If
                    Next

                    If añadir = True Then
                        For Each juegoInstalado In listaInstalado
                            If juegoInstalado.ToLower = juegoBBDD.IDEpic.ToLower Then
                                listaJuegos.Add(Await AñadirJuego(juegoBBDD))
                            End If

                            pbProgreso.Value = CInt((100 / listaInstalado.Count) * i)
                            tbProgreso.Text = i.ToString + "/" + listaInstalado.Count.ToString
                            i += 1
                        Next
                    End If
                Next

                If listaJuegos.Count > 0 Then
                    StorageApplicationPermissions.FutureAccessList.AddOrReplace(clave, carpeta)
                End If
            End If
        ElseIf modo = 1 Then
            Dim gridProgreso As Grid = pagina.FindName("gridProgreso")
            Interfaz.Pestañas.Visibilidad(gridProgreso, Nothing, Nothing)

            Dim listaBBDD As List(Of EpicGamesBBDDJuego) = EpicGamesBBDD.Listado

            Dim i As Integer = 0
            For Each juegoBBDD In listaBBDD
                Dim añadir As Boolean = True

                If Not listaJuegos Is Nothing Then
                    For Each juegoGuardado In listaJuegos
                        If Not juegoGuardado Is Nothing Then
                            If juegoGuardado.IDEpic = juegoBBDD.IDEpic Then
                                añadir = False
                            End If
                        End If
                    Next
                End If

                If añadir = True Then
                    listaJuegos.Add(Await AñadirJuego(juegoBBDD))
                End If

                pbProgreso.Value = CInt((100 / listaBBDD.Count) * i)
                tbProgreso.Text = i.ToString + "/" + listaBBDD.Count.ToString
                i += 1
            Next
        End If

        Dim resultadosBusqueda As New List(Of Interfaz.BusquedaFichero)

        If Not listaJuegos Is Nothing Then
            If listaJuegos.Count > 0 Then
                For Each juego In listaJuegos
                    If Not juego Is Nothing Then
                        Try
                            If Await helper.FileExistsAsync("Juegos\juego_" + juego.IDEpic) = False Then
                                Await helper.SaveFileAsync(Of Tile)("Juegos\juego_" + juego.IDEpic, juego)
                            End If
                        Catch ex As Exception

                        End Try

                        resultadosBusqueda.Add(New Interfaz.BusquedaFichero(juego.Titulo, "Juegos\juego_" + juego.IDEpic))
                    End If
                Next
            End If
        End If

        Try
            Await helper.SaveFileAsync(Of List(Of Interfaz.BusquedaFichero))("busqueda", resultadosBusqueda)
        Catch ex As Exception

        End Try

        If Not listaJuegos Is Nothing Then
            If listaJuegos.Count > 0 Then
                Dim gridJuegos As Grid = pagina.FindName("gridJuegos")
                Interfaz.Pestañas.Visibilidad(gridJuegos, recursos.GetString("Games"), Nothing)

                listaJuegos.Sort(Function(x, y)
                                     If Not x Is Nothing Then
                                         If Not y Is Nothing Then
                                             Return x.Titulo.CompareTo(y.Titulo)
                                         End If
                                     End If

                                     If Not x Is Nothing Then
                                         Return x.Titulo
                                     End If

                                     If Not y Is Nothing Then
                                         Return y.Titulo
                                     End If

                                     Return Nothing
                                 End Function)

                gv.Items.Clear()

                For Each juego In listaJuegos
                    BotonEstilo(juego, gv)
                Next
            Else
                Dim gridAvisoNoJuegos As Grid = pagina.FindName("gridAvisoNoJuegos")
                Interfaz.Pestañas.Visibilidad(gridAvisoNoJuegos, Nothing, Nothing)
            End If
        Else
            Dim gridAvisoNoJuegos As Grid = pagina.FindName("gridAvisoNoJuegos")
            Interfaz.Pestañas.Visibilidad(gridAvisoNoJuegos, Nothing, Nothing)
        End If

        General.Estado(True)
        Cache.Estado(True)
        LimpiezaArchivos.Estado(True)

    End Sub

    Private Async Function AñadirJuego(juegoBBDD As EpicGamesBBDDJuego) As Task(Of Tile)

        Dim titulo As String = juegoBBDD.Titulo
        titulo = titulo.Trim

        Dim imagenPequeña As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDEpic, "pequeña")
        Dim imagenMediana As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDEpic, "mediana")
        Dim imagenAncha As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDEpic, "ancha")
        Dim imagenGrande As String = Await Cache.DescargarImagen(Nothing, juegoBBDD.IDEpic, "grande")

        If Not juegoBBDD.IDSteam = Nothing Then
            If imagenMediana = String.Empty Then
                Try
                    imagenMediana = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/logo.png", juegoBBDD.IDEpic, "mediana")
                Catch ex As Exception

                End Try
            End If

            If imagenAncha = String.Empty Then
                Try
                    imagenAncha = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/header.jpg", juegoBBDD.IDEpic, "ancha")
                Catch ex As Exception

                End Try
            End If

            If imagenGrande = String.Empty Then
                Try
                    imagenGrande = Await Cache.DescargarImagen(dominioImagenes + "/steam/apps/" + juegoBBDD.IDSteam + "/library_600x900.jpg", juegoBBDD.IDEpic, "grande")
                Catch ex As Exception

                End Try
            End If
        End If

        Dim juego As New Tile(titulo, juegoBBDD.IDEpic, juegoBBDD.IDSteam, "com.epicgames.launcher://apps/" + juegoBBDD.IDEpic + "?action=launch&silent=true",
                              imagenPequeña, imagenMediana, imagenAncha, imagenGrande)
        Return juego

    End Function

    Public Sub BotonEstilo(juego As Tile, gv As GridView)

        Dim imagen As New ImageEx With {
            .Source = juego.ImagenGrande,
            .IsCacheEnabled = True,
            .Stretch = Stretch.UniformToFill,
            .Padding = New Thickness(0, 0, 0, 0),
            .HorizontalAlignment = HorizontalAlignment.Center,
            .VerticalAlignment = VerticalAlignment.Center,
            .EnableLazyLoading = True
        }

        Dim boton As New Button With {
            .Tag = juego,
            .Content = imagen,
            .Padding = New Thickness(0, 0, 0, 0),
            .Background = New SolidColorBrush(Colors.Transparent),
            .Margin = New Thickness(10, 10, 10, 10),
            .MinHeight = 40,
            .MinWidth = 40,
            .MaxWidth = anchoColumna + 20,
            .BorderBrush = New SolidColorBrush(App.Current.Resources("ColorPrimario")),
            .BorderThickness = New Thickness(1, 1, 1, 1),
            .HorizontalAlignment = HorizontalAlignment.Center,
            .VerticalAlignment = VerticalAlignment.Center
        }

        Dim tbToolTip As TextBlock = New TextBlock With {
            .Text = juego.Titulo,
            .FontSize = 16,
            .TextWrapping = TextWrapping.Wrap
        }

        ToolTipService.SetToolTip(boton, tbToolTip)
        ToolTipService.SetPlacement(boton, PlacementMode.Mouse)

        AddHandler boton.Click, AddressOf BotonTile_Click
        AddHandler boton.PointerEntered, AddressOf Interfaz.Entra_Boton_Imagen
        AddHandler boton.PointerExited, AddressOf Interfaz.Sale_Boton_Imagen

        gv.Items.Add(boton)

    End Sub

    Private Sub BotonTile_Click(sender As Object, e As RoutedEventArgs)

        Trial.Detectar()
        Interfaz.AñadirTile.ResetearValores()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonJuego As Button = e.OriginalSource
        Dim juego As Tile = botonJuego.Tag

        Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")
        botonAñadirTile.Tag = juego

        Dim imagenJuegoSeleccionado As ImageEx = pagina.FindName("imagenJuegoSeleccionado")
        imagenJuegoSeleccionado.Source = juego.ImagenAncha

        Dim tbJuegoSeleccionado As TextBlock = pagina.FindName("tbJuegoSeleccionado")
        tbJuegoSeleccionado.Text = juego.Titulo

        Dim gridAñadirTile As Grid = pagina.FindName("gridAñadirTile")
        Interfaz.Pestañas.Visibilidad(gridAñadirTile, juego.Titulo, Nothing)

        '---------------------------------------------

        ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("animacionJuego", botonJuego)
        Dim animacion As ConnectedAnimation = ConnectedAnimationService.GetForCurrentView().GetAnimation("animacionJuego")

        If Not animacion Is Nothing Then
            animacion.Configuration = New BasicConnectedAnimationConfiguration
            animacion.TryStart(gridAñadirTile)
        End If

        '---------------------------------------------

        Dim tbImagenTituloTextoTileAncha As TextBox = pagina.FindName("tbImagenTituloTextoTileAncha")
        tbImagenTituloTextoTileAncha.Text = juego.Titulo
        tbImagenTituloTextoTileAncha.Tag = juego.Titulo

        Dim tbImagenTituloTextoTileGrande As TextBox = pagina.FindName("tbImagenTituloTextoTileGrande")
        tbImagenTituloTextoTileGrande.Text = juego.Titulo
        tbImagenTituloTextoTileGrande.Tag = juego.Titulo

        '---------------------------------------------

        Dim imagenPequeña As ImageEx = pagina.FindName("imagenTilePequeña")
        imagenPequeña.Source = Nothing

        Dim imagenMediana As ImageEx = pagina.FindName("imagenTileMediana")
        imagenMediana.Source = Nothing

        Dim imagenAncha As ImageEx = pagina.FindName("imagenTileAncha")
        imagenAncha.Source = Nothing

        Dim imagenGrande As ImageEx = pagina.FindName("imagenTileGrande")
        imagenGrande.Source = Nothing

        If Not juego.ImagenPequeña = Nothing Then
            imagenPequeña.Source = juego.ImagenPequeña
            imagenPequeña.Tag = juego.ImagenPequeña
        End If

        If Not juego.ImagenMediana = Nothing Then
            imagenMediana.Source = juego.ImagenMediana
            imagenMediana.Tag = juego.ImagenMediana
        End If

        If Not juego.ImagenAncha = Nothing Then
            imagenAncha.Source = juego.ImagenAncha
            imagenAncha.Tag = juego.ImagenAncha
        End If

        If Not juego.ImagenGrande = Nothing Then
            imagenGrande.Source = juego.ImagenGrande
            imagenGrande.Tag = juego.ImagenGrande
        End If

    End Sub

    Public Async Sub Borrar()

        StorageApplicationPermissions.FutureAccessList.Clear()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim gv As AdaptiveGridView = pagina.FindName("gvTiles")
        gv.Items.Clear()

        Dim helper As New LocalObjectStorageHelper

        If Await helper.FileExistsAsync("juegos0") = True Then
            Dim listaJuegos As List(Of Tile) = Await helper.ReadFileAsync(Of List(Of Tile))("juegos0")
            listaJuegos.Clear()
            Await helper.SaveFileAsync(Of List(Of Tile))("juegos0", listaJuegos)
        End If

        If Await helper.FileExistsAsync("juegos1") = True Then
            Dim listaJuegos As List(Of Tile) = Await helper.ReadFileAsync(Of List(Of Tile))("juegos1")
            listaJuegos.Clear()
            Await helper.SaveFileAsync(Of List(Of Tile))("juegos1", listaJuegos)
        End If

        Dim carpetaFicheros As StorageFolder = ApplicationData.Current.LocalFolder

        Try
            carpetaFicheros = Await StorageFolder.GetFolderFromPathAsync(ApplicationData.Current.LocalFolder.Path + "\Juegos")
        Catch ex As Exception

        End Try

        If Not carpetaFicheros Is Nothing Then
            Await carpetaFicheros.DeleteAsync
        End If

    End Sub

End Module

'---------------------------------------------------

Public Class EpicGamesInstalado

    <JsonProperty("InstallationList")>
    Public Lista As List(Of EpicGamesInstaladoJuego)

End Class

Public Class EpicGamesInstaladoJuego

    <JsonProperty("AppName")>
    Public Juego As String

End Class

'---------------------------------------------------

Public Class EpicGamesDatos

    <JsonProperty("DisplayName")>
    Public Titulo As String

    <JsonProperty("CatalogNamespace")>
    Public ID As String

    <JsonProperty("Apps")>
    Public Apps As List(Of EpicGamesDatosApps)

End Class

Public Class EpicGamesDatosApps

    <JsonProperty("GroupId")>
    Public Tipo As String

    <JsonProperty("Name")>
    Public Nombre As String

    <JsonProperty("OfferId")>
    Public OfferID As String

End Class
