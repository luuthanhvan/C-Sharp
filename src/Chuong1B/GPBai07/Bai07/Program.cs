using System;

namespace Bai07{
    class Program{
        static bool isLeafYear(int year){
            return ((year % 4 == 0) || (year % 400 == 0) && (year % 100 != 0)); 
        }

        static void Main(string[] args){
            int year;

            Console.Write("Nhap vao 1 nam: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (isLeafYear(year))
                Console.WriteLine("{0} la nam nhuan", year);
            else
                Console.WriteLine("{0} khong phai la nam nhuan", year);

            Console.ReadLine();
        }
    }
}
