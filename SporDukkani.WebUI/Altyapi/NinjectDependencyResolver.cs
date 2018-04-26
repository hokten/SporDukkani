﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Moq;
using SporDukkani.Veriler.Soyut;
using SporDukkani.Veriler.Varliklar;

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
            Mock<IUrunlerFabrikasi> sabit_veri = new Mock<IUrunlerFabrikasi>();
            sabit_veri.Setup(m => m.Urunler).Returns(new List<Urun> {
                new Urun { Isim="Futbol Topu", Fiyat=25m},
                new Urun { Isim="Sörf Tahtası", Fiyat=15m},
                new Urun { Isim="Koşu Ayakkabısı", Fiyat=34m}
                });
            kernel.Bind<IUrunlerFabrikasi>().ToConstant(sabit_veri.Object);
        }
    }
}