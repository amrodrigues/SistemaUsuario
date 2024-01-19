using Projeto.Repository.Context;
using Projeto.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Persistence
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        public virtual void Insert(TEntity obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public virtual void Update(TEntity obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public virtual void Delete(TEntity obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public virtual List<TEntity> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<TEntity>().ToList();
            }
        }

        public virtual TEntity FindById(int id)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<TEntity>().Find(id);
            }
        }
    }
}
