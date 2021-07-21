using CrudUsuario.Domain.Interfaces.Repositories;
using CrudUsuario.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudUsuario.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _context;
        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public TEntity GetById(long id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Update(TEntity obj)
        {
            _context.Set<TEntity>().Update(obj);
            //Db.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            
        }
    }
}
