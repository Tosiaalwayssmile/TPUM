namespace DataLayer.Model
{
    public class WebSocketMessage
    {
        public delegate void void_string(string message);

        public string Data { get; set; }

        public static void_string onMessageRecieved { get; set; }

        public static void OnMessageRecieved(string message)
        {
            onMessageRecieved?.Invoke(message);
        }
    }
}
