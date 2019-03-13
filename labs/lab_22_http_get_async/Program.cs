using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace lab_22_http_get_async
{
    class Program
    {
        static void Main(string[] args)
        {
            // async read of htt 

            Uri bbc01 = new Uri("http://www.bbc.co.uk");
            Uri bbc02 = new Uri("https://www.bbc.co.uk");

            Console.WriteLine(bbc01.Host);
            Console.WriteLine(bbc01.Port);
            
            Console.WriteLine(bbc01.Host);
            Console.WriteLine(bbc01.Port);

            // simplest way to read data is with 'WebCLient'

            var bbcWebClient = new WebClient { Proxy = null };
            bbcWebClient.DownloadFile(bbc01, "locl-copt-of-bbc01.html");
            Console.WriteLine(File.ReadAllText("locl-copt-of-bbc01.html"));
        }
    }
}
