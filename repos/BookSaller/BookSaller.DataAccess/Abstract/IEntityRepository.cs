using BookSaller.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T Get(int id);
    }
}
