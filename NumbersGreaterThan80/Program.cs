using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NumbersGreaterThan80
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };

            showNumbersGreaterThan80(numbers);

            void showNumbersGreaterThan80(List<int> numbers)
            {
                var result = from n in numbers
                             where n > 80
                             select n;

                Console.WriteLine("Numbers greater than 80 are:");
                foreach (var num in result)
                {
                    Console.WriteLine(num);
                }
            }


        }

        
    }
}
