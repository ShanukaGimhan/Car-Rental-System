Imports MySql.Data.MySqlClient
Module DB_connect
    Public conn As New MySqlConnection
    Dim result As Boolean

    Public Function Open_db()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "datasource=localhost;username=root;password=;database=rental"
                conn.Open()
                result = conn.State
            End If
        Catch ex As Exception
            MsgBox("Connection Error", vbExclamation, "Database Error")
        End Try
        Return result
    End Function
    Public Function Close_db()
        conn.Close()
        Return conn.State
    End Function

End Module
