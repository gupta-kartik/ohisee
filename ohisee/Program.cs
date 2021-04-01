using System;
using ohisee.DependencyInjection;

namespace ohisee
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new DiServiceCollection();
            
            // services.RegisterSingleton(new RandomGuidGenerator());
            services.RegisterSingleton<RandomGuidGenerator>();


            var container = services.GenerateContainer();
            
            var serviceFirst = container.GetService<RandomGuidGenerator>();
            var serviceSecond = container.GetService<RandomGuidGenerator>();

            Console.WriteLine(serviceFirst.RandomGuid);
            Console.WriteLine(serviceSecond.RandomGuid);
        }
    }
}