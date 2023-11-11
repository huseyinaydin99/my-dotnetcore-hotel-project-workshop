using System.ComponentModel.DataAnnotations;

namespace AydinHotel.WebUI.DTOs.LoginDTOs
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı zorunludur.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        public string Password { get; set; }
    }
}