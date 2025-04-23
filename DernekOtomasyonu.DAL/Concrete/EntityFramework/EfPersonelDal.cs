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
    public class EfPersonelDal : IPersonelDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Personel personel)
        {
            _context.Personels.Add(personel);
            _context.SaveChanges();
        }

        public void Delete(Personel personel)
        {
            _context.Personels.Remove(personel);
            _context.SaveChanges();
        }

        public List<Personel> GetAll()
        {
            return _context.Personels.ToList();
        }

        public Personel GetById(int PersonelID)
        {
            return _context.Personels.Find(PersonelID);
        }

        public Personel GetByYetki(string personelKullaniciAdi, string personelSifre)
        {
            return _context.Personels.FirstOrDefault(p => p.PersonelKullaniciAdi == personelKullaniciAdi && p.PersonelSifre == personelSifre);
        }

        public void Update(Personel personel)
        {
            var result = _context.Personels.Find(personel.PersonelID);
            if (result != null)
            {
                result.PersonelAd = personel.PersonelAd;
                result.PersonelSoyad = personel.PersonelSoyad;
                result.PersonelKullaniciAdi = personel.PersonelKullaniciAdi;
                result.PersonelMail = personel.PersonelMail;
                result.PersonelSifre = personel.PersonelSifre;
                result.PersonelTelefon = personel.PersonelTelefon;
                _context.SaveChanges();

            }
        }
    }
}
