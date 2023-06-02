Imports System
Imports System.Collections

Module Program
    Sub Main(args As String())
        Dim ds As List(Of Integer) = New List(Of Integer)()
        Dim ChucNang As Integer
        Console.WriteLine("Chuong trinh xu ly danh sach so nguyen")
        While True
            Console.WriteLine("1. Them 1 phan tu vao danh sach")
            Console.WriteLine("2. Hien thi danh sach")
            Console.WriteLine("3. Tim phan tu co gia tri lon nhat")
            Console.WriteLine("4. Tinh gia tri trung binh")
            Console.WriteLine("5. Thoat")
            Console.Write("Chon chuc nang: ")
            ChucNang = Integer.Parse(Console.ReadLine())
            Select Case ChucNang
                Case 1
                    ThemPhanTu(ds)
                Case 2
                    HienThiDanhSach(ds)
                Case 3
                    TimPhanTuMax()
                Case 4
                    TinhGiaTriTrungBinh()
                Case 5
                    Exit While
            End Select

        End While
        Console.WriteLine("Ket thuc chuong trinh")
    End Sub

    Sub ThemPhanTu(ByRef ds As List(Of Integer))
        Console.Write("Nhap phan tu can them vao danh sach: ")
        Dim value As Integer = Integer.Parse(Console.ReadLine())
        ThemPhanTuVaoDanhSach(ds, value)
    End Sub

    Sub ThemPhanTuVaoDanhSach(ByRef ds As List(Of Integer), ByVal value As Integer)
        ds.Add(value)
    End Sub

    Sub ThemPhanTuVaoViTri(ByRef ds As List(Of Integer), ByVal pos As Integer, ByVal value As Integer)
        ds.Insert(pos, value)
    End Sub

    Sub HienThiDanhSach(ByVal ds As List(Of Integer))
        Console.Write("Hien thi danh sach: ")
        For i As Integer = 0 To ds.Count - 1
            Console.Write("{0} ", ds(i))
        Next
        Console.WriteLine()
    End Sub

    Sub TimPhanTuMax()
        Console.WriteLine("Tim phan tu co gia tri lon nhat")
    End Sub

    Sub TinhGiaTriTrungBinh()
        Console.WriteLine("Tinh gia tri trung binh")
    End Sub
End Module
