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
    public class EfAidatDal : IAidatDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Aidat aidat)
        {
            _context.Aidats.Add(aidat);
            _context.SaveChanges();
        }

        public void Delete(Aidat aidat)
        {
            var result = _context.Aidats.Find(aidat.AidatID);
            if (result != null)
            {

                _context.Aidats.Remove(result);
                _context.SaveChanges();
            }
        }
        public List<Aidat> GetAidatlarAfterDate(DateTime selectedDate)
        {
            return _context.Aidats
                .Where(a => a.AidatTarih > selectedDate)
                .ToList();
        }
        public List<Aidat> GetAll()
        {
            return _context.Aidats.ToList();
        }

        public Aidat GetById(int AidatID)
        {
            return _context.Aidats.Find(AidatID);
        }

        public int GetLastAddedAidatID()
        {
            var lastAidat = _context.Aidats.OrderByDescending(a => a.AidatID).FirstOrDefault();
            return lastAidat?.AidatID ?? 0;
        }
        public Aidat GetAidatInfoByAidatID(int aidatID)
        {
            return _context.Aidats.FirstOrDefault(a => a.AidatID == aidatID);
        }
        public void Update(Aidat aidat)
        {
            var result = _context.Aidats.Find(aidat.AidatID);
            if (result != null)
            {
            
                result.AidatMiktar = aidat.AidatMiktar;
                result.AidatTarih = aidat.AidatTarih;
           
                _context.SaveChanges();

            }
        }
    }
}
