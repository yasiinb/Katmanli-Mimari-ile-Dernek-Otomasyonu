using DernekOtomasyonu.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Entities.Concrete
{
    public class Personel:IEntity
    {
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelTelefon { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelKullaniciAdi { get; set; }
        public string PersonelSifre { get; set; }
        public int PersonelYetki { get; set; }
       
    }
}
