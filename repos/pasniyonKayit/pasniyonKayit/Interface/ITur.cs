using pasniyonKayit.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasniyonKayit.Interface
{
    public interface ITur:IEntitiyRepository<Tur>
    {
        List<Tur> GetByPansiyonTuru();
    }
}
