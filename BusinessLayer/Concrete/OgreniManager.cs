using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class OgreniManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgreniManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        public void Add(TBL_OGRENCI ogrenci)
        {
            throw new NotImplementedException();
        }

        public List<TBL_OGRENCI> GetberaberList()
        {
            return _ogrenciDal.GetberaberList();
        }

        public TBL_OGRENCI GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_OGRENCI> GetList()
        {
            return _ogrenciDal.GetListAll();
        }

        public List<TBL_OGRENCI> GetWithOgrenciId(int id)
        {
            return _ogrenciDal.GetListAll(x=> x.OGRENCI_ID == id);
        }

        public void Remove(TBL_OGRENCI ogrenci)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_OGRENCI ogrenci)
        {
            throw new NotImplementedException();
        }
    }
}
