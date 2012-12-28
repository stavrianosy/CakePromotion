using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace CakePromoServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Console WCF Based Host ***");
            using (ServiceHost host = new ServiceHost(typeof(CakePromoServiceLib.Main)))
            {
                host.Open();
                DisplayHostInfo(host);
                
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the enter key to terminate the service.");
                Console.ReadLine();
            }
        }
        static void DisplayHostInfo(ServiceHost serviceHost)
        {
            Console.WriteLine("*** Host Info ***");

            foreach (var se in serviceHost.Description.Endpoints)
            {
                Console.WriteLine("");

                Console.WriteLine("Address {0}: ", se.Address);
                Console.WriteLine("Binding {0}: ", se.Binding);
                Console.WriteLine("Contract {0}: ", se.Contract);

                Console.WriteLine("");
            }
            Console.WriteLine("***************");

        }
    }
}
