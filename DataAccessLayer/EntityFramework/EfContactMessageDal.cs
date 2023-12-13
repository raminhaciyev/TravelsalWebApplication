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
    public class EfContactMessageDal : GenericRepository<ContactMessage>, IContactMessageDal
    {
        public void ChangeStatus(ContactMessage p)
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
