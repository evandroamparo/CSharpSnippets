Order order = new()
{
    Items = 3,
    TotalValue = 100m
};

// if tradicional sem pattern matching:
if (order != null && order.Items > 2 && order.TotalValue > 50)
{
    Console.WriteLine("Order qualifies for discount.");
}
else
{
    Console.WriteLine("Order does not qualify for discount.");
}

// Usando pattern matching para verificar múltiplas propriedades de uma vez:
// pattern matching é uma forma mais concisa e legível de verificar condições complexas
// e pode ser usado para verificar se um objeto é nulo e se atende a várias condições
// em uma única expressão. Isso pode tornar o código mais limpo e fácil de entender.
if (order is { Items: > 2, TotalValue: > 50 })
{
    Console.WriteLine("Order qualifies for discount.");
}
else
{
    Console.WriteLine("Order does not qualify for discount.");
}

public class Order
{
    public int Items { get; set; }
    public decimal TotalValue { get; set; }
}