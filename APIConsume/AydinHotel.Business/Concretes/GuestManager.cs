using AydinHotel.Business.Abstracts;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.Business.Concretes
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TInsert(Guest entity)
        {
            _guestDal.Insert(entity);
        }

        public void TDelete(Guest entity)
        {
            _guestDal.Delete(entity);
        }

        public void TUpdate(Guest entity)
        {
            _guestDal.Update(entity);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public Guest TGetById(int id)
        {
            return _guestDal.GetById(id);
        }
    }
}