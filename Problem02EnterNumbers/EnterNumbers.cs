using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int temp = 0;
            List<int> numbers= new List<int>();
            while (numbers.Count < 10)
            {
                try
                {
                    int a = ReadNumber(start, end);
                    if (numbers.Count == 0)
                    {
                        numbers.Add(a);
                        temp = a;
                    }
                    else
                    {
                        if (temp >= a)
                        {
                            throw new ArithmeticException();
                        }
                        else if (temp < a)
                        {
                            numbers.Add(a);
                            temp = a;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter number between {0} and {1}!", start, end);
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("The next number have to be bigger!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid argument");
                }
            }
            
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        public static int ReadNumber(int start, int end)
        {
            int a = int.Parse(Console.ReadLine());
            if (!((a >= start) && (a <= end)))
            {
                throw new ArgumentOutOfRangeException();
            }
            return a;
        }
    }
}
