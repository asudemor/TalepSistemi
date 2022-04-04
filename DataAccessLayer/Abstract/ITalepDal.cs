using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITalepDal
    {
        List<Talep> ListAllTalep();
        void AddTalep(Talep talep);
        void DeleteTalep(Talep talep);
        void UpdateTalep(Talep talep);
        Talep GetByID(int id);
    }
}
