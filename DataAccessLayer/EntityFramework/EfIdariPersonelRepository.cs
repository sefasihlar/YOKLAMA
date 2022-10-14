using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfIdariPersonelRepository : GenericRepository<TBL_IDARI_PERSONEL>, IIdariPersonelDal
    {
    }
}
