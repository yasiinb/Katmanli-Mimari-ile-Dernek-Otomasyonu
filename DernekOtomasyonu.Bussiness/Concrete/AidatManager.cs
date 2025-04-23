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
    public class AidatManager : IAidatService
    {
        EfAidatDal _aidatDal = new EfAidatDal();
        UyeManager _uyeManager = new UyeManager();
        OdemelerManager _odemelerManager = new OdemelerManager();
        public void Add(Aidat aidat)
        {
            _aidatDal.Add(aidat);
            int lastAddedAidatID = GetLastAddedAidatID();

            // AktifDurum true olan tüm üyeler için TC'leri al
            List<string> aktifUyelerTC = _uyeManager.GetAktifUyeTCList();

            foreach (var uyeTC in aktifUyelerTC)
            {
                Odemeler yeniOdeme = new Odemeler
                {
                    AidatID = lastAddedAidatID,
                    UyeTC = uyeTC,
                    Durum = false
                };
                _odemelerManager.Add(yeniOdeme);
            }
        }
        public int GetLastAddedAidatID()
        {
            // En son eklenen Aidat'ın ID'sini al
            return _aidatDal.GetLastAddedAidatID();
        }
        public void Delete(Aidat aidat)
        {
            _aidatDal.Delete(aidat);
        }

        public List<Aidat> GetAll()
        {
            return _aidatDal.GetAll();
        }

        public Aidat GetById(int AidatID)
        {
            return _aidatDal.GetById(AidatID);
        }

      public  List<Aidat> GetAidatlarAfterDate(DateTime selectedDate)
      {      
            return _aidatDal.GetAidatlarAfterDate(selectedDate);
      }
        public Aidat GetAidatInfoByAidatID(int aidatID)
        {
            return _aidatDal.GetAidatInfoByAidatID(aidatID);//belirli ID ye göre Aidat satırı dönderen method 
        }
        public void Update(Aidat aidat)
        {
            _aidatDal.Update(aidat);
        }
    }
}
