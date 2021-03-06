﻿using System;
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
            ToolTip urlTip = new ToolTip();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            while (true)
            {
                Cursor cursor = System.Windows.Forms.Cursor.Current; //need to declare cursor to check state...of course
                if (cursor == (Cursors.Hand)) //checks to see if cursor is a hand, i.e., a URL
                {

                    
                }
            }
        }

        static void unShorten(String link)
        {
            //makes an http request and looks at the response as the unshortened URL (URI)
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
            request.Proxy = null;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            String url = request.Address.ToString();

            Console.WriteLine("URL is: \n" + url);
            Console.ReadLine();
        }
    }
}
