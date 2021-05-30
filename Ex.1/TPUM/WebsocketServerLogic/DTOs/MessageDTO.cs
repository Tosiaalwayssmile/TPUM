using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsocketServerLogic.DTOs
{
    public class MessageDTO
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
