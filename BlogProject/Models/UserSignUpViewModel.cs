using EntitylayerCore.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class UserSignUpViewModel : AppUser
    {
        [Display(Name= "Ad")]
        [Required(ErrorMessage = " Adınızı Daxil Edin")]
        public string name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "İstifadəçi Soyadını Daxil Edin")]
        public string surname { get; set; }

        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Parolunuzu Daxil Edin")]
        public string password { get; set; }

        [Display(Name = "Şifrə Təkrar")]
        [Compare("Password", ErrorMessage = "Şifrələr Uyğun Gəlmir!!!")]
        public string confirmPassword { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mail Adresini Daxil Edin")]
        public string mail { get; set; }

        [Display(Name = "İstifadəçi Adı")]
        [Required(ErrorMessage = "İstifadəçi Adını Daxil Edin")]
        public string userName { get; set; }

        [Display(Name = "Telefon Nömrəsi")]
        public string phoneNumber { get; set; }
        public string imageurl { get; set; }
    }
}
