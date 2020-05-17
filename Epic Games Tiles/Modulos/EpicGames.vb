Imports Microsoft.Toolkit.Uwp.Helpers
Imports Microsoft.Toolkit.Uwp.UI.Controls
Imports Newtonsoft.Json
Imports Windows.Storage
Imports Windows.Storage.AccessCache
Imports Windows.Storage.Pickers
Imports Windows.UI.Core
Imports Windows.UI.Xaml.Media.Animation

Module EpicGames

    Public anchoColumna As Integer = 350

    Public Async Sub Generar(boolBuscarCarpeta As Boolean)

        Dim modo As Integer = ApplicationData.Current.LocalSettings.Values("modo_tiles")

        Dim helper As New LocalObjectStorageHelper

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

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

        Dim botonCache As Button = pagina.FindName("botonConfigLimpiarCache")
        botonCache.IsEnabled = False

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

                                    Dim titulo As String = juegoEpic.Titulo.Trim

                                    Dim urlImagenFondoHorizontal As String = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoHorizontal, juegoBBDD.ID, "fondoH")

                                    If urlImagenFondoHorizontal = Nothing Then
                                        urlImagenFondoHorizontal = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoVertical, juegoBBDD.ID, "fondoH")
                                    End If

                                    Dim urlImagenFondoVertical As String = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoVertical, juegoBBDD.ID, "fondoV")

                                    Dim urlImagenLogo As String = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Logo.Url, juegoBBDD.ID, "logo")

                                    'If juegoEpic.ReviewNo = True Then
                                    '    Notificaciones.Toast(juegoEpic.Titulo, Nothing)
                                    'End If

                                    If Not urlImagenFondoHorizontal = Nothing Or Not urlImagenLogo = Nothing Then
                                        Dim juego As New Tile(titulo, juegoBBDD.ID, "com.epicgames.launcher://apps/" + juegoBBDD.ID + "?action=launch&silent=true",
                                                              urlImagenFondoHorizontal, urlImagenFondoVertical, urlImagenLogo)
                                        listaJuegos.Add(juego)
                                    End If
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
                    Dim html As String = Await Decompiladores.HttpClient(New Uri("https://store-content.ak.epicgames.com/api/en-US/content/products/" + juegoBBDD.Enlace))

                    If Not html = Nothing Then
                        Dim juegoEpic As EpicGamesJuego = JsonConvert.DeserializeObject(Of EpicGamesJuego)(html)

                        Dim titulo As String = juegoEpic.Titulo.Trim

                        Dim urlImagenFondoHorizontal As String = String.Empty

                        Try
                            urlImagenFondoHorizontal = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoHorizontal, juegoBBDD.ID, "fondoH")
                        Catch ex As Exception

                        End Try

                        Dim urlImagenFondoVertical As String = String.Empty

                        Try
                            urlImagenFondoVertical = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.FondoVertical, juegoBBDD.ID, "fondoV")
                        Catch ex As Exception

                        End Try

                        If urlImagenFondoHorizontal = Nothing Then
                            Try
                                urlImagenFondoHorizontal = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Capturas(1), juegoBBDD.ID, "fondoH")
                            Catch ex As Exception

                            End Try
                        End If

                        Dim urlImagenLogo As String = String.Empty

                        If juegoBBDD.Logo = True Then
                            Try
                                urlImagenLogo = Await Cache.DescargarImagen(juegoEpic.Paginas(0).Datos.Imagenes.Logo.Url, juegoBBDD.ID, "logo")
                            Catch ex As Exception

                            End Try
                        End If

                        If Not urlImagenFondoHorizontal = Nothing Or Not urlImagenLogo = Nothing Then
                            Dim juego As New Tile(titulo, juegoBBDD.ID, "com.epicgames.launcher://apps/" + juegoBBDD.ID + "?action=launch&silent=true",
                                                  urlImagenFondoHorizontal, urlImagenFondoVertical, urlImagenLogo)
                            listaJuegos.Add(juego)
                        End If
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

        If listaJuegos.Count > 0 Then
            gridTiles.Visibility = Visibility.Visible
            gridAvisoNoJuegos.Visibility = Visibility.Collapsed
            gridSeleccionarJuego.Visibility = Visibility.Visible

            listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

            gv.Items.Clear()

            For Each juego In listaJuegos
                Dim gridImagen As New Grid With {
                    .Width = 322,
                    .Height = 187
                }

                Dim imagenFondo As New ImageEx With {
                    .Source = juego.ImagenFondoHorizontal,
                    .IsCacheEnabled = True,
                    .Stretch = Stretch.UniformToFill
                }

                gridImagen.Children.Add(imagenFondo)

                If Not juego.ImagenLogo = Nothing Then
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
                End If

                Dim panel As New DropShadowPanel With {
                    .Margin = New Thickness(5, 5, 5, 5),
                    .ShadowOpacity = 0.9,
                    .BlurRadius = 5
                }

                Dim boton As New Button With {
                    .Tag = juego,
                    .Content = gridImagen,
                    .Padding = New Thickness(0, 0, 0, 0)
                }

                panel.Content = boton

                Dim tbToolTip As TextBlock = New TextBlock With {
                    .Text = juego.Titulo,
                    .FontSize = 16
                }

                ToolTipService.SetToolTip(boton, tbToolTip)
                ToolTipService.SetPlacement(boton, PlacementMode.Mouse)

                AddHandler boton.Click, AddressOf BotonTile_Click
                AddHandler boton.PointerEntered, AddressOf UsuarioEntraBoton
                AddHandler boton.PointerExited, AddressOf UsuarioSaleBoton

                gv.Items.Add(panel)
            Next

            If boolBuscarCarpeta = True Then
                Toast(listaJuegos.Count.ToString + " " + recursos.GetString("GamesDetected"), Nothing)
            End If
        Else
            gridTiles.Visibility = Visibility.Collapsed
            gridAvisoNoJuegos.Visibility = Visibility.Visible
            gridSeleccionarJuego.Visibility = Visibility.Collapsed
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

        If Not juego.ImagenLogo = Nothing Then
            imagenPequeña.Source = juego.ImagenLogo
            imagenPequeña.Tag = juego.ImagenLogo
        End If

        Dim imagenMediana As ImageEx = pagina.FindName("imagenTileMediana")
        imagenMediana.Source = Nothing

        Dim imagenAncha As ImageEx = pagina.FindName("imagenTileAncha")
        imagenAncha.Source = Nothing

        Dim imagenAnchaLogo As ImageEx = pagina.FindName("imagenTileAnchaLogo")
        imagenAnchaLogo.Source = Nothing

        If Not juego.ImagenFondoHorizontal = Nothing Then
            If Not juego.ImagenLogo = Nothing Then
                imagenMediana.Source = juego.ImagenLogo
                imagenMediana.Tag = juego.ImagenLogo
            Else
                imagenMediana.Source = juego.ImagenFondoHorizontal
                imagenMediana.Tag = juego.ImagenFondoHorizontal
            End If

            imagenAncha.Source = juego.ImagenFondoHorizontal
            imagenAncha.Tag = juego.ImagenFondoHorizontal

            imagenAnchaLogo.Source = juego.ImagenLogo
            imagenAnchaLogo.Tag = juego.ImagenLogo
        End If

        Dim imagenGrande As ImageEx = pagina.FindName("imagenTileGrande")
        imagenGrande.Source = Nothing

        Dim imagenGrandeLogo As ImageEx = pagina.FindName("imagenTileGrandeLogo")
        imagenGrandeLogo.Source = Nothing

        If Not juego.ImagenFondoVertical = Nothing Then
            imagenGrande.Source = juego.ImagenFondoVertical
            imagenGrande.Tag = juego.ImagenFondoVertical

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
