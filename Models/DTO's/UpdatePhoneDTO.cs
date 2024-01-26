using System.ComponentModel.DataAnnotations;

namespace MVC_Telefon_Kayit.Models.DTO_s
{
    public class UpdatePhoneDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Marka Alanı Zorunludur!")]
        [Display(Name = "Marka")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model Alanı Zorunludur!")]
        [Display(Name = "Model")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Batarya Kapasitesi Zorunludur!")]
        [Display(Name = "Batarya")]
        public string BataryCapasity { get; set; }

        [Required(ErrorMessage = "Adet Alanı Zorunludur!")]
        [Display(Name = "Adet")]
        public int Piece { get; set; }
    }
}
