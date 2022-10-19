using DataAccessLayer.Abstract;
using System.Linq.Expressions;
using System.Security.Cryptography.Pkcs;

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


        public List<T> GetListAll()
        {
            return _contex.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {

            return _contex.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            _contex.Update(entity);
            _contex.SaveChanges();
        }


    }
}
