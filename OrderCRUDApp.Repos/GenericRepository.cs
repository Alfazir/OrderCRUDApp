using Microsoft.EntityFrameworkCore;
using OrderCRUDApp.data.Entities;
using OrderCRUDApp.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCRUDApp.Repos
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly EFContext _DbContext;
        private readonly DbSet<T> _dBSet;

        public GenericRepository(EFContext context)
        {
            _DbContext = context;
            _dBSet = _DbContext.Set<T>();
        }
        public void Create(T item)
        {
            _dBSet.Add(item);
        }

        public void Delete(int id)
        {
            var item = _dBSet.Find(id);
            _dBSet.Remove(item);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return _dBSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dBSet.ToList();
        }

        public void Update(T item)
        {
            _dBSet.Attach(item);
            _DbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
