using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfMesajPathRepository : GenericRepository<TBL_MESAJ_PATH>, IMesajPathDal
    {
    }
}
