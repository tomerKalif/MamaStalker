using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ServerAbstractions;

namespace ServerImp
{
    class StalkerServer : IServer
    {
        private TcpListener _listener;
        public StalkerServer(string ip , string port)
        {
            IPAddress ipAd = IPAddress.Parse(ip);
            _listener = new TcpListener(ipAd, int.Parse(port));
        }
        public async Task ListenToClients()
        {
            _listener.Start();
            TcpClient client = null;
            Console.WriteLine("waiting for clients");
            for (int i = 0; i < 10; i++)
            {
                client = _listener.AcceptTcpClient();
                IClientHandler a = new ClientHandler(client);
                Task.Run(() => a.RunClient());

            }
        }

        public async Task StartServer()
        {
            await ListenToClients();
        }
    }
}
