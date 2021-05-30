using DataLayer.Websockets;
using System.Net.WebSockets;

namespace DataLayer.Model
{
    public class WebSocketMessage
    {
        public delegate void void_string(string message);
        private static event void_string _onMessageRecieved;
        public static event void_string onMessageRecieved;

        private static SocketConnection _connection;
        private static WebsocketClient _websocketClient = new WebsocketClient("ws://localhost:9000/api");


        public static void OnMessageRecieved(string message)
        {
            onMessageRecieved?.Invoke(message);
        }

        public static async void Connect()
        {
            _connection = await _websocketClient.Connect(OnMessageRecieved);
        }

        public static async void Disconnect()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.DISCONNECT.GetString(), Type = WebSocketMessageType.Close.ToString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public static async void FetchUsers()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_USERS.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public static async void FetchBooks()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_BOOKS.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public static async void FetchCodes()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }

        public static async void FetchSingleCode()
        {
            if (_websocketClient.WebSocket.State == WebSocketState.Open)
            {
                Message messageSent = new Message() { Action = EndpointAction.GET_DISCOUNT_CODES.GetString() };
                await _connection.SendAsync(messageSent.ToString());
            }
        }
    }
}
