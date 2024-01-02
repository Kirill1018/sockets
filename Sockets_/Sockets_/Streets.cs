using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sockets_
{
    internal class Streets
    {
        public static void Streets_(string[] streets, Socket socket)
        {
            for (int x = 0; x < streets.Length; x++)
            {
                Socket socket_ = socket.Accept();
                Console.WriteLine($"от {socket_.RemoteEndPoint}");
                socket_.Send(Encoding.Default.GetBytes(streets[x]));
                socket_.Shutdown(SocketShutdown.Both);
            }
        }
    }
}