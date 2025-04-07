using System.Text.Json;

namespace SerializationInheritanceExample
{
    public class Event
    {
        public string EventType { get; set; }
        public DateTime Timestamp { get; set; }

        public Event()
        {
            EventType = GetType().Name.Replace("Event", "").ToLower();
        }
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

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize((object)eventMessage, options);
            Console.WriteLine("Serialized event:");
            Console.WriteLine(json);
            // {
            //   "User": "Alice",
            //   "EventType": "login",
            //   "Timestamp": "2025-04-06T19:42:49.2561837-03:00",
            // }

            Event deserialized = JsonSerializer.Deserialize<Event>(json);
            switch (deserialized?.EventType)
            {
                case "login":
                    ProcessLogin(JsonSerializer.Deserialize<LoginEvent>(json));
                    break;
                case "error":
                    ProcessError(JsonSerializer.Deserialize<ErrorEvent>(json));
                    break;
                default:
                    PocessUnknownEvent(deserialized);
                    break;
            }
            ;
        }

        private static void ProcessLogin(LoginEvent typedEvent)
        {
            Console.WriteLine($"Event type: Login, User = {typedEvent.User}");
            // Event type: Login, User = Alice
        }

        private static void ProcessError(ErrorEvent? errorEvent)
        {
            Console.WriteLine($"Event type: Error, ErrorMessage = {errorEvent?.ErrorMessage}");
            // Event type: Error, ErrorMessage = An error occurred.
        }

        private static void PocessUnknownEvent(Event? @event)
        {
            Console.WriteLine($"Event type: unknown, EventType = {@event?.EventType}");
            // Event type: unknown, EventType = ?
        }
    }
}
