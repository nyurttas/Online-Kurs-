using _9_EFOnlineCourseDB.Abstract;
using _9_EFOnlineCourseDB.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EFOnlineCourseDB.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private AppDBContext _dbContext;
        private DbSet<T> _dbSet;
        public GenericRepository(AppDBContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteByID(Guid id)
        {
            var bulunan = _dbContext.Set<T>().Find(id);
            if (bulunan!=null)
            {
                _dbSet.Remove(bulunan);
            }

            _dbContext.SaveChanges();
        }

        public List<T>? GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetByID(Guid id)
        {
            var bulunan = _dbContext.Set<T>().Find(id);
            if (bulunan != null)
            {
                return bulunan;
            }
            else
            {
                throw new Exception("Bulunamadı.");
            }
        }

        public void Update()
        {
            _dbContext.SaveChanges();
        }
    }
}
