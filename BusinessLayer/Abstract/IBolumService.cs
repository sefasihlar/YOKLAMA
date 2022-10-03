using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBolumService
    {
        void Add(TBL_BOLUM bolum);
        void Remove(TBL_BOLUM bolum);  
        void Update(TBL_BOLUM bolum);
        List<TBL_BOLUM> GetList();
        TBL_BOLUM GetById(int id);

    }
}
