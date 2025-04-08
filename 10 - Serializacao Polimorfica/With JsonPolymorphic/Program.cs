using System.Text.Json;
using System.Text.Json.Serialization;

// O exemplo abaixo mostra como usar a serialização polimórfica com JsonSerializer
// para serializar e desserializar objetos de classes derivadas de uma classe base.
// A classe base Event tem duas classes derivadas: LoginEvent e ErrorEvent.
// A serialização polimórfica permite que o JsonSerializer saiba qual tipo de classe derivada
// deve ser usada durante a serialização e desserialização, usando os atributos JsonPolymorphic
// e JsonDerivedType

namespace SerializationInheritanceExample
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$baseType")]
    [JsonDerivedType(typeof(LoginEvent), "login")]
    [JsonDerivedType(typeof(ErrorEvent), "error")]
    public class Event
    {
        public DateTime Timestamp { get; set; }
    }

    public class LoginEvent : Event
    {
        public string User { get; set; }
    }

    public class ErrorEvent : Event
    {
        public string ErrorMessage { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Event eventMessage = new LoginEvent
            {
                Timestamp = DateTime.Now,
                User = "Alice"
            };

            // Exemplo 1 - usando jsonpolymorphic
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(eventMessage, options);
            Console.WriteLine("Serialized event:");
            Console.WriteLine(json);
            // {
            //    "$baseType": "login",
            //    "User": "Alice",
            //    "Timestamp": "2025-04-06T19:28:00.3229856-03:00",
            // }

            Event deserialized = JsonSerializer.Deserialize<Event>(json);
            string message = deserialized switch
            {
                LoginEvent loginEvent => $"Event type: Login, User = {loginEvent.User}",
                ErrorEvent errorEvent => $"Event type: Error, ErrorMessage = {errorEvent.ErrorMessage}",
                _ => "Event type: unknown."
            };
            Console.WriteLine(message); // Event type: Login, User = Alice
        }
    }
}
