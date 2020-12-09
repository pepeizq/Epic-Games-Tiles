Imports Windows.Storage

Module Configuracion

    Public Sub Cargar()

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonAbrirConfig As Button = pagina.FindName("botonAbrirConfig")

        AddHandler botonAbrirConfig.Click, AddressOf AbrirConfigClick
        AddHandler botonAbrirConfig.PointerEntered, AddressOf Interfaz.EfectosHover.Entra_Boton_IconoTexto
        AddHandler botonAbrirConfig.PointerExited, AddressOf Interfaz.EfectosHover.Sale_Boton_IconoTexto

        Dim cbEpicConfigModosTiles As ComboBox = pagina.FindName("cbEpicConfigModosTiles")
        cbEpicConfigModosTiles.Items.Add(recursos.GetString("Epic_ConfigImport1"))
        cbEpicConfigModosTiles.Items.Add(recursos.GetString("Epic_ConfigImport2"))

        Dim tbSeleccionarJuego As TextBlock = pagina.FindName("tbSeleccionarJuego")

        If ApplicationData.Current.LocalSettings.Values("modo_tiles") Is Nothing Then
            ApplicationData.Current.LocalSettings.Values("modo_tiles") = 0
            cbEpicConfigModosTiles.SelectedIndex = 0

            Dim spEpicConfigModo1 As StackPanel = pagina.FindName("spEpicConfigModo1")
            spEpicConfigModo1.Visibility = Visibility.Visible

            tbSeleccionarJuego.Text = recursos.GetString("SelectGame")
        Else
            cbEpicConfigModosTiles.SelectedIndex = ApplicationData.Current.LocalSettings.Values("modo_tiles")

            Dim spEpicConfigModo1 As StackPanel = pagina.FindName("spEpicConfigModo1")
            Dim spEpicConfigModo2 As StackPanel = pagina.FindName("spEpicConfigModo2")

            If cbEpicConfigModosTiles.SelectedIndex = 0 Then
                spEpicConfigModo1.Visibility = Visibility.Visible
                spEpicConfigModo2.Visibility = Visibility.Collapsed

                tbSeleccionarJuego.Text = recursos.GetString("SelectGame")
            Else
                spEpicConfigModo1.Visibility = Visibility.Collapsed
                spEpicConfigModo2.Visibility = Visibility.Visible

                EpicGames.Generar(True)
                tbSeleccionarJuego.Text = recursos.GetString("Epic_SelectGame")
            End If
        End If

        AddHandler cbEpicConfigModosTiles.SelectionChanged, AddressOf CambiarModoSelect
        AddHandler cbEpicConfigModosTiles.PointerEntered, AddressOf Interfaz.EfectosHover.Entra_Basico
        AddHandler cbEpicConfigModosTiles.PointerExited, AddressOf Interfaz.EfectosHover.Sale_Basico

        Dim botonConfigImagen As Button = pagina.FindName("botonConfigImagen")

        AddHandler botonConfigImagen.Click, AddressOf AbrirImagenClick
        AddHandler botonConfigImagen.PointerEntered, AddressOf Interfaz.EfectosHover.Entra_Boton_IconoTexto
        AddHandler botonConfigImagen.PointerExited, AddressOf Interfaz.EfectosHover.Sale_Boton_IconoTexto

        Dim botonBuscarCarpetaEpic As Button = pagina.FindName("botonBuscarCarpetaEpic")

        AddHandler botonBuscarCarpetaEpic.Click, AddressOf BuscarCarpetaClick
        AddHandler botonBuscarCarpetaEpic.PointerEntered, AddressOf Interfaz.EfectosHover.Entra_Boton_IconoTexto
        AddHandler botonBuscarCarpetaEpic.PointerExited, AddressOf Interfaz.EfectosHover.Sale_Boton_IconoTexto

    End Sub

    Private Sub AbrirConfigClick(sender As Object, e As RoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim gridConfig As Grid = pagina.FindName("gridConfig")

        Dim recursos As New Resources.ResourceLoader()
        Interfaz.Pestañas.Visibilidad_Pestañas(gridConfig, recursos.GetString("Config"))

    End Sub

    Private Sub CambiarModoSelect(sender As Object, e As SelectionChangedEventArgs)

        Dim recursos As New Resources.ResourceLoader()

        EpicGames.Borrar()

        Dim cb As ComboBox = sender
        ApplicationData.Current.LocalSettings.Values("modo_tiles") = cb.SelectedIndex

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim spEpicConfigModo1 As StackPanel = pagina.FindName("spEpicConfigModo1")
        Dim spEpicConfigModo2 As StackPanel = pagina.FindName("spEpicConfigModo2")

        Dim tbSeleccionarJuego As TextBlock = pagina.FindName("tbSeleccionarJuego")

        If cb.SelectedIndex = 0 Then
            spEpicConfigModo1.Visibility = Visibility.Visible
            spEpicConfigModo2.Visibility = Visibility.Collapsed

            tbSeleccionarJuego.Text = recursos.GetString("SelectGame")
        Else
            spEpicConfigModo1.Visibility = Visibility.Collapsed
            spEpicConfigModo2.Visibility = Visibility.Visible

            EpicGames.Generar(True)
            tbSeleccionarJuego.Text = recursos.GetString("Epic_SelectGame")
        End If

    End Sub

    Private Sub AbrirImagenClick(sender As Object, e As RoutedEventArgs)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim grid As Grid = pagina.FindName("gridConfigImagen")
        Dim icono As FontAwesome5.FontAwesome = pagina.FindName("iconoConfigImagen")

        If grid.Visibility = Visibility.Collapsed Then
            grid.Visibility = Visibility.Visible
            icono.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleUp
        Else
            grid.Visibility = Visibility.Collapsed
            icono.Icon = FontAwesome5.EFontAwesomeIcon.Solid_AngleDoubleDown
        End If

    End Sub

    Private Sub BuscarCarpetaClick(sender As Object, e As RoutedEventArgs)

        EpicGames.Generar(True)

    End Sub

    Public Sub Estado(estado As Boolean)

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim botonAbrirConfig As Button = pagina.FindName("botonAbrirConfig")
        botonAbrirConfig.IsEnabled = estado

        Dim cbEpicConfigModosTiles As ComboBox = pagina.FindName("cbEpicConfigModosTiles")
        cbEpicConfigModosTiles.IsEnabled = estado

        Dim botonConfigImagen As Button = pagina.FindName("botonConfigImagen")
        botonConfigImagen.IsEnabled = estado

        Dim botonBuscarCarpetaEpic As Button = pagina.FindName("botonBuscarCarpetaEpic")
        botonBuscarCarpetaEpic.IsEnabled = estado

    End Sub

End Module
