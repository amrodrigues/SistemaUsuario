using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(TEntity obj);

        List<TEntity> FindAll();

        TEntity FindById(int id);
    }
}
