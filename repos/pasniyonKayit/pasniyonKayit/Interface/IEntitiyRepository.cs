﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasniyonKayit
{
    public interface IEntitiyRepository<T>
    {

        void Add(T t);
        void Delete(T t);
        void Update(T t);

        List<T> GetAll();
        T GetById(int id);
    }
}
