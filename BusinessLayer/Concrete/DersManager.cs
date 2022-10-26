using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DersManager : IDersService
    {
        IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            this._dersDal = dersDal;
        }

        public void DersAdd(TBL_DERS ders)
        {
            throw new NotImplementedException();
        }

        public List<TBL_DERS> DersList()
        {
            return _dersDal.GetListAll();
        }

        public List<TBL_DERS> GetWithDersId(int id)
        {
            return _dersDal.GetListAll(x => x.DERS_ID == id);
        }
        public void DersRemove(TBL_DERS ders)
        {
            _dersDal.Delete(ders);
        }

        public void DersUpdate(TBL_DERS ders)
        {
            _dersDal.Update(ders);
            
        }

        public TBL_DERS GetById(int id)
        {
            return (TBL_DERS)_dersDal.GetById(id);  
        }
    }
}
