﻿using Newtonsoft.Json;

namespace WebsocketServerData
{
    public class Message
    {
        public string Action { get; set; }
        public string Params { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
