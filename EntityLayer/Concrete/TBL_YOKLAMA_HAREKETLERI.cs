using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_YOKLAMA_HAREKETLERI
    {
        [Key]
        public int YOKLAMA_HAREKETLERI_ID { get; set; }

        [ForeignKey("TBL_DERS_PROGRAMI")]
        public int DERS_PROGRAMI_ID { get; set; }
        public virtual TBL_DERS_PROGRAMI? TBL_DERS_PROGRAMI { get; set; }

        [ForeignKey("TBL_OGRENCI")]
        public int OGRENCI_ID { get; set; }
        public virtual TBL_OGRENCI? TBL_OGRENCI { get; set; }

        [ForeignKey("TBL_DONEM")]
        public int DONEM_ID { get; set; }
        public virtual TBL_DONEM? TBL_DONEM { get; set; }


        [ForeignKey("TBL_SCHOOL_DURUMLARI")]
        public int SCHOOL_ID { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI? TBL_SCHOOL_DURUMLARI { get; set; }

        public DateTime TARIH { get; set; }
        public DateTime SAAT { get; set; }
        public bool MESAJ_DURUM { get; set; }
        public bool EOKUL_DURUM { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }

     




    }
}
