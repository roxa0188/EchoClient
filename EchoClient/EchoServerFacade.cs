using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace EchoClient
{
    class EchoServerFacade
    {
        private NetworkStream netStream;
        private int port;
        private StreamReader reader;
        private StreamWriter writer;
        private string serverName;
        private Socket serverSocket;

        private void Close()
        {

        }

        public void Dispose()
        {

        }

        public void Echo()
        {

        }

        public EchoServerFacade()
        {

        }

        public void EchoUpper()
        {

        }

        private void Open()
        {

        }

        private void ReceiveFromServer()
        {

        }

        private void SendToServer()
        {

        }
    }
}
