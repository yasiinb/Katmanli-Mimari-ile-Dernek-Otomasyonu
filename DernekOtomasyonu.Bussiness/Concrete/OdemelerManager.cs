using DernekOtomasyonu.Bussiness.Abstract;
using DernekOtomasyonu.DAL.Concrete.EntityFramework;
using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Bussiness.Concrete
{
    public class OdemelerManager : IOdemelerService
    {
        EfOdemelerDal _odemelerDal = new EfOdemelerDal();
        public void Add(Odemeler odemeler)
        {
            _odemelerDal.Add(odemeler);
        }

        public void Delete(Odemeler odemeler)
        {
            _odemelerDal.Delete(odemeler);
        }
        public List<Odemeler> GetOdemelerByDurum(bool durum)
        {
            //Ödenme Durumuna göre listeleme 
            return _odemelerDal.GetOdemelerByDurum(durum);
        }
        public List<string> GetUnpaidMembersTC()
        {
            return _odemelerDal.GetUnpaidMembersTC();
        }
        public List<Odemeler> GetAll()
        {
            return _odemelerDal.GetAll();
        }
        public Odemeler GetOdemelerByUyeTCAndAidatID(string uyeTC, int aidatID)
        {
            return _odemelerDal.GetOdemelerByUyeTCAndAidatID(uyeTC, aidatID);
        }
        public Odemeler GetById(int OdemelerID)
        {
            return _odemelerDal.GetById(OdemelerID);
        }

        public List<Odemeler> GetByUyeTC(string uyeTC)
        {
            return _odemelerDal.GetByUyeTC(uyeTC);


        }
        public List<Odemeler> GetOdemelerByUyeTCDurum(string uyeTC, bool durum)
        {
            //Uyenin tc sine göre ödedimi ödemedimi diye bakıcak 
            return _odemelerDal.GetOdemelerByUyeTCDurum(uyeTC, durum);
        }
        public void Update(Odemeler odemeler)
        {
            _odemelerDal.Update(odemeler);
        }
    }
}
