using EntityLayer.Concrete;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=CODECYBER\\SQLEXPRESS;database=DBYOKLAMA;integrated securtiy=true");
        }

        public DbSet<TBL_BOLUM> TBL_BOLUMS { get; set; }
        public DbSet<TBL_DERS> TBL_DERS { get; set; }
        public DbSet<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMIS { get; set; }
        public DbSet<TBL_DERSLER> TBL_DERSLERS { get; set; }
        public DbSet<TBL_DONEM> TBL_DONEMS { get; set; }
        public DbSet<TBL_IDARI_PERSONEL> TBL_IDARI_PERSONELS { get; set; }
        public DbSet<TBL_KURUM> TBL_KURUMS { get; set; }
        public DbSet<TBL_LOG> TBL_LOGS { get; set; }
        public DbSet<TBL_MESAJ_HAREKETLERI> TBL_MESAJ_HAREKETLERIS { get; set; }
        public DbSet<TBL_MESAJ_PATH> TBL_MESAJ_PATHS { get; set; }
        public DbSet<TBL_OGRENCI> TBL_OGRENCIS { get; set; }
        public DbSet<TBL_SCHOOL_DURUMLARI> TBL_SCHOOL_DURUMLARIS { get; set; }
        public DbSet<TBL_SINIF> TBL_SINIFS { get; set; }
        public DbSet<TBL_TRY_CATCH> TBL_TRY_CATCHS { get; set; }
        public DbSet<TBL_VELI> TBL_VELIS { get; set; }
        public DbSet<TBL_YOKLAMA_HAREKETLERI> TBL_YOKLAMA_HAREKETLERIS { get; set; }


    }
}
