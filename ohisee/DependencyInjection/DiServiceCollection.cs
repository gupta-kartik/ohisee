using System.Collections.Generic;

namespace ohisee.DependencyInjection
{
    public class DiServiceCollection
    {
        private List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();

        public void RegisterSingleton<TService>(TService implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetime.Singleton));
        }

        public DiContainer GenerateContainer()
        {
            return new DiContainer(_serviceDescriptors);
        }
    }
}