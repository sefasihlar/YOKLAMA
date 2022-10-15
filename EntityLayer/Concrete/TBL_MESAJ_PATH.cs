using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{

    public class TBL_MESAJ_PATH
    {
        [Key]
        public int MESAJ_PATH_ID { get; set; }
        public String? FIRMA_ADI { get; set; }
        public String? API { get; set; }
        public String? API_KEY { get; set; }
        public String? SENDER { get; set; }
        public String? CHARSET { get; set; }
        public bool DURUM { get; set; }
        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }
        public String? OZEL_KOD { get; set; }





    }
}
