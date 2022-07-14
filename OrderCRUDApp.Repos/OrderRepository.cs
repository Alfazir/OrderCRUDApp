using OrderCRUDApp.data.Entities;
using OrderCRUDApp.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCRUDApp.Repos
{
    public class OrderRepository: GenericRepository<Order> , IOrderRepository
    {
        private readonly EFContext _context;

        public OrderRepository(EFContext context):base(context)
        {
            this._context = context;
        }

    }
}
