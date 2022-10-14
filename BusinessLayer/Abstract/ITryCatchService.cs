using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ITryCatchService
    {
        void Add(TBL_TRY_CATCH trycatch);
        void Remove(TBL_TRY_CATCH trycatch);
        void Update(TBL_TRY_CATCH trycatch);
        List<TBL_TRY_CATCH> GetList();
        TBL_TRY_CATCH GetById(int id);
    }
}
