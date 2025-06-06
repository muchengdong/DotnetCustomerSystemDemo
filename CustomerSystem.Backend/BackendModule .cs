﻿using System;
using System.Linq;
using Autofac;

namespace CustomerSystem.Backend {
    public class BackendModule : Module {
        protected override void Load(ContainerBuilder builder) {
            var serviceAssembly = AppDomain.CurrentDomain
                .GetAssemblies()
                .FirstOrDefault(t => t.GetName().Name == "CustomerSystem.Backend");

            if (serviceAssembly != null)
                builder.RegisterAssemblyTypes(serviceAssembly)
                    .Where(t => t.Name.EndsWith("Impl"))
                    .AsImplementedInterfaces()
                    .SingleInstance();
        }
    }
}