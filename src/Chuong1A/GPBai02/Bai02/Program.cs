using System;

namespace Bai02{
    class Program{
        static void Main(string[] args){
            float width, height;
            string str1, str2;
            Console.WriteLine("Enter width: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter height: ");
            str2 = Console.ReadLine();

            width = Convert.ToSingle(str1);
            height = Convert.ToSingle(str2);

            float perimeter = (width + height) * 2;
            float acreage = width * height;

            Console.WriteLine("Perimeter of the rectangle is {0}", perimeter);
            Console.WriteLine("Acreage of the rectangle is {0}", acreage);

            Console.ReadLine();
        }
    }
}
