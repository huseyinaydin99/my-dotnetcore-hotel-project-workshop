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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TInsert(Room entity)
        {
            _roomDal.Insert(entity);
        }

        public void TDelete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public int TRoomCount()
        {
            return _roomDal.RoomCount();
        }
    }
}