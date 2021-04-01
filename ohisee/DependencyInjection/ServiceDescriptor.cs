using System;

namespace ohisee.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; }
        
        public object Implementation { get; }
        
        public ServiceLifetime Lifetime { get; }

        public ServiceDescriptor(object implementation, ServiceLifetime lifetime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifetime;
        }
    }
}