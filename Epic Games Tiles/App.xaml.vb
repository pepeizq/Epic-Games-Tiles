Imports Windows.ApplicationModel.Core
Imports Windows.System
''' <summary>
''' Proporciona un comportamiento específico de la aplicación para complementar la clase Application predeterminada.
''' </summary>
NotInheritable Class App
    Inherits Application

    ''' <summary>
    ''' Se invoca cuando el usuario final inicia la aplicación normalmente. Se usarán otros puntos
    ''' cuando la aplicación se inicie para abrir un archivo específico, para mostrar
    ''' resultados de la búsqueda, etc.
    ''' </summary>
    ''' <param name="e">Información detallada acerca de la solicitud y el proceso de inicio.</param>
    Protected Overrides Async Sub OnLaunched(e As LaunchActivatedEventArgs)
#If DEBUG Then
        ' Show graphics profiling information while debugging.
        If Debugger.IsAttached Then
            ' Display the current frame rate counters
            Me.DebugSettings.EnableFrameRateCounter = True
        End If
#End If

        Dim boolIniciarApp As Boolean = False
        Dim arguments As String = e.Arguments

        Try
            boolIniciarApp = Await Launcher.LaunchUriAsync(New Uri(arguments))
        Catch ex As Exception

        End Try

        Try
            If boolIniciarApp = False Then
                boolIniciarApp = Await Launcher.LaunchFileAsync(New Uri(arguments))
            End If
        Catch ex As Exception

        End Try

        If boolIniciarApp = False Then
            Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

            If rootFrame Is Nothing Then
                rootFrame = New Frame()

                AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

                If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                    ' TODO: Load state from previously suspended application
                End If

                Window.Current.Content = rootFrame
            End If
            If rootFrame.Content Is Nothing Then
                rootFrame.Navigate(GetType(MainPage), e.Arguments)
            End If

            Window.Current.Activate()
        Else
            Try
                CoreApplication.Exit()
            Catch ex As Exception

            End Try

            Try
                Application.Current.Exit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    ''' <summary>
    ''' Se invoca cuando la aplicación la inicia normalmente el usuario final. Se usarán otros puntos
    ''' </summary>
    ''' <param name="sender">Marco que produjo el error de navegación</param>
    ''' <param name="e">Detalles sobre el error de navegación</param>
    Private Sub OnNavigationFailed(sender As Object, e As NavigationFailedEventArgs)
        Throw New Exception("Failed to load Page " + e.SourcePageType.FullName)
    End Sub

    ''' <summary>
    ''' Se invoca al suspender la ejecución de la aplicación. El estado de la aplicación se guarda
    ''' sin saber si la aplicación se terminará o se reanudará con el contenido
    ''' de la memoria aún intacto.
    ''' </summary>
    ''' <param name="sender">Origen de la solicitud de suspensión.</param>
    ''' <param name="e">Detalles sobre la solicitud de suspensión.</param>
    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        ' TODO: Guardar el estado de la aplicación y detener toda actividad en segundo plano
        deferral.Complete()
    End Sub

End Class
