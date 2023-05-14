Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Dim dsSoNguyen As Integer()
        Dim n As Integer
        Console.WriteLine("Chuong trinh nhap vao danh sach so nguyen va tinh ra ket qua")
        NhapMang(dsSoNguyen)
        XuatMang(dsSoNguyen)

        Console.Write("Nhap them so luong phan tu: ")
        n = Integer.Parse(Console.ReadLine())
        ReDim Preserve dsSoNguyen(n - 1) 'Khai bao mang co n phan tu (tu 0 den n-1)
        For i As Integer = 0 To n - 1
            Console.Write("Nhap phan tu thu {0}: ", i + 1)
            dsSoNguyen(i) = Integer.Parse(Console.ReadLine())
        Next
        XuatMang(dsSoNguyen)
    End Sub

    'Ham nhap mang
    Sub NhapMang(ByRef ds As Integer())
        Console.Write("Nhap so luong phan tu: ")
        Dim n As Integer = Integer.Parse(Console.ReadLine())
        ReDim ds(n - 1) 'Khai bao mang co n phan tu (tu 0 den n-1)
        For i As Integer = 0 To n - 1
            Console.Write("Nhap phan tu thu {0}: ", i + 1)
            ds(i) = Integer.Parse(Console.ReadLine())
        Next
    End Sub

    'Ham xuat mang
    Sub XuatMang(dsSoNguyen As Integer())
        Console.Write("Mang co {0} phan tu: ", dsSoNguyen.Length)
        For i As Integer = 0 To dsSoNguyen.Length - 1
            Console.Write("{0} ", dsSoNguyen(i))
        Next
        Console.WriteLine()
    End Sub
End Module