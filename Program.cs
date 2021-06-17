using System;

namespace T03_05_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 2;
            int B = 3;
            int C = 6;
            int D = 8;
            int aux = D;

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.WriteLine("D = " + D);

            D = B;
            B = C;
            C = A;
            A = aux;

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.WriteLine("D = " + D);
        }
    }
}
