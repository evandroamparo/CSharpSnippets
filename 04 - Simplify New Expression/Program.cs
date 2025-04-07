using System;

var date1 = new DateTime(2030, 1, 30);

// Sintaxe simplificada com target-typed new:
DateTime date2 = new(2030, 1, 30);

Console.WriteLine($"date 1: {date1}");
Console.WriteLine($"date 2: {date2}");
