using BusinessLayer.Abstract.AbstractUOW;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUOW
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUOWDal _uOWDal;

        public AccountManager(IAccountDal accountDal, IUOWDal uOWDal)
        {
            _accountDal = accountDal;
            _uOWDal = uOWDal;
        }

        public Account TGetById(int id)
        {
           return _accountDal.GetById(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uOWDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uOWDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uOWDal.Save();
        }
    }
}
