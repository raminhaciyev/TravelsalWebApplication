using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeStatus(Guide p)
        {
            using var c = new Context();
            if (p.Status == true)
            {
                p.Status = false;
            }
            else
            {
                p.Status = true;
            }
            c.Update(p);
            c.SaveChanges();
        }
    }
}
