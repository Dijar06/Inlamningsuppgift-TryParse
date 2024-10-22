using System;
using System.Security.Cryptography.X509Certificates;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            if (!TryParse(Console.ReadLine(), out resultat))
            {
                Console.WriteLine("Skriv in en siffra");
            }

        }
        public static bool TryParse(string s, out int result)
        {
            result = 0;

            try
            {
                result = int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}