using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sockets
{
    internal class Check_in
    {
        public static void Check_in_(TextBox box, ListBox list_box, List<string> places,
            string[] indexes)
        {
            if (box.Text == indexes[0])
            {
                for (int i = 0; i < 5; i++)
                {
                    using (Socket socket = new Socket(SocketType.Stream, ProtocolType.IP))
                    {
                        string serv_name = "192.168.1.130";
                        int port = int.Parse("2019");
                        IPEndPoint point = new IPEndPoint(Dns.GetHostAddresses(serv_name).Where(addr => addr.AddressFamily == AddressFamily.InterNetwork).First(), port);
                        socket.Connect(point);
                        byte[] response = new byte[1024];
                        Response.Response_(socket, response, list_box,
                            places, i, box);
                        socket.Shutdown(SocketShutdown.Both);
                    }
                }
            }
            else if (box.Text == indexes[1])
            {
                for (int i = 5; i < 14; i++)
                {
                    using (Socket socket = new Socket(SocketType.Stream, ProtocolType.IP))
                    {
                        string serv_name = "192.168.1.130";
                        int port = int.Parse("2019");
                        IPEndPoint point = new IPEndPoint(Dns.GetHostAddresses(serv_name).Where(addr => addr.AddressFamily == AddressFamily.InterNetwork).First(), port);
                        socket.Connect(point);
                        byte[] response = new byte[1024];
                        Response.Response_(socket, response, list_box,
                            places, i, box);
                        socket.Shutdown(SocketShutdown.Both);
                    }
                }
            }
            else if (box.Text == indexes[2])
            {
                for (int i = 14; i < 30; i++)
                {
                    using (Socket socket = new Socket(SocketType.Stream, ProtocolType.IP))
                    {
                        string serv_name = "192.168.1.130";
                        int port = int.Parse("2019");
                        IPEndPoint point = new IPEndPoint(Dns.GetHostAddresses(serv_name).Where(addr => addr.AddressFamily == AddressFamily.InterNetwork).First(), port);
                        socket.Connect(point);
                        byte[] response = new byte[1024];
                        Response.Response_(socket, response, list_box,
                            places, i, box);
                        socket.Shutdown(SocketShutdown.Both);
                    }
                }
            }
        }
    }
}