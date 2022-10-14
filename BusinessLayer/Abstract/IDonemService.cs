using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IDonemService
    {
        void Add(TBL_DONEM donem);
        void Remove(TBL_DONEM donem);
        void Update(TBL_DONEM donem);
        List<TBL_DONEM> GetList();
        TBL_DONEM GetById(int id);
    }
}
