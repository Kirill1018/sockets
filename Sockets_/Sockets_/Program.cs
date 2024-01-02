using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Sockets_
{
    internal class Program
    {
        static void Main(string[] args) => Server();
        public static void Server()
        {
            string street1_of_115547_ind = "бирюлёвская улица", street2_of_115547_ind = "загорьевский проезд", street3_of_115547_ind = "лебедянская улица";
            string street4_of_115547_ind = "михневская улица", street5_of_115547_ind = "михневский проезд";
            string[] streets1 = { street1_of_115547_ind, street2_of_115547_ind, street3_of_115547_ind,
                street4_of_115547_ind, street5_of_115547_ind };
            string street1_of_121170_ind = "улица 1812 года", street2_of_121170_ind = "улица братьев фонченко", street3_of_121170_ind = "улица генерала ермолова";
            string street4_of_121170_ind = "улица дениса давыдова", street5_of_121170_ind = "улица кульнева", street6_of_121170_ind = "кутузовский проезд";
            string street7_of_121170_ind = "кутузовский проспект", street8_of_121170_ind = "площадь победы", street9_of_121170_ind = "поклонная улица";
            string[] streets2 = { street1_of_121170_ind, street2_of_121170_ind, street3_of_121170_ind,
                street4_of_121170_ind, street5_of_121170_ind, street6_of_121170_ind,
                street7_of_121170_ind, street8_of_121170_ind, street9_of_121170_ind };
            string street1_of_125009_ind = "улица большая дмитровка", street2_of_125009_ind = "большая никитская улица", street3_of_125009_ind = "большая садовая улица";
            string street4_of_125009_ind = "большой гнездниковский переулок", street5_of_125009_ind = "большой кисловский переулок", street6_of_125009_ind = "брюсов переулок";
            string street7_of_125009_ind = "газетный переулок", street8_of_125009_ind = "георгиевский переулок", street9_of_125009_ind = "глинищевский переулок";
            string street10_of_125009_ind = "дегтярный переулок", street11_of_125009_ind = "елисеевский переулок", street12_of_125009_ind = "калашный переулок";
            string street13_of_125009_ind = "камергерский переулок", street14_of_125009_ind = "козицкий переулок", street15_of_125009_ind = "копьевский переулок";
            string street16_of_125009_ind = "красная площадь";
            string[] streets3 = { street1_of_125009_ind, street2_of_125009_ind, street3_of_125009_ind,
                street4_of_125009_ind, street5_of_125009_ind, street6_of_125009_ind,
                street7_of_125009_ind, street8_of_125009_ind, street9_of_125009_ind,
                street10_of_125009_ind, street11_of_125009_ind, street12_of_125009_ind,
                street13_of_125009_ind, street14_of_125009_ind, street15_of_125009_ind,
                street16_of_125009_ind };
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.Bind(new IPEndPoint(new IPAddress(new byte[] { 192, 168, 1,
                130 }), 2019));
            socket.Listen(5);
            Console.WriteLine("ожидание входящего соединения");
            while (true)
            {
                Streets.Streets_(streets1, socket);
                Streets.Streets_(streets2, socket);
                Streets.Streets_(streets3, socket);
            }
        }
    }
}