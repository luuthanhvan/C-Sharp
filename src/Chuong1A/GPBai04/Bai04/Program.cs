using System;

namespace Bai04{
    class Program{
        static void Main(string[] args) {
            string fullName, str;
            float math, physical, chemistry;

            Console.WriteLine("Enter your full name: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Enter your math score: ");
            str = Console.ReadLine();
            math = Convert.ToSingle(str);

            Console.WriteLine("Enter your physical score: ");
            str = Console.ReadLine();
            physical = Convert.ToSingle(str);

            Console.WriteLine("Enter your chemistry score: ");
            str = Console.ReadLine();
            chemistry = Convert.ToSingle(str);

            float avg = (math + physical + chemistry) / 3;

            Console.WriteLine("Full name: {0}", fullName.ToUpper());
            Console.WriteLine("Average score: {0:0.00}", avg);

            Console.ReadLine();
        }
    }
}
