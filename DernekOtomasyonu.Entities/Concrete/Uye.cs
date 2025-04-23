using DernekOtomasyonu.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Entities.Concrete
{
    public class Uye:IEntity
    {
 
        public string UyeTC { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string Kangurubu { get; set; }
        public string UyeTelefonNo { get; set; }
        public string Sehir { get; set; }
        public string UyeMail { get; set; }
        public DateTime KatilimTarihi { get; set; }
        public int KalanAidat { get; set; }
        public bool AktifDurum { get; set; }

        public IEnumerable<Odemeler> odemelers { get; set; }

    }
}
