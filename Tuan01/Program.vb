Imports System

Module Program
    Sub Main(args As String())
        Dim a As Double
        Dim b As Double
        Console.WriteLine("Chuong trinh cong 2 so")
        Console.Write("Nhap a: ")
        a = Double.Parse(Console.ReadLine())
        Console.Write("Nhap b: ")
        b = Double.Parse(Console.ReadLine())
        Console.WriteLine("Tong 2 so la: " & (a + b))
        Console.ReadLine()
    End Sub
End Module
