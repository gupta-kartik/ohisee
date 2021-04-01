using System;
using System.Collections.Generic;
using System.Linq;

namespace ohisee.DependencyInjection
{
    public class DiContainer
    {
        private List<ServiceDescriptor> _serviceDescriptors;
        public DiContainer(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        public T GetService<T>()
        {
            var descriptor = _serviceDescriptors.SingleOrDefault(x => x.ServiceType == typeof(T));

            if (descriptor == null)
            {
                throw new Exception($"Service of type {typeof(T).Name} isn't registered");
            }

            if (descriptor.Implementation != null)
            {
                return (T) descriptor.Implementation;
            }

            return default;
        }
    }
}