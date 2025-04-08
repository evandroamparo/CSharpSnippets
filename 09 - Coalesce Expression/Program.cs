using System;

int? y = null;
int z = 10;

// Usando operador ternário:
int x1 = y.HasValue ? y.Value : z;

// Usando o operador de coalescência (??):
int x2 = y ?? z;

// Verificando se um objeto é nulo:
var person1 = GetPerson();
if (person1 == null)
    throw new InvalidOperationException("Object is null");

// Usando ?? para verificar se um objeto é nulo e lançar uma exceção:
var person2 = GetPerson() ?? throw new InvalidOperationException("Object is null");

Person GetPerson() => null;

class Person
{
}
