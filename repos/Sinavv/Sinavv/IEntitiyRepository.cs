using System;
using System.Collections.Generic;
using System.Text;

namespace Sinavv
{
    public interface IEntitiyRepository<T>
    {
        void Add(T t);
        void Delete(int id);
        void Update(T t);

        List<T> GetAll();
    }
}
