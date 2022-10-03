using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDersService
    {
        void DersAdd(TBL_DERS ders);
        void DersRemove(TBL_DERS ders);
        void DersUpdate(TBL_DERS ders);
        List<TBL_DERS> DersList();
        TBL_DERS GetById(int id);
    }
}
