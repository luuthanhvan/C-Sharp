using System;

namespace Bai05{
    class Program{
        static void Main(string[] args){
            int bacluong;
            int ngaycong;
            int phucap;
            string str;

            Console.WriteLine("Nhap bac luong: ");
            str = Console.ReadLine();
            bacluong = Convert.ToInt32(str);


            Console.WriteLine("Nhap ngay cong: ");
            str = Console.ReadLine();
            ngaycong = Convert.ToInt32(str);


            Console.WriteLine("Nhap phu cap: ");
            str = Console.ReadLine();
            phucap = Convert.ToInt32(str);

            int NCTL;
            if (ngaycong >= 25)
                NCTL = (ngaycong - 25) * 2 + 25;
            else
                NCTL = ngaycong;

            int tienlanh = bacluong * 650000 * NCTL + phucap;

            Console.WriteLine("Tien lanh: {0}", tienlanh);

            Console.ReadLine();
        }
    }
}
