﻿using System;
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
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(Context context) : base(context)
        {

        }
    }
}
