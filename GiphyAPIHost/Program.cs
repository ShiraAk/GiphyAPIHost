using GiphyAPIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GiphyAPIHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost calcHost = new ServiceHost(typeof(GiphyService));
            calcHost.Open();

            Console.ReadLine();
        }
    }
}
