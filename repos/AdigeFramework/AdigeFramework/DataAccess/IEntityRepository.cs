using AdigeFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdigeFramework.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new() //T bit referans tip olmalı(interface ve abstractta referans tiplidir ancak class diyerek kısıtladık),
                                                                //IEntitiy ise bir çeşit imzadır, framework tasarımlarında nesnelerin imzalanmaı ve belli bir standarta sahip olması ve ona göre
                                                                //kural yazılması için sıklıkla başvururuz
    { 
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);//Nesne gönderip primary keye göre silinmesi
    }
}
