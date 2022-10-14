using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IOgrenciDal : IGenericDal<TBL_OGRENCI>
    {
        List<TBL_OGRENCI> GetberaberList();
    }
}
