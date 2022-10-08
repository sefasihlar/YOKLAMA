using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_DERSLER
    {
        [Key]
        public int DERSLER_ID { get; set; }

        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }

        public string? ADI { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }





    }
}
