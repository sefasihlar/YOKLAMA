using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_SINIF
    {
        [Key]
        public int SINIF_ID { get; set; }
        public string? ADI { get; set; }
        public bool DURUM { get; set; }
        public TBL_SCHOOL_DURUMLARI? SCHOOL { get; set; }
        public string? OZEL_KOD { get; set; }


        public ICollection<TBL_DERS_PROGRAMI>? TBL_DERS_PROGRAMIS { get; set; }



    }
}
