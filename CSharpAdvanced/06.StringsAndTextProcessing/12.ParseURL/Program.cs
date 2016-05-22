using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            Console.WriteLine(UrlParser(url));
        }

        private static string UrlParser(string url)
        {
            Uri uri = new Uri(url);
            // server
            string server = uri.Host;
            // protocol
            string protocol = uri.Scheme;
            // resource
            string resource = uri.LocalPath;

            StringBuilder result = new StringBuilder();
            result.Append("[protocol] = ")
                  .Append(protocol + "\n")
                  .Append("[server] = ")
                  .Append(server + "\n")
                  .Append("[resource] = ")
                  .Append(resource);
            return result.ToString();
        }
    }
}
