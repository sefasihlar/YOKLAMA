using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDerslerService
    {
        void Add(TBL_DERSLER dersler);
        void Remove(TBL_DERSLER dersler);
        void Update(TBL_DERSLER dersler);
        List<TBL_DERSLER> GetList();
        TBL_DERSLER GetById(int id);
    }
}
