using System;
using System.Collections.Generic;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace WebsocketServerLogic
{
    public class WebsocketServer : IDisposable
    {
        public static WebsocketServer Instance { get; private set; }

        WebsocketServerData.Data data = new WebsocketServerData.Data();
        private DiscountPublisher _discountPublisher;
        public List<WebSocketConnection> Connections = new List<WebSocketConnection>();

        public WebsocketServer(Action<string> log, string address)
        {
            lock (data)
            {
                data = new WebsocketServerData.Data(log, new HttpListener(), address);
                data.Listener.Prefixes.Add(address);
            }

            _discountPublisher = new DiscountPublisher(TimeSpan.FromSeconds(10));
            _discountPublisher.Start();
            Instance = this;
        }

        public async Task Listen()
        {
            try
            {
                data.Listener.Start();

                data.Log($"Waiting for connections on {data.Address} ... ");


                while (true)
                {
                    HttpListenerContext httpListenerContext = await data.Listener.GetContextAsync();

                    if (httpListenerContext.Request.IsWebSocketRequest)
                    {
                        await InitializeConnection(httpListenerContext);
                    }

                }
            }

            catch (Exception e)
            {
                data.Log(e.ToString());
            }
        }
        private async Task InitializeConnection(HttpListenerContext context)
        {
            try
            {
                HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(subProtocol: null);
                WebSocketConnection connection = new WebSocketConnection(webSocketContext.WebSocket, data.Log);
                Connections.Add(connection);
                SubscribeToDiscounts(connection);
                data.Log($"Maintaining {Connections.Count} active connections.");
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.Close();
                data.Log($"Unable to establish connection: {ex.Message}.");
            }
        }

        private void SubscribeToDiscounts(WebSocketConnection connection)
        {
            var observer = new DiscountObserver(connection);
            _discountPublisher.Subscribe(observer);
        }

        public void Dispose()
        {
            Connections.ForEach(connection => connection?.Dispose());
            Connections.Clear();
        }
    }
}
