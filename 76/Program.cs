using System;

namespace _76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableka konwersji stopni Celsujsza na stopnie  Fahrenheita");
            Console.WriteLine();
            Pętla();

        }
        public static void Pętla()
        {
            Console.WriteLine("Stopnie Celsujsze             Stopnie Fahrenheita ");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i <= 20; i++)
            {
                double F = ((9.0 / 5.0) * i) + 32.0;
                Console.WriteLine($"{i}                            {F.ToString("n")}");
            }
        }
    }
}
