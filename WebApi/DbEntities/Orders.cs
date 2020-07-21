using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.DbEntities
{
    public class Orders
    {
        public string OrderId { set; get; }
        public string Title { set; get; }
        public DateTime CreateTime { set; get; }
    }
}
