using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_MESAJ_HAREKETLERI
    {
        [Key]
        public int MESAJ_ID { get; set; }
        public string? KULLANICI_TURU { get; set; }
        public int KULLANICI_ID { get; set; }
        public string? MESAJ { get; set; }
        public DateTime TARIH { get; set; }
        public DateTime SAAT { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }
        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }
        public int USER_ID { get; set; }




    }
}
