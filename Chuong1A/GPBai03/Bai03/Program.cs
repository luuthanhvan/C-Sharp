using System;

namespace Bai03{
    class Program{
        static void Main(string[] args){
            float h;
            string str;

            Console.WriteLine("Enter height of the square; ");
            str = Console.ReadLine();

            h = Convert.ToSingle(str);

            float perimeter = h * 4;
            float acreage = h * h;

            Console.WriteLine("Perimeter of the square is {0}", perimeter);
            Console.WriteLine("Acreage of the square is {0}", acreage);

            Console.ReadLine();
        }
    }
}
