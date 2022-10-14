using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfVeliRepository : GenericRepository<TBL_VELI>, IVeliDal
    {
    }
}
