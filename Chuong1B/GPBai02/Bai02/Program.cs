using System;

namespace Bai02{
    class Program{
        static void Main(string[] args)
        {
            string fullName, str;
            float score;

            Console.WriteLine("Nhap ho ten: ");
            fullName = Console.ReadLine();

            Console.WriteLine("Nhap diem thi cuoi ky: ");
            str = Console.ReadLine();
            score = Convert.ToSingle(str);

            if (score >= 8)
                Console.WriteLine("{0}: Gioi", fullName.ToUpper());
            else
                if (score >= 6.5 && score < 8)
                    Console.WriteLine("{0}: Kha", fullName.ToUpper());
                else
                    if (score >= 5 && score < 6.5)
                    Console.WriteLine("{0}: Trung binh", fullName.ToUpper());
                    else
                        Console.WriteLine("{0}: Yeu", fullName.ToUpper());

            Console.ReadLine();
        } 
    }
}
