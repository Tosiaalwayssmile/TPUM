using Newtonsoft.Json;
using System;
using WebsocketServerData;
using WebsocketServerLogic.DTOs;
using WebsocketServerData.Websockets;
using WebsocketServerData.Observer;

namespace WebsocketServerLogic
{
    public class DiscountObserver : IObserver<PromotionEvent>
    {
        private WebSocketConnection _connection;
        public DiscountObserver(WebSocketConnection connection)
        {
            _connection = connection;
        }

        public void OnCompleted()
        {

        }

        public async void OnError(Exception error)
        {
            await _connection.SendAsync($"Error occured. Failed to fetch current promotion: {error.Message}");
        }

        public async void OnNext(PromotionEvent value)
        {
            Message message;

            lock (value)
            {
                Console.WriteLine("Cyclic message:", value);
                DiscountCodeDTO code = DTOMapper.DiscountCode2DTO(value.DiscountCode);
                string body = JsonConvert.SerializeObject(code);
                message = new Message() { Action = EndpointAction.PUBLISH_DISCOUNT_CODE.GetString(), Type = "DiscountCodeDTO", Body = body };
            }

            Console.WriteLine($"Promotion: {message}");

            try
            {
                await _connection.SendAsync(JsonConvert.SerializeObject(message));
            }
            catch (Exception) { }
        }
    }
}
