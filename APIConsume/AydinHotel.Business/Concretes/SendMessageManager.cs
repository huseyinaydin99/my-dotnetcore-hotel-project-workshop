using AydinHotel.Business.Abstracts;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.Business.Concretes
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _aboutDal;

        public SendMessageManager(ISendMessageDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TInsert(SendMessage entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TDelete(SendMessage entity)
        {
            _aboutDal.Delete(entity);
        }

        public void TUpdate(SendMessage entity)
        {
            _aboutDal.Update(entity);
        }

        public List<SendMessage> TGetList()
        {
            return _aboutDal.GetList();
        }

        public SendMessage TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }
    }
}