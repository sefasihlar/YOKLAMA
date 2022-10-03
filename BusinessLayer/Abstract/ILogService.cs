using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILogService
    {
        void Add(TBL_LOG log);
        void Remove(TBL_LOG log);
        void Update(TBL_LOG log);
        List<TBL_LOG> GetList();
        TBL_LOG GetById(int id);
    }
}
