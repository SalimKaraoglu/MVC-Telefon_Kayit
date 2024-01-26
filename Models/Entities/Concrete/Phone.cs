using MVC_Telefon_Kayit.Models.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Telefon_Kayit.Models.Entities.Concrete
{
    public class Phone : BaseEntity
    {
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public string BataryCapasity { get; set; }

        [Required]
        public int Piece { get; set; }
    }
}
