using System;

namespace management_app
{
    public class TOA_DO
    {
        public int x;
        public int y;

        public TOA_DO()
        {
            this.x = 0;
            this.y = 0;
        }

        public TOA_DO(int x0, int y0)
        {
            this.x = x0;
            this.y = y0;
        }

        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap x: ");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y: ");
            this.y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(TOA_DO b)
        {
            double kq;
            kq = Math.Sqrt(Math.Pow(this.x - b.x, 2) + Math.Pow(this.y - b.y, 2));
            return kq;
        }
    }
    public class TAM_GIAC
    {
        public TOA_DO A, B, C;
        public double chuVi;

        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this.A = new TOA_DO();
            this.A.Nhap("Nhap diem A: ");
            this.B = new TOA_DO();
            this.B.Nhap("Nhap diem B: ");
            this.C = new TOA_DO();
            this.C.Nhap("Nhap diem C: ");
        }

        public double TinhChuVi()
        {
            double AB, BC, AC;
            AB = this.A.TinhKhoangCach(B);
            BC = this.B.TinhKhoangCach(C);
            AC = this.C.TinhKhoangCach(A);
            this.chuVi = AB + BC + AC;
            return this.chuVi;
        }

    }

    class Program
    {

        public static void Sort(TAM_GIAC[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].chuVi > arr[j].chuVi)
                    {
                        TAM_GIAC temp = new TAM_GIAC();
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static TAM_GIAC[] NhapDanhSachTG(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            int n = int.Parse(Console.ReadLine());
            TAM_GIAC[] dsTamGiac = new TAM_GIAC[n];
            for (int i = 0; i < n; i++)
            {
                dsTamGiac[i] = new TAM_GIAC();
                dsTamGiac[i].NhapTamGiac($"Nhap tam giac thu {i + 1}");
                dsTamGiac[i].chuVi = dsTamGiac[i].TinhChuVi();
                Console.WriteLine($"Chu vi tam giac thu {i + 1} la {dsTamGiac[i].chuVi}");
            }
            return dsTamGiac;
        }

        public static void XuatDanhSachTG(TAM_GIAC[] dsTamGiac)
        {
            Console.WriteLine("DS Tam giac da sap xep theo chu vi tu nho den lon: ");
            for (int i = 0; i < dsTamGiac.Length; i++)
            {
                Console.WriteLine($"Tam giac thu {i+1}: " +
                    $"({dsTamGiac[i].A.x},{dsTamGiac[i].A.y}), " +
                    $"({dsTamGiac[i].B.x},{dsTamGiac[i].B.y}), " +
                    $"({dsTamGiac[i].C.x},{dsTamGiac[i].C.y})");
            }
        }

        static void Main(string[] args)
        {
            TAM_GIAC[] dsTamGiac = NhapDanhSachTG("Nhap so luong tam giac: ");
            Sort(dsTamGiac);
            XuatDanhSachTG(dsTamGiac);
        }
    }
}
