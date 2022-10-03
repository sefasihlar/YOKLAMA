using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesajPathService
    {
        void Add(TBL_MESAJ_PATH mesajpath);
        void Remove(TBL_MESAJ_PATH mesajpath);
        void Update(TBL_MESAJ_PATH mesajpath);
        List<TBL_MESAJ_PATH> GetList();
        TBL_MESAJ_PATH GetById(int id);
    }
}
