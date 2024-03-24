using AydinHotel.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.Entity.Concretes
{
    public class MessageCategory : IEntity
    {
        public int MessageCategoryId { get; set; }
        public string MessageCategoryName { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}