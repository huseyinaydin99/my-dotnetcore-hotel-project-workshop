﻿using AydinHotel.Business.Abstracts;
using AydinHotel.DataAccess.Abstracts;
using AydinHotel.DataAccess.EntityFramework;
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
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal aboutDal)
        {
            _sendMessageDal = aboutDal;
        }

        public void TInsert(SendMessage entity)
        {
            _sendMessageDal.Insert(entity);
        }

        public void TDelete(SendMessage entity)
        {
            _sendMessageDal.Delete(entity);
        }

        public void TUpdate(SendMessage entity)
        {
            _sendMessageDal.Update(entity);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageDal.GetList();
        }

        public SendMessage TGetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public int TGetSendMessageCount()
        {
            return _sendMessageDal.GetSendMessageCount();
        }
    }
}