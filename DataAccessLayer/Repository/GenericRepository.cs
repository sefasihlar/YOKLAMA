using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context _contex = new Context();
        public void Add(T entity)
        {
            _contex.Add(entity);
            _contex.SaveChanges();
        }

        public void Delete(T entity)
        {
            _contex.Remove(entity);
            _contex.SaveChanges();
        }

        public T GetById(int id)
        {
            return _contex.Set<T>().Find(id);
        }

        public List<T> GetGetAll()
        {
            return _contex.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _contex.Update(entity);
        }
    }
}
