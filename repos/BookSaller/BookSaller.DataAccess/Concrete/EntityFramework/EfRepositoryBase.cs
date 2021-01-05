using BookSaller.Abstract;
using BookSaller.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<Tentity, Tcontext> : IEntityRepository<Tentity> where Tentity:class,IEntity,new()
        where Tcontext:DbContext,new()
    {
        public void Add(Tentity t)
        {
            using (var context = new Tcontext())
            {
                context.Entry(t).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity t)
        {
            using (var context = new Tcontext())
            {
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(int id)
        {
            using (var context=new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(x => x.Id == id);
            }
        }

        public List<Tentity> GetAll()
        {
            using (var context=new Tcontext())
            {
                return context.Set<Tentity>().ToList();
            } 
        }

        public void Update(Tentity t)
        {
            using (var context = new Tcontext())
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
