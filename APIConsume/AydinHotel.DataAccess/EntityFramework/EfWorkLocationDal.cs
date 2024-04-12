using AydinHotel.DataAccess.Abstracts;
using AydinHotel.DataAccess.Concretes;
using AydinHotel.DataAccess.Repositories;
using AydinHotel.DataAccessLayer.Abstract;
using AydinHotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.DataAccessLayer.EntityFramework
{
    public class EfWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
    {
        public EfWorkLocationDal(Context context) : base(context)
        {

        }
    }
}