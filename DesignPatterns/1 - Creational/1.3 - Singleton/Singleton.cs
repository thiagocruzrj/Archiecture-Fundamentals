using System;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        public static void Executar()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if(b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Mesma Instancia\n");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Disparando Request para: "+ serverName);
            }
        }
    }
}