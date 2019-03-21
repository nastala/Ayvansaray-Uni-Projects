
using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding myBinding = new BasicHttpBinding();
            EndpointAddress myEndpoint = new EndpointAddress("http://localhost:63503/Service1.svc");
            ChannelFactory<IService1> myChannelFactory = new ChannelFactory<IService1>(myBinding, myEndpoint);
            var result = myChannelFactory.CreateChannel().Test();
            result = myChannelFactory.CreateChannel().GetData(5);
            Console.ReadKey();
        }
    }
}
