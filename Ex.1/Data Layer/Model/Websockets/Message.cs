using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Websockets
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
