using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.DAL.Abstract
{
    public interface IOdemelerDal
    {
        List<Odemeler> GetAll();
        Odemeler GetById(int OdemelerID);
        void Add(Odemeler odemeler);
        void Update(Odemeler odemeler);
        void Delete(Odemeler odemeler);
        List<Odemeler> GetByUyeTC(string uyeTC);
        public Odemeler GetOdemelerByUyeTCAndAidatID(string uyeTC, int aidatID);
        public List<Odemeler> GetOdemelerByDurum(bool durum);
        public List<Odemeler> GetOdemelerByUyeTCDurum(string uyeTC, bool durum);
        public List<string> GetUnpaidMembersTC();
    }
}
