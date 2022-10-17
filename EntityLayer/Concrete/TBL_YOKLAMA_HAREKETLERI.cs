using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_YOKLAMA_HAREKETLERI
    {
        [Key]
        public int YOKLAMA_HAREKETLERI_ID { get; set; }

        public virtual TBL_DERS_PROGRAMI? PROGRAM { get; set; }

        public virtual TBL_OGRENCI? OGRENCI { get; set; }

        public virtual TBL_DONEM? DONEM { get; set; }


        public virtual TBL_SCHOOL_DURUMLARI? SCHOOL { get; set; }

        public DateTime TARIH { get; set; }
        public DateTime SAAT { get; set; }
        public bool MESAJ_DURUM { get; set; }
        public bool EOKUL_DURUM { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }






    }
}
