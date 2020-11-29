using System;

namespace Bai01{
    class Program{
        static void Main(string[] args){
            string str;
            int num1, num2, num3, result;

            Console.WriteLine("Enter number 1: ");
            str = Console.ReadLine();
            num1 = Convert.ToInt32(str);

            Console.WriteLine("Enter number 2: ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str);
            result = Math.Min(num1, num2);

            Console.WriteLine("Enter number 3: ");
            str = Console.ReadLine();
            num3 = Convert.ToInt32(str);
            result = Math.Min(result, num3);

            Console.WriteLine("min({0}, {1}, {2}) = {3}", num1, num2, num3, result);

            Console.ReadLine();
        }
    }
}
