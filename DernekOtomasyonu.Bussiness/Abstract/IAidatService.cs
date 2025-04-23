using DernekOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.Bussiness.Abstract
{
    public interface IAidatService
    {
        List<Aidat> GetAll();
        Aidat GetById(int AidatID);
        void Add(Aidat aidat);
        void Update(Aidat aidat);
        void Delete(Aidat aidat);
        List<Aidat> GetAidatlarAfterDate(DateTime selectedDate);
        int GetLastAddedAidatID();
        Aidat GetAidatInfoByAidatID(int aidatID);
    }
}
