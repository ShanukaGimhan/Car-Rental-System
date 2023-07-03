Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Module Validation

    Dim result As Boolean
    Dim command As New MySqlCommand
    Public Function Min_len(ByVal name As String, ByVal number As Integer) As Boolean
        If name.Length < number Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Function Nullempty(ByVal name1 As String) As Boolean
        name1 = Trim(name1)
        If String.IsNullOrEmpty(name1) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Function Check_str(ByVal str1 As String, ByVal str2 As String, Optional ByVal str_case As Boolean = False) As Boolean
        If String.Compare(str1, str2, str_case) = 0 Then
            result = True
        Else
            result = False
        End If                      'use if NOT function. because need not match msg box only. this return correct value as compare paswword
        Return result
    End Function


    Public Function User_mail(ByVal mail As String) As Boolean

        Dim mail_row As String

        command.CommandText = "SELECT COUNT(`email`) FROM `admin` WHERE `email`=@MAIL1 LIMIT 1"
        command.Connection = conn
        command.Parameters.Add("@MAIL1", MySqlDbType.VarChar).Value = mail
        mail_row = command.ExecuteScalar()
        If mail_row = True Then
            MsgBox("Email Already Registred", vbExclamation, "Check Email")
        End If
        command.Parameters.Clear()
        Return mail_row = True

    End Function


    Public Function Username_check(ByVal username As String) As Boolean

        Dim user_row As String

        command.CommandText = "SELECT COUNT(`user_name`) FROM `admin` WHERE `user_name`=@USER LIMIT 1"
        command.Connection = conn
        command.Parameters.Add("@USER", MySqlDbType.VarChar).Value = username
        user_row = command.ExecuteScalar()
        If user_row = True Then
            MsgBox("User Name Already Registerd. Try Another User Name", vbExclamation, "Email Already Registerd")
        End If
        command.Parameters.Clear()
        Return user_row = True

    End Function

    Public Function NIC_check(ByVal nic As String) As Boolean

        If System.Text.RegularExpressions.Regex.IsMatch(nic, "[0-9]{9}|v") Then
            result = True
        End If
        Return result

    End Function


    Public Function NIC_lenght(ByVal NIC_len As String) As Boolean

        If NIC_len.Length > 12 Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Function Email_check(ByVal email As String) As Boolean

        If Not System.Text.RegularExpressions.Regex.IsMatch(email, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]{2,4}$") Then
            result = True
            MsgBox("Email Not In a Correct Format. Check Again", vbExclamation, "Email Format Error")
        Else
            result = False
        End If
        Return result
    End Function

    Public Function User_NIC(ByVal u_nic As String) As Boolean

        Dim NIC_row As String

        command.CommandText = "SELECT COUNT(`NIC`) FROM `admin` WHERE NIC=@NIC LIMIT 1"
        command.Connection = conn
        command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = u_nic
        NIC_row = command.ExecuteScalar()
        If NIC_row = True Then
            MsgBox("NIC Number Already Registerd. ", vbExclamation, "NIC Already Registerd")
        End If
        command.Parameters.Clear()
        Return NIC_row = True
    End Function

End Module
