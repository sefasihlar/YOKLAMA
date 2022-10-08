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
            optionsBuilder.UseSqlServer("server=CODECYBER\\SQLEXPRESS;database=DBYOKLAMA;integrated security=true");
        }

        public DbSet<TBL_BOLUM>? TBL_BOLUM { get; set; }
        public DbSet<TBL_DERS>?TBL_DERS{ get; set; }
        public DbSet<TBL_DERS_PROGRAMI>? TBL_DERS_PROGRAMI { get; set; }
        public DbSet<TBL_DERSLER>? TBL_DERSLER { get; set; }
        public DbSet<TBL_DONEM>? TBL_DONEM { get; set; }
        public DbSet<TBL_IDARI_PERSONEL>? TBL_IDARI_PERSONEL { get; set; }
        public DbSet<TBL_KURUM>? TBL_KURUM { get; set; }
        public DbSet<TBL_LOG>? TBL_LOG { get; set; }
        public DbSet<TBL_MESAJ_HAREKETLERI>? TBL_MESAJ_HAREKETLERI { get; set; }
        public DbSet<TBL_MESAJ_PATH>? TBL_MESAJ_PATH { get; set; }
        public DbSet<TBL_OGRENCI>? TBL_OGRENCI { get; set; }
        public DbSet<TBL_SCHOOL_DURUMLARI>? TBL_SCHOOL_DURUMLARI{ get; set; }
        public DbSet<TBL_SINIF>? TBL_SINIF { get; set; }
        public DbSet<TBL_TRY_CATCH>? TBL_TRY_CATCH { get; set; }
        public DbSet<TBL_VELI>? TBL_VELI { get; set; }
        public DbSet<TBL_YOKLAMA_HAREKETLERI>? TBL_YOKLAMA_HAREKETLERI { get; set; }

    }
}
