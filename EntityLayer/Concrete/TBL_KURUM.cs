using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_KURUM
    {
        [Key]
        public int KURUM_ID { get; set; }
        public string? KURUM_ADI { get; set; }
        public string? KURUM_LISANS { get; set; }
        public string? KURUM_LOGO { get; set; }
        public int AKTIF_DONEM { get; set; }
        public bool DURUM { get; set; }

        public TBL_SCHOOL_DURUMLARI? SCHOOL { get; set; }
        public string? OZEL_KOD { get; set; }




    }
}
