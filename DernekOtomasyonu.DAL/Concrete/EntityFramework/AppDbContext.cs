
using DernekOtomasyonu.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekOtomasyonu.DAL.Concrete.EntityFramework
{
   public class AppDbContext:DbContext
    {

        public DbSet<Aidat> Aidats { get; set; }
  
        public DbSet<Odemeler> Odemelers { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Uye> Uyes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + "/DernekOtoDB1.accdb");

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Odemeler>().HasKey(o => o.OdemeID);
        
            modelBuilder.Entity<Aidat>().HasKey(o => o.AidatID);
            modelBuilder.Entity<Personel>().HasKey(o => o.PersonelID);
            modelBuilder.Entity<Uye>().HasKey(o => o.UyeTC);
            // Diğer Fluent API konfigürasyonları...
        }

    }
}
