using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSınıfRepsository : GenericRepository<TBL_SINIF>, ISınıfDal
    {
    }
}
