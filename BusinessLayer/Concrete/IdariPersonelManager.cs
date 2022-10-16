using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Security.Cryptography.X509Certificates;

namespace BusinessLayer.Concrete
{
    public class IdariPersonelManager : IIdariPersonelService
    {
        IIdariPersonelDal _IdariPersonelDal;

        public IdariPersonelManager(IIdariPersonelDal ıdariPersonelDal)
        {
            _IdariPersonelDal = ıdariPersonelDal;
        }

        public void Add(TBL_IDARI_PERSONEL idaripersonel)
        {
            _IdariPersonelDal.Add(idaripersonel);
        }

        public TBL_IDARI_PERSONEL GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_IDARI_PERSONEL> GetWithPersonelId(int id)
        {
            return _IdariPersonelDal.GetListAll(x => x.IDARI_PERSONEL_ID == id);
        }

        public List<TBL_IDARI_PERSONEL> GetList()
        {
            return _IdariPersonelDal.GetListAll();
        }



        public void Remove(TBL_IDARI_PERSONEL idaripersonel)
        {
            _IdariPersonelDal.Delete(idaripersonel);
        }

        public void Update(TBL_IDARI_PERSONEL idaripersonel)
        {
            throw new NotImplementedException();
        }
    }
}
