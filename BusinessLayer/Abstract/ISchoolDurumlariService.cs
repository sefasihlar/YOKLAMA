using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISchoolDurumlariService
    {
        void Add(TBL_SCHOOL_DURUMLARI schooldurumlari);
        void Remove(TBL_SCHOOL_DURUMLARI schooldurumlari);
        void Update(TBL_SCHOOL_DURUMLARI schooldurumlari);
        List<TBL_SCHOOL_DURUMLARI> GetList();
        TBL_SCHOOL_DURUMLARI GetById(int id);
    }
}
