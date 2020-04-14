//using MicroRabbit.Domain.Core.Event;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Commands
{
   public abstract class Command : Message
    {

        public Command()
        {
            TimeStemp = DateTime.Now;
        }


        public DateTime TimeStemp { get; protected set; }


    }
}
