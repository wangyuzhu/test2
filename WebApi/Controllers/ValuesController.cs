using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using AutoMapper;
using WebApi.Commands;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ValuesController(ILogger<ValuesController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<Order_Create_Response> Get()
        {
            await _mediator.Publish(new NotyPing { Message = "Test Noty" });

            return await _mediator.Send(new Order_Create_Request() { Title = "TestTitle", CreateTime = DateTime.Now });
        }
    }
}
