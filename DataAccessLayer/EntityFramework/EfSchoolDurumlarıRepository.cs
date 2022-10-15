using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSchoolDurumlarıRepository : GenericRepository<TBL_SCHOOL_DURUMLARI>, ISchoolDurumlarıDal
    {
 
    }
}
