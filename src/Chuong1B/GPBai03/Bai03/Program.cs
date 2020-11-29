using System;

namespace Bai03{
    class Program{
        static void Main(string[] args){
            float b, c, result;
            string str;

            Console.Write("b = ");
            str = Console.ReadLine();
            b = Convert.ToSingle(str);


            Console.Write("c = ");
            str = Console.ReadLine();
            c = Convert.ToSingle(str);

            if (b == 0 && c == 0)
                Console.WriteLine("Phuong trinh co vo so nghiem");
            else 
                if (b == 0 && c != 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else{
                    result = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem duy nhat: x = {0}", result);
                }

            Console.ReadLine();
        }
    }
}
