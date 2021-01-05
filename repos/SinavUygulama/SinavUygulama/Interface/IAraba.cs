using System;
using System.Collections.Generic;
using System.Text;

namespace SinavUygulama.Interface
{
    interface IAraba:IEntityRepository<Araba>
    {
        List<Araba> GetByModel(string model);

    }
}
