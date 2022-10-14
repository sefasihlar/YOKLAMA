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


    }
}
