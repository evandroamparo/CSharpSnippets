using System;

int? y = null;
int z = 10;

// Usando operador ternário:
int x1 = y.HasValue ? y.Value : z;

// Usando o operador de coalescência (??):
int x2 = y ?? z;

// Using as operator with null check
var person1 = GetPerson();
if (person1 == null)
    throw new InvalidOperationException("Object is null");

// Using as operator without null check
var person2 = GetPerson() ?? throw new InvalidOperationException("Object is null");

Person GetPerson() => new Person();

class Person
{
}
