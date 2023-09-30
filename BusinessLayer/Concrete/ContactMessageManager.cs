using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    class ContactMessageManager : IContactMessageService
    {
        IContactMessageDal _contactMessageDal;

        public ContactMessageManager(IContactMessageDal contactMessageDal)
        {
            _contactMessageDal = contactMessageDal;
        }

        public void TAdd(ContactMessage t)
        {
            throw new NotImplementedException();
        }

        public void TChangeStatus(ContactMessage p)
        {
            _contactMessageDal.ChangeStatus(p);
        }

        public void TDelete(ContactMessage t)
        {
            throw new NotImplementedException();
        }

        public ContactMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> TListGet()
        {
            return _contactMessageDal.TGetList();
        }

        public void TUpdate(ContactMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
