using System;

namespace Bai08{
    class Program{
        // S1 = 1 + 2 + ... + n
        static int S1(int n){
            int result = 0;
            for(int i = 1; i <= n; i++){
                result += i;
            }
            return result;
        }

        // S2 = 1 + 1/2 + 1/3 + ... + 1/n
        static float S2(int n){
            float result = 1;
            for (int i = 2; i <= n; i++){
                result += ((float)1 / (float)i);
            }
            return result;
        }

        static void Main(string[] args){
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            int s1 = S1(n);
            float s2 = S2(n);

            Console.WriteLine("S1 = {0}", s1);
            Console.WriteLine("S2 = {0}", s2);

            Console.ReadLine();
        }
    }
}
