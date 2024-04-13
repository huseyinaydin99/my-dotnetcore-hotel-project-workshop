using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AydinHotel.WebUI.DTOs.FollowersDTOs
{
    public class ResultLinkedinFollowersDTO
    {
        public Data data { get; set; }
        public class Data
        {
            public int followers_count { get; set; }
        }
    }
}