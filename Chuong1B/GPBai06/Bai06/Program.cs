using System;

namespace Bai06{
    class Program{
        static bool isPrime(int number){
            for (int i = 2; i < Math.Sqrt(number); i++){
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args){
            int number;

            Console.WriteLine("Nhap mot so nguyen duong: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (isPrime(number))
                Console.WriteLine("{0} la so nguyen to", number);
            else
                Console.WriteLine("{0} khong phai la so nguyen to", number);

            Console.ReadLine();
        }
    }
}
