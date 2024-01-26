using Microsoft.EntityFrameworkCore;
using MVC_Telefon_Kayit.Infrastructure.Context;
using MVC_Telefon_Kayit.Infrastructure.Services.Interface;
using MVC_Telefon_Kayit.Models.Entities.Abstract;
using System.Linq.Expressions;

namespace MVC_Telefon_Kayit.Infrastructure.Services.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            var result = _table.Any(expression);
            return result;
        }

        public void Delete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Passive;
            _table.Update(entity);
            _context.SaveChanges();

        }

        public List<T> GetAll()
        {
            return _table.Where(x => x.Status != Status.Passive).ToList();
        }

        public T GetById(int id)
        {
            return _table.FirstOrDefault(x => x.Status != Status.Passive && x.Id == id);
        }

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = Status.Modified;
            _table.Update(entity);
            _context.SaveChanges();
        }
    }
}
