string[] words = ["apple", "banana", "cherry"];

// Abordagem usando Enumerable.Any()
// A regra CA1860 sugere evitar o uso de Enumerable.Any() para verificar se uma coleção tem elementos.
// Em vez disso, recomenda-se usar a propriedade Length ou Count, pois é mais eficiente.
// https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1860
bool hasWordsAny = words.Any();

// Abordagem usando a propriedade Length:
bool hasWordsLength = words.Length > 0;

Console.WriteLine($"Using Any(): {hasWordsAny}");
Console.WriteLine($"Using Length: {hasWordsLength}");
