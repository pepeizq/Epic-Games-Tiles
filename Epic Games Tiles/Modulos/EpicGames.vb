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

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim pr As ProgressRing = pagina.FindName("prTiles")
        pr.Visibility = Visibility.Visible

        Dim botonAñadirCarpetaTexto As TextBlock = pagina.FindName("botonAñadirCarpetaTexto")

        Dim botonCarpetaTexto As TextBlock = pagina.FindName("tbConfigCarpeta")

        Dim gv As GridView = pagina.FindName("gridViewTiles")

        gv.Items.Clear()

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

        Dim listaJuegos As New List(Of Tile)

        If Not carpeta Is Nothing Then
            Dim listaInstalado As New List(Of String)

            Dim ficheroBBDD As StorageFile = Await StorageFile.GetFileFromApplicationUriAsync(New Uri("ms-appx:///Assets/BBDD.txt"))
            Dim datosBBDD As String = Await FileIO.ReadTextAsync(ficheroBBDD)
            Dim bbdd As EpicGamesBBDD = JsonConvert.DeserializeObject(Of EpicGamesBBDD)(datosBBDD)

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

            For Each subcarpeta1 As StorageFolder In subcarpetas1
                If subcarpeta1.DisplayName.ToLower = "epicgameslauncher" Then
                    Dim subcarpetas2 As IReadOnlyList(Of StorageFolder) = Await subcarpeta1.GetFoldersAsync()

                    For Each subcarpeta2 As StorageFolder In subcarpetas2
                        If subcarpeta2.DisplayName.ToLower = "data" Then
                            Dim subcarpetas3 As IReadOnlyList(Of StorageFolder) = Await subcarpeta2.GetFoldersAsync()

                            For Each subcarpeta3 As StorageFolder In subcarpetas3
                                If subcarpeta3.DisplayName.ToLower = "ems" Then
                                    Dim subcarpetas4 As IReadOnlyList(Of StorageFolder) = Await subcarpeta3.GetFoldersAsync()

                                    For Each subcarpeta4 As StorageFolder In subcarpetas4
                                        If subcarpeta4.DisplayName.ToLower = "epicgameslauncher" Then
                                            Dim ficheros As IReadOnlyList(Of StorageFile) = Await subcarpeta4.GetFilesAsync()

                                            For Each fichero As StorageFile In ficheros
                                                If fichero.DisplayType.ToLower.Contains("v2product") Then
                                                    Dim datosTexto As String = Await FileIO.ReadTextAsync(fichero)
                                                    Dim datos As EpicGamesDatos = JsonConvert.DeserializeObject(Of EpicGamesDatos)(datosTexto)

                                                    If Not datos Is Nothing Then
                                                        Dim titulo As String = datos.Titulo
                                                        Dim idEjecutable As String = String.Empty
                                                        Dim idBBDD As String = datos.ID

                                                        If Not datos.Apps Is Nothing Then
                                                            If datos.Apps.Count > 0 Then
                                                                For Each app In datos.Apps
                                                                    For Each juegoInstalado In listaInstalado
                                                                        If juegoInstalado = app.Nombre Then
                                                                            idEjecutable = app.Nombre
                                                                        End If
                                                                    Next
                                                                Next
                                                            End If
                                                        End If

                                                        Dim añadirBool As Boolean = False
                                                        Dim i As Integer = 0
                                                        While i < listaJuegos.Count
                                                            If listaJuegos(i).Titulo = titulo Then
                                                                añadirBool = True
                                                            End If
                                                            i += 1
                                                        End While

                                                        If idEjecutable = String.Empty Then
                                                            añadirBool = True
                                                        End If

                                                        If añadirBool = False Then
                                                            Dim gridImagen As New Grid With {
                                                                .Width = 430,
                                                                .Height = 250
                                                            }

                                                            Dim urlImagenFondo As String = String.Empty

                                                            For Each juego In bbdd.Tienda.Juegos
                                                                If juego.Atributos.ID = idBBDD Then
                                                                    If Not juego.Imagenes.ImagenFondo Is Nothing Then
                                                                        Dim imagenFondo As New ImageEx With {
                                                                            .Source = juego.Imagenes.ImagenFondo(0),
                                                                            .IsCacheEnabled = True,
                                                                            .Stretch = Stretch.UniformToFill
                                                                        }

                                                                        gridImagen.Children.Add(imagenFondo)
                                                                        urlImagenFondo = juego.Imagenes.ImagenFondo(0)
                                                                    End If

                                                                    If Not juego.Imagenes.ImagenLogo Is Nothing Then
                                                                        Dim imagenLogo As New ImageEx With {
                                                                            .Source = juego.Imagenes.ImagenLogo(0),
                                                                            .IsCacheEnabled = True,
                                                                            .Stretch = Stretch.Uniform,
                                                                            .VerticalAlignment = VerticalAlignment.Center,
                                                                            .HorizontalAlignment = HorizontalAlignment.Center,
                                                                            .Margin = New Thickness(30)
                                                                        }

                                                                        gridImagen.Children.Add(imagenLogo)
                                                                    End If
                                                                End If
                                                            Next

                                                            If gridImagen.Children.Count > 0 Then
                                                                Dim juego As New Tile(titulo, idEjecutable, "com.epicgames.launcher://apps/" + idEjecutable + "?action=launch&silent=true",
                                                                                      urlImagenFondo, urlImagenFondo, gridImagen, urlImagenFondo)
                                                                listaJuegos.Add(juego)
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            Next
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                End If
            Next

            If listaJuegos.Count > 0 Then
                StorageApplicationPermissions.FutureAccessList.AddOrReplace("EpicGamesCarpeta", carpeta)
                botonCarpetaTexto.Text = carpeta.Path
                botonAñadirCarpetaTexto.Text = recursos.GetString("Change")
            End If
        End If

        pr.Visibility = Visibility.Collapsed

        Dim panelNoJuegos As Grid = pagina.FindName("panelAvisoNoJuegos")
        Dim gridSeleccionar As Grid = pagina.FindName("gridSeleccionarJuego")

        If listaJuegos.Count > 0 Then
            panelNoJuegos.Visibility = Visibility.Collapsed
            gridSeleccionar.Visibility = Visibility.Visible

            gv.Visibility = Visibility.Visible

            listaJuegos.Sort(Function(x, y) x.Titulo.CompareTo(y.Titulo))

            gv.Items.Clear()

            For Each juego In listaJuegos
                Dim boton As New Button With {
                    .Tag = juego,
                    .Content = juego.ImagenAncha,
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

    End Sub

    Private Async Sub BotonTile_Click(sender As Object, e As RoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonJuego As Button = e.OriginalSource
        Dim juego As Tile = botonJuego.Tag

        Dim botonAñadirTile As Button = pagina.FindName("botonAñadirTile")
        botonAñadirTile.Tag = juego

        Dim resultado As New RenderTargetBitmap()
        Await resultado.RenderAsync(juego.ImagenAncha)

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

        If Not juego.ImagenPequeña Is Nothing Then
            Dim imagenPequeña1 As ImageEx = pagina.FindName("imagenTilePequeñaEnseñar")
            Dim imagenPequeña2 As ImageEx = pagina.FindName("imagenTilePequeñaGenerar")
            Dim imagenPequeña3 As ImageEx = pagina.FindName("imagenTilePequeñaPersonalizar")

            imagenPequeña1.Source = juego.ImagenPequeña
            imagenPequeña2.Source = juego.ImagenPequeña
            imagenPequeña3.Source = juego.ImagenPequeña

            imagenPequeña1.Tag = juego.ImagenPequeña
            imagenPequeña2.Tag = juego.ImagenPequeña
            imagenPequeña3.Tag = juego.ImagenPequeña
        End If

        If Not juego.ImagenMediana Is Nothing Then
            Dim imagenMediana1 As ImageEx = pagina.FindName("imagenTileMedianaEnseñar")
            Dim imagenMediana2 As ImageEx = pagina.FindName("imagenTileMedianaGenerar")
            Dim imagenMediana3 As ImageEx = pagina.FindName("imagenTileMedianaPersonalizar")

            imagenMediana1.Source = juego.ImagenMediana
            imagenMediana2.Source = juego.ImagenMediana
            imagenMediana3.Source = juego.ImagenMediana

            imagenMediana1.Tag = juego.ImagenMediana
            imagenMediana2.Tag = juego.ImagenMediana
            imagenMediana3.Tag = juego.ImagenMediana
        End If

        If Not juego.ImagenAncha Is Nothing Then
            Dim imagenAncha1 As ImageEx = pagina.FindName("imagenTileAnchaEnseñar")
            Dim imagenAncha2 As ImageEx = pagina.FindName("imagenTileAnchaGenerar")
            Dim imagenAncha3 As ImageEx = pagina.FindName("imagenTileAnchaPersonalizar")

            imagenAncha1.Source = resultado
            imagenAncha2.Source = resultado
            imagenAncha3.Source = resultado

            imagenAncha1.Tag = juego.ImagenAncha
            imagenAncha2.Tag = juego.ImagenAncha
            imagenAncha3.Tag = juego.ImagenAncha
        End If

        If Not juego.ImagenGrande Is Nothing Then
            Dim imagenGrande1 As ImageEx = pagina.FindName("imagenTileGrandeEnseñar")
            Dim imagenGrande2 As ImageEx = pagina.FindName("imagenTileGrandeGenerar")
            Dim imagenGrande3 As ImageEx = pagina.FindName("imagenTileGrandePersonalizar")

            imagenGrande1.Source = juego.ImagenGrande
            imagenGrande2.Source = juego.ImagenGrande
            imagenGrande3.Source = juego.ImagenGrande

            imagenGrande1.Tag = juego.ImagenGrande
            imagenGrande2.Tag = juego.ImagenGrande
            imagenGrande3.Tag = juego.ImagenGrande
        End If

    End Sub

    Private Sub UsuarioEntraBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Hand, 1)

    End Sub

    Private Sub UsuarioSaleBoton(sender As Object, e As PointerRoutedEventArgs)

        Window.Current.CoreWindow.PointerCursor = New CoreCursor(CoreCursorType.Arrow, 1)

    End Sub

End Module

Public Class EpicGamesBBDD

    <JsonProperty("store")>
    Public Tienda As EpicGamesBBDD2

End Class

Public Class EpicGamesBBDD2

    <JsonProperty("storeItems")>
    Public Juegos As List(Of EpicGamesBBDDJuego)

End Class

Public Class EpicGamesBBDDJuego

    <JsonProperty("customAttributes")>
    Public Atributos As EpicGamesBBDDJuegoAtributos

    <JsonProperty("keyImages")>
    Public Imagenes As EpicGamesBBDDJuegoImagenes

End Class

Public Class EpicGamesBBDDJuegoAtributos

    <JsonProperty("com.epicgames.app.offerNs")>
    Public ID As String

End Class

Public Class EpicGamesBBDDJuegoImagenes

    <JsonProperty("DieselGameBoxLogo")>
    Public ImagenLogo As List(Of String)

    <JsonProperty("DieselStoreFrontWide")>
    Public ImagenFondo As List(Of String)

End Class

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
