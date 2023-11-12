using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.DataAccess.Concretes;
using AydinHotel.DataAccess.Repositories;
using AydinHotel.Entity.Concretes;

namespace AydinHotel.DataAccess.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context context) : base(context)
        {

        }
    }
}