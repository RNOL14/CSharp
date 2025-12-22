using System;
using System.Collections.Generic;

namespace Generics
{
    public class GenericCollections
    {
        public static void Run()
        {
            Console.WriteLine("Generic Collections:");

            List<int> numbers = new List<int> { 10, 20, 30 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
