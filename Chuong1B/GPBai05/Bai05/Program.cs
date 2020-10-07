using System;

namespace Bai05{
    class Program{
        static void Main(string[] args){
            string n;
            while (true){
                Console.Write("Nhap mot so: ");
                n = Console.ReadLine();
                if (Convert.ToInt32(n) > 0)
                    break;
                else
                    Console.WriteLine("Ban phai nhap mot so nguyen duong!");
            }

            Console.ReadLine();
        }
    }
}
