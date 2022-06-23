using System;

namespace SquareTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Decompose d = new Decompose();
            long n;
            do
            {
                Console.Write("Please insert the number to decompose: ");                
                long.TryParse(Console.ReadLine(), out n);
                var res = d.decompose(n);

                var message = "The decomposed result is: " + (res == null ? "null" : res);

                Console.WriteLine(message);
                
                Console.WriteLine("Press Enter to try again!");
                Console.ReadLine();
            } while (true);
        }
    }
}
