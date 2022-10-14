using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfKurumRepository : GenericRepository<TBL_KURUM>, IKurumDal
    {
    }
}
