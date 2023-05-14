Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub

    Function GiaiPTB1(ByVal a As Double, ByVal b As Double, ByRef nghiem As Double) As Integer
        Dim SoNghiem As Integer
        If a = 0 Then
            If b = 0 Then
                SoNghiem = -1 'Vo so nghiem
            Else
                SoNghiem = 0 'Vo nghiem
            End If
        Else
            SoNghiem = 1 'Co 1 nghiem
            nghiem = -b / a
        End If
        Return SoNghiem
    End Function

End Module