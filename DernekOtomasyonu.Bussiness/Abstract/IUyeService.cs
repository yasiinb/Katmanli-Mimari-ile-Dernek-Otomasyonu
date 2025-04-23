using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Bussiness.Abstract
{
    public interface IUyeService
    {
        List<Uye> GetAll();
        Uye GetById(int UyeID);
        void Add(Uye uye);
        void Update(Uye uye);
        void Delete(Uye uye);
        List<Uye> GetByListele(string kanGrubu = null, bool? aktifDurum = null, string sehir = null);
        List<string> sehirler();
        List<string> GetAktifUyeTCList();
        List<string> GetEmailsByTC(List<string> tcList);
        List<string> GetDistinctSehir();
        Dictionary<string, int> GetUyeCountBySehir();
    }

}

