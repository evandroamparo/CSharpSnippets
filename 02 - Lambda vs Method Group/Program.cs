using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaVsMethodGroup
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Using lambda expression:
            var evenNumbersLambda = numbers.Where(x => IsEven(x));

            // Using method group:
            var evenNumbersMethodGroup = numbers.Where(IsEven);

            Console.WriteLine("Even numbers using lambda:");
            foreach (var num in evenNumbersLambda)
                Console.WriteLine(num);

            Console.WriteLine("Even numbers using method group:");
            foreach (var num in evenNumbersMethodGroup)
                Console.WriteLine(num);
        }

        public static bool IsEven(int x) => x % 2 == 0;
    }
}
