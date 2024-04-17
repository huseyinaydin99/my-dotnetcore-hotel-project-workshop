using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AydinHotel.WebUI.Models.Role
{
    public class RoleAssignViewModel
    {
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public bool RoleExists { get; set; }
    }
}