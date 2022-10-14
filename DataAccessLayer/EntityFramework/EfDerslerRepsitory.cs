using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfDerslerRepsitory : GenericRepository<TBL_DERSLER>, IDerslerDal
    {
    }
}
