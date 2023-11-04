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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }
    }
}