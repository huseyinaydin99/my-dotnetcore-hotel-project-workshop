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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TInsert(Booking entity)
        {
            _bookingDal.Insert(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public void BookingStatusChangeApproved2(int id)
        {
            _bookingDal.BookingStatusChangeApproved2(id);
        }
    }
}
