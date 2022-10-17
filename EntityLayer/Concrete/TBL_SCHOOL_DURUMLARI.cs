using Microsoft.AspNetCore.Razor.Language;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TBL_SCHOOL_DURUMLARI
    {
        [Key]
        public int SCHOOL_ID { get; set; }
        public string? LISANS { get; set; }
        public string? OKUL_ADI { get; set; }
        public string? OKUL_MAIL { get; set; }
        public string? OKUL_TELOFON { get; set; }
        public string? OKUL_FAX { get; set; }
        public string? SORUMLU_YETKILI1 { get; set; }
        public string? SORUMLU_YETKILI_NUMARA1 { get; set; }
        public string? SORUMLU_YETKILI2 { get; set; }
        public string? SORUMLU_YETKILI_NUMARA2 { get; set; }
        public DateTime BASLAMA_TARIHI { get; set; }
        public DateTime BITIS_TARIHI { get; set; }
        public DateTime GUNCELLENEME_TARIHI { get; set; }
        public string? KURUM_KODU { get; set; }
        public bool DURUM { get; set; }

        public ICollection<TBL_DERSLER>? TBL_DERSLERS { get; set; }
        public ICollection<TBL_IDARI_PERSONEL>? TBL_IDARI_PERSONELS { get; set; }
        public ICollection<TBL_KURUM>? TBL_KURUMS { get; set; }

        public ICollection<TBL_LOG>? TBL_LOGS { get; set; }

        public ICollection<TBL_MESAJ_HAREKETLERI>? TBL_MESAJ_HAREKETLERIS { get; set; }

        public ICollection<TBL_MESAJ_PATH>? TBL_MESAJ_PATHS { get; set; }

        public ICollection<TBL_OGRENCI>? TBL_OGRENCIS { get; set; }
        public ICollection<TBL_SINIF>? TBL_SINIFS { get; set; }
        public ICollection<TBL_SUBE>? TBL_SUBES { get; set; }
        public ICollection<TBL_TRY_CATCH>? TBL_TRY_CATCHS { get; set; }

        public ICollection<TBL_VELI>? TBL_VELIS { get; set; }
        public ICollection<TBL_YOKLAMA_HAREKETLERI>? TBL_YOKLAMA_HAREKETLERIS { get; set; }
    }
}
