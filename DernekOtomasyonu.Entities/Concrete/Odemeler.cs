using DernekOtomasyonu.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Entities.Concrete
{
   public class Odemeler:IEntity
    {
        public int OdemeID { get; set; }
        public int AidatID { get; set; }
        public string UyeTC { get; set; }
        public bool Durum { get; set; }     
        public Uye Uye { get; set; }
        public Aidat Aidat { get; set; }
        
    }
}
