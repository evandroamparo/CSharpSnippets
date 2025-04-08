using System;

var date1 = new DateTime(2030, 1, 30);

// Sintaxe simplificada com target-typed new:
// Aqui o tipo é inferido a partir do contexto, então não precisamos repetir 'DateTime'
// na declaração da variável 'date2'.
// var date2 = new(2030, 1, 30) não é válido, pois o compilador não consegue inferir o tipo de 'date2'.
DateTime date2 = new(2030, 1, 30);

Console.WriteLine($"date 1: {date1}");
Console.WriteLine($"date 2: {date2}");
