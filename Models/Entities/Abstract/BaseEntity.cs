using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Telefon_Kayit.Models.Entities.Abstract
{
    public enum Status { Active = 1, Modified, Passive }

    public abstract class BaseEntity
    {
        private DateTime _createdDate = DateTime.Now;
        private Status _status = Status.Active;

        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column("CreateDate", TypeName = "datetime2")]
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
       
        [Column("UpdateDate", TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }

        [Column("DeleteDate", TypeName = "datetime2")]
        public DateTime? DeletedDate { get; set; }

        [Required]
        [Column("Status")]
        public Status Status { get => _status; set => _status = value; }
    }
}
