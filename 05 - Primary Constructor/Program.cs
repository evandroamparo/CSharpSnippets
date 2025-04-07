using System;

namespace PrimaryConstructorExample
{
    // Exemplo usando record types com primary constructor (disponível em versões mais recentes do C#)


    // Without primary constructor
    public class Client
    {
        public string Name { get; }
        public int Age { get; }

        public Client(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // With primary constructor (C# 12+)
    public class Person(string Name, int Age)
    {
        public string Name { get; } = Name;
        public int Age { get; } = Age;
    }

    class Program
    {
        static void Main()
        {
            Person person = new("Alice", 30);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
