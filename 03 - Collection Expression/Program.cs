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

            // Exemplo com range: cria uma lista de números de 1 a 10
            var rangeList = [1..10]; // C# 12 permite criar ranges diretamente
            Console.WriteLine("Range list:");
            foreach (var num in rangeList)
                Console.WriteLine(num); 

            // exemplo com outros tipos de coleção
            var dictionary = [1 => "one", 2 => "two", 3 => "three"];
            Console.WriteLine("Dictionary:");
            foreach (var kvp in dictionary)
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            
            // exemplo com tuplas
            var tupleList = [(1, "one"), (2, "two"), (3, "three")];
            Console.WriteLine("Tuple list:");
            foreach (var (key, value) in tupleList)
                Console.WriteLine($"{key} => {value}");
            
            // exemplo com arrays
            var array = [1, 2, 3, 4, 5];
            Console.WriteLine("Array:");
            foreach (var num in array)
                Console.WriteLine(num);

            // exemplo com strings
            var stringList = ["apple", "banana", "cherry"];
            Console.WriteLine("String list:");
            foreach (var str in stringList)
                Console.WriteLine(str);

            // exemplo com listas de objetos
            var objectList = [new { Name = "Alice" }, new { Name = "Bob" }, new { Name = "Charlie" }];
            Console.WriteLine("Object list:");
            foreach (var obj in objectList)
                Console.WriteLine(obj.Name);
        }
    }
}
