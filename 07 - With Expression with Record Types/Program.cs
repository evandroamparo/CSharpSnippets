// O operador 'with'  cria uma cópia de um objeto, 
// alterando apenas as propriedades especificadas.

// exemplo de with com record 
Person person1 = new("Bob", 25);
Person person2 = person1 with { Age = 26 }; // Name = "Bob", Age = 26

Console.WriteLine("Original: " + person1);
Console.WriteLine("Modified: " + person2);

// exemplo de with com struct
var point1 = new Point { X = 10, Y = 20 };
var point2 = point1 with { Y = 30 }; // X = 10, Y = 30

Console.WriteLine($"Original point: ({point1.X}, {point1.Y})");
Console.WriteLine($"Modified point: ({point2.X}, {point2.Y})");

public record Person(string Name, int Age);

public struct Point
{
    public int X { get; init; }
    public int Y { get; init; }
}