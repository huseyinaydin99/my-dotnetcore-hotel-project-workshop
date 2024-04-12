using AydinHotel.DataAccess.Abstracts;
using AydinHotel.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.DataAccess.Abstracts
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        List<AppUser> UsersListWithWorkLocations();
        int AppUserCount();
    }
}