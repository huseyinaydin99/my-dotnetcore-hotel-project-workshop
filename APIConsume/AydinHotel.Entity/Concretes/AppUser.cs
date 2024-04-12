using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinHotel.Entity.Abstracts;
using AydinHotel.Entity.Concrete;
using Microsoft.AspNetCore.Identity;

namespace AydinHotel.Entity.Concretes
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string WorkDepartment { get; set; }
        public int WorkLocationId { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}