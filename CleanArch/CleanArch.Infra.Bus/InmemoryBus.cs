using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
   public class InmemoryBus:IMediatorHandler
    {
        private readonly IMediator _mediator;
        public InmemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand <T>(T command) where T: Command
        {
            return _mediator.Send(command);
        }
    }
}
