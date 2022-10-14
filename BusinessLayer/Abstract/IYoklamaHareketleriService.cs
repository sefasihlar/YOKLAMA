using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IYoklamaHareketleriService
    {
        void Add(TBL_YOKLAMA_HAREKETLERI yoklamahareketleri);
        void Delete(TBL_YOKLAMA_HAREKETLERI yoklamahareketleri);
        void Update(TBL_YOKLAMA_HAREKETLERI yoklamahareketleri);
        List<TBL_YOKLAMA_HAREKETLERI> GetList();
        TBL_YOKLAMA_HAREKETLERI GetById(int id);

    }
}
