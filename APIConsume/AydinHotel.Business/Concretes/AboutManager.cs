using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.Business.Abstracts;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.DataAccess.EntityFramework;
using AydinHotel.Entity.Concretes;

namespace AydinHotel.Business.Concretes
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }


        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }
    }
}