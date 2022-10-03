using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Repository;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.EntityFramework
{
    public class EfDersProgramiRepository:GenericRepository<TBL_DERS_PROGRAMI>,IDersProgramıDal
    {
    }
}
