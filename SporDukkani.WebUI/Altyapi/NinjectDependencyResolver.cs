using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Moq;
using SporDukkani.Veriler.Soyut;
using SporDukkani.Veriler.Varliklar;
using SporDukkani.Veriler.Somut;

namespace SporDukkani.WebUI.Altyapi
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IUrunlerFabrikasi>().To<EFUrunFabrikasi>();
        }
    }
}