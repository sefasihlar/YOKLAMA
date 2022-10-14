using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class DerslerManager : IDerslerService
    {
        IDerslerDal _derslerDal;

        public DerslerManager(IDerslerDal derslerDal)
        {
            _derslerDal = derslerDal;
        }

        public void Add(TBL_DERSLER dersler)
        {
            throw new NotImplementedException();
        }

        public TBL_DERSLER GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_DERSLER> GetList()
        {
            return _derslerDal.GetListAll();
        }

        public void Remove(TBL_DERSLER dersler)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_DERSLER dersler)
        {
            throw new NotImplementedException();
        }
    }
}
