using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfBolumRepository : GenericRepository<TBL_BOLUM>, IBolumDal
    {

    }
}
