using System.ComponentModel.DataAnnotations;

namespace AydinHotel.WebUI.DTOs.ServiceDTO
{
    public class CreateServiceDTO
    {
        [Required(ErrorMessage = "Hizmet ikon linki giriniz.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
