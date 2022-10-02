using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_DERS_PROGRAMI
    {
        public int DERS_PROGRAM_ID { get; set; }
        public int OGERETMEN_ID { get; set; }
        public int DERS_SAAT_ID { get; set; }
        public string GUN { get; set; }
        public int DONEM_ID { get; set; }
        public int DERS_ID { get; set; }
        public int SINIF_ID { get; set; }
        public int SUBE_ID { get; set; }
        public bool DURUM { get; set; }
        public string OZEL_KOD { get; set; }
        public DateTime TARIH { get; set; }
        public int USER_ID { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD1 { get; set; }

        public virtual TBL_DERS TBL_DERS { get; set; }
        public virtual TBL_DERSLER TBL_DERSLER { get; set; }
        public virtual TBL_DONEM TBL_DONEM { get; set; }
        public virtual TBL_IDARI_PERSONEL TBL_IDARI_PERSONEL { get; set; }
        public virtual TBL_IDARI_PERSONEL TBL_IDARI_PERSONEL1 { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
        public virtual TBL_SINIF TBL_SINIF { get; set; }
        public virtual TBL_SUBE TBL_SUBE { get; set; }
        public virtual ICollection<TBL_YOKLAMA_HAREKETLERI> TBL_YOKLAMA_HAREKETLERI { get; set; }
    }
}
