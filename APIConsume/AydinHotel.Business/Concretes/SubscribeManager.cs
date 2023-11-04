using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.Business.Abstracts;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.Entity.Concretes;

namespace AydinHotel.Business.Concretes
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TInsert(Subscribe entity)
        {
            _subscribeDal.Insert(entity);
        }

        public void TDelete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeDal.GetById(id);
        }
    }
}