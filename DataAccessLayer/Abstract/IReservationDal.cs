using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal: IGenericDal<Reservation>
    {
        public List<Reservation> GetListReservationByDestination(int id);
    }
}
