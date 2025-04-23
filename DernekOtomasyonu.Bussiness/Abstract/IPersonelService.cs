using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Bussiness.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        Personel GetById(int PersonelID);
        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(Personel personel);
        Personel GetByYetki(string personelKullaniciAdi, string personelSifre);

    }
}
