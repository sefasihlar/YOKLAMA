using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_YOKLAMA_HAREKETLERI
    {
        public int YOKLAMA_HAREKETLERI_ID { get; set; }
        public Nullable<int> DERS_PROGRAMI_ID { get; set; }
        public Nullable<int> OGRENCI_ID { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.TimeSpan> SAAT { get; set; }
        public Nullable<bool> MESAJ_DURUM { get; set; }
        public Nullable<bool> EOKUL_DURUM { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }
        public Nullable<int> DONEM_ID { get; set; }

        public virtual TBL_DERS_PROGRAMI TBL_DERS_PROGRAMI { get; set; }
        public virtual TBL_DONEM TBL_DONEM { get; set; }
        public virtual TBL_OGRENCI TBL_OGRENCI { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
    }
}
