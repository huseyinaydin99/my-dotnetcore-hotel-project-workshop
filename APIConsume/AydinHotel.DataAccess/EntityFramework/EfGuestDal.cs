using AydinHotel.DataAccess.Abstracts;
using AydinHotel.DataAccess.Concretes;
using AydinHotel.DataAccess.Repositories;
using AydinHotel.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.DataAccess.EntityFramework
{
    public class EfGuestDal : GenericRepository<Guest>, IGuestDal
    {
        public EfGuestDal(Context context) : base(context)
        {

        }
    }
}
