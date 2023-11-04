using AydinHotel.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.Entity.Concretes
{
    public class Subscribe : IEntity
    {
        public int SubscribeId { get; set; }
        public string Mail { get; set; }
    }
}
