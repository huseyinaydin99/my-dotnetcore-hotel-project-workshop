using System.ComponentModel.DataAnnotations;

namespace AydinHotel.WebUI.DTOs.RegisterDTOs
{
    public class CreateNewUserDTO
    {
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "E-posta alanı gereklidir.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı alanı gereklidir.")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor. Lütfen şifre ve şifre tekrarı alanlarını aynı giriniz.")]
        public string ConfirmPassword { get; set; }
    }
}