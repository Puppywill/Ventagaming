Imports MySql.Data.MySqlClient

Public Class DTlogin
    Dim log As New MySqlConnection("server=localhost;username=root;password=;database=ventagaming")


    'Esto es para abrir'
    Public Function open() As MySqlConnection
        Try
            log.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return log
    End Function

    Public Function close() As MySqlConnection
        Try
            log.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return log
    End Function



End Class