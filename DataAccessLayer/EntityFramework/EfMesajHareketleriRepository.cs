using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfMesajHareketleriRepository : GenericRepository<TBL_MESAJ_HAREKETLERI>, IMesajHareketleriDal
    {
    }
}
