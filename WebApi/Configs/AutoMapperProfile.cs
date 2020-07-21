using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApi.Commands;
using WebApi.DbEntities;

namespace WebApi.Configs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Orders, Order_Create_Response>()
                .ForMember(a => a.OrderId, b => b.MapFrom(src => src.OrderId))
                .ReverseMap();
        }
    }
}
