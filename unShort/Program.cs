using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;


namespace unShort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {

            }
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
