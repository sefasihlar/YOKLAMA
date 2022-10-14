using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBolumService
    {
        void Add(TBL_BOLUM bolum);
        void Remove(TBL_BOLUM bolum);
        void Update(TBL_BOLUM bolum);
        List<TBL_BOLUM> GetList();
        TBL_BOLUM GetById(int id);

    }
}
