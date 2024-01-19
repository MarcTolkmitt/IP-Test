using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IP_Test
{
    internal class Program
    {
        static void Main( string[] args )
        {
            // Ausgabe der IP-Addresse
            IPHostEntry ipHostInfo = Dns.GetHostEntryAsync( "127.0.0.1" ).Result;
            IPAddress iPAddress = ipHostInfo.AddressList[0];
            string lokalName = Dns.GetHostName();
            Console.WriteLine( $"Lokaler Náme ist {lokalName}" );
            IPHostEntry ipHostLokal = Dns.GetHostEntryAsync( lokalName ).Result;
            IPAddress lokalAddress = ipHostLokal.AddressList[0];
            Console.WriteLine( $"Erste IP-Nummer : {iPAddress}\nZweite IP-Nummer: {lokalAddress}" );

            Console.WriteLine( "\ndie gesamte Liste:");
            foreach( IPAddress address in ipHostLokal.AddressList )
            {
                Console.WriteLine( address.ToString() );

            }

            // Stop am Ende
            Console.WriteLine( "Enter zum beenden..." );
            Console.ReadLine();
        }
    }
}
