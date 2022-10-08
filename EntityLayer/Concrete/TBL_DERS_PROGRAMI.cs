using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_DERS_PROGRAMI
    {
        [Key]
        public int DERS_PROGRAM_ID { get; set; }

        [ForeignKey("TBL_DERSLER")]
        public int DERS_SAAT_ID { get; set; }
        public virtual TBL_DERSLER? TBL_DERSLER { get; set; }

        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }

        [ForeignKey("TBL_IDARI_PERSONEL")]
        public int OGERETMEN_ID { get; set; }
        public virtual TBL_IDARI_PERSONEL? TBL_IDARI_PERSONEL { get; set; }
        
        [ForeignKey("TBL_DONEM")]
        public int DONEM_ID { get; set; }
        public virtual TBL_DONEM? TBL_DONEM { get; set; }

        [ForeignKey("TBL_DERS")]
        public int DERS_ID { get; set; }
        public virtual  TBL_DERS? TBL_DERS { get; set; }

        [ForeignKey("TBL_SINIF")]
        public int SINIF_ID { get; set; }
        public virtual TBL_SINIF? TBL_SINIF { get; set; }

        [ForeignKey("TBL_SUBE")]
        public int SUBE_ID { get; set; }
        public virtual TBL_SUBE? TBL_SUBE { get; set; }

        public string? GUN { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }
        public DateTime TARIH { get; set; }
        public int USER_ID { get; set; }

    }
}
