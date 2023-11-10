using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinHotel.DTOs.DTOs.RoomDTOs
{
    public class RoomAddDTO
    {
        [Required(ErrorMessage = "Oda sayısı giriniz.")]
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi giriniz.")]
        public int Price { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "Yatak sayısı giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Banyo sayısı giriniz.")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
