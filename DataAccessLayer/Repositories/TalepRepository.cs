using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    //16.video generic repository den devam et.
    public class TalepRepository : ITalepDal
    {
        Context c = new Context();
        public void AddTalep(Talep talep)
        {
            c.Add(talep);
            c.SaveChanges();
        }

        public void DeleteTalep(Talep talep)
        {
            c.Remove(talep);
            c.SaveChanges();
        }

        public Talep GetByID(int id)
        {
            return c.Talepler.Find(id);
        }

        public List<Talep> ListAllTalep()
        {
            return c.Talepler.ToList();
        }

        public void UpdateTalep(Talep talep)
        {
            c.Update(talep);
            c.SaveChanges();
        }
    }
}
