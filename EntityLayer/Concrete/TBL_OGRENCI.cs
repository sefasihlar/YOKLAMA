using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_OGRENCI
    {
        [Key]
        public int OGRENCI_ID { get; set; }
        public string? VATADANDAS_NO { get; set; }
        public string? OKUL_NO { get; set; }
        public string? ADI { get; set; }
        public string? SOYADI { get; set; }
        public string? SINIF { get; set; }
        public string? SUBE { get; set; }
        public string? TELEFON { get; set; }
        public string? MAIL { get; set; }
        public DateTime TARIH { get; set; }
        public bool DURUM { get; set; }
        public int USER_ID { get; set; }
        public string? OZEL_KOD { get; set; }


        [ForeignKey("TBL_BOLUM")]
        public int BOLUM_ID { get; set; }
        public virtual TBL_BOLUM? TBL_BOLUM { get; set; }

        [ForeignKey("TBL_DONEM")]
        public int DONEM_ID { get; set; }
        public virtual TBL_DONEM?  TBL_DONEM{ get; set; }

        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }


    }
}
