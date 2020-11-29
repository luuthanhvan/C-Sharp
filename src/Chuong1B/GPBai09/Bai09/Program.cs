using System;

namespace Bai09{
    class Program{
        static void display(int n){
            for(int i = 1; i <= n; i++){
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static int sum(int n){
            int total = 0;
            for (int i = 1; i <= n; i++){
                total += i;
            }
            return total;
        }

        static float avg(int sum, int n){
            return (float)sum / (float)n;
        }
        static void Main(string[] args){
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            int total = sum(n);

            display(n);
            Console.WriteLine("Sum = {0}", total);
            Console.WriteLine("Average = {0}", avg(total, n));

            Console.ReadLine();
        }
    }
}
