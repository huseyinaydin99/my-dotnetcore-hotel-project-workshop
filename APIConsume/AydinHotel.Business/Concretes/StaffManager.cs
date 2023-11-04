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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public void TDelete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetById(id);
        }
    }
}