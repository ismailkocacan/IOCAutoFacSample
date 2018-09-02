using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using IOCAutoFacSample.Service;

public class IOCConfig
{
    public static void Configure()
    {
        var builder = new ContainerBuilder();
        builder.RegisterControllers(Assembly.GetExecutingAssembly());
        builder.RegisterType<EntityService>().As<IEntityService>();
        IContainer container = builder.Build();
        DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
    }
}