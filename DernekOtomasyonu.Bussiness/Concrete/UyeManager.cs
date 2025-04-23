using DernekOtomasyonu.Bussiness.Abstract;
using DernekOtomasyonu.DAL.Concrete.EntityFramework;
using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Bussiness.Concrete
{
    public class UyeManager : IUyeService
    {
        EfUyeDal _uyeDal = new EfUyeDal();
        public void Add(Uye uye)
        {
            _uyeDal.Add(uye);
        }

        public void Delete(Uye uye)
        {
            _uyeDal.Delete(uye);
        }

        public List<Uye> GetAll()
        {
            return _uyeDal.GetAll();
        }
        public List<string> GetAktifUyeTCList()
        {
            // AktifDurum true olan tüm üyelerin TC'lerini al

            return _uyeDal.GetAktifUyeTCList();
        }
        public Uye GetById(int UyeID)
        {
            return _uyeDal.GetById(UyeID);
        }
        public List<string> GetDistinctSehir()//sehirleri geticek
        {
            return _uyeDal.GetDistinctSehir();
        }
        public Dictionary<string, int> GetUyeCountBySehir() 
        {
            return _uyeDal.GetUyeCountBySehir();
        }
        public bool Exists(string uyeTC)
        {
            // UyeTC'ye sahip üyenin varlığını kontrol et
            return _uyeDal.GetAll().Any(u => u.UyeTC == uyeTC);
        }

        public void Update(Uye uye)
        {
            _uyeDal.Update(uye);
        }
        public List<Uye> GetByListele(string kanGrubu = null, bool? aktifDurum = null, string sehir = null)
        {
            return _uyeDal.GetList(kanGrubu,aktifDurum,sehir);

        }
         public List<string> sehirler()
         {
           return _uyeDal.GetDistinctSehirler();
         }
        public List<string> GetEmailsByTC(List<string> tcList) 
        {
            return _uyeDal.GetEmailsByTC(tcList);
        }
    }
}
