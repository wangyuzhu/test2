using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MediatR;
using AutoMapper;
using WebApi.DbEntities;

namespace WebApi.Commands
{
    public class Order_Create_Request : IRequest<Order_Create_Response>
    {
        public string OrderId { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
    }

    public class Order_Create_Response
    {
        public string OrderId { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
    }

    public class Order_CreateHandler : IRequestHandler<Order_Create_Request, Order_Create_Response>, IDisposable
    {
        private readonly ILogger<Order_CreateHandler> _logger;
        private readonly IMapper _mapper;

        public Order_CreateHandler(ILogger<Order_CreateHandler> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public Task<Order_Create_Response> Handle(Order_Create_Request request, CancellationToken cancellationToken)
        {
            _logger.LogError("PingHandler Doing..." + request.Title);

            var dbEntity = new Orders
            {
                OrderId = Guid.NewGuid().ToString(),
                CreateTime = DateTime.Now,
                Title = "123456789"
            };

            var dto = _mapper.Map<Order_Create_Response>(dbEntity);

            return Task.FromResult(dto);
        }

        public void Dispose()
        {

        }
    }
}
