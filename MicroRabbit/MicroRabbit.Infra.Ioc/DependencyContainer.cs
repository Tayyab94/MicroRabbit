﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.Ioc
{
   public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection serviceCollection)
        {
            // Domain Bus
            serviceCollection.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
