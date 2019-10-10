Imports Microsoft.Toolkit.Uwp.Helpers
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Newtonsoft.Json
Imports Windows.Storage
Imports Windows.Storage.AccessCache
Imports Windows.Storage.Pickers
Imports Windows.UI
Imports Windows.UI.Core
Imports Windows.UI.Xaml.Media.Animation

Module EpicGames

    Public Async Sub Generar(boolBuscarCarpeta As Boolean)

        Dim modo As Integer = ApplicationData.Current.LocalSettings.Values("modo_tiles")

        Dim helper As New LocalObjectStorageHelper

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim spProgreso As StackPanel = pagina.FindName("spProgreso")
        spProgreso.Visibility = Visibility.Visible

        Dim tbProgreso As TextBlock = pagina.FindName("tbProgreso")
        tbProgreso.Text = String.Empty

        Dim cbTiles As ComboBox = pagina.FindName("cbConfigModosTiles")
        cbTiles.IsEnabled = False

        Dim sp1 As StackPanel = pagina.FindName("spModoTile1")
        sp1.IsHitTestVisible = False

        Dim botonCache As Button = pagina.FindName("botonConfigLimpiarCache")
        botonCache.IsEnabled = False

        Dim gv As GridView = pagina.FindName("gridViewTiles")
        gv.Items.Clear()

        Dim listaJuegos As New List(Of Tile)

        If Await helper.FileExistsAsync("juegos" + modo.ToString) = True Then
            listaJuegos = Await helper.ReadFileAsync(Of List(Of Tile))("juegos" + modo.ToString)
        End If

        If modo = 0 Then
            Dim botonAñadirCarpetaTexto As TextBlock = pagina.FindName("botonAñadirCarpetaTexto")
            Dim botonCarpetaTexto As TextBlock = pagina.FindName("tbConfigCarpeta")

            Dim carpeta As StorageFolder = Nothing

            Try
                If boolBuscarCarpeta = True Then
                    Dim carpetapicker As New FolderPicker()

                    carpetapicker.FileTypeFilter.Add("*")
                    carpetapicker.ViewMode = PickerViewMode.List

                    carpeta = Await carpetapicker.PickSingleFolderAsync()
                Else
                    carpeta = Await StorageApplicationPermissions.FutureAccessList.GetFolderAsync("EpicGamesCarpeta")
                End If
            Catch ex As Exception

            End Try

            If Not carpeta Is Nothing Then
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

                Dim listaBBDD As List(Of EpicGamesBBDDEntrada) = EpicGamesBBDD.Listado

                Dim i As Integer = 0
                For Each juegoBBDD In listaBBDD
                    Dim añadir As Boolean = True

                    For Each juegoGuardado In listaJuegos
                        If juegoGuardado.ID = juegoBBDD.ID Then
                            añadir = False
                        End If
                    Next

                    If añadir = True Then
                        For Each juegoInstalado In listaInstalado
                            If juegoInstalado.ToLower = juegoBBDD.ID.ToLower Then
                                Dim html As String = Await Decompiladores.HttpClient(New Uri("https://www.epicgames.com/store/en-US/api/content/products/" + juegoBBDD.Enlace))

                                If Not html = Nothing Then
                                    Dim juegoEpic As EpicGamesJuego = JsonConvert.DeserializeObject(Of EpicGamesJuego)(html)

                                    Dim titulo As String = juegoEpic.Titulo

                                    Dim urlImagenFondo As String = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoHorizontal, juegoBBDD.ID, "fondo")

                                    If urlImagenFondo = Nothing Then
                                        urlImagenFondo = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Capturas(1), juegoBBDD.ID, "fondo")
                                    End If

                                    Dim urlImagenLogo As String = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Logo.Url, juegoBBDD.ID, "logo")

                                    If Not urlImagenFondo = Nothing Or Not urlImagenLogo = Nothing Then
                                        Dim juego As New Tile(titulo, juegoBBDD.ID, "com.epicgames.launcher://apps/" + juegoBBDD.ID + "?action=launch&silent=true",
                                                 urlImagenFondo, urlImagenLogo)
                                        listaJuegos.Add(juego)
                                    End If
                                End If
                            End If

                            tbProgreso.Text = i.ToString + "/" + listaInstalado.Count.ToString
                            i += 1
                        Next
                    End If
                Next

                If listaJuegos.Count > 0 Then
                    StorageApplicationPermissions.FutureAccessList.AddOrReplace("EpicGamesCarpeta", carpeta)
                    botonCarpetaTexto.Text = carpeta.Path
                    botonAñadirCarpetaTexto.Text = recursos.GetString("Change")
                End If
            End If
        ElseIf modo = 1 Then
            Dim listaBBDD As List(Of EpicGamesBBDDEntrada) = EpicGamesBBDD.Listado

            Dim i As Integer = 0
            For Each juegoBBDD In listaBBDD
                Dim añadir As Boolean = True

                If Not listaJuegos Is Nothing Then
                    For Each juegoGuardado In listaJuegos
                        If juegoGuardado.ID = juegoBBDD.ID Then
                            añadir = False
                        End If
                    Next
                End If

                If añadir = True Then
                    Dim html As String = Await Decompiladores.HttpClient(New Uri("https://www.epicgames.com/store/en-US/api/content/products/" + juegoBBDD.Enlace))

                    If Not html = Nothing Then
                        Dim juegoEpic As EpicGamesJuego = JsonConvert.DeserializeObject(Of EpicGamesJuego)(html)

                        Dim titulo As String = juegoEpic.Titulo

                        Dim urlImagenFondo As String = String.Empty

                        Try
                            urlImagenFondo = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoHorizontal, juegoBBDD.ID, "fondo")
                        Catch ex As Exception

                        End Try

                        If urlImagenFondo = Nothing Then
                            Try
                                urlImagenFondo = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Capturas(1), juegoBBDD.ID, "fondo")
                            Catch ex As Exception

                            End Try
                        End If

                        Dim urlImagenLogo As String = String.Empty

                        Try
                            urlImagenLogo = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Logo.Url, juegoBBDD.ID, "logo")
                        Catch ex As Exception

                        End Try

                        If Not urlImagenFondo = Nothing Or Not urlImagenLogo = Nothing Then
                            Dim juego As New Tile(titulo, juegoBBDD.ID, "com.epicgames.launcher://apps/" + juegoBBDD.ID + "?action=launch&silent=true",
                                                 urlImagenFondo, urlImagenLogo)
                            listaJuegos.Add(juego)
                        End If
                    End If
                End If

                tbProgreso.Text = i.ToString + "/" + listaBBDD.Count.ToString
                i += 1
            Next
        End If

        Await helper.SaveFileAsync(Of List(Of Tile))("juegos" + modo.ToString, listaJuegos)

        spProgreso.Visibility = Visibility.Collapsed

        Dim panelNoJuegos As Grid = pagina.FindName("panelAvisoNoJuegos")
        Dim gridSeleccionar As Grid = pagina.FindName("gridSeleccionarJuego")

        If listaJuegos.Count > 0 Then
            panelNoJuegos.Visibility = Visibility.Collapsed
            gridSeleccionar.Visibility = Visibility.Visible

            gv.Visibility = Visibility.Visible

            listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

            gv.Items.Clear()

            For Each juego In listaJuegos
                Dim gridImagen As New Grid With {
                    .Width = 322,
                    .Height = 187
                }

                Dim imagenFondo As New ImageEx With {
                    .Source = juego.ImagenFondo,
                    .IsCacheEnabled = True,
                    .Stretch = Stretch.UniformToFill
                }

                gridImagen.Children.Add(imagenFondo)

                Dim imagenLogo As New ImageEx With {
                    .Source = juego.ImagenLogo,
                    .IsCacheEnabled = True,
                    .Stretch = Stretch.Uniform,
                    .VerticalAlignment = VerticalAlignment.Center,
                    .HorizontalAlignment = HorizontalAlignment.Center,
                    .MaxWidth = 180,
                    .MaxHeight = 110
                }

                gridImagen.Children.Add(imagenLogo)

                Dim boton As New Button With {
                    .Tag = juego,
                    .Content = gridImagen,
                    .Padding = New Thickness(0, 0, 0, 0),
                    .BorderThickness = New Thickness(1, 1, 1, 1),
                    .BorderBrush = New SolidColorBrush(Colors.Black),
                    .Background = New SolidColorBrush(Colors.Transparent)
                }

                Dim tbToolTip As TextBlock = New TextBlock With {
                    .Text = juego.Titulo,
                    .FontSize = 16
                }

                ToolTipService.SetToolTip(boton, tbToolTip)
                ToolTipService.SetPlacement(boton, PlacementMode.Mouse)

                AddHandler boton.Click, AddressOf BotonTile_Click
                AddHandler boton.PointerEntered, AddressOf UsuarioEntraBoton
                AddHandler boton.PointerExited, AddressOf UsuarioSaleBoton

                gv.Items.Add(boton)
            Next

            If boolBuscarCarpeta = True Then
                Toast(listaJuegos.Count.ToString + " " + recursos.GetString("GamesDetected"), Nothing)
            End If
        Else
            panelNoJuegos.Visibility = Visibility.Visible
            gridSeleccionar.Visibility = Visibility.Collapsed

            gv.Visibility = Visibility.Collapsed
        End If

        cbTiles.IsEnabled = True
        sp1.IsHitTestVisible = True
        botonCache.IsEnabled = True

    End Sub

    Private Async Sub BotonTile_Click(sender As Object, e As RoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonJuego As Button = e.OriginalSource
        Dim juego As Tile = botonJuego.Tag

        Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")
        botonAñadirTile.Tag = juego

        Dim resultado As New RenderTargetBitmap()
        Await resultado.RenderAsync(botonJuego.Content)

        Dim imagenJuegoSeleccionado As ImageEx = pagina.FindName("imagenJuegoSeleccionado")
        imagenJuegoSeleccionado.Source = resultado

        Dim tbJuegoSeleccionado As TextBlock = pagina.FindName("tbJuegoSeleccionado")
        tbJuegoSeleccionado.Text = juego.Titulo

        Dim gridAñadir As Grid = pagina.FindName("gridAñadirTile")
        gridAñadir.Visibility = Visibility.Visible

        ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("tile", botonJuego)

        Dim animacion As ConnectedAnimation = ConnectedAnimationService.GetForCurrentView().GetAnimation("tile")

        If Not animacion Is Nothing Then
            animacion.TryStart(gridAñadir)
        End If

        Dim tbTitulo As TextBlock = pagina.FindName("tbTitulo")
        tbTitulo.Text = Package.Current.DisplayName + " (" + Package.Current.Id.Version.Major.ToString + "." + Package.Current.Id.Version.Minor.ToString + "." + Package.Current.Id.Version.Build.ToString + "." + Package.Current.Id.Version.Revision.ToString + ") - " + juego.Titulo

        '---------------------------------------------

        Dim titulo1 As TextBlock = pagina.FindName("tituloTileAnchaEnseñar")
        Dim titulo2 As TextBlock = pagina.FindName("tituloTileAnchaPersonalizar")

        Dim titulo3 As TextBlock = pagina.FindName("tituloTileGrandeEnseñar")
        Dim titulo4 As TextBlock = pagina.FindName("tituloTileGrandePersonalizar")

        titulo1.Text = juego.Titulo
        titulo2.Text = juego.Titulo

        titulo3.Text = juego.Titulo
        titulo4.Text = juego.Titulo

        If Not juego.ImagenFondo Is Nothing Then
            Dim imagenPequeña1 As ImageEx = pagina.FindName("imagenTilePequeñaEnseñar")
            Dim imagenPequeña2 As ImageEx = pagina.FindName("imagenTilePequeñaGenerar")
            Dim imagenPequeña3 As ImageEx = pagina.FindName("imagenTilePequeñaPersonalizar")

            imagenPequeña1.Source = juego.ImagenFondo
            imagenPequeña2.Source = juego.ImagenFondo
            imagenPequeña3.Source = juego.ImagenFondo

            imagenPequeña1.Tag = juego.ImagenFondo
            imagenPequeña2.Tag = juego.ImagenFondo
            imagenPequeña3.Tag = juego.ImagenFondo

            Dim imagenMediana1 As ImageEx = pagina.FindName("imagenTileMedianaEnseñar")
            Dim imagenMediana2 As ImageEx = pagina.FindName("imagenTileMedianaGenerar")
            Dim imagenMediana3 As ImageEx = pagina.FindName("imagenTileMedianaPersonalizar")

            imagenMediana1.Source = juego.ImagenFondo
            imagenMediana2.Source = juego.ImagenFondo
            imagenMediana3.Source = juego.ImagenFondo

            imagenMediana1.Tag = juego.ImagenFondo
            imagenMediana2.Tag = juego.ImagenFondo
            imagenMediana3.Tag = juego.ImagenFondo

            Dim imagenAncha1 As ImageEx = pagina.FindName("imagenTileAnchaEnseñar")
            Dim imagenAncha2 As ImageEx = pagina.FindName("imagenTileAnchaGenerar")
            Dim imagenAncha3 As ImageEx = pagina.FindName("imagenTileAnchaPersonalizar")

            imagenAncha1.Source = resultado
            imagenAncha2.Source = resultado
            imagenAncha3.Source = resultado

            imagenAncha1.Tag = juego.ImagenFondo
            imagenAncha2.Tag = juego.ImagenFondo
            imagenAncha3.Tag = juego.ImagenFondo

            Dim imagenGrande1 As ImageEx = pagina.FindName("imagenTileGrandeEnseñar")
            Dim imagenGrande2 As ImageEx = pagina.FindName("imagenTileGrandeGenerar")
            Dim imagenGrande3 As ImageEx = pagina.FindName("imagenTileGrandePersonalizar")

            imagenGrande1.Source = juego.ImagenFondo
            imagenGrande2.Source = juego.ImagenFondo
            imagenGrande3.Source = juego.ImagenFondo

            imagenGrande1.Tag = juego.ImagenFondo
            imagenGrande2.Tag = juego.ImagenFondo
            imagenGrande3.Tag = juego.ImagenFondo
        End If

    End Sub

    Private Sub UsuarioEntraBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Hand, 1)

    End Sub

    Private Sub UsuarioSaleBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Arrow, 1)

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
