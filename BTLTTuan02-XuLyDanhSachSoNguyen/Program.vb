﻿Imports System

Module Program
    Sub Main(args As String())
        Dim ds As Integer()
        ReDim ds(-1)
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

    Sub ThemPhanTu(ByRef ds As Integer())
        Console.Write("Nhap phan tu can them vao danh sach: ")
        Dim value As Integer = Integer.Parse(Console.ReadLine())
        ThemPhanTuVaoDanhSach(ds, value)
    End Sub

    Sub ThemPhanTuVaoDanhSach(ByRef ds As Integer(), ByVal value As Integer)
        Dim n As Integer = ds.Length
        ReDim Preserve ds(ds.Length) 'Xin cấp phát mảng có n+1 phần tử
        ds(n) = value
    End Sub

    Sub ThemPhanTuVaoViTri(ByRef ds As Integer(), ByVal pos As Integer, ByVal value As Integer)
        Dim n As Integer = ds.Length
        ReDim Preserve ds(ds.Length) 'Xin cấp phát mảng có n+1 phần tử
        For i As Integer = n To pos + 1 Step -1
            ds(i) = ds(i - 1)
        Next
        ds(pos) = value
    End Sub

    Sub HienThiDanhSach(ByVal ds As Integer())
        Console.Write("Hien thi danh sach: ")
        For i As Integer = 0 To ds.Length - 1
            Console.Write("{0}, ", ds(i))
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