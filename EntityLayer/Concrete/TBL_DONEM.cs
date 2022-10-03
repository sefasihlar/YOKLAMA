using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_DONEM
    {
        public int DONEM_ID { get; set; }
        public string ADI { get; set; }
        public DateTime TARIH { get; set; }
        public bool DURUM { get; set; }
        public int USER_ID { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual ICollection<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMI { get; set; }
        public virtual TBL_IDARI_PERSONEL TBL_IDARI_PERSONEL { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
        public virtual ICollection<TBL_OGRENCI> TBL_OGRENCI { get; set; }
        public virtual ICollection<TBL_YOKLAMA_HAREKETLERI> TBL_YOKLAMA_HAREKETLERI { get; set; }
    }
}
