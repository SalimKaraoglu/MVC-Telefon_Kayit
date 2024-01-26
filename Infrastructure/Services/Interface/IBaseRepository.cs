using MVC_Telefon_Kayit.Models.Entities.Abstract;
using System.Linq.Expressions;

namespace MVC_Telefon_Kayit.Infrastructure.Services.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        bool Any(Expression<Func<T, bool>> expression);
        T GetById(int id);
        List<T> GetAll();
    }
}
