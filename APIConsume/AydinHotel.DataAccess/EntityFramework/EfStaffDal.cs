﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.DataAccess.Concrete;
using AydinHotel.DataAccess.Repositories;
using AydinHotel.Entity.Concretes;

namespace AydinHotel.DataAccess.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {

        }
    }
}