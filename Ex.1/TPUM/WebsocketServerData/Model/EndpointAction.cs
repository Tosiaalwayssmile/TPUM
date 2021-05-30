using System;

namespace WebsocketServerData.Websockets
{
    public enum EndpointAction
    {
        GET_BOOKS = 0,
        GET_USERS = 1,
        GET_DISCOUNT_CODES = 2,
        PUBLISH_DISCOUNT_CODE = 3,
        DISCONNECT = 4
    }
    public static class EndpointActionMethods
    {
        public static string GetString(this EndpointAction endpointAction)
        {
            return Enum.GetName(typeof(EndpointAction), endpointAction);
        }
    }
}
