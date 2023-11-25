using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Alanı Zorunlu")]
        public string? Name {get; set;}
        [Required(ErrorMessage = "Telefon Numarası Zorunlu")]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email Alanı Zorunlu")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım Durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }

    }
}