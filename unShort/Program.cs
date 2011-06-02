using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace unShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the link to be unshortened: ");
            string link = Console.ReadLine();
            unShorten(link);
        }

        static void unShorten(String link)
        {
            //makes an http request and looks at the response as the unshortened URL (URI)
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            String url = request.Address.ToString();

            Console.WriteLine("URL is: \n" + url);
            Console.ReadLine();
        }
    }

}
