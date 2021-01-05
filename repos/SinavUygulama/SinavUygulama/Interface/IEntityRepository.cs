using System;
using System.Collections.Generic;
using System.Text;

namespace SinavUygulama.Interface
{
    interface IEntityRepository<T>
    {
        void Add(T t);
        void Delete(T t);

        List<T> GetAll();

        void Update(T t);
    }
}
