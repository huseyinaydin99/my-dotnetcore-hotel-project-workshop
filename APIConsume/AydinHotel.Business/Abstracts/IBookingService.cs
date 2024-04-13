using AydinHotel.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.Business.Abstracts
{
    public interface IBookingService : IGenericService<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);
        int TGetBookingCount();
        List<Booking> TLast6Bookings();
    }
}
