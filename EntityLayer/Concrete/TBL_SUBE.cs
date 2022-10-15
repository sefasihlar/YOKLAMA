using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_SUBE
    {
        [Key]
        public int SUBE_ID { get; set; }
        public string ADI { get; set; }
        public bool DURUM { get; set; }

        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }

        public string? OZEL_KOD { get; set; }



    }
}
