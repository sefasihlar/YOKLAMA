using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDersProgramiService
    {
        void Add(TBL_DERS_PROGRAMI dersprogrami);
        void Delete(TBL_DERS_PROGRAMI dersprogrami);
        void Update(TBL_DERS_PROGRAMI dersprogrami);

        List<TBL_DERS_PROGRAMI> GetList();

        TBL_DERS_PROGRAMI GetById(int id);  

    }
}
