using System;

namespace log_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            // Composite formatting
            Console.WriteLine("N1: {0}, N2: {1}, N3: {2}, N4: {3}", n1, n2, n3, n4);
            //Console.WriteLine();
            //Console.WriteLine("N1: {0}, N2: {1}, N4: {3}", n1, n2, n4); // Error: Index based, test it
            Console.WriteLine();
            Console.WriteLine("N1: {0}, N2: {1}, N4: {2}", n1, n2, n4);
            Console.WriteLine();
            // String interpolation:
            Console.WriteLine($"N1: {n1}, N2: {n2}, N3: {n3}, N4: {n4}");
        }
    }
}
