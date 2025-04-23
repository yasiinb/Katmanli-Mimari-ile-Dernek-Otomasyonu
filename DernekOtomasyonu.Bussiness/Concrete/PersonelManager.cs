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
    public class PersonelManager : IPersonelService
    {
        EfPersonelDal _personelDal = new EfPersonelDal();
        public void Add(Personel personel)
        {
            _personelDal.Add(personel);
        }

        public void Delete(Personel personel)
        {
            _personelDal.Delete(personel);
        }

        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }

        public Personel GetById(int PersonelID)
        {
            return _personelDal.GetById(PersonelID);
        }

        public Personel GetByYetki(string personelKullaniciAdi, string personelSifre)
        {
            return _personelDal.GetByYetki(personelKullaniciAdi,personelSifre);
        }

        public void Update(Personel personel)
        {
            _personelDal.Update(personel);
        }
    }
}
