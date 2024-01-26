using MVC_Telefon_Kayit.Models.Entities.Abstract;

namespace MVC_Telefon_Kayit.Models.ViewModels
{
    public class GetPhoneVM
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Modelo { get; set; }
        public string BataryCapasity { get; set; }
        public int Piece { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; }
    }
}
