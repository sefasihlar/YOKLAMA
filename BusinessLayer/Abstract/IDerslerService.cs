using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IDerslerService
    {
        void Add(TBL_DERSLER dersler);
        void Remove(TBL_DERSLER dersler);
        void Update(TBL_DERSLER dersler);
        List<TBL_DERSLER> GetList();
        TBL_DERSLER GetById(int id);
    }
}
