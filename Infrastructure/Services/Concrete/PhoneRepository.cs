using MVC_Telefon_Kayit.Infrastructure.Context;
using MVC_Telefon_Kayit.Infrastructure.Services.Interface;
using MVC_Telefon_Kayit.Models.Entities.Concrete;

namespace MVC_Telefon_Kayit.Infrastructure.Services.Concrete
{
    public class PhoneRepository : BaseRepository<Phone> , IPhoneRepository
    {
        public PhoneRepository(AppDbContext context) : base(context)
        {
                
        }
    }
}
