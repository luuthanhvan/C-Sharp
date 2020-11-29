using System;

namespace Bai04{
    class Program{
        static void Main(string[] args){
            float a, b, c, delta;
            string str;

            Console.Write("a = ");
            str = Console.ReadLine();
            a = Convert.ToSingle(str);

            Console.Write("b = ");
            str = Console.ReadLine();
            b = Convert.ToSingle(str);

            Console.Write("c = ");
            str = Console.ReadLine();
            c = Convert.ToSingle(str);

            delta = (b * b) - (4 * a * c);

            if (delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else 
                if(delta == 0){
                    float result = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", result);
                }
                else{
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet x1 = {0}, x2 = {1}", x1, x2);
                }

            Console.ReadLine();
        }
    }
}
