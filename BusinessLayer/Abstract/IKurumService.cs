using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IKurumService
    {
        void Add(TBL_KURUM kurum);
        void Remove(TBL_KURUM kurum);
        void Update(TBL_KURUM kurum);
        List<TBL_KURUM> GetList();
        TBL_KURUM GetById(int id);
    }
}
