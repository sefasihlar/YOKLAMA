using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SchoolDurumlariManager : ISchoolDurumlariService
    {
        ISchoolDurumlarıDal _schoolDurumlarıDal;

        public SchoolDurumlariManager(ISchoolDurumlarıDal schoolDurumlarıDal)
        {
            this._schoolDurumlarıDal = schoolDurumlarıDal;
        }

        public void Add(TBL_SCHOOL_DURUMLARI schooldurumlari)
        {
            throw new NotImplementedException();
        }

        public TBL_SCHOOL_DURUMLARI GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_SCHOOL_DURUMLARI> GetList()
        {
            return _schoolDurumlarıDal.GetListAll();
        }

        public void Remove(TBL_SCHOOL_DURUMLARI schooldurumlari)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_SCHOOL_DURUMLARI schooldurumlari)
        {
            throw new NotImplementedException();
        }
    }
}
