using System;
using System.Net;

namespace WebsocketServerData
{
        public class Data
        {
            public Action<string> Log { get; private set; }
            public HttpListener Listener { get; private set; }
            public string Address { get; private set; }

            public Data()
            {

            }

            public Data(Action<string> _log, HttpListener _listener, string _address)
            {
                this.Log = _log;
                this.Listener = _listener;
                this.Address = _address;
            }

            static public void Main(String[] args)
            {

            }
        }
}
