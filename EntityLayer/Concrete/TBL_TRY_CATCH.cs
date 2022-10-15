using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_TRY_CATCH
    {
        [Key]
        public int TRY_CATCH_ID { get; set; }
        public string ERROR { get; set; }
        public DateTime DATE { get; set; }
        public DateTime TIME { get; set; }
        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }
        public string OZEL_KOD { get; set; }
        public string ISLEM { get; set; }
        public bool DURUM { get; set; }

    }
}
