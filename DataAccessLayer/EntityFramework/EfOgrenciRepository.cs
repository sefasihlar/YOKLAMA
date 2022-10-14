using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfOgrenciRepository : GenericRepository<TBL_OGRENCI>, IOgrenciDal
    {
        public List<TBL_OGRENCI> GetberaberList()
        {
            using (var c = new Context())
            {
                return c.TBL_OGRENCI.Include(x => x.TBL_BOLUM).Include(x => x.TBL_DONEM).ToList();
            }
        }
    }
}
