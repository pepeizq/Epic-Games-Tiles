Imports Windows.Storage

Module Configuracion

    Public Sub Iniciar()

        If ApplicationData.Current.LocalSettings.Values("modo_tiles") Is Nothing Then
            ModoTiles(0, True)
        Else
            ModoTiles(ApplicationData.Current.LocalSettings.Values("modo_tiles"), True)
        End If

        '------------------------------------------

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        Dim tbTitulo As TextBlock = pagina.FindName("tbTitulo")
        tbTitulo.Text = Package.Current.DisplayName + " (" + Package.Current.Id.Version.Major.ToString + "." + Package.Current.Id.Version.Minor.ToString + "." + Package.Current.Id.Version.Build.ToString + "." + Package.Current.Id.Version.Revision.ToString + ")"

    End Sub

    Public Sub ModoTiles(modo As Integer, arranque As Boolean)

        Dim recursos As New Resources.ResourceLoader()

        Dim frame As Frame = Window.Current.Content
        Dim pagina As Page = frame.Content

        ApplicationData.Current.LocalSettings.Values("modo_tiles") = modo

        If arranque = True Then
            Dim cbTiles As ComboBox = pagina.FindName("cbConfigModosTiles")
            cbTiles.SelectedIndex = modo
        Else
            EpicGames.Generar(False)
        End If

        Dim sp1 As StackPanel = pagina.FindName("spModoTile1")
        Dim tbSeleccionar As TextBlock = pagina.FindName("tbSeleccionarJuego")

        If modo = 0 Then
            sp1.Visibility = Visibility.Visible
            tbSeleccionar.Text = recursos.GetString("SelectGame0")
        Else
            sp1.Visibility = Visibility.Collapsed
            tbSeleccionar.Text = recursos.GetString("SelectGame1")
        End If

    End Sub

End Module
