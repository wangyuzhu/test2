using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MediatR;

namespace WebApi.Commands
{
    public class NotyPing : INotification
    {
        public string Message { get; set; }
    }
    public class Noty1Handler : INotificationHandler<NotyPing>, IDisposable
    {
        private readonly ILogger<Noty1Handler> _logger;
        public Noty1Handler(ILogger<Noty1Handler> logger)
        {
            _logger = logger;

        }

        public Task Handle(NotyPing notification, CancellationToken cancellationToken)
        {
            _logger.LogError("Noty1Handler Doing..." + notification.Message);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
        }
    }

    public class Noty2Handler : INotificationHandler<NotyPing>, IDisposable
    {
        private readonly ILogger<Noty2Handler> _logger;
        public Noty2Handler(ILogger<Noty2Handler> logger)
        {
            _logger = logger;
        }
        public Task Handle(NotyPing notification, CancellationToken cancellationToken)
        {
            _logger.LogError("Noty2Handler Doing..." + notification.Message);
            return Task.CompletedTask;
        }
        public void Dispose()
        {
        }
    }
}
