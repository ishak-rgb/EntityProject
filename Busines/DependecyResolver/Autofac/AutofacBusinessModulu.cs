using Autofac;
using Autofac.Extras.DynamicProxy;
using Busines.Abstrac;
using Busines.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAcsess.abstrac;
using DataAcsess.Concrete.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Busines.DependecyResolver.Autofac
{
    public class AutofacBusinessModulu:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EFProductDal>().As<IProductDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }



    }
}
