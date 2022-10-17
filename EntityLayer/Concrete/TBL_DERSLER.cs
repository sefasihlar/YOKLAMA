using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_DERSLER
    {
        [Key]
        public int DERSLER_ID { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI? SCHOOL { get; set; }

        public string? ADI { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }






    }
}
