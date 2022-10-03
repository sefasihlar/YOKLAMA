using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubeService
    {
        void Add(TBL_SUBE sube);
        void Remove(TBL_SUBE sube);
        void Update(TBL_SUBE sube);
        List<TBL_SUBE> GetList();
        TBL_SUBE GetById(int id);
    }
}
