using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ISinifService
    {
        void Add(TBL_SINIF sınıf);
        void Remove(TBL_SINIF sınıf);
        void Update(TBL_SINIF sınıf);
        List<TBL_SINIF> GetList();
        TBL_SINIF GetById(int id);
    }
}
