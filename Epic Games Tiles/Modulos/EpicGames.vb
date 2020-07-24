Imports Microsoft.Toolkit.Uwp.Helpers
Imports Microsoft.Toolkit.Uwp.UI.Animations
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Newtonsoft.Json
Imports Windows.Storage
Imports Windows.Storage.AccessCache
Imports Windows.Storage.Pickers
Imports Windows.UI
Imports Windows.UI.Core
Imports Windows.UI.Xaml.Media.Animation

Module EpicGames

    Public anchoColumna As Integer = 213

    Public Async Sub Generar(boolBuscarCarpeta As Boolean)

        Dim modo As Integer = ApplicationData.Current.LocalSettings.Values("modo_tiles")

        Dim helper As New LocalObjectStorageHelper

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Cache.Estado(False)

        Dim spProgreso As StackPanel = pagina.FindName("spProgreso")
        spProgreso.Visibility = Visibility.Visible

        Dim pbProgreso As ProgressBar = pagina.FindName("pbProgreso")
        pbProgreso.Value = 0

        Dim tbProgreso As TextBlock = pagina.FindName("tbProgreso")
        tbProgreso.Text = String.Empty

        Dim cbTiles As ComboBox = pagina.FindName("cbConfigModosTiles")
        cbTiles.IsEnabled = False

        Dim sp1 As StackPanel = pagina.FindName("spModoTile1")
        sp1.IsHitTestVisible = False

        Dim gridSeleccionarJuego As Grid = pagina.FindName("gridSeleccionarJuego")
        gridSeleccionarJuego.Visibility = Visibility.Collapsed

        Dim gv As GridView = pagina.FindName("gvTiles")
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

                Dim listaBBDD As List(Of EpicGamesBBDDJuego) = EpicGamesBBDD.Listado

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

                                    AñadirJuego(juegoEpic, juegoBBDD, listaJuegos)
                                End If
                            End If

                            pbProgreso.Value = CInt((100 / listaInstalado.Count) * i)
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
            Dim listaBBDD As List(Of EpicGamesBBDDJuego) = EpicGamesBBDD.Listado

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
                    Dim html As String = Await Decompiladores.HttpClient(New Uri("https://store-content.ak.epicgames.com/api/en-US/content/products/" + juegoBBDD.Enlace))

                    If Not html = Nothing Then
                        Dim juegoEpic As EpicGamesJuego = JsonConvert.DeserializeObject(Of EpicGamesJuego)(html)

                        AñadirJuego(juegoEpic, juegoBBDD, listaJuegos)
                    End If
                End If

                pbProgreso.Value = CInt((100 / listaBBDD.Count) * i)
                tbProgreso.Text = i.ToString + "/" + listaBBDD.Count.ToString
                i += 1
            Next
        End If

        Await helper.SaveFileAsync(Of List(Of Tile))("juegos" + modo.ToString, listaJuegos)

        spProgreso.Visibility = Visibility.Collapsed

        Dim gridTiles As Grid = pagina.FindName("gridTiles")
        Dim gridAvisoNoJuegos As Grid = pagina.FindName("gridAvisoNoJuegos")
        Dim spBuscador As StackPanel = pagina.FindName("spBuscador")

        If Not listaJuegos Is Nothing Then
            If listaJuegos.Count > 0 Then
                gridTiles.Visibility = Visibility.Visible
                gridAvisoNoJuegos.Visibility = Visibility.Collapsed
                gridSeleccionarJuego.Visibility = Visibility.Visible
                spBuscador.Visibility = Visibility.Visible

                listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

                gv.Items.Clear()

                For Each juego In listaJuegos
                    BotonEstilo(juego, gv)
                Next

                'If boolBuscarCarpeta = True Then
                '    Toast(listaJuegos.Count.ToString + " " + recursos.GetString("GamesDetected"), Nothing)
                'End If
            Else
                gridTiles.Visibility = Visibility.Collapsed
                gridAvisoNoJuegos.Visibility = Visibility.Visible
                gridSeleccionarJuego.Visibility = Visibility.Collapsed
                spBuscador.Visibility = Visibility.Collapsed
            End If
        Else
            gridTiles.Visibility = Visibility.Collapsed
            gridAvisoNoJuegos.Visibility = Visibility.Visible
            gridSeleccionarJuego.Visibility = Visibility.Collapsed
            spBuscador.Visibility = Visibility.Collapsed
        End If

        cbTiles.IsEnabled = True
        sp1.IsHitTestVisible = True
        Cache.Estado(True)

    End Sub

    Private Async Sub AñadirJuego(juegoEpic As EpicGamesJuego, juegoBBDD As EpicGamesBBDDJuego, listaJuegos As List(Of Tile))

        Dim listaBBDDImagenesVerticales As List(Of EpicGamesBBDDJuegoImagenVertical) = EpicGamesBBDD.ImagenesVertical

        Dim titulo As String = juegoEpic.Titulo

        If titulo = Nothing Then
            titulo = juegoBBDD.Titulo
        End If

        titulo = titulo.Trim

        Dim urlImagenFondoHorizontal As String = String.Empty
        Dim urlImagenFondoVertical As String = String.Empty
        Dim urlImagenLogo As String = String.Empty

        If juegoEpic.Paginas.Count = 1 Then
            Try
                urlImagenFondoHorizontal = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Horizontal, juegoBBDD.ID, "fondoH")
            Catch ex As Exception

            End Try

            For Each imagenVertical In listaBBDDImagenesVerticales
                If imagenVertical.ID = juegoBBDD.Enlace Then
                    urlImagenFondoVertical = Await Cache.DescargarImagen(imagenVertical.Enlace, juegoBBDD.ID, "fondoV")
                    Exit For
                End If
            Next

            If urlImagenFondoVertical = String.Empty Then
                Try
                    urlImagenFondoVertical = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Vertical, juegoBBDD.ID, "fondoV")
                Catch ex As Exception

                End Try
            End If

            If urlImagenFondoHorizontal = Nothing Then
                Try
                    urlImagenFondoHorizontal = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Capturas(1), juegoBBDD.ID, "fondoH")
                Catch ex As Exception

                End Try
            End If

            If juegoBBDD.Logo = True Then
                Try
                    urlImagenLogo = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Logo.Url, juegoBBDD.ID, "logo")
                Catch ex As Exception

                End Try
            End If
        ElseIf juegoEpic.Paginas.Count > 1 Then
            For Each paginaEpic In juegoEpic.Paginas
                If paginaEpic.Patron.Contains(juegoBBDD.Enlace + "/home") Then
                    Try
                        urlImagenFondoHorizontal = Await Cache.DescargarImagen(paginaEpic.Datos.Imagenes.Horizontal, juegoBBDD.ID, "fondoH")
                    Catch ex As Exception

                    End Try

                    For Each imagenVertical In listaBBDDImagenesVerticales
                        If imagenVertical.ID = juegoBBDD.Enlace Then
                            urlImagenFondoVertical = Await Cache.DescargarImagen(imagenVertical.Enlace, juegoBBDD.ID, "fondoV")
                        End If
                    Next

                    If urlImagenFondoVertical = String.Empty Then
                        Try
                            urlImagenFondoVertical = Await Cache.DescargarImagen(paginaEpic.Datos.Imagenes.Vertical, juegoBBDD.ID, "fondoV")
                        Catch ex As Exception

                        End Try
                    End If

                    If urlImagenFondoHorizontal = Nothing Then
                        Try
                            urlImagenFondoHorizontal = Await Cache.DescargarImagen(paginaEpic.Capturas(1), juegoBBDD.ID, "fondoH")
                        Catch ex As Exception

                        End Try
                    End If

                    If juegoBBDD.Logo = True Then
                        Try
                            urlImagenLogo = Await Cache.DescargarImagen(paginaEpic.Datos.Imagenes.Logo.Url, juegoBBDD.ID, "logo")
                        Catch ex As Exception

                        End Try
                    End If
                End If
            Next
        End If

        If Not urlImagenFondoHorizontal = Nothing Or Not urlImagenLogo = Nothing Then
            Dim juego As New Tile(titulo, juegoBBDD.ID, "com.epicgames.launcher://apps/" + juegoBBDD.ID + "?action=launch&silent=true",
                                  urlImagenFondoHorizontal, urlImagenFondoVertical, urlImagenLogo)
            listaJuegos.Add(juego)
        End If

    End Sub

    Public Sub BotonEstilo(juego As Tile, gv As GridView)

        Dim panel As New DropShadowPanel With {
            .Margin = New Thickness(10, 10, 10, 10),
            .ShadowOpacity = 0.9,
            .BlurRadius = 10,
            .MaxWidth = anchoColumna + 20,
            .HorizontalAlignment = HorizontalAlignment.Center,
            .VerticalAlignment = VerticalAlignment.Center
        }

        Dim boton As New Button

        Dim grid As New Grid

        Dim imagenFondo As New ImageEx With {
            .Source = juego.ImagenVertical,
            .IsCacheEnabled = True,
            .Stretch = Stretch.UniformToFill,
            .Padding = New Thickness(0, 0, 0, 0),
            .HorizontalAlignment = HorizontalAlignment.Center,
            .VerticalAlignment = VerticalAlignment.Center
        }

        grid.Children.Add(imagenFondo)

        If Not juego.ImagenLogo = String.Empty Then
            Dim imagenLogo As New ImageEx With {
                .Source = juego.ImagenLogo,
                .IsCacheEnabled = True,
                .Stretch = Stretch.Uniform,
                .Padding = New Thickness(0, 0, 0, 0),
                .Margin = New Thickness(20, 20, 20, 20),
                .HorizontalAlignment = HorizontalAlignment.Center,
                .VerticalAlignment = VerticalAlignment.Center
            }

            grid.Children.Add(imagenLogo)
        End If

        boton.Tag = juego
        boton.Content = grid
        boton.Padding = New Thickness(0, 0, 0, 0)
        boton.Background = New SolidColorBrush(Colors.Transparent)

        panel.Content = boton

        Dim tbToolTip As TextBlock = New TextBlock With {
            .Text = juego.Titulo,
            .FontSize = 16,
            .TextWrapping = TextWrapping.Wrap
        }

        ToolTipService.SetToolTip(boton, tbToolTip)
        ToolTipService.SetPlacement(boton, PlacementMode.Mouse)

        AddHandler boton.Click, AddressOf BotonTile_Click
        AddHandler boton.PointerEntered, AddressOf UsuarioEntraBoton
        AddHandler boton.PointerExited, AddressOf UsuarioSaleBoton

        gv.Items.Add(panel)

    End Sub

    Private Sub BotonTile_Click(sender As Object, e As RoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim spBuscador As StackPanel = pagina.FindName("spBuscador")
        spBuscador.Visibility = Visibility.Collapsed

        Dim botonJuego As Button = e.OriginalSource
        Dim juego As Tile = botonJuego.Tag

        Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")
        botonAñadirTile.Tag = juego

        Dim imagenJuegoSeleccionado As ImageEx = pagina.FindName("imagenJuegoSeleccionado")

        If Not juego.ImagenHorizontal = String.Empty Then
            imagenJuegoSeleccionado.Source = juego.ImagenHorizontal
        Else
            imagenJuegoSeleccionado.Source = Nothing
        End If

        Dim tbJuegoSeleccionado As TextBlock = pagina.FindName("tbJuegoSeleccionado")
        tbJuegoSeleccionado.Text = juego.Titulo

        Dim gridSeleccionarJuego As Grid = pagina.FindName("gridSeleccionarJuego")
        gridSeleccionarJuego.Visibility = Visibility.Collapsed

        Dim gvTiles As GridView = pagina.FindName("gvTiles")

        If gvTiles.ActualWidth > anchoColumna Then
            ApplicationData.Current.LocalSettings.Values("ancho_grid_tiles") = gvTiles.ActualWidth
        End If

        gvTiles.Width = anchoColumna
        gvTiles.Padding = New Thickness(0, 0, 15, 0)

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

        Dim imagenPequeña As ImageEx = pagina.FindName("imagenTilePequeña")
        imagenPequeña.Source = Nothing

        Dim imagenMediana As ImageEx = pagina.FindName("imagenTileMediana")
        imagenMediana.Source = Nothing

        Dim imagenAncha As ImageEx = pagina.FindName("imagenTileAncha")
        imagenAncha.Source = Nothing

        Dim imagenAnchaLogo As ImageEx = pagina.FindName("imagenTileAnchaLogo")
        imagenAnchaLogo.Source = Nothing

        Dim imagenGrande As ImageEx = pagina.FindName("imagenTileGrande")
        imagenGrande.Source = Nothing

        Dim imagenGrandeLogo As ImageEx = pagina.FindName("imagenTileGrandeLogo")
        imagenGrandeLogo.Source = Nothing

        If Not juego.ImagenLogo = Nothing Then
            imagenPequeña.Source = juego.ImagenLogo
            imagenPequeña.Tag = juego.ImagenLogo
        End If

        If Not juego.ImagenHorizontal = Nothing Then
            If Not juego.ImagenLogo = Nothing Then
                imagenMediana.Source = juego.ImagenLogo
                imagenMediana.Tag = juego.ImagenLogo
            Else
                imagenMediana.Source = juego.ImagenHorizontal
                imagenMediana.Tag = juego.ImagenHorizontal
            End If

            imagenAncha.Source = juego.ImagenHorizontal
            imagenAncha.Tag = juego.ImagenHorizontal

            imagenAnchaLogo.Source = juego.ImagenLogo
            imagenAnchaLogo.Tag = juego.ImagenLogo
        End If

        If Not juego.ImagenVertical = Nothing Then
            imagenGrande.Source = juego.ImagenVertical
            imagenGrande.Tag = juego.ImagenVertical

            imagenGrandeLogo.Source = juego.ImagenLogo
            imagenGrandeLogo.Tag = juego.ImagenLogo
        End If

        Dim gridPersonalizacionImagenLogoEpic As Grid = pagina.FindName("gridPersonalizacionImagenLogoEpic")

        If imagenAnchaLogo.Source = Nothing And imagenGrandeLogo.Source = Nothing Then
            gridPersonalizacionImagenLogoEpic.Visibility = Visibility.Collapsed
        Else
            gridPersonalizacionImagenLogoEpic.Visibility = Visibility.Visible
        End If

    End Sub

    Private Sub UsuarioEntraBoton(sender As Object, e As PointerRoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim gvTiles As AdaptiveGridView = pagina.FindName("gvTiles")

        Dim boton As Button = sender

        boton.Saturation(0).Scale(1.05, 1.05, gvTiles.DesiredWidth / 2, gvTiles.ItemHeight / 2).Start()

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Hand, 1)

    End Sub

    Private Sub UsuarioSaleBoton(sender As Object, e As PointerRoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim gvTiles As AdaptiveGridView = pagina.FindName("gvTiles")

        Dim boton As Button = sender

        boton.Saturation(1).Scale(1, 1, gvTiles.DesiredWidth / 2, gvTiles.ItemHeight / 2).Start()

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
