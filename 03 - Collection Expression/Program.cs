using System;
using System.Collections.Generic;

namespace CollectionExpression
{
    class Program
    {
        static void Main()
        {
            // Usando a sintaxe de collection expression (disponível no C# 12)
            List<int> numbers = [1, 2, 3, 4, 5];
            Console.WriteLine("Numbers using collection expression:");
            foreach (var num in numbers)
                Console.WriteLine(num);

            // Exemplo com coalesce: se 'maybeNull' for nulo, cria uma lista vazia
            List<int> maybeNull = null;
            var safeList = maybeNull ?? [];
            Console.WriteLine("Safe list count: " + safeList.Count);
            
            // exemplo com tuplas
            (int, string)[] tupleList = [(1, "one"), (2, "two"), (3, "three")];
            Console.WriteLine("Tuple list:");
            foreach (var (key, value) in tupleList)
                Console.WriteLine($"{key} => {value}");
            
            // exemplo com arrays
            int[] array = [1, 2, 3, 4, 5];
            Console.WriteLine("Array:");
            foreach (var num in array)
                Console.WriteLine(num);

            // exemplo com strings
            string[] stringList = ["apple", "banana", "cherry"];
            Console.WriteLine("String list:");
            foreach (var str in stringList)
                Console.WriteLine(str);
        }
    }
}
