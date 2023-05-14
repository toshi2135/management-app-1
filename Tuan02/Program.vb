Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Chuong trinh giai phuong trinh bac 1")
        Console.Write("Nhap a: ")
        Dim a As Double = Double.Parse(Console.ReadLine())
        Console.Write("Nhap b: ")
        Dim b As Double = Double.Parse(Console.ReadLine())
        Dim nghiem As Double
        Dim SoNghiem As Integer = GiaiPTB1(a, b, nghiem)
        If SoNghiem = -1 Then
            Console.WriteLine("Phuong trinh co vo so nghiem")
        ElseIf SoNghiem = 0 Then
            Console.WriteLine("Phuong trinh vo nghiem")
        Else
            Console.WriteLine("Phuong trinh co 1 nghiem x = {0}", nghiem)
        End If

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