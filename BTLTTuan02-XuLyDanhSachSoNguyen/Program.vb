Imports System

Module Program
    Sub Main(args As String())
        Dim ChucNang As Integer
        Console.WriteLine("Chuong trinh xu ly danh sach so nguyen")
        While True
            Console.WriteLine("1. Them 1 phan tu vao danh sach")
            Console.WriteLine("2. Hien thi danh sach")
            Console.WriteLine("3. Tim phan tu co gia tri lon nhat")
            Console.WriteLine("4. Tinh gia tri trung binh")
            Console.WriteLine("5. Thoat")
            ChucNang = Integer.Parse(Console.ReadLine())
            Select Case ChucNang
                Case 1
                    ThemPhanTu()
                Case 2
                    HienThiDanhSach()
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

    Sub ThemPhanTu()
        Console.WriteLine("Them phan tu vao danh sach")
    End Sub

    Sub HienThiDanhSach()
        Console.WriteLine("Hien thi danh sach")
    End Sub

    Sub TimPhanTuMax()
        Console.WriteLine("Tim phan tu co gia tri lon nhat")
    End Sub

    Sub TinhGiaTriTrungBinh()
        Console.WriteLine("Tinh gia tri trung binh")
    End Sub

End Module