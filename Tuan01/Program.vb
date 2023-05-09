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

        Dim n As Integer
        Dim kq As Long
        Console.WriteLine("Chuong trinh tinh giai thua")
        Console.Write("Nhap n: ")
        n = Integer.Parse(Console.ReadLine())

        kq = 1
        Dim i As Integer = 1
        While i <= n
            kq *= i
            i += 1
        End While

        kq = 1
        For j As Integer = 1 To n
            kq *= j
        Next

        Console.WriteLine("Giai thua cua {0} la {1}", n, kq)

    End Sub
End Module
