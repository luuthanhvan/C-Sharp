using System;

namespace Bai01{
    class Program{
        static void Main(string[] args){
            int n;
            string str;
            Console.WriteLine("Enter a number: ");
            str = Console.ReadLine();

            // convert a string to number
            n = Convert.ToInt32(str);

            if (n % 2 == 0)
                Console.WriteLine("{0} is an even number", n);
            else
                Console.WriteLine("{0} is an odd number", n);

            if(n > 0)
                Console.WriteLine("{0} is a positve number", n);
            else
                Console.WriteLine("{0} is a negative number", n);

            Console.ReadLine();
        }
    }
}
