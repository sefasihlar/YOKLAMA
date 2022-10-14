using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfDonemRepository : GenericRepository<TBL_DONEM>, IDonemDal
    {
    }
}
