using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IVeliService
    {
        void Add(TBL_VELI veli);
        void Remove(TBL_VELI veli);
        void Update(TBL_VELI veli);
        List<TBL_VELI> GetList();
        TBL_VELI GetById(int id);
    }
}
