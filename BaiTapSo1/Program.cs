
using System;

namespace BaiTapSo1
{
    class Program
    {
        class CacHinh
        {         
            public virtual void Xuat()
            {
                Console.WriteLine("Day la hinh ");
            }
        }
        class TamGiac : CacHinh
        {
            public override void Xuat()
            {
                Console.WriteLine("Day la hinh tam giac, co 3 canh.");
            }
        }
        class TuGiac : CacHinh
        {
            public override void Xuat()
            {
                Console.WriteLine("Day la tu giac co 4 canh.");
            }
        }
        class HinhBinhHanh: CacHinh
        {
            public override void Xuat()
            {
                Console.WriteLine("Day la hinh binh hanh co 4 canh, co 2 cap canh song song va khong co goc vuong.");
            }
        }
        class HinhVuong : CacHinh
        {
            public override void Xuat()
            {
                Console.WriteLine("Day la hinh vuong 4 canh, co 2 cap canh song song va vuong goc bang nhau.");
            }
        }
        class HinhChuNhat : CacHinh
        {
            public override void Xuat()
            {
                Console.WriteLine("Day la hinh chu nhat co 4 canh, co 2 cap canh song song khong bang nhau va vuong goc.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Cac hinh:  ");
            Console.WriteLine("1. Hinh tam giac: ");
            Console.WriteLine("2. Hinh tu giac: ");
            Console.WriteLine("3. Hinh binh hanh: ");
            Console.WriteLine("4. Hinh vuong: ");
            Console.WriteLine("5. Hinh chu nhat: ");
            Console.WriteLine("5. Thoat ");
            int choose = 0;
            do
            {
                Console.Write("Chon Hinh: ");
                choose = Int32.Parse(Console.ReadLine());
                switch(choose){
                    case 0:
                        break;
                    case 1:
                        TamGiac tamgiac = new TamGiac();
                        tamgiac.Xuat();
                        Console.ReadKey();
                        break;
                    case 2:
                        TuGiac tugiac = new TuGiac();
                        tugiac.Xuat();
                        Console.ReadKey();
                        break;
                    case 3:
                        HinhBinhHanh hbh = new HinhBinhHanh();
                        hbh.Xuat();
                        Console.ReadKey();
                        break;
                    case 4:
                        HinhVuong hv = new HinhVuong();
                        hv.Xuat();
                        Console.ReadKey();
                        break;
                    case 5:
                        HinhChuNhat hcn = new HinhChuNhat();
                        hcn.Xuat();
                        Console.ReadKey();
                        break;

                }
            } while (choose > 5 || choose < 0);
        }
    }
}
