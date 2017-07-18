using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Design
{
    //class MyApp
    //{

    //    static void Main()
    //    {

    //        LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
    //        LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
    //        LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
    //        LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

    //        if(b1==b2 && b2==b3 && b3 == b4)
    //        {
    //            Console.WriteLine("Same instance\n");

    //            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

    //            for(int i=0; i<15; i++)
    //            {
    //                string serverName = balancer.NextServer.Name;
    //                string serverIP = balancer.NextServer.IP;
    //                Console.WriteLine(serverName);
    //            }
    //        }

    //        Console.ReadKey();
    //    }
    //}

    sealed class LoadBalancer
    {
        private static readonly LoadBalancer _instance = new LoadBalancer();

        private List<Server> _servers;
        private Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server { Name="ServerI", IP="120.14.220.18"},
                new Server { Name = "ServerII", IP = "120.14.220.19" },
                new Server { Name = "ServerIII", IP = "120.14.180.19" },
                new Server { Name = "ServerIV", IP = "120.14.220.19" },
                new Server { Name = "ServerV", IP = "120.14.220.19" }
            };
        }
        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
    

    class Server
    {
        public string Name { get; set; }

        public string IP { get; set; }
    }
}
