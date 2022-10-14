using EntityLayer.Concrete;

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
