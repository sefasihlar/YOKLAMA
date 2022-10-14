using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DersManager : IDersService
    {
        IDersDal dersDal;

        public DersManager(IDersDal dersDal)
        {
            this.dersDal = dersDal;
        }

        public void DersAdd(TBL_DERS ders)
        {
            throw new NotImplementedException();
        }

        public List<TBL_DERS> DersList()
        {
            return dersDal.GetListAll();
        }

        public void DersRemove(TBL_DERS ders)
        {
            throw new NotImplementedException();
        }

        public void DersUpdate(TBL_DERS ders)
        {
            throw new NotImplementedException();
        }

        public TBL_DERS GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
