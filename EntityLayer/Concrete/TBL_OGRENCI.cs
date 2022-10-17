using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_OGRENCI
    {
        [Key]
        public int OGRENCI_ID { get; set; }
        public string? VATADANDAS_NO { get; set; }
        public string? OKUL_NO { get; set; }
        public string? ADI { get; set; }
        public string? SOYADI { get; set; }
        public string? SINIF { get; set; }
        public string? SUBE { get; set; }
        public string? TELEFON { get; set; }
        public string? MAIL { get; set; }
        public DateTime TARIH { get; set; }
        public bool DURUM { get; set; }
        public int USER_ID { get; set; }
        public string? OZEL_KOD { get; set; }

        public virtual TBL_BOLUM? BOLUM { get; set; }

        public virtual TBL_DONEM? DONEM { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI? SCHOOL { get; set; }


        public ICollection<TBL_VELI>? TBL_VELIS { get; set; }
        public ICollection<TBL_YOKLAMA_HAREKETLERI>? TBL_YOKLAMA_HAREKETLERIS { get; set; }


    }
}
