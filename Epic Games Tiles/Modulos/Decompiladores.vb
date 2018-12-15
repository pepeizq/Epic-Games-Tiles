Imports Windows.Web.Http

Module Decompiladores

    Public Async Function HttpClient(url As Uri) As Task(Of String)

        Dim cliente As New HttpClient()
        Dim httpFinal As String = Nothing

        cliente.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0")

        Try
            Dim respuesta As New HttpResponseMessage
            respuesta = Await cliente.GetAsync(url)
            respuesta.EnsureSuccessStatusCode()

            httpFinal = TryCast(Await respuesta.Content.ReadAsStringAsync(), String)
        Catch ex As Exception

        End Try

        cliente.Dispose()
        Return httpFinal
    End Function

    Public Async Function HttpClient2(url As Uri) As Task(Of String)

        Dim cliente As New Net.Http.HttpClient
        Dim html As String = Await cliente.GetStringAsync(url.ToString)

        Return html
    End Function

End Module
