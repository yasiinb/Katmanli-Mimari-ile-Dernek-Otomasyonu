using DernekOtomasyonu.DAL.Abstract;
using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DernekOtomasyonu.DAL.Concrete.EntityFramework
{
    public class EfUyeDal : IUyeDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Uye uye)
        {
            _context.Uyes.Add(uye);
            _context.SaveChanges();
        }

        public void Delete(Uye uye)
        {
            _context.Uyes.Remove(uye);
            _context.SaveChanges();
        }
        public List<string> GetAktifUyeTCList()
        {
            return _context.Uyes.Where(u => u.AktifDurum == true).Select(u => u.UyeTC).ToList();
        }
        public List<Uye> GetAll()
        {
            return _context.Uyes.ToList();//.Where(p=>p.UyeYetki==2)
        }
        public List<Uye> GetList(string kanGrubu = null, bool? aktifDurum = null, string sehir = null)
        {
            var query = _context.Uyes.AsQueryable();

            // Kan grubuna göre filtreleme
            if (!string.IsNullOrEmpty(kanGrubu))
            {
                query = query.Where(u => u.Kangurubu == kanGrubu);
            }

            // Aktif duruma göre filtreleme
            if (aktifDurum.HasValue)
            {
                query = query.Where(u => u.AktifDurum == aktifDurum.Value);
            }

            // Şehre göre filtreleme
            if (!string.IsNullOrEmpty(sehir))
            {
                query = query.Where(u => u.Sehir == sehir);
            }

            // Sonuçları liste olarak döndür
            return query.ToList();
        }
        public Uye GetById(int UyeID)
        {
            return _context.Uyes.Find(UyeID);
        }
        public List<string> GetDistinctSehir()//y ekseni için şehir getirme 
        {
            return _context.Uyes.Select(u => u.Sehir).Distinct().ToList();
        }
        public List<string> GetDistinctSehirler()
        {
            return _context.Uyes.Select(u => u.Sehir).Distinct().ToList();
        }
        public Dictionary<string, int> GetUyeCountBySehir()//şehir sayısı 
        {
            var result = _context.Uyes
         .GroupBy(u => u.Sehir)
         .Select(g => new { Sehir = g.Key, UyeSayisi = g.Count() })
         .ToList()
         .ToDictionary(x => x.Sehir, x => x.UyeSayisi);

            return result;
        }
        public List<string> GetEmailsByTC(List<string> tcList)
        {
            List<string> email = new List<string>();

            foreach (var tc in tcList)
            {
                Uye uye = _context.Uyes
                    .Where(u => u.UyeTC == tc)
                    .Select(u => new Uye
                    {
                        UyeTC = u.UyeTC,
                        UyeMail = u.UyeMail,
                        // Diğer özellikleri de ekleyebilirsin
                    })
                    .FirstOrDefault();

                if (uye != null)
                {
                    email.Add(uye.UyeMail);
                }
            }

            return email;
        
        }


        public void Update(Uye uye)
        {
            var result = _context.Uyes.Find(uye.UyeTC);
            if (result != null)
            {
                result.UyeAdi = uye.UyeAdi;
                result.UyeSoyadi = uye.UyeSoyadi;
                result.UyeTC = uye.UyeTC;
                result.UyeMail = uye.UyeMail;
                result.Kangurubu = uye.Kangurubu;
                result.UyeTelefonNo = uye.UyeTelefonNo;
                result.Sehir = uye.Sehir;
                result.KalanAidat = uye.KalanAidat;
                result.KatilimTarihi = uye.KatilimTarihi;
                result.AktifDurum = uye.AktifDurum;
                _context.SaveChanges();

            }
        }
    }
}
