﻿using AydinHotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AydinHotel.WebUI.DTOs.AppUserDTOs
{
    public class ResultAppUserListDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
