using OrderCRUDApp.data.Entities;
using OrderCRUDApp.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCRUDApp.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFContext _DbContext;

        public OrderRepository OrderRepository { get; private set; }

        public UnitOfWork (EFContext context)
        {
            this._DbContext = context;
            this.OrderRepository = new OrderRepository(this._DbContext);
        }

        public async Task Commit()
        {
           await this._DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._DbContext.Dispose();
        }
    }
}
