Imports Windows.System

Namespace Interfaz
    Module JuegosFaltan

        Public Sub Cargar()

            Dim frame As Frame = Window.Current.Content
            Dim pagina As Page = frame.Content

            Dim botonContactarAñadirJuegos As Button = pagina.FindName("botonContactarAñadirJuegos")

            AddHandler botonContactarAñadirJuegos.Click, AddressOf ContactarClick
            AddHandler botonContactarAñadirJuegos.PointerEntered, AddressOf EfectosHover.Entra_Boton_Texto
            AddHandler botonContactarAñadirJuegos.PointerExited, AddressOf EfectosHover.Sale_Boton_Texto

            Dim tbJuegosFaltanPais As TextBlock = pagina.FindName("tbJuegosFaltanPais")
            Dim pais As New Windows.Globalization.GeographicRegion
            tbJuegosFaltanPais.Text = pais.NativeName + " (" + pais.Code + ")"

        End Sub

        Private Async Sub ContactarClick(sender As Object, e As RoutedEventArgs)

            Await Launcher.LaunchUriAsync(New Uri("https://pepeizqapps.com/contact/"))

        End Sub

    End Module
End Namespace