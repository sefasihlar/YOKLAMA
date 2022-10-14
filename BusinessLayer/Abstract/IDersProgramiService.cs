using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IDersProgramiService
    {
        void Add(TBL_DERS_PROGRAMI dersprogrami);
        void Delete(TBL_DERS_PROGRAMI dersprogrami);
        void Update(TBL_DERS_PROGRAMI dersprogrami);

        List<TBL_DERS_PROGRAMI> GetList();

        TBL_DERS_PROGRAMI GetById(int id);

    }
}
