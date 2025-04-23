using DernekOtomasyonu.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Entities.Concrete
{
   public class Aidat:IEntity
    {
        public int AidatID { get; set; }
        public int AidatMiktar { get; set; }
        public DateTime AidatTarih { get; set; }
        public IEnumerable<Odemeler> odemelers { get; set; }//Aidat ile Odemeler arasında bağlantı kurduk

    }
}
