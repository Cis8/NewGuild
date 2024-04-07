using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace NewGuild.Combat
{
    public class ServiceLocator
    {
        private ServiceLocator() { }

        // singleton instance
        private static ServiceLocator _instance;

        // services
        private Dictionary<Type, IService> _services = new Dictionary<Type, IService>();

        private static void Initiailze() {
            // Register all the services
            //Provide(new LoggingHealthEventManager());
            Provide(new HealthEventManager());
        }

        /// <summary>
        /// Gets the service instance of the given type.
        /// </summary>
        /// <typeparam name="T">The type of the service to lookup.</typeparam>
        /// <returns>The service instance.</returns>
        public T Get<T>() where T : IService {
            var key = typeof(T);
            // Throws an exception if the service is not found with First
            var service = _services.First(t => key.IsAssignableFrom(t.Key));
            return (T)service.Value;
        }

        // Here we acceess the singleton instance through the Instance property, so that we prevent the NullReferenceException
        public static ServiceLocator Instance {
            get {
                if (_instance == null) {
                    _instance = new ServiceLocator();
                    Initiailze();
                }
                return _instance;
            }
        }

        public static void Provide<T>(T service) where T : IService {
            Instance._services[typeof(T)] = service;
        }

    }
}
