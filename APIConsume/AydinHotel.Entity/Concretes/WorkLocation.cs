using AydinHotel.Entity.Abstracts;
using AydinHotel.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.Entity.Concrete
{
    public class WorkLocation : IEntity
    {
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}