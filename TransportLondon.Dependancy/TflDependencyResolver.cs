using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TransportLondon.DAL;
using TransportLondon.Services;

namespace TransportLondon.Dependancy
{
    public class TflDependencyResolver : IDependencyResolver
    {
        readonly IUnityContainer _container;

        public TflDependencyResolver()
        {
            _container = new UnityContainer();
            _container.RegisterType<ITflProvider, TflApiProvider>();
            _container.RegisterType<ITflService, TflService>();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch
            {
                return null;
            }
        }
    }
}
