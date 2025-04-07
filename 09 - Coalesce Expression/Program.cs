using System;

namespace CoalesceExample
{
    class Program
    {
        static void Main()
        {
            int? y = null;
            int z = 10;

            // Usando operador ternário:
            int x1 = y.HasValue ? y.Value : z;
            
            // Usando o operador de coalescência (??):
            int x2 = y ?? z;

            Console.WriteLine($"Using ternary: {x1}");
            Console.WriteLine($"Using null-coalescing: {x2}");

            // Using as operator with null check
            var person1 = GetPerson();
            if (person1 == null)
                throw new InvalidOperationException("Object is null");

            // Using as operator without null check
            var person2 = GetPerson() ?? throw new InvalidOperationException("Object is null");
        }

        private static Person GetPerson() => new Person();

        private class Person
        {
        }
    }
}
