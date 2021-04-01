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
            // services.RegisterSingleton<RandomGuidGenerator>();
            
            // services.RegisterTransient<RandomGuidGenerator>();

            services.RegisterSingleton<IRandomGuidProvider, RandomGuidProvider>();
            services.RegisterTransient<ISomeService, SomeServiceOne>();

            var container = services.GenerateContainer();
            
            // var serviceFirst = container.GetService<RandomGuidGenerator>();
            // var serviceSecond = container.GetService<RandomGuidGenerator>();

            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();

            // Console.WriteLine(serviceFirst.RandomGuid);
            // Console.WriteLine(serviceSecond.RandomGuid);
            
            serviceFirst.PrintSomething();
            serviceSecond.PrintSomething();
        }
    }
}