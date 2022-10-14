using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSubeRepository : GenericRepository<TBL_SUBE>, ISubeDal
    {
    }
}
