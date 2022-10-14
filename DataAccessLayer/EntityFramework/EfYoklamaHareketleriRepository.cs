using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfYoklamaHareketleriRepository : GenericRepository<TBL_YOKLAMA_HAREKETLERI>, IYoklamaHareketleriDal
    {
    }
}
