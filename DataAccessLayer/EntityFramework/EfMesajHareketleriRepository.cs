using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMesajHareketleriRepository:GenericRepository<TBL_MESAJ_HAREKETLERI>,IMesajHareketleriDal
    {
    }
}
