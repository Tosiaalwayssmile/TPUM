﻿using System;
using System.Net;
using System.Threading.Tasks;

namespace WebsocketServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using WebsocketServer websocketServer = new WebsocketServer(Log, "http://localhost:9000/api/");
                await websocketServer.Listen();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Log("Unexpected error");
                Log(e.Message);
            }

        }

        private static readonly Action<string> Log = Console.WriteLine;

    }
}
