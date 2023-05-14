Imports System

Module Program
    Sub Main(args As String())
        'Dim a As Double
        'Dim b As Double
        'Dim kq As Double
        'Console.WriteLine("Chuong trinh cong 2 so")
        'Console.Write("Nhap a: ")
        'a = Double.Parse(Console.ReadLine())
        'Console.Write("Nhap b: ")
        'b = Double.Parse(Console.ReadLine())
        'kq = a + b
        'Dim str As String = String.Format("Ket qua chuong trinh la {0} + {1} = {2}", a, b, kq)
        'Console.WriteLine(str)

        'Dim a As Double
        'Dim b As Double
        'Dim kq As String
        'Console.WriteLine("Chuong trinh gia phuong trinh ax + b = 0")
        'Console.Write("Nhap a: ")
        'a = Double.Parse(Console.ReadLine())
        'Console.Write("Nhap b: ")
        'b = Double.Parse(Console.ReadLine())

        'If a = 0 Then
        '    If b = 0 Then
        '        kq = String.Format("Phuong trinh co vo so nghiem")
        '    Else
        '        kq = String.Format("Phuong trinh vo nghiem")
        '    End If
        'Else
        '    kq = String.Format("Phuong trinh co 1 nghiem x = {0}", -b / a)
        'End If
        'Console.WriteLine(kq)

        'Dim n As Integer
        'Dim kq As Long
        'Console.WriteLine("Chuong trinh tinh giai thua")
        'Console.Write("Nhap n: ")
        'n = Integer.Parse(Console.ReadLine())

        'kq = 1
        'Dim i As Integer = 1
        'While i <= n
        '    kq *= i
        '    i += 1
        'End While

        'kq = 1
        'For j As Integer = 1 To n
        '    kq *= j
        'Next

        'Console.WriteLine("Giai thua cua {0} la {1}", n, kq)

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
