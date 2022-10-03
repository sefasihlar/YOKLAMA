using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISinifService
    {
        void Add(TBL_SINIF sınıf);
        void Remove(TBL_SINIF sınıf);
        void Update(TBL_SINIF sınıf);
        List<TBL_SINIF> GetList();
        TBL_SINIF GetById(int id);
    }
}
