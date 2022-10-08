using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOgrenciService
    {
        void Add(TBL_OGRENCI ogrenci);
        void Remove(TBL_OGRENCI ogrenci);
        void Update(TBL_OGRENCI ogrenci);
        List<TBL_OGRENCI> GetList();
        List<TBL_OGRENCI> GetberaberList();
        TBL_OGRENCI GetById(int id);
    }
}
