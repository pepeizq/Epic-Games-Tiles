﻿''' <summary>
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
    Protected Overrides Sub OnLaunched(e As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

        ' No repetir la inicialización de la aplicación si la ventana tiene contenido todavía,
        ' solo asegurarse de que la ventana está activa.

        If rootFrame Is Nothing Then
            ' Crear un marco para que actúe como contexto de navegación y navegar a la primera página.
            rootFrame = New Frame()

            AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                ' TODO: Cargar el estado de la aplicación suspendida previamente
            End If
            ' Poner el marco en la ventana actual.
            Window.Current.Content = rootFrame
        End If

        If e.PrelaunchActivated = False Then
            If rootFrame.Content Is Nothing Then
                ' Cuando no se restaura la pila de navegación, navegar a la primera página,
                ' configurando la nueva página pasándole la información requerida como
                'parámetro de navegación
                rootFrame.Navigate(GetType(MainPage), e.Arguments)
            End If

            ' Asegurarse de que la ventana actual está activa.
            Window.Current.Activate()
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
