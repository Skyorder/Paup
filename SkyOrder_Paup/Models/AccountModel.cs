using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class RegistracijaModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} mora biti minimalno {2} znakova duga.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potvrdi lozinku")]
        [Compare("Password", ErrorMessage = "Lozinke se ne podudaraju.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "{0} mora biti minimalno {2} znakova duga.", MinimumLength = 9)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Dodajte broj mobitela")]
        public string Brmobitela { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "{0} mora biti minimalno {2} znakova duga.", MinimumLength = 9)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Upišite adresu")]
        public string adresa { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "{0} mora biti minimalno {2} znakova duga.", MinimumLength = 9)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Upišite naziv poduzeća")]
        public string Naziv { get; set; }
    }

    public class PrijavaModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [Display(Name = "Zapamti me")]
        public bool RememberMe { get; set; }
    }
}