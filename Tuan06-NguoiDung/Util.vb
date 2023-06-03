Imports System.Security.Cryptography
Imports System.Text
Module Util
    Public Function getHash(ByVal str As String) As String
        Dim md5 As MD5 = MD5.Create()
        Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(str)
        Dim hash As Byte() = md5.ComputeHash(inputBytes)
        Dim sb As StringBuilder = New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            sb.Append(hash(i).ToString("X2"))
        Next
        Return sb.ToString()
    End Function
End Module
