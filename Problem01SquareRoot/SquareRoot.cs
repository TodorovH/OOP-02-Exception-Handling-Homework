using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new Exception("Invalid Number");
                }
                double result = Math.Sqrt(n);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
