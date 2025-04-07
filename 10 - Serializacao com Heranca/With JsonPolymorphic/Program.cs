using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializationInheritanceExample
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$baseType")]
    [JsonDerivedType(typeof(LoginEvent), "login")]
    [JsonDerivedType(typeof(ErrorEvent), "error")]
    public class Event
    {
        public DateTime Timestamp { get; set; }
        public string Source { get; set; }
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
                Source = "App",
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
            //    "Source": "App"
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
