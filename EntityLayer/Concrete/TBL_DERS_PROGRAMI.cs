using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_DERS_PROGRAMI
    {
        [Key]
        public int DERS_PROGRAM_ID { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI? SCHOOL { get; set; }

        public virtual TBL_IDARI_PERSONEL? OGRETMEN { get; set; }
        public virtual TBL_DONEM? DONEM { get; set; }
        public virtual TBL_DERS? DERS { get; set; }

        public virtual TBL_SINIF? SINIF { get; set; }

        public virtual TBL_SUBE? SUBE { get; set; }

        public string? GUN { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }
        public DateTime TARIH { get; set; }
        public int USER_ID { get; set; }


        public ICollection<TBL_YOKLAMA_HAREKETLERI>? TBL_YOKLAMA_HAREKETLERIS { get; set; }

    }
}
